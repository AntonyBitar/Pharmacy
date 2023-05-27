Imports System.Data.SqlClient

Public Class SqlCommandManager
    Private Shared _instance As SqlCommandManager
    Private sqlconnection As SqlConnection
    Private sqldataset As DataSet

    Private Sub New()
        sqlconnection = Connection.Instance.SQLConnection
        sqldataset = SqlDataSett.Instance.SQLDataSet
    End Sub
    Public Shared ReadOnly Property Instance As SqlCommandManager
        Get
            If _instance Is Nothing Then
                _instance = New SqlCommandManager()

            End If
            Return _instance
        End Get
    End Property
    Public ReadOnly Property sqlconnections As SqlConnection
        Get
            Return sqlconnection
        End Get

    End Property
    Public ReadOnly Property sqldatasets As DataSet
        Get
            Return sqldataset
        End Get

    End Property
    'Public Function GetEmployeeData() As DataTable
    '    Dim dataTable As New DataTable()
    '    Dim query As String = "SELECT EmployeeID, EmployeeName FROM Employees"
    '    Using adapter As New SqlDataAdapter(query, sqlconnection)
    '        adapter.Fill(dataTable)
    '    End Using


    '    Return dataTable
    'End Function
End Class

