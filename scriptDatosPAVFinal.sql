USE [master]
GO
/****** Object:  Database [Proyecto_PAVI2021_2daVersion]    Script Date: 10/11/2021 06:00:41 ******/
CREATE DATABASE [Proyecto_PAVI2021_2daVersion]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Proyecto_PAVI2021_2daVersion', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Proyecto_PAVI2021_2daVersion.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Proyecto_PAVI2021_2daVersion_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Proyecto_PAVI2021_2daVersion_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Proyecto_PAVI2021_2daVersion].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET ARITHABORT OFF 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET  MULTI_USER 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET QUERY_STORE = OFF
GO
USE [Proyecto_PAVI2021_2daVersion]
GO
/****** Object:  Table [dbo].[BARRIOS]    Script Date: 10/11/2021 06:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BARRIOS](
	[Id_Barrio] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Borrado] [bit] NULL,
	[Id_Localidad] [int] NULL,
 CONSTRAINT [PK_BARRIOS] PRIMARY KEY CLUSTERED 
(
	[Id_Barrio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 10/11/2021 06:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTES](
	[Id_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Tipo_Doc] [varchar](50) NULL,
	[Nro_Doc] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Calle] [varchar](50) NULL,
	[Nro_Calle] [varchar](50) NULL,
	[Fecha_Alta] [datetime] NULL,
	[Borrado] [bit] NULL,
	[Id_Barrio] [int] NULL,
 CONSTRAINT [PK_CLIENTES] PRIMARY KEY CLUSTERED 
(
	[Id_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DETALLE_FACTURA_COMPRAS]    Script Date: 10/11/2021 06:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_FACTURA_COMPRAS](
	[Id_Detalle_Factura] [int] IDENTITY(1,1) NOT NULL,
	[Id_Factura] [int] NOT NULL,
	[Id_Material] [int] NOT NULL,
	[Cantidad_Comprada] [int] NULL,
	[Precio_Compra] [int] NULL,
	[Borrado] [bit] NULL,
 CONSTRAINT [PK_DETALLE_FACTURA_COMPRAS] PRIMARY KEY CLUSTERED 
(
	[Id_Detalle_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DETALLE_FACTURA_VENTAS]    Script Date: 10/11/2021 06:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_FACTURA_VENTAS](
	[Id_Detalle_Factura] [int] IDENTITY(1,1) NOT NULL,
	[Id_Factura] [int] NOT NULL,
	[Id_Material] [int] NOT NULL,
	[Cantidad_Vendida] [int] NULL,
	[Precio_Venta] [int] NULL,
	[Borrado] [bit] NULL,
	[Id_Lote] [int] NULL,
 CONSTRAINT [PK_DETALLE_FACTURA_VENTAS] PRIMARY KEY CLUSTERED 
(
	[Id_Detalle_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACTURA_COMPRA]    Script Date: 10/11/2021 06:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACTURA_COMPRA](
	[Id_Factura] [int] IDENTITY(1,1) NOT NULL,
	[Nro_Factura] [int] NOT NULL,
	[Tipo_Factura] [varchar](50) NULL,
	[Id_Proveedor] [int] NOT NULL,
	[Fecha_Factura] [datetime] NULL,
	[Legajo_Empleado] [int] NOT NULL,
	[Borrado] [bit] NULL,
 CONSTRAINT [PK_FACTURA_COMPRA] PRIMARY KEY CLUSTERED 
(
	[Id_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACTURA_VENTA]    Script Date: 10/11/2021 06:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACTURA_VENTA](
	[Id_Factura] [int] IDENTITY(1,1) NOT NULL,
	[Tipo_Factura] [varchar](50) NULL,
	[Id_Cliente] [int] NULL,
	[Fecha_Factura] [datetime] NULL,
	[Legajo_Empleado] [int] NULL,
	[Borrado] [bit] NULL,
 CONSTRAINT [PK_FACTURA_VENTA] PRIMARY KEY CLUSTERED 
(
	[Id_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FORMAS_PAGO]    Script Date: 10/11/2021 06:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FORMAS_PAGO](
	[Id_Forma_Pago] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Borrado] [bit] NULL,
 CONSTRAINT [PK_FORMAS_PAGO] PRIMARY KEY CLUSTERED 
(
	[Id_Forma_Pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOCALIDADES]    Script Date: 10/11/2021 06:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOCALIDADES](
	[Id_Localidad] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Borrado] [bit] NULL,
 CONSTRAINT [PK_LOCALIDADES] PRIMARY KEY CLUSTERED 
(
	[Id_Localidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOTE]    Script Date: 10/11/2021 06:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOTE](
	[Id_Lote] [int] IDENTITY(100,1) NOT NULL,
	[Fecha_Lote] [datetime] NULL,
	[Cantidad_Fabricada] [int] NULL,
	[Legajo_Empleado] [int] NULL,
	[Confirmacion_Lote] [bit] NULL,
	[Stock_Lote] [int] NULL,
	[Id_Material] [int] NULL,
	[Borrado] [bit] NULL,
 CONSTRAINT [PK_LOTE] PRIMARY KEY CLUSTERED 
(
	[Id_Lote] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MARCAS]    Script Date: 10/11/2021 06:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MARCAS](
	[Id_Marca] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Borrado] [bit] NULL,
 CONSTRAINT [PK_MARCAS] PRIMARY KEY CLUSTERED 
(
	[Id_Marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MATERIALES]    Script Date: 10/11/2021 06:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MATERIALES](
	[Id_Material] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Stock] [int] NULL,
	[Borrado] [bit] NULL,
	[Id_Marca] [int] NULL,
	[Precio] [decimal](10, 2) NULL,
 CONSTRAINT [PK_MATERIALES] PRIMARY KEY CLUSTERED 
(
	[Id_Material] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PAGOS_X_FACTURA]    Script Date: 10/11/2021 06:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAGOS_X_FACTURA](
	[Id_Pago_Factura] [int] IDENTITY(1,1) NOT NULL,
	[Id_Factura] [int] NOT NULL,
	[Id_Forma_Pago] [int] NULL,
	[Monto] [float] NULL,
	[Nro_Tarjeta] [int] NULL,
	[Cuotas] [int] NULL,
	[Borrado] [bit] NULL,
 CONSTRAINT [pagos_fac_pk] PRIMARY KEY CLUSTERED 
(
	[Id_Pago_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PERFILES]    Script Date: 10/11/2021 06:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERFILES](
	[Id_Perfil] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](100) NULL,
	[Borrado] [bit] NULL,
 CONSTRAINT [PK_PERFILES] PRIMARY KEY CLUSTERED 
(
	[Id_Perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PERSONAL]    Script Date: 10/11/2021 06:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERSONAL](
	[Legajo] [int] IDENTITY(1000,1) NOT NULL,
	[Tipo_Doc] [varchar](50) NULL,
	[Nro_Doc] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Calle] [varchar](50) NULL,
	[Nro_Calle] [varchar](50) NULL,
	[Id_Barrio] [int] NULL,
	[Id_Usuario] [int] NULL,
	[Borrado] [bit] NULL,
 CONSTRAINT [PK_PERSONAL] PRIMARY KEY CLUSTERED 
(
	[Legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROVEEDORESS]    Script Date: 10/11/2021 06:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVEEDORESS](
	[Id_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[CUIT] [varchar](50) NULL,
	[Calle] [varchar](50) NULL,
	[Nro_Calle] [varchar](50) NULL,
	[Id_Barrio] [int] NULL,
	[Borrado] [bit] NULL,
 CONSTRAINT [PK_PROVEEDORESS] PRIMARY KEY CLUSTERED 
(
	[Id_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 10/11/2021 06:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIOS](
	[Id_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Usuario] [varchar](50) NULL,
	[Contraseña_Usuario] [varchar](50) NULL,
	[Fecha_Alta] [datetime] NULL,
	[Id_Perfil] [int] NULL,
	[Borrado] [bit] NULL,
 CONSTRAINT [PK_USUARIOS] PRIMARY KEY CLUSTERED 
(
	[Id_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BARRIOS] ON 

INSERT [dbo].[BARRIOS] ([Id_Barrio], [Descripcion], [Borrado], [Id_Localidad]) VALUES (1, N'Alto Alberdi', 0, 1)
INSERT [dbo].[BARRIOS] ([Id_Barrio], [Descripcion], [Borrado], [Id_Localidad]) VALUES (2, N'Alta Córdoba', 0, 1)
INSERT [dbo].[BARRIOS] ([Id_Barrio], [Descripcion], [Borrado], [Id_Localidad]) VALUES (3, N'Cofico', 0, 1)
INSERT [dbo].[BARRIOS] ([Id_Barrio], [Descripcion], [Borrado], [Id_Localidad]) VALUES (4, N'Alberdi', 0, 1)
INSERT [dbo].[BARRIOS] ([Id_Barrio], [Descripcion], [Borrado], [Id_Localidad]) VALUES (5, N'Jardin Espinoza', 0, 1)
INSERT [dbo].[BARRIOS] ([Id_Barrio], [Descripcion], [Borrado], [Id_Localidad]) VALUES (6, N'Nueva Córdob', 0, 1)
INSERT [dbo].[BARRIOS] ([Id_Barrio], [Descripcion], [Borrado], [Id_Localidad]) VALUES (7, N'Ciudad Universitaria', 0, 1)
INSERT [dbo].[BARRIOS] ([Id_Barrio], [Descripcion], [Borrado], [Id_Localidad]) VALUES (8, N'Camara', 0, 2)
INSERT [dbo].[BARRIOS] ([Id_Barrio], [Descripcion], [Borrado], [Id_Localidad]) VALUES (9, N'El Crucero', 0, 2)
INSERT [dbo].[BARRIOS] ([Id_Barrio], [Descripcion], [Borrado], [Id_Localidad]) VALUES (10, N'Cafferata', 0, 2)
INSERT [dbo].[BARRIOS] ([Id_Barrio], [Descripcion], [Borrado], [Id_Localidad]) VALUES (11, N'Los Elefantes', 0, 3)
INSERT [dbo].[BARRIOS] ([Id_Barrio], [Descripcion], [Borrado], [Id_Localidad]) VALUES (12, N'12 de Octubre', 0, 3)
INSERT [dbo].[BARRIOS] ([Id_Barrio], [Descripcion], [Borrado], [Id_Localidad]) VALUES (13, N'25 de Mayo', 0, 4)
INSERT [dbo].[BARRIOS] ([Id_Barrio], [Descripcion], [Borrado], [Id_Localidad]) VALUES (14, N'7 Cascadas', 0, 5)
INSERT [dbo].[BARRIOS] ([Id_Barrio], [Descripcion], [Borrado], [Id_Localidad]) VALUES (15, N'La Banderita', 0, 5)
INSERT [dbo].[BARRIOS] ([Id_Barrio], [Descripcion], [Borrado], [Id_Localidad]) VALUES (16, N'San Cayetano', 0, 5)
INSERT [dbo].[BARRIOS] ([Id_Barrio], [Descripcion], [Borrado], [Id_Localidad]) VALUES (17, N'Villa Floresta', 0, 5)
INSERT [dbo].[BARRIOS] ([Id_Barrio], [Descripcion], [Borrado], [Id_Localidad]) VALUES (18, N'Punilla', 0, 6)
INSERT [dbo].[BARRIOS] ([Id_Barrio], [Descripcion], [Borrado], [Id_Localidad]) VALUES (19, N'Cordoba', 0, 6)
INSERT [dbo].[BARRIOS] ([Id_Barrio], [Descripcion], [Borrado], [Id_Localidad]) VALUES (20, N'20 de Junio', 0, 6)
INSERT [dbo].[BARRIOS] ([Id_Barrio], [Descripcion], [Borrado], [Id_Localidad]) VALUES (21, N'6 de Julio', 0, 4)
SET IDENTITY_INSERT [dbo].[BARRIOS] OFF
GO
SET IDENTITY_INSERT [dbo].[CLIENTES] ON 

INSERT [dbo].[CLIENTES] ([Id_Cliente], [Tipo_Doc], [Nro_Doc], [Nombre], [Apellido], [Telefono], [Calle], [Nro_Calle], [Fecha_Alta], [Borrado], [Id_Barrio]) VALUES (1, N'DNI', N'41234567', N'Daniel', N'Rodriguez', N'3517009987', N'San Luis', N'2021', CAST(N'2021-09-18T00:00:00.000' AS DateTime), 0, 1)
INSERT [dbo].[CLIENTES] ([Id_Cliente], [Tipo_Doc], [Nro_Doc], [Nombre], [Apellido], [Telefono], [Calle], [Nro_Calle], [Fecha_Alta], [Borrado], [Id_Barrio]) VALUES (2, N'DNI', N'19987654', N'Carlos', N'Gardel', N'3516677022', N'Obispo Trejo', N'945', CAST(N'2020-10-22T00:00:00.000' AS DateTime), 0, 1)
INSERT [dbo].[CLIENTES] ([Id_Cliente], [Tipo_Doc], [Nro_Doc], [Nombre], [Apellido], [Telefono], [Calle], [Nro_Calle], [Fecha_Alta], [Borrado], [Id_Barrio]) VALUES (3, N'DNI', N'30456123', N'Mariana', N'Figueroa', N'3512244889', N'Santa Rosa', N'1633', CAST(N'2021-01-03T00:00:00.000' AS DateTime), 0, 1)
INSERT [dbo].[CLIENTES] ([Id_Cliente], [Tipo_Doc], [Nro_Doc], [Nombre], [Apellido], [Telefono], [Calle], [Nro_Calle], [Fecha_Alta], [Borrado], [Id_Barrio]) VALUES (4, N'DNI', N'26489076', N'Jorge', N'Herrera', N'3511166772', N'Jujuy', N'2503', CAST(N'2019-06-17T00:00:00.000' AS DateTime), 0, 1)
INSERT [dbo].[CLIENTES] ([Id_Cliente], [Tipo_Doc], [Nro_Doc], [Nombre], [Apellido], [Telefono], [Calle], [Nro_Calle], [Fecha_Alta], [Borrado], [Id_Barrio]) VALUES (5, N'DNI', N'39123029', N'Jose', N'Hernandez', N'3515203911', N'Urquiza', N'1200', CAST(N'2021-11-08T00:00:00.000' AS DateTime), 0, 2)
INSERT [dbo].[CLIENTES] ([Id_Cliente], [Tipo_Doc], [Nro_Doc], [Nombre], [Apellido], [Telefono], [Calle], [Nro_Calle], [Fecha_Alta], [Borrado], [Id_Barrio]) VALUES (6, N'DNI', N'41058729', N'Martin', N'Castaña', N'3519202241', N'Urquiza', N'1350', CAST(N'2021-11-08T00:00:00.000' AS DateTime), 0, 2)
SET IDENTITY_INSERT [dbo].[CLIENTES] OFF
GO
SET IDENTITY_INSERT [dbo].[DETALLE_FACTURA_COMPRAS] ON 

INSERT [dbo].[DETALLE_FACTURA_COMPRAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Comprada], [Precio_Compra], [Borrado]) VALUES (3, 3, 3, 250, 2000, 0)
INSERT [dbo].[DETALLE_FACTURA_COMPRAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Comprada], [Precio_Compra], [Borrado]) VALUES (4, 4, 4, 50, 2500, 0)
INSERT [dbo].[DETALLE_FACTURA_COMPRAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Comprada], [Precio_Compra], [Borrado]) VALUES (5, 5, 3, 75, 2000, 0)
INSERT [dbo].[DETALLE_FACTURA_COMPRAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Comprada], [Precio_Compra], [Borrado]) VALUES (6, 6, 3, 45, 2000, 0)
INSERT [dbo].[DETALLE_FACTURA_COMPRAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Comprada], [Precio_Compra], [Borrado]) VALUES (7, 7, 4, 25, 2500, 0)
INSERT [dbo].[DETALLE_FACTURA_COMPRAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Comprada], [Precio_Compra], [Borrado]) VALUES (8, 8, 3, 115, 2000, 0)
INSERT [dbo].[DETALLE_FACTURA_COMPRAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Comprada], [Precio_Compra], [Borrado]) VALUES (9, 9, 3, 70, 2000, 0)
INSERT [dbo].[DETALLE_FACTURA_COMPRAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Comprada], [Precio_Compra], [Borrado]) VALUES (10, 10, 3, 100, 2000, 0)
INSERT [dbo].[DETALLE_FACTURA_COMPRAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Comprada], [Precio_Compra], [Borrado]) VALUES (11, 11, 4, 60, 2500, 0)
INSERT [dbo].[DETALLE_FACTURA_COMPRAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Comprada], [Precio_Compra], [Borrado]) VALUES (12, 12, 16, 20, 4470, 0)
INSERT [dbo].[DETALLE_FACTURA_COMPRAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Comprada], [Precio_Compra], [Borrado]) VALUES (13, 17, 14, 100, 1320, 0)
INSERT [dbo].[DETALLE_FACTURA_COMPRAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Comprada], [Precio_Compra], [Borrado]) VALUES (14, 19, 14, 30, 1320, 0)
INSERT [dbo].[DETALLE_FACTURA_COMPRAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Comprada], [Precio_Compra], [Borrado]) VALUES (15, 20, 12, 10, 3400, 0)
SET IDENTITY_INSERT [dbo].[DETALLE_FACTURA_COMPRAS] OFF
GO
SET IDENTITY_INSERT [dbo].[DETALLE_FACTURA_VENTAS] ON 

INSERT [dbo].[DETALLE_FACTURA_VENTAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Vendida], [Precio_Venta], [Borrado], [Id_Lote]) VALUES (9, 7, 3, 30, 2000, 0, 100)
INSERT [dbo].[DETALLE_FACTURA_VENTAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Vendida], [Precio_Venta], [Borrado], [Id_Lote]) VALUES (10, 7, 4, 15, 2500, 0, 101)
INSERT [dbo].[DETALLE_FACTURA_VENTAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Vendida], [Precio_Venta], [Borrado], [Id_Lote]) VALUES (1009, 8, 3, 50, 2000, 0, 100)
INSERT [dbo].[DETALLE_FACTURA_VENTAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Vendida], [Precio_Venta], [Borrado], [Id_Lote]) VALUES (1010, 8, 3, 100, 2000, 0, 102)
INSERT [dbo].[DETALLE_FACTURA_VENTAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Vendida], [Precio_Venta], [Borrado], [Id_Lote]) VALUES (1011, 8, 4, 10, 2500, 0, 101)
INSERT [dbo].[DETALLE_FACTURA_VENTAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Vendida], [Precio_Venta], [Borrado], [Id_Lote]) VALUES (1012, 9, 4, 50, 2500, 0, 101)
INSERT [dbo].[DETALLE_FACTURA_VENTAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Vendida], [Precio_Venta], [Borrado], [Id_Lote]) VALUES (1013, 10, 3, 10, 2000, 0, 102)
INSERT [dbo].[DETALLE_FACTURA_VENTAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Vendida], [Precio_Venta], [Borrado], [Id_Lote]) VALUES (1014, 11, 3, 5, 2000, 0, 100)
INSERT [dbo].[DETALLE_FACTURA_VENTAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Vendida], [Precio_Venta], [Borrado], [Id_Lote]) VALUES (1019, 14, 3, 1, 2000, 0, 100)
INSERT [dbo].[DETALLE_FACTURA_VENTAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Vendida], [Precio_Venta], [Borrado], [Id_Lote]) VALUES (1020, 14, 4, 2, 2500, 0, 101)
INSERT [dbo].[DETALLE_FACTURA_VENTAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Vendida], [Precio_Venta], [Borrado], [Id_Lote]) VALUES (1021, 15, 3, 20, 2000, 0, 100)
INSERT [dbo].[DETALLE_FACTURA_VENTAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Vendida], [Precio_Venta], [Borrado], [Id_Lote]) VALUES (1022, 15, 3, 10, 2000, 0, 102)
INSERT [dbo].[DETALLE_FACTURA_VENTAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Vendida], [Precio_Venta], [Borrado], [Id_Lote]) VALUES (1023, 16, 9, 70, 1100, 0, 102)
INSERT [dbo].[DETALLE_FACTURA_VENTAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Vendida], [Precio_Venta], [Borrado], [Id_Lote]) VALUES (1026, 17, 3, 1, 2000, 0, 100)
INSERT [dbo].[DETALLE_FACTURA_VENTAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Vendida], [Precio_Venta], [Borrado], [Id_Lote]) VALUES (1027, 18, 5, 10, 3450, 0, 1115)
INSERT [dbo].[DETALLE_FACTURA_VENTAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Vendida], [Precio_Venta], [Borrado], [Id_Lote]) VALUES (1028, 18, 7, 10, 3600, 0, 1117)
INSERT [dbo].[DETALLE_FACTURA_VENTAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Vendida], [Precio_Venta], [Borrado], [Id_Lote]) VALUES (1029, 18, 13, 10, 1500, 0, 1123)
INSERT [dbo].[DETALLE_FACTURA_VENTAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Vendida], [Precio_Venta], [Borrado], [Id_Lote]) VALUES (1030, 18, 15, 10, 2200, 0, 1125)
INSERT [dbo].[DETALLE_FACTURA_VENTAS] ([Id_Detalle_Factura], [Id_Factura], [Id_Material], [Cantidad_Vendida], [Precio_Venta], [Borrado], [Id_Lote]) VALUES (1031, 18, 17, 10, 1700, 0, 1127)
SET IDENTITY_INSERT [dbo].[DETALLE_FACTURA_VENTAS] OFF
GO
SET IDENTITY_INSERT [dbo].[FACTURA_COMPRA] ON 

INSERT [dbo].[FACTURA_COMPRA] ([Id_Factura], [Nro_Factura], [Tipo_Factura], [Id_Proveedor], [Fecha_Factura], [Legajo_Empleado], [Borrado]) VALUES (3, 1, N'A', 2, CAST(N'2021-11-02T23:49:59.763' AS DateTime), 1008, 0)
INSERT [dbo].[FACTURA_COMPRA] ([Id_Factura], [Nro_Factura], [Tipo_Factura], [Id_Proveedor], [Fecha_Factura], [Legajo_Empleado], [Borrado]) VALUES (4, 2, N'A', 4, CAST(N'2021-11-02T23:51:59.200' AS DateTime), 1012, 0)
INSERT [dbo].[FACTURA_COMPRA] ([Id_Factura], [Nro_Factura], [Tipo_Factura], [Id_Proveedor], [Fecha_Factura], [Legajo_Empleado], [Borrado]) VALUES (5, 3, N'C', 3, CAST(N'2021-11-02T23:51:59.200' AS DateTime), 1010, 0)
INSERT [dbo].[FACTURA_COMPRA] ([Id_Factura], [Nro_Factura], [Tipo_Factura], [Id_Proveedor], [Fecha_Factura], [Legajo_Empleado], [Borrado]) VALUES (6, 4, N'A', 2, CAST(N'2021-11-02T23:51:59.200' AS DateTime), 1009, 0)
INSERT [dbo].[FACTURA_COMPRA] ([Id_Factura], [Nro_Factura], [Tipo_Factura], [Id_Proveedor], [Fecha_Factura], [Legajo_Empleado], [Borrado]) VALUES (7, 5, N'A', 2, CAST(N'2021-11-02T23:51:59.200' AS DateTime), 1010, 0)
INSERT [dbo].[FACTURA_COMPRA] ([Id_Factura], [Nro_Factura], [Tipo_Factura], [Id_Proveedor], [Fecha_Factura], [Legajo_Empleado], [Borrado]) VALUES (8, 6, N'A', 5, CAST(N'2021-11-02T23:51:59.200' AS DateTime), 1010, 0)
INSERT [dbo].[FACTURA_COMPRA] ([Id_Factura], [Nro_Factura], [Tipo_Factura], [Id_Proveedor], [Fecha_Factura], [Legajo_Empleado], [Borrado]) VALUES (9, 7, N'C', 4, CAST(N'2021-11-02T23:51:59.200' AS DateTime), 1010, 0)
INSERT [dbo].[FACTURA_COMPRA] ([Id_Factura], [Nro_Factura], [Tipo_Factura], [Id_Proveedor], [Fecha_Factura], [Legajo_Empleado], [Borrado]) VALUES (10, 8, N'A', 6, CAST(N'2021-11-03T00:05:52.550' AS DateTime), 1011, 0)
INSERT [dbo].[FACTURA_COMPRA] ([Id_Factura], [Nro_Factura], [Tipo_Factura], [Id_Proveedor], [Fecha_Factura], [Legajo_Empleado], [Borrado]) VALUES (11, 9, N'A', 7, CAST(N'2021-11-03T00:05:52.550' AS DateTime), 1009, 0)
INSERT [dbo].[FACTURA_COMPRA] ([Id_Factura], [Nro_Factura], [Tipo_Factura], [Id_Proveedor], [Fecha_Factura], [Legajo_Empleado], [Borrado]) VALUES (12, 10, N'B', 5, CAST(N'2021-10-11T00:00:00.000' AS DateTime), 1010, 0)
INSERT [dbo].[FACTURA_COMPRA] ([Id_Factura], [Nro_Factura], [Tipo_Factura], [Id_Proveedor], [Fecha_Factura], [Legajo_Empleado], [Borrado]) VALUES (17, 11, N'A', 5, CAST(N'2021-10-11T00:00:00.000' AS DateTime), 1010, 0)
INSERT [dbo].[FACTURA_COMPRA] ([Id_Factura], [Nro_Factura], [Tipo_Factura], [Id_Proveedor], [Fecha_Factura], [Legajo_Empleado], [Borrado]) VALUES (19, 12, N'C', 2, CAST(N'2021-09-09T00:00:00.000' AS DateTime), 1010, 0)
INSERT [dbo].[FACTURA_COMPRA] ([Id_Factura], [Nro_Factura], [Tipo_Factura], [Id_Proveedor], [Fecha_Factura], [Legajo_Empleado], [Borrado]) VALUES (20, 13, N'A', 3, CAST(N'2021-08-08T00:00:00.000' AS DateTime), 1009, 0)
SET IDENTITY_INSERT [dbo].[FACTURA_COMPRA] OFF
GO
SET IDENTITY_INSERT [dbo].[FACTURA_VENTA] ON 

INSERT [dbo].[FACTURA_VENTA] ([Id_Factura], [Tipo_Factura], [Id_Cliente], [Fecha_Factura], [Legajo_Empleado], [Borrado]) VALUES (7, N'A', 1, CAST(N'2021-10-13T00:13:59.423' AS DateTime), 1008, 0)
INSERT [dbo].[FACTURA_VENTA] ([Id_Factura], [Tipo_Factura], [Id_Cliente], [Fecha_Factura], [Legajo_Empleado], [Borrado]) VALUES (8, N'A', 1, CAST(N'2021-10-13T08:30:32.053' AS DateTime), 1008, 0)
INSERT [dbo].[FACTURA_VENTA] ([Id_Factura], [Tipo_Factura], [Id_Cliente], [Fecha_Factura], [Legajo_Empleado], [Borrado]) VALUES (9, N'C', 3, CAST(N'2021-11-03T07:21:17.670' AS DateTime), 1010, 0)
INSERT [dbo].[FACTURA_VENTA] ([Id_Factura], [Tipo_Factura], [Id_Cliente], [Fecha_Factura], [Legajo_Empleado], [Borrado]) VALUES (10, N'A', 2, CAST(N'2021-11-03T07:22:27.667' AS DateTime), 1011, 0)
INSERT [dbo].[FACTURA_VENTA] ([Id_Factura], [Tipo_Factura], [Id_Cliente], [Fecha_Factura], [Legajo_Empleado], [Borrado]) VALUES (11, N'A', 4, CAST(N'2021-11-03T07:23:23.733' AS DateTime), 1011, 0)
INSERT [dbo].[FACTURA_VENTA] ([Id_Factura], [Tipo_Factura], [Id_Cliente], [Fecha_Factura], [Legajo_Empleado], [Borrado]) VALUES (14, N'B', 2, CAST(N'2021-11-05T16:42:12.960' AS DateTime), 1010, 0)
INSERT [dbo].[FACTURA_VENTA] ([Id_Factura], [Tipo_Factura], [Id_Cliente], [Fecha_Factura], [Legajo_Empleado], [Borrado]) VALUES (15, N'A', 1, CAST(N'2021-11-08T11:44:01.867' AS DateTime), 1008, 0)
INSERT [dbo].[FACTURA_VENTA] ([Id_Factura], [Tipo_Factura], [Id_Cliente], [Fecha_Factura], [Legajo_Empleado], [Borrado]) VALUES (16, N'C', 1, CAST(N'2021-10-11T00:00:00.000' AS DateTime), 1011, 0)
INSERT [dbo].[FACTURA_VENTA] ([Id_Factura], [Tipo_Factura], [Id_Cliente], [Fecha_Factura], [Legajo_Empleado], [Borrado]) VALUES (17, N'A', 4, CAST(N'2021-08-08T00:00:00.000' AS DateTime), 1008, 0)
INSERT [dbo].[FACTURA_VENTA] ([Id_Factura], [Tipo_Factura], [Id_Cliente], [Fecha_Factura], [Legajo_Empleado], [Borrado]) VALUES (18, N'A', 2, CAST(N'2021-11-10T04:58:17.870' AS DateTime), 1009, 0)
SET IDENTITY_INSERT [dbo].[FACTURA_VENTA] OFF
GO
SET IDENTITY_INSERT [dbo].[FORMAS_PAGO] ON 

INSERT [dbo].[FORMAS_PAGO] ([Id_Forma_Pago], [Descripcion], [Borrado]) VALUES (1, N'Tarjeta de Crédito', 0)
INSERT [dbo].[FORMAS_PAGO] ([Id_Forma_Pago], [Descripcion], [Borrado]) VALUES (2, N'Efectivo', 0)
SET IDENTITY_INSERT [dbo].[FORMAS_PAGO] OFF
GO
SET IDENTITY_INSERT [dbo].[LOCALIDADES] ON 

INSERT [dbo].[LOCALIDADES] ([Id_Localidad], [Descripcion], [Borrado]) VALUES (1, N'Córdoba', 0)
INSERT [dbo].[LOCALIDADES] ([Id_Localidad], [Descripcion], [Borrado]) VALUES (2, N'Alta Gracia', 0)
INSERT [dbo].[LOCALIDADES] ([Id_Localidad], [Descripcion], [Borrado]) VALUES (3, N'Mina Clavero', 0)
INSERT [dbo].[LOCALIDADES] ([Id_Localidad], [Descripcion], [Borrado]) VALUES (4, N'Anisacate', 0)
INSERT [dbo].[LOCALIDADES] ([Id_Localidad], [Descripcion], [Borrado]) VALUES (5, N'La Falda', 0)
INSERT [dbo].[LOCALIDADES] ([Id_Localidad], [Descripcion], [Borrado]) VALUES (6, N'Despeñaderos', 0)
SET IDENTITY_INSERT [dbo].[LOCALIDADES] OFF
GO
SET IDENTITY_INSERT [dbo].[LOTE] ON 

INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (100, CAST(N'2021-10-10T00:00:00.000' AS DateTime), 100, 1009, 1, 39, 3, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (101, CAST(N'2021-10-10T00:00:00.000' AS DateTime), 200, 1010, 1, 123, 4, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (102, CAST(N'2021-10-10T00:00:00.000' AS DateTime), 200, 1009, 1, 80, 3, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1104, CAST(N'2021-11-02T00:00:00.000' AS DateTime), 0, 1008, 1, 500, 3, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1106, CAST(N'2021-11-02T00:00:00.000' AS DateTime), 0, 1012, 1, 250, 3, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1107, CAST(N'2021-11-02T00:00:00.000' AS DateTime), 0, 1012, 1, 100, 4, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1108, CAST(N'2021-11-02T00:00:00.000' AS DateTime), 0, 1010, 1, 150, 3, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1109, CAST(N'2021-11-02T00:00:00.000' AS DateTime), 0, 1009, 1, 90, 3, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1110, CAST(N'2021-11-02T00:00:00.000' AS DateTime), 0, 1010, 1, 50, 4, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1111, CAST(N'2021-11-02T00:00:00.000' AS DateTime), 0, 1010, 1, 230, 3, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1112, CAST(N'2021-11-02T00:00:00.000' AS DateTime), 0, 1010, 1, 140, 3, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1113, CAST(N'2021-11-03T00:00:00.000' AS DateTime), 0, 1011, 1, 200, 3, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1114, CAST(N'2021-11-03T00:00:00.000' AS DateTime), 0, 1009, 1, 120, 4, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1115, CAST(N'2021-11-10T00:00:00.000' AS DateTime), 100, 1009, 1, 90, 5, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1116, CAST(N'2021-11-10T00:00:00.000' AS DateTime), 100, 1009, 1, 100, 6, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1117, CAST(N'2021-11-10T00:00:00.000' AS DateTime), 100, 1009, 1, 90, 7, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1118, CAST(N'2021-11-10T00:00:00.000' AS DateTime), 100, 1009, 1, 100, 8, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1119, CAST(N'2021-11-10T00:00:00.000' AS DateTime), 100, 1009, 1, 100, 9, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1120, CAST(N'2021-11-10T00:00:00.000' AS DateTime), 150, 1009, 1, 150, 10, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1121, CAST(N'2021-11-10T00:00:00.000' AS DateTime), 200, 1010, 1, 200, 11, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1122, CAST(N'2021-11-10T00:00:00.000' AS DateTime), 100, 1010, 1, 100, 12, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1123, CAST(N'2021-11-10T00:00:00.000' AS DateTime), 130, 1010, 1, 120, 13, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1124, CAST(N'2021-11-10T00:00:00.000' AS DateTime), 140, 1010, 1, 140, 14, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1125, CAST(N'2021-11-10T00:00:00.000' AS DateTime), 150, 1010, 1, 140, 15, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1126, CAST(N'2021-11-10T00:00:00.000' AS DateTime), 160, 1010, 1, 160, 16, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1127, CAST(N'2021-11-10T00:00:00.000' AS DateTime), 170, 1010, 1, 160, 17, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1128, CAST(N'2021-11-10T00:00:00.000' AS DateTime), 180, 1010, 1, 180, 18, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1129, CAST(N'2021-11-10T00:00:00.000' AS DateTime), 190, 1010, 1, 190, 19, 0)
INSERT [dbo].[LOTE] ([Id_Lote], [Fecha_Lote], [Cantidad_Fabricada], [Legajo_Empleado], [Confirmacion_Lote], [Stock_Lote], [Id_Material], [Borrado]) VALUES (1130, CAST(N'2021-11-10T00:00:00.000' AS DateTime), 200, 1010, 1, 200, 20, 0)
SET IDENTITY_INSERT [dbo].[LOTE] OFF
GO
SET IDENTITY_INSERT [dbo].[MARCAS] ON 

INSERT [dbo].[MARCAS] ([Id_Marca], [Descripcion], [Borrado]) VALUES (1, N'Fiat', 0)
INSERT [dbo].[MARCAS] ([Id_Marca], [Descripcion], [Borrado]) VALUES (2, N'Ford', 0)
INSERT [dbo].[MARCAS] ([Id_Marca], [Descripcion], [Borrado]) VALUES (3, N'Peugeot', 0)
INSERT [dbo].[MARCAS] ([Id_Marca], [Descripcion], [Borrado]) VALUES (4, N'Chevrolet', 0)
INSERT [dbo].[MARCAS] ([Id_Marca], [Descripcion], [Borrado]) VALUES (5, N'BMW', 0)
INSERT [dbo].[MARCAS] ([Id_Marca], [Descripcion], [Borrado]) VALUES (6, N'Audi', 0)
INSERT [dbo].[MARCAS] ([Id_Marca], [Descripcion], [Borrado]) VALUES (7, N'Honda', 0)
INSERT [dbo].[MARCAS] ([Id_Marca], [Descripcion], [Borrado]) VALUES (8, N'Citroen', 0)
INSERT [dbo].[MARCAS] ([Id_Marca], [Descripcion], [Borrado]) VALUES (9, N'Toyota', 0)
INSERT [dbo].[MARCAS] ([Id_Marca], [Descripcion], [Borrado]) VALUES (10, N'Kia', 0)
INSERT [dbo].[MARCAS] ([Id_Marca], [Descripcion], [Borrado]) VALUES (11, N'Nissan', 0)
INSERT [dbo].[MARCAS] ([Id_Marca], [Descripcion], [Borrado]) VALUES (12, N'Suzuki', 0)
SET IDENTITY_INSERT [dbo].[MARCAS] OFF
GO
SET IDENTITY_INSERT [dbo].[MATERIALES] ON 

INSERT [dbo].[MATERIALES] ([Id_Material], [Nombre], [Stock], [Borrado], [Id_Marca], [Precio]) VALUES (3, N'Soporte Focus', 1049, 0, 2, CAST(2000.00 AS Decimal(10, 2)))
INSERT [dbo].[MATERIALES] ([Id_Material], [Nombre], [Stock], [Borrado], [Id_Marca], [Precio]) VALUES (4, N'Estribera PickUp', 258, 0, 2, CAST(2500.00 AS Decimal(10, 2)))
INSERT [dbo].[MATERIALES] ([Id_Material], [Nombre], [Stock], [Borrado], [Id_Marca], [Precio]) VALUES (5, N'Amortiguadores', 779, 0, 1, CAST(3450.00 AS Decimal(10, 2)))
INSERT [dbo].[MATERIALES] ([Id_Material], [Nombre], [Stock], [Borrado], [Id_Marca], [Precio]) VALUES (6, N'Kit Embrague Sachs', 461, 0, 4, CAST(9000.00 AS Decimal(10, 2)))
INSERT [dbo].[MATERIALES] ([Id_Material], [Nombre], [Stock], [Borrado], [Id_Marca], [Precio]) VALUES (7, N'Bomba de agua', 1990, 0, 3, CAST(3600.00 AS Decimal(10, 2)))
INSERT [dbo].[MATERIALES] ([Id_Material], [Nombre], [Stock], [Borrado], [Id_Marca], [Precio]) VALUES (8, N'Deposito Refrigerante', 1333, 0, 5, CAST(6200.00 AS Decimal(10, 2)))
INSERT [dbo].[MATERIALES] ([Id_Material], [Nombre], [Stock], [Borrado], [Id_Marca], [Precio]) VALUES (9, N'Motor Limpiabrisas', 607, 0, 5, CAST(1100.00 AS Decimal(10, 2)))
INSERT [dbo].[MATERIALES] ([Id_Material], [Nombre], [Stock], [Borrado], [Id_Marca], [Precio]) VALUES (10, N'Bomba de aceite', 1495, 0, 6, CAST(2855.00 AS Decimal(10, 2)))
INSERT [dbo].[MATERIALES] ([Id_Material], [Nombre], [Stock], [Borrado], [Id_Marca], [Precio]) VALUES (11, N'Embrague Centrifugo', 105, 0, 7, CAST(4200.00 AS Decimal(10, 2)))
INSERT [dbo].[MATERIALES] ([Id_Material], [Nombre], [Stock], [Borrado], [Id_Marca], [Precio]) VALUES (12, N'Rotula Inferior', 389, 0, 7, CAST(3400.00 AS Decimal(10, 2)))
INSERT [dbo].[MATERIALES] ([Id_Material], [Nombre], [Stock], [Borrado], [Id_Marca], [Precio]) VALUES (13, N'Guardabarro Delantero', 490, 0, 8, CAST(1500.00 AS Decimal(10, 2)))
INSERT [dbo].[MATERIALES] ([Id_Material], [Nombre], [Stock], [Borrado], [Id_Marca], [Precio]) VALUES (14, N'Soporte Paragolpe', 1777, 0, 9, CAST(1320.00 AS Decimal(10, 2)))
INSERT [dbo].[MATERIALES] ([Id_Material], [Nombre], [Stock], [Borrado], [Id_Marca], [Precio]) VALUES (15, N'Cruceta Direccion', 1224, 0, 9, CAST(2200.00 AS Decimal(10, 2)))
INSERT [dbo].[MATERIALES] ([Id_Material], [Nombre], [Stock], [Borrado], [Id_Marca], [Precio]) VALUES (16, N'Espejo Retroviso', 973, 0, 10, CAST(4470.00 AS Decimal(10, 2)))
INSERT [dbo].[MATERIALES] ([Id_Material], [Nombre], [Stock], [Borrado], [Id_Marca], [Precio]) VALUES (17, N'Valvulas', 1142, 0, 10, CAST(1700.00 AS Decimal(10, 2)))
INSERT [dbo].[MATERIALES] ([Id_Material], [Nombre], [Stock], [Borrado], [Id_Marca], [Precio]) VALUES (18, N'Carburador', 489, 0, 11, CAST(900.00 AS Decimal(10, 2)))
INSERT [dbo].[MATERIALES] ([Id_Material], [Nombre], [Stock], [Borrado], [Id_Marca], [Precio]) VALUES (19, N'Piston', 888, 0, 12, CAST(1250.00 AS Decimal(10, 2)))
INSERT [dbo].[MATERIALES] ([Id_Material], [Nombre], [Stock], [Borrado], [Id_Marca], [Precio]) VALUES (20, N'Escape Silenciador', 3450, 0, 12, CAST(5900.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[MATERIALES] OFF
GO
SET IDENTITY_INSERT [dbo].[PAGOS_X_FACTURA] ON 

INSERT [dbo].[PAGOS_X_FACTURA] ([Id_Pago_Factura], [Id_Factura], [Id_Forma_Pago], [Monto], [Nro_Tarjeta], [Cuotas], [Borrado]) VALUES (1, 14, 1, 4000, NULL, NULL, 0)
INSERT [dbo].[PAGOS_X_FACTURA] ([Id_Pago_Factura], [Id_Factura], [Id_Forma_Pago], [Monto], [Nro_Tarjeta], [Cuotas], [Borrado]) VALUES (2, 14, 2, 3000, NULL, NULL, 0)
INSERT [dbo].[PAGOS_X_FACTURA] ([Id_Pago_Factura], [Id_Factura], [Id_Forma_Pago], [Monto], [Nro_Tarjeta], [Cuotas], [Borrado]) VALUES (3, 15, 1, 60000, NULL, NULL, 0)
INSERT [dbo].[PAGOS_X_FACTURA] ([Id_Pago_Factura], [Id_Factura], [Id_Forma_Pago], [Monto], [Nro_Tarjeta], [Cuotas], [Borrado]) VALUES (4, 18, 2, 124500, NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[PAGOS_X_FACTURA] OFF
GO
SET IDENTITY_INSERT [dbo].[PERFILES] ON 

INSERT [dbo].[PERFILES] ([Id_Perfil], [Nombre], [Descripcion], [Borrado]) VALUES (1, N'Administrador', NULL, 0)
INSERT [dbo].[PERFILES] ([Id_Perfil], [Nombre], [Descripcion], [Borrado]) VALUES (2, N'Operador', NULL, 0)
INSERT [dbo].[PERFILES] ([Id_Perfil], [Nombre], [Descripcion], [Borrado]) VALUES (3, N'Vendedor', NULL, 0)
SET IDENTITY_INSERT [dbo].[PERFILES] OFF
GO
SET IDENTITY_INSERT [dbo].[PERSONAL] ON 

INSERT [dbo].[PERSONAL] ([Legajo], [Tipo_Doc], [Nro_Doc], [Nombre], [Apellido], [Telefono], [Calle], [Nro_Calle], [Id_Barrio], [Id_Usuario], [Borrado]) VALUES (1008, N'DNI', N'19787464', N'Ignacio', N'Mercado', N'3514623089', N'Duarte Quiros', N'1644', 1, 2, 0)
INSERT [dbo].[PERSONAL] ([Legajo], [Tipo_Doc], [Nro_Doc], [Nombre], [Apellido], [Telefono], [Calle], [Nro_Calle], [Id_Barrio], [Id_Usuario], [Borrado]) VALUES (1009, N'DNI', N'32789321', N'Matias', N'Ferre', N'3512297133', N'Avellaneda', N'839', 1, 1, 0)
INSERT [dbo].[PERSONAL] ([Legajo], [Tipo_Doc], [Nro_Doc], [Nombre], [Apellido], [Telefono], [Calle], [Nro_Calle], [Id_Barrio], [Id_Usuario], [Borrado]) VALUES (1010, N'DNI', N'40734690', N'Ivan', N'Berrettini', N'3510679124', N'25 de Mayo', N'25', 1, 3, 0)
INSERT [dbo].[PERSONAL] ([Legajo], [Tipo_Doc], [Nro_Doc], [Nombre], [Apellido], [Telefono], [Calle], [Nro_Calle], [Id_Barrio], [Id_Usuario], [Borrado]) VALUES (1011, N'DNI', N'27565331', N'Ignacio', N'Mongi', N'3511288734', N'Chacabuco', N'2461', 1, 4, 0)
INSERT [dbo].[PERSONAL] ([Legajo], [Tipo_Doc], [Nro_Doc], [Nombre], [Apellido], [Telefono], [Calle], [Nro_Calle], [Id_Barrio], [Id_Usuario], [Borrado]) VALUES (1012, N'DNI', N'38873198', N'Alejandro', N'Burgos', N'3519735012', N'20 de Junio', N'566', 1, 5, 0)
SET IDENTITY_INSERT [dbo].[PERSONAL] OFF
GO
SET IDENTITY_INSERT [dbo].[PROVEEDORESS] ON 

INSERT [dbo].[PROVEEDORESS] ([Id_Proveedor], [Nombre], [Telefono], [CUIT], [Calle], [Nro_Calle], [Id_Barrio], [Borrado]) VALUES (2, N'3M ARGENTINA', N'3517291023', N'20263512437', N'Colon', N'1600', 1, 0)
INSERT [dbo].[PROVEEDORESS] ([Id_Proveedor], [Nombre], [Telefono], [CUIT], [Calle], [Nro_Calle], [Id_Barrio], [Borrado]) VALUES (3, N'AFFINIA ARGENTINA', N'3512109926', N'20324812267', N'Santa Rosa', N'1238', 1, 0)
INSERT [dbo].[PROVEEDORESS] ([Id_Proveedor], [Nombre], [Telefono], [CUIT], [Calle], [Nro_Calle], [Id_Barrio], [Borrado]) VALUES (4, N'AIRCA', N'3517442106', N'20292143652', N'Urquiza', N'1865', 2, 0)
INSERT [dbo].[PROVEEDORESS] ([Id_Proveedor], [Nombre], [Telefono], [CUIT], [Calle], [Nro_Calle], [Id_Barrio], [Borrado]) VALUES (5, N'GIACOMELLI', N'35192123405', N'20354021952', N'Isabel La Catolica', N'890', 21, 0)
INSERT [dbo].[PROVEEDORESS] ([Id_Proveedor], [Nombre], [Telefono], [CUIT], [Calle], [Nro_Calle], [Id_Barrio], [Borrado]) VALUES (6, N'ALADDIN', N'3512102327', N'20322598372', N'25 de mayo', N'1100', 20, 0)
INSERT [dbo].[PROVEEDORESS] ([Id_Proveedor], [Nombre], [Telefono], [CUIT], [Calle], [Nro_Calle], [Id_Barrio], [Borrado]) VALUES (7, N'ACINDAR', N'3518221094', N'20188234542', N'25 de mayo', N'350', 9, 0)
SET IDENTITY_INSERT [dbo].[PROVEEDORESS] OFF
GO
SET IDENTITY_INSERT [dbo].[USUARIOS] ON 

INSERT [dbo].[USUARIOS] ([Id_Usuario], [Nombre_Usuario], [Contraseña_Usuario], [Fecha_Alta], [Id_Perfil], [Borrado]) VALUES (1, N'mati', N'1234', CAST(N'2021-09-18T00:00:00.000' AS DateTime), 2, 0)
INSERT [dbo].[USUARIOS] ([Id_Usuario], [Nombre_Usuario], [Contraseña_Usuario], [Fecha_Alta], [Id_Perfil], [Borrado]) VALUES (2, N'nacho', N'1234', CAST(N'2020-10-26T00:00:00.000' AS DateTime), 1, 0)
INSERT [dbo].[USUARIOS] ([Id_Usuario], [Nombre_Usuario], [Contraseña_Usuario], [Fecha_Alta], [Id_Perfil], [Borrado]) VALUES (3, N'ivan', N'1234', CAST(N'2020-01-06T00:00:00.000' AS DateTime), 3, 0)
INSERT [dbo].[USUARIOS] ([Id_Usuario], [Nombre_Usuario], [Contraseña_Usuario], [Fecha_Alta], [Id_Perfil], [Borrado]) VALUES (4, N'mongi', N'1234', CAST(N'2019-12-11T00:00:00.000' AS DateTime), 1, 0)
INSERT [dbo].[USUARIOS] ([Id_Usuario], [Nombre_Usuario], [Contraseña_Usuario], [Fecha_Alta], [Id_Perfil], [Borrado]) VALUES (5, N'vendedor', N'1234', CAST(N'2021-03-30T00:00:00.000' AS DateTime), 1, 0)
SET IDENTITY_INSERT [dbo].[USUARIOS] OFF
GO
ALTER TABLE [dbo].[PAGOS_X_FACTURA] ADD  DEFAULT ((0)) FOR [Borrado]
GO
ALTER TABLE [dbo].[BARRIOS]  WITH CHECK ADD  CONSTRAINT [FK_BARRIOS_LOCALIDADES] FOREIGN KEY([Id_Localidad])
REFERENCES [dbo].[LOCALIDADES] ([Id_Localidad])
GO
ALTER TABLE [dbo].[BARRIOS] CHECK CONSTRAINT [FK_BARRIOS_LOCALIDADES]
GO
ALTER TABLE [dbo].[CLIENTES]  WITH CHECK ADD  CONSTRAINT [FK_CLIENTES_BARRIOS] FOREIGN KEY([Id_Barrio])
REFERENCES [dbo].[BARRIOS] ([Id_Barrio])
GO
ALTER TABLE [dbo].[CLIENTES] CHECK CONSTRAINT [FK_CLIENTES_BARRIOS]
GO
ALTER TABLE [dbo].[DETALLE_FACTURA_COMPRAS]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_FACTURA_COMPRAS_FACTURA_COMPRA] FOREIGN KEY([Id_Factura])
REFERENCES [dbo].[FACTURA_COMPRA] ([Id_Factura])
GO
ALTER TABLE [dbo].[DETALLE_FACTURA_COMPRAS] CHECK CONSTRAINT [FK_DETALLE_FACTURA_COMPRAS_FACTURA_COMPRA]
GO
ALTER TABLE [dbo].[DETALLE_FACTURA_COMPRAS]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_FACTURA_COMPRAS_MATERIALES] FOREIGN KEY([Id_Material])
REFERENCES [dbo].[MATERIALES] ([Id_Material])
GO
ALTER TABLE [dbo].[DETALLE_FACTURA_COMPRAS] CHECK CONSTRAINT [FK_DETALLE_FACTURA_COMPRAS_MATERIALES]
GO
ALTER TABLE [dbo].[DETALLE_FACTURA_VENTAS]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_FACTURA_VENTAS_FACTURA_VENTA] FOREIGN KEY([Id_Factura])
REFERENCES [dbo].[FACTURA_VENTA] ([Id_Factura])
GO
ALTER TABLE [dbo].[DETALLE_FACTURA_VENTAS] CHECK CONSTRAINT [FK_DETALLE_FACTURA_VENTAS_FACTURA_VENTA]
GO
ALTER TABLE [dbo].[DETALLE_FACTURA_VENTAS]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_FACTURA_VENTAS_LOTE] FOREIGN KEY([Id_Lote])
REFERENCES [dbo].[LOTE] ([Id_Lote])
GO
ALTER TABLE [dbo].[DETALLE_FACTURA_VENTAS] CHECK CONSTRAINT [FK_DETALLE_FACTURA_VENTAS_LOTE]
GO
ALTER TABLE [dbo].[DETALLE_FACTURA_VENTAS]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_FACTURA_VENTAS_MATERIALES] FOREIGN KEY([Id_Material])
REFERENCES [dbo].[MATERIALES] ([Id_Material])
GO
ALTER TABLE [dbo].[DETALLE_FACTURA_VENTAS] CHECK CONSTRAINT [FK_DETALLE_FACTURA_VENTAS_MATERIALES]
GO
ALTER TABLE [dbo].[FACTURA_COMPRA]  WITH CHECK ADD  CONSTRAINT [FK_FACTURA_COMPRA_PROVEEDORESS] FOREIGN KEY([Id_Proveedor])
REFERENCES [dbo].[PROVEEDORESS] ([Id_Proveedor])
GO
ALTER TABLE [dbo].[FACTURA_COMPRA] CHECK CONSTRAINT [FK_FACTURA_COMPRA_PROVEEDORESS]
GO
ALTER TABLE [dbo].[FACTURA_VENTA]  WITH CHECK ADD  CONSTRAINT [FK_FACTURA_VENTA_CLIENTES] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[CLIENTES] ([Id_Cliente])
GO
ALTER TABLE [dbo].[FACTURA_VENTA] CHECK CONSTRAINT [FK_FACTURA_VENTA_CLIENTES]
GO
ALTER TABLE [dbo].[LOTE]  WITH CHECK ADD  CONSTRAINT [FK_LOTE_PERSONAL] FOREIGN KEY([Legajo_Empleado])
REFERENCES [dbo].[PERSONAL] ([Legajo])
GO
ALTER TABLE [dbo].[LOTE] CHECK CONSTRAINT [FK_LOTE_PERSONAL]
GO
ALTER TABLE [dbo].[MATERIALES]  WITH CHECK ADD  CONSTRAINT [FK_MATERIALES_MARCAS] FOREIGN KEY([Id_Marca])
REFERENCES [dbo].[MARCAS] ([Id_Marca])
GO
ALTER TABLE [dbo].[MATERIALES] CHECK CONSTRAINT [FK_MATERIALES_MARCAS]
GO
ALTER TABLE [dbo].[PAGOS_X_FACTURA]  WITH CHECK ADD  CONSTRAINT [pagos_fac_fk_factura] FOREIGN KEY([Id_Factura])
REFERENCES [dbo].[FACTURA_VENTA] ([Id_Factura])
GO
ALTER TABLE [dbo].[PAGOS_X_FACTURA] CHECK CONSTRAINT [pagos_fac_fk_factura]
GO
ALTER TABLE [dbo].[PAGOS_X_FACTURA]  WITH CHECK ADD  CONSTRAINT [pagos_fac_fk_forma_pago] FOREIGN KEY([Id_Forma_Pago])
REFERENCES [dbo].[FORMAS_PAGO] ([Id_Forma_Pago])
GO
ALTER TABLE [dbo].[PAGOS_X_FACTURA] CHECK CONSTRAINT [pagos_fac_fk_forma_pago]
GO
ALTER TABLE [dbo].[PERSONAL]  WITH CHECK ADD  CONSTRAINT [FK_PERSONAL_BARRIOS] FOREIGN KEY([Id_Barrio])
REFERENCES [dbo].[BARRIOS] ([Id_Barrio])
GO
ALTER TABLE [dbo].[PERSONAL] CHECK CONSTRAINT [FK_PERSONAL_BARRIOS]
GO
ALTER TABLE [dbo].[PERSONAL]  WITH CHECK ADD  CONSTRAINT [FK_PERSONAL_USUARIOS] FOREIGN KEY([Id_Usuario])
REFERENCES [dbo].[USUARIOS] ([Id_Usuario])
GO
ALTER TABLE [dbo].[PERSONAL] CHECK CONSTRAINT [FK_PERSONAL_USUARIOS]
GO
ALTER TABLE [dbo].[PROVEEDORESS]  WITH CHECK ADD  CONSTRAINT [FK_PROVEEDORESS_BARRIOS] FOREIGN KEY([Id_Barrio])
REFERENCES [dbo].[BARRIOS] ([Id_Barrio])
GO
ALTER TABLE [dbo].[PROVEEDORESS] CHECK CONSTRAINT [FK_PROVEEDORESS_BARRIOS]
GO
ALTER TABLE [dbo].[USUARIOS]  WITH CHECK ADD  CONSTRAINT [FK_USUARIOS_PERFILES] FOREIGN KEY([Id_Perfil])
REFERENCES [dbo].[PERFILES] ([Id_Perfil])
GO
ALTER TABLE [dbo].[USUARIOS] CHECK CONSTRAINT [FK_USUARIOS_PERFILES]
GO
USE [master]
GO
ALTER DATABASE [Proyecto_PAVI2021_2daVersion] SET  READ_WRITE 
GO
