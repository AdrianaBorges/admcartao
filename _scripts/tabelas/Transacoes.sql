USE [admcc]
GO

/****** Object:  Table [dbo].[Transacoes]    Script Date: 28/01/2025 01:11:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Transacoes]') AND type in (N'U'))
DROP TABLE [dbo].[Transacoes]
GO

/****** Object:  Table [dbo].[Transacoes]    Script Date: 28/01/2025 01:11:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Transacoes](
	[Id_Transacao] [int] IDENTITY(1,1) NOT NULL,
	[Id_Cliente] [int] NOT NULL,
	[Id_Cartao] [int] NOT NULL,
	[Valor_Transacao] [numeric](18, 2) NOT NULL,
	[Data_Transacao] [datetime] NOT NULL,
	[Descricao] [nvarchar](1000) NOT NULL,
 CONSTRAINT [PK_Transacoes] PRIMARY KEY CLUSTERED 
(
	[Id_Transacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO



/************************** Carga da tabela Transacoes *********************************/

	insert into Transacoes(Id_Cliente, Id_Cartao, Valor_Transacao, Data_Transacao, Descricao) values (4, 1, '125.00', GETDATE() - 2,'Sepa Contrucao')
	insert into Transacoes(Id_Cliente, Id_Cartao, Valor_Transacao, Data_Transacao, Descricao) values (4, 2, '50.00', GETDATE() - 3, 'Posto de Gasolina Recreio')
	insert into Transacoes(Id_Cliente, Id_Cartao, Valor_Transacao, Data_Transacao, Descricao) values (3, 13, '349.25', GETDATE() - 5, 'Drogaria Barra')
	insert into Transacoes(Id_Cliente, Id_Cartao, Valor_Transacao, Data_Transacao, Descricao) values (3, 4,	'167.23', GETDATE() - 10, 'Drogaria Venancio')
	insert into Transacoes(Id_Cliente, Id_Cartao, Valor_Transacao, Data_Transacao, Descricao) values (2, 6,	'549.57', GETDATE() - 12, 'Outback Recreio Shopping')
	insert into Transacoes(Id_Cliente, Id_Cartao, Valor_Transacao, Data_Transacao, Descricao) values (6, 9, '1349.21', GETDATE() - 11, 'Outback Copacabana')
	insert into Transacoes(Id_Cliente, Id_Cartao, Valor_Transacao, Data_Transacao, Descricao) values (4, 1, '219.00', GETDATE() - 11, 'Posto de Gasolina Recreio')	
	insert into Transacoes(Id_Cliente, Id_Cartao, Valor_Transacao, Data_Transacao, Descricao) values (4, 1,	'126.00', GETDATE() - 12, 'Drogaria Raia')
	insert into Transacoes(Id_Cliente, Id_Cartao, Valor_Transacao, Data_Transacao, Descricao) values (6, 10, '728.00', GETDATE() - 13, 'Mercado Zona Sul')
	insert into Transacoes(Id_Cliente, Id_Cartao, Valor_Transacao, Data_Transacao, Descricao) values (3, 11, '45.00', GETDATE() - 14, 'Drogaria Rio Farma')
	insert into Transacoes(Id_Cliente, Id_Cartao, Valor_Transacao, Data_Transacao, Descricao) values (7, 12, '327.80', GETDATE() - 15, 'Mercado Zona Sul')
	insert into Transacoes(Id_Cliente, Id_Cartao, Valor_Transacao, Data_Transacao, Descricao) values (7, 14, '120.00', GETDATE(), 'Posto de Gasolina Santa Cruz')

