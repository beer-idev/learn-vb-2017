<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lstShow = New System.Windows.Forms.ListBox()
        Me.btnStrReverse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRpl = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStart = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rdBinary = New System.Windows.Forms.RadioButton()
        Me.rdText = New System.Windows.Forms.RadioButton()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.btnLen = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnMid = New System.Windows.Forms.Button()
        Me.btnInStr = New System.Windows.Forms.Button()
        Me.btnFullName = New System.Windows.Forms.Button()
        Me.btnFullName2 = New System.Windows.Forms.Button()
        Me.btnFullName3 = New System.Windows.Forms.Button()
        Me.bttnSpritWord = New System.Windows.Forms.Button()
        Me.btnSpritWord1 = New System.Windows.Forms.Button()
        Me.btnSplit = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnFilter1 = New System.Windows.Forms.Button()
        Me.btnJoin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(176, 53)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(184, 22)
        Me.txtInput.TabIndex = 0
        '
        'lstShow
        '
        Me.lstShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstShow.FormattingEnabled = True
        Me.lstShow.ItemHeight = 16
        Me.lstShow.Location = New System.Drawing.Point(504, 42)
        Me.lstShow.Name = "lstShow"
        Me.lstShow.Size = New System.Drawing.Size(381, 388)
        Me.lstShow.TabIndex = 1
        '
        'btnStrReverse
        '
        Me.btnStrReverse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStrReverse.Location = New System.Drawing.Point(94, 476)
        Me.btnStrReverse.Name = "btnStrReverse"
        Me.btnStrReverse.Size = New System.Drawing.Size(120, 43)
        Me.btnStrReverse.TabIndex = 2
        Me.btnStrReverse.Text = "StrReverse"
        Me.btnStrReverse.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "รับข้อมูล"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(91, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "คำค้นหา"
        '
        'txtFind
        '
        Me.txtFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFind.Location = New System.Drawing.Point(176, 102)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(184, 22)
        Me.txtFind.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(91, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "คำแทนที่"
        '
        'txtRpl
        '
        Me.txtRpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRpl.Location = New System.Drawing.Point(176, 150)
        Me.txtRpl.Name = "txtRpl"
        Me.txtRpl.Size = New System.Drawing.Size(184, 22)
        Me.txtRpl.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(91, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "เริ่มต้น"
        '
        'txtStart
        '
        Me.txtStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStart.Location = New System.Drawing.Point(176, 200)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(184, 22)
        Me.txtStart.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(91, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "จำนวนครั้ง"
        '
        'txtCount
        '
        Me.txtCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCount.Location = New System.Drawing.Point(176, 248)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(184, 22)
        Me.txtCount.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(91, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "การเปรียบเทียบ"
        '
        'rdBinary
        '
        Me.rdBinary.AutoSize = True
        Me.rdBinary.Checked = True
        Me.rdBinary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdBinary.Location = New System.Drawing.Point(201, 312)
        Me.rdBinary.Name = "rdBinary"
        Me.rdBinary.Size = New System.Drawing.Size(70, 20)
        Me.rdBinary.TabIndex = 13
        Me.rdBinary.TabStop = True
        Me.rdBinary.Text = "Binary"
        Me.rdBinary.UseVisualStyleBackColor = True
        '
        'rdText
        '
        Me.rdText.AutoSize = True
        Me.rdText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdText.Location = New System.Drawing.Point(325, 312)
        Me.rdText.Name = "rdText"
        Me.rdText.Size = New System.Drawing.Size(56, 20)
        Me.rdText.TabIndex = 14
        Me.rdText.Text = "Text"
        Me.rdText.UseVisualStyleBackColor = True
        '
        'btnReplace
        '
        Me.btnReplace.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReplace.Location = New System.Drawing.Point(240, 476)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(120, 43)
        Me.btnReplace.TabIndex = 15
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'btnLen
        '
        Me.btnLen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLen.Location = New System.Drawing.Point(387, 476)
        Me.btnLen.Name = "btnLen"
        Me.btnLen.Size = New System.Drawing.Size(120, 43)
        Me.btnLen.TabIndex = 16
        Me.btnLen.Text = "Len"
        Me.btnLen.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeft.Location = New System.Drawing.Point(537, 476)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(120, 43)
        Me.btnLeft.TabIndex = 17
        Me.btnLeft.Text = "Left"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRight.Location = New System.Drawing.Point(686, 476)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(120, 43)
        Me.btnRight.TabIndex = 18
        Me.btnRight.Text = "Right"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnMid
        '
        Me.btnMid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMid.Location = New System.Drawing.Point(94, 536)
        Me.btnMid.Name = "btnMid"
        Me.btnMid.Size = New System.Drawing.Size(120, 43)
        Me.btnMid.TabIndex = 19
        Me.btnMid.Text = "Mid"
        Me.btnMid.UseVisualStyleBackColor = True
        '
        'btnInStr
        '
        Me.btnInStr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInStr.Location = New System.Drawing.Point(240, 536)
        Me.btnInStr.Name = "btnInStr"
        Me.btnInStr.Size = New System.Drawing.Size(120, 43)
        Me.btnInStr.TabIndex = 20
        Me.btnInStr.Text = "InStr"
        Me.btnInStr.UseVisualStyleBackColor = True
        '
        'btnFullName
        '
        Me.btnFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFullName.Location = New System.Drawing.Point(387, 536)
        Me.btnFullName.Name = "btnFullName"
        Me.btnFullName.Size = New System.Drawing.Size(120, 43)
        Me.btnFullName.TabIndex = 21
        Me.btnFullName.Text = "Full Name"
        Me.btnFullName.UseVisualStyleBackColor = True
        '
        'btnFullName2
        '
        Me.btnFullName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFullName2.Location = New System.Drawing.Point(537, 536)
        Me.btnFullName2.Name = "btnFullName2"
        Me.btnFullName2.Size = New System.Drawing.Size(120, 43)
        Me.btnFullName2.TabIndex = 22
        Me.btnFullName2.Text = "Full Name 2"
        Me.btnFullName2.UseVisualStyleBackColor = True
        '
        'btnFullName3
        '
        Me.btnFullName3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFullName3.Location = New System.Drawing.Point(686, 536)
        Me.btnFullName3.Name = "btnFullName3"
        Me.btnFullName3.Size = New System.Drawing.Size(120, 43)
        Me.btnFullName3.TabIndex = 23
        Me.btnFullName3.Text = "Full Name 3"
        Me.btnFullName3.UseVisualStyleBackColor = True
        '
        'bttnSpritWord
        '
        Me.bttnSpritWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSpritWord.Location = New System.Drawing.Point(94, 597)
        Me.bttnSpritWord.Name = "bttnSpritWord"
        Me.bttnSpritWord.Size = New System.Drawing.Size(120, 43)
        Me.bttnSpritWord.TabIndex = 24
        Me.bttnSpritWord.Text = "Sprit Word"
        Me.bttnSpritWord.UseVisualStyleBackColor = True
        '
        'btnSpritWord1
        '
        Me.btnSpritWord1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpritWord1.Location = New System.Drawing.Point(240, 597)
        Me.btnSpritWord1.Name = "btnSpritWord1"
        Me.btnSpritWord1.Size = New System.Drawing.Size(120, 43)
        Me.btnSpritWord1.TabIndex = 25
        Me.btnSpritWord1.Text = "Sprit Word 1"
        Me.btnSpritWord1.UseVisualStyleBackColor = True
        '
        'btnSplit
        '
        Me.btnSplit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSplit.Location = New System.Drawing.Point(387, 597)
        Me.btnSplit.Name = "btnSplit"
        Me.btnSplit.Size = New System.Drawing.Size(120, 43)
        Me.btnSplit.TabIndex = 26
        Me.btnSplit.Text = "Split "
        Me.btnSplit.UseVisualStyleBackColor = True
        '
        'btnFilter
        '
        Me.btnFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.Location = New System.Drawing.Point(537, 597)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(120, 43)
        Me.btnFilter.TabIndex = 27
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'btnFilter1
        '
        Me.btnFilter1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter1.Location = New System.Drawing.Point(686, 597)
        Me.btnFilter1.Name = "btnFilter1"
        Me.btnFilter1.Size = New System.Drawing.Size(120, 43)
        Me.btnFilter1.TabIndex = 28
        Me.btnFilter1.Text = "Filter 1"
        Me.btnFilter1.UseVisualStyleBackColor = True
        '
        'btnJoin
        '
        Me.btnJoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJoin.Location = New System.Drawing.Point(825, 476)
        Me.btnJoin.Name = "btnJoin"
        Me.btnJoin.Size = New System.Drawing.Size(120, 43)
        Me.btnJoin.TabIndex = 29
        Me.btnJoin.Text = "Join"
        Me.btnJoin.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 652)
        Me.Controls.Add(Me.btnJoin)
        Me.Controls.Add(Me.btnFilter1)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.btnSplit)
        Me.Controls.Add(Me.btnSpritWord1)
        Me.Controls.Add(Me.bttnSpritWord)
        Me.Controls.Add(Me.btnFullName3)
        Me.Controls.Add(Me.btnFullName2)
        Me.Controls.Add(Me.btnFullName)
        Me.Controls.Add(Me.btnInStr)
        Me.Controls.Add(Me.btnMid)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.btnLen)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.rdText)
        Me.Controls.Add(Me.rdBinary)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtStart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRpl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStrReverse)
        Me.Controls.Add(Me.lstShow)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents lstShow As System.Windows.Forms.ListBox
    Friend WithEvents btnStrReverse As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRpl As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtStart As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCount As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rdBinary As System.Windows.Forms.RadioButton
    Friend WithEvents rdText As System.Windows.Forms.RadioButton
    Friend WithEvents btnReplace As System.Windows.Forms.Button
    Friend WithEvents btnLen As System.Windows.Forms.Button
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnMid As System.Windows.Forms.Button
    Friend WithEvents btnInStr As System.Windows.Forms.Button
    Friend WithEvents btnFullName As System.Windows.Forms.Button
    Friend WithEvents btnFullName2 As System.Windows.Forms.Button
    Friend WithEvents btnFullName3 As System.Windows.Forms.Button
    Friend WithEvents bttnSpritWord As System.Windows.Forms.Button
    Friend WithEvents btnSpritWord1 As System.Windows.Forms.Button
    Friend WithEvents btnSplit As System.Windows.Forms.Button
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents btnFilter1 As System.Windows.Forms.Button
    Friend WithEvents btnJoin As System.Windows.Forms.Button

End Class
