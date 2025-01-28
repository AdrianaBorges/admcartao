Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports ADMCC.Entity

Public Class TransacaoRepository
    Private objConn As SqlConnection
    Private objCmmd As SqlCommand
    Private rdr As SqlDataReader

    Public Function ObtemListaDeTransacoes(idbandeira As Integer, idcartao As Integer, dtde As String, dtate As String, vlrini As Decimal, vlrfim As Decimal) As DataTable
        Try
            Dim sValorIni As String = vlrini.ToString.Replace(",", ".")
            Dim sValorFim As String = vlrfim.ToString.Replace(",", ".")

            objConn = New SqlConnection(Parametros.ConnectionString)
            objConn.Open()

            Dim sSql As String = "SELECT idtransacao, Data, Cliente, Operadora, Cartao, Valor, Descricao, Categoria FROM ListaTransacoes_VW Where idtransacao is not null"

            If Not idbandeira.Equals(0) Then sSql += $" And idBandeira = {idbandeira}"

            If Not idcartao.Equals(0) Then sSql += $" And idCartao = {idcartao}"

            If Not String.IsNullOrEmpty(dtde) Then sSql += $" And data between '{Date.Parse(dtde):dd-MM-yyyy}' and '{Date.Parse(dtate):dd-MM-yyyy}'"

            If Not vlrini.Equals(0) Then sSql += $" And valor >= {sValorIni}"

            If Not vlrfim.Equals(0) Then sSql += $" And valor <= {sValorFim}"

            sSql += " order by data desc"

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

    Public Function ObtemTransacaoPorId(id As Integer) As Transacao
        Try

            objConn = New SqlConnection(Parametros.ConnectionString)
            objConn.Open()

            Dim sSql As String = $"Select * from dbo.ObtemTransacao_VW Where id_transacao = {id}"

            objCmmd = New SqlCommand(sSql, objConn)
            rdr = objCmmd.ExecuteReader(CommandBehavior.CloseConnection)

            Dim dt = New DataTable()
            dt.Load(rdr)
            Dim obj As New Transacao

            If Not dt.Rows.Count.Equals(0) Then
                For Each linha As DataRow In dt.Rows
                    With obj
                        .IdTransacao = dt.Rows(0)("id_transacao").ToString()
                        .DataTransacao = dt.Rows(0)("Data_Transacao").ToString()
                        .ValorTransacao = Decimal.Parse(dt.Rows(0)("Valor_Transacao").ToString())
                        .Descricao = dt.Rows(0)("Descricao").ToString()
                        .Categoria = dt.Rows(0)("Categoria").ToString()
                    End With

                    Dim cliente As New Cliente With
                        {
                        .IdCliente = Integer.Parse(dt.Rows(0)("id_cliente").ToString()),
                        .NomeCliente = dt.Rows(0)("Nome_cliente").ToString()
                    }

                    obj.Clientes = cliente

                    Dim cartoes As New Cartao With
                        {
                        .IdCartao = Integer.Parse(dt.Rows(0)("id_cartao").ToString()),
                        .NumeroCartao = dt.Rows(0)("Numero_Cartao").ToString()
                    }

                    obj.Cartoes = cartoes

                    Dim bandeira As New Bandeira With
                        {
                        .IdBandeira = Integer.Parse(dt.Rows(0)("id_bandeira").ToString()),
                        .Operadora = dt.Rows(0)("Operadora").ToString()
                    }

                    obj.Bandeiras = bandeira

                Next
            Else
                Return Nothing

            End If

            Return obj

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            objConn.Close()

        End Try
    End Function

    Public Function ObtemValorTotalTransacoes(dtIni As DateTime, dtFim As DateTime) As Decimal
        Try
            objConn = New SqlConnection(Parametros.ConnectionString)
            objConn.Open()

            objCmmd = New SqlCommand("TransacoesPorPeriodo", objConn) With {
                .CommandType = CommandType.StoredProcedure
            }
            objCmmd.Parameters.AddWithValue("@dtde", DateTime.Parse(dtIni).ToString("dd-MM-yyyy"))
            objCmmd.Parameters.AddWithValue("@dtate", DateTime.Parse(dtFim).ToString("dd-MM-yyyy"))

            rdr = objCmmd.ExecuteReader(CommandBehavior.CloseConnection)

            Dim dt = New DataTable()
            dt.Load(rdr)

            If Not dt.Rows.Count.Equals(0) Then
                Return dt.Rows(0)("valor_total").ToString()

            Else
                Return Nothing

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            objConn.Close()

        End Try

    End Function

    Public Sub GravaTransacao(t As Transacao)
        Try
            If Not TransacaoExiste(t) Then

                objConn = New SqlConnection(Parametros.ConnectionString)
                objConn.Open()

                Dim sSql As String = "Insert Into Transacoes (id_cliente, id_cartao, valor_transacao, data_transacao, descricao) Values (" & t.Clientes.IdCliente & ", " & t.Cartoes.IdCartao & ", '" & t.ValorTransacao.ToString.Replace(",", ".") & "', '" & t.DataTransacao & "', '" & t.Descricao & "'" & ")"

                objCmmd = New SqlCommand(sSql, objConn)
                objCmmd.ExecuteNonQuery()

            Else
                Throw New Exception(String.Format("Transação informada já constã na base de dados."))
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            objConn.Close()
        End Try
    End Sub


    Public Sub AlteraTransacao(t As Transacao)
        Try
            objConn = New SqlConnection(Parametros.ConnectionString)
            objConn.Open()

            Dim sSql As String = "Update Transacoes Set id_cliente = " & t.Clientes.IdCliente & ", id_cartao = " & t.Cartoes.IdCartao & ", valor_transacao = '" & t.ValorTransacao.ToString.Replace(",", ".") & "', data_transacao = '" & t.DataTransacao & "', descricao = '" & t.Descricao & "' Where id_transacao = " & t.IdTransacao

            objCmmd = New SqlCommand(sSql, objConn)
            objCmmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            objConn.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Valida se a transação já foi cadastrada.
    ''' </summary>
    ''' <param name="t"></param>
    ''' <returns></returns>
    Private Function TransacaoExiste(t As Transacao) As Integer

        Try
            Dim dt As New DataTable
            Dim ds As New DataSet()

            objConn = New SqlConnection(Parametros.ConnectionString)
            objConn.Open()

            Dim sSql As String = String.Format($"Select id_transacao From Transacoes Where id_cliente = " & t.Clientes.IdCliente & " and id_cartao = " & t.Cartoes.IdCartao & " and data_transacao = '" & t.DataTransacao & "' and valor_transacao = '" & t.ValorTransacao.ToString.Replace(",", ".") & "'")

            objCmmd.CommandText = sSql
            objCmmd.Connection = objConn

            Dim da As New SqlDataAdapter(objCmmd)
            da.Fill(ds)
            dt = ds.Tables(0)

            If dt.Rows.Count > 0 Then Return dt.Rows(0)("id_cartao")

            Return 0

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            objConn.Close()
        End Try

    End Function

    Public Sub ExcluirTransacaoSelecionada(t As Transacao)
        Try
            objConn = New SqlConnection(Parametros.ConnectionString)
            objConn.Open()

            Dim sSql As String = "Delete From Transacoes Where id_transacao = " & t.IdTransacao

            objCmmd = New SqlCommand(sSql, objConn)
            objCmmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            objConn.Close()
        End Try
    End Sub
End Class
