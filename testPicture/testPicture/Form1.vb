Public Class btnImage

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ofd01.Filter = "Image File(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)" & _
       "|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png|" & _
       "ALL File (*.*)|*.*"
        ofd01.ShowDialog()
        Pic01.Image = System.Drawing.Image.FromFile(ofd01.FileName)
    End Sub

    Private Sub btnBlank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlank.Click
        Pic01.Image = Nothing
    End Sub
End Class
