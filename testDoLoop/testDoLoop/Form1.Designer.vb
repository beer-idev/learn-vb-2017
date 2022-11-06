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
        Me.lstShow = New System.Windows.Forms.ListBox()
        Me.btnLoopWhile = New System.Windows.Forms.Button()
        Me.btnLoopUntil = New System.Windows.Forms.Button()
        Me.btnDoUntil = New System.Windows.Forms.Button()
        Me.btnDoWhile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstShow
        '
        Me.lstShow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lstShow.FormattingEnabled = True
        Me.lstShow.ItemHeight = 25
        Me.lstShow.Location = New System.Drawing.Point(34, 12)
        Me.lstShow.Name = "lstShow"
        Me.lstShow.Size = New System.Drawing.Size(188, 379)
        Me.lstShow.TabIndex = 0
        '
        'btnLoopWhile
        '
        Me.btnLoopWhile.BackColor = System.Drawing.Color.Fuchsia
        Me.btnLoopWhile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnLoopWhile.Location = New System.Drawing.Point(263, 316)
        Me.btnLoopWhile.Name = "btnLoopWhile"
        Me.btnLoopWhile.Size = New System.Drawing.Size(232, 62)
        Me.btnLoopWhile.TabIndex = 4
        Me.btnLoopWhile.Text = "Do Loop While"
        Me.btnLoopWhile.UseVisualStyleBackColor = False
        '
        'btnLoopUntil
        '
        Me.btnLoopUntil.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLoopUntil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnLoopUntil.Location = New System.Drawing.Point(263, 225)
        Me.btnLoopUntil.Name = "btnLoopUntil"
        Me.btnLoopUntil.Size = New System.Drawing.Size(232, 62)
        Me.btnLoopUntil.TabIndex = 3
        Me.btnLoopUntil.Text = "Do Loop Until"
        Me.btnLoopUntil.UseVisualStyleBackColor = False
        '
        'btnDoUntil
        '
        Me.btnDoUntil.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDoUntil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDoUntil.Location = New System.Drawing.Point(263, 139)
        Me.btnDoUntil.Name = "btnDoUntil"
        Me.btnDoUntil.Size = New System.Drawing.Size(232, 69)
        Me.btnDoUntil.TabIndex = 2
        Me.btnDoUntil.Text = "DoUntil Loop"
        Me.btnDoUntil.UseVisualStyleBackColor = False
        '
        'btnDoWhile
        '
        Me.btnDoWhile.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDoWhile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDoWhile.Location = New System.Drawing.Point(263, 50)
        Me.btnDoWhile.Name = "btnDoWhile"
        Me.btnDoWhile.Size = New System.Drawing.Size(232, 68)
        Me.btnDoWhile.TabIndex = 1
        Me.btnDoWhile.Text = "DoWhile Loop"
        Me.btnDoWhile.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.testDoLoop.My.Resources.Resources._57545
        Me.ClientSize = New System.Drawing.Size(749, 532)
        Me.Controls.Add(Me.btnLoopWhile)
        Me.Controls.Add(Me.btnLoopUntil)
        Me.Controls.Add(Me.btnDoUntil)
        Me.Controls.Add(Me.btnDoWhile)
        Me.Controls.Add(Me.lstShow)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstShow As System.Windows.Forms.ListBox
    Friend WithEvents btnDoWhile As System.Windows.Forms.Button
    Friend WithEvents btnDoUntil As System.Windows.Forms.Button
    Friend WithEvents btnLoopUntil As System.Windows.Forms.Button
    Friend WithEvents btnLoopWhile As System.Windows.Forms.Button

End Class
