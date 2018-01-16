<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSetup
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbSist = New System.Windows.Forms.ComboBox()
        Me.SISTEMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeguridadDS = New ControlUsuarios.SeguridadDS()
        Me.CmbMod = New System.Windows.Forms.ComboBox()
        Me.VWModuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbPerf = New System.Windows.Forms.ComboBox()
        Me.VWPerfilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SISTEMATableAdapter = New ControlUsuarios.SeguridadDSTableAdapters.SISTEMATableAdapter()
        Me.VW_ModuloTableAdapter = New ControlUsuarios.SeguridadDSTableAdapters.VW_ModuloTableAdapter()
        Me.VW_PerfilTableAdapter = New ControlUsuarios.SeguridadDSTableAdapters.VW_PerfilTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdSegDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CveperfilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomsistemaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CvemenuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CvesubmenuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CvessubmenuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CvesssubmenuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEGMAESTRABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SEG_MAESTRATableAdapter = New ControlUsuarios.SeguridadDSTableAdapters.SEG_MAESTRATableAdapter()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.VWUsuariosPerfilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.VW_UsuariosPerfilTableAdapter = New ControlUsuarios.SeguridadDSTableAdapters.VW_UsuariosPerfilTableAdapter()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.SISTEMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeguridadDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWModuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWPerfilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEGMAESTRABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWUsuariosPerfilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sistema"
        '
        'CmbSist
        '
        Me.CmbSist.DataSource = Me.SISTEMABindingSource
        Me.CmbSist.DisplayMember = "nom_sistema"
        Me.CmbSist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSist.FormattingEnabled = True
        Me.CmbSist.Location = New System.Drawing.Point(15, 26)
        Me.CmbSist.Name = "CmbSist"
        Me.CmbSist.Size = New System.Drawing.Size(152, 21)
        Me.CmbSist.TabIndex = 1
        Me.CmbSist.ValueMember = "id_sistema"
        '
        'SISTEMABindingSource
        '
        Me.SISTEMABindingSource.DataMember = "SISTEMA"
        Me.SISTEMABindingSource.DataSource = Me.SeguridadDS
        '
        'SeguridadDS
        '
        Me.SeguridadDS.DataSetName = "SeguridadDS"
        Me.SeguridadDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CmbMod
        '
        Me.CmbMod.DataSource = Me.VWModuloBindingSource
        Me.CmbMod.DisplayMember = "modulo"
        Me.CmbMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMod.FormattingEnabled = True
        Me.CmbMod.Location = New System.Drawing.Point(173, 26)
        Me.CmbMod.Name = "CmbMod"
        Me.CmbMod.Size = New System.Drawing.Size(152, 21)
        Me.CmbMod.TabIndex = 3
        Me.CmbMod.ValueMember = "modulo"
        '
        'VWModuloBindingSource
        '
        Me.VWModuloBindingSource.DataMember = "VW_Modulo"
        Me.VWModuloBindingSource.DataSource = Me.SeguridadDS
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Módulo"
        '
        'CmbPerf
        '
        Me.CmbPerf.DataSource = Me.VWPerfilBindingSource
        Me.CmbPerf.DisplayMember = "cve_perfil"
        Me.CmbPerf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPerf.FormattingEnabled = True
        Me.CmbPerf.Location = New System.Drawing.Point(331, 26)
        Me.CmbPerf.Name = "CmbPerf"
        Me.CmbPerf.Size = New System.Drawing.Size(152, 21)
        Me.CmbPerf.TabIndex = 5
        Me.CmbPerf.ValueMember = "cve_perfil"
        '
        'VWPerfilBindingSource
        '
        Me.VWPerfilBindingSource.DataMember = "VW_Perfil"
        Me.VWPerfilBindingSource.DataSource = Me.SeguridadDS
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(328, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Perfil"
        '
        'SISTEMATableAdapter
        '
        Me.SISTEMATableAdapter.ClearBeforeFill = True
        '
        'VW_ModuloTableAdapter
        '
        Me.VW_ModuloTableAdapter.ClearBeforeFill = True
        '
        'VW_PerfilTableAdapter
        '
        Me.VW_PerfilTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdSegDataGridViewTextBoxColumn, Me.CveperfilDataGridViewTextBoxColumn, Me.NomsistemaDataGridViewTextBoxColumn, Me.ModuloDataGridViewTextBoxColumn, Me.CvemenuDataGridViewTextBoxColumn, Me.CvesubmenuDataGridViewTextBoxColumn, Me.CvessubmenuDataGridViewTextBoxColumn, Me.CvesssubmenuDataGridViewTextBoxColumn, Me.MenuDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SEGMAESTRABindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(753, 441)
        Me.DataGridView1.TabIndex = 6
        '
        'IdSegDataGridViewTextBoxColumn
        '
        Me.IdSegDataGridViewTextBoxColumn.DataPropertyName = "IdSeg"
        Me.IdSegDataGridViewTextBoxColumn.HeaderText = "IdSeg"
        Me.IdSegDataGridViewTextBoxColumn.Name = "IdSegDataGridViewTextBoxColumn"
        Me.IdSegDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdSegDataGridViewTextBoxColumn.Visible = False
        '
        'CveperfilDataGridViewTextBoxColumn
        '
        Me.CveperfilDataGridViewTextBoxColumn.DataPropertyName = "cve_perfil"
        Me.CveperfilDataGridViewTextBoxColumn.HeaderText = "cve_perfil"
        Me.CveperfilDataGridViewTextBoxColumn.Name = "CveperfilDataGridViewTextBoxColumn"
        Me.CveperfilDataGridViewTextBoxColumn.Visible = False
        '
        'NomsistemaDataGridViewTextBoxColumn
        '
        Me.NomsistemaDataGridViewTextBoxColumn.DataPropertyName = "nom_sistema"
        Me.NomsistemaDataGridViewTextBoxColumn.HeaderText = "nom_sistema"
        Me.NomsistemaDataGridViewTextBoxColumn.Name = "NomsistemaDataGridViewTextBoxColumn"
        Me.NomsistemaDataGridViewTextBoxColumn.Visible = False
        '
        'ModuloDataGridViewTextBoxColumn
        '
        Me.ModuloDataGridViewTextBoxColumn.DataPropertyName = "modulo"
        Me.ModuloDataGridViewTextBoxColumn.HeaderText = "modulo"
        Me.ModuloDataGridViewTextBoxColumn.Name = "ModuloDataGridViewTextBoxColumn"
        Me.ModuloDataGridViewTextBoxColumn.Visible = False
        '
        'CvemenuDataGridViewTextBoxColumn
        '
        Me.CvemenuDataGridViewTextBoxColumn.DataPropertyName = "cve_menu"
        Me.CvemenuDataGridViewTextBoxColumn.HeaderText = "Nivel 0"
        Me.CvemenuDataGridViewTextBoxColumn.Name = "CvemenuDataGridViewTextBoxColumn"
        Me.CvemenuDataGridViewTextBoxColumn.Width = 50
        '
        'CvesubmenuDataGridViewTextBoxColumn
        '
        Me.CvesubmenuDataGridViewTextBoxColumn.DataPropertyName = "cve_submenu"
        Me.CvesubmenuDataGridViewTextBoxColumn.HeaderText = "Nivel 1"
        Me.CvesubmenuDataGridViewTextBoxColumn.Name = "CvesubmenuDataGridViewTextBoxColumn"
        Me.CvesubmenuDataGridViewTextBoxColumn.Width = 50
        '
        'CvessubmenuDataGridViewTextBoxColumn
        '
        Me.CvessubmenuDataGridViewTextBoxColumn.DataPropertyName = "cve_ssubmenu"
        Me.CvessubmenuDataGridViewTextBoxColumn.HeaderText = "Nivel 2"
        Me.CvessubmenuDataGridViewTextBoxColumn.Name = "CvessubmenuDataGridViewTextBoxColumn"
        Me.CvessubmenuDataGridViewTextBoxColumn.Width = 50
        '
        'CvesssubmenuDataGridViewTextBoxColumn
        '
        Me.CvesssubmenuDataGridViewTextBoxColumn.DataPropertyName = "cve_sssubmenu"
        Me.CvesssubmenuDataGridViewTextBoxColumn.HeaderText = "Nivel 3"
        Me.CvesssubmenuDataGridViewTextBoxColumn.Name = "CvesssubmenuDataGridViewTextBoxColumn"
        Me.CvesssubmenuDataGridViewTextBoxColumn.Width = 50
        '
        'MenuDataGridViewTextBoxColumn
        '
        Me.MenuDataGridViewTextBoxColumn.DataPropertyName = "menu"
        Me.MenuDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.MenuDataGridViewTextBoxColumn.Name = "MenuDataGridViewTextBoxColumn"
        Me.MenuDataGridViewTextBoxColumn.Width = 500
        '
        'SEGMAESTRABindingSource
        '
        Me.SEGMAESTRABindingSource.DataMember = "SEG_MAESTRA"
        Me.SEGMAESTRABindingSource.DataSource = Me.SeguridadDS
        '
        'SEG_MAESTRATableAdapter
        '
        Me.SEG_MAESTRATableAdapter.ClearBeforeFill = True
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.VWUsuariosPerfilBindingSource
        Me.ListBox1.DisplayMember = "Usuario"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(775, 54)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(222, 446)
        Me.ListBox1.TabIndex = 7
        Me.ListBox1.ValueMember = "cve_empleado"
        '
        'VWUsuariosPerfilBindingSource
        '
        Me.VWUsuariosPerfilBindingSource.DataMember = "VW_UsuariosPerfil"
        Me.VWUsuariosPerfilBindingSource.DataSource = Me.SeguridadDS
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(772, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Usuarios (doble click para eliminar)"
        '
        'VW_UsuariosPerfilTableAdapter
        '
        Me.VW_UsuariosPerfilTableAdapter.ClearBeforeFill = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(688, 501)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(80, 23)
        Me.BtnSave.TabIndex = 9
        Me.BtnSave.Text = "Guardar"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(898, 501)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Borrar Inactivos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(775, 501)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Agrega Usuario"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 525)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CmbPerf)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbMod)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbSist)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmSetup"
        Me.Text = "Configuración de Menu"
        CType(Me.SISTEMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeguridadDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWModuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWPerfilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEGMAESTRABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWUsuariosPerfilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CmbSist As ComboBox
    Friend WithEvents CmbMod As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbPerf As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SeguridadDS As SeguridadDS
    Friend WithEvents SISTEMABindingSource As BindingSource
    Friend WithEvents SISTEMATableAdapter As SeguridadDSTableAdapters.SISTEMATableAdapter
    Friend WithEvents VWModuloBindingSource As BindingSource
    Friend WithEvents VWPerfilBindingSource As BindingSource
    Friend WithEvents VW_ModuloTableAdapter As SeguridadDSTableAdapters.VW_ModuloTableAdapter
    Friend WithEvents VW_PerfilTableAdapter As SeguridadDSTableAdapters.VW_PerfilTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SEGMAESTRABindingSource As BindingSource
    Friend WithEvents SEG_MAESTRATableAdapter As SeguridadDSTableAdapters.SEG_MAESTRATableAdapter
    Friend WithEvents IdSegDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CveperfilDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomsistemaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CvemenuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CvesubmenuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CvessubmenuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CvesssubmenuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents VWUsuariosPerfilBindingSource As BindingSource
    Friend WithEvents Label4 As Label
    Friend WithEvents VW_UsuariosPerfilTableAdapter As SeguridadDSTableAdapters.VW_UsuariosPerfilTableAdapter
    Friend WithEvents BtnSave As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
