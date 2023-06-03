Imports System.Data.SqlClient

Public Class add_new_employe
    Dim k As Integer = 0
    Dim b As Integer = 0
    Dim con As SqlCommandManager
    Dim con1 As SQLDataSetSI
    Public Sub But_Submit_Click(sender As Object, e As EventArgs) Handles But_Submit.Click
        If txt_Name_Sign.Text = "" Then
            MsgBox("Enter a valid Name")
            Exit Sub
        ElseIf txt_Email_sign.Text = "" Then
            MsgBox("Enter a Valid Email Adresse")
            Exit Sub
        ElseIf txt_Password_sign.Text = "" Then
            MsgBox("Enter a Valid Password")
            Exit Sub
        ElseIf txt_phone_number.Text = "" Then
            MsgBox("Enter a Valid Phone Number")
            Exit Sub
        End If
        For p As Integer = 0 To txt_Email_sign.Text.Length - 1
            If Not (txt_Email_sign.Text.Contains("@")) Then
                MsgBox("Enter a Valid Email Adresse")
                Exit Sub
            End If
        Next
        MsgBox("hello")
        MsgBox("hello")
        con = SqlCommandManager.Instance
        Dim bati5 As String = "INSERT INTO Employe (Name_Employe, Email_employe,Password,Telephone_Employe)VALUES('" & txt_Name_Sign.Text & "','" & txt_Email_sign.Text & "','" & txt_Password_sign.Text & "','" & txt_phone_number.Text & "')"
        Dim cmd As New SqlCommand(bati5, con.sqlconnections)
        cmd.ExecuteNonQuery()
        MsgBox("Welcome To The Store")
        Purchase.ShowDialog()
    End Sub

    Private Sub txt_phone_number_TextChanged(sender As Object, e As EventArgs) Handles txt_phone_number.TextChanged
        Dim i As Integer = 0
        If k = 0 Then
            For i = i To txt_phone_number.Text.Length() - 1
                If IsNumeric(txt_phone_number.Text(i)) = False Then
                    k += 1
                    txt_phone_number.Text = txt_phone_number.Text.Substring(0, i) + txt_phone_number.Text.Substring(i + 1)
                    txt_phone_number.Select(i, 0)
                    txt_phone_number.Focus()
                    Exit Sub
                End If
            Next
        Else
            k = 0
            txt_phone_number.Select(i, 0)
            txt_phone_number.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txt_Email_sign_TextChanged(sender As Object, e As EventArgs) Handles txt_Email_sign.TextChanged

    End Sub

    Private Sub txt_Name_Sign_TextChanged(sender As Object, e As EventArgs) Handles txt_Name_Sign.TextChanged
        Dim v As Integer = 0
        If b = 0 Then
            For v = v To txt_Name_Sign.Text.Length() - 1
                If IsNumeric(txt_Name_Sign.Text(v)) = True Then
                    b += 1
                    txt_Name_Sign.Text = txt_Name_Sign.Text.Substring(0, v) + txt_Name_Sign.Text.Substring(v + 1)
                    txt_Name_Sign.Select(v, 0)
                    txt_Name_Sign.Focus()
                    Exit Sub
                End If
            Next
        Else
            b = 0
            txt_Name_Sign.Select(v, 0)
            txt_Name_Sign.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub add_new_employe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        login.Hide()
        Me.Show()
    End Sub
End Class

'cmd.Parameters.AddWithValue("@txt_Name_Sign", txt_Name_Sign.Text)
'cmd.Parameters.AddWithValue("@txt_Email_sign", txt_Email_sign.Text)
'cmd.Parameters.AddWithValue("@txt_Password_sign", txt_Password_sign.Text)
'cmd.Parameters.AddWithValue("@txt_phone_number", txt_phone_number.Text)
'con.Open()
'dataTable.Columns.Add("Name_Employe", GetType(String))
'dataTable.Columns.Add("Email_employe", GetType(String))
'dataTable.Columns.Add("Password", GetType(String))
'dataTable.Columns.Add("Telephone_Employe", GetType(String))
'Dim newRow As DataRow = dataTable.NewRow()
'newRow("Name_Employe") = txt_Name_Sign.Text
'newRow("Email_employe") = txt_Email_sign.Text
'newRow("Password") = txt_Password_sign.Text
'newRow("Telephone_Employe") = txt_phone_number.Text
'dataTable.Rows.Add(newRow)
'Dim sqldataset As DataSet = New DataSet()
'sqldataset.Tables.Add(dataTable)
'Dim sqldataadapter As New SqlDataAdapter("INSERT INTO Employe (Name_Employe, Email_employe,Password,Telephone_Employe)VALUES(@txt_Name_Sign,@txt_Email_sign,@txt_Password_sign,@txt_phone_number)", con)
'Dim dataTable As New DataTable("Employe")

'Dim cmd As New SqlCommand("INSERT INTO Employe (Name_Employe, Email_employe,Password,Telephone_Employe) VALUES(@txt_Name_Sign,@txt_Email_sign,@txt_Password_sign,@txt_phone_number)", con)
'cmd.Parameters.AddWithValue("@Name_Employe", txt_Name_Sign.Text)
'cmd.Parameters.AddWithValue("@Email_employe", txt_Email_sign.Text)
'cmd.Parameters.AddWithValue("@Password", txt_Password_sign.Text)
'cmd.Parameters.AddWithValue("@Telephone_Employe", txt_phone_number.Text)
'cmd.ExecuteReader()
'Dim cmd As New SqlCommand("SELECT * FROM Employe", con)
'Private Sub Button1_Click(sender As Object, e As EventArgs)
'    Purchase.ComboBox_Employe.Items.Add(txt_Name_Sign.Text)
'End Sub
'cmd.Parameters.AddWithValue("@Name_Employe", "txt_Name_Sign.text")
'cmd.Parameters.AddWithValue("@Email_employe", "txt_Email_sign.text")
'cmd.Parameters.AddWithValue("@Password", "txt_Password_sign.text")
'cmd.Parameters.AddWithValue("@Telephone_Employe", "txt_phone_number.text")
