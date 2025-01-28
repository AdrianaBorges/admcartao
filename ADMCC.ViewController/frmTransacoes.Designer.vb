<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransacoes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransacoes))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnExportaArquivo = New System.Windows.Forms.Button()
        Me.btnSelecaoDePasta = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPasta = New System.Windows.Forms.TextBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tsTotalizadores = New System.Windows.Forms.ToolStrip()
        Me.tslQtdRegistros = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslTotVlrTransacoes = New System.Windows.Forms.ToolStripLabel()
        Me.pnlCliente = New System.Windows.Forms.Panel()
        Me.toolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.novaTransacao = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.gravaTransacao = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.alterarTransacao = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.excluirTransacao = New System.Windows.Forms.ToolStripButton()
        Me.txtDataTransacao = New System.Windows.Forms.DateTimePicker()
        Me.cboOperadora = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtVlrTransacao = New System.Windows.Forms.TextBox()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboCartao = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lstTrans = New System.Windows.Forms.ListView()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnLimpaFormulario = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVlrIni = New System.Windows.Forms.TextBox()
        Me.txtVlrFim = New System.Windows.Forms.TextBox()
        Me.btnPesquisaValor = New System.Windows.Forms.Button()
        Me.dtpDtFim = New System.Windows.Forms.DateTimePicker()
        Me.dtpDtIni = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnFiltraPeriodo = New System.Windows.Forms.Button()
        Me.cboBandeira = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboFiltraCartao = New System.Windows.Forms.ComboBox()
        Me.fbdPasta = New System.Windows.Forms.FolderBrowserDialog()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tsTotalizadores.SuspendLayout()
        Me.pnlCliente.SuspendLayout()
        Me.toolStrip4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.btnFechar)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.GroupBox7)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1065, 578)
        Me.GroupBox4.TabIndex = 380
        Me.GroupBox4.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnExportaArquivo)
        Me.GroupBox2.Controls.Add(Me.btnSelecaoDePasta)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtPasta)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(9, 509)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(693, 53)
        Me.GroupBox2.TabIndex = 384
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Exportação:"
        '
        'btnExportaArquivo
        '
        Me.btnExportaArquivo.Location = New System.Drawing.Point(553, 18)
        Me.btnExportaArquivo.Name = "btnExportaArquivo"
        Me.btnExportaArquivo.Size = New System.Drawing.Size(120, 25)
        Me.btnExportaArquivo.TabIndex = 20
        Me.btnExportaArquivo.Text = "Exportar Arquivo"
        Me.btnExportaArquivo.UseVisualStyleBackColor = True
        '
        'btnSelecaoDePasta
        '
        Me.btnSelecaoDePasta.Location = New System.Drawing.Point(392, 18)
        Me.btnSelecaoDePasta.Name = "btnSelecaoDePasta"
        Me.btnSelecaoDePasta.Size = New System.Drawing.Size(155, 25)
        Me.btnSelecaoDePasta.TabIndex = 19
        Me.btnSelecaoDePasta.Text = "Selecionar Pasta"
        Me.btnSelecaoDePasta.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Teal
        Me.Label11.Location = New System.Drawing.Point(9, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Pasta:"
        '
        'txtPasta
        '
        Me.txtPasta.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtPasta.Location = New System.Drawing.Point(54, 21)
        Me.txtPasta.Name = "txtPasta"
        Me.txtPasta.Size = New System.Drawing.Size(330, 21)
        Me.txtPasta.TabIndex = 18
        '
        'btnFechar
        '
        Me.btnFechar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnFechar.ForeColor = System.Drawing.Color.Teal
        Me.btnFechar.Location = New System.Drawing.Point(894, 528)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(115, 26)
        Me.btnFechar.TabIndex = 21
        Me.btnFechar.Text = "Sair"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.pnlCliente)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(9, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1036, 422)
        Me.GroupBox1.TabIndex = 377
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transações:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tsTotalizadores)
        Me.Panel1.Location = New System.Drawing.Point(597, 382)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(315, 31)
        Me.Panel1.TabIndex = 386
        '
        'tsTotalizadores
        '
        Me.tsTotalizadores.AutoSize = False
        Me.tsTotalizadores.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.tsTotalizadores.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.tsTotalizadores.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslQtdRegistros, Me.ToolStripSeparator2, Me.tslTotVlrTransacoes})
        Me.tsTotalizadores.Location = New System.Drawing.Point(0, 0)
        Me.tsTotalizadores.Name = "tsTotalizadores"
        Me.tsTotalizadores.Size = New System.Drawing.Size(315, 25)
        Me.tsTotalizadores.TabIndex = 1
        Me.tsTotalizadores.Text = "ToolStrip1"
        '
        'tslQtdRegistros
        '
        Me.tslQtdRegistros.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tslQtdRegistros.AutoSize = False
        Me.tslQtdRegistros.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tslQtdRegistros.Name = "tslQtdRegistros"
        Me.tslQtdRegistros.Size = New System.Drawing.Size(214, 22)
        Me.tslQtdRegistros.Text = "tslQtdRegistros"
        Me.tslQtdRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tslTotVlrTransacoes
        '
        Me.tslTotVlrTransacoes.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tslTotVlrTransacoes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tslTotVlrTransacoes.Name = "tslTotVlrTransacoes"
        Me.tslTotVlrTransacoes.Size = New System.Drawing.Size(27, 22)
        Me.tslTotVlrTransacoes.Text = "0,0"
        Me.tslTotVlrTransacoes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlCliente
        '
        Me.pnlCliente.Controls.Add(Me.toolStrip4)
        Me.pnlCliente.Controls.Add(Me.txtDataTransacao)
        Me.pnlCliente.Controls.Add(Me.cboOperadora)
        Me.pnlCliente.Controls.Add(Me.Label1)
        Me.pnlCliente.Controls.Add(Me.Label9)
        Me.pnlCliente.Controls.Add(Me.Label8)
        Me.pnlCliente.Controls.Add(Me.Label7)
        Me.pnlCliente.Controls.Add(Me.txtDescricao)
        Me.pnlCliente.Controls.Add(Me.txtVlrTransacao)
        Me.pnlCliente.Controls.Add(Me.cboCliente)
        Me.pnlCliente.Controls.Add(Me.Label2)
        Me.pnlCliente.Controls.Add(Me.Label6)
        Me.pnlCliente.Controls.Add(Me.cboCartao)
        Me.pnlCliente.Location = New System.Drawing.Point(9, 24)
        Me.pnlCliente.Name = "pnlCliente"
        Me.pnlCliente.Size = New System.Drawing.Size(1022, 40)
        Me.pnlCliente.TabIndex = 380
        '
        'toolStrip4
        '
        Me.toolStrip4.Dock = System.Windows.Forms.DockStyle.None
        Me.toolStrip4.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.toolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.novaTransacao, Me.ToolStripSeparator1, Me.gravaTransacao, Me.toolStripSeparator7, Me.alterarTransacao, Me.toolStripSeparator10, Me.excluirTransacao})
        Me.toolStrip4.Location = New System.Drawing.Point(875, 8)
        Me.toolStrip4.Name = "toolStrip4"
        Me.toolStrip4.Size = New System.Drawing.Size(173, 31)
        Me.toolStrip4.TabIndex = 16
        Me.toolStrip4.Text = "toolStrip1"
        '
        'novaTransacao
        '
        Me.novaTransacao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.novaTransacao.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.novaTransacao.Image = Global.ADMCC.ViewController.My.Resources.Resources.add_16
        Me.novaTransacao.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.novaTransacao.Name = "novaTransacao"
        Me.novaTransacao.Size = New System.Drawing.Size(28, 28)
        Me.novaTransacao.Text = "Nova"
        Me.novaTransacao.ToolTipText = "Nova transação"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'gravaTransacao
        '
        Me.gravaTransacao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.gravaTransacao.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gravaTransacao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gravaTransacao.Image = Global.ADMCC.ViewController.My.Resources.Resources.Save
        Me.gravaTransacao.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.gravaTransacao.Name = "gravaTransacao"
        Me.gravaTransacao.Size = New System.Drawing.Size(28, 28)
        Me.gravaTransacao.Text = "Inclui"
        Me.gravaTransacao.ToolTipText = "Salvar transação"
        '
        'toolStripSeparator7
        '
        Me.toolStripSeparator7.Name = "toolStripSeparator7"
        Me.toolStripSeparator7.Size = New System.Drawing.Size(6, 31)
        '
        'alterarTransacao
        '
        Me.alterarTransacao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.alterarTransacao.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.alterarTransacao.ForeColor = System.Drawing.Color.DarkOrchid
        Me.alterarTransacao.Image = Global.ADMCC.ViewController.My.Resources.Resources.korganizer
        Me.alterarTransacao.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.alterarTransacao.Name = "alterarTransacao"
        Me.alterarTransacao.Size = New System.Drawing.Size(28, 28)
        Me.alterarTransacao.Text = "Altera"
        Me.alterarTransacao.ToolTipText = "Alterar transação"
        '
        'toolStripSeparator10
        '
        Me.toolStripSeparator10.Name = "toolStripSeparator10"
        Me.toolStripSeparator10.Size = New System.Drawing.Size(6, 31)
        '
        'excluirTransacao
        '
        Me.excluirTransacao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.excluirTransacao.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.excluirTransacao.ForeColor = System.Drawing.Color.Red
        Me.excluirTransacao.Image = CType(resources.GetObject("excluirTransacao.Image"), System.Drawing.Image)
        Me.excluirTransacao.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.excluirTransacao.Name = "excluirTransacao"
        Me.excluirTransacao.Size = New System.Drawing.Size(28, 28)
        Me.excluirTransacao.Text = "Exclui"
        Me.excluirTransacao.ToolTipText = "Excluir transação"
        '
        'txtDataTransacao
        '
        Me.txtDataTransacao.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataTransacao.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDataTransacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDataTransacao.Location = New System.Drawing.Point(2, 17)
        Me.txtDataTransacao.Name = "txtDataTransacao"
        Me.txtDataTransacao.Size = New System.Drawing.Size(79, 23)
        Me.txtDataTransacao.TabIndex = 10
        '
        'cboOperadora
        '
        Me.cboOperadora.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.cboOperadora.FormattingEnabled = True
        Me.cboOperadora.Location = New System.Drawing.Point(299, 18)
        Me.cboOperadora.Name = "cboOperadora"
        Me.cboOperadora.Size = New System.Drawing.Size(138, 21)
        Me.cboOperadora.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(296, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Operadora"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Teal
        Me.Label9.Location = New System.Drawing.Point(0, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Data"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Teal
        Me.Label8.Location = New System.Drawing.Point(675, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Descrição"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(636, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Valor"
        '
        'txtDescricao
        '
        Me.txtDescricao.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtDescricao.Location = New System.Drawing.Point(675, 18)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(199, 21)
        Me.txtDescricao.TabIndex = 15
        '
        'txtVlrTransacao
        '
        Me.txtVlrTransacao.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtVlrTransacao.Location = New System.Drawing.Point(596, 18)
        Me.txtVlrTransacao.Name = "txtVlrTransacao"
        Me.txtVlrTransacao.Size = New System.Drawing.Size(78, 21)
        Me.txtVlrTransacao.TabIndex = 14
        Me.txtVlrTransacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboCliente
        '
        Me.cboCliente.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(82, 18)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(215, 21)
        Me.cboCliente.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(80, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Cliente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(437, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Cartão de Crédito"
        '
        'cboCartao
        '
        Me.cboCartao.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.cboCartao.FormattingEnabled = True
        Me.cboCartao.Location = New System.Drawing.Point(439, 18)
        Me.cboCartao.Name = "cboCartao"
        Me.cboCartao.Size = New System.Drawing.Size(155, 21)
        Me.cboCartao.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lstTrans)
        Me.Panel3.Location = New System.Drawing.Point(10, 65)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(973, 313)
        Me.Panel3.TabIndex = 379
        '
        'lstTrans
        '
        Me.lstTrans.AllowColumnReorder = True
        Me.lstTrans.AutoArrange = False
        Me.lstTrans.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstTrans.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.lstTrans.ForeColor = System.Drawing.Color.Teal
        Me.lstTrans.FullRowSelect = True
        Me.lstTrans.GridLines = True
        Me.lstTrans.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstTrans.HideSelection = False
        Me.lstTrans.Location = New System.Drawing.Point(0, 0)
        Me.lstTrans.MultiSelect = False
        Me.lstTrans.Name = "lstTrans"
        Me.lstTrans.Size = New System.Drawing.Size(970, 310)
        Me.lstTrans.TabIndex = 17
        Me.lstTrans.UseCompatibleStateImageBehavior = False
        Me.lstTrans.View = System.Windows.Forms.View.Details
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btnLimpaFormulario)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.txtVlrIni)
        Me.GroupBox7.Controls.Add(Me.txtVlrFim)
        Me.GroupBox7.Controls.Add(Me.btnPesquisaValor)
        Me.GroupBox7.Controls.Add(Me.dtpDtFim)
        Me.GroupBox7.Controls.Add(Me.dtpDtIni)
        Me.GroupBox7.Controls.Add(Me.Label10)
        Me.GroupBox7.Controls.Add(Me.btnFiltraPeriodo)
        Me.GroupBox7.Controls.Add(Me.cboBandeira)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Controls.Add(Me.cboFiltraCartao)
        Me.GroupBox7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox7.Location = New System.Drawing.Point(9, 13)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1036, 60)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Opções de Filtro:"
        '
        'btnLimpaFormulario
        '
        Me.btnLimpaFormulario.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnLimpaFormulario.Location = New System.Drawing.Point(950, 14)
        Me.btnLimpaFormulario.Name = "btnLimpaFormulario"
        Me.btnLimpaFormulario.Size = New System.Drawing.Size(78, 38)
        Me.btnLimpaFormulario.TabIndex = 9
        Me.btnLimpaFormulario.Text = "Limpa Formulário"
        Me.btnLimpaFormulario.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(664, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 397
        Me.Label4.Text = "Vlr. Transação:"
        '
        'txtVlrIni
        '
        Me.txtVlrIni.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtVlrIni.Location = New System.Drawing.Point(756, 23)
        Me.txtVlrIni.Name = "txtVlrIni"
        Me.txtVlrIni.Size = New System.Drawing.Size(75, 21)
        Me.txtVlrIni.TabIndex = 6
        Me.txtVlrIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVlrFim
        '
        Me.txtVlrFim.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtVlrFim.Location = New System.Drawing.Point(835, 23)
        Me.txtVlrFim.Name = "txtVlrFim"
        Me.txtVlrFim.Size = New System.Drawing.Size(76, 21)
        Me.txtVlrFim.TabIndex = 7
        Me.txtVlrFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnPesquisaValor
        '
        Me.btnPesquisaValor.Image = Global.ADMCC.ViewController.My.Resources.Resources.lupa
        Me.btnPesquisaValor.Location = New System.Drawing.Point(913, 22)
        Me.btnPesquisaValor.Name = "btnPesquisaValor"
        Me.btnPesquisaValor.Size = New System.Drawing.Size(32, 23)
        Me.btnPesquisaValor.TabIndex = 8
        Me.btnPesquisaValor.UseVisualStyleBackColor = True
        '
        'dtpDtFim
        '
        Me.dtpDtFim.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDtFim.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpDtFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDtFim.Location = New System.Drawing.Point(546, 23)
        Me.dtpDtFim.Name = "dtpDtFim"
        Me.dtpDtFim.Size = New System.Drawing.Size(78, 23)
        Me.dtpDtFim.TabIndex = 4
        '
        'dtpDtIni
        '
        Me.dtpDtIni.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDtIni.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpDtIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDtIni.Location = New System.Drawing.Point(464, 23)
        Me.dtpDtIni.Name = "dtpDtIni"
        Me.dtpDtIni.Size = New System.Drawing.Size(78, 23)
        Me.dtpDtIni.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Teal
        Me.Label10.Location = New System.Drawing.Point(425, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 391
        Me.Label10.Text = "Data:"
        '
        'btnFiltraPeriodo
        '
        Me.btnFiltraPeriodo.Image = Global.ADMCC.ViewController.My.Resources.Resources.lupa
        Me.btnFiltraPeriodo.Location = New System.Drawing.Point(630, 22)
        Me.btnFiltraPeriodo.Name = "btnFiltraPeriodo"
        Me.btnFiltraPeriodo.Size = New System.Drawing.Size(31, 25)
        Me.btnFiltraPeriodo.TabIndex = 5
        Me.btnFiltraPeriodo.UseVisualStyleBackColor = True
        '
        'cboBandeira
        '
        Me.cboBandeira.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.cboBandeira.FormattingEnabled = True
        Me.cboBandeira.Location = New System.Drawing.Point(74, 23)
        Me.cboBandeira.Name = "cboBandeira"
        Me.cboBandeira.Size = New System.Drawing.Size(141, 21)
        Me.cboBandeira.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(3, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 389
        Me.Label5.Text = "Operadora:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(216, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 388
        Me.Label3.Text = "Cartão:"
        '
        'cboFiltraCartao
        '
        Me.cboFiltraCartao.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.cboFiltraCartao.FormattingEnabled = True
        Me.cboFiltraCartao.Location = New System.Drawing.Point(267, 23)
        Me.cboFiltraCartao.Name = "cboFiltraCartao"
        Me.cboFiltraCartao.Size = New System.Drawing.Size(156, 21)
        Me.cboFiltraCartao.TabIndex = 2
        '
        'frmTransacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 604)
        Me.Controls.Add(Me.GroupBox4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTransacoes"
        Me.Text = "Controle de Transações"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.tsTotalizadores.ResumeLayout(False)
        Me.tsTotalizadores.PerformLayout()
        Me.pnlCliente.ResumeLayout(False)
        Me.pnlCliente.PerformLayout()
        Me.toolStrip4.ResumeLayout(False)
        Me.toolStrip4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pnlCliente As Panel
    Friend WithEvents cboOperadora As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents txtVlrTransacao As TextBox
    Friend WithEvents cboCliente As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboCartao As ComboBox
    Friend WithEvents Panel3 As Panel
    Private WithEvents lstTrans As ListView
    Private WithEvents txtDataTransacao As DateTimePicker
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtVlrIni As TextBox
    Friend WithEvents txtVlrFim As TextBox
    Friend WithEvents btnPesquisaValor As Button
    Private WithEvents dtpDtFim As DateTimePicker
    Private WithEvents dtpDtIni As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents btnFiltraPeriodo As Button
    Friend WithEvents cboBandeira As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboFiltraCartao As ComboBox
    Friend WithEvents btnLimpaFormulario As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tsTotalizadores As ToolStrip
    Friend WithEvents tslTotVlrTransacoes As ToolStripLabel
    Friend WithEvents tslQtdRegistros As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Private WithEvents toolStrip4 As ToolStrip
    Private WithEvents gravaTransacao As ToolStripButton
    Private WithEvents toolStripSeparator7 As ToolStripSeparator
    Private WithEvents alterarTransacao As ToolStripButton
    Private WithEvents toolStripSeparator10 As ToolStripSeparator
    Private WithEvents excluirTransacao As ToolStripButton
    Friend WithEvents fbdPasta As FolderBrowserDialog
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPasta As TextBox
    Friend WithEvents btnSelecaoDePasta As Button
    Friend WithEvents btnExportaArquivo As Button
    Friend WithEvents sfd As SaveFileDialog
    Friend WithEvents novaTransacao As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
