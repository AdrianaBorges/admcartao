
Public Module Valida

    Public NotInheritable Class Preenchimento

#Region "Transação"
        Public Shared Sub Transacoes(t As Entity.Transacao)
            Dim strMensagem = ""

            Try
                If String.IsNullOrEmpty(Convert.ToString(t.DataTransacao)) Then
                    strMensagem = strMensagem & "Data de Cadastro da Transação, "
                End If
                If String.IsNullOrEmpty(Convert.ToString(t.Clientes.NomeCliente)) Then
                    strMensagem = strMensagem & "Nome do Cliente, "
                End If
                If String.IsNullOrEmpty(Convert.ToString(t.Cartoes.NumeroCartao)) Then
                    strMensagem = strMensagem & "Número do Cartão de Crédito, "
                End If
                If String.IsNullOrEmpty(Convert.ToString(t.ValorTransacao)) Then
                    strMensagem = strMensagem & "Valor da Transação, "
                End If
                If String.IsNullOrEmpty(Convert.ToString(t.Descricao)) Then
                    strMensagem = strMensagem & "Descrição da Transação), "
                End If

                If Not Equals(strMensagem, String.Empty) Then
                    Throw New Exception(strMensagem.Substring(0, strMensagem.Length - 2))
                End If
            Catch ex As Exception
                Throw New Exception(String.Format("O(s) campo(s) abaixo são de preenchimento obrigatório:") & ex.Message)
            End Try
        End Sub

#End Region

    End Class

End Module
