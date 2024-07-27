Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography

Public Class frmCatalogoUsuario
    Dim conexion As Conexion = New Conexion()
    Private comando As SqlCommand
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs)
        Dim frmAdmin As New frmAdmin
        frmAdmin.Show()
        Me.Hide() ''oculta el formuario atual
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        frm_Inicio.Show()
        Me.Close()
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim nombrePelicula As String

            nombrePelicula = InputBox("Ingrese el nombre de la película:", "Consultar Película")
            dgvPeliculas.DataSource = conexion.buscarPelicula(nombrePelicula)
            If dgvPeliculas.Rows.Count = 1 Then
                MessageBox.Show("Película no encontrada")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString())
        End Try

    End Sub

    Private Sub frmCatalogoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvPeliculas.DataSource = conexion.actualizarDgv2()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        dgvPeliculas.DataSource = conexion.actualizarDgv2()
    End Sub
End Class