Public Class FrmSetup
    Private Sub FrmSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SISTEMATableAdapter.Fill(Me.SeguridadDS.SISTEMA)
    End Sub

    Private Sub CmbSist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSist.SelectedIndexChanged
        If CmbSist.SelectedIndex >= 0 Then
            Me.VW_ModuloTableAdapter.Fill(Me.SeguridadDS.VW_Modulo, CmbSist.Text)
            CmbMod_SelectedIndexChanged(Nothing, Nothing)
        Else
            Me.SeguridadDS.VW_Modulo.Clear()
            Me.SeguridadDS.VW_Perfil.Clear()
            Me.SeguridadDS.VW_UsuariosPerfil.Clear()
            Me.SeguridadDS.SEG_MAESTRA.Clear()
        End If
    End Sub

    Private Sub CmbMod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMod.SelectedIndexChanged
        If CmbMod.SelectedIndex >= 0 Then
            Me.VW_PerfilTableAdapter.Fill(Me.SeguridadDS.VW_Perfil, CmbSist.Text, CmbMod.SelectedValue)
            CmbPerf_SelectedIndexChanged(Nothing, Nothing)
        Else
            Me.SeguridadDS.VW_Perfil.Clear()
            Me.SeguridadDS.VW_UsuariosPerfil.Clear()
            Me.SeguridadDS.SEG_MAESTRA.Clear()
        End If
    End Sub

    Private Sub CmbPerf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPerf.SelectedIndexChanged
        If CmbPerf.SelectedIndex >= 0 Then
            Me.SEG_MAESTRATableAdapter.Fill(Me.SeguridadDS.SEG_MAESTRA, CmbPerf.SelectedValue, CmbSist.Text, CmbMod.SelectedValue)
            Me.VW_UsuariosPerfilTableAdapter.Fill(Me.SeguridadDS.VW_UsuariosPerfil, CmbSist.SelectedValue, CmbPerf.SelectedValue, CmbMod.SelectedValue)
        Else
            Me.SeguridadDS.VW_UsuariosPerfil.Clear()
            Me.SeguridadDS.SEG_MAESTRA.Clear()
        End If
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        If ListBox1.SelectedIndex >= 0 Then
            If MessageBox.Show("Desea borrar al usuario " & ListBox1.Text, "Borrar Usuario de Perfil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.VW_UsuariosPerfilTableAdapter.DeletePerfiles(ListBox1.SelectedValue, CmbPerf.Text, CmbSist.SelectedValue)
                Me.VW_UsuariosPerfilTableAdapter.Fill(Me.SeguridadDS.VW_UsuariosPerfil, CmbSist.SelectedValue, CmbPerf.SelectedValue, CmbMod.SelectedValue)
            End If
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Me.SEG_MAESTRATableAdapter.Update(Me.SeguridadDS.SEG_MAESTRA)
    End Sub

    Private Sub DataGridView1_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridView1.UserAddedRow
        SEGMAESTRABindingSource.Current("cve_perfil") = CmbPerf.SelectedValue
        SEGMAESTRABindingSource.Current("nom_sistema") = CmbSist.Text
        SEGMAESTRABindingSource.Current("modulo") = CmbMod.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("¿Esta seguro de Borraro los perfiles de usuarios inactivos?", "Borrar Perfiles", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            For Each r As SeguridadDS.VW_UsuariosPerfilRow In Me.SeguridadDS.VW_UsuariosPerfil.Rows
                If r.estado = "Inactivo" Then
                    Me.VW_UsuariosPerfilTableAdapter.DeletePerfiles(r.cve_empleado, CmbPerf.Text, CmbSist.SelectedValue)
                End If
            Next
            Me.VW_UsuariosPerfilTableAdapter.Fill(Me.SeguridadDS.VW_UsuariosPerfil, CmbSist.SelectedValue, CmbPerf.SelectedValue, CmbMod.SelectedValue)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim User As String = InputBox("Dame el ID del usuario", "Alta de Usuario", "Usuario")
        Dim id As Double = Me.VW_UsuariosPerfilTableAdapter.SacaID_Usuario(User)
        If id = 0 Then
            MessageBox.Show("El usuario no existe ó esta incativo", "Error de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim ta As New SeguridadDSTableAdapters.VW_UsuariosPerfilTableAdapter
            ta.InsertaPerfilUsuario(id, CmbSist.SelectedValue, CmbPerf.SelectedValue)
            Me.VW_UsuariosPerfilTableAdapter.Fill(Me.SeguridadDS.VW_UsuariosPerfil, CmbSist.SelectedValue, CmbPerf.SelectedValue, CmbMod.SelectedValue)
        End If
    End Sub

End Class