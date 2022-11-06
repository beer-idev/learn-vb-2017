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
        Me.txtRsize = New System.Windows.Forms.TextBox()
        Me.txtCsize = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnM1 = New System.Windows.Forms.Button()
        Me.btnM2 = New System.Windows.Forms.Button()
        Me.btnAddM = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtM1 = New System.Windows.Forms.TextBox()
        Me.txtM2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAddM = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtRsize
        '
        Me.txtRsize.Location = New System.Drawing.Point(331, 62)
        Me.txtRsize.Name = "txtRsize"
        Me.txtRsize.Size = New System.Drawing.Size(183, 20)
        Me.txtRsize.TabIndex = 0
        '
        'txtCsize
        '
        Me.txtCsize.Location = New System.Drawing.Point(331, 112)
        Me.txtCsize.Name = "txtCsize"
        Me.txtCsize.Size = New System.Drawing.Size(183, 20)
        Me.txtCsize.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(212, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ขนาดของแถว"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(212, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ขนาดของคอลัมน์"
        '
        'btnM1
        '
        Me.btnM1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnM1.Location = New System.Drawing.Point(250, 187)
        Me.btnM1.Name = "btnM1"
        Me.btnM1.Size = New System.Drawing.Size(124, 41)
        Me.btnM1.TabIndex = 4
        Me.btnM1.Text = "ข้อมูลเมตริกซ์ที่ 1"
        Me.btnM1.UseVisualStyleBackColor = True
        '
        'btnM2
        '
        Me.btnM2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnM2.Location = New System.Drawing.Point(431, 187)
        Me.btnM2.Name = "btnM2"
        Me.btnM2.Size = New System.Drawing.Size(124, 41)
        Me.btnM2.TabIndex = 5
        Me.btnM2.Text = "ข้อมูลเมตริกซ์ที่ 2"
        Me.btnM2.UseVisualStyleBackColor = True
        '
        'btnAddM
        '
        Me.btnAddM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddM.Location = New System.Drawing.Point(331, 260)
        Me.btnAddM.Name = "btnAddM"
        Me.btnAddM.Size = New System.Drawing.Size(124, 41)
        Me.btnAddM.TabIndex = 6
        Me.btnAddM.Text = "บวกเมตริกซ์"
        Me.btnAddM.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "เมตริกซ์ที่ 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(338, 358)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "เมตริกซ์ที่ 2"
        '
        'txtM1
        '
        Me.txtM1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtM1.Location = New System.Drawing.Point(20, 416)
        Me.txtM1.Multiline = True
        Me.txtM1.Name = "txtM1"
        Me.txtM1.Size = New System.Drawing.Size(221, 163)
        Me.txtM1.TabIndex = 9
        '
        'txtM2
        '
        Me.txtM2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtM2.Location = New System.Drawing.Point(272, 416)
        Me.txtM2.Multiline = True
        Me.txtM2.Name = "txtM2"
        Me.txtM2.Size = New System.Drawing.Size(221, 163)
        Me.txtM2.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(602, 358)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ผลบวกเมตริกซ์"
        '
        'txtAddM
        '
        Me.txtAddM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddM.Location = New System.Drawing.Point(533, 416)
        Me.txtAddM.Multiline = True
        Me.txtAddM.Name = "txtAddM"
        Me.txtAddM.Size = New System.Drawing.Size(221, 163)
        Me.txtAddM.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 632)
        Me.Controls.Add(Me.txtAddM)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtM2)
        Me.Controls.Add(Me.txtM1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAddM)
        Me.Controls.Add(Me.btnM2)
        Me.Controls.Add(Me.btnM1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCsize)
        Me.Controls.Add(Me.txtRsize)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRsize As System.Windows.Forms.TextBox
    Friend WithEvents txtCsize As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnM1 As System.Windows.Forms.Button
    Friend WithEvents btnM2 As System.Windows.Forms.Button
    Friend WithEvents btnAddM As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtM1 As System.Windows.Forms.TextBox
    Friend WithEvents txtM2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAddM As System.Windows.Forms.TextBox

End Class
