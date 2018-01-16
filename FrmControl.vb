Public Class FrmMDI
    Private Sub FrmMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim Arg() As String
        'Arg = Environment.GetCommandLineArgs()
        'If Arg.Count = 1 Then
        '    MessageBox.Show("No tienes Permiso para abrir esta aplicación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End
        'ElseIf Arg(1) <> "AbCdE" Then
        '    MessageBox.Show("Argumento Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End
        'End If
    End Sub

    Private Sub PerfilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerfilesToolStripMenuItem.Click
        Call New FrmPerfiles With {.MdiParent = Me, .WindowState = FormWindowState.Maximized, .ClientSize = Me.ClientSize}.Show()
    End Sub

    Private Sub SistemasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SistemasToolStripMenuItem.Click
        Call New FrmSistemas With {.MdiParent = Me, .WindowState = FormWindowState.Maximized, .ClientSize = Me.ClientSize}.Show()
    End Sub

    Private Sub MódulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MódulosToolStripMenuItem.Click
        Call New FrmModulos With {.MdiParent = Me, .WindowState = FormWindowState.Maximized, .ClientSize = Me.ClientSize}.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Call New FrmUsuarios With {.MdiParent = Me, .WindowState = FormWindowState.Maximized, .ClientSize = Me.ClientSize}.Show()
    End Sub

    Private Sub MenuSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuSetupToolStripMenuItem.Click
        Call New FrmSetup With {.MdiParent = Me, .WindowState = FormWindowState.Maximized, .ClientSize = Me.ClientSize}.Show()
    End Sub

    Private Sub UsuarioMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioMenuToolStripMenuItem.Click
        Call New FrmSetupM With {.MdiParent = Me, .WindowState = FormWindowState.Maximized, .ClientSize = Me.ClientSize}.Show()
    End Sub
End Class
