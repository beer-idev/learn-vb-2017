Public Class Form1
    Dim count, point As Integer
    Dim Fname() As String
    Dim Age() As Integer
    Dim Salary() As Single
    Dim ChkS As String
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Call btnEnable(False)
        ChkS = "ADD"
        txtFname.Text = ""
        txtAge.Text = ""
        txtSalary.Text = ""
        txtFname.Focus()
        lblFname.Text = "ชื่อคนที่ :" & (count + 1)
    End Sub
    Sub btnEnable(ByVal a As Boolean) 'a = true     'edit คือแก้ไข 
        txtFname.Enabled = Not a
        txtAge.Enabled = Not a
        txtSalary.Enabled = Not a

        btnAdd.Enabled = a
        btnEdit.Enabled = a
        btnSave.Enabled = Not a
        btnCancel.Enabled = Not a
        btnDelete.Enabled = a
        btnInsert.Enabled = a

        btnFirst.Enabled = a
        btnPrevious.Enabled = a
        btnShowAll.Enabled = a
        btnNext.Enabled = a
        btnLast.Enabled = a

    End Sub
    Sub ShowData(ByVal a)
        txtFname.Text = Fname(a)
        txtAge.Text = Age(a)
        txtSalary.Text = Salary(a)
        lblFname.Text = "ชื่อคนที่ :" & (a)

        With lstShow.Items
            .Add("คนที่ :" & (a))
            .Add("ชื่อ : " & Fname(a))
            .Add("อายุ : " & Age(a))
            .Add("เงินเดือน : " & Salary(a))
            .Add("*******************")
        End With
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call btnEnable(True)
        count = 5 : point = count
        ReDim Preserve Fname(count)
        ReDim Preserve Age(count)
        ReDim Preserve Salary(count)

        Fname(1) = "Beer"
        Age(1) = 17
        Salary(1) = 1000000

        Fname(2) = "Pissanu"
        Age(2) = 100
        Salary(2) = 3500

        Fname(3) = "Waraporn"
        Age(3) = 39
        Salary(3) = 12003

        Fname(4) = "Somchai"
        Age(4) = 17
        Salary(4) = 9000

        Fname(5) = "Kittiphop"
        Age(5) = 23
        Salary(5) = 20000

        Call ShowData(point)

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ChkS = "ADD" Then
            count -= 1 : point = count - 1
            ReDim Preserve Fname(count)
            ReDim Preserve Age(count)
            ReDim Preserve Salary(count)
            Fname(count) = txtFname.Text
            Age(count) = Val(txtAge.Text)
            Salary(count) = Val(txtSalary.Text)
            lstShow.Items.Clear()
            Call ShowData(point)
        ElseIf ChkS = "INSERT" Then
            count += 1 : If point < 1 Then point = 1
            ReDim Preserve Fname(count) 'ReDim Preserve คือการเพิ่มหรือลดข้อมูล
            ReDim Preserve Age(count)
            ReDim Preserve Salary(count)
            For i = count To point Step -1
                Fname(i) = Fname(i - 1)
                Age(i) = Age(i - 1)
                Salary(i) = Salary(i - 1)
            Next
            Fname(point) = txtFname.Text
            Age(point) = Val(txtAge.Text)
            Salary(point) = Val(txtSalary.Text)
            lstShow.Items.Clear()
            Call ShowData(point)
        ElseIf ChkS = "EDIT" Then
            Fname(point) = txtFname.Text
            Age(point) = Val(txtAge.Text)
            Salary(point) = Val(txtSalary.Text)
            lstShow.Items.Clear()
            Call ShowData(point)
        Else
            ChkS = "DELETE"
            If point < 1 Or count < 1 Then
                MsgBox("Can not Delete Data")
            Else
                For i = point To count - 1
                    Fname(i) = Fname(i + 1)
                    Age(i) = Age(i + 1)
                    Salary(i) = Salary(i + 1)
                Next
                count -= 1
                ReDim Preserve Fname(count)
                ReDim Preserve Age(count)
                ReDim Preserve Salary(count)
                If point > count Then point = count
                lstShow.Items.Clear()
                Call ShowData(point)
            End If
        End If


        ChkS = "SAVE"
        Call btnEnable(True)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Call btnEnable(True)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Call btnEnable(False)
        ChkS = "EDIT"
        txtFname.Text = txtFname.Text
        txtAge.Text = txtAge.Text
        txtSalary.Text = txtSalary.Text
        txtFname.Focus()
        lblFname.Text = "ชื่อคนที่ :" & (point)
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click

        Call btnEnable(False)
        ChkS = "INSERT"
        txtFname.Text = ""
        txtAge.Text = ""
        txtSalary.Text = ""
        txtFname.Focus()
        If point < 1 Then point = count
        lblFname.Text = "ชื่อคนที่ :" & (point)
    End Sub

    Private Sub btnShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAll.Click
        If count < 1 Or point > count Or point < 1 Then 'or จะไม่เข้าเงื่อนไขตอนเป้นเท็จ
            MsgBox("No Data")
        Else
            lstShow.Items.Clear()
            For i = 1 To count
                Call ShowData(i)
            Next
        End If
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        If count < 1 Or point > count Or point < 1 Then
            MsgBox("No Data")
        Else
            point = 1
            lstShow.Items.Clear()
            Call ShowData(point)
        End If
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        If count < 1 Or point > count Or point < 1 Then
            MsgBox("No Data")
        Else
            point = count
            lstShow.Items.Clear()
            Call ShowData(point)
        End If
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        If count < 1 Or point > count Or point < 1 Then
            MsgBox("No Data")
        Else
            point -= 1
            If point <= 0 Then
                MsgBox("First Of Data")
                point = 1
            End If
            lstShow.Items.Clear()
            Call ShowData(point)
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If count < 1 Or point > count Or point < 1 Then
            MsgBox("No Data")
        Else
            point += 1
            If point > count Then
                MsgBox("Finist Of Data")
                point = count
            End If
            lstShow.Items.Clear()
            Call ShowData(point)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ChkS = "DELETE"
        If point < 1 Or count < 1 Then
            MsgBox("Can not Delete Data")
        Else
            For i = point To count - 1
                Fname(i) = Fname(i + 1)
                Age(i) = Age(i + 1)
                Salary(i) = Salary(i + 1)
            Next
            count -= 1
            ReDim Preserve Fname(count)
            ReDim Preserve Age(count)
            ReDim Preserve Salary(count)
            If point > count Then point = count
            lstShow.Items.Clear()
            Call ShowData(point)
        End If
    End Sub
End Class
