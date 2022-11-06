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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtShowText = New System.Windows.Forms.TextBox()
        Me.btnFontColor = New System.Windows.Forms.Button()
        Me.btnShowText = New System.Windows.Forms.Button()
        Me.btnFormColor = New System.Windows.Forms.Button()
        Me.btnFormTitle = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(94, 49)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(287, 66)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "My First Basic Application"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtShowText
        '
        Me.txtShowText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtShowText.Location = New System.Drawing.Point(94, 143)
        Me.txtShowText.Name = "txtShowText"
        Me.txtShowText.Size = New System.Drawing.Size(287, 22)
        Me.txtShowText.TabIndex = 1
        Me.txtShowText.Text = "Text To Show"
        '
        'btnFontColor
        '
        Me.btnFontColor.Location = New System.Drawing.Point(94, 194)
        Me.btnFontColor.Name = "btnFontColor"
        Me.btnFontColor.Size = New System.Drawing.Size(121, 38)
        Me.btnFontColor.TabIndex = 2
        Me.btnFontColor.Text = "Change Font Color"
        Me.btnFontColor.UseVisualStyleBackColor = True
        '
        'btnShowText
        '
        Me.btnShowText.Location = New System.Drawing.Point(260, 194)
        Me.btnShowText.Name = "btnShowText"
        Me.btnShowText.Size = New System.Drawing.Size(121, 38)
        Me.btnShowText.TabIndex = 3
        Me.btnShowText.Text = "Show Text"
        Me.btnShowText.UseVisualStyleBackColor = True
        '
        'btnFormColor
        '
        Me.btnFormColor.Location = New System.Drawing.Point(94, 255)
        Me.btnFormColor.Name = "btnFormColor"
        Me.btnFormColor.Size = New System.Drawing.Size(121, 38)
        Me.btnFormColor.TabIndex = 4
        Me.btnFormColor.Text = "Change Form Color"
        Me.btnFormColor.UseVisualStyleBackColor = True
        '
        'btnFormTitle
        '
        Me.btnFormTitle.Location = New System.Drawing.Point(260, 255)
        Me.btnFormTitle.Name = "btnFormTitle"
        Me.btnFormTitle.Size = New System.Drawing.Size(121, 38)
        Me.btnFormTitle.TabIndex = 5
        Me.btnFormTitle.Text = "Change Form Title"
        Me.btnFormTitle.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(281, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Mouse Move Event" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 388)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFormTitle)
        Me.Controls.Add(Me.btnFormColor)
        Me.Controls.Add(Me.btnShowText)
        Me.Controls.Add(Me.btnFontColor)
        Me.Controls.Add(Me.txtShowText)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtShowText As System.Windows.Forms.TextBox
    Friend WithEvents btnFontColor As System.Windows.Forms.Button
    Friend WithEvents btnShowText As System.Windows.Forms.Button
    Friend WithEvents btnFormColor As System.Windows.Forms.Button
    Friend WithEvents btnFormTitle As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
