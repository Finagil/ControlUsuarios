Public Class FrmSetupM
    Private Sub FrmSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SISTEMATableAdapter.Fill(Me.SeguridadDS.SISTEMA)
    End Sub

    Private Sub CmbSist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSist.SelectedIndexChanged
        If CmbSist.SelectedIndex >= 0 Then
            Me.VW_ModuloTableAdapter.Fill(Me.SeguridadDS.VW_Modulo, CmbSist.Text)
            CmbMod_SelectedIndexChanged(Nothing, Nothing)
        Else
            Me.SeguridadDS.VW_Modulo.Clear()
            Me.SeguridadDS.VW_UsuariosPerfil.Clear()
            Me.SeguridadDS.VW_Perfil.Clear()
            Me.SeguridadDS.SEG_MAESTRA.Clear()
        End If
    End Sub

    Private Sub CmbMod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMod.SelectedIndexChanged
        If CmbMod.SelectedIndex >= 0 Then
            Me.VW_UsuariosPerfilTableAdapter.FillBySistema(Me.SeguridadDS.VW_UsuariosPerfil, CmbMod.SelectedValue, CmbSist.SelectedValue)
            CmbUser_SelectedIndexChanged(Nothing, Nothing)
        Else
            Me.SeguridadDS.VW_UsuariosPerfil.Clear()
            Me.SeguridadDS.VW_Perfil.Clear()
            Me.SeguridadDS.SEG_MAESTRA.Clear()
        End If
    End Sub

    Private Sub CmbUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUser.SelectedIndexChanged
        If CmbUser.SelectedIndex >= 0 Then
            Me.VW_PerfilTableAdapter.FillByUsuario(Me.SeguridadDS.VW_Perfil, CmbSist.Text, CmbMod.SelectedValue, CmbUser.SelectedValue)
            ListPerfiles_SelectedIndexChanged(Nothing, Nothing)
        Else
            Me.SeguridadDS.VW_Perfil.Clear()
            Me.SeguridadDS.SEG_MAESTRA.Clear()
        End If
    End Sub

    Private Sub ListPerfiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListPerfiles.SelectedIndexChanged
        If ListPerfiles.SelectedIndex >= 0 Then
            Me.SEG_MAESTRATableAdapter.Fill(Me.SeguridadDS.SEG_MAESTRA, ListPerfiles.SelectedValue, CmbSist.Text, CmbMod.SelectedValue)
        Else
            Me.SeguridadDS.SEG_MAESTRA.Clear()
        End If
    End Sub

    Private Sub ListPerfiles_DoubleClick(sender As Object, e As EventArgs) Handles ListPerfiles.DoubleClick
        If ListPerfiles.SelectedIndex >= 0 Then
            If MessageBox.Show("Desea borrar el perfil  " & ListPerfiles.Text & " del usuario " & CmbUser.Text, "Borrar Perfil de usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.VW_UsuariosPerfilTableAdapter.DeletePerfiles(CmbUser.SelectedValue, ListPerfiles.Text, CmbSist.SelectedValue)
                Me.VW_PerfilTableAdapter.FillByUsuario(Me.SeguridadDS.VW_Perfil, CmbSist.Text, CmbMod.SelectedValue, CmbUser.SelectedValue)
                ListPerfiles_SelectedIndexChanged(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New FrmPerfilDialog
        f.Sistema = CmbSist.Text
        f.idSistema = CmbSist.SelectedValue
        f.Modulo = CmbMod.SelectedValue
        f.User = CmbUser.SelectedValue
        f.ShowDialog()
        If f.DialogResult = DialogResult.OK Then
            CmbUser_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub
End Class