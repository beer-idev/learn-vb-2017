Public Class Form1
    Const MAXQUEUE = 5
    Dim queue(MAXQUEUE) As String
    Dim rear As Integer
    Dim front As Integer

    Private Sub btnEnQueue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnQueue.Click
        Call EnQueue()
    End Sub
    Sub EnQueue()
        If rear = MAXQUEUE Then
            MsgBox("Full Queue")
        Else
            rear += 1
            queue(rear) = InputBox("Enter Value:", , 0)
            If front = 0 Then front = 1
            lstShow.Items.Add(rear & " : " & queue(rear))
        End If
    End Sub

    Private Sub btnDeQueue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeQueue.Click

        Call Dequeue()
      

    End Sub
    Sub Dequeue()
        If front = 0 Then
            MsgBox("Empty Queue")
        Else
            If front = rear Then
                front = 0
                rear = 0
            Else
                front += 1
            End If

            lstShow.Items.RemoveAt(0)
        End If
    End Sub
End Class
