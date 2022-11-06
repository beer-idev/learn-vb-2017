Public Class Form1
    Const Max1 = 1 : Const Min1 = 1
    Dim Data1(Max1) As String
    Const minSize = 1
    Const maxsize = 1
    Dim Data(maxsize), list1(maxsize), list2(maxsize) As String
    Dim Gi As Integer

    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click
        Dim i As Integer
        Dim str As String = "เริ่มต้น : "
        For i = 1 To maxsize
            Data(i) = InputBox("Input Data: ", i, 0)
            str &= Data(i) & Space(8)
        Next
        lstShow.Items.Clear()
        lstShow.Items.Add(str)
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Call InsertionSort(Data, maxsize)
    End Sub
    Sub InsertionSort(ByVal data, ByVal max)
        Dim i, j, x As Integer
        Dim Str As String = ""
        For i = 2 To max
            x = data(i) : j = i - 1
            Do While (x < data(j)) And (j > 0)
                data(j + 1) = data(j)
                j -= 1
            Loop
            data(j + 1) = x
            Str = "รอบที่" & (i - 1) & ": "
            For i2 = 1 To max
                Str &= data(i2) & Space(8)
            Next
            lstShow.Items.Add(Str)
        Next
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Call SelectionSort(Data, maxsize)
    End Sub
    Sub SelectionSort(ByVal Data, ByVal max)
        Dim i, j, min As Integer
        Dim str As String = ""
        For i = 1 To max - 1
            min = i
            For j = i + 1 To max
                If Data(j) < Data(min) Then min = j
            Next
            Call swap(i, min)
            str = "รอบที่ " & i & " : "
            For i2 = 1 To max
                str &= Data(i2) & Space(8)
            Next
            lstShow.Items.Add(str)
        Next
    End Sub
    Sub swap(ByVal a, ByVal b)
        Dim Temp As Integer
        Temp = Data(a)
        Data(a) = Data(b)
        Data(b) = Temp
    End Sub

    Private Sub btnBubble_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBubble.Click
        Call BubbleSort(Data, maxsize)
    End Sub
    Sub BubbleSort(ByVal data, ByVal max)
        Dim i, j As Integer
        Dim str As String = ""
        For i = 2 To max
            For j = max To i Step -1
                If data(j) < data(j - 1) Then Call swap(j, j - 1)
            Next
            str = "รอบที่ " & (i - 1) & " : "
            For i2 = 1 To max
                str &= data(i2) & Space(8)
            Next
            lstShow.Items.Add(str)
        Next
    End Sub

    Private Sub btnQuick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuick.Click
        Gi = 0
        Call QuickSort(Data, minSize, maxsize)
    End Sub
    Sub QuickSort(ByVal data, ByVal min, ByVal max)
        Dim med_value, hi, lo, i As Integer
        Dim str As String = ""
        If min >= max Then Exit Sub
        med_value = data(min)
        lo = min
        hi = max
        Do 'do loop ใหญ่
            Do While data(hi) >= med_value 'do loop เล็กที่ 1
                hi = hi - 1
                If hi <= lo Then Exit Do
            Loop

            If hi <= lo Then 'if ตัวที่ 1
                data(lo) = med_value
                Exit Do
            End If

            data(lo) = data(hi)

            lo = lo + 1

            Do While data(lo) <= med_value 'do loop ตัวที่ 2
                lo = lo + 1
                If lo >= hi Then Exit Do
            Loop
            If lo >= hi Then 'if ตัวที่2
                lo = hi
                data(hi) = med_value
                Exit Do
            End If

            data(hi) = data(lo)
        Loop
        Gi += 1
        str = "รอบที่ " & Gi & " : "
        For i = 1 To max
            str &= data(i) & Space(8)
        Next
        lstShow.Items.Add(str)

        QuickSort(data, min, lo - 1)
        QuickSort(data, lo + 1, max)
    End Sub

    Private Sub btnMerge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMerge.Click
        Gi = 0
        Call MergeSort(Data, minSize, maxsize)
    End Sub
    Sub MergeSort(ByVal data, ByVal First, ByVal Last)
        Dim middle As Integer
        Dim Str As String

        If First < Last Then
            middle = (First + Last) \ 2
            Call MergeSort(data, First, middle)
            Call MergeSort(data, middle + 1, Last)
            Call Merge(data, First, middle, middle + 1, Last)
            Gi += 1 : Str = "รอบบที่ " & Gi & " : "
            For i = 1 To maxsize
                Str &= data(i) & Space(8)
            Next
            lstShow.Items.Add(Str)
        End If

    End Sub
    Sub Merge(ByVal data, ByVal LF, ByVal LL, ByVal RF, ByVal RL)
        Dim Temp(maxsize), index, CL, CR As Integer
        CL = LF : CR = RF
        index = LF
        Do While (CL <= LL) And (CR <= RL) ' loop 1
            If data(CL) < data(CR) Then
                Temp(index) = data(CL)
                CL = CL + 1
            Else
                Temp(index) = data(CR)
                CR = CR + 1
            End If
            index = index + 1
        Loop
        Do While CL <= LL ' loop 2
            Temp(index) = data(CL)
            CL += 1 : index += 1
        Loop
        Do While CR <= RL ' loop 3

            Temp(index) = data(CR)
            CR += 1 : index += 1
        Loop
        For index = LF To RL ' for 1
            data(index) = Temp(index)
        Next
    End Sub

    Private Sub btnMysort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMysort.Click
        Call MySort(Data1, Max1)
    End Sub
    Sub MySort(ByVal Data1, ByVal Maxs)
        Dim Str As String
        Dim i, j As Integer
        For i = 2 To Maxs
            For j = Maxs To i Step -1
                If Data1(j) > Data1(j - 1) Then
                    Call Swap1(j, j - 1)
                End If
            Next
            Str = "รอบที่" & (i - 1) & ":"
            For i2 = 1 To Maxs
                Str &= Data1(i2) & Space(8)
            Next
        Next
        With lstShow.Items
            .Add(StrReverse(Str))
        End With


    End Sub
    Sub Swap1(ByVal a, ByVal b)
        Dim Temp As String
        Temp = Data1(a)
        Data1(a) = Data1(b)
        Data1(b) = Temp
    End Sub


    Private Sub btnMy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMy.Click
        Dim i As Integer
        Dim str As String = "เริ่มต้น : "

        Data1(i) = InputBox("Input Data: ", i, 0)
        str &= Data1(i) & Space(8)

        lstShow.Items.Clear()
        lstShow.Items.Add(str)
    End Sub
End Class
