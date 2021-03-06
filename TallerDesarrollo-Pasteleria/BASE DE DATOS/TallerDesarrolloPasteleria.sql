USE [master]
GO
/****** Object:  Database [DBTaller]    Script Date: 20/08/2020 20:54:59 ******/
CREATE DATABASE [DBTaller]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBTaller', FILENAME = N'D:\DATA\DBTaller.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBTaller_log', FILENAME = N'D:\DATA\DBTaller_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DBTaller] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBTaller].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBTaller] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBTaller] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBTaller] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBTaller] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBTaller] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBTaller] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBTaller] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBTaller] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBTaller] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBTaller] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBTaller] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBTaller] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBTaller] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBTaller] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBTaller] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBTaller] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBTaller] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBTaller] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBTaller] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBTaller] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBTaller] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBTaller] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBTaller] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DBTaller] SET  MULTI_USER 
GO
ALTER DATABASE [DBTaller] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBTaller] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBTaller] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBTaller] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DBTaller] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DBTaller]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 20/08/2020 20:54:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[ap_paterno] [varchar](50) NULL,
	[ap_materno] [varchar](50) NULL,
	[ci] [varchar](10) NULL,
	[telefono] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
 CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[det_producto]    Script Date: 20/08/2020 20:54:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[det_producto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_producto] [int] NOT NULL,
	[id_factura] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio_unitario] [float] NOT NULL,
	[subtotal] [float] NOT NULL,
 CONSTRAINT [PK_det_producto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[factura]    Script Date: 20/08/2020 20:54:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[factura](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nro] [bigint] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[total] [float] NOT NULL,
 CONSTRAINT [PK_factura] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[producto]    Script Date: 20/08/2020 20:54:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[producto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[precio_venta] [float] NULL,
	[tipo] [varchar](50) NULL,
	[stock] [int] NULL,
 CONSTRAINT [PK_producto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[reservacion]    Script Date: 20/08/2020 20:54:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[reservacion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NULL,
	[id_producto] [int] NULL,
	[horario] [time](7) NULL,
	[fecha] [date] NULL,
	[observacion] [varchar](50) NULL,
 CONSTRAINT [PK_reservacion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 20/08/2020 20:54:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[ap_paterno] [varchar](50) NULL,
	[ap_materno] [varchar](50) NULL,
	[ci] [varchar](15) NULL,
	[telefono] [varchar](20) NULL,
	[direccion] [varchar](100) NULL,
	[tipo] [varchar](50) NULL,
	[cuenta] [varchar](50) NULL,
	[pass] [varchar](256) NULL,
	[activo] [int] NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[cliente] ON 

GO
INSERT [dbo].[cliente] ([id], [nombre], [ap_paterno], [ap_materno], [ci], [telefono], [direccion]) VALUES (1, N'Alejandra', N'Fernandez', N'Perez', N'7454687', N'69876775', N'Bolivar y potosi')
GO
INSERT [dbo].[cliente] ([id], [nombre], [ap_paterno], [ap_materno], [ci], [telefono], [direccion]) VALUES (2, N'Luis', N'Martinez', N'Lino', N'3546879', N'60409889', N'Petot y murguia')
GO
INSERT [dbo].[cliente] ([id], [nombre], [ap_paterno], [ap_materno], [ci], [telefono], [direccion]) VALUES (3, N'Martha', N'Lima', N'Porrez', N'3677909', N'71467889', N'Aroma y La paz')
GO
INSERT [dbo].[cliente] ([id], [nombre], [ap_paterno], [ap_materno], [ci], [telefono], [direccion]) VALUES (4, N'Hilda', N'Meneses', N'Cabrera', N'3677339', N'71467009', N'Circunvalacion')
GO
SET IDENTITY_INSERT [dbo].[cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[det_producto] ON 

GO
INSERT [dbo].[det_producto] ([id], [id_producto], [id_factura], [cantidad], [precio_unitario], [subtotal]) VALUES (1, 2, 1, 4, 5, 20)
GO
INSERT [dbo].[det_producto] ([id], [id_producto], [id_factura], [cantidad], [precio_unitario], [subtotal]) VALUES (2, 5, 2, 1, 12, 12)
GO
INSERT [dbo].[det_producto] ([id], [id_producto], [id_factura], [cantidad], [precio_unitario], [subtotal]) VALUES (3, 3, 2, 3, 5, 15)
GO
INSERT [dbo].[det_producto] ([id], [id_producto], [id_factura], [cantidad], [precio_unitario], [subtotal]) VALUES (4, 5, 3, 1, 12, 12)
GO
INSERT [dbo].[det_producto] ([id], [id_producto], [id_factura], [cantidad], [precio_unitario], [subtotal]) VALUES (5, 3, 3, 5, 5, 25)
GO
SET IDENTITY_INSERT [dbo].[det_producto] OFF
GO
SET IDENTITY_INSERT [dbo].[factura] ON 

GO
INSERT [dbo].[factura] ([id], [nro], [id_cliente], [id_usuario], [fecha], [total]) VALUES (1, 99999, 1, 2, CAST(N'2020-08-20' AS Date), 20)
GO
INSERT [dbo].[factura] ([id], [nro], [id_cliente], [id_usuario], [fecha], [total]) VALUES (2, 99999, 2, 2, CAST(N'2020-08-20' AS Date), 27)
GO
INSERT [dbo].[factura] ([id], [nro], [id_cliente], [id_usuario], [fecha], [total]) VALUES (3, 99999, 4, 3, CAST(N'2020-08-20' AS Date), 37)
GO
SET IDENTITY_INSERT [dbo].[factura] OFF
GO
SET IDENTITY_INSERT [dbo].[producto] ON 

GO
INSERT [dbo].[producto] ([id], [nombre], [precio_venta], [tipo], [stock]) VALUES (1, N'Cupcakes de Chocolate', 5, N'Dulce', 20)
GO
INSERT [dbo].[producto] ([id], [nombre], [precio_venta], [tipo], [stock]) VALUES (2, N'Cupcake de Frutilla', 5, N'Dulce', 20)
GO
INSERT [dbo].[producto] ([id], [nombre], [precio_venta], [tipo], [stock]) VALUES (3, N'Cupcake de Vainilla', 5, N'Dulce', 20)
GO
INSERT [dbo].[producto] ([id], [nombre], [precio_venta], [tipo], [stock]) VALUES (4, N'Rosca Glaseada ', 18, N'Dulce', 5)
GO
INSERT [dbo].[producto] ([id], [nombre], [precio_venta], [tipo], [stock]) VALUES (5, N'Rollo de Queso', 12, N'Salado', 10)
GO
INSERT [dbo].[producto] ([id], [nombre], [precio_venta], [tipo], [stock]) VALUES (6, N'Queque de Naranja', 14, N'Dulce', 13)
GO
SET IDENTITY_INSERT [dbo].[producto] OFF
GO
SET IDENTITY_INSERT [dbo].[reservacion] ON 

GO
INSERT [dbo].[reservacion] ([id], [id_cliente], [id_producto], [horario], [fecha], [observacion]) VALUES (5, 1, 1, CAST(N'11:30:00' AS Time), CAST(N'2020-08-22' AS Date), N'Ninguna')
GO
INSERT [dbo].[reservacion] ([id], [id_cliente], [id_producto], [horario], [fecha], [observacion]) VALUES (8, 1, 1, CAST(N'12:30:00' AS Time), CAST(N'2020-08-29' AS Date), N'5')
GO
INSERT [dbo].[reservacion] ([id], [id_cliente], [id_producto], [horario], [fecha], [observacion]) VALUES (12, 2, 1, CAST(N'11:30:00' AS Time), CAST(N'2020-08-24' AS Date), N'RESERVACION CANCELADA')
GO
INSERT [dbo].[reservacion] ([id], [id_cliente], [id_producto], [horario], [fecha], [observacion]) VALUES (13, 3, 3, CAST(N'16:30:00' AS Time), CAST(N'2020-08-29' AS Date), N'10')
GO
INSERT [dbo].[reservacion] ([id], [id_cliente], [id_producto], [horario], [fecha], [observacion]) VALUES (14, 3, 4, CAST(N'09:30:00' AS Time), CAST(N'2020-08-30' AS Date), N'12')
GO
SET IDENTITY_INSERT [dbo].[reservacion] OFF
GO
SET IDENTITY_INSERT [dbo].[usuario] ON 

GO
INSERT [dbo].[usuario] ([id], [nombre], [ap_paterno], [ap_materno], [ci], [telefono], [direccion], [tipo], [cuenta], [pass], [activo]) VALUES (1, N'Jorge', N'Fernandez', N'Montecinos', N'7665453', N'61478990', N'Bolivar y 6 de octubre', N'Administrador', N'jefeprod', N'123', 1)
GO
INSERT [dbo].[usuario] ([id], [nombre], [ap_paterno], [ap_materno], [ci], [telefono], [direccion], [tipo], [cuenta], [pass], [activo]) VALUES (2, N'Saul', N'Terrazas', N'Perez', N'7345676', N'71433876', N'Petot y Murguia', N'Cajero', N'vendedor1', N'123', 1)
GO
INSERT [dbo].[usuario] ([id], [nombre], [ap_paterno], [ap_materno], [ci], [telefono], [direccion], [tipo], [cuenta], [pass], [activo]) VALUES (3, N'Teresa', N'Yucra', N'Villarroel', N'7454676', N'60590998', N'6 de octubre y bolivar', N'Cajero', N'vendedor2', N'1234', 1)
GO
SET IDENTITY_INSERT [dbo].[usuario] OFF
GO
ALTER TABLE [dbo].[det_producto]  WITH CHECK ADD  CONSTRAINT [FK_det_producto_factura] FOREIGN KEY([id_factura])
REFERENCES [dbo].[factura] ([id])
GO
ALTER TABLE [dbo].[det_producto] CHECK CONSTRAINT [FK_det_producto_factura]
GO
ALTER TABLE [dbo].[det_producto]  WITH CHECK ADD  CONSTRAINT [FK_det_producto_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[producto] ([id])
GO
ALTER TABLE [dbo].[det_producto] CHECK CONSTRAINT [FK_det_producto_producto]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK_factura_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[cliente] ([id])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK_factura_cliente]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK_factura_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuario] ([id])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK_factura_usuario]
GO
ALTER TABLE [dbo].[reservacion]  WITH CHECK ADD  CONSTRAINT [FK_reservacion_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[cliente] ([id])
GO
ALTER TABLE [dbo].[reservacion] CHECK CONSTRAINT [FK_reservacion_cliente]
GO
ALTER TABLE [dbo].[reservacion]  WITH CHECK ADD  CONSTRAINT [FK_reservacion_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[det_producto] ([id])
GO
ALTER TABLE [dbo].[reservacion] CHECK CONSTRAINT [FK_reservacion_producto]
GO
USE [master]
GO
ALTER DATABASE [DBTaller] SET  READ_WRITE 
GO
