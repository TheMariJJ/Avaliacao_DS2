USE [Avaliacao]
GO

/****** Object:  Table [dbo].[tbCliente]    Script Date: 04/10/2018 22:28:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tbCliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[NomeCliente] [varchar](200) NOT NULL,
	[CPF] [varchar](12) NOT NULL,
	[Telefone] [varchar](11) NOT NULL,
	[Endereco] [varchar](100) NOT NULL,
	[Bairro] [varchar](50) NOT NULL,
	[DtNasc] [date] NOT NULL,
	[idCelular] [int] NOT NULL,
 CONSTRAINT [PK_tbCliente] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tbCliente]  WITH CHECK ADD  CONSTRAINT [fk_celular] FOREIGN KEY([idCelular])
REFERENCES [dbo].[tbCelular] ([idCelular])
GO

ALTER TABLE [dbo].[tbCliente] CHECK CONSTRAINT [fk_celular]
GO

ALTER TABLE [dbo].[tbCliente]  WITH CHECK ADD  CONSTRAINT [FK_idCelular] FOREIGN KEY([idCliente])
REFERENCES [dbo].[tbCliente] ([idCliente])
GO

ALTER TABLE [dbo].[tbCliente] CHECK CONSTRAINT [FK_idCelular]
GO


