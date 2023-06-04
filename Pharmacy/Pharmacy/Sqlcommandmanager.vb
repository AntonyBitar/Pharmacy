Imports System.Data.SqlClient
Public Enum opearation
    Insert
    Update
    Delete
End Enum
Public Class SqlCommandManager

    Private Shared _instance As SqlCommandManager
    Private sqlconnection As SqlConnection
    Private sqldataset As DataSet
    Private _sqldataadapter As SqlDataAdapter

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
    Public ReadOnly Property SqlDataAdapter As SqlDataAdapter
        Get
            Return _sqldataadapter
        End Get

    End Property
    Public ReadOnly Property sqldatasets As DataSet
        Get
            Return sqldataset
        End Get

    End Property
    Public Function UpdateTable(tablename As String, op As opearation)

        _sqldataadapter.SelectCommand = New SqlCommand($"SELECT * FROM {tablename}", sqlconnection)
        Dim builder As SqlCommandBuilder = New SqlCommandBuilder(_sqldataadapter)
        If op = opearation.Insert Then
            _sqldataadapter.InsertCommand = builder.GetInsertCommand()
        ElseIf op = opearation.Update Then
            _sqldataadapter.UpdateCommand = builder.GetUpdateCommand()
        Else
            _sqldataadapter.DeleteCommand = builder.GetDeleteCommand()
        End If
        _sqldataadapter.Update(sqldatasets.Tables(tablename))

    End Function
    Public Sub FillData()
        If (sqldataset.Tables.Count) <> 0 Then
            Return
        End If
        Dim tablesSchema As DataTable = sqlconnection.GetSchema("Tables")
        _sqldataadapter = New SqlDataAdapter(Nothing, sqlconnection)

        ' Iterate through each table and retrieve the data
        For Each row As DataRow In tablesSchema.Rows
            Dim tableName As String = row("TABLE_NAME").ToString()

            ' Create the DataTable and add it to the DataSet
            Dim dataTable As New DataTable(tableName)
            sqldataset.Tables.Add(dataTable)

            ' Retrieve the data from the table
            Dim selectQuery As String = $"SELECT * FROM {tableName}"
            _sqldataadapter.SelectCommand = New SqlCommand(selectQuery, sqlconnection)
            'Using adapter As New SqlDataAdapter(selectQuery, sqlconnection)
            _sqldataadapter.Fill(sqldataset, tableName)
            'End Using
        Next

        Dim primaryKeySchema As DataTable = sqlconnection.GetSchema("Indexes")

        For Each primaryKeyRow As DataRow In primaryKeySchema.Rows
            Dim primaryKeyInf As String() = primaryKeyRow("CONSTRAINT_NAME").ToString().Split("__")
            Dim Table As DataTable = sqldataset.Tables(primaryKeyRow("TABLE_NAME"))

            Dim primaryKeyColumns(primaryKeyInf.Length - If(primaryKeyInf(0).Equals("Auto"), 2, 1)) As DataColumn

            For i = If(primaryKeyInf(0).Equals("Auto"), 1, 0) To primaryKeyInf.Length - 1
                primaryKeyColumns(i - If(primaryKeyInf(0).Equals("Auto"), 1, 0)) = Table.Columns(primaryKeyInf(i))
            Next

            If primaryKeyInf(0).Equals("Auto") Then
                primaryKeyColumns(0).AutoIncrement = True
                primaryKeyColumns(0).AutoIncrementSeed = 1
                primaryKeyColumns(0).AutoIncrementStep = 1
            End If
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

