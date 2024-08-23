Imports System.Data.SqlClient          'importara todos los objetos que necesito para mi sql
Imports System.Text.RegularExpressions 'para crear expreciones regulares, me ayudara a validar formatos
Public Class Conexion
    Public conexion As SqlConnection = New SqlConnection("Data source=DESKTOP-VLAD\DBVLAD; Initial Catalog=Catalogo_Peliculas; trusted_connection=Yes")
    Public comando As SqlCommand
    Public da As SqlDataAdapter
    Public dr As SqlDataReader
    Public ds As DataSet = New DataSet()
    Public builder As SqlCommandBuilder
    Public dataset As DataSet = New DataSet()
    Public f As Integer


    Public Sub conectar()

        Try
            conexion.Open()
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString)
            MsgBox("Contacte a soporte")
            End
        Finally
            conexion.Close()
        End Try

    End Sub

    Public Function inserta_datos(ByVal datos As String) As Boolean
        Try

            conexion.Open()
            comando = New SqlCommand(datos, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()

            F = 0

            Return True

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString)
            F = 1
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function verificaLogin(ByVal username As String, password As String) As DataTable

        Dim dt = New DataTable() 'Instanciando en memoria

        'Busca usuarios activos
        Consultar("SELECT * FROM USUARIO WHERE USUARIO = '" + username + "' AND PASSWORDHASH = '" + password + "'", "USUARIO")
        If dataset.Tables("USUARIO").Rows.Count > 0 Then
            f = 0
        Else
            f = 1
        End If

        da.Fill(dt)
        Return (dt)

    End Function

    Public Sub Consultar(ByVal sql As String, ByVal tabla As String)
        dataset.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        builder = New SqlCommandBuilder(da)
        da.Fill(dataset, tabla)
    End Sub

    Public Function generadorIdPelicula() As DataTable
        Dim dt = New DataTable()
        Consultar("Select ID FROM PELICULA", "ID")
        idPelicula = dataset.Tables("ID").Rows.Count
        da.Fill(dt)
        Return (dt)
    End Function

    Public Function generadorIdUsuario() As DataTable
        Dim dt = New DataTable()
        Consultar("Select ID FROM USUARIO", "ID")
        idUsuario = dataset.Tables("ID").Rows.Count
        da.Fill(dt)
        Return (dt)
    End Function

    Public Function insertarPelicula(ByVal datos As String) As Boolean
        Try
            conexion.Open()
            comando = New SqlCommand(datos, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            f = 0
            Return True
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString)
            conexion.Close()
            Return False
        End Try
    End Function

    Public Sub consultadgv(ByVal sql As String)
        dataset.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        builder = New SqlCommandBuilder(da)
        da.Fill(dataset)
    End Sub

    Public Function actualizarDgv() As DataTable
        Try
            Dim dt = New DataTable() 'Instanciando en memoria
            Dim strsql As String
            strsql = "SELECT * FROM PELICULA"
            consultadgv(strsql)
            da.Fill(dt)
            Return (dt)
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString)
        End Try
    End Function

    Public Function actualizarDgv2() As DataTable
        Try
            Dim dt = New DataTable() 'Instanciando en memoria
            Dim strsql As String
            strsql = "SELECT ID, TITULO, DIRECTOR, GENERO, ANIO, DURACION, SINOPSIS, CARTELERA FROM PELICULA"
            consultadgv(strsql)
            da.Fill(dt)
            Return (dt)
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString)
        End Try
    End Function

    Public Function buscarPelicula(ByVal nombre As String) As DataTable
        Dim dt = New DataTable()
        Try
            Consultar("SELECT * FROM PELICULA WHERE TITULO LIKE '%" + nombre + "%'", "ID")
            If dataset.Tables("ID").Rows.Count > 0 Then
                f = 0
            Else
                f = 1
            End If
            da.Fill(dt)
            Return (dt)
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString)
        End Try

    End Function

    Public Function actualizarPeli(ByVal idPelicula As Integer, ByVal vGenero As String, ByVal vTitulo As String, ByVal vDirector As String, ByVal vAnio As Integer, ByVal vDuracion As Integer, ByVal vSinopsis As String, ByVal vPosterUrl As String) As Boolean
        Try
            conexion.Open()
            comando = New SqlCommand("UPDATE PELICULA SET GENERO = @genero, TITULO = @titulo, DIRECTOR = @director, ANIO = @anio, DURACION = @duracion, SINOPSIS = @sinopsis, POSTER_URL = @posterUrl WHERE ID = @idPelicula", conexion)
            comando.Parameters.AddWithValue("@genero", vGenero)
            comando.Parameters.AddWithValue("@titulo", vTitulo)
            comando.Parameters.AddWithValue("@director", vDirector)
            comando.Parameters.AddWithValue("@anio", vAnio)
            comando.Parameters.AddWithValue("@duracion", vDuracion)
            comando.Parameters.AddWithValue("@sinopsis", vSinopsis)
            comando.Parameters.AddWithValue("@posterUrl", vPosterUrl)
            comando.Parameters.AddWithValue("@idPelicula", idPelicula)
            comando.ExecuteNonQuery()
            conexion.Close()
            f = 0
            Return True
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString)
            conexion.Close()
            Return False
        End Try
    End Function

    Public Function eliminarPeli(ByVal idPelicula As Integer) As Boolean
        Try
            conexion.Open()
            comando = New SqlCommand("DELETE FROM PELICULA WHERE ID = @idPelicula", conexion)
            comando.Parameters.AddWithValue("@idPelicula", idPelicula)
            comando.ExecuteNonQuery()
            conexion.Close()
            f = 0
            Return True
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString)
            conexion.Close()
            Return False
        End Try
    End Function


End Class
