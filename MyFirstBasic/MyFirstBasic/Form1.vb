Public Class Form1

    Private Sub btnFontColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFontColor.Click
        lblTitle.ForeColor = Color.Red
        lblTitle.BackColor = Color.YellowGreen
        txtShowText.ForeColor = Color.Blue
        lblTitle.Text = "I Love VB.NET"
    End Sub

    Private Sub btnShowText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowText.Click
        lblTitle.Text = txtShowText.Text
        MessageBox.Show(txtShowText.Text)
    End Sub

    Private Sub btnFormColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFormColor.Click
        Me.BackColor = Color.Green
    End Sub

    Private Sub btnFormTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFormTitle.Click
        Me.Text = "My First Basic Application"
        Me.Text &= txtShowText.Text
    End Sub

    Private Sub btnFormTitle_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFormTitle.MouseLeave
        Label1.Visible = False
    End Sub

    Private Sub btnFormTitle_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnFormTitle.MouseMove
        Label1.Visible = True
    End Sub

    Private Sub btnFontColor_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFontColor.MouseLeave

        Me.BackColor = Color.Yellow
    End Sub

    Private Sub btnFontColor_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnFontColor.MouseMove

        Me.BackColor = Color.Green
    End Sub
End Class
