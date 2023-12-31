USE [tarjetasCredito]
GO
/****** Object:  StoredProcedure [dbo].[sp_insertarTransaccion]    Script Date: 8/13/2023 8:22:42 PM ******/
DROP PROCEDURE [dbo].[sp_insertarTransaccion]
GO
/****** Object:  StoredProcedure [dbo].[sp_insertarTarjeta]    Script Date: 8/13/2023 8:22:42 PM ******/
DROP PROCEDURE [dbo].[sp_insertarTarjeta]
GO
/****** Object:  StoredProcedure [dbo].[sp_datosTransaccion]    Script Date: 8/13/2023 8:22:42 PM ******/
DROP PROCEDURE [dbo].[sp_datosTransaccion]
GO
/****** Object:  StoredProcedure [dbo].[sp_datosCliente]    Script Date: 8/13/2023 8:22:42 PM ******/
DROP PROCEDURE [dbo].[sp_datosCliente]
GO
ALTER TABLE [dbo].[transaccion] DROP CONSTRAINT [FK__transacci__idTar__49C3F6B7]
GO
/****** Object:  Table [dbo].[transaccion]    Script Date: 8/13/2023 8:22:42 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[transaccion]') AND type in (N'U'))
DROP TABLE [dbo].[transaccion]
GO
/****** Object:  Table [dbo].[tarjeta]    Script Date: 8/13/2023 8:22:42 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tarjeta]') AND type in (N'U'))
DROP TABLE [dbo].[tarjeta]
GO
USE [master]
GO
/****** Object:  Database [tarjetasCredito]    Script Date: 8/13/2023 8:22:42 PM ******/
DROP DATABASE [tarjetasCredito]
GO
/****** Object:  Database [tarjetasCredito]    Script Date: 8/13/2023 8:22:42 PM ******/
CREATE DATABASE [tarjetasCredito]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'tarjetasCredito', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\tarjetasCredito.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'tarjetasCredito_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\tarjetasCredito_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [tarjetasCredito] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [tarjetasCredito].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [tarjetasCredito] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [tarjetasCredito] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [tarjetasCredito] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [tarjetasCredito] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [tarjetasCredito] SET ARITHABORT OFF 
GO
ALTER DATABASE [tarjetasCredito] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [tarjetasCredito] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [tarjetasCredito] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [tarjetasCredito] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [tarjetasCredito] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [tarjetasCredito] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [tarjetasCredito] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [tarjetasCredito] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [tarjetasCredito] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [tarjetasCredito] SET  DISABLE_BROKER 
GO
ALTER DATABASE [tarjetasCredito] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [tarjetasCredito] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [tarjetasCredito] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [tarjetasCredito] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [tarjetasCredito] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [tarjetasCredito] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [tarjetasCredito] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [tarjetasCredito] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [tarjetasCredito] SET  MULTI_USER 
GO
ALTER DATABASE [tarjetasCredito] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [tarjetasCredito] SET DB_CHAINING OFF 
GO
ALTER DATABASE [tarjetasCredito] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [tarjetasCredito] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [tarjetasCredito] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [tarjetasCredito] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [tarjetasCredito] SET QUERY_STORE = ON
GO
ALTER DATABASE [tarjetasCredito] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [tarjetasCredito]
GO
/****** Object:  Table [dbo].[tarjeta]    Script Date: 8/13/2023 8:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tarjeta](
	[idCliente] [int] NULL,
	[numeroTarjeta] [nchar](16) NULL,
	[fechaexpira] [date] NULL,
	[cvv] [int] NULL,
	[cupoAutorizado] [decimal](18, 0) NULL,
	[cupoUtilizado] [decimal](18, 0) NULL,
	[cupoDisponible] [decimal](18, 0) NULL,
	[idTarjeta] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [pk_idTarjeta] PRIMARY KEY CLUSTERED 
(
	[idTarjeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transaccion]    Script Date: 8/13/2023 8:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transaccion](
	[idProducto] [int] NULL,
	[fecha] [date] NULL,
	[producto] [nchar](20) NULL,
	[valor] [decimal](18, 2) NULL,
	[idTransaccion] [int] IDENTITY(1,1) NOT NULL,
	[idTarjeta] [int] NOT NULL,
 CONSTRAINT [pk_idTransaccion] PRIMARY KEY CLUSTERED 
(
	[idTransaccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tarjeta] ON 

INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (1, N'123456          ', CAST(N'2023-02-02' AS Date), 144, CAST(12 AS Decimal(18, 0)), CAST(12 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 10)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (1, N'1000036752700386', CAST(N'2023-08-12' AS Date), 144, CAST(12 AS Decimal(18, 0)), CAST(12 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 11)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (1, N'1000061718008249', CAST(N'2023-03-13' AS Date), 144, CAST(12 AS Decimal(18, 0)), CAST(12 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 12)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (1, N'1000063701918341', CAST(N'2022-11-23' AS Date), 144, CAST(12 AS Decimal(18, 0)), CAST(12 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 13)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (1, N'1000045640202671', CAST(N'2023-03-17' AS Date), 144, CAST(12 AS Decimal(18, 0)), CAST(12 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 14)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (1, N'1000071506384416', CAST(N'2022-08-13' AS Date), 144, CAST(12 AS Decimal(18, 0)), CAST(12 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 15)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (0, N'1000034883247338', CAST(N'2023-08-07' AS Date), 629, CAST(723 AS Decimal(18, 0)), CAST(149 AS Decimal(18, 0)), CAST(574 AS Decimal(18, 0)), 16)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (0, N'1000075793403406', CAST(N'2023-01-26' AS Date), 657, CAST(127 AS Decimal(18, 0)), CAST(117 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)), 17)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (0, N'1000006684415678', CAST(N'2022-11-22' AS Date), 323, CAST(417 AS Decimal(18, 0)), CAST(191 AS Decimal(18, 0)), CAST(226 AS Decimal(18, 0)), 18)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (0, N'1000007146812016', CAST(N'2023-03-21' AS Date), 944, CAST(302 AS Decimal(18, 0)), CAST(207 AS Decimal(18, 0)), CAST(95 AS Decimal(18, 0)), 19)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (1, N'1000071506384416', CAST(N'2022-08-13' AS Date), 144, CAST(12 AS Decimal(18, 0)), CAST(12 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 20)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (1, N'1000071506384416', CAST(N'2022-08-13' AS Date), 144, CAST(12 AS Decimal(18, 0)), CAST(12 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 21)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (0, N'1000073356871659', CAST(N'2023-01-03' AS Date), 769, CAST(872 AS Decimal(18, 0)), CAST(199 AS Decimal(18, 0)), CAST(673 AS Decimal(18, 0)), 22)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (1, N'1000063265369379', CAST(N'2023-04-11' AS Date), 401, CAST(564 AS Decimal(18, 0)), CAST(31 AS Decimal(18, 0)), CAST(533 AS Decimal(18, 0)), 23)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (1, N'1000084466998465', CAST(N'2022-08-29' AS Date), 821, CAST(360 AS Decimal(18, 0)), CAST(100 AS Decimal(18, 0)), CAST(260 AS Decimal(18, 0)), 24)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (1, N'1000021948093443', CAST(N'2023-05-22' AS Date), 541, CAST(803 AS Decimal(18, 0)), CAST(235 AS Decimal(18, 0)), CAST(568 AS Decimal(18, 0)), 25)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (1, N'1000064811064986', CAST(N'2022-09-24' AS Date), 949, CAST(91 AS Decimal(18, 0)), CAST(73 AS Decimal(18, 0)), CAST(18 AS Decimal(18, 0)), 26)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (1, N'1000073591543869', CAST(N'2022-11-22' AS Date), 467, CAST(366 AS Decimal(18, 0)), CAST(321 AS Decimal(18, 0)), CAST(45 AS Decimal(18, 0)), 27)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (1, N'1000032031704485', CAST(N'2023-03-15' AS Date), 520, CAST(468 AS Decimal(18, 0)), CAST(81 AS Decimal(18, 0)), CAST(387 AS Decimal(18, 0)), 28)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (1, N'1000058882450919', CAST(N'2022-12-11' AS Date), 151, CAST(599 AS Decimal(18, 0)), CAST(65 AS Decimal(18, 0)), CAST(534 AS Decimal(18, 0)), 29)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (1, N'1000072014781275', CAST(N'2022-11-10' AS Date), 767, CAST(955 AS Decimal(18, 0)), CAST(147 AS Decimal(18, 0)), CAST(808 AS Decimal(18, 0)), 30)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (1, N'1000046468423746', CAST(N'2022-09-02' AS Date), 111, CAST(503 AS Decimal(18, 0)), CAST(94 AS Decimal(18, 0)), CAST(409 AS Decimal(18, 0)), 31)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (1, N'1000025811508455', CAST(N'2023-04-03' AS Date), 499, CAST(491 AS Decimal(18, 0)), CAST(8 AS Decimal(18, 0)), CAST(483 AS Decimal(18, 0)), 32)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (1, N'1000030720441346', CAST(N'2022-09-07' AS Date), 676, CAST(682 AS Decimal(18, 0)), CAST(576 AS Decimal(18, 0)), CAST(106 AS Decimal(18, 0)), 33)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (1, N'1000043680394735', CAST(N'2022-12-11' AS Date), 138, CAST(748 AS Decimal(18, 0)), CAST(185 AS Decimal(18, 0)), CAST(563 AS Decimal(18, 0)), 34)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (1, N'1000071506384416', CAST(N'2022-08-13' AS Date), 144, CAST(12 AS Decimal(18, 0)), CAST(12 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 35)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (1, N'1000065437320229', CAST(N'2022-10-13' AS Date), 216, CAST(352 AS Decimal(18, 0)), CAST(29 AS Decimal(18, 0)), CAST(323 AS Decimal(18, 0)), 36)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (2, N'1234            ', CAST(N'2010-02-02' AS Date), 166, CAST(690 AS Decimal(18, 0)), CAST(900 AS Decimal(18, 0)), CAST(900 AS Decimal(18, 0)), 37)
INSERT [dbo].[tarjeta] ([idCliente], [numeroTarjeta], [fechaexpira], [cvv], [cupoAutorizado], [cupoUtilizado], [cupoDisponible], [idTarjeta]) VALUES (3, N'444444          ', CAST(N'2016-02-06' AS Date), 666, CAST(95 AS Decimal(18, 0)), CAST(955 AS Decimal(18, 0)), CAST(955 AS Decimal(18, 0)), 38)
SET IDENTITY_INSERT [dbo].[tarjeta] OFF
GO
SET IDENTITY_INSERT [dbo].[transaccion] ON 

INSERT [dbo].[transaccion] ([idProducto], [fecha], [producto], [valor], [idTransaccion], [idTarjeta]) VALUES (1, CAST(N'2022-02-02' AS Date), N'producto1           ', CAST(39.50 AS Decimal(18, 2)), 1, 31)
INSERT [dbo].[transaccion] ([idProducto], [fecha], [producto], [valor], [idTransaccion], [idTarjeta]) VALUES (1, CAST(N'2021-01-05' AS Date), N'producto1           ', CAST(14.25 AS Decimal(18, 2)), 2, 32)
INSERT [dbo].[transaccion] ([idProducto], [fecha], [producto], [valor], [idTransaccion], [idTarjeta]) VALUES (2, CAST(N'2023-01-01' AS Date), N'producto2           ', CAST(35.62 AS Decimal(18, 2)), 3, 31)
INSERT [dbo].[transaccion] ([idProducto], [fecha], [producto], [valor], [idTransaccion], [idTarjeta]) VALUES (2, CAST(N'2023-01-01' AS Date), N'producto2           ', CAST(35.62 AS Decimal(18, 2)), 4, 31)
INSERT [dbo].[transaccion] ([idProducto], [fecha], [producto], [valor], [idTransaccion], [idTarjeta]) VALUES (2, CAST(N'2023-01-01' AS Date), N'producto2           ', CAST(35.62 AS Decimal(18, 2)), 5, 31)
INSERT [dbo].[transaccion] ([idProducto], [fecha], [producto], [valor], [idTransaccion], [idTarjeta]) VALUES (1, CAST(N'2022-02-02' AS Date), N'producto1           ', CAST(39.50 AS Decimal(18, 2)), 6, 35)
INSERT [dbo].[transaccion] ([idProducto], [fecha], [producto], [valor], [idTransaccion], [idTarjeta]) VALUES (1, CAST(N'2022-02-02' AS Date), N'producto1           ', CAST(0.50 AS Decimal(18, 2)), 7, 35)
INSERT [dbo].[transaccion] ([idProducto], [fecha], [producto], [valor], [idTransaccion], [idTarjeta]) VALUES (0, CAST(N'2023-08-13' AS Date), N'                    ', CAST(0.00 AS Decimal(18, 2)), 8, 20)
INSERT [dbo].[transaccion] ([idProducto], [fecha], [producto], [valor], [idTransaccion], [idTarjeta]) VALUES (0, CAST(N'2023-08-13' AS Date), N'                    ', CAST(0.00 AS Decimal(18, 2)), 9, 20)
INSERT [dbo].[transaccion] ([idProducto], [fecha], [producto], [valor], [idTransaccion], [idTarjeta]) VALUES (0, CAST(N'2023-08-13' AS Date), N'                    ', CAST(0.00 AS Decimal(18, 2)), 10, 13)
INSERT [dbo].[transaccion] ([idProducto], [fecha], [producto], [valor], [idTransaccion], [idTarjeta]) VALUES (0, CAST(N'2023-08-13' AS Date), N'                    ', CAST(0.00 AS Decimal(18, 2)), 11, 26)
INSERT [dbo].[transaccion] ([idProducto], [fecha], [producto], [valor], [idTransaccion], [idTarjeta]) VALUES (0, CAST(N'2023-08-13' AS Date), N'                    ', CAST(0.00 AS Decimal(18, 2)), 12, 24)
INSERT [dbo].[transaccion] ([idProducto], [fecha], [producto], [valor], [idTransaccion], [idTarjeta]) VALUES (0, CAST(N'2023-08-13' AS Date), N'                    ', CAST(0.00 AS Decimal(18, 2)), 13, 37)
INSERT [dbo].[transaccion] ([idProducto], [fecha], [producto], [valor], [idTransaccion], [idTarjeta]) VALUES (0, CAST(N'2023-08-13' AS Date), N'                    ', CAST(0.00 AS Decimal(18, 2)), 14, 37)
INSERT [dbo].[transaccion] ([idProducto], [fecha], [producto], [valor], [idTransaccion], [idTarjeta]) VALUES (0, CAST(N'2023-08-13' AS Date), N'                    ', CAST(0.00 AS Decimal(18, 2)), 15, 23)
INSERT [dbo].[transaccion] ([idProducto], [fecha], [producto], [valor], [idTransaccion], [idTarjeta]) VALUES (0, CAST(N'2023-08-13' AS Date), N'                    ', CAST(0.00 AS Decimal(18, 2)), 16, 14)
INSERT [dbo].[transaccion] ([idProducto], [fecha], [producto], [valor], [idTransaccion], [idTarjeta]) VALUES (1, CAST(N'2023-08-13' AS Date), N'FJALLRAVEN - FOLDSAC', CAST(0.00 AS Decimal(18, 2)), 17, 36)
INSERT [dbo].[transaccion] ([idProducto], [fecha], [producto], [valor], [idTransaccion], [idTarjeta]) VALUES (1, CAST(N'2023-08-13' AS Date), N'FJALLRAVEN - FOLDSAC', CAST(109.95 AS Decimal(18, 2)), 18, 36)
INSERT [dbo].[transaccion] ([idProducto], [fecha], [producto], [valor], [idTransaccion], [idTarjeta]) VALUES (14, CAST(N'2023-08-13' AS Date), N'SAMSUNG 49-INCH CHG9', CAST(1109.94 AS Decimal(18, 2)), 19, 36)
INSERT [dbo].[transaccion] ([idProducto], [fecha], [producto], [valor], [idTransaccion], [idTarjeta]) VALUES (1, CAST(N'2023-08-13' AS Date), N'FJALLRAVEN - FOLDSAC', CAST(109.95 AS Decimal(18, 2)), 20, 35)
SET IDENTITY_INSERT [dbo].[transaccion] OFF
GO
ALTER TABLE [dbo].[transaccion]  WITH CHECK ADD FOREIGN KEY([idTarjeta])
REFERENCES [dbo].[tarjeta] ([idTarjeta])
GO
/****** Object:  StoredProcedure [dbo].[sp_datosCliente]    Script Date: 8/13/2023 8:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[sp_datosCliente]
(
@id int
)
as
select *
from tarjeta
where idCliente = @id
GO
/****** Object:  StoredProcedure [dbo].[sp_datosTransaccion]    Script Date: 8/13/2023 8:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[sp_datosTransaccion]
@idCliente int
as
select t.idTransaccion, t.idTarjeta ,t.idProducto, t.fecha, t.producto, t.valor 
from transaccion t
join tarjeta ta
on t.idTarjeta = ta.idTarjeta
and ta.idCliente = @idCliente
GO
/****** Object:  StoredProcedure [dbo].[sp_insertarTarjeta]    Script Date: 8/13/2023 8:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[sp_insertarTarjeta]
(
@idCliente	    int     ,
@numeroTarjeta  nchar(16)     ,
@fechaexpira     date    ,
@cvv		      int   ,
@cupoAutorizado   money   ,
@cupoUtilizado    money   ,
@cupoDisponible	  money
)
as
insert into
tarjeta
values 
(
	@idCliente	   ,
	
	@numeroTarjeta ,
	@fechaexpira   ,
	@cvv		   ,
	@cupoAutorizado,
	@cupoUtilizado ,
	@cupoDisponible

);
GO
/****** Object:  StoredProcedure [dbo].[sp_insertarTransaccion]    Script Date: 8/13/2023 8:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[sp_insertarTransaccion]
(
@idTarjeta			int,
@idProducto			 int, 
@fecha				date,
@producto			nchar(20),
@valor				money
)
as
insert into transaccion
values
(

@idProducto	 ,
@fecha		 ,
@producto	 ,
@valor		,
@idTarjeta	 
)
GO
USE [master]
GO
ALTER DATABASE [tarjetasCredito] SET  READ_WRITE 
GO
