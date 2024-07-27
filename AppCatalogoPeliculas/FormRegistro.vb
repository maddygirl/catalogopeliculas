Public Class FormRegistro

    Dim conexion As Conexion = New Conexion()
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim frmLogin As New frmLogin_form
        frmLogin.Show()
        Me.Hide() ''oculta el formuario atual
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
                Else
                    MessageBox.Show("Hubo un error al guardar el registro", "Datos No Guardados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString())

        End Try

    End Sub
End Class