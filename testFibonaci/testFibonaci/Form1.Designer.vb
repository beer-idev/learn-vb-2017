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
        Me.txtFibonaci = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnFibonaci = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnFibo = New System.Windows.Forms.Button()
        Me.btnG = New System.Windows.Forms.Button()
        Me.btnH = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFibonaci
        '
        Me.txtFibonaci.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFibonaci.Location = New System.Drawing.Point(213, 65)
        Me.txtFibonaci.Multiline = True
        Me.txtFibonaci.Name = "txtFibonaci"
        Me.txtFibonaci.Size = New System.Drawing.Size(273, 30)
        Me.txtFibonaci.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fibonaci Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Result"
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(213, 115)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(273, 30)
        Me.txtResult.TabIndex = 3
        '
        'btnFibonaci
        '
        Me.btnFibonaci.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFibonaci.Location = New System.Drawing.Point(195, 192)
        Me.btnFibonaci.Name = "btnFibonaci"
        Me.btnFibonaci.Size = New System.Drawing.Size(107, 40)
        Me.btnFibonaci.TabIndex = 4
        Me.btnFibonaci.Text = "Fibonaci"
        Me.btnFibonaci.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(320, 192)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(107, 40)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnFibo
        '
        Me.btnFibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFibo.Location = New System.Drawing.Point(195, 250)
        Me.btnFibo.Name = "btnFibo"
        Me.btnFibo.Size = New System.Drawing.Size(107, 40)
        Me.btnFibo.TabIndex = 6
        Me.btnFibo.Text = "Fibo"
        Me.btnFibo.UseVisualStyleBackColor = True
        '
        'btnG
        '
        Me.btnG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnG.Location = New System.Drawing.Point(320, 250)
        Me.btnG.Name = "btnG"
        Me.btnG.Size = New System.Drawing.Size(107, 40)
        Me.btnG.TabIndex = 7
        Me.btnG.Text = "G(n)"
        Me.btnG.UseVisualStyleBackColor = True
        '
        'btnH
        '
        Me.btnH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnH.Location = New System.Drawing.Point(195, 305)
        Me.btnH.Name = "btnH"
        Me.btnH.Size = New System.Drawing.Size(107, 40)
        Me.btnH.TabIndex = 8
        Me.btnH.Text = "H(n)"
        Me.btnH.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 430)
        Me.Controls.Add(Me.btnH)
        Me.Controls.Add(Me.btnG)
        Me.Controls.Add(Me.btnFibo)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnFibonaci)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFibonaci)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFibonaci As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents btnFibonaci As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnFibo As System.Windows.Forms.Button
    Friend WithEvents btnG As System.Windows.Forms.Button
    Friend WithEvents btnH As System.Windows.Forms.Button

End Class
