<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPerfiles
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
        Me.CmbSist = New System.Windows.Forms.ComboBox()
        Me.SISTEMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeguridadDS = New ControlUsuarios.SeguridadDS()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MODULOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CveEmpresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CveperfilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdsistemaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PERFILESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TxtPerfil = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SISTEMATableAdapter = New ControlUsuarios.SeguridadDSTableAdapters.SISTEMATableAdapter()
        Me.MODULOSTableAdapter = New ControlUsuarios.SeguridadDSTableAdapters.MODULOSTableAdapter()
        Me.PERFILESTableAdapter = New ControlUsuarios.SeguridadDSTableAdapters.PERFILESTableAdapter()
        CType(Me.SISTEMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeguridadDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MODULOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERFILESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbSist
        '
        Me.CmbSist.DataSource = Me.SISTEMABindingSource
        Me.CmbSist.DisplayMember = "nom_sistema"
        Me.CmbSist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSist.FormattingEnabled = True
        Me.CmbSist.Location = New System.Drawing.Point(12, 25)
        Me.CmbSist.Name = "CmbSist"
        Me.CmbSist.Size = New System.Drawing.Size(213, 21)
        Me.CmbSist.TabIndex = 3
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sistemas"
        '
        'MODULOSBindingSource
        '
        Me.MODULOSBindingSource.DataMember = "MODULOS"
        Me.MODULOSBindingSource.DataSource = Me.SeguridadDS
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CveEmpresaDataGridViewTextBoxColumn, Me.CveperfilDataGridViewTextBoxColumn, Me.IdsistemaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PERFILESBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(398, 251)
        Me.DataGridView1.TabIndex = 6
        '
        'CveEmpresaDataGridViewTextBoxColumn
        '
        Me.CveEmpresaDataGridViewTextBoxColumn.DataPropertyName = "CveEmpresa"
        Me.CveEmpresaDataGridViewTextBoxColumn.HeaderText = "CveEmpresa"
        Me.CveEmpresaDataGridViewTextBoxColumn.Name = "CveEmpresaDataGridViewTextBoxColumn"
        Me.CveEmpresaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CveEmpresaDataGridViewTextBoxColumn.Visible = False
        '
        'CveperfilDataGridViewTextBoxColumn
        '
        Me.CveperfilDataGridViewTextBoxColumn.DataPropertyName = "cve_perfil"
        Me.CveperfilDataGridViewTextBoxColumn.HeaderText = "Nombre Perfil"
        Me.CveperfilDataGridViewTextBoxColumn.Name = "CveperfilDataGridViewTextBoxColumn"
        Me.CveperfilDataGridViewTextBoxColumn.ReadOnly = True
        Me.CveperfilDataGridViewTextBoxColumn.Width = 200
        '
        'IdsistemaDataGridViewTextBoxColumn
        '
        Me.IdsistemaDataGridViewTextBoxColumn.DataPropertyName = "id_sistema"
        Me.IdsistemaDataGridViewTextBoxColumn.HeaderText = "id_sistema"
        Me.IdsistemaDataGridViewTextBoxColumn.Name = "IdsistemaDataGridViewTextBoxColumn"
        Me.IdsistemaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdsistemaDataGridViewTextBoxColumn.Visible = False
        '
        'PERFILESBindingSource
        '
        Me.PERFILESBindingSource.DataMember = "PERFILES"
        Me.PERFILESBindingSource.DataSource = Me.SeguridadDS
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(330, 309)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(80, 23)
        Me.BtnSave.TabIndex = 10
        Me.BtnSave.Text = "Guardar"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(232, 322)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(80, 23)
        Me.BtnAdd.TabIndex = 9
        Me.BtnAdd.Text = "Agregar Perf."
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TxtPerfil
        '
        Me.TxtPerfil.Location = New System.Drawing.Point(13, 324)
        Me.TxtPerfil.Name = "TxtPerfil"
        Me.TxtPerfil.Size = New System.Drawing.Size(213, 20)
        Me.TxtPerfil.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 307)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nuevo Perfil"
        '
        'SISTEMATableAdapter
        '
        Me.SISTEMATableAdapter.ClearBeforeFill = True
        '
        'MODULOSTableAdapter
        '
        Me.MODULOSTableAdapter.ClearBeforeFill = True
        '
        'PERFILESTableAdapter
        '
        Me.PERFILESTableAdapter.ClearBeforeFill = True
        '
        'FrmPerfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 579)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TxtPerfil)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CmbSist)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmPerfiles"
        Me.Text = "Catálogo de Perfiles"
        Me.TopMost = True
        CType(Me.SISTEMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeguridadDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MODULOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERFILESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbSist As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents TxtPerfil As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SeguridadDS As SeguridadDS
    Friend WithEvents SISTEMABindingSource As BindingSource
    Friend WithEvents SISTEMATableAdapter As SeguridadDSTableAdapters.SISTEMATableAdapter
    Friend WithEvents MODULOSBindingSource As BindingSource
    Friend WithEvents MODULOSTableAdapter As SeguridadDSTableAdapters.MODULOSTableAdapter
    Friend WithEvents PERFILESBindingSource As BindingSource
    Friend WithEvents PERFILESTableAdapter As SeguridadDSTableAdapters.PERFILESTableAdapter
    Friend WithEvents CveEmpresaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CveperfilDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdsistemaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
