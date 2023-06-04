Imports System.Data.SqlClient

Public Class login

    Public Function getEmployeEmail()

        For Each rows As DataRow In SqlCommandManager.Instance.sqldatasets.Tables("Employe").Rows
            's = rows.Item("Email_employe")
            If rows.Item("Email_employe") = email_txt.Text And rows.Item("Password") = password_txt.Text Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub Login_but_Click(sender As Object, e As EventArgs) Handles Login_but.Click
        If getEmployeEmail() Then
            MsgBox("Weclome")
            Purchase.ShowDialog(Me)
        Else
            MsgBox("Invalid Email/Password")
        End If
    End Sub

    Private Sub Sign_but_Click(sender As Object, e As EventArgs) Handles Sign_but.Click
        add_new_employe.Show(Me)
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlCommandManager.Instance.FillData()
    End Sub

End Class