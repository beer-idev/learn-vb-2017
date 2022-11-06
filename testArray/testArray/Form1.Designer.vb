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
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnInputDy = New System.Windows.Forms.Button()
        Me.btnShowDy = New System.Windows.Forms.Button()
        Me.btn2Miti = New System.Windows.Forms.Button()
        Me.btnShow2Miti = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstShow
        '
        Me.lstShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstShow.FormattingEnabled = True
        Me.lstShow.ItemHeight = 16
        Me.lstShow.Location = New System.Drawing.Point(63, 35)
        Me.lstShow.Name = "lstShow"
        Me.lstShow.Size = New System.Drawing.Size(525, 340)
        Me.lstShow.TabIndex = 0
        '
        'btnInput
        '
        Me.btnInput.BackColor = System.Drawing.Color.Cyan
        Me.btnInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInput.Location = New System.Drawing.Point(63, 401)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(142, 54)
        Me.btnInput.TabIndex = 1
        Me.btnInput.Text = "รับข้อมูล"
        Me.btnInput.UseVisualStyleBackColor = False
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.Cyan
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(221, 401)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(142, 54)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "แสดงข้อมูล"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'btnInputDy
        '
        Me.btnInputDy.BackColor = System.Drawing.Color.Cyan
        Me.btnInputDy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInputDy.Location = New System.Drawing.Point(384, 401)
        Me.btnInputDy.Name = "btnInputDy"
        Me.btnInputDy.Size = New System.Drawing.Size(142, 54)
        Me.btnInputDy.TabIndex = 3
        Me.btnInputDy.Text = "รับข้อมูล Dynamic Array"
        Me.btnInputDy.UseVisualStyleBackColor = False
        '
        'btnShowDy
        '
        Me.btnShowDy.BackColor = System.Drawing.Color.Cyan
        Me.btnShowDy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowDy.Location = New System.Drawing.Point(550, 401)
        Me.btnShowDy.Name = "btnShowDy"
        Me.btnShowDy.Size = New System.Drawing.Size(142, 54)
        Me.btnShowDy.TabIndex = 4
        Me.btnShowDy.Text = "แสดงผล Dynamic Array"
        Me.btnShowDy.UseVisualStyleBackColor = False
        '
        'btn2Miti
        '
        Me.btn2Miti.BackColor = System.Drawing.Color.Cyan
        Me.btn2Miti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2Miti.Location = New System.Drawing.Point(63, 477)
        Me.btn2Miti.Name = "btn2Miti"
        Me.btn2Miti.Size = New System.Drawing.Size(142, 54)
        Me.btn2Miti.TabIndex = 5
        Me.btn2Miti.Text = "รับข้อมูล 2 มิติ"
        Me.btn2Miti.UseVisualStyleBackColor = False
        '
        'btnShow2Miti
        '
        Me.btnShow2Miti.BackColor = System.Drawing.Color.Cyan
        Me.btnShow2Miti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow2Miti.Location = New System.Drawing.Point(221, 477)
        Me.btnShow2Miti.Name = "btnShow2Miti"
        Me.btnShow2Miti.Size = New System.Drawing.Size(142, 54)
        Me.btnShow2Miti.TabIndex = 6
        Me.btnShow2Miti.Text = "แสดงผล 2 มิติ"
        Me.btnShow2Miti.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 680)
        Me.Controls.Add(Me.btnShow2Miti)
        Me.Controls.Add(Me.btn2Miti)
        Me.Controls.Add(Me.btnShowDy)
        Me.Controls.Add(Me.btnInputDy)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.lstShow)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstShow As System.Windows.Forms.ListBox
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnInputDy As System.Windows.Forms.Button
    Friend WithEvents btnShowDy As System.Windows.Forms.Button
    Friend WithEvents btn2Miti As System.Windows.Forms.Button
    Friend WithEvents btnShow2Miti As System.Windows.Forms.Button

End Class
