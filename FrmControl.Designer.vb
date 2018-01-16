<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMDI
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuMDI = New System.Windows.Forms.MenuStrip()
        Me.SistemasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MódulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerfilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuMDI.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuMDI
        '
        Me.MenuMDI.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemasToolStripMenuItem, Me.MódulosToolStripMenuItem, Me.PerfilesToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.MenuSetupToolStripMenuItem, Me.UsuarioMenuToolStripMenuItem})
        Me.MenuMDI.Location = New System.Drawing.Point(0, 0)
        Me.MenuMDI.Name = "MenuMDI"
        Me.MenuMDI.Size = New System.Drawing.Size(1082, 24)
        Me.MenuMDI.TabIndex = 0
        Me.MenuMDI.Text = "MenuStrip1"
        '
        'SistemasToolStripMenuItem
        '
        Me.SistemasToolStripMenuItem.Name = "SistemasToolStripMenuItem"
        Me.SistemasToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.SistemasToolStripMenuItem.Text = "Sistemas"
        '
        'MódulosToolStripMenuItem
        '
        Me.MódulosToolStripMenuItem.Name = "MódulosToolStripMenuItem"
        Me.MódulosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.MódulosToolStripMenuItem.Text = "Módulos"
        '
        'PerfilesToolStripMenuItem
        '
        Me.PerfilesToolStripMenuItem.Name = "PerfilesToolStripMenuItem"
        Me.PerfilesToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.PerfilesToolStripMenuItem.Text = "Perfiles"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'MenuSetupToolStripMenuItem
        '
        Me.MenuSetupToolStripMenuItem.Name = "MenuSetupToolStripMenuItem"
        Me.MenuSetupToolStripMenuItem.Size = New System.Drawing.Size(145, 20)
        Me.MenuSetupToolStripMenuItem.Text = "Configuración de Menu"
        '
        'UsuarioMenuToolStripMenuItem
        '
        Me.UsuarioMenuToolStripMenuItem.Name = "UsuarioMenuToolStripMenuItem"
        Me.UsuarioMenuToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.UsuarioMenuToolStripMenuItem.Text = "Usuario-Menu"
        '
        'FrmMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 593)
        Me.Controls.Add(Me.MenuMDI)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuMDI
        Me.Name = "FrmMDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Usuarios Finagil"
        Me.MenuMDI.ResumeLayout(False)
        Me.MenuMDI.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuMDI As MenuStrip
    Friend WithEvents PerfilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SistemasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MódulosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuarioMenuToolStripMenuItem As ToolStripMenuItem
End Class
