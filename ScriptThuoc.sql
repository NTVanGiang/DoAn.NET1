USE [master]
GO
/****** Object:  Database [dbThuoc]    Script Date: 3/6/2017 8:13:46 PM ******/
CREATE DATABASE [dbThuoc]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbThuoc', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\dbThuoc.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbThuoc_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\dbThuoc_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbThuoc] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbThuoc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbThuoc] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbThuoc] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbThuoc] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbThuoc] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbThuoc] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbThuoc] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbThuoc] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [dbThuoc] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbThuoc] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbThuoc] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbThuoc] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbThuoc] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbThuoc] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbThuoc] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbThuoc] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbThuoc] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbThuoc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbThuoc] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbThuoc] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbThuoc] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbThuoc] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbThuoc] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbThuoc] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbThuoc] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbThuoc] SET  MULTI_USER 
GO
ALTER DATABASE [dbThuoc] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbThuoc] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbThuoc] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbThuoc] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [dbThuoc]
GO
/****** Object:  StoredProcedure [dbo].[Insert_NhomThuoc]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Insert_NhomThuoc]
@TenNhom varchar(50)

as
begin
declare @newID int 
select @newID = max(MaNhom)+1 from NhomThuoc
insert into NhomThuoc values (@newID, @TenNhom)
end
GO
/****** Object:  StoredProcedure [dbo].[pr_Xoa_HDX]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pr_Xoa_HDX]
@mahdx int
as
 delete from ChiTietHoaDonXuat where ChiTietHoaDonXuat.MaHDX=@mahdx
 delete from HoaDonXuat where HoaDonXuat.MaHDX=@mahdx
return

GO
/****** Object:  StoredProcedure [dbo].[tb]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[tb]
@mahdx int
as
 delete from ChiTietHoaDonXuat where ChiTietHoaDonXuat.MaHDX=@mahdx
 delete from HoaDonXuat where HoaDonXuat.MaHDX=@mahdx
return

exec tb 11
GO
/****** Object:  StoredProcedure [dbo].[Timkiem_nhacc]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Timkiem_nhacc]
@tennhacc nvarchar(50)
as
 select * from HoaDonNhap join NhaCungCap on HoaDonNhap.MaNCC=NhaCungCap.MaNCC and NhaCungCap.TenNCC like N'%'+@tennhacc+'%'
 return
GO
/****** Object:  StoredProcedure [dbo].[timkiem_tenbn]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[timkiem_tenbn]
@tenbenhnhan nvarchar(50)
as
 select * from HoaDonXuat join BenhNhan on HoaDonXuat.MaBN=BenhNhan.MaBN and BenhNhan.HoTen like N'%'+@tenbenhnhan+'%'
return
GO
/****** Object:  StoredProcedure [dbo].[Timkiem_TenNhom]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Timkiem_TenNhom]
@tennhom nvarchar(50)
AS
 select * from Thuoc join NhomThuoc on Thuoc.MaNhom = NhomThuoc.MaNhom and NhomThuoc.TenNhom like N'%'+@tennhom+'%'
RETURN
GO
/****** Object:  StoredProcedure [dbo].[Timkiem_Tenthuoc]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Timkiem_Tenthuoc]
@tenthuoc nvarchar(50)
as
 select * from ChiTietHoaDonXuat join Thuoc on ChiTietHoaDonXuat.MaThuoc=Thuoc.MaThuoc and TenThuoc like N'%'+@tenthuoc+'%'
 return
GO
/****** Object:  StoredProcedure [dbo].[Timkiem_tenthuoc1]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Timkiem_tenthuoc1]
@tent nvarchar(50)
as
	select * from ChiTietHoaDonNhap join Thuoc on ChiTietHoaDonNhap.MaThuoc=Thuoc.MaThuoc and Thuoc.TenThuoc like N'%'+@tent+'%'
return
GO
/****** Object:  Table [dbo].[BenhNhan]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BenhNhan](
	[MaBN] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[Tuoi] [int] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_BenhNhan] PRIMARY KEY CLUSTERED 
(
	[MaBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietHoaDonNhap]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonNhap](
	[MaCTHDN] [int] IDENTITY(1,1) NOT NULL,
	[MaHDN] [int] NULL,
	[MaThuoc] [int] NULL,
	[SoLuong] [int] NULL,
	[GiaNhap] [money] NULL,
 CONSTRAINT [PK_ChiTietHoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[MaCTHDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietHoaDonXuat]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonXuat](
	[MaCTHDX] [int] IDENTITY(1,1) NOT NULL,
	[MaHDX] [int] NULL,
	[MaThuoc] [int] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_ChiTietHoaDonXuat] PRIMARY KEY CLUSTERED 
(
	[MaCTHDX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonViTinh](
	[MaDVT] [int] IDENTITY(1,1) NOT NULL,
	[TenDVT] [nvarchar](50) NULL,
 CONSTRAINT [PK_DonViTinh] PRIMARY KEY CLUSTERED 
(
	[MaDVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDonNhap]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonNhap](
	[MaHDN] [int] IDENTITY(1,1) NOT NULL,
	[MaNCC] [int] NULL,
	[NguoiGiao] [nvarchar](50) NULL,
	[NguoiNhan] [nvarchar](50) NULL,
	[TongTienThuoc] [money] NULL,
	[NgayNhap] [date] NULL,
 CONSTRAINT [PK_HoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[MaHDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDonXuat]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonXuat](
	[MaHDX] [int] IDENTITY(1,1) NOT NULL,
	[MaBN] [int] NULL,
	[NgayLap] [date] NULL,
	[TongTien] [money] NULL,
 CONSTRAINT [PK_HoaDonXuat] PRIMARY KEY CLUSTERED 
(
	[MaHDX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [int] IDENTITY(1,1) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhomThuoc]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomThuoc](
	[MaNhom] [int] IDENTITY(1,1) NOT NULL,
	[TenNhom] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhomThuoc] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Thuoc]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thuoc](
	[MaThuoc] [int] IDENTITY(1,1) NOT NULL,
	[TenThuoc] [nvarchar](50) NULL,
	[MaNhom] [int] NULL,
	[SoLuong] [int] NULL,
	[GiaBan] [money] NULL,
	[MaDVT] [int] NULL,
	[CongDung] [nvarchar](50) NULL,
	[PhanTacDung] [nvarchar](50) NULL,
	[NgaySanXuat] [date] NULL,
	[HanSuDung] [date] NULL,
 CONSTRAINT [PK_Thuoc] PRIMARY KEY CLUSTERED 
(
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[PassWord] [varchar](50) NULL,
	[HoTen] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_User_1] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[BenhNhan] ON 

INSERT [dbo].[BenhNhan] ([MaBN], [HoTen], [Tuoi], [DiaChi], [DienThoai]) VALUES (9, N'Nguyễn Văn A', 9, N'Hà Nội', N'9')
INSERT [dbo].[BenhNhan] ([MaBN], [HoTen], [Tuoi], [DiaChi], [DienThoai]) VALUES (11, N'Nguyễn Thị Mơ', 11, N'Nghệ An', N'0999123111')
INSERT [dbo].[BenhNhan] ([MaBN], [HoTen], [Tuoi], [DiaChi], [DienThoai]) VALUES (12, N'Lan Lan', 1, N'Hà Nam', N'1')
INSERT [dbo].[BenhNhan] ([MaBN], [HoTen], [Tuoi], [DiaChi], [DienThoai]) VALUES (15, N'Mai Hoa', 1, N'1', N'1')
INSERT [dbo].[BenhNhan] ([MaBN], [HoTen], [Tuoi], [DiaChi], [DienThoai]) VALUES (16, N'Me', 10, N'Mai Châu', N'1')
INSERT [dbo].[BenhNhan] ([MaBN], [HoTen], [Tuoi], [DiaChi], [DienThoai]) VALUES (19, N'Nguyễn Hoa', 22, N'Ninh Bình', N'222')
SET IDENTITY_INSERT [dbo].[BenhNhan] OFF
SET IDENTITY_INSERT [dbo].[ChiTietHoaDonNhap] ON 

INSERT [dbo].[ChiTietHoaDonNhap] ([MaCTHDN], [MaHDN], [MaThuoc], [SoLuong], [GiaNhap]) VALUES (34, 13, 1, 9, 4.0000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaCTHDN], [MaHDN], [MaThuoc], [SoLuong], [GiaNhap]) VALUES (39, 13, 2, 18, 2.0000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaCTHDN], [MaHDN], [MaThuoc], [SoLuong], [GiaNhap]) VALUES (40, 13, 4, 2, 10.0000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaCTHDN], [MaHDN], [MaThuoc], [SoLuong], [GiaNhap]) VALUES (49, 19, 2, 3, 3.0000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaCTHDN], [MaHDN], [MaThuoc], [SoLuong], [GiaNhap]) VALUES (50, 19, 4, 3, 2.0000)
INSERT [dbo].[ChiTietHoaDonNhap] ([MaCTHDN], [MaHDN], [MaThuoc], [SoLuong], [GiaNhap]) VALUES (51, 19, 7, 1, 20.0000)
SET IDENTITY_INSERT [dbo].[ChiTietHoaDonNhap] OFF
SET IDENTITY_INSERT [dbo].[ChiTietHoaDonXuat] ON 

INSERT [dbo].[ChiTietHoaDonXuat] ([MaCTHDX], [MaHDX], [MaThuoc], [SoLuong]) VALUES (108, 36, 2, 4)
INSERT [dbo].[ChiTietHoaDonXuat] ([MaCTHDX], [MaHDX], [MaThuoc], [SoLuong]) VALUES (112, 35, 9, 9)
INSERT [dbo].[ChiTietHoaDonXuat] ([MaCTHDX], [MaHDX], [MaThuoc], [SoLuong]) VALUES (113, 35, 2, 3)
INSERT [dbo].[ChiTietHoaDonXuat] ([MaCTHDX], [MaHDX], [MaThuoc], [SoLuong]) VALUES (114, 35, 1, 3)
INSERT [dbo].[ChiTietHoaDonXuat] ([MaCTHDX], [MaHDX], [MaThuoc], [SoLuong]) VALUES (115, 36, 4, 6)
INSERT [dbo].[ChiTietHoaDonXuat] ([MaCTHDX], [MaHDX], [MaThuoc], [SoLuong]) VALUES (121, 38, 2, 6)
INSERT [dbo].[ChiTietHoaDonXuat] ([MaCTHDX], [MaHDX], [MaThuoc], [SoLuong]) VALUES (122, 38, 4, 5)
INSERT [dbo].[ChiTietHoaDonXuat] ([MaCTHDX], [MaHDX], [MaThuoc], [SoLuong]) VALUES (126, 38, 7, 4)
INSERT [dbo].[ChiTietHoaDonXuat] ([MaCTHDX], [MaHDX], [MaThuoc], [SoLuong]) VALUES (130, 40, 4, 3)
INSERT [dbo].[ChiTietHoaDonXuat] ([MaCTHDX], [MaHDX], [MaThuoc], [SoLuong]) VALUES (133, 40, 1, 5)
INSERT [dbo].[ChiTietHoaDonXuat] ([MaCTHDX], [MaHDX], [MaThuoc], [SoLuong]) VALUES (136, 42, 4, 4)
INSERT [dbo].[ChiTietHoaDonXuat] ([MaCTHDX], [MaHDX], [MaThuoc], [SoLuong]) VALUES (137, 42, 16, 7)
SET IDENTITY_INSERT [dbo].[ChiTietHoaDonXuat] OFF
SET IDENTITY_INSERT [dbo].[DonViTinh] ON 

INSERT [dbo].[DonViTinh] ([MaDVT], [TenDVT]) VALUES (1, N'Lọ')
INSERT [dbo].[DonViTinh] ([MaDVT], [TenDVT]) VALUES (2, N'Hộp')
INSERT [dbo].[DonViTinh] ([MaDVT], [TenDVT]) VALUES (3, N'Viên')
INSERT [dbo].[DonViTinh] ([MaDVT], [TenDVT]) VALUES (6, N'Bột')
INSERT [dbo].[DonViTinh] ([MaDVT], [TenDVT]) VALUES (7, N'dd')
SET IDENTITY_INSERT [dbo].[DonViTinh] OFF
SET IDENTITY_INSERT [dbo].[HoaDonNhap] ON 

INSERT [dbo].[HoaDonNhap] ([MaHDN], [MaNCC], [NguoiGiao], [NguoiNhan], [TongTienThuoc], [NgayNhap]) VALUES (13, 2, N'Nguyễn Văn A', N'Nguyễn Văn B', 60.0000, CAST(0x3F3C0B00 AS Date))
INSERT [dbo].[HoaDonNhap] ([MaHDN], [MaNCC], [NguoiGiao], [NguoiNhan], [TongTienThuoc], [NgayNhap]) VALUES (19, 3, N'1', N'1', 35.0000, CAST(0x433C0B00 AS Date))
SET IDENTITY_INSERT [dbo].[HoaDonNhap] OFF
SET IDENTITY_INSERT [dbo].[HoaDonXuat] ON 

INSERT [dbo].[HoaDonXuat] ([MaHDX], [MaBN], [NgayLap], [TongTien]) VALUES (35, 11, CAST(0x423C0B00 AS Date), 2.0000)
INSERT [dbo].[HoaDonXuat] ([MaHDX], [MaBN], [NgayLap], [TongTien]) VALUES (36, 11, CAST(0x423C0B00 AS Date), 12.0000)
INSERT [dbo].[HoaDonXuat] ([MaHDX], [MaBN], [NgayLap], [TongTien]) VALUES (38, 9, CAST(0x423C0B00 AS Date), 62.0000)
INSERT [dbo].[HoaDonXuat] ([MaHDX], [MaBN], [NgayLap], [TongTien]) VALUES (40, 11, CAST(0x433C0B00 AS Date), 11.0000)
INSERT [dbo].[HoaDonXuat] ([MaHDX], [MaBN], [NgayLap], [TongTien]) VALUES (42, 19, CAST(0x433C0B00 AS Date), 22.0000)
SET IDENTITY_INSERT [dbo].[HoaDonXuat] OFF
SET IDENTITY_INSERT [dbo].[NhaCungCap] ON 

INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [DienThoai], [Email]) VALUES (1, N'Thái Dương', N'Hà Nội', N'0912121212', N'vvv')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [DienThoai], [Email]) VALUES (2, N'Hoa Linh', N'TP Hồ Chí Minh', N'0928282828', N'tttttttt')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [DienThoai], [Email]) VALUES (3, N'Nam Dược', N'da', N'da', N'a')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [DienThoai], [Email]) VALUES (6, N'Mai Hoa', N'Đà Nẵng', N'0923333333', N'dddd')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [DienThoai], [Email]) VALUES (7, N'3', N'3', N'3', N'3')
SET IDENTITY_INSERT [dbo].[NhaCungCap] OFF
SET IDENTITY_INSERT [dbo].[NhomThuoc] ON 

INSERT [dbo].[NhomThuoc] ([MaNhom], [TenNhom]) VALUES (1, N'Đường Hô Hấp')
INSERT [dbo].[NhomThuoc] ([MaNhom], [TenNhom]) VALUES (8, N'Tiêu Hóa,Gan,Mật')
INSERT [dbo].[NhomThuoc] ([MaNhom], [TenNhom]) VALUES (13, N'Vitamin')
INSERT [dbo].[NhomThuoc] ([MaNhom], [TenNhom]) VALUES (14, N'Thực phẩm chức năng')
INSERT [dbo].[NhomThuoc] ([MaNhom], [TenNhom]) VALUES (15, N'Tim Mạch')
INSERT [dbo].[NhomThuoc] ([MaNhom], [TenNhom]) VALUES (17, N'Điều trị da liễu')
INSERT [dbo].[NhomThuoc] ([MaNhom], [TenNhom]) VALUES (18, N'Đau nửa đầu')
INSERT [dbo].[NhomThuoc] ([MaNhom], [TenNhom]) VALUES (21, N'ds')
SET IDENTITY_INSERT [dbo].[NhomThuoc] OFF
SET IDENTITY_INSERT [dbo].[Thuoc] ON 

INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaNhom], [SoLuong], [GiaBan], [MaDVT], [CongDung], [PhanTacDung], [NgaySanXuat], [HanSuDung]) VALUES (1, N'Acetylcystein 200mg', 1, 1, 1.0000, 1, N'Tiêu nhày trong các bệnh phế quản-phổi cấp', N'1', CAST(0xB9330B00 AS Date), CAST(0xD9330B00 AS Date))
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaNhom], [SoLuong], [GiaBan], [MaDVT], [CongDung], [PhanTacDung], [NgaySanXuat], [HanSuDung]) VALUES (2, N'Xules', 1, 1, 2.0000, 1, N'21', N'2', CAST(0x383C0B00 AS Date), CAST(0x383C0B00 AS Date))
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaNhom], [SoLuong], [GiaBan], [MaDVT], [CongDung], [PhanTacDung], [NgaySanXuat], [HanSuDung]) VALUES (4, N'Routo', 15, 4, 2.0000, 3, N'22', N'2', CAST(0x3D3C0B00 AS Date), CAST(0x4E3C0B00 AS Date))
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaNhom], [SoLuong], [GiaBan], [MaDVT], [CongDung], [PhanTacDung], [NgaySanXuat], [HanSuDung]) VALUES (7, N'Antituss', 1, 7, 10.0000, 1, N'd', N'd', CAST(0x3D3C0B00 AS Date), CAST(0x3D3C0B00 AS Date))
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaNhom], [SoLuong], [GiaBan], [MaDVT], [CongDung], [PhanTacDung], [NgaySanXuat], [HanSuDung]) VALUES (9, N'Beberin', 8, 5, 1.0000, 1, N'1', N'1', CAST(0x3D3C0B00 AS Date), CAST(0x3D3C0B00 AS Date))
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaNhom], [SoLuong], [GiaBan], [MaDVT], [CongDung], [PhanTacDung], [NgaySanXuat], [HanSuDung]) VALUES (14, N'a', 1, 4, 3.0000, 6, N'3', N'3', CAST(0x423C0B00 AS Date), CAST(0x423C0B00 AS Date))
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [MaNhom], [SoLuong], [GiaBan], [MaDVT], [CongDung], [PhanTacDung], [NgaySanXuat], [HanSuDung]) VALUES (16, N'Andol S', 1, 3, 2.0000, 1, N'2', N'2', CAST(0x423C0B00 AS Date), CAST(0x423C0B00 AS Date))
SET IDENTITY_INSERT [dbo].[Thuoc] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [UserName], [PassWord], [HoTen], [DiaChi]) VALUES (4, N'Giang', N'12345', N'Nguyễn Thị Vân Giang', N'Nghệ An')
INSERT [dbo].[Users] ([UserId], [UserName], [PassWord], [HoTen], [DiaChi]) VALUES (6, N'Quân', N'123', N'Đỗ Mạnh Quân', N'Hà Nội')
INSERT [dbo].[Users] ([UserId], [UserName], [PassWord], [HoTen], [DiaChi]) VALUES (9, N'test', N'123', N'1', N'1')
INSERT [dbo].[Users] ([UserId], [UserName], [PassWord], [HoTen], [DiaChi]) VALUES (11, N'dd', N'dd', N'dd', N'd')
INSERT [dbo].[Users] ([UserId], [UserName], [PassWord], [HoTen], [DiaChi]) VALUES (16, N'Mai', N'123456', N'Nguyễn Mai', N'Hà Nội')
INSERT [dbo].[Users] ([UserId], [UserName], [PassWord], [HoTen], [DiaChi]) VALUES (18, N'1', N'1', N'1', N'1')
INSERT [dbo].[Users] ([UserId], [UserName], [PassWord], [HoTen], [DiaChi]) VALUES (1018, N'Giang', N'12345', N'Nguyễn Thị Vân Giang', N'Nghệ An')
INSERT [dbo].[Users] ([UserId], [UserName], [PassWord], [HoTen], [DiaChi]) VALUES (1019, N'Giang', N'12345', N'Nguyễn Thị Vân Giang', N'Nghệ An')
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[ChiTietHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonNhap_HoaDonNhap] FOREIGN KEY([MaHDN])
REFERENCES [dbo].[HoaDonNhap] ([MaHDN])
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap] CHECK CONSTRAINT [FK_ChiTietHoaDonNhap_HoaDonNhap]
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonNhap_Thuoc] FOREIGN KEY([MaThuoc])
REFERENCES [dbo].[Thuoc] ([MaThuoc])
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap] CHECK CONSTRAINT [FK_ChiTietHoaDonNhap_Thuoc]
GO
ALTER TABLE [dbo].[ChiTietHoaDonXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonXuat_HoaDonXuat] FOREIGN KEY([MaHDX])
REFERENCES [dbo].[HoaDonXuat] ([MaHDX])
GO
ALTER TABLE [dbo].[ChiTietHoaDonXuat] CHECK CONSTRAINT [FK_ChiTietHoaDonXuat_HoaDonXuat]
GO
ALTER TABLE [dbo].[ChiTietHoaDonXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonXuat_Thuoc] FOREIGN KEY([MaThuoc])
REFERENCES [dbo].[Thuoc] ([MaThuoc])
GO
ALTER TABLE [dbo].[ChiTietHoaDonXuat] CHECK CONSTRAINT [FK_ChiTietHoaDonXuat_Thuoc]
GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhap_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[HoaDonNhap] CHECK CONSTRAINT [FK_HoaDonNhap_NhaCungCap]
GO
ALTER TABLE [dbo].[HoaDonXuat]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonXuat_BenhNhan] FOREIGN KEY([MaBN])
REFERENCES [dbo].[BenhNhan] ([MaBN])
GO
ALTER TABLE [dbo].[HoaDonXuat] CHECK CONSTRAINT [FK_HoaDonXuat_BenhNhan]
GO
ALTER TABLE [dbo].[Thuoc]  WITH CHECK ADD  CONSTRAINT [FK_Thuoc_DonViTinh] FOREIGN KEY([MaDVT])
REFERENCES [dbo].[DonViTinh] ([MaDVT])
GO
ALTER TABLE [dbo].[Thuoc] CHECK CONSTRAINT [FK_Thuoc_DonViTinh]
GO
ALTER TABLE [dbo].[Thuoc]  WITH CHECK ADD  CONSTRAINT [FK_Thuoc_NhomThuoc] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NhomThuoc] ([MaNhom])
GO
ALTER TABLE [dbo].[Thuoc] CHECK CONSTRAINT [FK_Thuoc_NhomThuoc]
GO
/****** Object:  Trigger [dbo].[tg_update_ChiTietHoaDonNhap]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[tg_update_ChiTietHoaDonNhap]
on [dbo].[ChiTietHoaDonNhap]
after update
as
begin
	declare @MaHDN int=(select MaHDN from deleted);
	declare @slcu int=(select SoLuong from deleted);
	declare @slmoi int=(select SoLuong from inserted);
	declare @sum money =(select TongTienThuoc from HoaDonNhap where MaHDN=@MaHDN);
	declare @GiaNhapcu money=(select GiaNhap from deleted);
	declare @GiaNhapmoi money=(select GiaNhap from inserted);
	set @sum=@sum -(@slcu * @GiaNhapcu)+(@slmoi * @GiaNhapmoi);

	update HoaDonNhap set TongTienThuoc=@sum where HoaDonNhap.MaHDN=@MaHDN;
end
GO
/****** Object:  Trigger [dbo].[tr_AddTongNhap]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE trigger [dbo].[tr_AddTongNhap]
on [dbo].[ChiTietHoaDonNhap]
instead of insert
as begin
	
	INSERT INTO ChiTietHoaDonNhap(MaHDN , MaThuoc , SoLuong, GiaNhap) SELECT MaHDN , MaThuoc , SoLuong, GiaNhap FROM INSERTED
	--Tinh tong tien
	declare @id int =  (select SCOPE_IDENTITY() AS [SCOPE_IDENTITY]);  
	declare @Sum money = (select TongTienThuoc From HoaDonNhap where MaHDN in (select MaHDN from inserted));
	declare @sl int = (select SoLuong from inserted);
	declare @gn money = (select GiaNhap from inserted );
	set @Sum = @Sum + @sl * @gn;
	Update HoaDonNhap set TongTienThuoc = @Sum where MaHDN in (select MaHDN from ChiTietHoaDonNhap where MaCTHDN = @id);

	--cong don soluong thuoc
	declare @ma int = (select MaThuoc From inserted);
	if ((select count(MaThuoc) from ChiTietHoaDonNhap where MaThuoc = @ma and MaHDN = (select MaHDN from inserted)) >=2)
	begin
		select MaThuoc from ChiTietHoaDonNhap where MaThuoc = @ma and MaHDN = (select MaHDN from inserted)
		delete ChiTietHoaDonNhap where MaCTHDN = @id
		declare @sl2 int = (select SoLuong from ChiTietHoaDonNhap where MaThuoc = @ma and MaHDN = (select MaHDN from inserted));
		set @sl2 = @sl2 + (select SoLuong From inserted)
		Update ChiTietHoaDonNhap set SoLuong = @sl2 where MaCTHDN in (select MaCTHDN from ChiTietHoaDonNhap where MaThuoc = @ma)
	end
end
GO
/****** Object:  Trigger [dbo].[tr_delete_Chitiethoadonnhap]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[tr_delete_Chitiethoadonnhap]
on [dbo].[ChiTietHoaDonNhap]
after delete
as begin	
	declare @MaHDN int=(select MaHDN From deleted );
	declare @Sum money = (select TongTienThuoc From HoaDonNhap where MaHDN=@MaHDN);

	declare @sl int = (select SoLuong from deleted);
	declare @GiaNhap money = (select GiaNhap from deleted);
	set @Sum = @Sum - @sl*@GiaNhap;
	
	Update HoaDonNhap  set HoaDonNhap.TongTienThuoc = @Sum where MaHDN =@MaHDN
end
GO
/****** Object:  Trigger [dbo].[tg_Update_ChiTietHDX]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[tg_Update_ChiTietHDX]
on [dbo].[ChiTietHoaDonXuat]
after update
as
begin
	declare @MaHDX int=(select MaHDX from deleted);
	declare @slcu int=(select SoLuong from deleted);
	declare @slmoi int=(select SoLuong from inserted);
	declare @sum money =(select TongTien from HoaDonXuat where MaHDX=@MaHDX);
	declare @GiaBan money=(select GiaBan from Thuoc where MaThuoc=(select MaThuoc from deleted));
	set @sum=@sum -(@slcu * @GiaBan)+(@slmoi * @GiaBan);

	update HoaDonXuat set TongTien=@sum where HoaDonXuat.MaHDX=@MaHDX;
end
GO
/****** Object:  Trigger [dbo].[tr_AddTongXuat]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[tr_AddTongXuat]
on [dbo].[ChiTietHoaDonXuat]
instead of insert
as begin
	
	INSERT INTO ChiTietHoaDonXuat(MaHDX , MaThuoc , SoLuong) SELECT MaHDX , MaThuoc , SoLuong FROM INSERTED
	--Tinh tong tien
	declare @id int =  (select SCOPE_IDENTITY() AS [SCOPE_IDENTITY]);  
	declare @Sum money = (select TongTien From HoaDonXuat where MaHDX in (select MaHDX from inserted));
	declare @sl int = (select SoLuong from inserted);
	declare @gb money = (select GiaBan from Thuoc where MaThuoc in (select MaThuoc From ChiTietHoaDonXuat where MaCTHDX = @id));
	set @Sum = @Sum + @sl * @gb;
	Update HoaDonXuat set TongTien = @Sum where MaHDX in (select MaHDX from ChiTietHoaDonXuat where MaCTHDX = @id);

	--cong don soluong thuoc
	declare @ma int = (select MaThuoc From inserted);
	if ((select count(MaThuoc) from ChiTietHoaDonXuat where MaThuoc = @ma and MaHDX = (select MaHDX from inserted)) >=2)
	begin
		select MaThuoc from ChiTietHoaDonXuat where MaThuoc = @ma and MaHDX = (select MaHDX from inserted)
		delete ChiTietHoaDonXuat where MaCTHDX = @id
		declare @sl2 int = (select SoLuong from ChiTietHoaDonXuat where MaThuoc = @ma and MaHDX = (select MaHDX from inserted));
		set @sl2 = @sl2 + (select SoLuong From inserted)
		Update ChiTietHoaDonXuat set SoLuong = @sl2 where MaCTHDX in (select MaCTHDX from ChiTietHoaDonXuat where MaThuoc = @ma)
	end
end
GO
/****** Object:  Trigger [dbo].[tr_delete_Chitiethoadonxuat]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[tr_delete_Chitiethoadonxuat]
on [dbo].[ChiTietHoaDonXuat]
after delete
as begin	
	select * from deleted
	select MaCTHDX from deleted
	declare @MaHDX int=(select MaHDX From deleted );
	declare @Sum money = (select TongTien From HoaDonXuat where MaHDX=@MaHDX);

	declare @sl int = (select SoLuong from deleted);
	declare @GiaBan money = (select GiaBan from Thuoc where MaThuoc =(select MaThuoc from deleted));
	set @Sum = @Sum - @sl*@GiaBan;
	print @sl
	Update HoaDonXuat  set HoaDonXuat.TongTien = @Sum where MaHDX =@MaHDX
end
GO
/****** Object:  Trigger [dbo].[tg_HoaDonNhap]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[tg_HoaDonNhap]
on [dbo].[HoaDonNhap]
instead of delete
as
begin
	declare @MaHDN int=(select MaHDN from deleted);
	delete from ChiTietHoaDonNhap where MaHDN=@MaHDN;
	delete from HoaDonNhap where MaHDN=@MaHDN;
end
GO
/****** Object:  Trigger [dbo].[tg_HoaDonXuat]    Script Date: 3/6/2017 8:13:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[tg_HoaDonXuat]
ON [dbo].[HoaDonXuat]
instead of delete
as
begin 
	declare @MaHDX int = (select MaHDX from deleted);
	delete from ChiTietHoaDonXuat where MaHDX = @MaHDX;
	delete from HoaDonXuat where MaHDX = @MaHDX;
end
GO
USE [master]
GO
ALTER DATABASE [dbThuoc] SET  READ_WRITE 
GO
