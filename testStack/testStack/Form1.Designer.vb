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
        Me.btnPush = New System.Windows.Forms.Button()
        Me.btnPop = New System.Windows.Forms.Button()
        Me.btnReverse = New System.Windows.Forms.Button()
        Me.btnPop1 = New System.Windows.Forms.Button()
        Me.btnPush1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstShow
        '
        Me.lstShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstShow.FormattingEnabled = True
        Me.lstShow.ItemHeight = 20
        Me.lstShow.Location = New System.Drawing.Point(12, 46)
        Me.lstShow.Name = "lstShow"
        Me.lstShow.Size = New System.Drawing.Size(346, 404)
        Me.lstShow.TabIndex = 0
        '
        'btnPush
        '
        Me.btnPush.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPush.Location = New System.Drawing.Point(398, 46)
        Me.btnPush.Name = "btnPush"
        Me.btnPush.Size = New System.Drawing.Size(153, 50)
        Me.btnPush.TabIndex = 1
        Me.btnPush.Text = "Push"
        Me.btnPush.UseVisualStyleBackColor = True
        '
        'btnPop
        '
        Me.btnPop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPop.Location = New System.Drawing.Point(398, 130)
        Me.btnPop.Name = "btnPop"
        Me.btnPop.Size = New System.Drawing.Size(153, 50)
        Me.btnPop.TabIndex = 2
        Me.btnPop.Text = "Pop"
        Me.btnPop.UseVisualStyleBackColor = True
        '
        'btnReverse
        '
        Me.btnReverse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReverse.Location = New System.Drawing.Point(398, 218)
        Me.btnReverse.Name = "btnReverse"
        Me.btnReverse.Size = New System.Drawing.Size(153, 50)
        Me.btnReverse.TabIndex = 3
        Me.btnReverse.Text = "Reverse"
        Me.btnReverse.UseVisualStyleBackColor = True
        '
        'btnPop1
        '
        Me.btnPop1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPop1.Location = New System.Drawing.Point(597, 130)
        Me.btnPop1.Name = "btnPop1"
        Me.btnPop1.Size = New System.Drawing.Size(153, 50)
        Me.btnPop1.TabIndex = 5
        Me.btnPop1.Text = "Pop1"
        Me.btnPop1.UseVisualStyleBackColor = True
        '
        'btnPush1
        '
        Me.btnPush1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPush1.Location = New System.Drawing.Point(597, 46)
        Me.btnPush1.Name = "btnPush1"
        Me.btnPush1.Size = New System.Drawing.Size(153, 50)
        Me.btnPush1.TabIndex = 4
        Me.btnPush1.Text = "Push1"
        Me.btnPush1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 595)
        Me.Controls.Add(Me.btnPop1)
        Me.Controls.Add(Me.btnPush1)
        Me.Controls.Add(Me.btnReverse)
        Me.Controls.Add(Me.btnPop)
        Me.Controls.Add(Me.btnPush)
        Me.Controls.Add(Me.lstShow)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstShow As System.Windows.Forms.ListBox
    Friend WithEvents btnPush As System.Windows.Forms.Button
    Friend WithEvents btnPop As System.Windows.Forms.Button
    Friend WithEvents btnReverse As System.Windows.Forms.Button
    Friend WithEvents btnPop1 As System.Windows.Forms.Button
    Friend WithEvents btnPush1 As System.Windows.Forms.Button

End Class
