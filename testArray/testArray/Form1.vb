Public Class Form1
    Const max As Integer = 10
    Dim Fname(max) As String
    Dim Salary(max) As Single
    Dim count As Integer
    Dim total As Single
    'ประกาศตัวแปลแบบไดนามิกอาร์เรย์
    Dim Cdy As Integer
    Dim Fdy() As String
    Dim Sdy() As Single
    Dim sum As Single
    'การประกาศตัวแปรแบบ 2 มิติ
    Dim Fname2(max, 2) As String
    Dim C2M As Integer

    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click
        If count > max Then
            MsgBox("Full Data")
        Else
            count += 1
            Fname(count) = InputBox("Input name:#" & count)
            Salary(count) = Val(InputBox("Input Salary:#" & count, , 0))
            With lstShow.Items
                .Clear()
                .Add("คนที่ :" & count)
                .Add("ชื่อ :" & Fname(count))
                .Add("เงินเดือน :" & Format(Salary(count), "#,##0.00"))
                .Add("*****************")
            End With
        End If
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        With lstShow.Items
            .Clear()
            For i = 1 To count
                .Add("คนที่ :" & i)
                .Add("ชื่อ :" & Fname(i))
                .Add("เงินเดือน :" & Format(Salary(i), "#,##0,00"))
                .Add("*******************")
                total = Salary(i) + total
            Next
            .Add("รวมเงินเดือน :" & Format(total, "#,##0,00"))
        End With
    End Sub

    Private Sub btnInputDy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInputDy.Click
        Cdy += 1
        ReDim Preserve Fdy(Cdy)
        ReDim Preserve Sdy(Cdy)
        Fdy(Cdy) = InputBox("Input Name:#" & Cdy)
        Sdy(Cdy) = InputBox("Input Salary:#" & Cdy)
        With lstShow.Items
            .Clear()
            .Add("Dynamic Array")
            .Add("คนที่ :" & Cdy)
            .Add("ชื่อ :" & Fdy(Cdy))
            .Add("เงินเดือน :" & Format(Sdy(Cdy), "#,##0.00"))
            .Add("****************************")
        End With
    End Sub

    Private Sub btnShowDy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowDy.Click
        With lstShow.Items
            .Clear()
            .Add("Dynamic Array")
            For i = Cdy To 1 Step -1
                .Add("คนที่ :" & i)
                .Add("ชื่อ :" & Fdy(i))
                .Add("เงินเดือน :" & Format(Sdy(i), "#,##0.00"))
                .Add("**************************")
                sum = (Sdy(i) + sum) / Cdy
            Next
            .Add("รวมเงินเดือน :" & Format(sum, "#,##0,00"))
        End With
    End Sub

    Private Sub btn2Miti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2Miti.Click
        C2M += 1
        Fname2(C2M, 0) = InputBox("คำนำหนน้า คนที่ :" & C2M, , "นาย")
        Fname2(C2M, 1) = InputBox("ชื่อคนที่ :" & C2M)
        Fname2(C2M, 2) = InputBox("นามสกุล คนที่ :" & C2M)
        With lstShow.Items
            .Clear()
            .Add("คนที่ :" & C2M)
            .Add("คำนำหน้า :" & Fname2(C2M, 0))
            .Add("ชื่อ :" & Fname2(C2M, 1))
            .Add("นามสกุล :" & Fname2(C2M, 2))
        End With
    End Sub

    Private Sub btnShow2Miti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow2Miti.Click
        With lstShow.Items
            .Clear()
            For i = 1 To C2M
                .Add("คนที่ :" & i)
                .Add("คำนำหน้า :" & Fname2(i, 0))
                .Add("ชื่อ :" & Fname2(i, 1))
                .Add("นามสกุล :" & Fname2(i, 2))
                .Add("**************************")
            Next

        End With
    End Sub
End Class
