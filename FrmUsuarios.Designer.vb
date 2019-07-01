<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
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
        Me.CmbUser = New System.Windows.Forms.ComboBox()
        Me.USUARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeguridadDS = New ControlUsuarios.SeguridadDS()
        Me.USUARIOSTableAdapter = New ControlUsuarios.SeguridadDSTableAdapters.USUARIOSTableAdapter()
        Me.SUCURSALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SUCURSALTableAdapter = New ControlUsuarios.SeguridadDSTableAdapters.SUCURSALTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboJefe = New System.Windows.Forms.ComboBox()
        Me.USUARIOSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeguridadDS1 = New ControlUsuarios.SeguridadDS()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CmbSucursal = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ChkBloq = New System.Windows.Forms.CheckBox()
        Me.CmbEdo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateCaducidad = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateIngreso = New System.Windows.Forms.DateTimePicker()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtAma = New System.Windows.Forms.TextBox()
        Me.TxtApa = New System.Windows.Forms.TextBox()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnPWD = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.ComboDepto = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Deptop_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DEPTOTableAdapter = New ControlUsuarios.SeguridadDSTableAdapters.DEPTOTableAdapter()
        CType(Me.USUARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeguridadDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUCURSALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.USUARIOSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeguridadDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Deptop_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuarios"
        '
        'CmbUser
        '
        Me.CmbUser.DataSource = Me.USUARIOSBindingSource
        Me.CmbUser.DisplayMember = "Nom"
        Me.CmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUser.FormattingEnabled = True
        Me.CmbUser.Location = New System.Drawing.Point(16, 30)
        Me.CmbUser.Name = "CmbUser"
        Me.CmbUser.Size = New System.Drawing.Size(273, 21)
        Me.CmbUser.TabIndex = 1
        Me.CmbUser.ValueMember = "cve_empleado"
        '
        'USUARIOSBindingSource
        '
        Me.USUARIOSBindingSource.DataMember = "USUARIOS"
        Me.USUARIOSBindingSource.DataSource = Me.SeguridadDS
        '
        'SeguridadDS
        '
        Me.SeguridadDS.DataSetName = "SeguridadDS"
        Me.SeguridadDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'USUARIOSTableAdapter
        '
        Me.USUARIOSTableAdapter.ClearBeforeFill = True
        '
        'SUCURSALBindingSource
        '
        Me.SUCURSALBindingSource.DataMember = "SUCURSAL"
        Me.SUCURSALBindingSource.DataSource = Me.SeguridadDS
        '
        'SUCURSALTableAdapter
        '
        Me.SUCURSALTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboDepto)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.ComboJefe)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TxtUser)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.CmbSucursal)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.ChkBloq)
        Me.GroupBox1.Controls.Add(Me.CmbEdo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.DateCaducidad)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DateIngreso)
        Me.GroupBox1.Controls.Add(Me.TxtMail)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtAma)
        Me.GroupBox1.Controls.Add(Me.TxtApa)
        Me.GroupBox1.Controls.Add(Me.TxtNom)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 196)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Usuario"
        '
        'ComboJefe
        '
        Me.ComboJefe.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.USUARIOSBindingSource, "jefe", True))
        Me.ComboJefe.DataSource = Me.USUARIOSBindingSource1
        Me.ComboJefe.DisplayMember = "Nom"
        Me.ComboJefe.FormattingEnabled = True
        Me.ComboJefe.Location = New System.Drawing.Point(17, 167)
        Me.ComboJefe.Name = "ComboJefe"
        Me.ComboJefe.Size = New System.Drawing.Size(273, 21)
        Me.ComboJefe.TabIndex = 28
        Me.ComboJefe.ValueMember = "cve_empleado"
        '
        'USUARIOSBindingSource1
        '
        Me.USUARIOSBindingSource1.DataMember = "USUARIOS"
        Me.USUARIOSBindingSource1.DataSource = Me.SeguridadDS1
        '
        'SeguridadDS1
        '
        Me.SeguridadDS1.DataSetName = "SeguridadDS"
        Me.SeguridadDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 150)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Jefe"
        '
        'TxtUser
        '
        Me.TxtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtUser.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOSBindingSource, "id_usuario", True))
        Me.TxtUser.Location = New System.Drawing.Point(420, 125)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(128, 20)
        Me.TxtUser.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(417, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Usuario"
        '
        'CmbSucursal
        '
        Me.CmbSucursal.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.USUARIOSBindingSource, "id_sucursal", True))
        Me.CmbSucursal.DataSource = Me.SUCURSALBindingSource
        Me.CmbSucursal.DisplayMember = "nom_sucursal"
        Me.CmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSucursal.FormattingEnabled = True
        Me.CmbSucursal.Location = New System.Drawing.Point(249, 125)
        Me.CmbSucursal.Name = "CmbSucursal"
        Me.CmbSucursal.Size = New System.Drawing.Size(165, 21)
        Me.CmbSucursal.TabIndex = 36
        Me.CmbSucursal.ValueMember = "id_sucursal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(246, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Sucursal"
        '
        'ChkBloq
        '
        Me.ChkBloq.AutoSize = True
        Me.ChkBloq.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.USUARIOSBindingSource, "Bloqueo", True))
        Me.ChkBloq.Location = New System.Drawing.Point(152, 125)
        Me.ChkBloq.Name = "ChkBloq"
        Me.ChkBloq.Size = New System.Drawing.Size(77, 17)
        Me.ChkBloq.TabIndex = 34
        Me.ChkBloq.Text = "Bloqueado"
        Me.ChkBloq.UseVisualStyleBackColor = True
        '
        'CmbEdo
        '
        Me.CmbEdo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOSBindingSource, "estado", True))
        Me.CmbEdo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbEdo.FormattingEnabled = True
        Me.CmbEdo.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.CmbEdo.Location = New System.Drawing.Point(17, 122)
        Me.CmbEdo.Name = "CmbEdo"
        Me.CmbEdo.Size = New System.Drawing.Size(121, 21)
        Me.CmbEdo.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Estado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(417, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Fecha Caducidad"
        '
        'DateCaducidad
        '
        Me.DateCaducidad.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.USUARIOSBindingSource, "FechaCaducidad", True))
        Me.DateCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateCaducidad.Location = New System.Drawing.Point(420, 82)
        Me.DateCaducidad.Name = "DateCaducidad"
        Me.DateCaducidad.Size = New System.Drawing.Size(121, 20)
        Me.DateCaducidad.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(290, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Fecha Ingreso"
        '
        'DateIngreso
        '
        Me.DateIngreso.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.USUARIOSBindingSource, "fecha_ingreso", True))
        Me.DateIngreso.Enabled = False
        Me.DateIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateIngreso.Location = New System.Drawing.Point(293, 82)
        Me.DateIngreso.Name = "DateIngreso"
        Me.DateIngreso.Size = New System.Drawing.Size(121, 20)
        Me.DateIngreso.TabIndex = 28
        '
        'TxtMail
        '
        Me.TxtMail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOSBindingSource, "correo", True))
        Me.TxtMail.Location = New System.Drawing.Point(17, 82)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(270, 20)
        Me.TxtMail.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Correo"
        '
        'TxtAma
        '
        Me.TxtAma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAma.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOSBindingSource, "ape_mat", True))
        Me.TxtAma.Location = New System.Drawing.Point(376, 38)
        Me.TxtAma.Name = "TxtAma"
        Me.TxtAma.Size = New System.Drawing.Size(172, 20)
        Me.TxtAma.TabIndex = 25
        '
        'TxtApa
        '
        Me.TxtApa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOSBindingSource, "ape_pat", True))
        Me.TxtApa.Location = New System.Drawing.Point(198, 39)
        Me.TxtApa.Name = "TxtApa"
        Me.TxtApa.Size = New System.Drawing.Size(172, 20)
        Me.TxtApa.TabIndex = 24
        '
        'TxtNom
        '
        Me.TxtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOSBindingSource, "nombre", True))
        Me.TxtNom.Location = New System.Drawing.Point(17, 39)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(172, 20)
        Me.TxtNom.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(373, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Apellido Materno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(195, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Apellido Paterno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nombre"
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(508, 259)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 21
        Me.BtnSave.Text = "Guardar"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.Location = New System.Drawing.Point(12, 259)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(75, 23)
        Me.BtnNew.TabIndex = 22
        Me.BtnNew.Text = "Nuevo Usuario"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'BtnPWD
        '
        Me.BtnPWD.Location = New System.Drawing.Point(415, 259)
        Me.BtnPWD.Name = "BtnPWD"
        Me.BtnPWD.Size = New System.Drawing.Size(85, 23)
        Me.BtnPWD.TabIndex = 23
        Me.BtnPWD.Text = "Cambiar PWD"
        Me.BtnPWD.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(305, 259)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Borrar Perfiles"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(457, 34)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(60, 17)
        Me.RadioButton1.TabIndex = 25
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Activos"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(523, 34)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(68, 17)
        Me.RadioButton2.TabIndex = 26
        Me.RadioButton2.Text = "Inactivos"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'ComboDepto
        '
        Me.ComboDepto.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.USUARIOSBindingSource, "id_depto", True))
        Me.ComboDepto.DataSource = Me.Deptop_BindingSource
        Me.ComboDepto.DisplayMember = "nom_depto"
        Me.ComboDepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboDepto.FormattingEnabled = True
        Me.ComboDepto.Location = New System.Drawing.Point(296, 167)
        Me.ComboDepto.Name = "ComboDepto"
        Me.ComboDepto.Size = New System.Drawing.Size(252, 21)
        Me.ComboDepto.TabIndex = 40
        Me.ComboDepto.ValueMember = "id_depto"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(293, 150)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Departamento"
        '
        'Deptop_BindingSource
        '
        Me.Deptop_BindingSource.DataMember = "DEPTO"
        Me.Deptop_BindingSource.DataSource = Me.SeguridadDS1
        '
        'DEPTOTableAdapter
        '
        Me.DEPTOTableAdapter.ClearBeforeFill = True
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 288)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnPWD)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CmbUser)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmUsuarios"
        Me.Text = "Captura de Usuarios"
        CType(Me.USUARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeguridadDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUCURSALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.USUARIOSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeguridadDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Deptop_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CmbUser As ComboBox
    Friend WithEvents SeguridadDS As SeguridadDS
    Friend WithEvents USUARIOSBindingSource As BindingSource
    Friend WithEvents USUARIOSTableAdapter As SeguridadDSTableAdapters.USUARIOSTableAdapter
    Friend WithEvents SUCURSALBindingSource As BindingSource
    Friend WithEvents SUCURSALTableAdapter As SeguridadDSTableAdapters.SUCURSALTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CmbSucursal As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ChkBloq As CheckBox
    Friend WithEvents CmbEdo As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateCaducidad As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents DateIngreso As DateTimePicker
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtAma As TextBox
    Friend WithEvents TxtApa As TextBox
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnNew As Button
    Friend WithEvents BtnPWD As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents ComboJefe As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents SeguridadDS1 As SeguridadDS
    Friend WithEvents USUARIOSBindingSource1 As BindingSource
    Friend WithEvents ComboDepto As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Deptop_BindingSource As BindingSource
    Friend WithEvents DEPTOTableAdapter As SeguridadDSTableAdapters.DEPTOTableAdapter
End Class
