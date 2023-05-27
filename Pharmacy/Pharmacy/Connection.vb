Imports System.Data.SqlClient

Public Class Connection
    Private Shared _instance As Connection
    Private _sqlConnection As SqlConnection


    Private Sub New()
        Dim connection As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PharmacyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        _sqlConnection = New SqlConnection(connection)
        _sqlConnection.Open()

        'dataTable.Rows.Add(1, "txt_Name_Sign", "txt_Email_sign", "txt_Password_sign", "txt_phone_number")


    End Sub

    Public Sub CloseConnection()
        _sqlConnection.Close()
    End Sub

    Public Shared ReadOnly Property Instance As Connection ' static property
        Get

            If _instance Is Nothing Then
                _instance = New Connection()
            End If
            Return _instance
        End Get
    End Property

    Public ReadOnly Property SQLConnection As SqlConnection
        Get
            Return _sqlConnection
        End Get
    End Property


End Class
