<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.password_txt = New System.Windows.Forms.TextBox()
        Me.email_txt = New System.Windows.Forms.TextBox()
        Me.Sign_but = New System.Windows.Forms.Button()
        Me.Login_but = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(985, 533)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 148
        Me.PictureBox1.TabStop = False
        '
        'password_txt
        '
        Me.password_txt.Location = New System.Drawing.Point(152, 384)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.Size = New System.Drawing.Size(176, 27)
        Me.password_txt.TabIndex = 154
        '
        'email_txt
        '
        Me.email_txt.Location = New System.Drawing.Point(145, 137)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.Size = New System.Drawing.Size(183, 27)
        Me.email_txt.TabIndex = 153
        '
        'Sign_but
        '
        Me.Sign_but.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Sign_but.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Sign_but.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Sign_but.Location = New System.Drawing.Point(629, 436)
        Me.Sign_but.Name = "Sign_but"
        Me.Sign_but.Size = New System.Drawing.Size(159, 69)
        Me.Sign_but.TabIndex = 150
        Me.Sign_but.Text = "Signin"
        Me.Sign_but.UseVisualStyleBackColor = False
        '
        'Login_but
        '
        Me.Login_but.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Login_but.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Login_but.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Login_but.Location = New System.Drawing.Point(765, 118)
        Me.Login_but.Name = "Login_but"
        Me.Login_but.Size = New System.Drawing.Size(159, 76)
        Me.Login_but.TabIndex = 149
        Me.Login_but.Text = "Login"
        Me.Login_but.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(423, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(539, 68)
        Me.Label3.TabIndex = 155
        Me.Label3.Text = "Dont have an account,Add new account"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(152, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 57)
        Me.Label4.TabIndex = 151
        Me.Label4.Text = "Email"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(152, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 60)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Password"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 533)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.password_txt)
        Me.Controls.Add(Me.email_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Sign_but)
        Me.Controls.Add(Me.Login_but)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "login"
        Me.Text = "login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents password_txt As TextBox
    Friend WithEvents email_txt As TextBox
    Friend WithEvents Sign_but As Button
    Friend WithEvents Login_but As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
