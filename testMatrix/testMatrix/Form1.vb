Public Class Form1
    Dim Rsize, Csize As Integer
    Dim M1(5, 5), M2(5, 5), AddM(5, 5) As Integer
    Dim Rin, Cin As Integer
    Dim M1Out, M2Out, AddMOut As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnM1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnM1.Click
        Rsize = Val(txtRsize.Text)
        Csize = Val(txtCsize.Text)
        M1Out = ""
        For Rin = 1 To Rsize
            For Cin = 1 To Csize
                M1(Rin, Cin) = Val(InputBox("Enter Matrix1", "Matrix1", 0))
                M1Out &= M1(Rin, Cin) & Space(8)
            Next
            M1Out &= vbCrLf
        Next
        txtM1.Text = M1Out
    End Sub

    Private Sub btnM2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnM2.Click
        Rsize = Val(txtRsize.Text)
        Csize = Val(txtCsize.Text)
        M2Out = ""
        For Rin = 1 To Rsize
            For Cin = 1 To Csize
                M2(Rin, Cin) = Val(InputBox("Enter Matrix2", "Matrix2", 0))
                M2Out &= M2(Rin, Cin) & Space(8)
            Next
            M2Out &= vbCrLf
        Next
        txtM2.Text = M2Out
    End Sub

    Private Sub btnAddM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddM.Click
        Rsize = Val(txtRsize.Text)
        Csize = Val(txtCsize.Text)
        AddMOut = ""
        For Rin = 1 To Rsize
            For Cin = 1 To Csize
                AddM(Rin, Cin) = M1(Rin, Cin) + M2(Rin, Cin)
                AddMOut &= AddM(Rin, Cin) & Space(8)
            Next
            AddMOut &= vbCrLf
        Next
        txtAddM.Text = AddMOut
    End Sub
End Class
