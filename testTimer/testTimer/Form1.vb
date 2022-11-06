Public Class Form1
    Dim space01 As String = ""
    Dim chkB As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim xTmp As Integer = Button2.Location.X
        Dim yTmp As Integer = Button2.Location.Y
        Dim a As String = 0
        
        If chkB = True Then
            xTmp += 5
            Button2.Location = New Point(xTmp, yTmp)
            If xTmp >= 586 Then chkB = False
        Else
            xTmp -= 5
            Button2.Location = New Point(xTmp, yTmp)
            If xTmp <= 66 Then chkB = True
        End If


        If Len(space01) < 100 Then
            space01 &= " "
        Else
            space01 = ""
        End If

        Label1.Text = TimeOfDay & space01
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Timer1.Enabled = True Then
            Timer1.Enabled = False
        Else
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Enabled = False
    End Sub
End Class
