ALTER DATABASE [AracKiralama] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AracKiralama] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AracKiralama] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AracKiralama] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AracKiralama] SET ARITHABORT OFF 
GO
ALTER DATABASE [AracKiralama] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AracKiralama] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AracKiralama] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AracKiralama] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AracKiralama] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AracKiralama] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AracKiralama] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AracKiralama] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AracKiralama] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AracKiralama] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AracKiralama] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AracKiralama] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AracKiralama] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AracKiralama] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AracKiralama] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AracKiralama] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AracKiralama] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AracKiralama] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AracKiralama] SET  MULTI_USER 
GO
ALTER DATABASE [AracKiralama] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AracKiralama] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AracKiralama] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AracKiralama] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AracKiralama] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'AracKiralama', N'ON'
GO
ALTER DATABASE [AracKiralama] SET QUERY_STORE = OFF
GO
USE [AracKiralama]
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
USE [AracKiralama]
GO
/****** Object:  Table [dbo].[AraclarListesi]    Script Date: 23.12.2019 08:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AraclarListesi](
	[AracID] [int] IDENTITY(1,1) NOT NULL,
	[Plaka] [nvarchar](20) NOT NULL,
	[Marka] [nvarchar](50) NOT NULL,
	[Seri] [nvarchar](50) NOT NULL,
	[Model_Yıl] [nvarchar](50) NOT NULL,
	[Km] [int] NOT NULL,
	[Vites] [nvarchar](50) NOT NULL,
	[Yakıt] [nvarchar](20) NOT NULL,
	[KiraUcreti] [int] NOT NULL,
	[Durum] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_AraclarListesi] PRIMARY KEY CLUSTERED 
(
	[AracID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GenelToplam]    Script Date: 23.12.2019 08:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GenelToplam](
	[GenelToplamID] [int] IDENTITY(1,1) NOT NULL,
	[GenelToplamUcret] [int] NOT NULL,
 CONSTRAINT [PK_GenelToplam] PRIMARY KEY CLUSTERED 
(
	[GenelToplamID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KiralamaIslemleri]    Script Date: 23.12.2019 08:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KiralamaIslemleri](
	[IslemID] [int] IDENTITY(1,1) NOT NULL,
	[AracID] [int] NOT NULL,
	[MusteriID] [int] NOT NULL,
	[AracCıkısTarihi] [datetime] NOT NULL,
	[AracTeslimTarihi] [datetime] NOT NULL,
	[ToplamUcret] [int] NOT NULL,
 CONSTRAINT [PK_KiralamaIslemleri] PRIMARY KEY CLUSTERED 
(
	[IslemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanıcılar]    Script Date: 23.12.2019 08:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanıcılar](
	[KullanıcıID] [int] IDENTITY(1,1) NOT NULL,
	[KullanıcıAdı] [nvarchar](50) NOT NULL,
	[Sifre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Kullanıcılar] PRIMARY KEY CLUSTERED 
(
	[KullanıcıID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musteriler]    Script Date: 23.12.2019 08:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteriler](
	[MusteriID] [int] IDENTITY(1,1) NOT NULL,
	[TcNO] [nvarchar](50) NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
	[Soyad] [nvarchar](50) NOT NULL,
	[Telefon] [nvarchar](50) NOT NULL,
	[Adres] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Cinsiyet] [nvarchar](10) NOT NULL,
	[EhliyetNo] [int] NOT NULL,
 CONSTRAINT [PK_Mü] PRIMARY KEY CLUSTERED 
(
	[MusteriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AraclarListesi] ON 

INSERT [dbo].[AraclarListesi] ([AracID], [Plaka], [Marka], [Seri], [Model_Yıl], [Km], [Vites], [Yakıt], [KiraUcreti], [Durum]) VALUES (1, N'34 YO 7585', N'FORD', N'FOCUS', N'2019', 15000, N'Manuel', N'Benzin', 250, N'Uygun')
INSERT [dbo].[AraclarListesi] ([AracID], [Plaka], [Marka], [Seri], [Model_Yıl], [Km], [Vites], [Yakıt], [KiraUcreti], [Durum]) VALUES (2, N'34 YO 4585', N'TOFAŞ', N'ŞAHİN', N'1999', 250000, N'Manuel', N'LPG', 100, N'Uygun')
INSERT [dbo].[AraclarListesi] ([AracID], [Plaka], [Marka], [Seri], [Model_Yıl], [Km], [Vites], [Yakıt], [KiraUcreti], [Durum]) VALUES (3, N'10 ES 12542', N'WOLKSVAGEN', N'PASSAT', N'2005', 60000, N'Otomatik', N'Benzin', 200, N'Uygun')
INSERT [dbo].[AraclarListesi] ([AracID], [Plaka], [Marka], [Seri], [Model_Yıl], [Km], [Vites], [Yakıt], [KiraUcreti], [Durum]) VALUES (6, N'27 HRN 526', N'RENAULT', N'MEGANE', N'2019', 10000, N'Manuel', N'Benzin', 250, N'Uygun')
INSERT [dbo].[AraclarListesi] ([AracID], [Plaka], [Marka], [Seri], [Model_Yıl], [Km], [Vites], [Yakıt], [KiraUcreti], [Durum]) VALUES (7, N'34 tsk 8596', N'FIAT', N'ALBEA', N'2005', 152000, N'Manuel', N'LPG', 150, N'Uygun')
INSERT [dbo].[AraclarListesi] ([AracID], [Plaka], [Marka], [Seri], [Model_Yıl], [Km], [Vites], [Yakıt], [KiraUcreti], [Durum]) VALUES (8, N'34 tv 752', N'Totoya', N'Corolla', N'1996', 192, N'Manuel', N'LPG', 185, N'Uygun')
INSERT [dbo].[AraclarListesi] ([AracID], [Plaka], [Marka], [Seri], [Model_Yıl], [Km], [Vites], [Yakıt], [KiraUcreti], [Durum]) VALUES (9, N'34 AFK 758', N'BMW', N'M5', N'2018', 57254, N'Manuel', N'Benzin', 450, N'Uygun')
INSERT [dbo].[AraclarListesi] ([AracID], [Plaka], [Marka], [Seri], [Model_Yıl], [Km], [Vites], [Yakıt], [KiraUcreti], [Durum]) VALUES (10, N'27 ZCV 785', N'BMW', N'M3', N'2005', 125402, N'Manuel', N'LPG', 250, N'Kiralandı')
SET IDENTITY_INSERT [dbo].[AraclarListesi] OFF
SET IDENTITY_INSERT [dbo].[Kullanıcılar] ON 

INSERT [dbo].[Kullanıcılar] ([KullanıcıID], [KullanıcıAdı], [Sifre]) VALUES (1, N'admin', N'12345')
SET IDENTITY_INSERT [dbo].[Kullanıcılar] OFF
SET IDENTITY_INSERT [dbo].[Musteriler] ON 

INSERT [dbo].[Musteriler] ([MusteriID], [TcNO], [Ad], [Soyad], [Telefon], [Adres], [Email], [Cinsiyet], [EhliyetNo]) VALUES (1, N'40526176056', N'Harun', N'Alkan', N'(536) 548-5788', N'Gaziosmanpaşa', N'harun@gmail.com', N'Kadın', 514556)
INSERT [dbo].[Musteriler] ([MusteriID], [TcNO], [Ad], [Soyad], [Telefon], [Adres], [Email], [Cinsiyet], [EhliyetNo]) VALUES (2, N'40521457588', N'Osman', N'Göler', N'(548) 646-8489', N'Küçükköy', N'osman@hotmail.com', N'Erkek', 111111)
INSERT [dbo].[Musteriler] ([MusteriID], [TcNO], [Ad], [Soyad], [Telefon], [Adres], [Email], [Cinsiyet], [EhliyetNo]) VALUES (3, N'52145214587', N'Büşra', N'Çınar', N'(546) 464-9848', N'Üsküdar', N'busra@hotmail.com', N'Erkek', 254256)
SET IDENTITY_INSERT [dbo].[Musteriler] OFF
ALTER TABLE [dbo].[KiralamaIslemleri]  WITH CHECK ADD  CONSTRAINT [FK_KiralamaIslemleri_AraclarListesi] FOREIGN KEY([AracID])
REFERENCES [dbo].[AraclarListesi] ([AracID])
GO
ALTER TABLE [dbo].[KiralamaIslemleri] CHECK CONSTRAINT [FK_KiralamaIslemleri_AraclarListesi]
GO
ALTER TABLE [dbo].[KiralamaIslemleri]  WITH CHECK ADD  CONSTRAINT [FK_KiralamaIslemleri_Musteriler] FOREIGN KEY([MusteriID])
REFERENCES [dbo].[Musteriler] ([MusteriID])
GO
ALTER TABLE [dbo].[KiralamaIslemleri] CHECK CONSTRAINT [FK_KiralamaIslemleri_Musteriler]
GO
USE [master]
GO
ALTER DATABASE [AracKiralama] SET  READ_WRITE 
GO
