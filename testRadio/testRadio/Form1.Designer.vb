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
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.rbSingle = New System.Windows.Forms.RadioButton()
        Me.rbMarry = New System.Windows.Forms.RadioButton()
        Me.rbYa = New System.Windows.Forms.RadioButton()
        Me.rbMai = New System.Windows.Forms.RadioButton()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.grbGander = New System.Windows.Forms.GroupBox()
        Me.grbStatus = New System.Windows.Forms.GroupBox()
        Me.grbSport = New System.Windows.Forms.GroupBox()
        Me.TxtOther = New System.Windows.Forms.TextBox()
        Me.ChkOther = New System.Windows.Forms.CheckBox()
        Me.ChkTennis = New System.Windows.Forms.CheckBox()
        Me.ChkValleyball = New System.Windows.Forms.CheckBox()
        Me.ChkPatong = New System.Windows.Forms.CheckBox()
        Me.ChkBadminton = New System.Windows.Forms.CheckBox()
        Me.ChkBasketball = New System.Windows.Forms.CheckBox()
        Me.chkFootball = New System.Windows.Forms.CheckBox()
        Me.btnShow2 = New System.Windows.Forms.Button()
        Me.grbGander.SuspendLayout()
        Me.grbStatus.SuspendLayout()
        Me.grbSport.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Checked = True
        Me.rbMale.Location = New System.Drawing.Point(17, 21)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(44, 17)
        Me.rbMale.TabIndex = 0
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "ชาย"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Location = New System.Drawing.Point(124, 21)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(46, 17)
        Me.rbFemale.TabIndex = 1
        Me.rbFemale.Text = "หญิง"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'rbSingle
        '
        Me.rbSingle.AutoSize = True
        Me.rbSingle.Checked = True
        Me.rbSingle.Location = New System.Drawing.Point(16, 21)
        Me.rbSingle.Name = "rbSingle"
        Me.rbSingle.Size = New System.Drawing.Size(45, 20)
        Me.rbSingle.TabIndex = 2
        Me.rbSingle.TabStop = True
        Me.rbSingle.Text = "โสด"
        Me.rbSingle.UseVisualStyleBackColor = True
        '
        'rbMarry
        '
        Me.rbMarry.AutoSize = True
        Me.rbMarry.Location = New System.Drawing.Point(124, 21)
        Me.rbMarry.Name = "rbMarry"
        Me.rbMarry.Size = New System.Drawing.Size(63, 20)
        Me.rbMarry.TabIndex = 3
        Me.rbMarry.Text = "แต่งงาน"
        Me.rbMarry.UseVisualStyleBackColor = True
        '
        'rbYa
        '
        Me.rbYa.AutoSize = True
        Me.rbYa.Location = New System.Drawing.Point(232, 21)
        Me.rbYa.Name = "rbYa"
        Me.rbYa.Size = New System.Drawing.Size(45, 20)
        Me.rbYa.TabIndex = 4
        Me.rbYa.Text = "หย่า"
        Me.rbYa.UseVisualStyleBackColor = True
        '
        'rbMai
        '
        Me.rbMai.AutoSize = True
        Me.rbMai.Location = New System.Drawing.Point(338, 21)
        Me.rbMai.Name = "rbMai"
        Me.rbMai.Size = New System.Drawing.Size(52, 20)
        Me.rbMai.TabIndex = 5
        Me.rbMai.Text = "หม้าย"
        Me.rbMai.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnShow.Location = New System.Drawing.Point(12, 322)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(159, 53)
        Me.btnShow.TabIndex = 6
        Me.btnShow.Text = "Show Data"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'grbGander
        '
        Me.grbGander.Controls.Add(Me.rbFemale)
        Me.grbGander.Controls.Add(Me.rbMale)
        Me.grbGander.Location = New System.Drawing.Point(24, 12)
        Me.grbGander.Name = "grbGander"
        Me.grbGander.Size = New System.Drawing.Size(233, 54)
        Me.grbGander.TabIndex = 7
        Me.grbGander.TabStop = False
        Me.grbGander.Text = "เพศ"
        '
        'grbStatus
        '
        Me.grbStatus.Controls.Add(Me.rbMai)
        Me.grbStatus.Controls.Add(Me.rbYa)
        Me.grbStatus.Controls.Add(Me.rbMarry)
        Me.grbStatus.Controls.Add(Me.rbSingle)
        Me.grbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.grbStatus.Location = New System.Drawing.Point(24, 82)
        Me.grbStatus.Name = "grbStatus"
        Me.grbStatus.Size = New System.Drawing.Size(400, 55)
        Me.grbStatus.TabIndex = 8
        Me.grbStatus.TabStop = False
        Me.grbStatus.Text = "สถานะ"
        '
        'grbSport
        '
        Me.grbSport.Controls.Add(Me.TxtOther)
        Me.grbSport.Controls.Add(Me.ChkOther)
        Me.grbSport.Controls.Add(Me.ChkTennis)
        Me.grbSport.Controls.Add(Me.ChkValleyball)
        Me.grbSport.Controls.Add(Me.ChkPatong)
        Me.grbSport.Controls.Add(Me.ChkBadminton)
        Me.grbSport.Controls.Add(Me.ChkBasketball)
        Me.grbSport.Controls.Add(Me.chkFootball)
        Me.grbSport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.grbSport.Location = New System.Drawing.Point(24, 160)
        Me.grbSport.Name = "grbSport"
        Me.grbSport.Size = New System.Drawing.Size(455, 146)
        Me.grbSport.TabIndex = 9
        Me.grbSport.TabStop = False
        Me.grbSport.Text = "กีฬาที่ชื่นชอบ"
        '
        'TxtOther
        '
        Me.TxtOther.Location = New System.Drawing.Point(324, 74)
        Me.TxtOther.Name = "TxtOther"
        Me.TxtOther.Size = New System.Drawing.Size(113, 22)
        Me.TxtOther.TabIndex = 7
        Me.TxtOther.Visible = False
        '
        'ChkOther
        '
        Me.ChkOther.AutoSize = True
        Me.ChkOther.Location = New System.Drawing.Point(271, 74)
        Me.ChkOther.Name = "ChkOther"
        Me.ChkOther.Size = New System.Drawing.Size(47, 20)
        Me.ChkOther.TabIndex = 6
        Me.ChkOther.Text = "อื่นๆ"
        Me.ChkOther.UseVisualStyleBackColor = True
        '
        'ChkTennis
        '
        Me.ChkTennis.AutoSize = True
        Me.ChkTennis.Location = New System.Drawing.Point(196, 74)
        Me.ChkTennis.Name = "ChkTennis"
        Me.ChkTennis.Size = New System.Drawing.Size(59, 20)
        Me.ChkTennis.TabIndex = 5
        Me.ChkTennis.Text = "เทนนิส"
        Me.ChkTennis.UseVisualStyleBackColor = True
        '
        'ChkValleyball
        '
        Me.ChkValleyball.AutoSize = True
        Me.ChkValleyball.Location = New System.Drawing.Point(97, 74)
        Me.ChkValleyball.Name = "ChkValleyball"
        Me.ChkValleyball.Size = New System.Drawing.Size(79, 20)
        Me.ChkValleyball.TabIndex = 4
        Me.ChkValleyball.Text = "วอลเลย์บอล"
        Me.ChkValleyball.UseVisualStyleBackColor = True
        '
        'ChkPatong
        '
        Me.ChkPatong.AutoSize = True
        Me.ChkPatong.Location = New System.Drawing.Point(16, 74)
        Me.ChkPatong.Name = "ChkPatong"
        Me.ChkPatong.Size = New System.Drawing.Size(56, 20)
        Me.ChkPatong.TabIndex = 3
        Me.ChkPatong.Text = "เปตอง"
        Me.ChkPatong.UseVisualStyleBackColor = True
        '
        'ChkBadminton
        '
        Me.ChkBadminton.AutoSize = True
        Me.ChkBadminton.Location = New System.Drawing.Point(196, 33)
        Me.ChkBadminton.Name = "ChkBadminton"
        Me.ChkBadminton.Size = New System.Drawing.Size(75, 20)
        Me.ChkBadminton.TabIndex = 2
        Me.ChkBadminton.Text = "แบตมินตัน"
        Me.ChkBadminton.UseVisualStyleBackColor = True
        '
        'ChkBasketball
        '
        Me.ChkBasketball.AutoSize = True
        Me.ChkBasketball.Location = New System.Drawing.Point(97, 33)
        Me.ChkBasketball.Name = "ChkBasketball"
        Me.ChkBasketball.Size = New System.Drawing.Size(81, 20)
        Me.ChkBasketball.TabIndex = 1
        Me.ChkBasketball.Text = "บาสเกตบอล"
        Me.ChkBasketball.UseVisualStyleBackColor = True
        '
        'chkFootball
        '
        Me.chkFootball.AutoSize = True
        Me.chkFootball.Location = New System.Drawing.Point(17, 33)
        Me.chkFootball.Name = "chkFootball"
        Me.chkFootball.Size = New System.Drawing.Size(61, 20)
        Me.chkFootball.TabIndex = 0
        Me.chkFootball.Text = "ฟุตบอล"
        Me.chkFootball.UseVisualStyleBackColor = True
        '
        'btnShow2
        '
        Me.btnShow2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnShow2.Location = New System.Drawing.Point(220, 322)
        Me.btnShow2.Name = "btnShow2"
        Me.btnShow2.Size = New System.Drawing.Size(159, 53)
        Me.btnShow2.TabIndex = 10
        Me.btnShow2.Text = "Show2"
        Me.btnShow2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 443)
        Me.Controls.Add(Me.btnShow2)
        Me.Controls.Add(Me.grbSport)
        Me.Controls.Add(Me.grbStatus)
        Me.Controls.Add(Me.grbGander)
        Me.Controls.Add(Me.btnShow)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grbGander.ResumeLayout(False)
        Me.grbGander.PerformLayout()
        Me.grbStatus.ResumeLayout(False)
        Me.grbStatus.PerformLayout()
        Me.grbSport.ResumeLayout(False)
        Me.grbSport.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbMale As System.Windows.Forms.RadioButton
    Friend WithEvents rbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbSingle As System.Windows.Forms.RadioButton
    Friend WithEvents rbMarry As System.Windows.Forms.RadioButton
    Friend WithEvents rbYa As System.Windows.Forms.RadioButton
    Friend WithEvents rbMai As System.Windows.Forms.RadioButton
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents grbGander As System.Windows.Forms.GroupBox
    Friend WithEvents grbStatus As System.Windows.Forms.GroupBox
    Friend WithEvents grbSport As System.Windows.Forms.GroupBox
    Friend WithEvents chkFootball As System.Windows.Forms.CheckBox
    Friend WithEvents ChkOther As System.Windows.Forms.CheckBox
    Friend WithEvents ChkTennis As System.Windows.Forms.CheckBox
    Friend WithEvents ChkValleyball As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPatong As System.Windows.Forms.CheckBox
    Friend WithEvents ChkBadminton As System.Windows.Forms.CheckBox
    Friend WithEvents ChkBasketball As System.Windows.Forms.CheckBox
    Friend WithEvents TxtOther As System.Windows.Forms.TextBox
    Friend WithEvents btnShow2 As System.Windows.Forms.Button

End Class
