Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

''' <summary>
''' Classe responsável por carregar e selecionar elementos de interface com base em dados do banco de dados.
''' </summary>
Public Class WindowsForm
    Friend Structure Dado
        Public Property Id As String
        Public Property Nome As String
    End Structure

    ''' <summary>
    ''' Carrega o ListBox com base no conteúdo do DataTable passado por parâmetro.
    ''' </summary>
    ''' <paramname="listBox">ListBox</param>
    ''' <paramname="dataTable">DataTable</param>
    Public Sub LoadFromDataTable(listBox As ListBox, dataTable As DataTable)
        Try
            Dim colecao = New List(Of Dado)()

            For Each row As DataRow In dataTable.Rows
                Dim dado = New Dado With {
                        .Id = row.ItemArray(0).ToString(),
                        .Nome = row.ItemArray(1).ToString()
                    }
                colecao.Add(dado)
            Next

            listBox.ValueMember = "ID"
            listBox.DisplayMember = "Nome"
            listBox.DataSource = colecao
        Catch ex As Exception
            Throw New Exception("Erro :" & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Carrega o ComboBox com base no conteúdo do DataTable passado por parâmetro.
    ''' </summary>
    ''' <paramname="comboBox">ComboBox</param>
    ''' <paramname="dataTable">DataTable</param>
    Public Sub LoadFromDataTable(comboBox As ComboBox, dataTable As DataTable)
        Try
            Dim colecao = New List(Of Dado)()

            For Each row As DataRow In dataTable.Rows
                Dim dado = New Dado With {
                        .Id = row.ItemArray(0).ToString(),
                        .Nome = row.ItemArray(1).ToString()
                    }
                colecao.Add(dado)
            Next

            comboBox.ValueMember = "ID"
            comboBox.DisplayMember = "Nome"
            comboBox.DataSource = colecao
        Catch ex As Exception
            Throw New Exception("Erro :" & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Carrega o ComboBox com base no conteúdo do DataTable passado por parâmetro.
    ''' </summary>
    ''' <paramname="ToolStripComboBox">ToolStripComboBox</param>
    ''' <paramname="dataTable">DataTable</param>
    Public Sub LoadFromDataTable(comboBox As ToolStripComboBox, dataTable As DataTable)
        Try
            Dim colecao = New List(Of Dado)()

            For Each row As DataRow In dataTable.Rows
                Dim dado = New Dado With {
                        .Id = row.ItemArray(0).ToString(),
                        .Nome = row.ItemArray(1).ToString()
                    }
                colecao.Add(dado)
            Next

            comboBox.ComboBox.ValueMember = "ID"
            comboBox.ComboBox.DisplayMember = "Nome"

            'comboBox.ComboBox.Items.Add(colecao);
            comboBox.ComboBox.DataSource = colecao
        Catch ex As Exception
            Throw New Exception("Erro :" & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Carrega o ListView com base no conteúdo do DataTable passado por parâmetro.
    ''' </summary>
    ''' <paramname="listView">ListView</param>
    ''' <paramname="dataTable">DataTable</param>
    Public Sub LoadFromDataTable(listView As ListView, dataTable As DataTable)
        Try
            For Each row As DataRow In dataTable.Rows
                Dim coluna = 0
                Dim dados = New String(row.ItemArray.Length - 1) {}

                For Each item In row.ItemArray
                    dados(Math.Min(Threading.Interlocked.Increment(coluna), coluna - 1)) = item.ToString()
                Next

                listView.Items.Add(New ListViewItem(dados))
            Next
        Catch ex As Exception
            Throw New Exception("Erro :" & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Seleciona um item do ListBox com base no Id passado por parâmetro.
    ''' </summary>
    ''' <paramname="listBox">ListBox</param>
    ''' <paramname="id">Id do item que será selecionado.</param>
    Public Sub SelectById(listBox As ListBox, id As String)
        For Each item As Dado In listBox.Items
            If Not Equals(item.Id, id) Then Continue For
            listBox.SelectedItem = item
            Return
        Next
        Throw New Exception("Item não encontrado.")
    End Sub

    ''' <summary>
    ''' Seleciona um item do ComboBox com base no Id passado por parâmetro.
    ''' </summary>
    ''' <paramname="comboBox">ComboBox</param>
    ''' <paramname="id">Id do item que será selecionado.</param>
    Public Sub SelectById(comboBox As ComboBox, id As String)
        For Each item As Dado In comboBox.Items
            If Not Equals(item.Id, id) Then Continue For
            comboBox.SelectedItem = item
            Return
        Next
        Throw New Exception("Item não encontrado.")
    End Sub

    Public Shared Sub RegisterFocusEvents(controls As Control.ControlCollection)
        If controls Is Nothing Then Throw New ArgumentNullException("controls")

        For Each control As Control In controls
            If (TypeOf control Is TextBox) OrElse (TypeOf control Is RichTextBox) OrElse (TypeOf control Is ComboBox) OrElse (TypeOf control Is MaskedTextBox) Then
                AddHandler control.Enter, New EventHandler(AddressOf controlFocus_Enter)
                AddHandler control.Leave, New EventHandler(AddressOf controlFocus_Leave)
            End If
            RegisterFocusEvents(control.Controls)
        Next
    End Sub

    Public Shared Sub controlFocus_Leave(sender As Object, e As EventArgs)
        TryCast(sender, Control).BackColor = Color.White
    End Sub

    Public Shared Sub controlFocus_Enter(sender As Object, e As EventArgs)
        TryCast(sender, Control).BackColor = Color.LightGreen
    End Sub
End Class
