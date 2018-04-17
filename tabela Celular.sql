USE [Avaliacao]
GO

/****** Object:  Table [dbo].[tbCelular]    Script Date: 04/10/2018 22:27:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tbCelular](
	[idCelular] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [varchar](20) NOT NULL,
	[Modelo] [varchar](10) NOT NULL,
	[Ano] [int] NULL,
	[Memoria] [int] NULL,
 CONSTRAINT [PK_tbCelular] PRIMARY KEY CLUSTERED 
(
	[idCelular] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


