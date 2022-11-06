Public Class Form1
    Dim data(10) As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstShow.Items.Add("Address Data")
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim Info, HashIndex, Num As Integer
        On Error GoTo err
        Info = txtInput.Text
        If Info = 0 Then
            MsgBox("Data must be not equl 0")
            Exit Sub
        End If
        HashIndex = Info Mod 11
        For Num = 1 To 9
            If data(HashIndex) = 0 Then
                data(HashIndex) = Info
                lstShow.Items.Add(HashIndex & Space(15) & data(HashIndex))
                Exit Sub
            End If
            HashIndex = (HashIndex + 1) Mod 11
        Next
        MsgBox("Hash is full of data")
err:
        MsgBox (Err .Description)

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim Info, HashIndex, Num As Integer
        Info = txtSearch.Text
        If Info = 0 Then
            MsgBox("Data must be not equl 0")
            Exit Sub
        End If
        HashIndex = Info Mod 11
        For Num = 1 To 9
            If data(HashIndex) = Info Then
                MsgBox("Data that you are searching is" & " and it's index number is" & HashIndex)
                Exit Sub
            End If
            HashIndex = (HashIndex + 1) Mod 11
        Next
        MsgBox("Data not fount")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Exit Program ?", 36, "Hashing Function") = vbYes Then
            Me.Close()
        End If
    End Sub
End Class
