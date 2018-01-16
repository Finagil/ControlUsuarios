Public Class FrmModulos
    Private Sub FrmModulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SISTEMATableAdapter.Fill(Me.SeguridadDS.SISTEMA)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If TxtMod.Text.Trim = "" Then
            MessageBox.Show("Nombre de módulo No valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Me.MODULOSTableAdapter.ValidaNombre(TxtMod.Text) > 0 Then
            MessageBox.Show("Nombre de módulo existente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Me.MODULOSTableAdapter.Insert(Me.MODULOSTableAdapter.SacaID, TxtMod.Text.ToUpper, CmbSist.SelectedValue, "")
        Me.MODULOSTableAdapter.Fill(Me.SeguridadDS.MODULOS, CmbSist.SelectedValue)
        TxtMod.Clear()
    End Sub

    Private Sub CmbSist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSist.SelectedIndexChanged
        If CmbSist.SelectedIndex >= 0 Then
            Me.MODULOSTableAdapter.Fill(Me.SeguridadDS.MODULOS, CmbSist.SelectedValue)
        End If
    End Sub

    Private Sub GridMods_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles GridMods.UserDeletingRow
        If Me.MODULOSTableAdapter.TieneDatos(e.Row.Cells(1).Value) > 0 Then
            MessageBox.Show("Este módulo no puede ser Eliminado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
        End If
    End Sub

    Private Sub GridMods_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles GridMods.UserDeletedRow
        Me.MODULOSTableAdapter.Update(Me.SeguridadDS.MODULOS)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Me.MODULOSTableAdapter.Update(Me.SeguridadDS.MODULOS)
    End Sub

End Class