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
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.lstShow = New System.Windows.Forms.ListBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnBubble = New System.Windows.Forms.Button()
        Me.btnQuick = New System.Windows.Forms.Button()
        Me.btnMerge = New System.Windows.Forms.Button()
        Me.btnMysort = New System.Windows.Forms.Button()
        Me.btnMy = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnInput
        '
        Me.btnInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInput.Location = New System.Drawing.Point(738, 24)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(142, 52)
        Me.btnInput.TabIndex = 1
        Me.btnInput.Text = "Input Data"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.Location = New System.Drawing.Point(738, 108)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(142, 52)
        Me.btnInsert.TabIndex = 2
        Me.btnInsert.Text = "Insert Sort"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'lstShow
        '
        Me.lstShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstShow.FormattingEnabled = True
        Me.lstShow.ItemHeight = 20
        Me.lstShow.Location = New System.Drawing.Point(26, 24)
        Me.lstShow.Name = "lstShow"
        Me.lstShow.Size = New System.Drawing.Size(696, 504)
        Me.lstShow.TabIndex = 3
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(738, 188)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(142, 52)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.Text = "Selection Sort"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnBubble
        '
        Me.btnBubble.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBubble.Location = New System.Drawing.Point(738, 268)
        Me.btnBubble.Name = "btnBubble"
        Me.btnBubble.Size = New System.Drawing.Size(142, 52)
        Me.btnBubble.TabIndex = 5
        Me.btnBubble.Text = "Bubble Sort"
        Me.btnBubble.UseVisualStyleBackColor = True
        '
        'btnQuick
        '
        Me.btnQuick.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuick.Location = New System.Drawing.Point(738, 344)
        Me.btnQuick.Name = "btnQuick"
        Me.btnQuick.Size = New System.Drawing.Size(142, 52)
        Me.btnQuick.TabIndex = 6
        Me.btnQuick.Text = "Quick Sort"
        Me.btnQuick.UseVisualStyleBackColor = True
        '
        'btnMerge
        '
        Me.btnMerge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMerge.Location = New System.Drawing.Point(738, 418)
        Me.btnMerge.Name = "btnMerge"
        Me.btnMerge.Size = New System.Drawing.Size(142, 52)
        Me.btnMerge.TabIndex = 7
        Me.btnMerge.Text = "Merge Sort"
        Me.btnMerge.UseVisualStyleBackColor = True
        '
        'btnMysort
        '
        Me.btnMysort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMysort.Location = New System.Drawing.Point(738, 575)
        Me.btnMysort.Name = "btnMysort"
        Me.btnMysort.Size = New System.Drawing.Size(142, 52)
        Me.btnMysort.TabIndex = 8
        Me.btnMysort.Text = "Mysort"
        Me.btnMysort.UseVisualStyleBackColor = True
        '
        'btnMy
        '
        Me.btnMy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMy.Location = New System.Drawing.Point(738, 497)
        Me.btnMy.Name = "btnMy"
        Me.btnMy.Size = New System.Drawing.Size(142, 52)
        Me.btnMy.TabIndex = 9
        Me.btnMy.Text = "My Data"
        Me.btnMy.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 653)
        Me.Controls.Add(Me.btnMy)
        Me.Controls.Add(Me.btnMysort)
        Me.Controls.Add(Me.btnMerge)
        Me.Controls.Add(Me.btnQuick)
        Me.Controls.Add(Me.btnBubble)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.lstShow)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnInput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents lstShow As System.Windows.Forms.ListBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnBubble As System.Windows.Forms.Button
    Friend WithEvents btnQuick As System.Windows.Forms.Button
    Friend WithEvents btnMerge As System.Windows.Forms.Button
    Friend WithEvents btnMysort As System.Windows.Forms.Button
    Friend WithEvents btnMy As System.Windows.Forms.Button

End Class
