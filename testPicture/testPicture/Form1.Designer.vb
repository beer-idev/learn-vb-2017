<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class btnImage
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
        Me.Pic01 = New System.Windows.Forms.PictureBox()
        Me.ofd01 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBlank = New System.Windows.Forms.Button()
        CType(Me.Pic01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pic01
        '
        Me.Pic01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pic01.Image = Global.testPicture.My.Resources.Resources._2f6173727773a12d9ab44bbd1966c92b
        Me.Pic01.Location = New System.Drawing.Point(210, 35)
        Me.Pic01.Name = "Pic01"
        Me.Pic01.Size = New System.Drawing.Size(316, 310)
        Me.Pic01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic01.TabIndex = 0
        Me.Pic01.TabStop = False
        '
        'ofd01
        '
        Me.ofd01.FileName = "OpenFileDialog1"
        Me.ofd01.Filter = "ไฟล์รูปภาพ|*.bmp;*.jpg"
        Me.ofd01.InitialDirectory = "D:\"
        Me.ofd01.Title = "เปิด"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(191, 351)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 61)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Image"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnBlank
        '
        Me.btnBlank.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnBlank.Location = New System.Drawing.Point(392, 351)
        Me.btnBlank.Name = "btnBlank"
        Me.btnBlank.Size = New System.Drawing.Size(157, 61)
        Me.btnBlank.TabIndex = 2
        Me.btnBlank.Text = "Blank"
        Me.btnBlank.UseVisualStyleBackColor = True
        '
        'btnImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 528)
        Me.Controls.Add(Me.btnBlank)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Pic01)
        Me.Name = "btnImage"
        Me.Text = "Form1"
        CType(Me.Pic01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pic01 As System.Windows.Forms.PictureBox
    Friend WithEvents ofd01 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnBlank As System.Windows.Forms.Button

End Class
