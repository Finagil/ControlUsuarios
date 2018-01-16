Public Class FrmSistemas
    Private Sub FrmSistemas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SISTEMATableAdapter.Fill(Me.SeguridadDS.SISTEMA)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If TxtSist.Text.Trim = "" Then
            MessageBox.Show("Nombre de sistema No valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Me.SISTEMATableAdapter.ValidaNombre(TxtSist.Text) > 0 Then
            MessageBox.Show("Nombre de sistema existente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Me.SISTEMATableAdapter.Insert(Me.SISTEMATableAdapter.SacaID, TxtSist.Text.ToUpper)
        Me.SISTEMATableAdapter.Fill(Me.SeguridadDS.SISTEMA)
        TxtSist.Clear()
    End Sub

    Private Sub DataGridView1_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DataGridView1.UserDeletingRow
        If Me.SISTEMATableAdapter.TieneDatos(e.Row.Cells(0).Value) > 0 Then
            MessageBox.Show("Este sistema no puede ser Eliminado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
        End If
    End Sub

    Private Sub DataGridView1_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridView1.UserDeletedRow
        Me.SISTEMATableAdapter.Update(Me.SeguridadDS.SISTEMA)
    End Sub
End Class