Imports System.Data.SqlClient

Public Class SqlCommandManager
    Private Shared _instance As SqlCommandManager
    Private sqlconnection As SqlConnection
    Private sqldataset As DataSet

    Private Sub New()
        sqlconnection = Connection.Instance.SQLConnection
        sqldataset = SQLDataSetSI.Instance.SqlDataSet
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
    Public Sub FillData()
        Dim tablesSchema As DataTable = sqlconnection.GetSchema("Tables")
        ' Iterate through each table and retrieve the data
        For Each row As DataRow In tablesSchema.Rows
            Dim tableName As String = row("TABLE_NAME").ToString()

            ' Create the DataTable and add it to the DataSet
            Dim dataTable As New DataTable(tableName)
            sqldataset.Tables.Add(dataTable)

            ' Retrieve the data from the table
            Dim selectQuery As String = $"SELECT * FROM {tableName}"
            Using adapter As New SqlDataAdapter(selectQuery, sqlconnection)
                adapter.Fill(dataTable)
            End Using
        Next

        Dim primaryKeySchema As DataTable = sqlconnection.GetSchema("Indexes")

        For Each primaryKeyRow As DataRow In primaryKeySchema.Rows
            Dim primaryKeyInf As String() = primaryKeyRow("CONSTRAINT_NAME").ToString().Split("__")
            Dim Table As DataTable = sqldataset.Tables(primaryKeyRow("TABLE_NAME"))

            Dim primaryKeyColumns(primaryKeyInf.Length - 1) As DataColumn
            For i = 0 To primaryKeyInf.Length - 1
                primaryKeyColumns(i) = Table.Columns(primaryKeyInf(i))
            Next

            Table.PrimaryKey = primaryKeyColumns
        Next

        Dim relationshipsSchema As DataTable = sqlconnection.GetSchema("ForeignKeys")

        For Each relationRow As DataRow In relationshipsSchema.Rows
            Dim foreignKeyInf As String() = relationRow("CONSTRAINT_NAME").ToString().Split("__")

            Dim childTable As DataTable = sqldataset.Tables(foreignKeyInf(0))
            Dim parentTable As DataTable = sqldataset.Tables(foreignKeyInf(2))

            Dim dataRelation As New DataRelation(relationRow("CONSTRAINT_NAME").ToString(),
                                                parentTable.Columns(foreignKeyInf(3)),
                                                childTable.Columns(foreignKeyInf(1)))
            sqldataset.Relations.Add(dataRelation)
        Next

    End Sub



    'Public Function GetEmployeeData() As DataTable
    '    Dim dataTable As New DataTable()
    '    Dim query As String = "SELECT EmployeeID, EmployeeName FROM Employees"
    '    Using adapter As New SqlDataAdapter(query, sqlconnection)
    '        adapter.Fill(dataTable)
    '    End Using


    '    Return dataTable
    'End Function
End Class

