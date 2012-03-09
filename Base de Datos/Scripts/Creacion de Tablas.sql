USE [Ventas]
GO

/****** Object:  Table [dbo].[TipoPauta]    Script Date: 03/09/2012 07:53:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[TipoPauta](
	[tipoPautaCodigo] [int] NULL,
	[tipoPautaNombre] [varchar](25) NULL,
	[tipoPautaEstado] [char](1) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


