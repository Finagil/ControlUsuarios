Imports System.Security.Cryptography
Imports System.Text
Public Class FrmUsuarios
    Dim Nuevo As Boolean = False
    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SeguridadDS1.DEPTO' Puede moverla o quitarla según sea necesario.
        Me.DEPTOTableAdapter.Fill(Me.SeguridadDS1.DEPTO)
        Me.SUCURSALTableAdapter.Fill(Me.SeguridadDS.SUCURSAL)
        Me.USUARIOSTableAdapter.Fill(Me.SeguridadDS.USUARIOS)
        Me.USUARIOSTableAdapter.Fill(Me.SeguridadDS1.USUARIOS)
        RadioButton1_CheckedChanged(Nothing, Nothing)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If TxtUser.Text = "" Then
            MessageBox.Show("Usuario no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        USUARIOSBindingSource.EndEdit()
        Me.USUARIOSTableAdapter.Update(Me.SeguridadDS.USUARIOS)

        If Nuevo = True Then
            Dim CN As New SqlClient.SqlConnection(My.MySettings.Default.ProductionConnectionString())
            Dim NewPWD As String = Genera_Pass(8, "", False, True, True, False, False, False)
            Dim SQL As New SqlClient.SqlCommand
            NewPWD = InputBox("Dame la nueva Contraseña", "Alta de Contraseña", NewPWD)
            If NewPWD <> "" Then
                NewPWD = getMd5Hash(NewPWD)
                Me.USUARIOSTableAdapter.ChangePWD(NewPWD, CmbUser.SelectedValue, CmbUser.SelectedValue)
                SQL.Connection = Me.USUARIOSTableAdapter.Connection
                SQL.Connection.Open()
                SQL.CommandText = "CREATE LOGIN [" & TxtUser.Text & "] WITH PASSWORD = '" & NewPWD & "';"
                SQL.ExecuteNonQuery()
                SQL.CommandText = "CREATE USER [" & TxtUser.Text & "] FOR LOGIN [" & TxtUser.Text & "];"
                SQL.ExecuteNonQuery()
                SQL.CommandText = "EXEC sp_addrolemember 'db_datareader', '" & TxtUser.Text & "';"
                SQL.ExecuteNonQuery()
                SQL.Connection.Close()
                'PRODUCTION
                SQL.Connection = CN
                SQL.Connection.Open()
                SQL.CommandText = "CREATE USER [" & TxtUser.Text & "] FOR LOGIN [" & TxtUser.Text & "];"
                SQL.ExecuteNonQuery()
                SQL.CommandText = "EXEC sp_addrolemember 'db_owner', '" & TxtUser.Text & "';"
                SQL.ExecuteNonQuery()
                SQL.Connection.Close()
            End If
        End If

        Nuevo = False
        BtnNew.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        USUARIOSBindingSource.AddNew()
        USUARIOSBindingSource.Current("cve_empleado") = Me.USUARIOSTableAdapter.SacaID
        USUARIOSBindingSource.Current("Estado") = "Activo"
        USUARIOSBindingSource.Current("Bloqueo") = False
        USUARIOSBindingSource.Current("id_sucursal") = "TOL"
        USUARIOSBindingSource.Current("Autorizar") = False
        DateIngreso.Value = Date.Now
        DateCaducidad.Value = Date.Now.AddMonths(6)
        USUARIOSBindingSource.Current("fecha_ingreso") = Date.Now
        USUARIOSBindingSource.Current("FechaCaducidad") = Date.Now.AddMonths(6)
        Nuevo = True
        BtnNew.Enabled = False
        TxtNom.Focus()
    End Sub

    Private Sub BtnPWD_Click(sender As Object, e As EventArgs) Handles BtnPWD.Click
        Dim NewPWD As String = Genera_Pass(8, "", False, True, True, False, False, False)
        'Dim SQL As New SqlClient.SqlCommand
        NewPWD = InputBox("Dame la nueva Contraseña", "Cambio de Contraseña", NewPWD)
        If NewPWD <> "" Then
            NewPWD = getMd5Hash(NewPWD)
            Me.USUARIOSTableAdapter.ChangePWD(NewPWD, CmbUser.SelectedValue, CmbUser.SelectedValue)
            'SQL.CommandText = "ALTER LOGIN [" & TxtUser.Text & "] WITH PASSWORD = '" & NewPWD & "';"
            'Sql.Connection = Me.USUARIOSTableAdapter.Connection
            'Sql.Connection.Open()
            'Sql.ExecuteNonQuery()
            'Sql.Connection.Close()
            MessageBox.Show("Cambio de contraseña exitoso", "Cambio de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Function Genera_Pass(Longitud As Byte, Optional MiCadena As String = "", Optional Codigo_ansii As Boolean = False,
Optional Numeros As Boolean = False, Optional Minusculas As Boolean = False, Optional Mayusculas As _
Boolean = False, Optional Especiales As Boolean = False, Optional bRepetir As Boolean = True)
        'Longitud = Parametro para SAber de cuantos caracteres se hara el pass
        'MiCadena = PArametro para trabajar con los caracteres seleccionados por el usuario
        'Codigo_ansi = Parametro para trabajar con todos los caracteres
        'Numeros,Minusculas,Mayusculas,Especiales = PArametros para armar la cadena con lo que seleccione el usuario
        Const sNum = "1234567890"
        Const sMin = "abcdefghijklmnopqrstuvwxyz"
        Const sMay = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Const sEsp = "[]{}!¡¿?#$%&/()"
        Dim sIn As String = "" 'Variable para armar la contraseña
        Dim sFi As String 'Variable para armar la cadena sobre la que se va a sacar la contraseña
        Dim i As Integer 'Variable para los bucles
        Dim iRan As Integer 'Variable para saber la posicion de donde vamos a sacar el caracter
        Dim iCadFin As Integer 'Variable para saber la longitud de la cadena armada
        Try

            sFi = "" 'Iniciamos la variable por si las dudas
            If MiCadena = "" Then 'Si esta es diferente entonces ya no arma nada
                If Codigo_ansii = True Then 'Si se escoge el codigo ansi como verdadero entonces ya no checa nada mas
                    For i = 33 To 126 'Bucle para armar la cadena con los caracteres ascii del 33 al 126
                        sFi = sFi & Chr(i)
                    Next
                Else
                    'Las siguientes condiciones son para armar la cadena segun las opciones seleccionadas
                    If Numeros = True Then sFi = sFi & sNum
                    If Minusculas = True Then sFi = sFi & sMin
                    If Mayusculas = True Then sFi = sFi & sMay
                    If Especiales = True Then sFi = sFi & sEsp
                End If
            Else
                sFi = MiCadena
            End If


            iCadFin = Len(sFi) 'Aqui se sabe la logitud de la cadena final
            If bRepetir = False Then
                If Longitud > iCadFin Then Longitud = iCadFin
            End If
            If iCadFin = 0 Or Longitud < 1 Then 'Si la cadena final es "" lo longitud es menor de 1 entonces Pone mi Alias JeJe ;-)
                Genera_Pass = "ZiTrO" : Exit Function
            End If
            For i = 1 To Longitud 'Bucle para hacer el pass con la longitud seleccionada
                Randomize() 'Empieza la funcion de numeros aleatorios
                Do
                    iRan = Math.Round(Rnd(iCadFin) * iCadFin, 0) 'Aqui generamos la posicion aleatoria de un numero valido dentro de la cadena de caracteres
                Loop While iRan = 0 'Si el azar nos da 0 lo volvemos a hacer, por que en el mid nos daria error el 0
                sIn = sIn & Mid(sFi, iRan, 1) 'Aqui ya obtenemos el caracter y lo concatenamos con el anterior
                If bRepetir = False Then
                    sFi = Replace(sFi, Mid(sFi, iRan, 1), "")
                    iCadFin = iCadFin - 1
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(Err.Number & " " & Err.Description, "Error a Tratar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sIn = ""
        End Try
        Return sIn
    End Function

    Function getMd5Hash(ByVal input As String) As String
        Dim md5Hasher As MD5 = MD5.Create()
        Dim data As Byte() = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input))
        Dim sBuilder As New StringBuilder()
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i
        Return sBuilder.ToString()
    End Function

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("¿Esta seguro de Borraro los perfiles de este usuario?", "Borrar Perfiles", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim ta As New SeguridadDSTableAdapters.VW_UsuariosPerfilTableAdapter
            For Each r As SeguridadDS.VW_UsuariosPerfilRow In Me.SeguridadDS.VW_UsuariosPerfil.Rows
                If r.estado = "Inactivo" Then
                    ta.DeletePerfilesALL(r.cve_empleado)
                End If
            Next
            MessageBox.Show("Perfiles Borrados", "Borrar Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ta.Dispose()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Me.USUARIOSBindingSource.Filter = "estado = 'Activo'"
        Else
            Me.USUARIOSBindingSource.Filter = "estado = 'inactivo'"
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton1.Checked = True Then
            Me.USUARIOSBindingSource.Filter = "estado = 'Activo'"
        Else
            Me.USUARIOSBindingSource.Filter = "estado = 'inactivo'"
        End If
    End Sub
End Class