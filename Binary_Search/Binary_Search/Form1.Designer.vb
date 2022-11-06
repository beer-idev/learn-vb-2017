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
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnBinary = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstShow = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnInput
        '
        Me.btnInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInput.Location = New System.Drawing.Point(585, 59)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(139, 55)
        Me.btnInput.TabIndex = 0
        Me.btnInput.Text = "Input Data"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnBinary
        '
        Me.btnBinary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBinary.Location = New System.Drawing.Point(585, 163)
        Me.btnBinary.Name = "btnBinary"
        Me.btnBinary.Size = New System.Drawing.Size(139, 55)
        Me.btnBinary.TabIndex = 1
        Me.btnBinary.Text = "Binary Search"
        Me.btnBinary.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(585, 263)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(139, 55)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit Program"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstShow
        '
        Me.lstShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstShow.FormattingEnabled = True
        Me.lstShow.ItemHeight = 20
        Me.lstShow.Location = New System.Drawing.Point(34, 35)
        Me.lstShow.Name = "lstShow"
        Me.lstShow.Size = New System.Drawing.Size(493, 524)
        Me.lstShow.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 650)
        Me.Controls.Add(Me.lstShow)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBinary)
        Me.Controls.Add(Me.btnInput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents btnBinary As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lstShow As System.Windows.Forms.ListBox

End Class
