<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Purchase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Purchase))
        Me.but_Add = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Prix_total = New System.Windows.Forms.TextBox()
        Me.Txt_prix_unitaire = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.but_stock_employe_inf = New System.Windows.Forms.Button()
        Me.ComboBox_Employe = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown_quantite = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Expiry_Date = New System.Windows.Forms.DateTimePicker()
        Me.Production_date = New System.Windows.Forms.DateTimePicker()
        Me.but_employe_A_R = New System.Windows.Forms.Button()
        Me.but_Product_A_R = New System.Windows.Forms.Button()
        Me.txt_bar_code = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.NumericUpDown_quantite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'but_Add
        '
        Me.but_Add.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.but_Add.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.but_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.but_Add.Location = New System.Drawing.Point(1229, 232)
        Me.but_Add.Name = "but_Add"
        Me.but_Add.Size = New System.Drawing.Size(228, 98)
        Me.but_Add.TabIndex = 199
        Me.but_Add.Text = "Add(Purchase)"
        Me.but_Add.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(1246, 440)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 38)
        Me.Label7.TabIndex = 198
        Me.Label7.Text = "Prix Total"
        '
        'txt_Prix_total
        '
        Me.txt_Prix_total.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_Prix_total.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_Prix_total.Location = New System.Drawing.Point(1245, 506)
        Me.txt_Prix_total.Multiline = True
        Me.txt_Prix_total.Name = "txt_Prix_total"
        Me.txt_Prix_total.Size = New System.Drawing.Size(173, 58)
        Me.txt_Prix_total.TabIndex = 197
        '
        'Txt_prix_unitaire
        '
        Me.Txt_prix_unitaire.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Txt_prix_unitaire.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Txt_prix_unitaire.Location = New System.Drawing.Point(885, 104)
        Me.Txt_prix_unitaire.Name = "Txt_prix_unitaire"
        Me.Txt_prix_unitaire.Size = New System.Drawing.Size(172, 27)
        Me.Txt_prix_unitaire.TabIndex = 196
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(875, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(182, 38)
        Me.Label6.TabIndex = 195
        Me.Label6.Text = "Prix_unitaire"
        '
        'but_stock_employe_inf
        '
        Me.but_stock_employe_inf.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.but_stock_employe_inf.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.but_stock_employe_inf.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.but_stock_employe_inf.Location = New System.Drawing.Point(74, 506)
        Me.but_stock_employe_inf.Name = "but_stock_employe_inf"
        Me.but_stock_employe_inf.Size = New System.Drawing.Size(314, 91)
        Me.but_stock_employe_inf.TabIndex = 194
        Me.but_stock_employe_inf.Text = "Stock and Employe information"
        Me.but_stock_employe_inf.UseVisualStyleBackColor = False
        '
        'ComboBox_Employe
        '
        Me.ComboBox_Employe.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ComboBox_Employe.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ComboBox_Employe.FormattingEnabled = True
        Me.ComboBox_Employe.Location = New System.Drawing.Point(1131, 103)
        Me.ComboBox_Employe.Name = "ComboBox_Employe"
        Me.ComboBox_Employe.Size = New System.Drawing.Size(187, 28)
        Me.ComboBox_Employe.TabIndex = 193
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(1155, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 38)
        Me.Label5.TabIndex = 192
        Me.Label5.Text = "Employe"
        '
        'NumericUpDown_quantite
        '
        Me.NumericUpDown_quantite.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NumericUpDown_quantite.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NumericUpDown_quantite.Location = New System.Drawing.Point(1357, 103)
        Me.NumericUpDown_quantite.Name = "NumericUpDown_quantite"
        Me.NumericUpDown_quantite.Size = New System.Drawing.Size(151, 27)
        Me.NumericUpDown_quantite.TabIndex = 191
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1366, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 38)
        Me.Label4.TabIndex = 190
        Me.Label4.Text = "quantite"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(273, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 38)
        Me.Label3.TabIndex = 189
        Me.Label3.Text = "Production date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(604, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 38)
        Me.Label2.TabIndex = 188
        Me.Label2.Text = "Expiry Date"
        '
        'Expiry_Date
        '
        Me.Expiry_Date.CalendarMonthBackground = System.Drawing.SystemColors.ButtonHighlight
        Me.Expiry_Date.Location = New System.Drawing.Point(548, 104)
        Me.Expiry_Date.Name = "Expiry_Date"
        Me.Expiry_Date.Size = New System.Drawing.Size(284, 27)
        Me.Expiry_Date.TabIndex = 187
        '
        'Production_date
        '
        Me.Production_date.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Production_date.CalendarMonthBackground = System.Drawing.SystemColors.ButtonHighlight
        Me.Production_date.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.Production_date.Location = New System.Drawing.Point(240, 104)
        Me.Production_date.Name = "Production_date"
        Me.Production_date.Size = New System.Drawing.Size(289, 27)
        Me.Production_date.TabIndex = 186
        '
        'but_employe_A_R
        '
        Me.but_employe_A_R.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.but_employe_A_R.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.but_employe_A_R.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.but_employe_A_R.Location = New System.Drawing.Point(74, 388)
        Me.but_employe_A_R.Name = "but_employe_A_R"
        Me.but_employe_A_R.Size = New System.Drawing.Size(314, 90)
        Me.but_employe_A_R.TabIndex = 185
        Me.but_employe_A_R.Text = "Add or remove Employe  "
        Me.but_employe_A_R.UseVisualStyleBackColor = False
        '
        'but_Product_A_R
        '
        Me.but_Product_A_R.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.but_Product_A_R.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.but_Product_A_R.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.but_Product_A_R.Location = New System.Drawing.Point(74, 272)
        Me.but_Product_A_R.Name = "but_Product_A_R"
        Me.but_Product_A_R.Size = New System.Drawing.Size(314, 91)
        Me.but_Product_A_R.TabIndex = 184
        Me.but_Product_A_R.Text = "Add or remove Products (Stock)"
        Me.but_Product_A_R.UseVisualStyleBackColor = False
        '
        'txt_bar_code
        '
        Me.txt_bar_code.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_bar_code.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_bar_code.Location = New System.Drawing.Point(24, 93)
        Me.txt_bar_code.Multiline = True
        Me.txt_bar_code.Name = "txt_bar_code"
        Me.txt_bar_code.Size = New System.Drawing.Size(190, 58)
        Me.txt_bar_code.TabIndex = 183
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(46, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 38)
        Me.Label1.TabIndex = 182
        Me.Label1.Text = "Bar Code"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1537, 667)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 147
        Me.PictureBox1.TabStop = False
        '
        'Purchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1537, 667)
        Me.Controls.Add(Me.but_Add)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_Prix_total)
        Me.Controls.Add(Me.Txt_prix_unitaire)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.but_stock_employe_inf)
        Me.Controls.Add(Me.ComboBox_Employe)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumericUpDown_quantite)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Expiry_Date)
        Me.Controls.Add(Me.Production_date)
        Me.Controls.Add(Me.but_employe_A_R)
        Me.Controls.Add(Me.but_Product_A_R)
        Me.Controls.Add(Me.txt_bar_code)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Purchase"
        Me.Text = "Purchasee"
        CType(Me.NumericUpDown_quantite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents but_Add As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_Prix_total As TextBox
    Friend WithEvents Txt_prix_unitaire As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents but_stock_employe_inf As Button
    Friend WithEvents ComboBox_Employe As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown_quantite As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Expiry_Date As DateTimePicker
    Friend WithEvents Production_date As DateTimePicker
    Friend WithEvents but_employe_A_R As Button
    Friend WithEvents but_Product_A_R As Button
    Friend WithEvents txt_bar_code As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
