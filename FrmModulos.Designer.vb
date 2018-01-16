<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModulos
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
        Me.SISTEMATableAdapter = New ControlUsuarios.SeguridadDSTableAdapters.SISTEMATableAdapter()
        Me.GridMods = New System.Windows.Forms.DataGridView()
        Me.CvemodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NommodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdsistemaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RutaAplicacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODULOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MODULOSTableAdapter = New ControlUsuarios.SeguridadDSTableAdapters.MODULOSTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMod = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        CType(Me.SISTEMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeguridadDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridMods, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MODULOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sistemas"
        '
        'CmbSist
        '
        Me.CmbSist.DataSource = Me.SISTEMABindingSource
        Me.CmbSist.DisplayMember = "nom_sistema"
        Me.CmbSist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSist.FormattingEnabled = True
        Me.CmbSist.Location = New System.Drawing.Point(16, 30)
        Me.CmbSist.Name = "CmbSist"
        Me.CmbSist.Size = New System.Drawing.Size(213, 21)
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
        'SISTEMATableAdapter
        '
        Me.SISTEMATableAdapter.ClearBeforeFill = True
        '
        'GridMods
        '
        Me.GridMods.AllowUserToAddRows = False
        Me.GridMods.AutoGenerateColumns = False
        Me.GridMods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridMods.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CvemodDataGridViewTextBoxColumn, Me.NommodDataGridViewTextBoxColumn, Me.IdsistemaDataGridViewTextBoxColumn, Me.RutaAplicacionDataGridViewTextBoxColumn})
        Me.GridMods.DataSource = Me.MODULOSBindingSource
        Me.GridMods.Location = New System.Drawing.Point(16, 58)
        Me.GridMods.Name = "GridMods"
        Me.GridMods.Size = New System.Drawing.Size(752, 314)
        Me.GridMods.TabIndex = 2
        '
        'CvemodDataGridViewTextBoxColumn
        '
        Me.CvemodDataGridViewTextBoxColumn.DataPropertyName = "cve_mod"
        Me.CvemodDataGridViewTextBoxColumn.HeaderText = "cve_mod"
        Me.CvemodDataGridViewTextBoxColumn.Name = "CvemodDataGridViewTextBoxColumn"
        Me.CvemodDataGridViewTextBoxColumn.Visible = False
        Me.CvemodDataGridViewTextBoxColumn.Width = 200
        '
        'NommodDataGridViewTextBoxColumn
        '
        Me.NommodDataGridViewTextBoxColumn.DataPropertyName = "nom_mod"
        Me.NommodDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NommodDataGridViewTextBoxColumn.Name = "NommodDataGridViewTextBoxColumn"
        Me.NommodDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdsistemaDataGridViewTextBoxColumn
        '
        Me.IdsistemaDataGridViewTextBoxColumn.DataPropertyName = "id_sistema"
        Me.IdsistemaDataGridViewTextBoxColumn.HeaderText = "id_sistema"
        Me.IdsistemaDataGridViewTextBoxColumn.Name = "IdsistemaDataGridViewTextBoxColumn"
        Me.IdsistemaDataGridViewTextBoxColumn.Visible = False
        '
        'RutaAplicacionDataGridViewTextBoxColumn
        '
        Me.RutaAplicacionDataGridViewTextBoxColumn.DataPropertyName = "RutaAplicacion"
        Me.RutaAplicacionDataGridViewTextBoxColumn.HeaderText = "Ruta Aplicación"
        Me.RutaAplicacionDataGridViewTextBoxColumn.Name = "RutaAplicacionDataGridViewTextBoxColumn"
        Me.RutaAplicacionDataGridViewTextBoxColumn.Width = 600
        '
        'MODULOSBindingSource
        '
        Me.MODULOSBindingSource.DataMember = "MODULOS"
        Me.MODULOSBindingSource.DataSource = Me.SeguridadDS
        '
        'MODULOSTableAdapter
        '
        Me.MODULOSTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 375)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nuevo Módulo"
        '
        'TxtMod
        '
        Me.TxtMod.Location = New System.Drawing.Point(16, 392)
        Me.TxtMod.Name = "TxtMod"
        Me.TxtMod.Size = New System.Drawing.Size(213, 20)
        Me.TxtMod.TabIndex = 4
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(235, 390)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(80, 23)
        Me.BtnAdd.TabIndex = 5
        Me.BtnAdd.Text = "Agregar Mod."
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(688, 378)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(80, 23)
        Me.BtnSave.TabIndex = 6
        Me.BtnSave.Text = "Guardar"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FrmModulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 492)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TxtMod)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GridMods)
        Me.Controls.Add(Me.CmbSist)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmModulos"
        Me.Text = "Catálogo de Módulos"
        CType(Me.SISTEMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeguridadDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridMods, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MODULOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CmbSist As ComboBox
    Friend WithEvents SeguridadDS As SeguridadDS
    Friend WithEvents SISTEMABindingSource As BindingSource
    Friend WithEvents SISTEMATableAdapter As SeguridadDSTableAdapters.SISTEMATableAdapter
    Friend WithEvents GridMods As DataGridView
    Friend WithEvents MODULOSBindingSource As BindingSource
    Friend WithEvents MODULOSTableAdapter As SeguridadDSTableAdapters.MODULOSTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtMod As TextBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents CvemodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NommodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdsistemaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RutaAplicacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
