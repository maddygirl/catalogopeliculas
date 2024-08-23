Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Module Funciones
    ''Variables globales 
    Public F, K As Integer
    Public idPelicula, idUsuario As Integer
    Public adminUser As Boolean
    Public codigoVerificacion As String

    Public Sub set_solo_letras(ByRef ee As System.Windows.Forms.KeyPressEventArgs)
        'Funcion que obliga a digitar en mayúscula en los textbox
        Dim cadena As String
        cadena = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz"
        If InStr(cadena, ee.KeyChar) Then
            ee.Handled = False
        ElseIf Char.IsControl(ee.KeyChar) Then
            ee.Handled = False
        Else
            ee.Handled = True
        End If
    End Sub


    Public Function validar_correo(ByRef e As String) As Boolean
        Try
            Return Regex.IsMatch(e.Trim, "([0-9a-zA-Z]([-\.\w][0-9a-zA-Z])@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

    Public Function Gen_SHA256(ByVal Content As String) As String
        Dim Hashing As New Security.Cryptography.SHA256CryptoServiceProvider
        Dim ByteString() As Byte = System.Text.Encoding.ASCII.GetBytes(Content)
        ByteString = Hashing.ComputeHash(ByteString)

        Dim FinalString As String = Nothing
        For Each bt As Byte In ByteString
            FinalString &= bt.ToString("x2")
        Next
        Return FinalString
    End Function

    Public Sub clearAlltxt(ByVal root As Control) 'Funcion para limpiar todos los textboxes
        For Each ctrl As Control In root.Controls
            clearAlltxt(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub

    Function validarAnio(strValor As String) As Boolean
        Dim intAnio As Integer

        ' Elimina espacios en blanco
        strValor = Trim(strValor)

        ' Verifica si el input contiene solo números
        If Not IsNumeric(strValor) Then
            validarAnio = False
            Exit Function
        End If

        ' Obteniene la longitud del input
        Dim vLongitud As Integer
        vLongitud = Len(strValor)

        ' Verifica si la cadena tiene 4 dígitos
        If vLongitud <> 4 Then
            validarAnio = False
            Exit Function
        End If

        ' Convertir la cadena a un número entero
        intAnio = Val(strValor)

        ' Verificar si el año está dentro del rango válido (por ejemplo, entre 1900 y 2100)
        If intAnio < 1900 Or intAnio > 2100 Then
            validarAnio = False
        Else
            validarAnio = True
        End If
    End Function


End Module
