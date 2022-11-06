Public Class Form1

    Private Sub btnFactorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFactorial.Click
        txtReasult.Text = Factorial(txtFacNum.Text)
    End Sub
    Function Factorial(ByVal Num As Integer) As Long
        If Num = 0 Then
            Factorial = 1
        Else
            Factorial = 1
            For i = 1 To Num
                Factorial = Factorial * i
            Next
        End If

    End Function

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtFacNum.Text = " "
        txtReasult.Text = " "
    End Sub

    Private Sub btnFactorial1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFactorial1.Click
        txtReasult.Text = (txtFacNum.Text)
    End Sub

    Private Sub btnFac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFac.Click
        txtReasult.Text = Fac(Val(txtFacNum.Text))
    End Sub
    Function Fac(ByVal Num)
        If Num = 0 Then
            Fac = 1
        Else
            Fac = Num * Fac(Num - 1)

        End If
    End Function

    Private Sub Fac1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFac1.Click
        txtReasult.Text = fac1(txtFacNum.Text)
    End Sub
    Function fac1(ByVal Num)
        Dim M, B As String
        If Num = 0 Then
            fac1 = 1
        Else
            fac1 = 1
            For i = 1 To Num - 1
                fac1 = Num - i
                B = fac1
                M &= " * " & B
            Next i
            fac1 = Num & M & " = " & Fac(Num)
        End If
    End Function
End Class
