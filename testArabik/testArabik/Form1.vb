Public Class Form1

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        txtResult1.Text = Fup(txtInput1.Text)
        txtResult2.Text = Fup(txtInput2.Text)
        txtResult3.Text = Fup(txtInput3.Text)
    End Sub
    Function Fup(ByVal a)
        Dim m, d, k As Integer
        Dim n As String
        For i = Len(a) To 1 Step -1
            n = Mid(a, i, 1)
            If n = "1" Then
                m = i
            ElseIf n = "1" Then
                m = i
            ElseIf n = "1" Then
                m = i
            ElseIf n = "1" Then
                m = i
            ElseIf n = "1" Then
                m = i
            ElseIf n = "1" Then
                m = i
            ElseIf n = "1" Then
                m = i
            ElseIf n = "1" Then
                m = i
            ElseIf Not n = "0" Then
                m = 0
            End If
            d += m
            k &= d
        Next
        Fup = k
    End Function

    
    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar < "0" Or e.KeyChar > "1" Then
            e.Handled = True
        End If
    End Sub
End Class
