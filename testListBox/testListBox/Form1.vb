Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i = 1 To 20
            ListBox1.Items.Add(i)
        Next
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        MessageBox.Show(ListBox1.SelectedItem, "ที่เลือก")
    End Sub

    Private Sub btnShow1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow1.Click
        Dim i As Integer = 0
        Dim strShow As String = "ข้อมูลที่เลือก"
        Do While i <= ListBox1.Items.Count - 1
            If ListBox1.GetSelected(i) = True Then
                strShow &= vbCrLf & ListBox1.Items.Item(i)
            End If
            i += 1
        Loop
        MessageBox.Show(strShow, "รายการที่เหลือ")
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim a As String
        a = InputBox("Input Data")
        ListBox1.Items.Add(a)
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim a As String
        a = InputBox("กรุณาแทรกข้อความ")
        ListBox1.Items.Insert(0, a)
    End Sub

    Private Sub btnInsert1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert1.Click
        Dim a As String
        Dim b As Integer
        a = InputBox("input data")
        b = InputBox("กรุณากรอกตัวที่ต้องการแทรก")
        If b > ListBox1.Items.Count Then
            b = ListBox1.Items.Count
        End If
        ListBox1.Items.Insert(b, a)
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Dim a As String
        a = InputBox("กรอกข้อมูลลบ")
        ListBox1.Items.Remove(a)
    End Sub

    Private Sub btnRemoveAt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveAt.Click
        Dim i As Integer
        i = InputBox("Input Number At:")
        ListBox1.Items.RemoveAt(i)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim i As Integer = 0
        Do While i < ListBox1.Items.Count
            If ListBox1.GetSelected(i) Then
                MsgBox("Delete" & ListBox1.Items.Item(i))
                ListBox1.Items.RemoveAt(i)
            Else
                i += 1
            End If
        Loop
    End Sub
End Class
