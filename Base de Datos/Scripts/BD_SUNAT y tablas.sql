USE [SUNAT]
GO
/****** Object:  Table [dbo].[contribuyentes]    Script Date: 03/19/2012 21:04:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[contribuyentes](
	[Ruc] [varchar](11) NOT NULL,
	[RazonSocial] [varchar](100) NULL,
	[FInscripcion] [varchar](10) NULL,
	[Estado] [varchar](20) NULL,
	[Condicion] [varchar](20) NULL,
	[Direccion] [varchar](100) NULL,
	[Telefono] [varchar](9) NULL,
	[Sistema] [varchar](20) NULL,
 CONSTRAINT [PK_Contribuyentes] PRIMARY KEY CLUSTERED 
(
	[Ruc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO