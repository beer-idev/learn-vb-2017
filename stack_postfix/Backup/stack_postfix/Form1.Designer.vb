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
        Me.btnInfixPostfix = New System.Windows.Forms.Button
        Me.lblPostfix = New System.Windows.Forms.Label
        Me.txtInfix = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnClear = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnInfixPostfix
        '
        Me.btnInfixPostfix.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnInfixPostfix.Location = New System.Drawing.Point(423, 4)
        Me.btnInfixPostfix.Name = "btnInfixPostfix"
        Me.btnInfixPostfix.Size = New System.Drawing.Size(104, 36)
        Me.btnInfixPostfix.TabIndex = 0
        Me.btnInfixPostfix.Text = "PostFix"
        Me.btnInfixPostfix.UseVisualStyleBackColor = True
        '
        'lblPostfix
        '
        Me.lblPostfix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPostfix.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPostfix.Location = New System.Drawing.Point(133, 56)
        Me.lblPostfix.Name = "lblPostfix"
        Me.lblPostfix.Size = New System.Drawing.Size(260, 30)
        Me.lblPostfix.TabIndex = 1
        Me.lblPostfix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtInfix
        '
        Me.txtInfix.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtInfix.Location = New System.Drawing.Point(136, 14)
        Me.txtInfix.Name = "txtInfix"
        Me.txtInfix.Size = New System.Drawing.Size(257, 29)
        Me.txtInfix.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "นิพจน์ Infix"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "นิพจน์ PostFix"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClear.Location = New System.Drawing.Point(424, 56)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(103, 30)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 344)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInfix)
        Me.Controls.Add(Me.lblPostfix)
        Me.Controls.Add(Me.btnInfixPostfix)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnInfixPostfix As System.Windows.Forms.Button
    Friend WithEvents lblPostfix As System.Windows.Forms.Label
    Friend WithEvents txtInfix As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
