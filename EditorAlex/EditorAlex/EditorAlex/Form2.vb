Public Class Form2
    Dim start As Integer = 0
    Dim indexOfSearchText As Integer = 0
    Dim rtb As RichTextBox = CType(Form1.TabControl1.SelectedTab.Controls.Item(0), RichTextBox)
    Dim color As Color
    'Boton para buscar un texto(definido en la primera caja de texto) en el texto del editor.
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim startindex As Integer = 0

        If TextBox1.Text.Length > 0 Then
            startindex = FindMyText(TextBox1.Text.Trim(), start, rtb.Text.Length)
        End If
        '  Si el string se encuentra en el texto lo remarca
        If startindex >= 0 Then
            ' Encuentra el índice final (número de caracteres en el rtb)
            Dim endindex As Integer = TextBox1.Text.Length
            ' Se posiciona en el string seleccionado
            rtb.Select(startindex, endindex)
            ' Recoge el color del texto antes de ser cambiado para que cuando se cierre el Form2 este vuelve a su color anterior.
            color = rtb.SelectionColor
            ' Cambia el color a Azul
            rtb.SelectionColor = color.Blue
            ' Marca la posicion de inicio tras la posicion del ultimo string buscado
            start = startindex + endindex
        Else
            'Si no se encuentra la palabra en la busqueda , reinicializa las variables start y indexOfSearchText.
            start = 0
            indexOfSearchText = 0
        End If
    End Sub

    Public Function FindMyText(ByVal txtToSearch As String, ByVal searchStart As Integer, ByVal searchEnd As Integer) As Integer
        'deja de seleccionar el ultimo string
        If searchStart > 0 AndAlso searchEnd > 0 AndAlso indexOfSearchText >= 0 Then
            rtb.Undo()
            start = 0
            indexOfSearchText = 0
        End If
        ' Pone el valor de la variable return a -1.
        Dim retVal As Integer = -1

        ' Un índice de partida válido debe ser especificado.
        ' Si la variable indexOfSearchText es -1, es el final de la búsqueda.
        If searchStart >= 0 AndAlso indexOfSearchText >= 0 Then
            ' A valid ending index
            If searchEnd > searchStart OrElse searchEnd = -1 Then
                'Encuentra la posicion de la busqueda del string en el RichTextBox(el texto del editor).
                indexOfSearchText = rtb.Find(txtToSearch, searchStart, searchEnd, RichTextBoxFinds.None)
                'Determina donde esta el texto en el RichTextBox(el texto del editor).
                If indexOfSearchText <> -1 Then
                    ' Devuelve el valor especificado de la busqueda a la variable retVal.
                    retVal = indexOfSearchText
                End If
            End If
        End If
        Return retVal
    End Function

    'Si el texto es cambiado, reinicializa las variables start y indexOfSearchText.
    Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        start = 0
        indexOfSearchText = 0
    End Sub

    ' El texto que es buscado en el metodo FindMyText es reeamplazado por el valor de la Textbox2
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Dim startindex As Integer = 0
        If TextBox1.Text.Length > 0 Then
            startindex = FindMyText(TextBox1.Text.Trim(), start, rtb.Text.Length)
        End If
        rtb.SelectedText = rtb.SelectedText.Replace(TextBox1.Text, TextBox2.Text)
    End Sub

    ' Cuando se cierre el Form2 l texto que se busco vuelve a su color anterior.
    Private Sub Form2_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        rtb.SelectionColor = color
    End Sub

End Class