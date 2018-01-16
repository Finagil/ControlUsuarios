Public Class FrmPerfiles
    Private Sub FrmPerfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SISTEMATableAdapter.Fill(Me.SeguridadDS.SISTEMA)
    End Sub

    Private Sub CmbSist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSist.SelectedIndexChanged
        If CmbSist.SelectedIndex >= 0 Then
            Me.PERFILESTableAdapter.Fill(Me.SeguridadDS.PERFILES, CmbSist.SelectedValue)
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If TxtPerfil.Text.Trim = "" Then
            MessageBox.Show("Nombre de perfil No valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Me.PERFILESTableAdapter.ValidaNombre(TxtPerfil.Text) > 0 Then
            MessageBox.Show("Nombre de perfil existente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Me.PERFILESTableAdapter.Insert(1, TxtPerfil.Text.ToUpper, CmbSist.SelectedValue)
        Me.PERFILESTableAdapter.Fill(Me.SeguridadDS.PERFILES, CmbSist.SelectedValue)
        TxtPerfil.Clear()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Me.PERFILESTableAdapter.Update(Me.SeguridadDS.PERFILES)
    End Sub

    Private Sub DataGridView1_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridView1.UserDeletedRow
        Me.PERFILESTableAdapter.Update(Me.SeguridadDS.PERFILES)
    End Sub

    Private Sub DataGridView1_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DataGridView1.UserDeletingRow
        If Me.PERFILESTableAdapter.TieneDatos(e.Row.Cells(1).Value) > 0 Then
            MessageBox.Show("Este perfil no puede ser Eliminado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
        End If
    End Sub
End Class