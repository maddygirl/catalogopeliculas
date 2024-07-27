Imports System.Security.Cryptography.X509Certificates

Public Class frm_Inicio

    Dim conexion As Conexion = New Conexion()

    ''programacion del boton salir
    Private Sub lklSalir_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklSalir.LinkClicked
        Me.Close()
    End Sub


    ''programacion del boton ingresar al sistema, llamamos al formulario
    '' login. 
    Private Sub btnIngresarSistema_Click(sender As Object, e As EventArgs) Handles btnIngresarSistema.Click
        Dim frmLogin As New frmLogin_form
        frmLogin.Show()
        Me.Hide() ''oculta el formuario atual
    End Sub

    Private Sub frm_Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()

    End Sub

End Class


