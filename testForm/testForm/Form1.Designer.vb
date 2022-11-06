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
        Me.btnNewForm = New System.Windows.Forms.Button()
        Me.btnOpenForm2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNewForm
        '
        Me.btnNewForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnNewForm.ForeColor = System.Drawing.Color.Black
        Me.btnNewForm.Location = New System.Drawing.Point(160, 303)
        Me.btnNewForm.Name = "btnNewForm"
        Me.btnNewForm.Size = New System.Drawing.Size(169, 66)
        Me.btnNewForm.TabIndex = 0
        Me.btnNewForm.Text = "New Form"
        Me.btnNewForm.UseVisualStyleBackColor = True
        '
        'btnOpenForm2
        '
        Me.btnOpenForm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnOpenForm2.ForeColor = System.Drawing.Color.Black
        Me.btnOpenForm2.Location = New System.Drawing.Point(160, 399)
        Me.btnOpenForm2.Name = "btnOpenForm2"
        Me.btnOpenForm2.Size = New System.Drawing.Size(169, 66)
        Me.btnOpenForm2.TabIndex = 1
        Me.btnOpenForm2.Text = "Open Form2"
        Me.btnOpenForm2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.BackgroundImage = Global.testForm.My.Resources.Resources.received_123613194783992
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(498, 477)
        Me.Controls.Add(Me.btnOpenForm2)
        Me.Controls.Add(Me.btnNewForm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Beer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNewForm As System.Windows.Forms.Button
    Friend WithEvents btnOpenForm2 As System.Windows.Forms.Button

End Class
