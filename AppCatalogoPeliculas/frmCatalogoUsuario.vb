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
        dgvPeliculas.Columns("ID").Visible = False
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        dgvPeliculas.DataSource = conexion.actualizarDgv2()
        dgvPeliculas.Columns("ID").Visible = False
    End Sub

    Private Sub dgvPeliculas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPeliculas.CellClick
        If e.RowIndex >= 0 Then 'Verifica que una fila valida se selecciono


            Dim selectedRow As DataGridViewRow = dgvPeliculas.Rows(e.RowIndex)

            'Crea una instancia del form frmPelicula
            Dim frmInfoPeli As New frmPelicula()

            'Actualiza la information de los labels
            frmInfoPeli.lblTitulo.Text = selectedRow.Cells("TITULO").Value.ToString()
            frmInfoPeli.lblSummary.Text = ("La película '[placeholder TITULO]', dirigida por [placeholder DIRECTOR], se estrenó en el año [placeholder ANIO]. Este filme de género [placeholder GENERO] tiene una duración de [placeholder DURACION] minutos." & Environment.NewLine & Environment.NewLine & Environment.NewLine & "Sinopsis: [placeholder SINOPSIS]")
            frmInfoPeli.lblSummary.Text = frmInfoPeli.lblSummary.Text.Replace("[placeholder TITULO]", selectedRow.Cells("TITULO").Value.ToString())
            frmInfoPeli.lblSummary.Text = frmInfoPeli.lblSummary.Text.Replace("[placeholder DIRECTOR]", selectedRow.Cells("DIRECTOR").Value.ToString())
            frmInfoPeli.lblSummary.Text = frmInfoPeli.lblSummary.Text.Replace("[placeholder ANIO]", selectedRow.Cells("ANIO").Value.ToString())
            frmInfoPeli.lblSummary.Text = frmInfoPeli.lblSummary.Text.Replace("[placeholder GENERO]", selectedRow.Cells("GENERO").Value.ToString())
            frmInfoPeli.lblSummary.Text = frmInfoPeli.lblSummary.Text.Replace("[placeholder DURACION]", selectedRow.Cells("DURACION").Value.ToString())
            frmInfoPeli.lblSummary.Text = frmInfoPeli.lblSummary.Text.Replace("[placeholder SINOPSIS]", selectedRow.Cells("SINOPSIS").Value.ToString())

            Dim valCartelera As String = selectedRow.Cells("CARTELERA").Value.ToString()

            If valCartelera = "Si" Then
                frmInfoPeli.lblDisponible.Text = "Pelicula Disponible en Cartelera"
                frmInfoPeli.lblDisponible.ForeColor = Color.LimeGreen
            Else
                frmInfoPeli.lblDisponible.Text = "Pelicula NO Disponible en Cartelera"
                frmInfoPeli.lblDisponible.ForeColor = Color.DarkRed
            End If


            Dim idPelicula As Integer = CInt(selectedRow.Cells("ID").Value)
            Dim posterUrl As String = GetPosterUrlFromDatabase(idPelicula)
            Try
                'Intenta jalar la imagen
                frmInfoPeli.pbPoster.Load(posterUrl)
            Catch ex As Exception
                frmInfoPeli.pbPoster.Image = My.Resources.DefaultMoviePoster
            End Try

            ' Show the details form
            frmInfoPeli.ShowDialog()
        End If
    End Sub

    Private Function GetPosterUrlFromDatabase(idPelicula As Integer) As String
        conexion.Consultar("SELECT POSTER_URL FROM PELICULA WHERE ID = " & idPelicula, "POSTER_URL")
        If conexion.dataset.Tables("POSTER_URL").Rows.Count > 0 Then
            Return conexion.dataset.Tables("POSTER_URL").Rows(0)("POSTER_URL").ToString()
        Else
            Return ""
        End If
    End Function

    Private Function BusquedaAvanzada(searchCriteria As List(Of Tuple(Of String, String))) As DataTable
        'Constructor de SQL basado en criteria definido por usuario
        Dim sqlQuery As String = "SELECT ID, TITULO, DIRECTOR, GENERO, ANIO, DURACION, SINOPSIS, CARTELERA FROM PELICULA WHERE "

        For i As Integer = 0 To searchCriteria.Count - 1
            Dim criteria = searchCriteria(i)
            sqlQuery += criteria.Item1 & " LIKE '%" & criteria.Item2 & "%'"
            If i < searchCriteria.Count - 1 Then
                sqlQuery += " AND "
            End If
        Next

        'Ejecuta el query usando la clase conexion
        conexion.consultadgv(sqlQuery)
        Dim dt As New DataTable()
        conexion.da.Fill(dt)
        Return dt
    End Function

    Private Sub btnBusquedaAvanzada_Click(sender As Object, e As EventArgs) Handles btnBusquedaAvanzada.Click
        Dim frmAdvancedSearch As New frmBusquedaAvanzada()
        frmAdvancedSearch.ShowDialog()

        If frmAdvancedSearch.DialogResult = DialogResult.OK Then
            dgvPeliculas.DataSource = BusquedaAvanzada(frmAdvancedSearch.searchCriteria)
        End If
    End Sub
End Class