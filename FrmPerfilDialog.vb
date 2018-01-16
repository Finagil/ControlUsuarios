Public Class FrmPerfilDialog
    Public Modulo As String
    Public Sistema As String
    Public idSistema As String
    Public User As String
    Private Sub FrmPerfilDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.VW_PerfilTableAdapter.Fill(SeguridadDS.VW_Perfil, Sistema, Modulo)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ta As New SeguridadDSTableAdapters.VW_UsuariosPerfilTableAdapter
        ta.InsertaPerfilUsuario(User, idSistema, CmbPerf.SelectedValue)
    End Sub

    Private Sub CmbPerf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPerf.SelectedIndexChanged
        If CmbPerf.SelectedIndex >= 0 Then
            Me.SEG_MAESTRATableAdapter.Fill(SeguridadDS.SEG_MAESTRA, CmbPerf.SelectedValue, Sistema, Modulo)
        End If
    End Sub
End Class