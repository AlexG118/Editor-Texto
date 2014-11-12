Imports System.IO

Public Class Form1
    'Al abrir o guardar un archivo , su nombre queda guardado en esta variable.
    Dim ultimoFich As String
    'Muestra el menú Abrir para mostrar el contenido de un archivo de texto que queramos abrir , si habia algo que no hemos guardado en el texto nos preguntara si guardarlo.
    Private Sub AbrirToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click
        If CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).Modified = True Then
            Dim ask As String
            ask = MsgBox("No has guardado tu archivo ¿Quieres guardarlo?", MsgBoxStyle.YesNoCancel)
            If ask = vbYes Then

                CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).SaveFile(ofd.FileName, RichTextBoxStreamType.RichText)

                If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).LoadFile(ofd.FileName, RichTextBoxStreamType.RichText)
                    TabControl1.SelectedTab.Text = Path.GetFileName(ofd.FileName)
                End If

            Else

                If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).LoadFile(ofd.FileName, RichTextBoxStreamType.RichText)
                    TabControl1.SelectedTab.Text = Path.GetFileName(ofd.FileName)
                End If
            End If
        Else
            If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).LoadFile(ofd.FileName, RichTextBoxStreamType.RichText)
                TabControl1.SelectedTab.Text = Path.GetFileName(ofd.FileName)
            End If
        End If
    End Sub


    'Guarda los cambios realizados en el fichero , si no esta especificado el archivo en el que se guardara , saldra un menu que preguntara donde guardarlo.
    Private Sub GrabarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrabarToolStripMenuItem.Click
        If TabControl1.SelectedTab.Text = "" Then
            If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).SaveFile(sfd.FileName, RichTextBoxStreamType.RichText)
                TabControl1.SelectedTab.Text = Path.GetFileName(sfd.FileName)
            End If
        Else
            CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).SaveFile(sfd.FileName, RichTextBoxStreamType.RichText)
            TabControl1.SelectedTab.Text = Path.GetFileName(sfd.FileName)
        End If
    End Sub


    'Guarda los cambios realizados en el fichero especificado.
    Private Sub GrabarComoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrabarComoToolStripMenuItem.Click
        If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).SaveFile(sfd.FileName, RichTextBoxStreamType.RichText)
            TabControl1.SelectedTab.Text = Path.GetFileName(sfd.FileName)
        End If
    End Sub


    'Cierra el editor de texto.
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub


    'Borra el texto escrito.
    Private Sub BorrarTextoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarTextoToolStripMenuItem.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).Clear()
    End Sub


    'Metodo que asocia el nombre del archivo a la variable ultimoFich y posteriormente guarda el archivo.
    Private Sub sfd_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sfd.FileOk
        ultimoFich = Path.GetFileName(sfd.FileName)
    End Sub


    'Metodo que asocie el nombre del archico a la variable ultimoFich y posteriormente abre el archivo.
    Private Sub ofd_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ofd.FileOk
        ultimoFich = Path.GetFileName(ofd.FileName)
    End Sub

    'Metodo para copiar el contenido del texto en la pestaña que estemos al portapapeles.
    Private Sub CopiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarToolStripMenuItem.Click
        Clipboard.Clear()
        CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).Copy()
    End Sub

    'Metodo que pega lo que haya en el portapapeles en el texto de la pestaña que estemos.
    Private Sub PegarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PegarToolStripMenuItem.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).Paste()
    End Sub

    'Metodo que genera una pestaña con su texto al cargar el programa.
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim richtext As New RichTextBox
        Dim edittab As New TabPage
        edittab.Controls.Add(richtext)
        richtext.Dock = DockStyle.Fill
        TabControl1.TabPages.Add(edittab)
        TabControl1.SelectTab(edittab)
    End Sub

    'Metodo que al ahcer click genera una pestaña con un texto.
    Private Sub NuevoToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Dim richtext As New RichTextBox
        Dim edittab As New TabPage
        edittab.Controls.Add(richtext)
        richtext.Dock = DockStyle.Fill
        TabControl1.TabPages.Add(edittab)
        TabControl1.SelectTab(edittab)

    End Sub

    'Metodo para deshacer los cambios.
    Private Sub DeshacerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeshacerToolStripMenuItem.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).Undo()
    End Sub

    'Metodo para rehacer los cambios.
    Private Sub RehacerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RehacerToolStripMenuItem.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).Redo()

    End Sub

    'Metodo para cambiar la fuente del texto seleccionado.
    Private Sub FuenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuenteToolStripMenuItem.Click
        If FontDialog1.showdialog = Windows.Forms.DialogResult.OK Then
            CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).SelectionFont = FontDialog1.Font
        End If

    End Sub

    'Metodo para cambiar el color del texto seleccionado.
    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        If ColorDialog1.showdialog = Windows.Forms.DialogResult.OK Then
            CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).SelectionColor = ColorDialog1.Color
        End If
    End Sub

    'Metodo para cambiar el fondo de color del texto seleccionado.
    Private Sub RemarcarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemarcarToolStripMenuItem.Click
        If ColourDialog1.showdialog = Windows.Forms.DialogResult.OK Then
            CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).SelectionBackColor = ColourDialog1.Color
        End If
    End Sub

    'Metodo para cerrar la pestaña seleccionada.
    Private Sub CerrarPestañaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarPestañaToolStripMenuItem.Click
        TabControl1.TabPages.Remove(TabControl1.SelectedTab)
    End Sub

    'Metodo para cortar el texto seleccionado.
    Private Sub CortarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CortarToolStripMenuItem.Click
        Clipboard.Clear()
        CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).Copy()
        CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).Clear()
    End Sub

    'Metodo que abrira el form2 donde esta las funciones buscar y reemplazar.
    Private Sub BuscarRemplazarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarRemplazarToolStripMenuItem.Click
        Form2.Show()
    End Sub

    'Metodo para cuando se cierre el programa, lo que hara es que si el texto esta modificado pero no lo hemos guardado nos dira que si queremos guardarlo.
    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
      
        If CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).Modified = True Then
            If TabControl1.SelectedTab.Text = "" Then
                Dim x As DialogResult = MessageBox.Show("¿Quieres guardar los cambios?", "Text Creator", MessageBoxButtons.YesNoCancel)
                If x = DialogResult.Yes Then
                    sfd.ShowDialog()
                ElseIf x = DialogResult.No Then

                Else
                    e.Cancel = True
                End If
            End If
        End If

    End Sub

End Class