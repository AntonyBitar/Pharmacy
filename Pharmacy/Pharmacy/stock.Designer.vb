<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class stock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stock))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.But_P_R_from_stock = New System.Windows.Forms.Button()
        Me.txt_Name_P_R = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.But_P_A_to_stock = New System.Windows.Forms.Button()
        Me.NumericUpDown_Q_A_R = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimeExpiry_Product_A_R = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeProduction_Product_A_R = New System.Windows.Forms.DateTimePicker()
        Me.txt_bar_code_A_R = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Prix_unitaire_stock = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Q_A_R, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1450, 733)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 148
        Me.PictureBox1.TabStop = False
        '
        'But_P_R_from_stock
        '
        Me.But_P_R_from_stock.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.But_P_R_from_stock.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.But_P_R_from_stock.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.But_P_R_from_stock.Location = New System.Drawing.Point(784, 338)
        Me.But_P_R_from_stock.Name = "But_P_R_from_stock"
        Me.But_P_R_from_stock.Size = New System.Drawing.Size(378, 57)
        Me.But_P_R_from_stock.TabIndex = 160
        Me.But_P_R_from_stock.Text = "Remove from the Stock"
        Me.But_P_R_from_stock.UseVisualStyleBackColor = False
        '
        'txt_Name_P_R
        '
        Me.txt_Name_P_R.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_Name_P_R.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_Name_P_R.Location = New System.Drawing.Point(873, 163)
        Me.txt_Name_P_R.Multiline = True
        Me.txt_Name_P_R.Name = "txt_Name_P_R"
        Me.txt_Name_P_R.Size = New System.Drawing.Size(150, 34)
        Me.txt_Name_P_R.TabIndex = 159
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(873, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 38)
        Me.Label5.TabIndex = 158
        Me.Label5.Text = "Namee"
        '
        'But_P_A_to_stock
        '
        Me.But_P_A_to_stock.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.But_P_A_to_stock.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.But_P_A_to_stock.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.But_P_A_to_stock.Location = New System.Drawing.Point(293, 338)
        Me.But_P_A_to_stock.Name = "But_P_A_to_stock"
        Me.But_P_A_to_stock.Size = New System.Drawing.Size(286, 57)
        Me.But_P_A_to_stock.TabIndex = 157
        Me.But_P_A_to_stock.Text = "Add to the Stock"
        Me.But_P_A_to_stock.UseVisualStyleBackColor = False
        '
        'NumericUpDown_Q_A_R
        '
        Me.NumericUpDown_Q_A_R.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NumericUpDown_Q_A_R.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NumericUpDown_Q_A_R.Location = New System.Drawing.Point(1287, 170)
        Me.NumericUpDown_Q_A_R.Name = "NumericUpDown_Q_A_R"
        Me.NumericUpDown_Q_A_R.Size = New System.Drawing.Size(150, 27)
        Me.NumericUpDown_Q_A_R.TabIndex = 156
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(1287, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 38)
        Me.Label4.TabIndex = 155
        Me.Label4.Text = "quantite"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(242, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 38)
        Me.Label3.TabIndex = 154
        Me.Label3.Text = "Production date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(563, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 38)
        Me.Label2.TabIndex = 153
        Me.Label2.Text = "Expiry Date"
        '
        'DateTimeExpiry_Product_A_R
        '
        Me.DateTimeExpiry_Product_A_R.CalendarFont = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DateTimeExpiry_Product_A_R.Location = New System.Drawing.Point(554, 170)
        Me.DateTimeExpiry_Product_A_R.Name = "DateTimeExpiry_Product_A_R"
        Me.DateTimeExpiry_Product_A_R.Size = New System.Drawing.Size(239, 27)
        Me.DateTimeExpiry_Product_A_R.TabIndex = 152
        '
        'DateTimeProduction_Product_A_R
        '
        Me.DateTimeProduction_Product_A_R.Location = New System.Drawing.Point(242, 167)
        Me.DateTimeProduction_Product_A_R.Name = "DateTimeProduction_Product_A_R"
        Me.DateTimeProduction_Product_A_R.Size = New System.Drawing.Size(245, 27)
        Me.DateTimeProduction_Product_A_R.TabIndex = 151
        '
        'txt_bar_code_A_R
        '
        Me.txt_bar_code_A_R.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_bar_code_A_R.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_bar_code_A_R.Location = New System.Drawing.Point(5, 154)
        Me.txt_bar_code_A_R.Multiline = True
        Me.txt_bar_code_A_R.Name = "txt_bar_code_A_R"
        Me.txt_bar_code_A_R.Size = New System.Drawing.Size(189, 46)
        Me.txt_bar_code_A_R.TabIndex = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 38)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "Bar Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(1078, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 38)
        Me.Label6.TabIndex = 161
        Me.Label6.Text = "Prix_U"
        '
        'Prix_unitaire_stock
        '
        Me.Prix_unitaire_stock.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Prix_unitaire_stock.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Prix_unitaire_stock.Location = New System.Drawing.Point(1069, 160)
        Me.Prix_unitaire_stock.Multiline = True
        Me.Prix_unitaire_stock.Name = "Prix_unitaire_stock"
        Me.Prix_unitaire_stock.Size = New System.Drawing.Size(150, 34)
        Me.Prix_unitaire_stock.TabIndex = 162
        '
        'stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1450, 733)
        Me.Controls.Add(Me.Prix_unitaire_stock)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.But_P_R_from_stock)
        Me.Controls.Add(Me.txt_Name_P_R)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.But_P_A_to_stock)
        Me.Controls.Add(Me.NumericUpDown_Q_A_R)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimeExpiry_Product_A_R)
        Me.Controls.Add(Me.DateTimeProduction_Product_A_R)
        Me.Controls.Add(Me.txt_bar_code_A_R)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "stock"
        Me.Text = "stock"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Q_A_R, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents But_P_R_from_stock As Button
    Friend WithEvents txt_Name_P_R As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents But_P_A_to_stock As Button
    Friend WithEvents NumericUpDown_Q_A_R As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimeExpiry_Product_A_R As DateTimePicker
    Friend WithEvents DateTimeProduction_Product_A_R As DateTimePicker
    Friend WithEvents txt_bar_code_A_R As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Prix_unitaire_stock As TextBox
End Class
