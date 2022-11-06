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
        Me.rdFirst = New System.Windows.Forms.RadioButton()
        Me.rdLast = New System.Windows.Forms.RadioButton()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstShow
        '
        Me.lstShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstShow.FormattingEnabled = True
        Me.lstShow.ItemHeight = 16
        Me.lstShow.Location = New System.Drawing.Point(41, 53)
        Me.lstShow.Name = "lstShow"
        Me.lstShow.Size = New System.Drawing.Size(335, 420)
        Me.lstShow.TabIndex = 0
        '
        'rdFirst
        '
        Me.rdFirst.AutoSize = True
        Me.rdFirst.Checked = True
        Me.rdFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdFirst.Location = New System.Drawing.Point(488, 53)
        Me.rdFirst.Name = "rdFirst"
        Me.rdFirst.Size = New System.Drawing.Size(63, 24)
        Me.rdFirst.TabIndex = 1
        Me.rdFirst.TabStop = True
        Me.rdFirst.Text = "First"
        Me.rdFirst.UseVisualStyleBackColor = True
        '
        'rdLast
        '
        Me.rdLast.AutoSize = True
        Me.rdLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdLast.Location = New System.Drawing.Point(488, 102)
        Me.rdLast.Name = "rdLast"
        Me.rdLast.Size = New System.Drawing.Size(62, 24)
        Me.rdLast.TabIndex = 2
        Me.rdLast.Text = "Last"
        Me.rdLast.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.Location = New System.Drawing.Point(463, 177)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(136, 55)
        Me.btnInsert.TabIndex = 3
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(463, 265)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(136, 55)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.testDeque.My.Resources.Resources.One_Piece_Premier_Show_2015_Luffy_Ace_Sabo_590x330
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(799, 620)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.rdLast)
        Me.Controls.Add(Me.rdFirst)
        Me.Controls.Add(Me.lstShow)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstShow As System.Windows.Forms.ListBox
    Friend WithEvents rdFirst As System.Windows.Forms.RadioButton
    Friend WithEvents rdLast As System.Windows.Forms.RadioButton
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button

End Class
