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
        Me.txtFacNum = New System.Windows.Forms.TextBox()
        Me.txtReasult = New System.Windows.Forms.TextBox()
        Me.btnFactorial = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnFactorial1 = New System.Windows.Forms.Button()
        Me.btnFac = New System.Windows.Forms.Button()
        Me.btnFac1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFacNum
        '
        Me.txtFacNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFacNum.Location = New System.Drawing.Point(239, 62)
        Me.txtFacNum.Multiline = True
        Me.txtFacNum.Name = "txtFacNum"
        Me.txtFacNum.Size = New System.Drawing.Size(207, 29)
        Me.txtFacNum.TabIndex = 0
        '
        'txtReasult
        '
        Me.txtReasult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReasult.Location = New System.Drawing.Point(239, 124)
        Me.txtReasult.Multiline = True
        Me.txtReasult.Name = "txtReasult"
        Me.txtReasult.Size = New System.Drawing.Size(207, 29)
        Me.txtReasult.TabIndex = 1
        '
        'btnFactorial
        '
        Me.btnFactorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactorial.Location = New System.Drawing.Point(178, 193)
        Me.btnFactorial.Name = "btnFactorial"
        Me.btnFactorial.Size = New System.Drawing.Size(100, 44)
        Me.btnFactorial.TabIndex = 2
        Me.btnFactorial.Text = "Factorial"
        Me.btnFactorial.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Factorial Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Result"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(395, 193)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 44)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnFactorial1
        '
        Me.btnFactorial1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactorial1.Location = New System.Drawing.Point(178, 269)
        Me.btnFactorial1.Name = "btnFactorial1"
        Me.btnFactorial1.Size = New System.Drawing.Size(100, 44)
        Me.btnFactorial1.TabIndex = 6
        Me.btnFactorial1.Text = "Factorial1"
        Me.btnFactorial1.UseVisualStyleBackColor = True
        '
        'btnFac
        '
        Me.btnFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFac.Location = New System.Drawing.Point(395, 269)
        Me.btnFac.Name = "btnFac"
        Me.btnFac.Size = New System.Drawing.Size(100, 44)
        Me.btnFac.TabIndex = 7
        Me.btnFac.Text = "Fac"
        Me.btnFac.UseVisualStyleBackColor = True
        '
        'btnFac1
        '
        Me.btnFac1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFac1.Location = New System.Drawing.Point(289, 231)
        Me.btnFac1.Name = "btnFac1"
        Me.btnFac1.Size = New System.Drawing.Size(100, 44)
        Me.btnFac1.TabIndex = 8
        Me.btnFac1.Text = "Fac1"
        Me.btnFac1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 640)
        Me.Controls.Add(Me.btnFac1)
        Me.Controls.Add(Me.btnFac)
        Me.Controls.Add(Me.btnFactorial1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFactorial)
        Me.Controls.Add(Me.txtReasult)
        Me.Controls.Add(Me.txtFacNum)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFacNum As System.Windows.Forms.TextBox
    Friend WithEvents txtReasult As System.Windows.Forms.TextBox
    Friend WithEvents btnFactorial As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnFactorial1 As System.Windows.Forms.Button
    Friend WithEvents btnFac As System.Windows.Forms.Button
    Friend WithEvents btnFac1 As System.Windows.Forms.Button

End Class
