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
        Me.btnEnQueue = New System.Windows.Forms.Button()
        Me.btnDeQueue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstShow
        '
        Me.lstShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstShow.FormattingEnabled = True
        Me.lstShow.ItemHeight = 16
        Me.lstShow.Location = New System.Drawing.Point(61, 44)
        Me.lstShow.Name = "lstShow"
        Me.lstShow.Size = New System.Drawing.Size(342, 452)
        Me.lstShow.TabIndex = 0
        '
        'btnEnQueue
        '
        Me.btnEnQueue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnQueue.Location = New System.Drawing.Point(564, 44)
        Me.btnEnQueue.Name = "btnEnQueue"
        Me.btnEnQueue.Size = New System.Drawing.Size(139, 58)
        Me.btnEnQueue.TabIndex = 1
        Me.btnEnQueue.Text = "EnQueue"
        Me.btnEnQueue.UseVisualStyleBackColor = True
        '
        'btnDeQueue
        '
        Me.btnDeQueue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeQueue.Location = New System.Drawing.Point(564, 146)
        Me.btnDeQueue.Name = "btnDeQueue"
        Me.btnDeQueue.Size = New System.Drawing.Size(139, 58)
        Me.btnDeQueue.TabIndex = 2
        Me.btnDeQueue.Text = "DeQueue"
        Me.btnDeQueue.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 610)
        Me.Controls.Add(Me.btnDeQueue)
        Me.Controls.Add(Me.btnEnQueue)
        Me.Controls.Add(Me.lstShow)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstShow As System.Windows.Forms.ListBox
    Friend WithEvents btnEnQueue As System.Windows.Forms.Button
    Friend WithEvents btnDeQueue As System.Windows.Forms.Button

End Class
