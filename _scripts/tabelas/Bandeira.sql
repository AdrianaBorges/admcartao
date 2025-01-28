USE [admcc]
GO

/****** Object:  Table [dbo].[Bandeira]    Script Date: 28/01/2025 00:36:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Bandeira]') AND type in (N'U'))
DROP TABLE [dbo].[Bandeira]
GO

/****** Object:  Table [dbo].[Bandeira]    Script Date: 28/01/2025 00:36:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Bandeira](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Bandeira] [nvarchar](2) NOT NULL,
	[Operadora] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Bandeira] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO




/************ Carga da tabela *******************/

	insert into bandeira (id_bandeira, operadora) values ('01','Visa')
	insert into bandeira (id_bandeira, operadora) values ('02','Mastercard')
	insert into bandeira (id_bandeira, operadora) values ('03','American Express')
	insert into bandeira (id_bandeira, operadora) values ('04','Sorocred')
	insert into bandeira (id_bandeira, operadora) values ('05','Diners Club')
	insert into bandeira (id_bandeira, operadora) values ('06','Elo')
	insert into bandeira (id_bandeira, operadora) values ('07','Hipercard')
	insert into bandeira (id_bandeira, operadora) values ('08','Aura')
	insert into bandeira (id_bandeira, operadora) values ('09','Cabal')
	insert into bandeira (id_bandeira, operadora) values ('10','Alelo')
	insert into bandeira (id_bandeira, operadora) values ('11','Banes Card')
	insert into bandeira (id_bandeira, operadora) values ('12','CalCard')
	insert into bandeira (id_bandeira, operadora) values ('13','Credz')
	insert into bandeira (id_bandeira, operadora) values ('14','Discover')
	insert into bandeira (id_bandeira, operadora) values ('15','GoodCard')
	insert into bandeira (id_bandeira, operadora) values ('16','GreenCard')
	insert into bandeira (id_bandeira, operadora) values ('17','Hiper')
	insert into bandeira (id_bandeira, operadora) values ('18','JcB')
	insert into bandeira (id_bandeira, operadora) values ('19','Mais')
	insert into bandeira (id_bandeira, operadora) values ('20','MaxVan')
	insert into bandeira (id_bandeira, operadora) values ('21','Policard')
	insert into bandeira (id_bandeira, operadora) values ('22','RedeCompras')
	insert into bandeira (id_bandeira, operadora) values ('23','Sodexo')
	insert into bandeira (id_bandeira, operadora) values ('24','ValeCard')
	insert into bandeira (id_bandeira, operadora) values ('25','Verocheque')
	insert into bandeira (id_bandeira, operadora) values ('26','VR')
	insert into bandeira (id_bandeira, operadora) values ('27','Ticket')
	insert into bandeira (id_bandeira, operadora) values ('99','Outros')




