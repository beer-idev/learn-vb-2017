Public Class Form1
    Const MAXSTACK As Integer = 40
    Dim Stack(0 To MAXSTACK) As String
    Dim TopOfStack As Integer
    Dim Str As String
    Dim StrInFix(0 To 50) As String
    Dim PriorityInfix(0 To 50) As Integer
    Dim PriorityStack(0 To 50) As Integer
    Dim StrPostfix(0 To 50) As String
    Dim I As Integer, J As Integer
    Dim X As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TopOfStack = 0
        X = 0
    End Sub

    Private Sub btnInfixPostfix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInfixPostfix.Click
        Str = txtInfix.Text
        txtInfix.Text = Str
        StrInFix(1) = Mid(Str, 1, 1)
        X = 1
        For II = 0 To 50
            StrPostfix(II) = ""
        Next
        Do While Len(Str) >= X
            X = X + 1
            StrInFix(X) = Mid(Str, X, 1)
        Loop
        I = 1
        J = 1
        'Do While StrInFix(I) <> "."
        Do While Len(Str) >= I
            If StrInFix(I) = "(" Then
                Push(StrInFix(I))
            ElseIf StrInFix(I) = ")" Then
                Do While Stack(TopOfStack) <> "(" And Stack(TopOfStack) <> ")"
                    If Stack(TopOfStack) <> "(" And Stack(TopOfStack) <> ")" Then
                        StrPostfix(J) = Stack(TopOfStack)
                    End If
                    Pop(Stack(TopOfStack))
                    J = J + 1
                Loop
                If Stack(TopOfStack) = "(" Then
                    Pop(Stack(TopOfStack))
                End If
            ElseIf StrInFix(I) = "+" Or StrInFix(I) = "-" Or StrInFix(I) = "*" Or StrInFix(I) = "/" Or StrInFix(I) = "^" Then
                Call SetPriorityInfix()
                If TopOfStack <= 0 Then
                    Push(StrInFix(I))
                ElseIf PriorityInfix(I) > PriorityStack(TopOfStack) Then
                    Push(StrInFix(I))
                Else
                    Do While (TopOfStack > 0) And (PriorityInfix(I) <= PriorityStack(TopOfStack) And Stack(TopOfStack) <> "(")
                        If Stack(TopOfStack) <> "(" And Stack(TopOfStack) <> ")" Then
                            StrPostfix(J) = Stack(TopOfStack)
                        End If
                        Pop(Stack(TopOfStack))
                        J = J + 1
                        If TopOfStack = 0 Then
                            Exit Do
                        End If
                    Loop
                    Push(StrInFix(I))
                End If
            Else
                StrPostfix(J) = StrInFix(I)
                J = J + 1
            End If
            I = I + 1
        Loop
        Do While TopOfStack <> 0
            If Stack(TopOfStack) <> "(" And Stack(TopOfStack) <> ")" Then
                StrPostfix(J) = Stack(TopOfStack)
            End If
            Pop(Stack(TopOfStack))
            J = J + 1
        Loop
        Str = Join(StrPostfix, "")
        lblPostfix.Text = ""
        lblPostfix.Text = Str
    End Sub
    Public Sub Push(ByVal Element As String)
        If TopOfStack >= MAXSTACK Then
            MsgBox("Stack Full")
        Else
            TopOfStack = TopOfStack + 1
            Stack(TopOfStack) = Element
            Call SetPriorityStack()
        End If
    End Sub
    Public Sub Pop(ByVal Element As String)
        If TopOfStack <= 0 Then
            MsgBox("Stack Empty")
        Else
            Element = Stack(TopOfStack)
            TopOfStack = TopOfStack - 1
        End If
    End Sub
    Public Sub SetPriorityInfix()
        Select Case StrInFix(I)
            Case "("
                PriorityInfix(I) = 0
            Case ")"
                PriorityInfix(I) = 0
            Case "+"
                PriorityInfix(I) = 1
            Case "-"
                PriorityInfix(I) = 1
            Case "*"
                PriorityInfix(I) = 2
            Case "/"
                PriorityInfix(I) = 2
            Case "^"
                PriorityInfix(I) = 3
        End Select
    End Sub
    Public Sub SetPriorityStack()
        Select Case Stack(TopOfStack)
            Case "("
                PriorityStack(TopOfStack) = 0
            Case ")"
                PriorityStack(TopOfStack) = 0
            Case "+"
                PriorityStack(TopOfStack) = 1
            Case "-"
                PriorityStack(TopOfStack) = 1
            Case "*"
                PriorityStack(TopOfStack) = 2
            Case "/"
                PriorityStack(TopOfStack) = 2
            Case "^"
                PriorityStack(TopOfStack) = 3
        End Select
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lblPostfix.Text = ""
        txtInfix.Text = ""
        I = 0 : J = 0 : X = 0

    End Sub
End Class
