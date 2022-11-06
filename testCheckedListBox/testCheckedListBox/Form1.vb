Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i = 1 To 20
            Clb1.Items.Add(i)
        Next
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim StrSelect As String = "เลือก :" & vbCrLf
        For i = 0 To Clb1.CheckedItems.Count - 1
            StrSelect &= Clb1.CheckedItems(i) & ","
        Next
        MsgBox(StrSelect, , "รายการเลือก")
    End Sub

    Private Sub btnShow1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow1.Click
        Dim strSelect As String = "ข้อมูลที่คุณเลือก :"
        For i = 0 To Clb1.Items.Count - 1
            If Clb1.GetItemChecked(i) Then
                strSelect &= vbCrLf & Clb1.Items.Item(i)
            End If
        Next
        MsgBox(strSelect)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Clb1.Items.Clear()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim a As String
        a = InputBox("กรุณาใส่ข้อมูล")
        Clb1.Items.Add(a)
    End Sub

    Private Sub btnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
        Dim i As Integer = 0
        Do While i < Clb1.Items.Count
            If Clb1.GetItemChecked(i) Then
                clb2.Items.Add(Clb1.Items.Item(i))
                Clb1.Items.RemoveAt(i)
            Else
                i += 1
            End If
        Loop
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim a As Integer = 0
        Do While a < clb2.Items.Count
            If clb2.GetItemChecked(a) Then
                Clb1.Items.Add(clb2.Items.Item(a))
                clb2.Items.RemoveAt(a)
            Else
                a += 1
            End If
        Loop
    End Sub
End Class
