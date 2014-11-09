Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CType(Form1.TabControl1.SelectedTab.Controls.Item(0), RichTextBox).Find(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CType(Form1.TabControl1.SelectedTab.Controls.Item(0), RichTextBox).Find(TextBox1.Text)
        CType(Form1.TabControl1.SelectedTab.Controls.Item(0), RichTextBox).SelectedText = TextBox2.Text

    End Sub
End Class