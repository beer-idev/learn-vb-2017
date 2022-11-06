Public Class Form1

    Const Max As Integer = 5
    Dim Deque(Max), value As String
    Dim num As Integer

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        If num >= Max Then
            MsgBox("Deque Full")
            Exit Sub
        End If
        num += 1
        If rdLast.Checked = True Then
            Deque(num) = InputBox("InsertLast Data:")
        Else
            For i = num To 2 Step -1
                Deque(i) = Deque(i - 1)
            Next
            Deque(1) = InputBox("InsertFirst Data:")
        End If
        lstShow.Items.Clear()
        For i = 1 To num
            lstShow.Items.Add(i & " : " & Deque(i))
        Next
    End Sub

    Private Sub btnReMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Dim strReMove As String
        If num <= 0 Then
            MsgBox("Deque Empty")
            Exit Sub
        End If
        If rdLast.Checked = True Then
            strReMove = Deque(num)
            Deque(num) = ""
            MsgBox("Remove Last : " & strReMove)
        Else
            strReMove = Deque(1)
            MsgBox("Remove First : " & strReMove)
            For i = 1 To num - 1
                Deque(i) = Deque(i + 1)
            Next
            Deque(num) = ""
        End If
        num -= 1
        lstShow.Items.Clear()
        For i = 1 To num
            lstShow.Items.Add(i & " : " & Deque(i))
        Next
    End Sub

End Class
