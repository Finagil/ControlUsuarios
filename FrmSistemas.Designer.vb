<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSistemas
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdsistemaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomsistemaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SISTEMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeguridadDS = New ControlUsuarios.SeguridadDS()
        Me.SISTEMATableAdapter = New ControlUsuarios.SeguridadDSTableAdapters.SISTEMATableAdapter()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSist = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SISTEMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeguridadDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdsistemaDataGridViewTextBoxColumn, Me.NomsistemaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SISTEMABindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(362, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'IdsistemaDataGridViewTextBoxColumn
        '
        Me.IdsistemaDataGridViewTextBoxColumn.DataPropertyName = "id_sistema"
        Me.IdsistemaDataGridViewTextBoxColumn.HeaderText = "id_sistema"
        Me.IdsistemaDataGridViewTextBoxColumn.Name = "IdsistemaDataGridViewTextBoxColumn"
        Me.IdsistemaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdsistemaDataGridViewTextBoxColumn.Visible = False
        '
        'NomsistemaDataGridViewTextBoxColumn
        '
        Me.NomsistemaDataGridViewTextBoxColumn.DataPropertyName = "nom_sistema"
        Me.NomsistemaDataGridViewTextBoxColumn.HeaderText = "Nombre Sistema"
        Me.NomsistemaDataGridViewTextBoxColumn.Name = "NomsistemaDataGridViewTextBoxColumn"
        Me.NomsistemaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomsistemaDataGridViewTextBoxColumn.Width = 300
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
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(231, 183)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 1
        Me.BtnAdd.Text = "Agregar Sist."
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nuevo Sistema"
        '
        'TxtSist
        '
        Me.TxtSist.Location = New System.Drawing.Point(16, 186)
        Me.TxtSist.Name = "TxtSist"
        Me.TxtSist.Size = New System.Drawing.Size(209, 20)
        Me.TxtSist.TabIndex = 3
        '
        'FrmSistemas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 718)
        Me.Controls.Add(Me.TxtSist)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmSistemas"
        Me.Text = "Catálogo de Sistemas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SISTEMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeguridadDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SeguridadDS As SeguridadDS
    Friend WithEvents SISTEMABindingSource As BindingSource
    Friend WithEvents SISTEMATableAdapter As SeguridadDSTableAdapters.SISTEMATableAdapter
    Friend WithEvents IdsistemaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomsistemaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BtnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSist As TextBox
End Class
