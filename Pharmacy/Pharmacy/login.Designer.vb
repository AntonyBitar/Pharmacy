<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.But_log = New System.Windows.Forms.Button()
        Me.txt_password_log = New System.Windows.Forms.TextBox()
        Me.txt_email_log = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.signup_setup = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.PictureBox1.Size = New System.Drawing.Size(800, 450)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 151
        Me.PictureBox1.TabStop = False
        '
        'But_log
        '
        Me.But_log.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.But_log.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.But_log.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.But_log.Location = New System.Drawing.Point(589, 82)
        Me.But_log.Name = "But_log"
        Me.But_log.Size = New System.Drawing.Size(142, 56)
        Me.But_log.TabIndex = 156
        Me.But_log.Text = "LogIn"
        Me.But_log.UseVisualStyleBackColor = False
        '
        'txt_password_log
        '
        Me.txt_password_log.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_password_log.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_password_log.Location = New System.Drawing.Point(12, 264)
        Me.txt_password_log.Name = "txt_password_log"
        Me.txt_password_log.Size = New System.Drawing.Size(215, 27)
        Me.txt_password_log.TabIndex = 155
        '
        'txt_email_log
        '
        Me.txt_email_log.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_email_log.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_email_log.Location = New System.Drawing.Point(12, 111)
        Me.txt_email_log.Name = "txt_email_log"
        Me.txt_email_log.Size = New System.Drawing.Size(215, 27)
        Me.txt_email_log.TabIndex = 154
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(62, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 38)
        Me.Label2.TabIndex = 153
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(62, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 38)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "Email"
        '
        'signup_setup
        '
        Me.signup_setup.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.signup_setup.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.signup_setup.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.signup_setup.Location = New System.Drawing.Point(406, 349)
        Me.signup_setup.Name = "signup_setup"
        Me.signup_setup.Size = New System.Drawing.Size(208, 56)
        Me.signup_setup.TabIndex = 158
        Me.signup_setup.Text = "Sign Up Page"
        Me.signup_setup.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(185, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(615, 38)
        Me.Label4.TabIndex = 159
        Me.Label4.Text = "I Don't have an account,Create a new account"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.signup_setup)
        Me.Controls.Add(Me.But_log)
        Me.Controls.Add(Me.txt_password_log)
        Me.Controls.Add(Me.txt_email_log)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "login"
        Me.Text = "login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents But_log As Button
    Friend WithEvents txt_password_log As TextBox
    Friend WithEvents txt_email_log As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents signup_setup As Button
    Friend WithEvents Label4 As Label

    Private Sub signup_setup_Click(sender As Object, e As EventArgs) Handles signup_setup.Click
        add_new_employe.Show()
    End Sub

    Private Sub txt_email_log_TextChanged(sender As Object, e As EventArgs) Handles txt_email_log.TextChanged

    End Sub
End Class
