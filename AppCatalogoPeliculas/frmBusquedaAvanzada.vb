Public Class frmBusquedaAvanzada

    Public searchCriteria As New List(Of Tuple(Of String, String))()
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'Consolida todos las variables para busqueda


        ' Validacion de cmbGeneroPeli 
        If cmbGeneroPeli.SelectedItem IsNot Nothing AndAlso Not String.IsNullOrEmpty(cmbGeneroPeli.SelectedItem.ToString()) Then
            searchCriteria.Add(New Tuple(Of String, String)("GENERO", cmbGeneroPeli.SelectedItem.ToString()))
        End If

        ' Validacion de txtTituloPeli
        If Not String.IsNullOrEmpty(txtTituloPeli.Text) Then
            searchCriteria.Add(New Tuple(Of String, String)("TITULO", txtTituloPeli.Text))
        End If

        ' Validacion de txtDirectorPeli 
        If Not String.IsNullOrEmpty(txtDirectorPeli.Text) Then
            searchCriteria.Add(New Tuple(Of String, String)("DIRECTOR", txtDirectorPeli.Text))
        End If

        ' Validacion de txtAnio 
        If Not String.IsNullOrEmpty(txtAnio.Text) AndAlso IsNumeric(txtAnio.Text) Then
            searchCriteria.Add(New Tuple(Of String, String)("ANIO", txtAnio.Text))
        End If

        ' Validacion de txtDuracionPeli 
        If Not String.IsNullOrEmpty(txtDuracionPeli.Text) AndAlso IsNumeric(txtDuracionPeli.Text) Then
            searchCriteria.Add(New Tuple(Of String, String)("DURACION", txtDuracionPeli.Text))
        End If

        ' Validacion de cmbCartelera
        If cmbCartelera.SelectedItem IsNot Nothing AndAlso Not String.IsNullOrEmpty(cmbCartelera.SelectedItem.ToString()) Then
            searchCriteria.Add(New Tuple(Of String, String)("CARTELERA", cmbCartelera.SelectedItem.ToString()))
        End If

        'Devuelve resultado OK
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class