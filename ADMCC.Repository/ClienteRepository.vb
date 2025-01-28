Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ClienteRepository

    Private objConn As SqlConnection
    Private objCmmd As SqlCommand
    Private rdr As SqlDataReader

    Public Function ObterListaDeClientesCadastrados(idCliente As Integer) As DataTable
        Try

            objConn = New SqlConnection(Parametros.ConnectionString)
            objConn.Open()

            Dim sSql As String = "Select Id_Cliente, Nome_Cliente From Clientes"

            If Not idCliente.Equals(0) Then sSql += $" Where Id_Cliente = {idCliente}"

            sSql += " Order by Nome_Cliente"

            objCmmd = New SqlCommand(sSql, objConn)
            rdr = objCmmd.ExecuteReader(CommandBehavior.CloseConnection)

            Dim dt = New DataTable()
            dt.Load(rdr)

            Return dt

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            objConn.Close()

        End Try
    End Function

    ''' <summary>
    ''' Valida se o Cliente já foi cadastrado.
    ''' </summary>
    ''' <param name="t"></param>
    ''' <returns></returns>
    Public Function ClienteExiste(nome As String) As Boolean
        Try

            objConn = New SqlConnection(Parametros.ConnectionString)
            objConn.Open()

            Dim sSql As String = $"Select id_cliente From Clientes Where nome_cliente = '{nome}'"

            objCmmd = New SqlCommand(sSql, objConn)
            rdr = objCmmd.ExecuteReader(CommandBehavior.CloseConnection)

            Dim dt = New DataTable()
            dt.Load(rdr)

            If Not dt.Rows.Count.Equals(0) Then Return True

            Return False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            objConn.Close()

        End Try

    End Function

    Public Function GravaCliente(nome As String) As Integer
        Try

            objConn = New SqlConnection(Parametros.ConnectionString)
            objConn.Open()

            Dim sSql As String = "Insert Into Clientes (Nome_Cliente) Values ('" & nome & "')"

            objCmmd = New SqlCommand(sSql, objConn)
            objCmmd.ExecuteNonQuery()

            Dim id = GetById(nome)
            If Not id.Equals(0) Then Return id

            Return 0

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            objConn.Close()
        End Try
    End Function

    Private Function GetById(nome As String) As Integer

        Try
            Dim dt As New DataTable
            Dim ds As New DataSet()

            objConn = New SqlConnection(Parametros.ConnectionString)

            objCmmd.CommandText = $"Select id_cliente From Clientes Where nome_cliente = '{nome}'"
            objCmmd.Connection = objConn

            objConn.Open()
            Dim da As New SqlDataAdapter(objCmmd)
            da.Fill(ds)
            dt = ds.Tables(0)

            If dt.Rows.Count > 0 Then Return dt.Rows(0)("id_cliente")

            Return 0

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            objConn.Close()
        End Try

    End Function
End Class
