Public Class frmAdmin
    Dim conexion As Conexion = New Conexion()
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close() ''oculta el formuario atual
        frm_Inicio.Show()
    End Sub

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.generadorIdPelicula()
        idPelicula = idPelicula + 1
        txtID_Peli.Text = idPelicula.ToString
        mostrarDgv()
    End Sub

    Function camposLlenos() As Boolean
        If txtID_Peli.Text = "" Or txtAnio.Text = "" Or txtDuracionPeli.Text = "" Or cmbGeneroPeli.Text = "" Or txtTituloPeli.Text = "" Or txtDirectorPeli.Text = "" Or txtSinopsisPeli.Text = "" Or txtPosterURL.Text = "" Or cmbCartelera.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub txtAnio_Leave(sender As Object, e As EventArgs) Handles txtAnio.Leave

        If Funciones.validarAnio(txtAnio.Text) = False Then
            MessageBox.Show("El año ingresado es invalido.")
            txtAnio.Clear()
        End If
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Dim vID, vAnio, vDuracion As Integer
        Dim vGenero, vTitulo, vDirector, vSinopsis, vPosterUrl, vCartelera As String
        Dim strsql As String = ""

        Try
            If camposLlenos() = False Then
                MessageBox.Show("Hay campos vacíos. Intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            ElseIf MessageBox.Show("¿Está seguro de insertar esta pelicula en la base de datos?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

                vID = txtID_Peli.Text
                vAnio = txtAnio.Text
                vDuracion = txtDuracionPeli.Text
                vGenero = cmbGeneroPeli.Text
                vTitulo = txtTituloPeli.Text
                vDirector = txtDirectorPeli.Text
                vSinopsis = txtSinopsisPeli.Text
                vPosterUrl = txtPosterURL.Text
                vCartelera = cmbCartelera.Text

                'Falta agregar validacion para consultar peliculas existentes
                strsql = "INSERT INTO PELICULA (ID, GENERO, TITULO, DIRECTOR, ANIO, DURACION, SINOPSIS, POSTER_URL, CARTELERA) "
                strsql += vbCrLf + "VALUES ('" & vID & "', '" & vGenero & "', '" & vTitulo & "', '" & vDirector & "', '" & vAnio & "', '" & vDuracion & "', '" & vSinopsis & "', '" & vPosterUrl & "', '" & vCartelera & "')"
                conexion.insertarPelicula(strsql)
                If conexion.f = 0 Then
                    MessageBox.Show("Pelicula añadida satisfactoriamente.")
                    Funciones.clearAlltxt(Me)
                    cmbGeneroPeli.SelectedIndex.Equals(0)
                    mostrarDgv()
                Else
                    MessageBox.Show("Error al guardar los datos.")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: " + ex.ToString)
        End Try

    End Sub

    Public Sub mostrarDgv()
        dgvListaPeliculas.DataSource = conexion.actualizarDgv()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim nombrePelicula As String

        nombrePelicula = InputBox("Ingrese el nombre de la película:", "Consultar Película")
        dgvListaPeliculas.DataSource = conexion.buscarPelicula(nombrePelicula)

    End Sub

    Private Sub dgvListaPeliculas_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaPeliculas.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataRowView = dgvListaPeliculas.Rows(e.RowIndex).DataBoundItem

            txtID_Peli.Text = selectedRow("ID").ToString
            txtAnio.Text = selectedRow("ANIO").ToString
            txtDuracionPeli.Text = selectedRow("DURACION").ToString
            cmbGeneroPeli.Text = selectedRow("GENERO").ToString
            txtTituloPeli.Text = selectedRow("TITULO").ToString
            txtDirectorPeli.Text = selectedRow("DIRECTOR").ToString
            txtSinopsisPeli.Text = selectedRow("SINOPSIS").ToString
            txtPosterURL.Text = selectedRow("POSTER_URL").ToString
            cmbCartelera.Text = selectedRow("CARTELERA").ToString
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim vID, vAnio, vDuracion As Integer
        Dim vGenero, vTitulo, vDirector, vSinopsis, vPosterUrl, vCartelera As String

        If camposLlenos() = False Then
            MessageBox.Show("Hay campos vacíos. Intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        vID = CInt(txtID_Peli.Text)
        vGenero = cmbGeneroPeli.Text
        vTitulo = txtTituloPeli.Text
        vDirector = txtDirectorPeli.Text
        vAnio = CInt(txtAnio.Text)
        vDuracion = CInt(txtDuracionPeli.Text)
        vSinopsis = txtSinopsisPeli.Text
        vPosterUrl = txtPosterURL.Text
        vCartelera = cmbCartelera.Text

        If conexion.actualizarPeli(vID, vGenero, vTitulo, vDirector, vAnio, vDuracion, vSinopsis, vPosterUrl, vCartelera) Then
            MessageBox.Show("Pelicula actualizada satisfactoriamente.")
            mostrarDgv()
            Funciones.clearAlltxt(Me)
            cmbGeneroPeli.SelectedIndex = 0
        Else
            MessageBox.Show("Error al actualizar los datos.")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim vID As Integer

        If dgvListaPeliculas.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione una película para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        vID = CInt(dgvListaPeliculas.SelectedRows(0).Cells("ID").Value)

        Dim result As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar la película seleccionada?", "Eliminar Película", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            If conexion.eliminarPeli(vID) Then
                MessageBox.Show("Pelicula eliminada satisfactoriamente.")
                mostrarDgv()
            Else
                MessageBox.Show("Error al eliminar la película.")
            End If
        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Funciones.clearAlltxt(Me)
        cmbGeneroPeli.SelectedIndex.Equals(0)
        conexion.generadorIdPelicula()
        idPelicula = idPelicula + 1
        txtID_Peli.Text = idPelicula.ToString
        mostrarDgv()
    End Sub
End Class