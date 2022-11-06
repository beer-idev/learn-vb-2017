Public Class Form1
    Dim Input1, Input2, Input3, a, b As String
    Dim s As Integer


    Private Sub btnNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNumber.Click
        Input1 = Trim(txtInput1.Text)
        s = Len(Input1)
        For i = 1 To s
            a = Mid(Input1, i, 1)
            If a = "9" Then
                b = "9"
            ElseIf a = "8" Then
                b = "8"
            ElseIf a = "7" Then
                b = "7"
            ElseIf a = "6" Then
                b = "6"
            ElseIf a = "5" Then
                b = "5"
            ElseIf a = "4" Then
                b = "4"
            ElseIf a = "3" Then
                b = "3"
            ElseIf a = "2" Then
                b = "2"
            ElseIf a = "1" Then
                b = "1"
            ElseIf a = "0" Then
                b = "0"
            Else
                b = ""
            End If
            lblResult1.Text &= b
        Next
        Input2 = Trim(txtInput2.Text)
        s = Len(Input2)
        For i = 1 To s
            a = Mid(Input2, i, 1)
            If a = "9" Then
                b = "9"
            ElseIf a = "8" Then
                b = "8"
            ElseIf a = "7" Then
                b = "7"
            ElseIf a = "6" Then
                b = "6"
            ElseIf a = "5" Then
                b = "5"
            ElseIf a = "4" Then
                b = "4"
            ElseIf a = "3" Then
                b = "3"
            ElseIf a = "2" Then
                b = "2"
            ElseIf a = "1" Then
                b = "1"
            ElseIf a = "0" Then
                b = "0"
            Else
                b = ""
            End If
            lblResult2.Text &= b
        Next
        Input3 = Trim(txtInput3.Text)
        s = Len(Input3)
        For i = 1 To s
            a = Mid(Input3, i, 1)
            If a = "9" Then
                b = "9"
            ElseIf a = "8" Then
                b = "8"
            ElseIf a = "7" Then
                b = "7"
            ElseIf a = "6" Then
                b = "6"
            ElseIf a = "5" Then
                b = "5"
            ElseIf a = "4" Then
                b = "4"
            ElseIf a = "3" Then
                b = "3"
            ElseIf a = "2" Then
                b = "2"
            ElseIf a = "1" Then
                b = "1"
            ElseIf a = "0" Then
                b = "0"
            Else
                b = ""
            End If
            lblResult3.Text &= b
        Next
    End Sub



    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtInput1.Clear()
        txtInput2.Clear()
        txtInput3.Clear()
        lblResult1.Text = " "
        lblResult2.Text = " "
        lblResult3.Text = " "
    End Sub

    Private Sub btnNumber1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNumber1.Click
        lblResult1.Text = func_number(txtInput1.Text)
        lblResult2.Text = func_number(txtInput2.Text)
        lblResult3.Text = func_number(txtInput3.Text)
    End Sub
    Function func_number(ByVal a)
        Dim Tmp, Ans As String
        For i = 1 To Len(a)
            Tmp = Mid(a, i, 1)
            If Tmp >= "0" And Tmp <= "9" Then
                Ans &= Tmp

            End If

        Next
        'func_number = Ans
        Return Ans
    End Function
End Class
