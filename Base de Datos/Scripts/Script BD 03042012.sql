USE [Ventas]
GO
/****** Object:  User [BUILTIN\Users]    Script Date: 04/03/2012 21:43:41 ******/
CREATE USER [BUILTIN\Users] FOR LOGIN [BUILTIN\Users]
GO
/****** Object:  Table [dbo].[VentaPauta]    Script Date: 04/03/2012 21:43:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VentaPauta](
	[ventaCodigo] [int] NOT NULL,
	[radioCodigo] [int] NULL,
	[ventaNombreVendedor] [varchar](50) NULL,
	[ventaDescripcionProducto] [varchar](200) NULL,
	[empresaRuc] [varchar](20) NULL,
	[tipoPautaCodigo] [int] NULL,
	[ventaNumeroDias] [varchar](20) NULL,
	[ventaPrioridad] [int] NULL,
	[ventaTipoTransaccion] [int] NULL,
	[ventaIGV] [int] NULL,
	[ventaTipoOrden] [int] NULL,
	[ventaImporteTotal] [decimal](18, 0) NULL,
	[ventaMontoTotal] [decimal](18, 0) NULL,
	[ventaTipoPago] [int] NULL,
	[ventaFechaCreacion] [date] NULL,
	[ventaUsuarioCreacion] [varchar](50) NULL,
	[ventaFechaModif] [date] NULL,
	[ventaUsuarioModif] [varchar](50) NULL,
	[ventaEstado] [char](1) NULL,
 CONSTRAINT [PK_VentaPauta] PRIMARY KEY CLUSTERED 
(
	[ventaCodigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 04/03/2012 21:43:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[usuarioCodigo] [int] NULL,
	[usuarioUser] [varchar](20) NULL,
	[usuarioPassword] [varchar](20) NULL,
	[usuarioEstado] [char](1) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoTransaccion]    Script Date: 04/03/2012 21:43:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoTransaccion](
	[tipoTransaccionCodigo] [int] NULL,
	[tipoTransaccionDesc] [varchar](50) NULL,
	[tipoTransaccionEstado] [char](1) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoTarifa]    Script Date: 04/03/2012 21:43:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoTarifa](
	[tipoTarifaCodigo] [int] NOT NULL,
	[tipoTarifaNombre] [varchar](100) NULL,
	[tipoTarifaEstado] [char](1) NULL,
 CONSTRAINT [PK_TipoTarifa] PRIMARY KEY CLUSTERED 
(
	[tipoTarifaCodigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoPauta]    Script Date: 04/03/2012 21:43:41 ******/
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
/****** Object:  Table [dbo].[TipoPago]    Script Date: 04/03/2012 21:43:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoPago](
	[tipoPagoCodigo] [int] NULL,
	[tipoPagoDesc] [varchar](20) NULL,
	[tipoPagoEstado] [char](1) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoOrden]    Script Date: 04/03/2012 21:43:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoOrden](
	[tipoOrdenCodigo] [int] NULL,
	[tipoOrdenDesc] [varchar](50) NULL,
	[tipoOrdenEstado] [char](1) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tarifa]    Script Date: 04/03/2012 21:43:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[Tarifa](
	[tarifaCodigo] [int] NOT NULL,
	[tarifaCodigoRadio] [int] NULL,
	[tarifaCodigoTipoPauta] [int] NULL,
	[tarifaPrecio] [numeric](10, 2) NULL,
	[tarifaBloque] [varchar](200) NULL,
	[tarifaEstado] [char](1) NULL,
 CONSTRAINT [PK_Tarifa] PRIMARY KEY CLUSTERED 
(
	[tarifaCodigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Radio]    Script Date: 04/03/2012 21:43:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Radio](
	[radioCodigo] [int] NOT NULL,
	[radioNombreComercial] [varchar](120) NULL,
	[radioEstado] [char](1) NULL,
 CONSTRAINT [PK_Radio] PRIMARY KEY CLUSTERED 
(
	[radioCodigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Prioridad]    Script Date: 04/03/2012 21:43:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Prioridad](
	[prioridadCodigo] [int] NULL,
	[prioridadDescripcion] [varchar](50) NULL,
	[prioridadEstado] [char](1) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 04/03/2012 21:43:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empresa](
	[empresaCodigo] [int] NULL,
	[empresaRUC] [varchar](20) NULL,
	[empresaNombreComercial] [varchar](50) NULL,
	[empresaDireccion] [varchar](50) NULL,
	[empresaTelefono] [varchar](50) NULL,
	[empresaEstado] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[contribuyentes]    Script Date: 04/03/2012 21:43:41 ******/
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
