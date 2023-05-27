Public Class SqlDataSett
    Private Shared _instance As SqlDataSett
    Private _dataSet As DataSet
    Sub New()
        _dataSet = New DataSet
    End Sub
    Public Shared ReadOnly Property Instance As SqlDataSett ' static property
        Get

            If _instance Is Nothing Then
                _instance = New SqlDataSett()
            End If
            Return _instance
        End Get
    End Property
    Public ReadOnly Property SQLDataSet As DataSet ' static property
        Get
            Return _dataSet
        End Get
    End Property

End Class
