Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim a As String
        a = InputBox("Input Data")
        lstLeft.Items.Add(a)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lstLeft.Items.Clear()
        lstRight.Items.Clear()
    End Sub

    Private Sub btnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
        Dim i As Integer = 0
        Do While i < lstLeft.Items.Count
            If lstLeft.GetSelected(i) Then
                lstRight.Items.Add(lstLeft.Items.Item(i))
                lstLeft.Items.RemoveAt(i)
            Else
                i += 1
            End If
        Loop
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim i As Integer = 0
        Do While i < lstRight.Items.Count
            If lstRight.GetSelected(i) Then
                lstLeft.Items.Add(lstRight.Items.Item(i))
                lstRight.Items.RemoveAt(i)
            Else
                i += 1
            End If
        Loop
    End Sub
End Class
