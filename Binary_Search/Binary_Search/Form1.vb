Public Class Form1
    Const Max_Size = 15
    Dim info(Max_Size), LLink(Max_Size) As Integer
    Dim RLink(Max_Size), x, y As Integer

    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click
        Dim z, s, m, f As Integer
        y = Val(InputBox("นับค่าที่เป็นตัวเลข ", "Binary", 0))
        If x = 1 Then
            info(x) = y : LLink(x) = -1 : RLink(x) = -1
            x += 1
        Else
            m = x
            info(x) = y : LLink(x) = -1 : RLink(x) = -1
            x += 1 : z = 1
            Do While s = 0
                If y >= info(z) Then
                    If RLink(z) = -1 Then
                        RLink(z) = m
                        s = 1
                    Else
                        z = RLink(z)
                    End If
                Else
                    If LLink(z) = -1 Then
                        LLink(z) = m
                        s = 1
                    Else
                        z = LLink(z)
                    End If
                End If
            Loop
        End If
        With lstShow.Items
            .Clear()
            .Add("**********************************************************************")
            .Add(Space(20) & "Binary Search Tree")
            .Add("ลำดับ Data Right Child Node Left Child Node")
            .Add("**********************************************************************")
            For f = 1 To x - 1
                .Add(f & Space(8) & info(f) & Space(15) & RLink(f) & Space(20) & LLink(f))
            Next
        End With
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        x = 1
    End Sub

    Private Sub btnBinary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBinary.Click
        Dim z, compare_count, key As Integer
        Dim found As Integer
        found = 0
        z = 1
        compare_count = 0
        key = Val(InputBox("รับค่าตัววเลขที่ต้องการค้นหา ", , 0))
        Do While z <> -1
            compare_count += 1
            If key > info(z) Then
                z = RLink(z)
            ElseIf key < info(z) Then
                z = LLink(z)
            ElseIf key = info(z) Then
                found = 1
                Exit Do
            End If
        Loop
        If found = 0 Then
            MsgBox("ไม่พบข้อมูล :" & key)
        Else
            MsgBox("พบ :" & key & " เปรียบเทียบทั้งหมด :" & compare_count & "ครั้ง")
        End If
    End Sub
End Class
