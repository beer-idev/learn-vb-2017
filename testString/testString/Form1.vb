Public Class Form1

    Private Sub btnStrReverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStrReverse.Click
        Dim Strinput, Result As String
        Strinput = txtInput.Text
        Result = StrReverse(Strinput)
        With lstShow.Items
            .Clear()
            .Add("Input :" & Strinput)
            .Add("Reverse :" & Result)
            .Add("********************")
        End With
    End Sub

    Private Sub btnReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplace.Click
        Dim strInput, strFind, strRpl, Result1, Result2, Result3 As String
        Dim Start, Count, Compare As Integer
        strInput = txtInput.Text
        strFind = txtFind.Text
        strRpl = txtRpl.Text
        Start = Val(txtStart.Text)
        Count = Val(txtCount.Text)
        If Start = 0 Then Start = 1
        If Count = 0 Then Count = -1
        If rdText.Checked Then Compare = 1
        Result1 = Replace(strInput, strFind, strRpl)
        Result2 = Replace(strInput, strFind, strRpl, 1, -1, CompareMethod.Text)
        Result3 = Replace(strInput, strFind, strRpl, Start, Count, Compare)
        With lstShow.Items
            .Clear()
            .Add("Input :" & strInput)
            .Add("Find :" & strFind)
            .Add("Replace :" & strRpl)
            .Add("Start :" & Start)
            .Add("Count :" & Count)
            .Add("Compare :" & Compare)
            .Add("*********************")
            .Add("Result1 :" & Result1)
            .Add("Result2 :" & Result2)
            .Add("Result3 :" & Result3)
            .Add("*********************")
        End With

    End Sub

    Private Sub btnLen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLen.Click
        Dim strInput As String
        Dim IntResult As Integer
        strInput = txtInput.Text
        IntResult = Len(strInput)
        With lstShow.Items
            .Clear()
            .Add("Input :" & strInput)
            .Add("Len :" & IntResult)
            .Add("*****************")

        End With
    End Sub

    Private Sub btnLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeft.Click
        Dim strInput, Result As String
        Dim Count As Integer
        strInput = LTrim(txtInput.Text)
        'ฟังก์ชั่น LTRIM() ตัดช่องว่างด้านซ้ายทิ้ง
        Count = Val(txtFind.Text)
        Result = Microsoft.VisualBasic.Left(strInput, Count)
        With lstShow.Items
            .Clear()
            .Add("Fucntion Left")
            .Add("Input :" & strInput)
            .Add("Count :" & Count)
            .Add("Result :" & Result)
            .Add("******************")

        End With
    End Sub

    Private Sub btnRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRight.Click
        Dim strInput, Result As String
        Dim Count As Integer
        strInput = RTrim(txtInput.Text)
        'ฟังก์ชั่น RTRIM() ตัดช่องว่างด้านขวาทิ้ง หรือด้านหลัง
        strInput = LTrim(RTrim(txtInput.Text))
        strInput = Trim(txtInput.Text)
        'ฟังก์ชั่น TRIM() ตัดช่องว่างทั้งด้านซ้ายและขวา หรือทั้งด้านหน้าและด้านหลัง
        Count = Val(txtFind.Text)
        Result = Microsoft.VisualBasic.Right(strInput, Count)
        With lstShow.Items
            .Clear()
            .Add("Fucntion Right")
            .Add("Input :" & strInput)
            .Add("Right :" & Count)
            .Add("Result :" & Result)
            .Add("******************")

        End With
    End Sub

    Private Sub btnMid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMid.Click
        Dim strInput, Result As String
        Dim Start, count As Integer
        strInput = Trim(txtInput.Text)
        Start = Val(txtStart.Text)
        count = Val(txtCount.Text)
        If Start <= 0 Then Start = 1
        If count > 0 Then
            Result = Mid(strInput, Start, count)
        Else
            Result = Mid(strInput, Start)
        End If
        With lstShow.Items
            .Clear()
            .Add("Function Mid()")
            .Add("Input :" & strInput)
            .Add("Start :" & Start)
            .Add("Count :" & count)
            .Add("*********************")
            .Add("Result  :" & Result)
            .Add("*********************")
        End With
    End Sub

    Private Sub btnInStr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInStr.Click
        Dim strInput, strFind As String
        Dim Start, compare, Result As Integer
        strInput = txtInput.Text
        strFind = txtFind.Text
        Start = Val(txtStart.Text)
        If Start <= 0 Then Start = 1
        If rdText.Checked Then compare = 1
        Result = InStr(Start, strInput, strFind, compare)
        With lstShow.Items
            .Clear()
            .Add("Function Mid()")
            .Add("Input :" & strInput)
            .Add("Find :" & strFind)
            .Add("Start :" & Start)
            .Add("Compare :" & compare)
            .Add("*********************")
            .Add("Result  :" & Result)
            .Add("*********************")
        End With

    End Sub

    Private Sub btnFullName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFullName.Click

        Dim strInput, Bname, Fname, Lname, UFname, ULname As String
        Dim countB, countF, countFname, countLname As Integer
        Dim Count As String

        strInput = Trim(txtInput.Text)
        Count = Len(strInput)

        countB = InStr(strInput, ".")
        countF = InStr(strInput, " ")
        If countF <> 0 Then
            Bname = UCase(Mid(strInput, 1, countB))
            Fname = Mid(strInput, countB + 1, countF - countB)
            Lname = Mid(strInput, countF + 1, Count - countF)

            countFname = Len(Fname)
            countLname = Len(Lname)

            UFname = UCase(Mid(Fname, 1, 1)) & LCase(Mid(Fname, 2, countFname - 1))
            ULname = UCase(Mid(Lname, 1, 1)) & LCase(Mid(Lname, 2, countLname - 1))

        Else
            UFname = strInput
        End If
        With lstshow.Items
            .Clear()
            .Add("Full Name : " & strInput)
            .Add("Fist Name : " & UFname)
            .Add("Last Name : " & ULname)
        End With
    End Sub

    Private Sub btnFullName2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFullName2.Click
        Dim strInput, Bname, Fname, Lname, UFname, ULname, Mname, UMname As String
        Dim countB, countF, countFname, countLname, countMname, countM As Integer
        Dim Count As Decimal

        strInput = Trim(txtInput.Text)
        Count = Len(strInput)


        
        countB = InStr(strInput, ".")
        countF = InStr(strInput, " ")
        countMname = InStr(strInput, " ")
        If countF <> 0 Then
            Bname = UCase(Mid(strInput, 1, countB))
            Mname = UCase(Mid(strInput, 1, countB))
            Fname = Mid(strInput, countB + 1, countF - countB)
            Lname = Mid(strInput, countF + 1, Count - countF)

            countMname = Len(Mname)
            countFname = Len(Fname)
            countLname = Len(Lname)
            UFname = UCase(Mid(Fname, 1, 1)) & LCase(Mid(Fname, 2, countFname - 1))
            ULname = UCase(Mid(Lname, 1, 1)) & LCase(Mid(Lname, 2, countLname - 1))

        Else
            UFname = strInput
        End If
        With lstShow.Items
            .Clear()
            .Add("Full name : " & strInput)
            .Add("Mname :" & Mname)
            .Add("Fname : " & UFname)
            .Add("Lname : " & ULname)
        End With
    End Sub

    Private Sub btnFullName3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFullName3.Click
        Dim strInput, Bname, Fname, Lname, Cname, Dname, UFname, ULname, UDname As String
        Dim countB, countF, countC, countD, countFname, countLname, countCname, countDname As Integer
        Dim Count As Decimal
        strInput = txtInput.Text
        Count = Len(strInput)
        countB = InStr(strInput, ".")
        countF = InStr(strInput, " ")
        countC = InStr(strInput, " ")
        countD = InStr(strInput, "")
        countCname = InStr(strInput, " ")
        If countF <> 0 Then
            Bname = UCase(Mid(strInput, 1, countB))
            Cname = UCase(Mid(strInput, 1, countB))
            Fname = Mid(strInput, countB + 1, countF - countB)
            Lname = Mid(strInput, countF + 1, Count - countF)
            Dname = Mid(strInput, countD + 1, Count - countD)
            countCname = Len(Cname)
            countFname = Len(Fname)
            countLname = Len(Lname)
            countDname = Len(Dname)
            UFname = UCase(Mid(Fname, 1, 1)) & LCase(Mid(Fname, 2, countFname - 1))
            ULname = UCase(Mid(Lname, 1, 1)) & LCase(Mid(Lname, 2, countLname - 1))
            UDname = UCase(Mid(Dname, 1, 1)) & LCase(Mid(Dname, 2, countDname - 1))
        Else
            UFname = strInput
        End If
        With lstShow.Items
            .Clear()
            .Add("Full name : " & strInput)
            .Add("1 :" & UFname)
            .Add("2 : " & ULname)
            .Add("3 :" & UDname)
        End With
    End Sub

    Private Sub bttnSpritWord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSpritWord.Click
        Dim intSpace, IntF, i As Integer
        Dim StrInput, StrWod As String
        IntF = 1
        i = 1
        StrInput = Trim(txtInput.Text)
        intSpace = InStr(StrInput, " ")
        With lstShow.Items
            .Clear()
            .Add("Input :" & StrInput)
            Do While intSpace <> 0
                StrWod = Mid(StrInput, IntF, intSpace)
                StrInput = Trim(Mid(StrInput, intSpace))
                .Add(i & " : " & StrWod)
                intSpace = InStr(StrInput, " ")
                i += 1

            Loop
            .Add(i & " : " & StrInput)
        End With
    End Sub

    Private Sub btnSpritWord1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpritWord1.Click
        Dim strInput, strWord, Count As String
        Dim i, Space As Integer
        Space = 1
        strInput = Trim(txtInput.Text)

        With lstShow.Items
            .Clear()
            .Add("Input :" & strInput)
            For i = 1 To Len(strInput)
                strWord = Mid(strInput, i, 1)
                If strWord <> " " Then

                    Count &= strWord
                Else
                    If Count <> "" Then
                        .Add(Space & " : " & Count)
                        Space += 1
                        Count = ""
                    End If
                End If

            Next
            .Add(Space & " : " & Count)
           
        End With
    End Sub

    Private Sub btnSplit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSplit.Click
        Dim strInput, strDel, Arr() As String
        Dim count, Compare As Integer

        strInput = Trim(txtInput.Text)
        strDel = txtFind.Text
        count = Val(txtCount.Text)
        If count = 0 Then count = -1
        If rdText.Checked Then Compare = 1
        Arr = Split(strInput, strDel, count, Compare)
        With lstShow.Items
            .Clear()
            .Add("Input :" & strInput)
            .Add("Delimiter :" & strDel)
            For i = 0 To UBound(Arr)
                .Add(i & " : " & Arr(i))

            Next
        End With
    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        Dim x, Last As Integer
        Dim strResult() As String
        Dim VarL() As String = {"september", "separate", "observe", "unseparete"}
        strResult = Filter(VarL, "sep", True, 0)
        With lstShow.Items
            .Clear()
            .Add("Data :")
            For x = 0 To UBound(VarL)
                .Add(x & " : " & VarL(x))
            Next
            .Add("*******")
            For x = 0 To UBound(strResult)
                .Add(x & " : " & strResult(x))
            Next
        End With
    End Sub

    Private Sub btnFilter1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter1.Click
        Dim x, ig As Integer
        Dim strResult() As String
        Dim strDel, strInput As String
        Dim VarL(), Arr() As String
        strInput = Trim(txtInput.Text)
        strDel = txtFind.Text
        Arr = Split(strInput, strDel)
        strResult = Filter(Arr, strDel, True, 0)
        With lstShow.Items
            .Clear()
           
            .Add("Data :")
            For i = 0 To UBound(Arr)
                .Add(i & " : " & Arr(i))
            Next
            .Add("*******")
            For x = 0 To UBound(strResult)
                .Add(x & " : " & strResult(x))
            Next
        End With
    End Sub

    Private Sub btnJoin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJoin.Click
        Dim strDel, result As String
        Dim VarL() As String = {"pencil", "book", "ruler"}
        strDel = txtFind.Text
        result = Join(VarL, strDel)
        With lstShow.Items
            .Clear()
            .Add("Data : ")
            For i = 0 To UBound(VarL)
                .Add(i & " : " & VarL(i))

            Next
            .Add("*********")
            .Add("Join : " & result)
        End With
    End Sub
End Class
