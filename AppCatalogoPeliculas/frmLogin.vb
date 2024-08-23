Public Class frmLogin_form

    Dim conexion As Conexion = New Conexion()
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
        frm_Inicio.Show()
    End Sub

    ''programación del link Registrarse Aqui, hace llamado al formulario de Registro
    Private Sub lkbRegistro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkbRegistro.LinkClicked
        Dim FormRegistro As New FormRegistro
        Me.Close() ''oculta el formuario atual
        FormRegistro.ShowDialog()
    End Sub



    ''programación del botón Login, hace llamado al formulario de CatalogoPeliculas
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        funcionLogin()

    End Sub

    Private Sub frmLogin_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.Clear()
        txtUser.Clear()
    End Sub

    Public Sub funcionLogin()
        Dim strsql As String = ""
        Dim strsql1 As String = ""
        Dim vUsername As String = txtUser.Text.Trim
        Dim vPassword As String = Funciones.Gen_SHA256(txtPassword.Text.Trim)

        If txtUser.Text = "" And txtPassword.Text = "" Then
            'Validacion de campos vacios
            MessageBox.Show("El usuario o contraseña se encuentran en blanco.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            'Metodo que verifica credenciales
            conexion.verificaLogin(vUsername, vPassword)
            Dim dt = conexion.verificaLogin(vUsername, vPassword)

            If dt.Rows.Count > 0 Then
                If dt.Rows(0)!ROL = 1 Then
                    txtUser.Clear()
                    txtPassword.Clear()
                    adminUser = True
                    Me.Close() 'Oculta login
                    frmAdmin.ShowDialog() 'Abre el formulario administrador
                Else
                    txtUser.Clear()
                    txtPassword.Clear()
                    adminUser = False
                    Me.Close() 'Oculta login
                    frmCatalogoUsuario.ShowDialog() 'Abre el formulario usuario
                End If
            Else
                MessageBox.Show("El usuario o contraseña son incorrectos.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            funcionLogin() 'Evento login al presionar Enter
        End If
    End Sub
End Class