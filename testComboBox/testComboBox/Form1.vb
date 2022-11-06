Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i = 1 To 10
            ComboBox1.Items.Add(i)
            ComboBox2.Items.Add(i)
            ComboBox3.Items.Add(i)

        Next
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        MsgBox(ComboBox1.Text)
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim strShow As String = "Item: "
        Dim Str1 As String = "Index: "
        strShow &= ComboBox1.SelectedItem & vbCrLf
        strShow &= ComboBox2.SelectedItem & vbCrLf
        strShow &= ComboBox3.Text
        MsgBox(strShow)

        Str1 &= ComboBox1.SelectedIndex & vbCrLf
        Str1 &= ComboBox2.SelectedIndex & vbCrLf
        Str1 &= ComboBox3.SelectedIndex
        MsgBox(Str1)

    End Sub
End Class
