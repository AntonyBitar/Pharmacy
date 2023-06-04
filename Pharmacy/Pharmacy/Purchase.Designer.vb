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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Purchase))
        but_Add = New Button()
        Label7 = New Label()
        txt_Prix_total = New TextBox()
        Txt_prix_unitaire = New TextBox()
        Label6 = New Label()
        but_stock_employe_inf = New Button()
        ComboBox_Employe = New ComboBox()
        Label5 = New Label()
        NumericUpDown_quantite = New NumericUpDown()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Expiry_Date = New DateTimePicker()
        Production_date = New DateTimePicker()
        but_employe_A_R = New Button()
        but_Product_A_R = New Button()
        txt_bar_code = New TextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(NumericUpDown_quantite, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' but_Add
        ' 
        but_Add.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        but_Add.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        but_Add.ForeColor = SystemColors.ButtonHighlight
        but_Add.Location = New Point(1229, 232)
        but_Add.Name = "but_Add"
        but_Add.Size = New Size(228, 98)
        but_Add.TabIndex = 199
        but_Add.Text = "Add(Purchase)"
        but_Add.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label7.FlatStyle = FlatStyle.Flat
        Label7.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(1246, 440)
        Label7.Name = "Label7"
        Label7.Size = New Size(140, 38)
        Label7.TabIndex = 198
        Label7.Text = "Prix Total"
        ' 
        ' txt_Prix_total
        ' 
        txt_Prix_total.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txt_Prix_total.ForeColor = SystemColors.ButtonHighlight
        txt_Prix_total.Location = New Point(1245, 506)
        txt_Prix_total.Multiline = True
        txt_Prix_total.Name = "txt_Prix_total"
        txt_Prix_total.Size = New Size(173, 58)
        txt_Prix_total.TabIndex = 197
        ' 
        ' Txt_prix_unitaire
        ' 
        Txt_prix_unitaire.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Txt_prix_unitaire.ForeColor = SystemColors.ButtonHighlight
        Txt_prix_unitaire.Location = New Point(885, 104)
        Txt_prix_unitaire.Name = "Txt_prix_unitaire"
        Txt_prix_unitaire.Size = New Size(172, 27)
        Txt_prix_unitaire.TabIndex = 196
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label6.FlatStyle = FlatStyle.Flat
        Label6.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(875, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(182, 38)
        Label6.TabIndex = 195
        Label6.Text = "Prix_unitaire"
        ' 
        ' but_stock_employe_inf
        ' 
        but_stock_employe_inf.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        but_stock_employe_inf.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        but_stock_employe_inf.ForeColor = SystemColors.ButtonHighlight
        but_stock_employe_inf.Location = New Point(74, 506)
        but_stock_employe_inf.Name = "but_stock_employe_inf"
        but_stock_employe_inf.Size = New Size(314, 91)
        but_stock_employe_inf.TabIndex = 194
        but_stock_employe_inf.Text = "Stock and Employe information"
        but_stock_employe_inf.UseVisualStyleBackColor = False
        ' 
        ' ComboBox_Employe
        ' 
        ComboBox_Employe.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ComboBox_Employe.ForeColor = SystemColors.ButtonHighlight
        ComboBox_Employe.FormattingEnabled = True
        ComboBox_Employe.Location = New Point(1131, 103)
        ComboBox_Employe.Name = "ComboBox_Employe"
        ComboBox_Employe.Size = New Size(187, 28)
        ComboBox_Employe.TabIndex = 193
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label5.FlatStyle = FlatStyle.Flat
        Label5.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(1155, 30)
        Label5.Name = "Label5"
        Label5.Size = New Size(130, 38)
        Label5.TabIndex = 192
        Label5.Text = "Employe"
        ' 
        ' NumericUpDown_quantite
        ' 
        NumericUpDown_quantite.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        NumericUpDown_quantite.ForeColor = SystemColors.ButtonHighlight
        NumericUpDown_quantite.Location = New Point(1357, 103)
        NumericUpDown_quantite.Name = "NumericUpDown_quantite"
        NumericUpDown_quantite.Size = New Size(151, 27)
        NumericUpDown_quantite.TabIndex = 191
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label4.FlatStyle = FlatStyle.Flat
        Label4.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(1366, 30)
        Label4.Name = "Label4"
        Label4.Size = New Size(128, 38)
        Label4.TabIndex = 190
        Label4.Text = "quantite"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(273, 30)
        Label3.Name = "Label3"
        Label3.Size = New Size(228, 38)
        Label3.TabIndex = 189
        Label3.Text = "Production date"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(604, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 38)
        Label2.TabIndex = 188
        Label2.Text = "Expiry Date"
        ' 
        ' Expiry_Date
        ' 
        Expiry_Date.CalendarMonthBackground = SystemColors.ButtonHighlight
        Expiry_Date.Location = New Point(548, 104)
        Expiry_Date.Name = "Expiry_Date"
        Expiry_Date.Size = New Size(284, 27)
        Expiry_Date.TabIndex = 187
        ' 
        ' Production_date
        ' 
        Production_date.CalendarForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Production_date.CalendarMonthBackground = SystemColors.ButtonHighlight
        Production_date.CalendarTitleBackColor = SystemColors.ControlText
        Production_date.Location = New Point(240, 104)
        Production_date.Name = "Production_date"
        Production_date.Size = New Size(289, 27)
        Production_date.TabIndex = 186
        ' 
        ' but_employe_A_R
        ' 
        but_employe_A_R.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        but_employe_A_R.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        but_employe_A_R.ForeColor = SystemColors.ButtonHighlight
        but_employe_A_R.Location = New Point(74, 388)
        but_employe_A_R.Name = "but_employe_A_R"
        but_employe_A_R.Size = New Size(314, 90)
        but_employe_A_R.TabIndex = 185
        but_employe_A_R.Text = "Add or remove Employe  "
        but_employe_A_R.UseVisualStyleBackColor = False
        ' 
        ' but_Product_A_R
        ' 
        but_Product_A_R.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        but_Product_A_R.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        but_Product_A_R.ForeColor = SystemColors.ButtonHighlight
        but_Product_A_R.Location = New Point(74, 272)
        but_Product_A_R.Name = "but_Product_A_R"
        but_Product_A_R.Size = New Size(314, 91)
        but_Product_A_R.TabIndex = 184
        but_Product_A_R.Text = "Add or remove Products (Stock)"
        but_Product_A_R.UseVisualStyleBackColor = False
        ' 
        ' txt_bar_code
        ' 
        txt_bar_code.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        txt_bar_code.ForeColor = SystemColors.ButtonHighlight
        txt_bar_code.Location = New Point(24, 93)
        txt_bar_code.Multiline = True
        txt_bar_code.Name = "txt_bar_code"
        txt_bar_code.Size = New Size(190, 58)
        txt_bar_code.TabIndex = 183
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(46, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 38)
        Label1.TabIndex = 182
        Label1.Text = "Bar Code"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ActiveCaptionText
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1537, 667)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 147
        PictureBox1.TabStop = False
        ' 
        ' Purchase
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1537, 667)
        Controls.Add(but_Add)
        Controls.Add(Label7)
        Controls.Add(txt_Prix_total)
        Controls.Add(Txt_prix_unitaire)
        Controls.Add(Label6)
        Controls.Add(but_stock_employe_inf)
        Controls.Add(ComboBox_Employe)
        Controls.Add(Label5)
        Controls.Add(NumericUpDown_quantite)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Expiry_Date)
        Controls.Add(Production_date)
        Controls.Add(but_employe_A_R)
        Controls.Add(but_Product_A_R)
        Controls.Add(txt_bar_code)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Purchase"
        Text = "Purchasee"
        CType(NumericUpDown_quantite, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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
