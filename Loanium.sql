USE [master]
GO
/****** Object:  Database [Loanium]    Script Date: 30/04/2019 22:44:25 ******/
CREATE DATABASE [Loanium]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Loanium', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Loanium.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Loanium_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Loanium_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Loanium] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Loanium].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Loanium] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Loanium] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Loanium] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Loanium] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Loanium] SET ARITHABORT OFF 
GO
ALTER DATABASE [Loanium] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Loanium] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Loanium] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Loanium] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Loanium] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Loanium] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Loanium] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Loanium] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Loanium] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Loanium] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Loanium] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Loanium] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Loanium] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Loanium] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Loanium] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Loanium] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Loanium] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Loanium] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Loanium] SET  MULTI_USER 
GO
ALTER DATABASE [Loanium] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Loanium] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Loanium] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Loanium] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Loanium] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Loanium] SET QUERY_STORE = OFF
GO
USE [Loanium]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Loanium]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 30/04/2019 22:44:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[UsuarioId] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [nchar](45) NOT NULL,
	[Apellidos] [nchar](45) NOT NULL,
	[Documento] [nchar](15) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[CorreoElectronico] [nchar](45) NOT NULL,
	[Clave] [nchar](45) NOT NULL,
	[Telefono] [nchar](10) NULL,
	[TipoUsuarioId] [int] NOT NULL,
	[TipoDocumentoId] [int] NOT NULL,
	[EstadoUsuarioId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoUsuario]    Script Date: 30/04/2019 22:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoUsuario](
	[TipoUsuarioId] [int] IDENTITY(1,1) NOT NULL,
	[TipoUsuario] [nchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TipoUsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoUsuario]    Script Date: 30/04/2019 22:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoUsuario](
	[EstadoUsuarioId] [int] IDENTITY(1,1) NOT NULL,
	[EstadoUsuario] [nchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EstadoUsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDocumento]    Script Date: 30/04/2019 22:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDocumento](
	[TipoDocumentoId] [int] IDENTITY(1,1) NOT NULL,
	[TipoDocumento] [nchar](45) NOT NULL,
	[SiglaTipoDocumento] [nchar](2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TipoDocumentoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[UsuarioCompleto]    Script Date: 30/04/2019 22:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[UsuarioCompleto]
AS
SELECT        dbo.Usuario.Nombres, dbo.Usuario.Apellidos, dbo.TipoDocumento.TipoDocumento AS [Tipo de documento], dbo.Usuario.Documento, dbo.Usuario.FechaNacimiento AS [Fecha de nacimiento], 
                         dbo.Usuario.CorreoElectronico AS [Correo electrónico], dbo.Usuario.Clave, dbo.Usuario.Telefono, dbo.TipoUsuario.TipoUsuario AS [Tipo de usuario], dbo.EstadoUsuario.EstadoUsuario AS Estado
FROM            dbo.EstadoUsuario INNER JOIN
                         dbo.Usuario ON dbo.EstadoUsuario.EstadoUsuarioId = dbo.Usuario.EstadoUsuarioId INNER JOIN
                         dbo.TipoDocumento ON dbo.Usuario.TipoDocumentoId = dbo.TipoDocumento.TipoDocumentoId INNER JOIN
                         dbo.TipoUsuario ON dbo.Usuario.TipoUsuarioId = dbo.TipoUsuario.TipoUsuarioId
GO
/****** Object:  Table [dbo].[Material]    Script Date: 30/04/2019 22:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Material](
	[MaterialId] [int] IDENTITY(1,1) NOT NULL,
	[TituloMaterial] [nchar](45) NOT NULL,
	[AutorMaterial] [nchar](45) NOT NULL,
	[FechaPublicacion] [date] NOT NULL,
	[DescripcionMaterial] [text] NOT NULL,
	[Isbn] [nchar](20) NULL,
	[Editorial] [nchar](45) NULL,
	[Issn] [nchar](20) NULL,
	[Duracion] [nchar](5) NULL,
	[IdiomaId] [int] NOT NULL,
	[TematicaId] [int] NOT NULL,
	[TipoMaterialId] [int] NOT NULL,
	[EstadoMaterialId] [int] NOT NULL,
 CONSTRAINT [PK__Material__C50610F740DB1039] PRIMARY KEY CLUSTERED 
(
	[MaterialId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoMaterial]    Script Date: 30/04/2019 22:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoMaterial](
	[EstadoMaterialId] [int] IDENTITY(1,1) NOT NULL,
	[EstadoMaterial] [nchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EstadoMaterialId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Idioma]    Script Date: 30/04/2019 22:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idioma](
	[IdiomaId] [int] IDENTITY(1,1) NOT NULL,
	[NombreIdioma] [nchar](45) NOT NULL,
	[SiglaIdioma] [nchar](2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdiomaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tematica]    Script Date: 30/04/2019 22:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tematica](
	[TematicaId] [int] IDENTITY(1,1) NOT NULL,
	[NumeroDewey] [nchar](3) NOT NULL,
	[Tematica] [nchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TematicaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Libro]    Script Date: 30/04/2019 22:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Libro]
AS
SELECT        dbo.Material.MaterialId, dbo.Material.TituloMaterial AS Título, dbo.Material.AutorMaterial AS Autor, dbo.Material.FechaPublicacion AS [Fecha de publicación], dbo.Material.DescripcionMaterial AS Descripción, dbo.Material.Isbn, 
                         dbo.Material.Editorial, dbo.Tematica.Tematica AS Temática, dbo.Idioma.NombreIdioma AS Idioma, dbo.EstadoMaterial.EstadoMaterial AS Estado
FROM            dbo.Material INNER JOIN
                         dbo.EstadoMaterial ON dbo.Material.EstadoMaterialId = dbo.EstadoMaterial.EstadoMaterialId INNER JOIN
                         dbo.Idioma ON dbo.Material.IdiomaId = dbo.Idioma.IdiomaId INNER JOIN
                         dbo.Tematica ON dbo.Material.TematicaId = dbo.Tematica.TematicaId
WHERE        (dbo.Material.TipoMaterialId = 1)
GO
/****** Object:  View [dbo].[Revista]    Script Date: 30/04/2019 22:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Revista]
AS
SELECT        dbo.Material.MaterialId, dbo.Material.TituloMaterial AS Título, dbo.Material.AutorMaterial AS Autor, dbo.Material.FechaPublicacion AS [Fecha de publicación], dbo.Material.Issn, dbo.Material.DescripcionMaterial AS Descripción, 
                         dbo.Tematica.Tematica, dbo.Idioma.NombreIdioma, dbo.EstadoMaterial.EstadoMaterial
FROM            dbo.EstadoMaterial INNER JOIN
                         dbo.Material ON dbo.EstadoMaterial.EstadoMaterialId = dbo.Material.EstadoMaterialId INNER JOIN
                         dbo.Idioma ON dbo.Material.IdiomaId = dbo.Idioma.IdiomaId INNER JOIN
                         dbo.Tematica ON dbo.Material.TematicaId = dbo.Tematica.TematicaId
WHERE        (dbo.Material.TipoMaterialId = 2)
GO
/****** Object:  Table [dbo].[TipoMaterial]    Script Date: 30/04/2019 22:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoMaterial](
	[TipoMaterialId] [int] IDENTITY(1,1) NOT NULL,
	[TipoMaterial] [nchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TipoMaterialId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Discos]    Script Date: 30/04/2019 22:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Discos]
AS
SELECT        dbo.Material.MaterialId, dbo.Material.TituloMaterial AS Título, dbo.Material.AutorMaterial AS Autor, dbo.Material.FechaPublicacion AS [Fecha de publicación], dbo.Material.DescripcionMaterial AS Descripción, 
                         dbo.Material.Duracion AS [Duración (min)], dbo.TipoMaterial.TipoMaterial AS [Tipo de material], dbo.Idioma.NombreIdioma AS Idioma, dbo.EstadoMaterial.EstadoMaterial AS Estado
FROM            dbo.EstadoMaterial INNER JOIN
                         dbo.Material ON dbo.EstadoMaterial.EstadoMaterialId = dbo.Material.EstadoMaterialId INNER JOIN
                         dbo.Idioma ON dbo.Material.IdiomaId = dbo.Idioma.IdiomaId INNER JOIN
                         dbo.Tematica ON dbo.Material.TematicaId = dbo.Tematica.TematicaId INNER JOIN
                         dbo.TipoMaterial ON dbo.Material.TipoMaterialId = dbo.TipoMaterial.TipoMaterialId
WHERE        (dbo.Material.TipoMaterialId = 3) OR
                         (dbo.Material.TipoMaterialId = 4)
GO
/****** Object:  Table [dbo].[PQRS]    Script Date: 30/04/2019 22:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PQRS](
	[PQRSId] [int] IDENTITY(1,1) NOT NULL,
	[RemitentePQRS] [nchar](45) NOT NULL,
	[MensajePQRS] [text] NOT NULL,
	[RespuestaPQRS] [text] NULL,
	[TipoPQRSId] [int] NOT NULL,
	[EstadoPQRSId] [int] NOT NULL,
	[UsuarioId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PQRSId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoPQRS]    Script Date: 30/04/2019 22:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoPQRS](
	[TipoPQRSId] [int] IDENTITY(1,1) NOT NULL,
	[TipoPQRS] [nchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TipoPQRSId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[PQRSSinResponder]    Script Date: 30/04/2019 22:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PQRSSinResponder]
AS
SELECT        dbo.PQRS.RemitentePQRS AS Remitente, dbo.PQRS.MensajePQRS AS Mensaje, dbo.TipoPQRS.TipoPQRS AS Tipo
FROM            dbo.PQRS INNER JOIN
                         dbo.TipoPQRS ON dbo.PQRS.TipoPQRSId = dbo.TipoPQRS.TipoPQRSId
WHERE        (dbo.PQRS.EstadoPQRSId = 1)
GO
/****** Object:  View [dbo].[PQRSRespondida]    Script Date: 30/04/2019 22:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PQRSRespondida]
AS
SELECT        dbo.PQRS.RemitentePQRS AS Remitente, dbo.PQRS.MensajePQRS AS Mensaje, dbo.PQRS.RespuestaPQRS AS Respuesta, dbo.TipoPQRS.TipoPQRS AS Tipo, dbo.Usuario.Nombres, dbo.Usuario.Apellidos
FROM            dbo.PQRS INNER JOIN
                         dbo.TipoPQRS ON dbo.PQRS.TipoPQRSId = dbo.TipoPQRS.TipoPQRSId INNER JOIN
                         dbo.Usuario ON dbo.PQRS.UsuarioId = dbo.Usuario.UsuarioId
WHERE        (dbo.PQRS.EstadoPQRSId = 2)
GO
/****** Object:  Table [dbo].[Donacion]    Script Date: 30/04/2019 22:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Donacion](
	[DonacionId] [int] IDENTITY(1,1) NOT NULL,
	[FechaDonacion] [datetime] NOT NULL,
	[MotivoRechazo] [text] NULL,
	[EstadoDonacionId] [int] NOT NULL,
	[UsuarioId] [int] NOT NULL,
	[MaterialId] [int] NOT NULL,
 CONSTRAINT [PK__Donacion__9F5DEE87B8B5C53B] PRIMARY KEY CLUSTERED 
(
	[DonacionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoDonacion]    Script Date: 30/04/2019 22:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoDonacion](
	[EstadoDonacionId] [int] IDENTITY(1,1) NOT NULL,
	[EstadoDonacion] [nchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EstadoDonacionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoPQRS]    Script Date: 30/04/2019 22:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoPQRS](
	[EstadoPQRSId] [int] IDENTITY(1,1) NOT NULL,
	[EstadoPQRS] [nchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EstadoPQRSId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoPrestamo]    Script Date: 30/04/2019 22:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoPrestamo](
	[EstadoPrestamoId] [int] IDENTITY(1,1) NOT NULL,
	[EstadoPrestamo] [nchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EstadoPrestamoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prestamo]    Script Date: 30/04/2019 22:44:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prestamo](
	[PrestamoId] [int] IDENTITY(1,1) NOT NULL,
	[FechaPrestamo] [datetime] NOT NULL,
	[FechaDevolucion] [datetime] NOT NULL,
	[UsuarioId] [int] NOT NULL,
	[EstadoPrestamoId] [int] NOT NULL,
	[MaterialId] [int] NOT NULL,
 CONSTRAINT [PK__Prestamo__AA58A0A076C519FC] PRIMARY KEY CLUSTERED 
(
	[PrestamoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suspension]    Script Date: 30/04/2019 22:44:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suspension](
	[SuspensionId] [int] IDENTITY(1,1) NOT NULL,
	[FechaSuspension] [datetime] NOT NULL,
	[DetalleSuspension] [nchar](45) NOT NULL,
	[PrestamoId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SuspensionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[EstadoDonacion] ON 

INSERT [dbo].[EstadoDonacion] ([EstadoDonacionId], [EstadoDonacion]) VALUES (1, N'En proceso                                   ')
INSERT [dbo].[EstadoDonacion] ([EstadoDonacionId], [EstadoDonacion]) VALUES (2, N'Aceptada                                     ')
INSERT [dbo].[EstadoDonacion] ([EstadoDonacionId], [EstadoDonacion]) VALUES (3, N'Rechazada                                    ')
SET IDENTITY_INSERT [dbo].[EstadoDonacion] OFF
SET IDENTITY_INSERT [dbo].[EstadoMaterial] ON 

INSERT [dbo].[EstadoMaterial] ([EstadoMaterialId], [EstadoMaterial]) VALUES (1, N'Disponible                                   ')
INSERT [dbo].[EstadoMaterial] ([EstadoMaterialId], [EstadoMaterial]) VALUES (2, N'Prestado                                     ')
SET IDENTITY_INSERT [dbo].[EstadoMaterial] OFF
SET IDENTITY_INSERT [dbo].[EstadoPQRS] ON 

INSERT [dbo].[EstadoPQRS] ([EstadoPQRSId], [EstadoPQRS]) VALUES (1, N'Sin reponder                                 ')
INSERT [dbo].[EstadoPQRS] ([EstadoPQRSId], [EstadoPQRS]) VALUES (2, N'Respondida                                   ')
SET IDENTITY_INSERT [dbo].[EstadoPQRS] OFF
SET IDENTITY_INSERT [dbo].[EstadoPrestamo] ON 

INSERT [dbo].[EstadoPrestamo] ([EstadoPrestamoId], [EstadoPrestamo]) VALUES (1, N'Activo                                       ')
INSERT [dbo].[EstadoPrestamo] ([EstadoPrestamoId], [EstadoPrestamo]) VALUES (2, N'Finalizado                                   ')
SET IDENTITY_INSERT [dbo].[EstadoPrestamo] OFF
SET IDENTITY_INSERT [dbo].[EstadoUsuario] ON 

INSERT [dbo].[EstadoUsuario] ([EstadoUsuarioId], [EstadoUsuario]) VALUES (1, N'Activo                                       ')
INSERT [dbo].[EstadoUsuario] ([EstadoUsuarioId], [EstadoUsuario]) VALUES (2, N'Suspendido                                   ')
INSERT [dbo].[EstadoUsuario] ([EstadoUsuarioId], [EstadoUsuario]) VALUES (3, N'Suspención propia                            ')
SET IDENTITY_INSERT [dbo].[EstadoUsuario] OFF
SET IDENTITY_INSERT [dbo].[Idioma] ON 

INSERT [dbo].[Idioma] ([IdiomaId], [NombreIdioma], [SiglaIdioma]) VALUES (1, N'No aplica                                    ', N'NA')
INSERT [dbo].[Idioma] ([IdiomaId], [NombreIdioma], [SiglaIdioma]) VALUES (2, N'Español                                      ', N'ES')
INSERT [dbo].[Idioma] ([IdiomaId], [NombreIdioma], [SiglaIdioma]) VALUES (3, N'Inglés                                       ', N'EN')
INSERT [dbo].[Idioma] ([IdiomaId], [NombreIdioma], [SiglaIdioma]) VALUES (4, N'Francés                                      ', N'FR')
INSERT [dbo].[Idioma] ([IdiomaId], [NombreIdioma], [SiglaIdioma]) VALUES (5, N'Portugués                                    ', N'PT')
INSERT [dbo].[Idioma] ([IdiomaId], [NombreIdioma], [SiglaIdioma]) VALUES (6, N'Italiano                                     ', N'IT')
SET IDENTITY_INSERT [dbo].[Idioma] OFF
SET IDENTITY_INSERT [dbo].[Material] ON 

INSERT [dbo].[Material] ([MaterialId], [TituloMaterial], [AutorMaterial], [FechaPublicacion], [DescripcionMaterial], [Isbn], [Editorial], [Issn], [Duracion], [IdiomaId], [TematicaId], [TipoMaterialId], [EstadoMaterialId]) VALUES (1, N'Red                                          ', N'King Crimson                                 ', CAST(N'1974-04-10' AS Date), N'1. Red
2. Fallen Angel
3. One More Red Nighmare
4. Providence
5. Starless', N'NULL                ', N'NULL                                         ', N'NULL                ', N'39   ', 3, 1, 3, 1)
INSERT [dbo].[Material] ([MaterialId], [TituloMaterial], [AutorMaterial], [FechaPublicacion], [DescripcionMaterial], [Isbn], [Editorial], [Issn], [Duracion], [IdiomaId], [TematicaId], [TipoMaterialId], [EstadoMaterialId]) VALUES (2, N'Cien Años de Soledad                         ', N'Gabriel García Marquez                       ', CAST(N'1967-03-05' AS Date), N'Novela colombiana', N'978-958-567-45-34   ', N'Planeta                                      ', N'NULL                ', N'NULL ', 2, 10, 1, 1)
SET IDENTITY_INSERT [dbo].[Material] OFF
SET IDENTITY_INSERT [dbo].[Tematica] ON 

INSERT [dbo].[Tematica] ([TematicaId], [NumeroDewey], [Tematica]) VALUES (1, N'NA ', N'No aplica                                    ')
INSERT [dbo].[Tematica] ([TematicaId], [NumeroDewey], [Tematica]) VALUES (2, N'000', N'Generalidades                                ')
INSERT [dbo].[Tematica] ([TematicaId], [NumeroDewey], [Tematica]) VALUES (3, N'100', N'Filosofía y psicología                       ')
INSERT [dbo].[Tematica] ([TematicaId], [NumeroDewey], [Tematica]) VALUES (4, N'200', N'Religión                                     ')
INSERT [dbo].[Tematica] ([TematicaId], [NumeroDewey], [Tematica]) VALUES (5, N'300', N'Ciencias sociales                            ')
INSERT [dbo].[Tematica] ([TematicaId], [NumeroDewey], [Tematica]) VALUES (6, N'400', N'Lenguas                                      ')
INSERT [dbo].[Tematica] ([TematicaId], [NumeroDewey], [Tematica]) VALUES (7, N'500', N'Ciencias naturales y matemáticas             ')
INSERT [dbo].[Tematica] ([TematicaId], [NumeroDewey], [Tematica]) VALUES (8, N'600', N'Tecnología (ciencias aplicadas)              ')
INSERT [dbo].[Tematica] ([TematicaId], [NumeroDewey], [Tematica]) VALUES (9, N'700', N'Artes                                        ')
INSERT [dbo].[Tematica] ([TematicaId], [NumeroDewey], [Tematica]) VALUES (10, N'800', N'Literatura y retórica                        ')
INSERT [dbo].[Tematica] ([TematicaId], [NumeroDewey], [Tematica]) VALUES (11, N'900', N'Geografía e historia                         ')
SET IDENTITY_INSERT [dbo].[Tematica] OFF
SET IDENTITY_INSERT [dbo].[TipoDocumento] ON 

INSERT [dbo].[TipoDocumento] ([TipoDocumentoId], [TipoDocumento], [SiglaTipoDocumento]) VALUES (1, N'Tarjeta de identidad                         ', N'TI')
INSERT [dbo].[TipoDocumento] ([TipoDocumentoId], [TipoDocumento], [SiglaTipoDocumento]) VALUES (2, N'Cédula de ciudadanía                         ', N'CC')
INSERT [dbo].[TipoDocumento] ([TipoDocumentoId], [TipoDocumento], [SiglaTipoDocumento]) VALUES (3, N'Cédula de extranjería                        ', N'CE')
INSERT [dbo].[TipoDocumento] ([TipoDocumentoId], [TipoDocumento], [SiglaTipoDocumento]) VALUES (4, N'Pasaporte                                    ', N'P ')
SET IDENTITY_INSERT [dbo].[TipoDocumento] OFF
SET IDENTITY_INSERT [dbo].[TipoMaterial] ON 

INSERT [dbo].[TipoMaterial] ([TipoMaterialId], [TipoMaterial]) VALUES (1, N'Libro                                        ')
INSERT [dbo].[TipoMaterial] ([TipoMaterialId], [TipoMaterial]) VALUES (2, N'Revista                                      ')
INSERT [dbo].[TipoMaterial] ([TipoMaterialId], [TipoMaterial]) VALUES (3, N'CD                                           ')
INSERT [dbo].[TipoMaterial] ([TipoMaterialId], [TipoMaterial]) VALUES (4, N'DVD                                          ')
SET IDENTITY_INSERT [dbo].[TipoMaterial] OFF
SET IDENTITY_INSERT [dbo].[TipoPQRS] ON 

INSERT [dbo].[TipoPQRS] ([TipoPQRSId], [TipoPQRS]) VALUES (1, N'Pregunta                                     ')
INSERT [dbo].[TipoPQRS] ([TipoPQRSId], [TipoPQRS]) VALUES (2, N'Queja                                        ')
INSERT [dbo].[TipoPQRS] ([TipoPQRSId], [TipoPQRS]) VALUES (3, N'Reclamo                                      ')
INSERT [dbo].[TipoPQRS] ([TipoPQRSId], [TipoPQRS]) VALUES (4, N'Sugerencia                                   ')
SET IDENTITY_INSERT [dbo].[TipoPQRS] OFF
SET IDENTITY_INSERT [dbo].[TipoUsuario] ON 

INSERT [dbo].[TipoUsuario] ([TipoUsuarioId], [TipoUsuario]) VALUES (1, N'Administrador                                ')
INSERT [dbo].[TipoUsuario] ([TipoUsuarioId], [TipoUsuario]) VALUES (2, N'Cliente                                      ')
SET IDENTITY_INSERT [dbo].[TipoUsuario] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([UsuarioId], [Nombres], [Apellidos], [Documento], [FechaNacimiento], [CorreoElectronico], [Clave], [Telefono], [TipoUsuarioId], [TipoDocumentoId], [EstadoUsuarioId]) VALUES (2, N'David Santiago                               ', N'Rivas Agudelo                                ', N'1026291172     ', CAST(N'1995-06-13' AS Date), N'dsrivas2@misena.edu.co                       ', N'david                                        ', NULL, 1, 2, 1)
INSERT [dbo].[Usuario] ([UsuarioId], [Nombres], [Apellidos], [Documento], [FechaNacimiento], [CorreoElectronico], [Clave], [Telefono], [TipoUsuarioId], [TipoDocumentoId], [EstadoUsuarioId]) VALUES (3, N'Juan Alexander                               ', N'Vargas Ramos                                 ', N'1234567890     ', CAST(N'1995-01-01' AS Date), N'javargas@misena.edu.co                       ', N'juan                                         ', N'3124567890', 2, 2, 1)
INSERT [dbo].[Usuario] ([UsuarioId], [Nombres], [Apellidos], [Documento], [FechaNacimiento], [CorreoElectronico], [Clave], [Telefono], [TipoUsuarioId], [TipoDocumentoId], [EstadoUsuarioId]) VALUES (4, N'Cristian                                     ', N'Barreto                                      ', N'123456         ', CAST(N'2000-06-06' AS Date), N'cris.bar@gmail.com                           ', N'cristian                                     ', N'          ', 2, 2, 1)
INSERT [dbo].[Usuario] ([UsuarioId], [Nombres], [Apellidos], [Documento], [FechaNacimiento], [CorreoElectronico], [Clave], [Telefono], [TipoUsuarioId], [TipoDocumentoId], [EstadoUsuarioId]) VALUES (7, N'John                                         ', N'Lennon                                       ', N'234456         ', CAST(N'1980-08-09' AS Date), N'john@lennon.com                              ', N'lennon                                       ', NULL, 2, 3, 1)
INSERT [dbo].[Usuario] ([UsuarioId], [Nombres], [Apellidos], [Documento], [FechaNacimiento], [CorreoElectronico], [Clave], [Telefono], [TipoUsuarioId], [TipoDocumentoId], [EstadoUsuarioId]) VALUES (8, N'Yenni                                        ', N'Bosera                                       ', N'123132         ', CAST(N'1999-11-09' AS Date), N'gjhgjhj@hashf.com                            ', N'1234567                                      ', NULL, 2, 1, 1)
INSERT [dbo].[Usuario] ([UsuarioId], [Nombres], [Apellidos], [Documento], [FechaNacimiento], [CorreoElectronico], [Clave], [Telefono], [TipoUsuarioId], [TipoDocumentoId], [EstadoUsuarioId]) VALUES (12, N'Catalina Concepción                          ', N'Hernández Aldana                             ', N'3456           ', CAST(N'1990-03-09' AS Date), N'catalina@iesec.net                           ', N'katy                                         ', N'4564567   ', 2, 2, 1)
INSERT [dbo].[Usuario] ([UsuarioId], [Nombres], [Apellidos], [Documento], [FechaNacimiento], [CorreoElectronico], [Clave], [Telefono], [TipoUsuarioId], [TipoDocumentoId], [EstadoUsuarioId]) VALUES (13, N'Katherine                                    ', N'Garzón                                       ', N'666            ', CAST(N'1993-11-05' AS Date), N'okgarzon@misena.edu.co                       ', N'katherine                                    ', NULL, 2, 2, 1)
INSERT [dbo].[Usuario] ([UsuarioId], [Nombres], [Apellidos], [Documento], [FechaNacimiento], [CorreoElectronico], [Clave], [Telefono], [TipoUsuarioId], [TipoDocumentoId], [EstadoUsuarioId]) VALUES (15, N'Arturo                                       ', N'Calle                                        ', N'65747          ', CAST(N'1984-06-06' AS Date), N'arturocalle@excel.com                        ', N'Vean lo que me dejaron                       ', N'4656      ', 2, 3, 1)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
ALTER TABLE [dbo].[Donacion]  WITH CHECK ADD  CONSTRAINT [FK__Donacion__Estado__71D1E811] FOREIGN KEY([EstadoDonacionId])
REFERENCES [dbo].[EstadoDonacion] ([EstadoDonacionId])
GO
ALTER TABLE [dbo].[Donacion] CHECK CONSTRAINT [FK__Donacion__Estado__71D1E811]
GO
ALTER TABLE [dbo].[Donacion]  WITH CHECK ADD  CONSTRAINT [FK__Donacion__Usuari__70DDC3D8] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuario] ([UsuarioId])
GO
ALTER TABLE [dbo].[Donacion] CHECK CONSTRAINT [FK__Donacion__Usuari__70DDC3D8]
GO
ALTER TABLE [dbo].[Donacion]  WITH CHECK ADD  CONSTRAINT [FK_Donacion_Material] FOREIGN KEY([MaterialId])
REFERENCES [dbo].[Material] ([MaterialId])
GO
ALTER TABLE [dbo].[Donacion] CHECK CONSTRAINT [FK_Donacion_Material]
GO
ALTER TABLE [dbo].[Material]  WITH CHECK ADD  CONSTRAINT [FK__Material__Estado__7A672E12] FOREIGN KEY([EstadoMaterialId])
REFERENCES [dbo].[EstadoMaterial] ([EstadoMaterialId])
GO
ALTER TABLE [dbo].[Material] CHECK CONSTRAINT [FK__Material__Estado__7A672E12]
GO
ALTER TABLE [dbo].[Material]  WITH CHECK ADD  CONSTRAINT [FK__Material__Idioma__787EE5A0] FOREIGN KEY([IdiomaId])
REFERENCES [dbo].[Idioma] ([IdiomaId])
GO
ALTER TABLE [dbo].[Material] CHECK CONSTRAINT [FK__Material__Idioma__787EE5A0]
GO
ALTER TABLE [dbo].[Material]  WITH CHECK ADD  CONSTRAINT [FK__Material__Temati__778AC167] FOREIGN KEY([TematicaId])
REFERENCES [dbo].[Tematica] ([TematicaId])
GO
ALTER TABLE [dbo].[Material] CHECK CONSTRAINT [FK__Material__Temati__778AC167]
GO
ALTER TABLE [dbo].[Material]  WITH CHECK ADD  CONSTRAINT [FK__Material__TipoMa__797309D9] FOREIGN KEY([TipoMaterialId])
REFERENCES [dbo].[TipoMaterial] ([TipoMaterialId])
GO
ALTER TABLE [dbo].[Material] CHECK CONSTRAINT [FK__Material__TipoMa__797309D9]
GO
ALTER TABLE [dbo].[PQRS]  WITH CHECK ADD FOREIGN KEY([EstadoPQRSId])
REFERENCES [dbo].[EstadoPQRS] ([EstadoPQRSId])
GO
ALTER TABLE [dbo].[PQRS]  WITH CHECK ADD FOREIGN KEY([TipoPQRSId])
REFERENCES [dbo].[TipoPQRS] ([TipoPQRSId])
GO
ALTER TABLE [dbo].[PQRS]  WITH CHECK ADD FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuario] ([UsuarioId])
GO
ALTER TABLE [dbo].[Prestamo]  WITH CHECK ADD  CONSTRAINT [FK__Prestamo__Estado__7D439ABD] FOREIGN KEY([EstadoPrestamoId])
REFERENCES [dbo].[EstadoPrestamo] ([EstadoPrestamoId])
GO
ALTER TABLE [dbo].[Prestamo] CHECK CONSTRAINT [FK__Prestamo__Estado__7D439ABD]
GO
ALTER TABLE [dbo].[Prestamo]  WITH CHECK ADD  CONSTRAINT [FK__Prestamo__Usuari__7C4F7684] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuario] ([UsuarioId])
GO
ALTER TABLE [dbo].[Prestamo] CHECK CONSTRAINT [FK__Prestamo__Usuari__7C4F7684]
GO
ALTER TABLE [dbo].[Prestamo]  WITH CHECK ADD  CONSTRAINT [FK_Prestamo_Material] FOREIGN KEY([MaterialId])
REFERENCES [dbo].[Material] ([MaterialId])
GO
ALTER TABLE [dbo].[Prestamo] CHECK CONSTRAINT [FK_Prestamo_Material]
GO
ALTER TABLE [dbo].[Suspension]  WITH CHECK ADD  CONSTRAINT [FK__Suspensio__Prest__7B5B524B] FOREIGN KEY([PrestamoId])
REFERENCES [dbo].[Prestamo] ([PrestamoId])
GO
ALTER TABLE [dbo].[Suspension] CHECK CONSTRAINT [FK__Suspensio__Prest__7B5B524B]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD FOREIGN KEY([EstadoUsuarioId])
REFERENCES [dbo].[EstadoUsuario] ([EstadoUsuarioId])
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD FOREIGN KEY([TipoDocumentoId])
REFERENCES [dbo].[TipoDocumento] ([TipoDocumentoId])
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD FOREIGN KEY([TipoUsuarioId])
REFERENCES [dbo].[TipoUsuario] ([TipoUsuarioId])
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "EstadoMaterial"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 215
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Material"
            Begin Extent = 
               Top = 6
               Left = 461
               Bottom = 136
               Right = 655
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Idioma"
            Begin Extent = 
               Top = 6
               Left = 253
               Bottom = 119
               Right = 423
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Tematica"
            Begin Extent = 
               Top = 6
               Left = 693
               Bottom = 119
               Right = 863
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TipoMaterial"
            Begin Extent = 
               Top = 102
               Left = 38
               Bottom = 198
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
        ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Discos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Discos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Discos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Material"
            Begin Extent = 
               Top = 16
               Left = 272
               Bottom = 146
               Right = 466
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "EstadoMaterial"
            Begin Extent = 
               Top = 69
               Left = 9
               Bottom = 165
               Right = 186
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Idioma"
            Begin Extent = 
               Top = 0
               Left = 808
               Bottom = 113
               Right = 978
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Tematica"
            Begin Extent = 
               Top = 110
               Left = 629
               Bottom = 223
               Right = 799
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1185
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Libro'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Libro'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "PQRS"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 210
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "TipoPQRS"
            Begin Extent = 
               Top = 6
               Left = 248
               Bottom = 102
               Right = 418
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Usuario"
            Begin Extent = 
               Top = 6
               Left = 456
               Bottom = 136
               Right = 642
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PQRSRespondida'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PQRSRespondida'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "PQRS"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 418
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "TipoPQRS"
            Begin Extent = 
               Top = 6
               Left = 456
               Bottom = 102
               Right = 626
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PQRSSinResponder'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PQRSSinResponder'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = -33
      End
      Begin Tables = 
         Begin Table = "EstadoMaterial"
            Begin Extent = 
               Top = 84
               Left = 29
               Bottom = 180
               Right = 206
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Material"
            Begin Extent = 
               Top = 6
               Left = 461
               Bottom = 136
               Right = 655
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Idioma"
            Begin Extent = 
               Top = 6
               Left = 253
               Bottom = 119
               Right = 423
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Tematica"
            Begin Extent = 
               Top = 6
               Left = 693
               Bottom = 119
               Right = 863
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Revista'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Revista'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "EstadoUsuario"
            Begin Extent = 
               Top = 108
               Left = 53
               Bottom = 204
               Right = 227
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Usuario"
            Begin Extent = 
               Top = 79
               Left = 430
               Bottom = 209
               Right = 616
            End
            DisplayFlags = 280
            TopColumn = 7
         End
         Begin Table = "TipoDocumento"
            Begin Extent = 
               Top = 87
               Left = 743
               Bottom = 200
               Right = 944
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TipoUsuario"
            Begin Extent = 
               Top = 24
               Left = 212
               Bottom = 120
               Right = 382
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2100
         Alias = 900
         Table = 1830
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UsuarioCompleto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'UsuarioCompleto'
GO
USE [master]
GO
ALTER DATABASE [Loanium] SET  READ_WRITE 
GO
