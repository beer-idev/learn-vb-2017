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
        Me.lstShow = New System.Windows.Forms.ListBox()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnArray = New System.Windows.Forms.Button()
        Me.btnDynamic = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstShow
        '
        Me.lstShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstShow.FormattingEnabled = True
        Me.lstShow.ItemHeight = 16
        Me.lstShow.Location = New System.Drawing.Point(42, 49)
        Me.lstShow.Name = "lstShow"
        Me.lstShow.Size = New System.Drawing.Size(440, 308)
        Me.lstShow.TabIndex = 0
        '
        'btnInput
        '
        Me.btnInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInput.Location = New System.Drawing.Point(542, 49)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(208, 56)
        Me.btnInput.TabIndex = 1
        Me.btnInput.Text = "รับข้อมูลตัวแปรแบบธรรมดา"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnArray
        '
        Me.btnArray.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArray.Location = New System.Drawing.Point(542, 144)
        Me.btnArray.Name = "btnArray"
        Me.btnArray.Size = New System.Drawing.Size(208, 56)
        Me.btnArray.TabIndex = 2
        Me.btnArray.Text = "รับข้อมูลแบบ Array"
        Me.btnArray.UseVisualStyleBackColor = True
        '
        'btnDynamic
        '
        Me.btnDynamic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDynamic.Location = New System.Drawing.Point(542, 240)
        Me.btnDynamic.Name = "btnDynamic"
        Me.btnDynamic.Size = New System.Drawing.Size(208, 56)
        Me.btnDynamic.TabIndex = 3
        Me.btnDynamic.Text = "รับข้อมูลแบบ Dynamic Array"
        Me.btnDynamic.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 633)
        Me.Controls.Add(Me.btnDynamic)
        Me.Controls.Add(Me.btnArray)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.lstShow)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstShow As System.Windows.Forms.ListBox
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents btnArray As System.Windows.Forms.Button
    Friend WithEvents btnDynamic As System.Windows.Forms.Button

End Class
