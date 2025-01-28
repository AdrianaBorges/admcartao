USE [admcc]
GO

/****** Object:  Table [dbo].[Cartoes]    Script Date: 28/01/2025 00:57:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Cartoes]') AND type in (N'U'))
DROP TABLE [dbo].[Cartoes]
GO

/****** Object:  Table [dbo].[Cartoes]    Script Date: 28/01/2025 00:57:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cartoes](
	[Id_Cartao] [int] IDENTITY(1,1) NOT NULL,
	[Id_Cliente] [int] NOT NULL,
	[Id_Bandeira] [int] NOT NULL,
	[Numero_Cartao] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Cartoes] PRIMARY KEY CLUSTERED 
(
	[Id_Cartao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO



/************************** Carga da tabela Clientes *********************************/

	insert into Cartoes(Id_Cliente, Id_Bandeira, Numero_Cartao) values (4, 3, '3727 182043 55520')
	insert into Cartoes(Id_Cliente, Id_Bandeira, Numero_Cartao) values (4, 1, '4485 3146 9834 7706')
	insert into Cartoes(Id_Cliente, Id_Bandeira, Numero_Cartao) values (1, 2, '5239 0342 5910 7952')
	insert into Cartoes(Id_Cliente, Id_Bandeira, Numero_Cartao) values (3, 1, '4024 0071 7493 8638')
	insert into Cartoes(Id_Cliente, Id_Bandeira, Numero_Cartao) values (2, 7, '6062 8292 0202 9405')
	insert into Cartoes(Id_Cliente, Id_Bandeira, Numero_Cartao) values (2, 3, '3475 071822 69395')
	insert into Cartoes(Id_Cliente, Id_Bandeira, Numero_Cartao) values (5, 5, '3012 572811 5311')
	insert into Cartoes(Id_Cliente, Id_Bandeira, Numero_Cartao) values (6, 1, '4024 0071 2857 5056')
	insert into Cartoes(Id_Cliente, Id_Bandeira, Numero_Cartao) values (3, 8, '5015 0401 2848 7046')
	insert into Cartoes(Id_Cliente, Id_Bandeira, Numero_Cartao) values (7, 2, '5367 9727 5267 0055')
	insert into Cartoes(Id_Cliente, Id_Bandeira, Numero_Cartao) values (3, 7, '6062 8206 0708 1505')
	insert into Cartoes(Id_Cliente, Id_Bandeira, Numero_Cartao) values (7, 5, '3007 666491 3047')


