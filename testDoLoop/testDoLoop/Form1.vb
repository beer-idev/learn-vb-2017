Public Class Form1

    Private Sub btnDoWhile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoWhile.Click
        Dim a As Integer = Val(InputBox("Input Number loop"))
        Dim i As Integer
        lstShow.Items.Clear()
        lstShow.Items.Add("Do While......Loop")
        Do While i < a
            i += 1
            lstShow.Items.Add(i)
        Loop
    End Sub

    Private Sub btnDoUntil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoUntil.Click
        Dim a As Integer = Val(InputBox("input Numbar loop"))
        Dim i As Integer
        lstShow.Items.Clear()
        lstShow.Items.Add("Do Until......Loop")
        Do Until i > a - 1
            i += 1
            lstShow.Items.Add(i)
        Loop
    End Sub

    Private Sub btnLoopUntil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoopUntil.Click
        Dim a As Integer = Val(InputBox("input Numbar loop"))
        Dim i As Integer
        lstShow.Items.Clear()
        lstShow.Items.Add("Do......Loop Until")
        a += 1
        i = 2
        Do
            a -= 1
            lstShow.Items.Add(a)
        Loop Until i > a

    End Sub

    Private Sub btnLoopWhile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoopWhile.Click
        Dim a As Integer = Val(InputBox("input Numbar loop"))
        Dim i As Integer
        lstShow.Items.Clear()
        lstShow.Items.Add("Do......Loop While")
        a += 1
        i = 1
        Do
            a -= 1
            lstShow.Items.Add(a)
        Loop While i < a
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub
End Class
