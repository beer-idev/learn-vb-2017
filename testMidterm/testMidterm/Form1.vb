Public Class Form1
    Dim count, point As Integer
    Dim Fname() As String
    Dim Age() As Integer
    Dim Salary() As Single
    Dim ChkS As String

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Call btnEnabled(False)
        ChkS = "ADD"
        txtFname.Text = ""
        txtAge.Text = ""
        txtSalary.Text = ""
        txtFname.Focus()
        lblFname.Text = "ชื่อคนที่ :" & (count + 1)
    End Sub

    Sub btnEnabled(ByVal a As Boolean)
        txtFname.Enabled = Not a
        txtAge.Enabled = Not a
        txtSalary.Enabled = Not a

        btnAdd.Enabled = a

        btnSave.Enabled = Not a
        btnCancel.Enabled = Not a

        btnShowAll.Enabled = a

    End Sub

    Sub ShowData(ByVal a)
        lblFname.Text = "ชื่อคนที่ :" & (a)
        txtFname.Text = Fname(a)
        txtAge.Text = Age(a)
        txtSalary.Text = Salary(a)
        With lstShow.Items
            .Add("คนที่ :" & (a))
            .Add("ชื่อ :" & Fname(a))
            .Add("อายุ :" & Age(a))
            .Add("เงินเดือน :" & Salary(a))
            .Add("***************")
        End With
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        count += 1 : point = count
        ReDim Preserve Fname(count)
        ReDim Preserve Age(count)
        ReDim Preserve Salary(count)
        Fname(count) = txtFname.Text
        Age(count) = Val(txtAge.Text)
        Salary(count) = Val(txtSalary.Text)
        lstShow.Items.Clear()
        lblFname.Text = "ชื่อคนที่ :" & (count + 1)
        Call ShowData(point)
        ChkS = "SAVE"
        Call btnEnabled(True)
    End Sub

    Private Sub btnShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAll.Click
        If count < 1 Or point > count Or point < 1 Then
            MsgBox("No Data")
        Else
            lstShow.Items.Clear()
            For i = 1 To count
                Call ShowData(i)
            Next
        End If
        Dim x, min, max, sum, avg As Integer
        If count > 0 Then
            min = 1
            For x = 2 To count
                If Salary(x) <= Salary(min) Then
                    min = x

                End If
            Next
        End If
        If count > 0 Then
            max = 1
            For x = 2 To count
                If Salary(x) >= Salary(max) Then
                    max = x

                End If
            Next
        End If
        sum = 0
        avg = 0

        For x = 1 To count
            sum = sum + Salary(x)
            avg = sum / count
        Next
        lstShow.Items.Clear()
        lstShow.Items.Add("จำนวณพนักงานทั้งหมด :" & count)
        lstShow.Items.Add("************************")
        lstShow.Items.Add("คนที่เงินเดือนน้อยที่สุด")
        lstShow.Items.Add("ลำดับที่ :" & min & "ชื่อ :" & Fname(min))
        lstShow.Items.Add("เงินเดือนน้อยที่สุด :" & Salary(min))
        lstShow.Items.Add("************************")
        lstShow.Items.Add("คนที่เงินเดือนมากที่สุด")
        lstShow.Items.Add("ลำดับที่ :" & max & "ชื่อ :" & Fname(max))
        lstShow.Items.Add("เงินเดือนมากที่สุด :" & Salary(max))
        lstShow.Items.Add("************************")
        lstShow.Items.Add("รวมเงินเดือนทั้งหมด :" & sum)
        lstShow.Items.Add("รวมเงินเดือนเฉลี่ย :" & avg)
    End Sub





    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call btnEnabled(True)
        count = 5 : point = count
        ReDim Preserve Fname(count)
        ReDim Preserve Age(count)
        ReDim Preserve Salary(count)

        Fname(1) = "Pitsanu"
        Age(1) = 20
        Salary(1) = 50000

        Fname(2) = "Kittipop"
        Age(2) = 23
        Salary(2) = 11000

        Fname(3) = "Warawut"
        Age(3) = 17
        Salary(3) = 300000

        Fname(4) = "Somchai"
        Age(4) = 17
        Salary(4) = 9000

        Fname(5) = "Pittawat"
        Age(5) = 20
        Salary(5) = 39000

        Call ShowData(point)
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If count < 1 Or point > count Or point < 1 Then
            MsgBox("No Data")
        Else
            point += 1
            If point > count Then
                MsgBox("First of Dats")
                point = count
            End If
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
                MsgBox("First of Dats")
                point = 1
            End If
            lstShow.Items.Clear()
            Call ShowData(point)

        End If
    End Sub
End Class
