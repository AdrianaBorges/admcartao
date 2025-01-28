Imports ADMCC.Entity
Imports ADMCC.Repository
Imports Microsoft.Office.Interop
Imports Microsoft.ReportingServices.Rendering.ExcelRenderer

Public Class frmTransacoes
    Private _bandRep As New BandeiraRepository()
    Private _repositorioDeTransacoes As New TransacaoRepository()
    Private _cartRep As New CartaoRepository()
    Private _repositorioDeClientes As New ClienteRepository()
    Private _repositorioDeCartoes As New CartaoRepository()

    Private lvwColumnSorter As ListViewColumnSorter
    Private IdTransacao As Integer = 0
    Private XcelApp As New Excel.Application()
    Private xlApp As Excel.Application
    Private XceWorkBook As Excel.Workbook
    Private XceWorkSheet As Excel.Worksheet
    Private bAtualizaCombo As Boolean = False

    Public Sub New()
        Me.InitializeComponent()
        Me.lvwColumnSorter = New ListViewColumnSorter()
        Me.lstTrans.ListViewItemSorter = Me.lvwColumnSorter

        Call Data.Base.WindowsForm.RegisterFocusEvents(MyBase.Controls)

    End Sub

    Private Sub frmTransacoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            MyBase.WindowState = FormWindowState.Normal

            MyBase.Cursor = Cursors.WaitCursor
            Call Funcoes.LimpaCamposFormulario(MyBase.Controls)

            Me.AcionaControlesIniciais()

        Catch ex As Exception
            Call MessageBox.Show(String.Format("Erro: ") & Environment.NewLine & String.Format(ex.Message), String.Format("Atenção..."), MessageBoxButtons.OK, icon:=System.Windows.Forms.MessageBoxIcon.[Error])
        Finally
            MyBase.Cursor = Cursors.[Default]

        End Try

    End Sub
    Private Sub AcionaControlesIniciais()

        Call Funcoes.LimpaCamposFormulario(MyBase.Controls)

        MontaComboDeOperadora(cboBandeira)

        MontaComboDeOperadoraDeSelecao(cboOperadora)

        MontaComboDeCartoesRegistrados(cboCartao, 0, 0)

        MontaComboDeCartoesRegistrados(cboFiltraCartao, 0, 0)

        MontaComboDeClientesRegistrados(cboCliente, 0)

        ListaTransacoesEfetuadas(Me.lstTrans, 0, 0, String.Empty, String.Empty, 0, 0)

        Me.novaTransacao.Enabled = True
        Me.gravaTransacao.Enabled = False
        Me.alterarTransacao.Enabled = False
        Me.excluirTransacao.Enabled = False

    End Sub

    Private Sub HabilitaOperacoes(estado As Boolean)
        'Registro de transações
        Me.pnlCliente.Enabled = estado

    End Sub


#Region "Montagem das combos"

    ''' <summary>
    ''' Monta a combo de Operadoras de Cartões.
    ''' </summary>
    ''' <param name="cmb"></param>
    Private Sub MontaComboDeOperadora(cmb As ComboBox)
        Try
            Call New Data.Base.WindowsForm().LoadFromDataTable(cmb, _bandRep.ObterListaDeOperadoras())
            cmb.Text = String.Empty
            cmb.SelectedValue = 0

        Catch ex As Exception
            Throw New Exception(String.Format("Não foi possível listar a(s) Operadoras de Cartões cadastradas.") & ex.Message)

        End Try

    End Sub

    Private Sub MontaComboDeOperadoraDeSelecao(cmb As ComboBox)
        Try
            Call New Data.Base.WindowsForm().LoadFromDataTable(cmb, _bandRep.ObterListaDeOperadoras())
            cmb.Text = String.Empty
            cmb.SelectedValue = 0

        Catch ex As Exception
            Throw New Exception(String.Format("Não foi possível listar a(s) Operadoras de Cartões cadastradas.") & ex.Message)

        End Try

    End Sub

    ''' <summary>
    ''' Monta a combo de Cartões registrados.
    ''' </summary>
    ''' <param name="cmb"></param>
    ''' <param name="idbandeira"></param>
    Private Sub MontaComboDeCartoesRegistrados(cmb As ComboBox, idbandeira As Integer, idcliente As Integer)
        Try
            Call New Data.Base.WindowsForm().LoadFromDataTable(cmb, _cartRep.ObterListaDeCartoesRegistrados(idbandeira, idcliente))
            cmb.Text = String.Empty
            cmb.SelectedValue = 0

        Catch ex As Exception
            Throw New Exception(String.Format("Não foi possível listar o(s) Cartões registrados.") & ex.Message)

        End Try

    End Sub

    Private Sub MontaComboDeClientesRegistrados(cmb As ComboBox, idCliente As Integer)
        Try
            Call New Data.Base.WindowsForm().LoadFromDataTable(cmb, _repositorioDeClientes.ObterListaDeClientesCadastrados(idCliente))
            cmb.Text = String.Empty
            cmb.SelectedValue = 0

        Catch ex As Exception
            Throw New Exception(String.Format("Não foi possível listar o(s) Clientes registrados.") & ex.Message)

        End Try

    End Sub

#End Region

#Region "Carregamento de ListView"

    ''' <summary>
    ''' Lista as transações efetuadas.
    ''' </summary>
    ''' <param name="lst"></param>
    ''' <param name="idbandeira"></param>
    ''' <param name="idcartao"></param>
    ''' <param name="dtde"></param>
    ''' <param name="dtate"></param>
    ''' <param name="vlrini"></param>
    ''' <param name="vlrfin"></param>
    Private Sub ListaTransacoesEfetuadas(lst As ListView, idbandeira As Integer, idcartao As Integer, dtde As String, dtate As String, vlrini As Decimal, vlrfin As Decimal)
        Try
            lst.Columns.Clear()

            lst.Columns.Add("Idtransacao", 0 * Convert.ToInt32(lst.Font.SizeInPoints), HorizontalAlignment.Left)
            lst.Columns.Add("Data", 10 * Convert.ToInt32(lst.Font.SizeInPoints), HorizontalAlignment.Left)
            lst.Columns.Add("Nome do Cliente", 27 * Convert.ToInt32(lst.Font.SizeInPoints), HorizontalAlignment.Left)
            lst.Columns.Add("Operadora", 17 * Convert.ToInt32(lst.Font.SizeInPoints), HorizontalAlignment.Left)
            lst.Columns.Add("Número do Cartão", 20 * Convert.ToInt32(lst.Font.SizeInPoints), HorizontalAlignment.Left)
            lst.Columns.Add("Valor", 10 * Convert.ToInt32(lst.Font.SizeInPoints), HorizontalAlignment.Right)
            lst.Columns.Add("Descrição", 25 * Convert.ToInt32(lst.Font.SizeInPoints), HorizontalAlignment.Left)
            lst.Columns.Add("Categoria", 12 * Convert.ToInt32(lst.Font.SizeInPoints), HorizontalAlignment.Left)

            lst.Items.Clear()
            lst.Groups.Clear()

            Call New Data.Base.WindowsForm().LoadFromDataTable(lst, _repositorioDeTransacoes.ObtemListaDeTransacoes(idbandeira, idcartao, dtde, dtate, vlrini, vlrfin))
            Me.tslQtdRegistros.Text = lst.Items.Count.ToString()
            Me.tslQtdRegistros.Text = String.Format("{0} registro(s) localizado(s)", lst.Items.Count)
            Me.tslTotVlrTransacoes.Text = $"R$ " + Convert.ToString(CalculaValorAPagar(lst))

        Catch ex As Exception
            Throw New Exception(String.Format("Não foi possível listar a(s) Transação(ões) cadastrada(as).") & ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Calcula o valor total a pagar.  
    ''' Chamada: vlrTotal.Text = Convert.ToString(CalculaValorAPagar(lstSelecionados));
    ''' </summary>
    ''' <param name="lst"></param>
    ''' <returns></returns>
    Private Function CalculaValorAPagar(lst As ListView) As Double
        Try
            MyBase.Cursor = Cursors.WaitCursor

            Dim valor As Double = 0

            For Each list As ListViewItem In lst.Items
                valor += Convert.ToDouble(list.SubItems(5).Text)
            Next

            MyBase.Cursor = Cursors.Default

            Return valor
        Catch ex As Exception
            Throw New Exception("Erro : " & ex.Message)
        End Try

    End Function

#End Region

#Region "Carregamento de Objeto"

    Private Function CarregaObjetoTransacao(idTrans As Integer) As Transacao
        Dim obj As New Transacao
        Dim cliente As New Cliente
        Dim cartao As New Cartao

        If idTrans > 0 Then obj.IdTransacao = idTrans

        Try
            With obj
                .DataTransacao = Convert.ToDateTime(Me.txtDataTransacao.Text)
                .ValorTransacao = Decimal.Parse(Convert.ToDecimal(Me.txtVlrTransacao.Text))
                .Descricao = Me.txtDescricao.Text
            End With

            Dim bandeira As New Bandeira With
            {
                .IdBandeira = Integer.Parse(Me.cboOperadora.SelectedValue)
            }

            obj.Bandeiras = bandeira

            If Not _repositorioDeClientes.ClienteExiste(Me.cboCliente.Text) Then
                With cliente
                    .IdCliente = _repositorioDeClientes.GravaCliente(Me.cboCliente.Text)
                    .NomeCliente = Me.cboCliente.Text
                End With

            Else
                With cliente
                    .IdCliente = Convert.ToInt32(Me.cboCliente.SelectedValue)
                    .NomeCliente = Me.cboCliente.Text
                End With

            End If

            obj.Clientes = cliente

            If Not _repositorioDeCartoes.CartaoExiste(obj, Me.cboCartao.Text) Then
                With cartao
                    .IdCartao = _repositorioDeCartoes.GravaCartao(obj, Me.cboCartao.Text)
                    .NumeroCartao = Me.cboCartao.Text
                End With

            Else
                With cartao
                    .IdCartao = Convert.ToInt32(Me.cboCartao.SelectedValue)
                    .NumeroCartao = Me.cboCartao.Text
                End With

            End If

            obj.Cartoes = cartao

            Return obj

        Catch ex As Exception
            Throw New Exception("Não foi possível carregar o objeto Figurante. " & ex.Message)

        End Try
    End Function

#End Region

#Region "Carregamento de Interface"

    Private Sub ExibeTransacaoSelecionada(lst As ListView)
        Try
            If lst.SelectedItems.Count = 0 Then Return
            If Not lst.SelectedItems(CInt((0))).Selected Then Return

            Me.HabilitaOperacoes(True)

            Me.CarregaInterfaceDeTransacoes(Convert.ToInt32(lst.FocusedItem.SubItems(CInt(0)).Text))

            Me.gravaTransacao.Enabled = False
            Me.alterarTransacao.Enabled = True
            Me.excluirTransacao.Enabled = True

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub CarregaInterfaceDeTransacoes(id As Integer)
        Dim repTrans = New TransacaoRepository()
        Try
            Dim t As New Transacao()
            Dim result = repTrans.ObtemTransacaoPorId(id)

            If result Is Nothing Then Throw New ArgumentNullException(String.Format("Dados não localizados"))

            Me.IdTransacao = result.IdTransacao
            Me.txtDataTransacao.Text = Convert.ToString(result.DataTransacao)
            Me.cboCliente.SelectedValue = Convert.ToInt32(result.Clientes.IdCliente)
            Me.cboCliente.Text = Convert.ToString((result.Clientes.NomeCliente))
            Me.cboCartao.SelectedValue = Convert.ToInt32(result.Cartoes.IdCartao)
            Me.cboCartao.Text = Convert.ToString((result.Cartoes.NumeroCartao))
            Me.txtVlrTransacao.Text = Convert.ToString(result.ValorTransacao)
            Me.txtDescricao.Text = result.Descricao
            Me.cboOperadora.SelectedValue = Convert.ToInt32(result.Bandeiras.IdBandeira)
            Me.cboOperadora.Text = Convert.ToString((result.Bandeiras.Operadora))

        Catch ex As Exception
            Throw New Exception(String.Format("Não foi possível carregar a Interface da Transação.") & ex.Message)
        End Try
    End Sub

    Private Sub btnLimFiltOperadora_Click(sender As Object, e As EventArgs)
        Me.AcionaControlesIniciais()

    End Sub

    Private Sub lstTrans_Click(sender As Object, e As EventArgs) Handles lstTrans.Click
        MyBase.Cursor = Cursors.WaitCursor

        Try
            Me.ExibeTransacaoSelecionada(Me.lstTrans)
        Catch ex As Exception
            Call MessageBox.Show(String.Format(ex.Message), String.Format("Atenção..."), MessageBoxButtons.OK, icon:=MessageBoxIcon.[Error])
        Finally
            MyBase.Cursor = Cursors.[Default]
        End Try

    End Sub

    Private Sub lstTrans_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstTrans.ColumnClick
        If e.Column = Me.lvwColumnSorter.SortColumn Then
            If Me.lvwColumnSorter.Order = SortOrder.Ascending Then
                Me.lvwColumnSorter.Order = SortOrder.Descending
            Else
                Me.lvwColumnSorter.Order = SortOrder.Ascending
            End If
        Else
            Me.lvwColumnSorter.SortColumn = e.Column
            Me.lvwColumnSorter.Order = SortOrder.Ascending
        End If

        Me.lstTrans.Sort()

    End Sub

    Private Sub btnLimpaPeriodo_Click(sender As Object, e As EventArgs)

        Me.AcionaControlesIniciais()

    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()

    End Sub

#End Region

#Region "Operações de CRUD"

    Private Sub CadastroDeTransacao()

        Dim obj = Me.CarregaObjetoTransacao(0)
        Call _repositorioDeTransacoes.GravaTransacao(obj)
        Me.AcionaControlesIniciais()

    End Sub

    Private Sub AlteracaoDeTransacao(IdTrans As Integer)
        Try
            Dim obj = Me.CarregaObjetoTransacao(IdTrans)

            Call _repositorioDeTransacoes.AlteraTransacao(obj)
            Me.AcionaControlesIniciais()

            MessageBox.Show(String.Format("Efetuada com Sucesso."), String.Format("Alteração"), MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub lstTrans_DoubleClick(sender As Object, e As EventArgs) Handles lstTrans.DoubleClick
        MyBase.Cursor = Cursors.WaitCursor

        Try
            Me.ExibeTransacaoSelecionada(Me.lstTrans)
        Catch ex As Exception
            Call MessageBox.Show(String.Format(ex.Message), String.Format("Atenção..."), MessageBoxButtons.OK, icon:=MessageBoxIcon.[Error])
        Finally
            MyBase.Cursor = Cursors.[Default]
        End Try

    End Sub

    Private Function ValidaPreenchimentoDosCampos() As Boolean
        Dim strMensagem = String.Empty

        Try
            If String.IsNullOrEmpty(Convert.ToString(txtDataTransacao.Value)) Then strMensagem &= "Data de Cadastro da Transação " & vbCrLf

            If String.IsNullOrEmpty(Convert.ToString(cboCliente.Text)) Then strMensagem &= "Nome do Cliente " & vbCrLf

            If String.IsNullOrEmpty(Convert.ToString(cboOperadora.Text)) Then strMensagem &= "Operadora do Cartão de Crédito " & vbCrLf

            If String.IsNullOrEmpty(Convert.ToString(cboCartao.Text)) Then strMensagem &= "Número do Cartão de Crédito " & vbCrLf

            If String.IsNullOrEmpty(Convert.ToString(txtVlrTransacao.Text)) Then strMensagem &= "Valor da Transação " & vbCrLf

            If String.IsNullOrEmpty(Convert.ToString(txtDescricao.Text)) Then strMensagem &= "Descrição da Transação "

            If Not Equals(strMensagem, String.Empty) Then
                Throw New Exception(strMensagem)
                Return False
            Else
                Return True

            End If

        Catch ex As Exception
            Throw New Exception(String.Format("O(s) campo(s) abaixo são de preenchimento obrigatório:" & vbCrLf) & ex.Message)

        End Try

    End Function

    Private Sub btnLimpaFormulario_Click(sender As Object, e As EventArgs) Handles btnLimpaFormulario.Click
        Call Funcoes.LimpaCamposFormulario(MyBase.Controls)
        Me.AcionaControlesIniciais()

    End Sub

    Private Sub gravaTransacao_Click(sender As Object, e As EventArgs) Handles gravaTransacao.Click
        Try
            If False = Me.ValidaPreenchimentoDosCampos() Then Return

            Me.CadastroDeTransacao()

            Me.alterarTransacao.Enabled = False
            Me.excluirTransacao.Enabled = False

        Catch ex As Exception
            Call MessageBox.Show(String.Format(ex.Message), String.Format("Atenção..."), MessageBoxButtons.OK, icon:=MessageBoxIcon.[Error])
        End Try

    End Sub

    Private Sub alterarTransacao_Click(sender As Object, e As EventArgs) Handles alterarTransacao.Click
        Try
            If False = Me.ValidaPreenchimentoDosCampos() Then Return

            Me.AlteracaoDeTransacao(Me.IdTransacao)

        Catch ex As Exception
            Call MessageBox.Show(String.Format(ex.Message), String.Format("Atenção..."), MessageBoxButtons.OK, icon:=MessageBoxIcon.[Error])
        End Try

    End Sub

    Private Sub excluirTransacao_Click(sender As Object, e As EventArgs) Handles excluirTransacao.Click

        Try
            If Me.lstTrans.SelectedItems.Count <> 0 Then
                If MessageBox.Show("Confirma a exclusão da Transação abaixo:" & vbCrLf & "Data: " & Me.lstTrans.FocusedItem.SubItems(CInt(1)).Text & vbCrLf & "Cliente: " & Me.lstTrans.FocusedItem.SubItems(CInt(2)).Text & vbCrLf & "Cartão: " & Me.lstTrans.FocusedItem.SubItems(CInt(3)).Text & " - " & Me.lstTrans.FocusedItem.SubItems(CInt(4)).Text & vbCrLf & "Valor: R$ " & Me.lstTrans.FocusedItem.SubItems(CInt(5)).Text & vbCrLf & "Descrição: " & Me.lstTrans.FocusedItem.SubItems(CInt(6)).Text,
                                   "Atenção...",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question,
                                   MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    If Me.lstTrans.SelectedItems(0).Selected Then
                        Me.ExcluisaoDeTransacao(Me.IdTransacao)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format(ex.Message), String.Format("Atenção..."), MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ExcluisaoDeTransacao(IdTrans As Integer)
        Try
            Dim obj = Me.CarregaObjetoTransacao(IdTrans)

            Call _repositorioDeTransacoes.ExcluirTransacaoSelecionada(obj)
            Me.AcionaControlesIniciais()

            MessageBox.Show(String.Format("Efetuada com Sucesso."), String.Format("Exclusão"), MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "Operações ref. a Exportação"

    ''' <summary>
    ''' Gera arquivo em excel.
    ''' </summary>
    Private Sub ExportaTransacoesParaExcel()
        Try
            For Each list As ListViewItem In lstTrans.Items
                XcelApp.Application.Workbooks.Add(Type.Missing)
                For i As Integer = 1 To list.SubItems.Count
                    XcelApp.Cells(1, 1) = list.SubItems(i - 1).Text
                Next

                For i As Integer = 0 To list.SubItems.Count - 2
                    XcelApp.Cells(2, i + 1) = list.SubItems(i).Text

                    For j As Integer = 0 To list.SubItems.Count - 1
                        XcelApp.Cells(i + 2, j + 1) = list.ListView.Items(i).SubItems(j).Text

                    Next
                Next
                Exit For
            Next

            Dim spath As String = Trim(txtPasta.Text)

            XcelApp.ActiveWorkbook.SaveAs(spath)
            XcelApp.Visible = True

        Catch ex As Exception
            MessageBox.Show("Erro : " + ex.Message)
            XcelApp.Quit()

        End Try
    End Sub

    ''' <summary>
    ''' Exibe a caixa de diálogo para seleção de pasta.
    ''' </summary>
    Private Sub SelecionarPastaParaExportacao()
        fbdPasta.Description = "Selecione uma pasta para realizar a exportação"
        fbdPasta.RootFolder = Environment.SpecialFolder.MyComputer
        fbdPasta.ShowNewFolderButton = True

        'Exibe a caixa de diálogo
        If fbdPasta.ShowDialog = Windows.Forms.DialogResult.OK Then

            'Exibe a pasta selecionada
            txtPasta.Text = fbdPasta.SelectedPath & "\Transacoes.xlsx"

        End If

    End Sub

    Private Sub btnExportaArquivo_Click(sender As Object, e As EventArgs) Handles btnExportaArquivo.Click

        If txtPasta.Text = String.Empty Then
            MessageBox.Show("Selecione a pasta para exportação.", "Atenção...", MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            Return
        Else

            Funcoes.VerificaSeArquivoExiste(txtPasta.Text)

            Me.ExportaTransacoesParaExcel()

        End If
    End Sub

    Private Sub btnSelecaoDePasta_Click(sender As Object, e As EventArgs) Handles btnSelecaoDePasta.Click

        If lstTrans.Items.Count = 0 Then
            MessageBox.Show("Não há registros para exportação.", "Atenção...", MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            Return

        Else
            Me.SelecionarPastaParaExportacao()

        End If

    End Sub

#End Region

#Region "Controle de Eventos"

    Private Sub btnFiltraPeriodo_Click(sender As Object, e As EventArgs) Handles btnFiltraPeriodo.Click

        Call Funcoes.LimpaCamposFormulario(MyBase.Controls)

        Me.ListaTransacoesEfetuadas(Me.lstTrans, 0, 0, Me.dtpDtIni.Value, Me.dtpDtFim.Value, 0, 0)

    End Sub

    Private Sub FiltraTransacoesPorCartao()
        Me.ListaTransacoesEfetuadas(Me.lstTrans, 0, cboFiltraCartao.SelectedValue, String.Empty, String.Empty, 0, 0)

    End Sub

    Private Sub cboOperadora_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboOperadora.SelectionChangeCommitted

        Me.MontaComboDeCartoesRegistrados(cboCartao, cboOperadora.SelectedValue, cboCliente.SelectedValue)

    End Sub

    Private Sub novaTransacao_Click(sender As Object, e As EventArgs) Handles novaTransacao.Click

        Me.AcionaControlesIniciais()
        Me.gravaTransacao.Enabled = True
        Me.alterarTransacao.Enabled = False
        Me.excluirTransacao.Enabled = False

        Me.txtDataTransacao.Focus()

    End Sub

    Private Sub btnPesquisaValor_Click(sender As Object, e As EventArgs) Handles btnPesquisaValor.Click

        Me.ListaTransacoesEfetuadas(Me.lstTrans, 0, 0, String.Empty, String.Empty, Me.txtVlrIni.Text, Me.txtVlrFim.Text)

    End Sub

    Private Sub cboBandeira_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboBandeira.SelectionChangeCommitted

        Me.ListaTransacoesEfetuadas(Me.lstTrans, Convert.ToInt32(Me.cboBandeira.SelectedValue), 0, String.Empty, String.Empty, 0, 0)
        Me.MontaComboDeCartoesRegistrados(cboFiltraCartao, Me.cboBandeira.SelectedValue, 0)

    End Sub

    Private Sub cboFiltraCartao_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboFiltraCartao.SelectionChangeCommitted
        Me.FiltraTransacoesPorCartao()

    End Sub

#End Region

End Class


