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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnMsgBox = New System.Windows.Forms.Button()
        Me.btnMessage = New System.Windows.Forms.Button()
        Me.btnInputBox = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMsgBox
        '
        Me.btnMsgBox.BackColor = System.Drawing.Color.Red
        Me.btnMsgBox.Location = New System.Drawing.Point(386, 339)
        Me.btnMsgBox.Name = "btnMsgBox"
        Me.btnMsgBox.Size = New System.Drawing.Size(112, 45)
        Me.btnMsgBox.TabIndex = 0
        Me.btnMsgBox.Text = "MsgBox"
        Me.btnMsgBox.UseVisualStyleBackColor = False
        '
        'btnMessage
        '
        Me.btnMessage.BackColor = System.Drawing.Color.Lime
        Me.btnMessage.Location = New System.Drawing.Point(299, 401)
        Me.btnMessage.Name = "btnMessage"
        Me.btnMessage.Size = New System.Drawing.Size(212, 45)
        Me.btnMessage.TabIndex = 1
        Me.btnMessage.Text = "MessageBox"
        Me.btnMessage.UseVisualStyleBackColor = False
        '
        'btnInputBox
        '
        Me.btnInputBox.BackColor = System.Drawing.Color.Fuchsia
        Me.btnInputBox.Location = New System.Drawing.Point(399, 276)
        Me.btnInputBox.Name = "btnInputBox"
        Me.btnInputBox.Size = New System.Drawing.Size(112, 45)
        Me.btnInputBox.TabIndex = 2
        Me.btnInputBox.Text = "InputBox"
        Me.btnInputBox.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(523, 458)
        Me.Controls.Add(Me.btnInputBox)
        Me.Controls.Add(Me.btnMessage)
        Me.Controls.Add(Me.btnMsgBox)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMsgBox As System.Windows.Forms.Button
    Friend WithEvents btnMessage As System.Windows.Forms.Button
    Friend WithEvents btnInputBox As System.Windows.Forms.Button

End Class
