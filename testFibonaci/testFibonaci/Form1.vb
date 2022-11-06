Public Class Form1

    Private Sub btnFibonaci_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFibonaci.Click
        txtResult.Text = Fibonaci(txtFibonaci.Text)
    End Sub
    Function Fibonaci(ByVal Num As Single) As Long
        Dim Fibonaci1, Fibonaci2 As Integer
        If Num = 0 Or Num = 1 Then
            Fibonaci = Num
        Else
            Fibonaci = 0
            Fibonaci2 = 0
            Fibonaci1 = 1
            For i = 2 To Num
                Fibonaci = Fibonaci1 + Fibonaci2
                Fibonaci2 = Fibonaci1
                Fibonaci1 = Fibonaci
            Next
        End If
    End Function

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtFibonaci.Text = " "
        txtResult.Text = " "
    End Sub

    Private Sub btnFibo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFibo.Click
        txtResult.Text = Fibonaci(Val(txtFibonaci.Text))
    End Sub
    Function Fibo(ByVal Num)
        If Num <= 1 Then
            Fibo = Num
        Else
            Fibo = Fibo(Num - 1) + Fibo(Num - 2)

        End If
    End Function

    Private Sub btnG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnG.Click
        txtResult.Text = gn(Val(txtFibonaci.Text))
    End Sub
    Function gn(ByVal Num)
       If Num <= 1 Then
            gn = 1
        Else
            gn = gn(Num - 1) + gn(Num - 2)

        End If
    End Function

    Private Sub btnH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnH.Click
        txtResult.Text = Hn(Val(txtFibonaci.Text))
    End Sub
    Function Hn(ByVal Num)
        If Num <= 1 Then
            Hn = 0
        Else
            Hn = 1 + Hn(Num - 1) + Hn(Num - 2)

        End If
    End Function
End Class
