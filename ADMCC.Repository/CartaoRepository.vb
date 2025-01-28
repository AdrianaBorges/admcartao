Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports ADMCC.Entity

Public Class CartaoRepository

    Private objConn As SqlConnection
    Private objCmmd As SqlCommand
    Private rdr As SqlDataReader

    Public Function ObterListaDeCartoesRegistrados(idbandeira As Integer, idcliente As Integer) As DataTable
        Try

            objConn = New SqlConnection(Parametros.ConnectionString)
            objConn.Open()

            Dim sSql = $"Select Id_Cartao, Numero_Cartao From Cartoes"

            If idbandeira <> 0 And idcliente <> 0 Then
                sSql += $" Where Id_Bandeira = {idbandeira} and id_cliente = {idcliente}"
            Else
                If idbandeira <> 0 Then sSql += $" Where Id_Bandeira = {idbandeira}"
                If idcliente <> 0 Then sSql += $" Where id_cliente = {idcliente}"

            End If

            sSql += " order by Numero_Cartao desc"

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
    ''' Valida se o Cartao já foi cadastrado.
    ''' </summary>
    ''' <param name="t"></param>
    ''' <returns></returns>
    Public Function CartaoExiste(t As Transacao, cartao As String) As Boolean
        Try

            objConn = New SqlConnection(Parametros.ConnectionString)
            objConn.Open()

            Dim sSql As String = String.Format($"Select id_cartao From Cartoes Where numero_cartao = '" & cartao & "' and id_cliente = " & t.Clientes.IdCliente & " and id_bandeira = " & t.Bandeiras.IdBandeira)

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

    Public Function GravaCartao(t As Transacao, cartao As String) As Integer
        Try
            objConn = New SqlConnection(Parametros.ConnectionString)

            objConn.Open()

            Dim sSql As String = "Insert Into Cartoes (Id_Cliente, Id_Bandeira, Numero_Cartao) Values (" & t.Clientes.IdCliente & ", " & t.Bandeiras.IdBandeira & ", '" & cartao & "')"

            objCmmd = New SqlCommand(sSql, objConn)

            objCmmd.ExecuteNonQuery()

            Return GetById(t, cartao)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            objConn.Close()
        End Try
    End Function

    Private Function GetById(t As Transacao, cartao As String) As Integer

        Try
            Dim dt As New DataTable
            Dim ds As New DataSet()

            objConn = New SqlConnection(Parametros.ConnectionString)
            Dim sSql As String = String.Format($"Select id_cartao From Cartoes Where numero_cartao = '" & cartao & "' and id_cliente = " & t.Clientes.IdCliente & " and id_bandeira = " & t.Bandeiras.IdBandeira)

            objCmmd.CommandText = sSql
            objCmmd.Connection = objConn

            objConn.Open()
            Dim da As New SqlDataAdapter(objCmmd)
            da.Fill(ds)
            dt = ds.Tables(0)

            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)("id_cartao")
            End If

            Return 0

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            objConn.Close()
        End Try

    End Function

End Class
