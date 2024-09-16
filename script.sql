USE [master]
GO
/****** Object:  Database [cihaz_atama]    Script Date: 16.09.2024 10:01:22 ******/
CREATE DATABASE [cihaz_atama]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'cihaz_atama', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\cihaz_atama.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'cihaz_atama_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\cihaz_atama_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [cihaz_atama] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cihaz_atama].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cihaz_atama] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [cihaz_atama] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [cihaz_atama] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cihaz_atama] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [cihaz_atama] SET ARITHABORT OFF 
GO
ALTER DATABASE [cihaz_atama] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [cihaz_atama] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [cihaz_atama] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [cihaz_atama] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [cihaz_atama] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cihaz_atama] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cihaz_atama] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cihaz_atama] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cihaz_atama] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cihaz_atama] SET  ENABLE_BROKER 
GO
ALTER DATABASE [cihaz_atama] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [cihaz_atama] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [cihaz_atama] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [cihaz_atama] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [cihaz_atama] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [cihaz_atama] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [cihaz_atama] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [cihaz_atama] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [cihaz_atama] SET  MULTI_USER 
GO
ALTER DATABASE [cihaz_atama] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cihaz_atama] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cihaz_atama] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cihaz_atama] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [cihaz_atama] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [cihaz_atama] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [cihaz_atama] SET QUERY_STORE = ON
GO
ALTER DATABASE [cihaz_atama] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [cihaz_atama]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 16.09.2024 10:01:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 16.09.2024 10:01:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[AdminId] [int] IDENTITY(1,1) NOT NULL,
	[AdminEposta] [nvarchar](max) NOT NULL,
	[Sifre] [nvarchar](max) NOT NULL,
	[Yetki] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Admins] PRIMARY KEY CLUSTERED 
(
	[AdminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CihazAtamas]    Script Date: 16.09.2024 10:01:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CihazAtamas](
	[AtamaId] [int] IDENTITY(1,1) NOT NULL,
	[PersonelId] [int] NULL,
	[CihazId] [int] NULL,
	[AtamaTarihi] [datetime2](7) NULL,
	[DepartmanID] [int] NULL,
 CONSTRAINT [PK_CihazAtamas] PRIMARY KEY CLUSTERED 
(
	[AtamaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cihazs]    Script Date: 16.09.2024 10:01:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cihazs](
	[CihazId] [int] IDENTITY(1,1) NOT NULL,
	[CihazAdi] [nvarchar](max) NULL,
	[CihazModel] [nvarchar](max) NULL,
	[CihazSeriNo] [nvarchar](max) NULL,
	[IsAssigned] [bit] NOT NULL,
 CONSTRAINT [PK_Cihazs] PRIMARY KEY CLUSTERED 
(
	[CihazId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departmans]    Script Date: 16.09.2024 10:01:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departmans](
	[DepartmanID] [int] IDENTITY(1,1) NOT NULL,
	[DepartmanAdi] [nvarchar](max) NULL,
 CONSTRAINT [PK_Departmans] PRIMARY KEY CLUSTERED 
(
	[DepartmanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeviceStatusViewModels]    Script Date: 16.09.2024 10:01:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeviceStatusViewModels](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Durum] [nvarchar](max) NOT NULL,
	[CihazId] [int] NOT NULL,
 CONSTRAINT [PK_DeviceStatusViewModels] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personels]    Script Date: 16.09.2024 10:01:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personels](
	[PersonelId] [int] IDENTITY(1,1) NOT NULL,
	[PersonelAd] [nvarchar](max) NULL,
	[PersonelSoyad] [nvarchar](max) NULL,
	[DepartmanID] [int] NULL,
	[PersonelEposta] [nvarchar](max) NULL,
	[PersonelTel] [nvarchar](max) NULL,
	[FotoğrafYolu] [nvarchar](max) NULL,
 CONSTRAINT [PK_Personels] PRIMARY KEY CLUSTERED 
(
	[PersonelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240902103645_first', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240902113621_second', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240902120759_hata', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240902121334_hata2', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240902121803_deneme', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240902123005_cozum', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240904072931_yenitablo', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240904080813_isassigned', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240904100503_son', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240904132402_dprtmn', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240909081611_mgr', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240914184606_foto', N'8.0.8')
GO
SET IDENTITY_INSERT [dbo].[Admins] ON 

INSERT [dbo].[Admins] ([AdminId], [AdminEposta], [Sifre], [Yetki]) VALUES (1, N'duygu@gmail.com', N'123456', N'admin')
INSERT [dbo].[Admins] ([AdminId], [AdminEposta], [Sifre], [Yetki]) VALUES (3, N'nazli@gmail.com', N'123456', N'admin')
SET IDENTITY_INSERT [dbo].[Admins] OFF
GO
SET IDENTITY_INSERT [dbo].[CihazAtamas] ON 

INSERT [dbo].[CihazAtamas] ([AtamaId], [PersonelId], [CihazId], [AtamaTarihi], [DepartmanID]) VALUES (24, 1, 10, CAST(N'2024-09-10T10:12:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[CihazAtamas] ([AtamaId], [PersonelId], [CihazId], [AtamaTarihi], [DepartmanID]) VALUES (25, 13, 12, CAST(N'2024-09-06T11:12:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[CihazAtamas] ([AtamaId], [PersonelId], [CihazId], [AtamaTarihi], [DepartmanID]) VALUES (26, 18, 17, CAST(N'2024-08-02T16:01:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[CihazAtamas] ([AtamaId], [PersonelId], [CihazId], [AtamaTarihi], [DepartmanID]) VALUES (27, 15, 16, CAST(N'2024-10-02T09:10:00.0000000' AS DateTime2), NULL)
SET IDENTITY_INSERT [dbo].[CihazAtamas] OFF
GO
SET IDENTITY_INSERT [dbo].[Cihazs] ON 

INSERT [dbo].[Cihazs] ([CihazId], [CihazAdi], [CihazModel], [CihazSeriNo], [IsAssigned]) VALUES (10, N'Apple MacBook ', N'MacBook Pro 16', N'MBP16-2024-00234', 0)
INSERT [dbo].[Cihazs] ([CihazId], [CihazAdi], [CihazModel], [CihazSeriNo], [IsAssigned]) VALUES (11, N'HP Laptop', N'HP Spectre x360', N'HPSX360-2024-00456', 0)
INSERT [dbo].[Cihazs] ([CihazId], [CihazAdi], [CihazModel], [CihazSeriNo], [IsAssigned]) VALUES (12, N'Dell Laptop', N'Dell Latitude 7420', N' DL7420-2024-01123', 0)
INSERT [dbo].[Cihazs] ([CihazId], [CihazAdi], [CihazModel], [CihazSeriNo], [IsAssigned]) VALUES (14, N'Asus Laptop', N' ASUS ZenBook 14', N'ZB14-2024-1122', 0)
INSERT [dbo].[Cihazs] ([CihazId], [CihazAdi], [CihazModel], [CihazSeriNo], [IsAssigned]) VALUES (15, N'Apple MacBook ', N'Apple MacBook Pro 16', N' MBP16-2024-9876', 0)
INSERT [dbo].[Cihazs] ([CihazId], [CihazAdi], [CihazModel], [CihazSeriNo], [IsAssigned]) VALUES (16, N'Acer', N'Acer Predator Helios 300', N'APH300-2024-0007', 0)
INSERT [dbo].[Cihazs] ([CihazId], [CihazAdi], [CihazModel], [CihazSeriNo], [IsAssigned]) VALUES (17, N'Samsung', N' Samsung Galaxy Book Pro 360', N'SGBP360-2024-0008', 0)
INSERT [dbo].[Cihazs] ([CihazId], [CihazAdi], [CihazModel], [CihazSeriNo], [IsAssigned]) VALUES (18, N'Toshiba', N'Toshiba Portege X30', N'TPX30-2024-0010', 0)
INSERT [dbo].[Cihazs] ([CihazId], [CihazAdi], [CihazModel], [CihazSeriNo], [IsAssigned]) VALUES (19, N'HP Laptop', N' HP EliteBook 850 G7', N'SN987654321', 0)
SET IDENTITY_INSERT [dbo].[Cihazs] OFF
GO
SET IDENTITY_INSERT [dbo].[Departmans] ON 

INSERT [dbo].[Departmans] ([DepartmanID], [DepartmanAdi]) VALUES (1, N'Bilgi İşlem')
INSERT [dbo].[Departmans] ([DepartmanID], [DepartmanAdi]) VALUES (2, N'Elektrik')
INSERT [dbo].[Departmans] ([DepartmanID], [DepartmanAdi]) VALUES (3, N'Kontrol Otomasyon')
INSERT [dbo].[Departmans] ([DepartmanID], [DepartmanAdi]) VALUES (4, N'Satın Alma')
INSERT [dbo].[Departmans] ([DepartmanID], [DepartmanAdi]) VALUES (5, N'İnsan Kaynakları')
SET IDENTITY_INSERT [dbo].[Departmans] OFF
GO
SET IDENTITY_INSERT [dbo].[Personels] ON 

INSERT [dbo].[Personels] ([PersonelId], [PersonelAd], [PersonelSoyad], [DepartmanID], [PersonelEposta], [PersonelTel], [FotoğrafYolu]) VALUES (1, N'Zişan', N'Dağtekin', 1, N'zisand@gmail.com', N'05559998877', NULL)
INSERT [dbo].[Personels] ([PersonelId], [PersonelAd], [PersonelSoyad], [DepartmanID], [PersonelEposta], [PersonelTel], [FotoğrafYolu]) VALUES (2, N'Ali', N'Erkoç', 1, N'alierkc@gmail.com', N'054633312000', NULL)
INSERT [dbo].[Personels] ([PersonelId], [PersonelAd], [PersonelSoyad], [DepartmanID], [PersonelEposta], [PersonelTel], [FotoğrafYolu]) VALUES (12, N'Dilek', N'Kaş', 1, N'dilek@gmail.com', N'05336664477', NULL)
INSERT [dbo].[Personels] ([PersonelId], [PersonelAd], [PersonelSoyad], [DepartmanID], [PersonelEposta], [PersonelTel], [FotoğrafYolu]) VALUES (13, N'Murat', N'Doğan', 3, N'muratd@gmail.com', N'05447778899', NULL)
INSERT [dbo].[Personels] ([PersonelId], [PersonelAd], [PersonelSoyad], [DepartmanID], [PersonelEposta], [PersonelTel], [FotoğrafYolu]) VALUES (14, N'Ali', N'Şahin', 4, N'alishn@gmail.com', N'05441112587', NULL)
INSERT [dbo].[Personels] ([PersonelId], [PersonelAd], [PersonelSoyad], [DepartmanID], [PersonelEposta], [PersonelTel], [FotoğrafYolu]) VALUES (15, N'Mehmet', N'Türker', 2, N'mehmettt@gmail.com', N'05466669988', NULL)
INSERT [dbo].[Personels] ([PersonelId], [PersonelAd], [PersonelSoyad], [DepartmanID], [PersonelEposta], [PersonelTel], [FotoğrafYolu]) VALUES (16, N'Mert', N'Türkoğlu', 5, N'mertrk@gmail.com', N'05532221144', NULL)
INSERT [dbo].[Personels] ([PersonelId], [PersonelAd], [PersonelSoyad], [DepartmanID], [PersonelEposta], [PersonelTel], [FotoğrafYolu]) VALUES (18, N'Nevra', N'Kaplan', 5, N'nevra@gmail.com', N'05444999862', N'')
SET IDENTITY_INSERT [dbo].[Personels] OFF
GO
/****** Object:  Index [IX_CihazAtamas_CihazId]    Script Date: 16.09.2024 10:01:23 ******/
CREATE NONCLUSTERED INDEX [IX_CihazAtamas_CihazId] ON [dbo].[CihazAtamas]
(
	[CihazId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CihazAtamas_DepartmanID]    Script Date: 16.09.2024 10:01:23 ******/
CREATE NONCLUSTERED INDEX [IX_CihazAtamas_DepartmanID] ON [dbo].[CihazAtamas]
(
	[DepartmanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CihazAtamas_PersonelId]    Script Date: 16.09.2024 10:01:23 ******/
CREATE NONCLUSTERED INDEX [IX_CihazAtamas_PersonelId] ON [dbo].[CihazAtamas]
(
	[PersonelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DeviceStatusViewModels_CihazId]    Script Date: 16.09.2024 10:01:23 ******/
CREATE NONCLUSTERED INDEX [IX_DeviceStatusViewModels_CihazId] ON [dbo].[DeviceStatusViewModels]
(
	[CihazId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Personels_DepartmanID]    Script Date: 16.09.2024 10:01:23 ******/
CREATE NONCLUSTERED INDEX [IX_Personels_DepartmanID] ON [dbo].[Personels]
(
	[DepartmanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cihazs] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsAssigned]
GO
ALTER TABLE [dbo].[CihazAtamas]  WITH CHECK ADD  CONSTRAINT [FK_CihazAtamas_Cihazs_CihazId] FOREIGN KEY([CihazId])
REFERENCES [dbo].[Cihazs] ([CihazId])
GO
ALTER TABLE [dbo].[CihazAtamas] CHECK CONSTRAINT [FK_CihazAtamas_Cihazs_CihazId]
GO
ALTER TABLE [dbo].[CihazAtamas]  WITH CHECK ADD  CONSTRAINT [FK_CihazAtamas_Departmans_DepartmanID] FOREIGN KEY([DepartmanID])
REFERENCES [dbo].[Departmans] ([DepartmanID])
GO
ALTER TABLE [dbo].[CihazAtamas] CHECK CONSTRAINT [FK_CihazAtamas_Departmans_DepartmanID]
GO
ALTER TABLE [dbo].[CihazAtamas]  WITH CHECK ADD  CONSTRAINT [FK_CihazAtamas_Personels_PersonelId] FOREIGN KEY([PersonelId])
REFERENCES [dbo].[Personels] ([PersonelId])
GO
ALTER TABLE [dbo].[CihazAtamas] CHECK CONSTRAINT [FK_CihazAtamas_Personels_PersonelId]
GO
ALTER TABLE [dbo].[DeviceStatusViewModels]  WITH CHECK ADD  CONSTRAINT [FK_DeviceStatusViewModels_Cihazs_CihazId] FOREIGN KEY([CihazId])
REFERENCES [dbo].[Cihazs] ([CihazId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DeviceStatusViewModels] CHECK CONSTRAINT [FK_DeviceStatusViewModels_Cihazs_CihazId]
GO
ALTER TABLE [dbo].[Personels]  WITH CHECK ADD  CONSTRAINT [FK_Personels_Departmans_DepartmanID] FOREIGN KEY([DepartmanID])
REFERENCES [dbo].[Departmans] ([DepartmanID])
GO
ALTER TABLE [dbo].[Personels] CHECK CONSTRAINT [FK_Personels_Departmans_DepartmanID]
GO
USE [master]
GO
ALTER DATABASE [cihaz_atama] SET  READ_WRITE 
GO
