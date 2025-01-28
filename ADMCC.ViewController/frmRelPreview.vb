Imports Microsoft.Reporting.WinForms

Public Class frmRelPreview

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim Titulo As String
        'Dim Inicial As String
        'Dim Final As String

        'Me.ReportViewer1.RefreshReport()

        'Dim rpTitulo As New ReportParameter("Titulo", Titulo)
        'Dim rpInicial As New ReportParameter("Inicial", Inicial)
        'Dim rpFinal As New ReportParameter("Final", Final)

        ''  ReportViewer1.LocalReport.SetParameters(rpTitulo)

        'Defina o modo de processamento do ReportViewer como Remoto  
        ReportViewer1.ProcessingMode = ProcessingMode.Remote

        Dim serverReport As ServerReport
        serverReport = ReportViewer1.ServerReport

        'Obtenha uma referência às credenciais padrão  
        Dim credentials As System.Net.ICredentials
        credentials = System.Net.CredentialCache.DefaultCredentials

        'Obtenha uma referência às credenciais do servidor de relatório  
        Dim rsCredentials As ReportServerCredentials
        rsCredentials = serverReport.ReportServerCredentials

        'Defina as credenciais para o relatório do servidor 
        rsCredentials.NetworkCredentials = credentials

        'Definir o URL do servidor de relatório e o caminho do relatório
        'serverReport.ReportServerUrl =
        '   New Uri("https://<Server Name>/reportserver")
        'serverReport.ReportPath =
        '   "/AdventureWorks Sample Reports/Sales Order Detail"

        'Criar o parâmetro de relatório do número do pedido de vendas  
        Dim salesOrderNumber As New ReportParameter()
        salesOrderNumber.Name = "SalesOrderNumber"
        salesOrderNumber.Values.Add("SO43661")

        'Defina os parâmetros do relatório  
        '     Dim parameters() As ReportParameter = {salesOrderNumber}
        '    serverReport.SetParameters(parameters)

        'Atualizar o relatório
        ReportViewer1.RefreshReport()




    End Sub



End Class
