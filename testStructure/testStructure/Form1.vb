Public Class Form1
    Private Structure EmployeeRecord
        Dim Fname As String
        Dim age As Integer
        Dim Salary As Single
    End Structure
    Dim Emp As EmployeeRecord 'แบบตัวแปรธรรมดา

    Dim EmpArr(10) As EmployeeRecord  'แบบ Array
    Dim CArr As Integer

    Dim EmpDy() As EmployeeRecord 'แบบ Dynamic Array
    Dim CDy As Integer

    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click
        Emp.Fname = InputBox("ชื่อ :")
        Emp.age = Val(InputBox("อายุ :", , 0))
        Emp.Salary = Val(InputBox("เงินเดือน :", , 0))
        With lstShow.Items
            .Clear()
            .Add("ตัวแปรแบบธรรมดา")
            .Add("ชื่อ :" & Emp.Fname)
            .Add("อายุ :" & Emp.age)
            .Add("เงินเดือน :" & Format(Emp.Salary, "#,##0.00"))
            .Add("*******************")
        End With
    End Sub

    Private Sub btnArray_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArray.Click
        CArr += 1
        EmpArr(CArr).Fname = InputBox("ชื่อ :" & CArr)
        EmpArr(CArr).age = Val(InputBox("อายุ :", , 0))
        EmpArr(CArr).Salary = Val(InputBox("เงินเดือน :", , 0))
        With lstShow.Items
            .Clear()
            .Add("ตัวแปรแบบ Array")
            For i = CArr To 1 Step -1
                .Add("คนที่ :" & i)
                .Add("ชื่อ :" & EmpArr(i).Fname)
                .Add("อายุ :" & EmpArr(i).age)
                .Add("เงินเดือน :" & Format(EmpArr(i).Salary, "#,##0.00"))
                .Add("*******************")
            Next
        End With
    End Sub

    Private Sub btnDynamic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDynamic.Click
        CDy += 1
        ReDim Preserve EmpDy(CDy)
        EmpDy(CDy).Fname = InputBox("ชื่อ :" & CDy)
        EmpDy(CDy).age = Val(InputBox("อายุ :", , 0))
        EmpDy(CDy).Salary = Val(InputBox("เงินเดือน :", , 0))
        With lstShow.Items
            .Clear()
            .Add("ตัวแปรแบบ Dynamic Array")
            For i = CDy To 1 Step -1
                .Add("คนที่ :" & i)
                .Add("ชื่อ :" & EmpDy(i).Fname)
                .Add("อายุ :" & EmpDy(i).age)
                .Add("เงินเดือน :" & Format(EmpDy(i).Salary, "#,##0.00"))
                .Add("*******************")
            Next
        End With
    End Sub
End Class
