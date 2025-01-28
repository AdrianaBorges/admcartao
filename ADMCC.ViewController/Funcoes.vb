Imports System.Text.RegularExpressions

Public Module Funcoes

    ''' <summary>
    ''' Verifica se o campo está preenchido.
    ''' </summary>
    ''' <param name="campo"></param>
    ''' <returns></returns> 

    ''' <summary>
    ''' Limpa os campos de um formulário.    
    ''' </summary>
    ''' <param name="controles"></param>
    Public Sub LimpaCamposFormulario(controles As Control.ControlCollection)
        For Each ctrl As Control In controles
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            End If

            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).Text = String.Empty
            End If

            If TypeOf ctrl Is MaskedTextBox Then
                CType(ctrl, MaskedTextBox).Clear()
            End If

            If TypeOf ctrl Is RadioButton Then
                CType(ctrl, RadioButton).Checked = False
            End If

            If TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).Checked = False
            End If

            If TypeOf ctrl Is DataGridView Then
                CType(ctrl, DataGridView).Rows.Clear()
            End If

            If TypeOf ctrl Is RichTextBox Then
                CType(ctrl, RichTextBox).Clear()
            End If

            If TypeOf ctrl Is CheckedListBox Then
                CType(ctrl, CheckedListBox).SetItemChecked(2, False)
                For x As Integer = 0 To CType(ctrl, CheckedListBox).CheckedItems.Count - 1
                    CType(ctrl, CheckedListBox).SetItemChecked(x, False)
                Next
            End If

            If TypeOf ctrl Is DateTimePicker Then
                CType(ctrl, DateTimePicker).Value = DateTime.Now
            End If


            'if (ctrl is CheckedListBox)
            '{
            '    ((CheckedListBox)(ctrl)).SetItemChecked(2, false);

            '    for (int x = 0; x <= ((CheckedListBox)(ctrl)).CheckedItems.Count - 1; x++)
            '    {
            '        ((CheckedListBox)(ctrl)).SetItemChecked(x, false);
            '    }
            '}

            LimpaCamposFormulario(ctrl.Controls)
        Next
    End Sub

    Public Function ValidaEmail(Valor As String) As Boolean
        If String.IsNullOrEmpty(Valor) Then
            Return True
        End If
        Dim Valido = False
        Dim regEx As Regex = New Regex("^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$", RegexOptions.IgnoreCase)
        Valido = regEx.IsMatch(Valor)
        Return Valido
    End Function

    Public Function CalculaIdade(dtNascimento As Date) As Integer
        Dim idade = Date.Now.Year - dtNascimento.Year
        If Date.Now.Month < dtNascimento.Month OrElse Date.Now.Month = dtNascimento.Month AndAlso Date.Now.Day < dtNascimento.Day Then idade -= 1

        Return idade
    End Function

    Public Function DataDeBaixaValida(dtbaixa As Date) As Boolean
        If dtbaixa > Date.Now Then
            Return True
        End If
        Return False
    End Function

#Region "Controla as Cores da tela"
    Public Sub RegisterFocusEvents(controls As Control.ControlCollection)
        If controls Is Nothing Then Throw New ArgumentNullException("controls")
        For Each control As Control In controls
            If (TypeOf control Is TextBox) OrElse (TypeOf control Is RichTextBox) OrElse (TypeOf control Is ComboBox) OrElse (TypeOf control Is MaskedTextBox) Then
                AddHandler control.Enter, New EventHandler(AddressOf controlFocus_Enter)
                AddHandler control.Leave, New EventHandler(AddressOf controlFocus_Leave)
            End If

            RegisterFocusEvents(control.Controls)
        Next
    End Sub

    Private Sub controlFocus_Leave(sender As Object, e As EventArgs)
        TryCast(sender, Control).BackColor = Color.White
    End Sub

    Private Sub controlFocus_Enter(sender As Object, e As EventArgs)
        TryCast(sender, Control).BackColor = Color.LightGreen
    End Sub


    ''' <summary>
    ''' Verifica se um arquivo existe e o exclui.
    ''' </summary>
    ''' <param name="arquivo"></param>
    Friend Sub VerificaSeArquivoExiste(arquivo As String)

        Try
            If IO.File.Exists(arquivo) Then IO.File.Delete(arquivo)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

End Module
