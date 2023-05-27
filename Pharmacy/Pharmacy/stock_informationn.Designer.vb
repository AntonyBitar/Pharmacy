<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class stock_informationn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stock_informationn))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView_employe = New System.Windows.Forms.DataGridView()
        Me.Active_employe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView_Product = New System.Windows.Forms.DataGridView()
        Me.Bar_Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Namee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_Production = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_expiry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_employe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1465, 523)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 150
        Me.PictureBox1.TabStop = False
        '
        'DataGridView_employe
        '
        Me.DataGridView_employe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_employe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Active_employe, Me.Phone_number})
        Me.DataGridView_employe.Location = New System.Drawing.Point(948, 120)
        Me.DataGridView_employe.Name = "DataGridView_employe"
        Me.DataGridView_employe.RowHeadersWidth = 51
        Me.DataGridView_employe.RowTemplate.Height = 29
        Me.DataGridView_employe.Size = New System.Drawing.Size(453, 355)
        Me.DataGridView_employe.TabIndex = 154
        '
        'Active_employe
        '
        Me.Active_employe.HeaderText = "Active Employe"
        Me.Active_employe.MinimumWidth = 6
        Me.Active_employe.Name = "Active_employe"
        Me.Active_employe.Width = 200
        '
        'Phone_number
        '
        Me.Phone_number.HeaderText = "Telephone_number"
        Me.Phone_number.MinimumWidth = 6
        Me.Phone_number.Name = "Phone_number"
        Me.Phone_number.Width = 200
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(1109, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 38)
        Me.Label2.TabIndex = 153
        Me.Label2.Text = "Employe"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(260, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 38)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "All Products"
        '
        'DataGridView_Product
        '
        Me.DataGridView_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Product.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Bar_Code, Me.Namee, Me.Quantite, Me.Date_Production, Me.Date_expiry})
        Me.DataGridView_Product.Location = New System.Drawing.Point(64, 97)
        Me.DataGridView_Product.Name = "DataGridView_Product"
        Me.DataGridView_Product.RowHeadersWidth = 51
        Me.DataGridView_Product.RowTemplate.Height = 29
        Me.DataGridView_Product.Size = New System.Drawing.Size(678, 410)
        Me.DataGridView_Product.TabIndex = 151
        '
        'Bar_Code
        '
        Me.Bar_Code.HeaderText = "Bar_Code"
        Me.Bar_Code.MinimumWidth = 6
        Me.Bar_Code.Name = "Bar_Code"
        Me.Bar_Code.Width = 125
        '
        'Namee
        '
        Me.Namee.HeaderText = "Name"
        Me.Namee.MinimumWidth = 6
        Me.Namee.Name = "Namee"
        Me.Namee.Width = 125
        '
        'Quantite
        '
        Me.Quantite.HeaderText = "Quantite"
        Me.Quantite.MinimumWidth = 6
        Me.Quantite.Name = "Quantite"
        Me.Quantite.Width = 125
        '
        'Date_Production
        '
        Me.Date_Production.HeaderText = "Date_Production"
        Me.Date_Production.MinimumWidth = 6
        Me.Date_Production.Name = "Date_Production"
        Me.Date_Production.Width = 125
        '
        'Date_expiry
        '
        Me.Date_expiry.HeaderText = "Date_expiry"
        Me.Date_expiry.MinimumWidth = 6
        Me.Date_expiry.Name = "Date_expiry"
        Me.Date_expiry.Width = 125
        '
        'stock_informationn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1465, 523)
        Me.Controls.Add(Me.DataGridView_employe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView_Product)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "stock_informationn"
        Me.Text = "stock_information"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_employe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView_employe As DataGridView
    Friend WithEvents Active_employe As DataGridViewTextBoxColumn
    Friend WithEvents Phone_number As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView_Product As DataGridView
    Friend WithEvents Bar_Code As DataGridViewTextBoxColumn
    Friend WithEvents Namee As DataGridViewTextBoxColumn
    Friend WithEvents Quantite As DataGridViewTextBoxColumn
    Friend WithEvents Date_Production As DataGridViewTextBoxColumn
    Friend WithEvents Date_expiry As DataGridViewTextBoxColumn
End Class
