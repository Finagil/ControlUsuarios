<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPerfilDialog
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
        Me.CmbPerf = New System.Windows.Forms.ComboBox()
        Me.VWPerfilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeguridadDS = New ControlUsuarios.SeguridadDS()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.VW_PerfilTableAdapter = New ControlUsuarios.SeguridadDSTableAdapters.VW_PerfilTableAdapter()
        Me.SEG_MAESTRATableAdapter = New ControlUsuarios.SeguridadDSTableAdapters.SEG_MAESTRATableAdapter()
        CType(Me.VWPerfilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeguridadDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEGMAESTRABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbPerf
        '
        Me.CmbPerf.DataSource = Me.VWPerfilBindingSource
        Me.CmbPerf.DisplayMember = "cve_perfil"
        Me.CmbPerf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPerf.FormattingEnabled = True
        Me.CmbPerf.Location = New System.Drawing.Point(12, 27)
        Me.CmbPerf.Name = "CmbPerf"
        Me.CmbPerf.Size = New System.Drawing.Size(254, 21)
        Me.CmbPerf.TabIndex = 7
        Me.CmbPerf.ValueMember = "cve_perfil"
        '
        'VWPerfilBindingSource
        '
        Me.VWPerfilBindingSource.DataMember = "VW_Perfil"
        Me.VWPerfilBindingSource.DataSource = Me.SeguridadDS
        '
        'SeguridadDS
        '
        Me.SeguridadDS.DataSetName = "SeguridadDS"
        Me.SeguridadDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Perfil"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdSegDataGridViewTextBoxColumn, Me.CveperfilDataGridViewTextBoxColumn, Me.NomsistemaDataGridViewTextBoxColumn, Me.ModuloDataGridViewTextBoxColumn, Me.CvemenuDataGridViewTextBoxColumn, Me.CvesubmenuDataGridViewTextBoxColumn, Me.CvessubmenuDataGridViewTextBoxColumn, Me.CvesssubmenuDataGridViewTextBoxColumn, Me.MenuDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SEGMAESTRABindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(540, 256)
        Me.DataGridView1.TabIndex = 8
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
        Me.CveperfilDataGridViewTextBoxColumn.ReadOnly = True
        Me.CveperfilDataGridViewTextBoxColumn.Visible = False
        '
        'NomsistemaDataGridViewTextBoxColumn
        '
        Me.NomsistemaDataGridViewTextBoxColumn.DataPropertyName = "nom_sistema"
        Me.NomsistemaDataGridViewTextBoxColumn.HeaderText = "nom_sistema"
        Me.NomsistemaDataGridViewTextBoxColumn.Name = "NomsistemaDataGridViewTextBoxColumn"
        Me.NomsistemaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomsistemaDataGridViewTextBoxColumn.Visible = False
        '
        'ModuloDataGridViewTextBoxColumn
        '
        Me.ModuloDataGridViewTextBoxColumn.DataPropertyName = "modulo"
        Me.ModuloDataGridViewTextBoxColumn.HeaderText = "modulo"
        Me.ModuloDataGridViewTextBoxColumn.Name = "ModuloDataGridViewTextBoxColumn"
        Me.ModuloDataGridViewTextBoxColumn.ReadOnly = True
        Me.ModuloDataGridViewTextBoxColumn.Visible = False
        '
        'CvemenuDataGridViewTextBoxColumn
        '
        Me.CvemenuDataGridViewTextBoxColumn.DataPropertyName = "cve_menu"
        Me.CvemenuDataGridViewTextBoxColumn.HeaderText = "N1"
        Me.CvemenuDataGridViewTextBoxColumn.Name = "CvemenuDataGridViewTextBoxColumn"
        Me.CvemenuDataGridViewTextBoxColumn.ReadOnly = True
        Me.CvemenuDataGridViewTextBoxColumn.Width = 25
        '
        'CvesubmenuDataGridViewTextBoxColumn
        '
        Me.CvesubmenuDataGridViewTextBoxColumn.DataPropertyName = "cve_submenu"
        Me.CvesubmenuDataGridViewTextBoxColumn.HeaderText = "N2"
        Me.CvesubmenuDataGridViewTextBoxColumn.Name = "CvesubmenuDataGridViewTextBoxColumn"
        Me.CvesubmenuDataGridViewTextBoxColumn.ReadOnly = True
        Me.CvesubmenuDataGridViewTextBoxColumn.Width = 25
        '
        'CvessubmenuDataGridViewTextBoxColumn
        '
        Me.CvessubmenuDataGridViewTextBoxColumn.DataPropertyName = "cve_ssubmenu"
        Me.CvessubmenuDataGridViewTextBoxColumn.HeaderText = "N3"
        Me.CvessubmenuDataGridViewTextBoxColumn.Name = "CvessubmenuDataGridViewTextBoxColumn"
        Me.CvessubmenuDataGridViewTextBoxColumn.ReadOnly = True
        Me.CvessubmenuDataGridViewTextBoxColumn.Width = 25
        '
        'CvesssubmenuDataGridViewTextBoxColumn
        '
        Me.CvesssubmenuDataGridViewTextBoxColumn.DataPropertyName = "cve_sssubmenu"
        Me.CvesssubmenuDataGridViewTextBoxColumn.HeaderText = "N4"
        Me.CvesssubmenuDataGridViewTextBoxColumn.Name = "CvesssubmenuDataGridViewTextBoxColumn"
        Me.CvesssubmenuDataGridViewTextBoxColumn.ReadOnly = True
        Me.CvesssubmenuDataGridViewTextBoxColumn.Width = 25
        '
        'MenuDataGridViewTextBoxColumn
        '
        Me.MenuDataGridViewTextBoxColumn.DataPropertyName = "menu"
        Me.MenuDataGridViewTextBoxColumn.HeaderText = "Menu"
        Me.MenuDataGridViewTextBoxColumn.Name = "MenuDataGridViewTextBoxColumn"
        Me.MenuDataGridViewTextBoxColumn.ReadOnly = True
        Me.MenuDataGridViewTextBoxColumn.Width = 380
        '
        'SEGMAESTRABindingSource
        '
        Me.SEGMAESTRABindingSource.DataMember = "SEG_MAESTRA"
        Me.SEGMAESTRABindingSource.DataSource = Me.SeguridadDS
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button1.Location = New System.Drawing.Point(396, 316)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(477, 316)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'VW_PerfilTableAdapter
        '
        Me.VW_PerfilTableAdapter.ClearBeforeFill = True
        '
        'SEG_MAESTRATableAdapter
        '
        Me.SEG_MAESTRATableAdapter.ClearBeforeFill = True
        '
        'FrmPerfilDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 349)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CmbPerf)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FrmPerfilDialog"
        Me.Text = "Perfiles"
        CType(Me.VWPerfilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeguridadDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEGMAESTRABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbPerf As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents VWPerfilBindingSource As BindingSource
    Friend WithEvents SeguridadDS As SeguridadDS
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdSegDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CveperfilDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomsistemaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CvemenuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CvesubmenuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CvessubmenuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CvesssubmenuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SEGMAESTRABindingSource As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents VW_PerfilTableAdapter As SeguridadDSTableAdapters.VW_PerfilTableAdapter
    Friend WithEvents SEG_MAESTRATableAdapter As SeguridadDSTableAdapters.SEG_MAESTRATableAdapter
End Class
