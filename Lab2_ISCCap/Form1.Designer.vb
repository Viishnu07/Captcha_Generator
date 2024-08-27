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
        Me.txtInp = New System.Windows.Forms.TextBox()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnSound = New System.Windows.Forms.Button()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.CaptchaBox1 = New Lab2_ISCCap.CaptchaBox()
        CType(Me.CaptchaBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtInp
        '
        Me.txtInp.Location = New System.Drawing.Point(186, 226)
        Me.txtInp.Name = "txtInp"
        Me.txtInp.Size = New System.Drawing.Size(282, 22)
        Me.txtInp.TabIndex = 0
        '
        'lblHint
        '
        Me.lblHint.AutoSize = True
        Me.lblHint.Location = New System.Drawing.Point(183, 256)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(134, 16)
        Me.lblHint.TabIndex = 1
        Me.lblHint.Text = "Hint: Case Insensitive"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(534, 124)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(93, 47)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnSound
        '
        Me.btnSound.Location = New System.Drawing.Point(534, 177)
        Me.btnSound.Name = "btnSound"
        Me.btnSound.Size = New System.Drawing.Size(93, 43)
        Me.btnSound.TabIndex = 3
        Me.btnSound.Text = "Sound"
        Me.btnSound.UseVisualStyleBackColor = True
        '
        'btnVerify
        '
        Me.btnVerify.Location = New System.Drawing.Point(534, 226)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(93, 46)
        Me.btnVerify.TabIndex = 4
        Me.btnVerify.Text = "Verify"
        Me.btnVerify.UseVisualStyleBackColor = True
        '
        'CaptchaBox1
        '
        Me.CaptchaBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CaptchaBox1.CaptchaTextLength = 8
        Me.CaptchaBox1.Location = New System.Drawing.Point(186, 114)
        Me.CaptchaBox1.Name = "CaptchaBox1"
        Me.CaptchaBox1.NumberOfLines = 50
        Me.CaptchaBox1.RandomCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmopqrstuvwxyz!#$%^&*()1234567890"
        Me.CaptchaBox1.Size = New System.Drawing.Size(241, 69)
        Me.CaptchaBox1.TabIndex = 5
        Me.CaptchaBox1.TabStop = False
        Me.CaptchaBox1.TextColor = System.Drawing.Color.Black
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CaptchaBox1)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.btnSound)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.lblHint)
        Me.Controls.Add(Me.txtInp)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.CaptchaBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInp As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnSound As Button
    Friend WithEvents btnVerify As Button
    Friend WithEvents lblHint As Label
    Friend WithEvents CaptchaBox1 As CaptchaBox
End Class
