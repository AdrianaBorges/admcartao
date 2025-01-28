USE [admcc]
GO

/****** Object:  StoredProcedure [dbo].[TransacoesPorPeriodo]    Script Date: 28/01/2025 00:27:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE OR ALTER   PROCEDURE [dbo].[TransacoesPorPeriodo](@dtde datetime, @dtate datetime)

AS
		
BEGIN
	Begin Try
		
		Select 
			c.Numero_Cartao
			,sum(t.valor_transacao) as Valor_Total
			,Count(t.id_cartao) as Quantidade_Transacoes
		From Transacoes t
		Inner Join Cartoes c on t.id_cartao = c.id_cartao
		Where t.Data_Transacao between @dtde and @dtate
		Group by c.Numero_Cartao

	End Try

	Begin Catch
		Select ERROR_MESSAGE() as ErrorMessage
	End Catch

END




GO


