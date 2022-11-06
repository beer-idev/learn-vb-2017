Public Class Form1
    Const MaxStack As Integer = 5
    Dim Stack(MaxStack) As Integer
    Dim Top As Integer
    '*******เปลี่ยนแปลงสมาชิกของสแตค
    Dim Stack1() As Integer
    Dim StackSize As Integer

    Dim strInput(), strWord, M10ut, strM As String
    Dim Count, i, o As Integer
    Dim Stacks As String

    Private Sub btnPush_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPush.Click
        Call Push()
    End Sub
    Sub Push()
        If Top >= MaxStack Then
            MsgBox("Stack Full")
        Else
            Top += 1
            Stack(Top) = InputBox("Inpuit Nember:", , 0)
            lstShow.Items.Insert(0, Top & " : " & Stack(Top))
        End If
    End Sub

    Private Sub btnPop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPop.Click
        Call Pop()

    End Sub
    Sub Pop()
        If Top <= 0 Then
            MsgBox("Stack Empty")
        Else
            Top -= 1
            MsgBox("Pop : " & Stack(Top))
            lstShow.Items.RemoveAt(0)
        End If
    End Sub

    Private Sub btnPush1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPush1.Click

        Call Push1()
    End Sub
    Sub Push1()
        StackSize += 1
        ReDim Preserve Stack1(StackSize)
        Stack1(StackSize) = InputBox("Enter Value", , 0)
        lstShow.Items.Insert(0, StackSize & " : " & Stack1(StackSize))
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StackSize = 0
    End Sub

    Private Sub btnPop1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPop1.Click
        Call Pop1()
    End Sub
    Sub Pop1()
        If StackSize <= 0 Then
            MsgBox("Stack Empty!!!")
        Else
            StackSize -= 1
            MsgBox("Pop : " & Stack1(StackSize))
            If StackSize <> 0 Then
                ReDim Preserve Stack1(StackSize)
            End If
            lstShow.Items.RemoveAt(0)
        End If

    End Sub

    Private Sub btnReverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReverse.Click

        ReDim Preserve strInput(Stacks)
        strInput(Stacks) = InputBox("Enter Value" & Stacks)
        Count = Len(strInput(Stacks))
        M10ut = ""
        With lstShow.Items
            .Clear()
            .Add(" " & strInput(Stacks))
            For i = 1 To Count
                strWord = Microsoft.VisualBasic.Right(strInput(Stacks), Count)
                For o = 1 To Count Step -1
                    strM = Microsoft.VisualBasic.Left(strInput(Stacks), 1)
                    .Add("  " & strM)
                Next
                .Add(" " & strWord)
            Next

        End With

    End Sub
End Class
