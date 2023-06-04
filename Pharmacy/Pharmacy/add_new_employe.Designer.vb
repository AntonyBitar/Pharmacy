<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class add_new_employe
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(add_new_employe))
        txt_Password_sign = New TextBox()
        Label4 = New Label()
        txt_phone_number = New TextBox()
        Label3 = New Label()
        But_Submit = New Button()
        txt_Email_sign = New TextBox()
        txt_Name_Sign = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_Password_sign
        ' 
        txt_Password_sign.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txt_Password_sign.ForeColor = SystemColors.ButtonHighlight
        txt_Password_sign.Location = New Point(12, 281)
        txt_Password_sign.Name = "txt_Password_sign"
        txt_Password_sign.Size = New Size(258, 27)
        txt_Password_sign.TabIndex = 158
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label4.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(54, 219)
        Label4.Name = "Label4"
        Label4.Size = New Size(139, 38)
        Label4.TabIndex = 157
        Label4.Text = "Password"
        ' 
        ' txt_phone_number
        ' 
        txt_phone_number.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txt_phone_number.ForeColor = SystemColors.ButtonHighlight
        txt_phone_number.Location = New Point(12, 390)
        txt_phone_number.Name = "txt_phone_number"
        txt_phone_number.Size = New Size(258, 27)
        txt_phone_number.TabIndex = 156
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(54, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 38)
        Label3.TabIndex = 155
        Label3.Text = "Email"
        ' 
        ' But_Submit
        ' 
        But_Submit.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        But_Submit.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        But_Submit.ForeColor = SystemColors.ButtonHighlight
        But_Submit.Location = New Point(676, 172)
        But_Submit.Name = "But_Submit"
        But_Submit.Size = New Size(128, 62)
        But_Submit.TabIndex = 154
        But_Submit.Text = "Submit"
        But_Submit.UseVisualStyleBackColor = False
        ' 
        ' txt_Email_sign
        ' 
        txt_Email_sign.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txt_Email_sign.ForeColor = SystemColors.ButtonHighlight
        txt_Email_sign.Location = New Point(12, 172)
        txt_Email_sign.Name = "txt_Email_sign"
        txt_Email_sign.Size = New Size(258, 27)
        txt_Email_sign.TabIndex = 153
        ' 
        ' txt_Name_Sign
        ' 
        txt_Name_Sign.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txt_Name_Sign.ForeColor = SystemColors.ButtonHighlight
        txt_Name_Sign.Location = New Point(12, 62)
        txt_Name_Sign.Name = "txt_Name_Sign"
        txt_Name_Sign.Size = New Size(258, 27)
        txt_Name_Sign.TabIndex = 152
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(35, 330)
        Label2.Name = "Label2"
        Label2.Size = New Size(216, 38)
        Label2.TabIndex = 151
        Label2.Text = "Phone Number"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(54, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 38)
        Label1.TabIndex = 150
        Label1.Text = "Name"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(892, 450)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 149
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(514, 330)
        Button1.Name = "Button1"
        Button1.Size = New Size(336, 62)
        Button1.TabIndex = 159
        Button1.Text = "Go back to login page"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' add_new_employe
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(892, 450)
        Controls.Add(Button1)
        Controls.Add(txt_Password_sign)
        Controls.Add(Label4)
        Controls.Add(txt_phone_number)
        Controls.Add(Label3)
        Controls.Add(But_Submit)
        Controls.Add(txt_Email_sign)
        Controls.Add(txt_Name_Sign)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "add_new_employe"
        Text = "add_new_employe"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txt_Password_sign As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_phone_number As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents But_Submit As Button
    Friend WithEvents txt_Email_sign As TextBox
    Friend WithEvents txt_Name_Sign As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
