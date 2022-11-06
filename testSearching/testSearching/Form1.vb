Public Class Form1
    Dim Num As Integer
    Dim D_Search As Integer

    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click
        lstShow.Items.Add(InputBox("Input Data", , 0))
        Num = lstShow.Items.Count
        btnSearch.Enabled = True
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lstShow.Items.Clear()
    End Sub

    Private Sub btnRandom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRandom.Click
        Dim i As Integer
        Randomize()
        lstShow.Items.Clear()
        Num = InputBox("Numbr of data to random ", , 0)
        For i = 1 To Num
            lstShow.Items.Add(Int(Rnd() * 100))
        Next
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        D_Search = InputBox("Want to Search :", , 0)
        Call SequenSearch()
    End Sub
    Sub SequenSearch()
        Dim i As Integer
        lstShow.ClearSelected()
        For i = 0 To Num - 1
            If lstShow.Items.Item(i) = D_Search Then
                lstShow.SelectedIndex = i
                Exit Sub
            End If
        Next
        MsgBox("Data not found", , "Sequential Search")
    End Sub

    Private Sub btnMy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMy.Click
        D_Search = InputBox("Want to Search :", , 0)
        Call MySearch()
    End Sub
    Sub MySearch()
        Dim i, Num2 As Integer
        For i = 0 To Num - 1
            If lstShow.Items.Item(i) = D_Search Then
                lstShow.SelectedIndex = i
                Num2 += 1
            End If
        Next
        If Num2 >= 1 Then
            MsgBox("ซ้ำกัน : " & Num2 & " ตัว", , "My Search") : Exit Sub
        End If
        MsgBox("Data not Found", , "Sequential Search")
    End Sub
End Class
