USE [master]
GO
/****** Object:  Database [Ventas]    Script Date: 03/20/2012 01:44:09 ******/
CREATE DATABASE [Ventas] ON  PRIMARY 
( NAME = N'Ventas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Ventas.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Ventas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Ventas_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Ventas] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ventas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Ventas] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Ventas] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Ventas] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Ventas] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Ventas] SET ARITHABORT OFF
GO
ALTER DATABASE [Ventas] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Ventas] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Ventas] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Ventas] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Ventas] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Ventas] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Ventas] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Ventas] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Ventas] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Ventas] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Ventas] SET  DISABLE_BROKER
GO
ALTER DATABASE [Ventas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Ventas] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Ventas] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Ventas] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Ventas] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Ventas] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Ventas] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Ventas] SET  READ_WRITE
GO
ALTER DATABASE [Ventas] SET RECOVERY FULL
GO
ALTER DATABASE [Ventas] SET  MULTI_USER
GO
ALTER DATABASE [Ventas] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Ventas] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'Ventas', N'ON'
GO
USE [Ventas]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 03/20/2012 01:44:09 ******/
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
INSERT [dbo].[Usuario] ([usuarioCodigo], [usuarioUser], [usuarioPassword], [usuarioEstado]) VALUES (1, N'Admin', N'123', N'A')
/****** Object:  Table [dbo].[TipoTarifa]    Script Date: 03/20/2012 01:44:09 ******/
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
/****** Object:  Table [dbo].[TipoPauta]    Script Date: 03/20/2012 01:44:09 ******/
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
INSERT [dbo].[TipoPauta] ([tipoPautaCodigo], [tipoPautaNombre], [tipoPautaEstado]) VALUES (1, N'Menciones', N'A')
INSERT [dbo].[TipoPauta] ([tipoPautaCodigo], [tipoPautaNombre], [tipoPautaEstado]) VALUES (2, N'Disco Servicios', N'A')
INSERT [dbo].[TipoPauta] ([tipoPautaCodigo], [tipoPautaNombre], [tipoPautaEstado]) VALUES (3, N'Auspicios', N'A')
/****** Object:  Table [dbo].[Tarifa]    Script Date: 03/20/2012 01:44:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
INSERT [dbo].[Tarifa] ([tarifaCodigo], [tarifaCodigoRadio], [tarifaCodigoTipoPauta], [tarifaPrecio], [tarifaBloque], [tarifaEstado]) VALUES (1, 2, 1, CAST(500.00 AS Numeric(10, 2)), N'Nuevo', N'A')
INSERT [dbo].[Tarifa] ([tarifaCodigo], [tarifaCodigoRadio], [tarifaCodigoTipoPauta], [tarifaPrecio], [tarifaBloque], [tarifaEstado]) VALUES (3, 5, 1, CAST(100.00 AS Numeric(10, 2)), N'Al son de la noche', N'A')
INSERT [dbo].[Tarifa] ([tarifaCodigo], [tarifaCodigoRadio], [tarifaCodigoTipoPauta], [tarifaPrecio], [tarifaBloque], [tarifaEstado]) VALUES (4, 2, 1, CAST(75.00 AS Numeric(10, 2)), N'Salsaludos', N'A')
INSERT [dbo].[Tarifa] ([tarifaCodigo], [tarifaCodigoRadio], [tarifaCodigoTipoPauta], [tarifaPrecio], [tarifaBloque], [tarifaEstado]) VALUES (5, 5, 3, CAST(120.00 AS Numeric(10, 2)), N'Mañana Maldita', N'A')
/****** Object:  Table [dbo].[Radio]    Script Date: 03/20/2012 01:44:09 ******/
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
INSERT [dbo].[Radio] ([radioCodigo], [radioNombreComercial], [radioEstado]) VALUES (1, N'Inca', N'A')
INSERT [dbo].[Radio] ([radioCodigo], [radioNombreComercial], [radioEstado]) VALUES (2, N'Radiomar', N'A')
INSERT [dbo].[Radio] ([radioCodigo], [radioNombreComercial], [radioEstado]) VALUES (3, N'La Inolvidable', N'A')
INSERT [dbo].[Radio] ([radioCodigo], [radioNombreComercial], [radioEstado]) VALUES (4, N'Ritmo Romantica', N'A')
INSERT [dbo].[Radio] ([radioCodigo], [radioNombreComercial], [radioEstado]) VALUES (5, N'Planeta', N'A')
INSERT [dbo].[Radio] ([radioCodigo], [radioNombreComercial], [radioEstado]) VALUES (6, N'Radiomar', N'A')
INSERT [dbo].[Radio] ([radioCodigo], [radioNombreComercial], [radioEstado]) VALUES (7, N'Nueva Q', N'A')
/****** Object:  Table [dbo].[Empresa]    Script Date: 03/20/2012 01:44:09 ******/
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
INSERT [dbo].[Empresa] ([empresaCodigo], [empresaRUC], [empresaNombreComercial], [empresaDireccion], [empresaTelefono], [empresaEstado]) VALUES (1, N'12345678901', N'prueba', N'prueba', N'1234567', N'A')
INSERT [dbo].[Empresa] ([empresaCodigo], [empresaRUC], [empresaNombreComercial], [empresaDireccion], [empresaTelefono], [empresaEstado]) VALUES (2, N'12345678901', N'Empresa 2', N'Test Empresa', N'6666333', N'A')
