Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Taquilla
    Public searchCriteria As New List(Of Tuple(Of String, String))()
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim frmCatalogoUsuario As New frmCatalogoUsuario
        frmCatalogoUsuario.Show()
        Me.Hide() ''oculta el formuario atual

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Funciones.clearAlltxt(Me)
        cmbPelicula.SelectedIndex = -1
        cmbTipoEntrada.SelectedIndex = -1
        mkbCantEntradas.Text = ""
        ckbCombo1.Checked = False
        ckbCombo2.Checked = False
        ckbCombo3.Checked = False
        ckbNachos.Checked = False
        ckbPalomitas.Checked = False
        ckbRefresco.Checked = False

    End Sub

    Private Sub cmbTipoEntrada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoEntrada.SelectedIndexChanged
        Dim precio As Integer


        Select Case cmbTipoEntrada.SelectedIndex
            Case 0
                precio = 3400
                txtPrecio.Text = Convert.ToString(FormatNumber(precio, 2))
            Case 1
                precio = 2700
                txtPrecio.Text = Convert.ToString(FormatNumber(precio, 2))
            Case 2
                precio = 2500
                txtPrecio.Text = Convert.ToString(FormatNumber(precio, 2))
        End Select

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim cant, precio, subt, desc, iva, total As Integer

        If (mkbCantEntradas.Text.Length = 0) Or (txtPrecio.Text.Length = 0) Then
            MessageBox.Show("Debe ingresar los campos requeridos")
            Return
        End If

        cant = Convert.ToDouble(mkbCantEntradas.Text)
        precio = Convert.ToDouble(txtPrecio.Text)
        subt = precio * cant
        txtSubTotal.Text = Convert.ToString(FormatNumber(subt, 2))

        If cant > 3 And cant <= 7 Then
            desc = subt * 0.08
        Else
            If cant > 7 Then
                desc = subt * 0.1
            End If
        End If

        txtDesc.Text = Convert.ToString(FormatNumber(desc, 2))

        iva = subt * 0.13
        txtImpuesto.Text = Convert.ToString(FormatNumber(iva, 2))


        If ckbCombo1.Checked = True Then
            total = total + 7900
        End If
        If ckbCombo2.Checked = True Then
            total = total + 5600
        End If
        If ckbCombo3.Checked = True Then
            total = total + 15600
        End If
        If ckbPalomitas.Checked = True Then
            total = total + 2900
        End If
        If ckbRefresco.Checked = True Then
            total = total + 2500
        End If
        If ckbNachos.Checked = True Then
            total = total + 3500
        End If

        total = total + subt - desc + iva
        txtTotalPago.Text = Convert.ToString(FormatNumber(total, 2))
    End Sub

    Private Sub btnticket_Click(sender As Object, e As EventArgs) Handles btnticket.Click
        ' Llamar a la función para generar el ticket
        Dim ticket As String = GenerarTicket()

    End Sub

    Private Function GenerarTicket() As String
        Throw New NotImplementedException()
    End Function

    Private Sub Taquilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New Conexion()
        Dim strsql As String = "SELECT TITULO FROM PELICULA WHERE CARTELERA = 'Si'"

        conexion.consultadgv(strsql)

        Dim dt As DataTable = conexion.dataset.Tables(0) ' Assuming the first table in the dataset

        For Each row As DataRow In dt.Rows
            cmbPelicula.Items.Add(row("TITULO"))
        Next
    End Sub
End Class