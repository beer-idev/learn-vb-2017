Public Class Form1

    Private Sub btnPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus.Click
        Dim Input1, Input2, Result As Double
        Dim StrResult As String = ""
        If IsNumeric(txtInput1.Text) = False Then
            MessageBox.Show("กรุณากรอกเป็นตัวเลข")
            txtInput1.Focus()
            txtInput1.SelectAll()
            Exit Sub
        ElseIf IsNumeric(txtInput2.Text) = False Then
            MessageBox.Show("กรุณากรอกเป็นตัวเลข")
            txtInput2.Focus()
            txtInput2.SelectAll()
            Exit Sub
        End If
        Input1 = txtInput1.Text
        Input2 = txtInput2.Text
        Result = Input1 + Input2
        StrResult = Format(Input1, "#,##0.00") & vbCrLf & "+" & vbCrLf
        StrResult &= Format(Input2, "#,##0.00") & vbCrLf & "========="
        StrResult &= vbCrLf & Format(Result, "#,##0.00")
        lblResult.Text = StrResult
    End Sub

    Private Sub btnMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus.Click
        Dim Input1, Input2, Result As Double
        Dim StrResult As String = ""
        Input1 = txtInput1.Text
        Input2 = txtInput2.Text
        Result = Input1 - Input2
        StrResult = Input1 & vbCrLf & "-" & vbCrLf
        StrResult &= Input2 & vbCrLf & "========="
        StrResult &= vbCrLf & Result
        lblResult.Text = StrResult
    End Sub

    Private Sub btnMultiple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiple.Click
        Dim Input1, Input2, Result As Double
        Dim StrResult As String = ""
        Input1 = txtInput1.Text
        Input2 = txtInput2.Text
        Result = Input1 * Input2
        StrResult = Input1 & vbCrLf & "*" & vbCrLf
        StrResult &= Input2 & vbCrLf & "========="
        StrResult &= vbCrLf & Result
        lblResult.Text = StrResult
    End Sub

    Private Sub btnDevide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDevide.Click
        Dim Input1, Input2, Result As Double
        Dim StrResult As String = ""
        Input1 = txtInput1.Text
        Input2 = txtInput2.Text
        Result = Input1 / Input2
        StrResult = Input1 & vbCrLf & "/" & vbCrLf
        StrResult &= Input2 & vbCrLf & "========="
        StrResult &= vbCrLf & Result
        lblResult.Text = StrResult
    End Sub

    Private Sub btnPercent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPercent.Click
        Dim Input1, Input2, Result As Double
        Dim StrResult As String = ""
        Input1 = txtInput1.Text
        Input2 = txtInput2.Text
        Result = Input1 * Input2 / 100 + Input1
        StrResult = Input1 & vbCrLf & "%" & vbCrLf
        StrResult &= Input2 & vbCrLf & "========="
        StrResult &= vbCrLf & Result
        lblResult.Text = StrResult
    End Sub

    Private Sub btnVat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVat.Click
        Dim Input1, Input2, Result As Double
        Dim StrResult As String
        Input1 = txtInput1.Text
        Input2 = txtInput2.Text
        Result = (Input1 * 100 / Input2) - Input1
        StrResult = Input1 & vbCrLf & "%" & vbCrLf
        StrResult &= Input2 & vbCrLf & "========="
        StrResult &= vbCrLf & Result
        lblResult.Text = StrResult
    End Sub
End Class
