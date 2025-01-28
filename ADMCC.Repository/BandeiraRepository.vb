Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class BandeiraRepository
    Private con As SqlConnection
    Private cmd As SqlCommand
    Private rdr As SqlDataReader

    ''' <summary>
    ''' Obtem a lista de operadoras de cartão.
    ''' </summary>
    ''' <returns></returns>
    Public Function ObterListaDeOperadoras() As DataTable
        Try

            con = New SqlConnection(Parametros.ConnectionString)
            con.Open()

            Dim sSql = $"Select Id, Operadora From Bandeira"
            cmd = New SqlCommand(sSql, con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            Dim dt = New DataTable()
            dt.Load(rdr)

            Return dt

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            con.Close()

        End Try

    End Function

    ''' <summary>
    ''' Obtem a operadora de cartão por operadora.
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Function ObtemOperadora(id As Integer) As DataTable
        Try

            con = New SqlConnection(Parametros.ConnectionString)
            con.Open()

            Dim sSql = $"Select Id, Operadora From Bandeira Where Id = {id}"
            cmd = New SqlCommand(sSql, con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            Dim dt = New DataTable()
            dt.Load(rdr)

            Return dt

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            con.Close()

        End Try

    End Function

End Class
