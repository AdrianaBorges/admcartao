USE [admcc]
GO

/****** Object:  Table [dbo].[Clientes]    Script Date: 28/01/2025 00:49:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Clientes]') AND type in (N'U'))
DROP TABLE [dbo].[Clientes]
GO

/****** Object:  Table [dbo].[Clientes]    Script Date: 28/01/2025 00:49:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Clientes](
	[Id_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nome_Cliente] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Id_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


/************************** Carga da tabela Clientes *********************************/

	insert into Clientes(nome_cliente) values ('Agatha Cristina Moura')
	insert into Clientes(nome_cliente) values ('Robson Carvalho de Almeida')
	insert into Clientes(nome_cliente) values ('Joyce Ribeiro Dias')
	insert into Clientes(nome_cliente) values ('Charlotte Guedes')
	insert into Clientes(nome_cliente) values ('Marcos Eduardo Rosa')
	insert into Clientes(nome_cliente) values ('Marcos Alves Rosa')
	insert into Clientes(nome_cliente) values ('Andre Carlos da Fonseca Borges')

