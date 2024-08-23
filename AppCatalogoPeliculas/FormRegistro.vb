Imports System.Net.Mail
Imports System.Text
Imports System.Text.RegularExpressions

Public Class FormRegistro

    Dim conexion As Conexion = New Conexion()
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim frmLogin As New frmLogin_form
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click '!!Falta validacion cuando se intenta crear un usuario o correo existente
        Dim vID As Integer = txtID_usuario.Text.Trim
        Dim vUsuario As String = txtNombre_usuario.Text.Trim
        Dim vPassword As String = Funciones.Gen_SHA256(txtPassword_usuario.Text.Trim)
        Dim vEmail As String = txtEmail.Text.Trim
        Dim vRol As Integer
        Dim strsql As String = ""
        If cmbRol.Text = "Usuario" Then
            vRol = 0
        Else
            vRol = 1
        End If

        Try

            If MessageBox.Show("¿Esta seguro de incluir estos datos en registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

                'Constructor de INSERT SQL
                strsql = "INSERT INTO USUARIO (ID, USUARIO, EMAIL, PASSWORDHASH, ROL)"
                strsql += vbCrLf + "VALUES ('" & vID & "','" & vUsuario & "','" & vEmail & "','" & vPassword & "','" & vRol & "')"

                'Metodo que realiza la insercion a BD
                conexion.inserta_datos(strsql)
                If F = 0 Then
                    MessageBox.Show("Registro satisfactorio", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Funciones.clearAlltxt(Me)
                    cmbRol.SelectedIndex.Equals(0)
                    Me.Close()
                    Dim frmLogin As New frmLogin_form
                    frmLogin.Show()
                Else
                    MessageBox.Show("Hubo un error al guardar el registro", "Datos No Guardados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString())

        End Try

    End Sub

    Private Sub FormRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnRegistrar.Visible = False
        If adminUser = False Then 'Validacion para que si no hay un admin loggeado, solo permita crear usuarios (no admins)
            cmbRol.Items.Clear()
            cmbRol.Items.Add("Usuario")
            cmbRol.SelectedIndex = cmbRol.FindStringExact("Usuario")
            cmbRol.Enabled = False
            cmbRol.Visible = False
            lblRol.Visible = False
        Else
            cmbRol.Items.Clear()
            cmbRol.Items.Add("Usuario")
            cmbRol.Items.Add("Administrador")
            cmbRol.Enabled = True
            cmbRol.Visible = True
            lblRol.Visible = True
        End If
        conexion.generadorIdUsuario()
        idUsuario = idUsuario + 1
        txtID_usuario.Text = idUsuario
    End Sub

    Private Function validacionEmail(email As String) As Boolean
        ' Usando Regex para validar el formato del email
        Dim pattern As String = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"
        Return Regex.IsMatch(email, pattern)
    End Function

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        Dim vEmail As String = txtEmail.Text.Trim

        If Not validacionEmail(vEmail) Then
            MessageBox.Show("El formato del email es incorrecto. Por favor intente nuevamente", "Email Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmail.Focus() 'Devuelve al usuario al email box
        End If
    End Sub

    Private Function GenerateVerificationCode() As String
        Const codeLength As Integer = 6 'Tamaño del codigo
        Const chars As String = "0123456789" 'Pool de caracteres

        Dim random As New Random()
        Dim code As New StringBuilder(codeLength)

        For i As Integer = 1 To codeLength
            Dim randomIndex As Integer = random.Next(0, chars.Length) 'Randomizer
            code.Append(chars(randomIndex))   'Hace appends de los caracteres del codigo
        Next

        Return code.ToString()
    End Function

    Private Sub enviarEmail(email As String, code As String)
        Dim mail As New MailMessage()
        mail.From = New MailAddress("MS_bu5lwU@trial-yzkq340713xld796.mlsender.net")
        mail.To.Add(email)
        mail.Subject = "Verificacion de Correo"
        mail.Body = $"Su codigo de verificacion es: {code}"

        Dim smtp As New SmtpClient("smtp.mailersend.net")
        smtp.Port = 587
        smtp.Credentials = New System.Net.NetworkCredential("MS_bu5lwU@trial-yzkq340713xld796.mlsender.net", "cxRfyD2VcdAiIDGt")
        smtp.EnableSsl = True

        Try
            smtp.Send(mail)
        Catch ex As Exception
            MessageBox.Show($"Error al enviar correo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        MessageBox.Show(code)
    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        codigoVerificacion = GenerateVerificationCode()
        enviarEmail(txtEmail.Text.Trim, codigoVerificacion)
        MessageBox.Show("Se ha enviado un codigo de verificacion a su correo. Verifique el codigo para completar el registro.", "Verificacion de Correo", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim vCodigo As String = InputBox("Ingrese el codigo de verificacion que se mando a su correo", "Verificacion de Correo")

        If vCodigo = codigoVerificacion Then
            btnRegistrar.Visible = True
            MessageBox.Show("Email verificado!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnVerificar.Visible = False
        Else
            MessageBox.Show("Codigo invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmail.Clear()
        End If
    End Sub
End Class