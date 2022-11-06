Public Class Form1

    Private Sub btnNewForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewForm.Click
        Dim NewForm As New Form1
        NewForm.Text = "New Form"
        NewForm.Show()
    End Sub

    Private Sub btnOpenForm2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenForm2.Click
        Form2.Show()
        Me.Hide()   'ซ่อนฟอร์มตัวมันเอง
        'me.close() 
    End Sub
End Class
