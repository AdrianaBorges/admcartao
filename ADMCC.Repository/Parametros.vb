Friend Class Parametros

    Private Const _sqlConnectionString As String =
            "Data Source=ADRIANABORGES\SQLEXPRESS;Initial Catalog=admcc;Integrated Security=True;"

    Protected Shared ReadOnly Property SqlConnectionString As String
        Get
            Return _sqlConnectionString
        End Get
    End Property

    Friend Shared Function ConnectionString() As String
        Return SqlConnectionString

    End Function

End Class


