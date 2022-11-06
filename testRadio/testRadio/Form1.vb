Public Class Form1

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim strShow As String = "เพศ: "
        If rbMale.Checked = True Then
            strShow &= rbMale.Text
        Else
            strShow &= rbFemale.Text
        End If
        strShow &= vbCrLf & "สถานะ: "
        If rbSingle.Checked Then
            strShow &= rbSingle.Text
        ElseIf rbMarry.Checked Then
            strShow &= rbMarry.Text
        ElseIf rbYa.Checked Then
            strShow &= rbYa.Text
        Else
            strShow &= rbMai.Text
        End If
        strShow &= vbCrLf & "กีฬาที่ชื่นชอบ: "
        If chkFootball.Checked Then
            strShow &= chkFootball.Text & ", "
        End If
        If ChkBadminton.Checked Then
            strShow &= ChkBadminton.Text & ", "
        End If
        If ChkPatong.Checked Then
            strShow &= ChkPatong.Text & ", "
        End If
        If ChkValleyball.Checked Then
            strShow &= ChkValleyball.Text & ", "
        End If
        If ChkTennis.Checked Then
            strShow &= ChkTennis.Text & ", "
        End If
        If ChkOther.Checked Then
            strShow &= ChkOther.Text
        End If
        strShow &= " เช่น " & TxtOther.Text
        MessageBox.Show(strShow)
    End Sub

    Private Sub ChkOther_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkOther.CheckedChanged
        If ChkOther.Checked Then
            TxtOther.Visible = True
        Else
            TxtOther.Visible = False
        End If
    End Sub

    Private Sub btnShow2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow2.Click
        Dim a As String = "เพศ: "
        Dim objS As Object
        For Each objS In Me.grbGander.Controls
            If TypeOf objS Is RadioButton And objS.checked Then
                a &= objS.text : Exit For
            End If
        Next
        a &= vbCrLf & "สถานะ: "
        For Each objS In Me.grbStatus.Controls
            If TypeOf objS Is RadioButton And objS.checked Then
                a &= objS.text : Exit For

            End If
        Next
        a &= vbCrLf & "กีฬาที่ชื่นชอบ: "
        For Each objS In Me.grbSport.Controls
            If TypeOf objS Is CheckBox Then
                If objS.checked Then
                    a &= objS.text & " "
                    If objS Is ChkOther Then a &= " เช่น " & TxtOther.Text & " "
                End If
            End If
        Next
        MsgBox(a)
    End Sub

    Private Sub rbMale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMale.CheckedChanged

    End Sub
End Class

