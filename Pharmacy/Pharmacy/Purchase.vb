Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Purchase
    Private Sub but_Product_A_R_Click(sender As Object, e As EventArgs) Handles but_Product_A_R.Click
        Dim newForm As New stock()
        newForm.ShowDialog()
    End Sub

    Private Sub but_employe_A_R_Click(sender As Object, e As EventArgs) Handles but_employe_A_R.Click
        Dim newform As New add_new_employe()
        newform.ShowDialog()
    End Sub

    Private Sub but_stock_employe_inf_Click(sender As Object, e As EventArgs) Handles but_stock_employe_inf.Click
        Dim newform As New stock_informationn()

        newform.ShowDialog()
    End Sub

    Private Sub but_Add_Click(sender As Object, e As EventArgs) Handles but_Add.Click



        Dim total As Long
        Dim con As SqlConnection = Connection.Instance.SQLConnection
        total = Txt_prix_unitaire.Text * NumericUpDown_quantite.Value
        txt_Prix_total.Text = total

    End Sub

    Private Sub Txt_prix_unitaire_TextChanged(sender As Object, e As EventArgs) Handles Txt_prix_unitaire.TextChanged
        Dim antony As String
        Dim i As Integer = 0

        If IsNumeric(Txt_prix_unitaire.Text) = False And Txt_prix_unitaire.TextLength <> 0 Then
            antony = Txt_prix_unitaire.Text
            i = antony.IndexOf(antony.Where(Function(n) IsNumeric(n) = False).First())
            Txt_prix_unitaire.Clear()
            Txt_prix_unitaire.Text = antony.Substring(0, i) + antony.Substring(i + 1)
            Txt_prix_unitaire.Select(i, 0)
            Txt_prix_unitaire.Focus()
        End If
    End Sub

    Private Sub ComboBox_Employe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Employe.SelectedIndexChanged

        ''''ComboBox_Employe.Items.Add(SqlCommandManager.Instance.GetEmployeeData())
    End Sub

    Private Sub Purchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT Name_Employe FROM Employe"
        Using command As New SqlCommand(query, SqlCommandManager.Instance.sqlconnections)
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                    ComboBox_Employe.Items.Add(reader("Name_Employe").ToString())
                End While
            End Using


    End Sub

    'Dim query As String = "SELECT * FROM Product"
    'Dim queryy As New SqlCommand(query, antony)
    'Dim adapter As New SqlDataAdapter(queryy)
    'Dim dataset As New DataSet()
    'Dim productsTable As DataTable = dataset.Tables("Product")
    'Dim cmd As New SqlCommand("INSERT INTO Product (Bar_code, Desc_p,P_name,P_prix_unitaire) VALUES() )", Connection)
    'cmd.Parameters.AddWithValue("@name", Name)
    'cmd.Parameters.AddWithValue("@age", age)
End Class
