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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInput1 = New System.Windows.Forms.TextBox()
        Me.txtInput2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnMultiple = New System.Windows.Forms.Button()
        Me.btnDevide = New System.Windows.Forms.Button()
        Me.btnPercent = New System.Windows.Forms.Button()
        Me.btnVat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รับข้อมูลที่ 1"
        '
        'txtInput1
        '
        Me.txtInput1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtInput1.Location = New System.Drawing.Point(140, 45)
        Me.txtInput1.Name = "txtInput1"
        Me.txtInput1.Size = New System.Drawing.Size(159, 22)
        Me.txtInput1.TabIndex = 1
        '
        'txtInput2
        '
        Me.txtInput2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtInput2.Location = New System.Drawing.Point(140, 99)
        Me.txtInput2.Name = "txtInput2"
        Me.txtInput2.Size = New System.Drawing.Size(159, 22)
        Me.txtInput2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "รับข้อมูลที่ 2"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblResult.Location = New System.Drawing.Point(328, 44)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(241, 131)
        Me.lblResult.TabIndex = 4
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnPlus
        '
        Me.btnPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPlus.Location = New System.Drawing.Point(13, 186)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(89, 35)
        Me.btnPlus.TabIndex = 5
        Me.btnPlus.Text = "Plus (+)"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMinus.Location = New System.Drawing.Point(108, 186)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(89, 35)
        Me.btnMinus.TabIndex = 6
        Me.btnMinus.Text = "Minus (-)"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnMultiple
        '
        Me.btnMultiple.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMultiple.Location = New System.Drawing.Point(203, 186)
        Me.btnMultiple.Name = "btnMultiple"
        Me.btnMultiple.Size = New System.Drawing.Size(96, 35)
        Me.btnMultiple.TabIndex = 7
        Me.btnMultiple.Text = "Multiple (*)"
        Me.btnMultiple.UseVisualStyleBackColor = True
        '
        'btnDevide
        '
        Me.btnDevide.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDevide.Location = New System.Drawing.Point(305, 186)
        Me.btnDevide.Name = "btnDevide"
        Me.btnDevide.Size = New System.Drawing.Size(89, 35)
        Me.btnDevide.TabIndex = 8
        Me.btnDevide.Text = "Devide (/)"
        Me.btnDevide.UseVisualStyleBackColor = True
        '
        'btnPercent
        '
        Me.btnPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPercent.Location = New System.Drawing.Point(400, 186)
        Me.btnPercent.Name = "btnPercent"
        Me.btnPercent.Size = New System.Drawing.Size(103, 35)
        Me.btnPercent.TabIndex = 9
        Me.btnPercent.Text = "Percent (%)"
        Me.btnPercent.UseVisualStyleBackColor = True
        '
        'btnVat
        '
        Me.btnVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnVat.Location = New System.Drawing.Point(509, 186)
        Me.btnVat.Name = "btnVat"
        Me.btnVat.Size = New System.Drawing.Size(89, 35)
        Me.btnVat.TabIndex = 10
        Me.btnVat.Text = "Vat ใน"
        Me.btnVat.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 451)
        Me.Controls.Add(Me.btnVat)
        Me.Controls.Add(Me.btnPercent)
        Me.Controls.Add(Me.btnDevide)
        Me.Controls.Add(Me.btnMultiple)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtInput2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtInput1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInput1 As System.Windows.Forms.TextBox
    Friend WithEvents txtInput2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents btnMinus As System.Windows.Forms.Button
    Friend WithEvents btnMultiple As System.Windows.Forms.Button
    Friend WithEvents btnDevide As System.Windows.Forms.Button
    Friend WithEvents btnPercent As System.Windows.Forms.Button
    Friend WithEvents btnVat As System.Windows.Forms.Button

End Class
