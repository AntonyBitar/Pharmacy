Public Class SQLDataSetSI
    Private Shared _instance As SQLDataSetSI
    Private _dataSet As DataSet
    Sub New()
        _dataSet = New DataSet
    End Sub
    Public Shared ReadOnly Property Instance As SQLDataSetSI ' static property
        Get

            If _instance Is Nothing Then
                _instance = New SQLDataSetSI()
            End If
            Return _instance
        End Get
    End Property
    Public ReadOnly Property SqlDataSet As DataSet ' static property
        Get
            Return _dataSet
        End Get
    End Property

End Class
