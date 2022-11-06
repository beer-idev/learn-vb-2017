Public Class Form1

    Private Sub btnMsgBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMsgBox.Click
        Dim a As Integer
        ' a = MsgBox("Select button", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Exclamation, "Select")'
        a = MsgBox("Select button", 3 + 16, "Select")
        If a = MsgBoxResult.Yes Then
            MsgBox("You Press Yes!!!")
        ElseIf a = MsgBoxResult.No Then
            MsgBox("You Press No!!!")
        ElseIf a = MsgBoxResult.Cancel Then
            MsgBox("You Press Cancel!!!")
        End If
    End Sub

    Private Sub btnMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMessage.Click
        Dim a As Integer
        a = MessageBox.Show("Press:", "Title", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2)
        If a = MsgBoxResult.Abort Then
            MsgBox("Press Abort")
        ElseIf a = MsgBoxResult.Retry Then
            MsgBox("Press Retry")
        ElseIf a = DialogResult.Ignore Then
            MsgBox("Press Ignore")
        End If
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim a As Integer
        a = MessageBox.Show("Exit Program", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If a = DialogResult.No Then e.Cancel = True
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnInputBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInputBox.Click
        Dim a
        a = InputBox("ป้อนรหัสเลขบัญชี", "รหัส", "00000", 400, 200)
        MsgBox("รหัส :" & a)
    End Sub
End Class
