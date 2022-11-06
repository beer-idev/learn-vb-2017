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
        Me.Clb1 = New System.Windows.Forms.CheckedListBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnShow1 = New System.Windows.Forms.Button()
        Me.clb2 = New System.Windows.Forms.CheckedListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Clb1
        '
        Me.Clb1.FormattingEnabled = True
        Me.Clb1.Items.AddRange(New Object() {"Beer", "Rov"})
        Me.Clb1.Location = New System.Drawing.Point(12, 12)
        Me.Clb1.Name = "Clb1"
        Me.Clb1.Size = New System.Drawing.Size(178, 229)
        Me.Clb1.TabIndex = 0
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(102, 305)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(115, 37)
        Me.btnShow.TabIndex = 1
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnShow1
        '
        Me.btnShow1.Location = New System.Drawing.Point(223, 305)
        Me.btnShow1.Name = "btnShow1"
        Me.btnShow1.Size = New System.Drawing.Size(115, 37)
        Me.btnShow1.TabIndex = 2
        Me.btnShow1.Text = "Show1"
        Me.btnShow1.UseVisualStyleBackColor = True
        '
        'clb2
        '
        Me.clb2.FormattingEnabled = True
        Me.clb2.Location = New System.Drawing.Point(330, 12)
        Me.clb2.Name = "clb2"
        Me.clb2.Size = New System.Drawing.Size(177, 229)
        Me.clb2.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(208, 21)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 36)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(208, 77)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(100, 36)
        Me.btnMove.TabIndex = 5
        Me.btnMove.Text = ">>"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(208, 130)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 36)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "<<"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(208, 184)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 36)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 536)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.clb2)
        Me.Controls.Add(Me.btnShow1)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.Clb1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Clb1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnShow1 As System.Windows.Forms.Button
    Friend WithEvents clb2 As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnMove As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
