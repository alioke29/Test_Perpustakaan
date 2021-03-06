USE [TestPerpustakaan]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 7/18/2021 9:56:02 PM ******/
DROP TABLE [dbo].[Users]
GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 7/18/2021 9:56:02 PM ******/
DROP TABLE [dbo].[UserRoles]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 7/18/2021 9:56:02 PM ******/
DROP TABLE [dbo].[Role]
GO
/****** Object:  Table [dbo].[Peminjaman]    Script Date: 7/18/2021 9:56:02 PM ******/
DROP TABLE [dbo].[Peminjaman]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 7/18/2021 9:56:02 PM ******/
DROP TABLE [dbo].[Menu]
GO
/****** Object:  Table [dbo].[Location]    Script Date: 7/18/2021 9:56:02 PM ******/
DROP TABLE [dbo].[Location]
GO
/****** Object:  Table [dbo].[Buku]    Script Date: 7/18/2021 9:56:02 PM ******/
DROP TABLE [dbo].[Buku]
GO
/****** Object:  Table [dbo].[Buku]    Script Date: 7/18/2021 9:56:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Buku](
	[ID] [bigint] IDENTITY(4,1) NOT NULL,
	[JudulBuku] [nvarchar](100) NULL,
	[Pengarang] [nvarchar](100) NULL,
	[JenisBuku] [nvarchar](50) NULL,
	[HargaSewa] [decimal](12, 2) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_Buku] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Location]    Script Date: 7/18/2021 9:56:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location](
	[ID] [bigint] IDENTITY(4,1) NOT NULL,
	[Code] [nvarchar](10) NULL,
	[LocationName] [nvarchar](100) NULL,
	[Desc] [nvarchar](200) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Menu]    Script Date: 7/18/2021 9:56:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[ID] [bigint] IDENTITY(4,1) NOT NULL,
	[Code] [nvarchar](4) NULL,
	[DisplayName] [nvarchar](100) NULL,
	[UrlNav] [nvarchar](200) NULL,
	[ParentMenuCode] [nvarchar](4) NULL,
	[SortNumber] [nvarchar](2) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdateBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Peminjaman]    Script Date: 7/18/2021 9:56:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Peminjaman](
	[ID] [bigint] IDENTITY(4,1) NOT NULL,
	[IDUser] [bigint] NULL,
	[IDBuku] [bigint] NULL,
	[TanggalMulai] [datetime] NULL,
	[TanggalSelesai] [datetime] NULL,
	[TotalSewa] [decimal](12, 2) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_Peminjaman] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Role]    Script Date: 7/18/2021 9:56:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [bigint] IDENTITY(4,1) NOT NULL,
	[RoleName] [nvarchar](100) NOT NULL,
	[Desc] [nvarchar](200) NOT NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 7/18/2021 9:56:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoles](
	[ID] [bigint] IDENTITY(4,1) NOT NULL,
	[IDRole] [bigint] NULL,
	[MenuCode] [nvarchar](4) NULL,
	[ParentMenuCode] [nvarchar](4) NULL,
	[IsActiveMenu] [bit] NULL,
	[IsAdd] [bit] NULL,
	[IsEdit] [bit] NULL,
	[IsDelete] [bit] NULL,
	[IsExport] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdateBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 7/18/2021 9:56:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [bigint] IDENTITY(4,1) NOT NULL,
	[IDRole] [bigint] NULL,
	[IDLocation] [bigint] NULL,
	[Code] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](20) NULL,
	[Fullname] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[Password] [nvarchar](max) NULL,
	[IsLogin] [bit] NULL,
	[IsActive] [bit] NULL,
	[LastLoginDate] [datetime] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Buku] ON 

INSERT [dbo].[Buku] ([ID], [JudulBuku], [Pengarang], [JenisBuku], [HargaSewa], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (4, N'Perjuangan Rakyat', N'Ilham Randi', N'Non Fiksi', CAST(45000.00 AS Decimal(12, 2)), CAST(0x0000AD5800000000 AS DateTime), N'System', NULL, NULL)
INSERT [dbo].[Buku] ([ID], [JudulBuku], [Pengarang], [JenisBuku], [HargaSewa], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (5, N'Dongeng Raja Singa', N'Perdana Sakti', N'Fiksi', CAST(25000.00 AS Decimal(12, 2)), CAST(0x0000AD5800000000 AS DateTime), N'System', CAST(0x0000AD6900EC73BC AS DateTime), N'admin')
INSERT [dbo].[Buku] ([ID], [JudulBuku], [Pengarang], [JenisBuku], [HargaSewa], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (6, N'Mutasi Corona', N'Gery Manurung', N'Non Fiksi', CAST(50000.00 AS Decimal(12, 2)), CAST(0x0000AD5800000000 AS DateTime), N'System', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Buku] OFF
SET IDENTITY_INSERT [dbo].[Location] ON 

INSERT [dbo].[Location] ([ID], [Code], [LocationName], [Desc], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (4, N'JKT', N'Jakarta', NULL, CAST(0x0000AD6800000000 AS DateTime), N'System', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Location] OFF
SET IDENTITY_INSERT [dbo].[Menu] ON 

INSERT [dbo].[Menu] ([ID], [Code], [DisplayName], [UrlNav], [ParentMenuCode], [SortNumber], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (4, N'M1', N'Security Management', N'-', N'', N'0', CAST(0x0000ACAE00F09ED3 AS DateTime), N'system', CAST(0x0000ACB301061F51 AS DateTime), N'System')
INSERT [dbo].[Menu] ([ID], [Code], [DisplayName], [UrlNav], [ParentMenuCode], [SortNumber], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (5, N'M1A', N'Master User', N'UserList', N'M1', N'1', CAST(0x0000A8AE00000000 AS DateTime), N'system', NULL, NULL)
INSERT [dbo].[Menu] ([ID], [Code], [DisplayName], [UrlNav], [ParentMenuCode], [SortNumber], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (6, N'M1B', N'Master Role', N'RoleList', N'M1', N'2', CAST(0x0000ACAE00F09ED3 AS DateTime), N'System', CAST(0x0000ACAE00F09ED3 AS DateTime), N'System')
INSERT [dbo].[Menu] ([ID], [Code], [DisplayName], [UrlNav], [ParentMenuCode], [SortNumber], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (9, N'M2', N'Master', N'-', N'', N'0', CAST(0x0000ACAE00F09ED3 AS DateTime), N'System', NULL, NULL)
INSERT [dbo].[Menu] ([ID], [Code], [DisplayName], [UrlNav], [ParentMenuCode], [SortNumber], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (10, N'M2A', N'Buku', N'BukuList', N'M2', N'1', CAST(0x0000ACAE00F09ED3 AS DateTime), N'System', NULL, NULL)
INSERT [dbo].[Menu] ([ID], [Code], [DisplayName], [UrlNav], [ParentMenuCode], [SortNumber], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (11, N'M3', N'Transaction', N'-', N'', N'0', CAST(0x0000ACAE00F09ED3 AS DateTime), N'System', NULL, NULL)
INSERT [dbo].[Menu] ([ID], [Code], [DisplayName], [UrlNav], [ParentMenuCode], [SortNumber], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (12, N'M3A', N'Peminjaman Buku', N'PinjamList', N'M3', N'1', CAST(0x0000ACAE00F09ED3 AS DateTime), N'System', NULL, NULL)
INSERT [dbo].[Menu] ([ID], [Code], [DisplayName], [UrlNav], [ParentMenuCode], [SortNumber], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (13, N'M4', N'Report', N'-', N'', N'0', CAST(0x0000ACAE00F09ED3 AS DateTime), N'System', NULL, NULL)
INSERT [dbo].[Menu] ([ID], [Code], [DisplayName], [UrlNav], [ParentMenuCode], [SortNumber], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (14, N'M4A', N'Peminjaman Buku', N'RepPinjamList', N'M4', N'1', CAST(0x0000ACAE00F09ED3 AS DateTime), N'System', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Menu] OFF
SET IDENTITY_INSERT [dbo].[Peminjaman] ON 

INSERT [dbo].[Peminjaman] ([ID], [IDUser], [IDBuku], [TanggalMulai], [TanggalSelesai], [TotalSewa], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (4, 5, 4, CAST(0x0000AD6100000000 AS DateTime), CAST(0x0000AD7600000000 AS DateTime), CAST(945000.00 AS Decimal(12, 2)), CAST(0x0000AD5800000000 AS DateTime), N'System', CAST(0x0000AD690146007B AS DateTime), N'iwan')
INSERT [dbo].[Peminjaman] ([ID], [IDUser], [IDBuku], [TanggalMulai], [TanggalSelesai], [TotalSewa], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (5, 5, 6, CAST(0x0000AD6B00000000 AS DateTime), CAST(0x0000AD7B00000000 AS DateTime), CAST(800000.00 AS Decimal(12, 2)), CAST(0x0000AD5800000000 AS DateTime), N'System', CAST(0x0000AD690146CBE2 AS DateTime), N'iwan')
INSERT [dbo].[Peminjaman] ([ID], [IDUser], [IDBuku], [TanggalMulai], [TanggalSelesai], [TotalSewa], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (7, 6, 5, CAST(0x0000AD6B00000000 AS DateTime), CAST(0x0000AD7B00000000 AS DateTime), CAST(0.00 AS Decimal(12, 2)), NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Peminjaman] OFF
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([ID], [RoleName], [Desc], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (4, N'Administrator', N'User Super Admistrator :<br />- test 123<br />- 456<br />- ok nice', CAST(0x0000AD2400F980B1 AS DateTime), N'admin', CAST(0x0000AD2400F980B1 AS DateTime), N'admin')
INSERT [dbo].[Role] ([ID], [RoleName], [Desc], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (5, N'Penyewa', N'Penyewa', CAST(0x0000AD2400F980B1 AS DateTime), N'admin', CAST(0x0000AD2400F980B1 AS DateTime), N'admin')
SET IDENTITY_INSERT [dbo].[Role] OFF
SET IDENTITY_INSERT [dbo].[UserRoles] ON 

INSERT [dbo].[UserRoles] ([ID], [IDRole], [MenuCode], [ParentMenuCode], [IsActiveMenu], [IsAdd], [IsEdit], [IsDelete], [IsExport], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (4, 4, N'M1', N'', 1, 0, 0, 0, 0, CAST(0x0000A61300000000 AS DateTime), N'admin', CAST(0x0000ACD300BB0572 AS DateTime), N'admin')
INSERT [dbo].[UserRoles] ([ID], [IDRole], [MenuCode], [ParentMenuCode], [IsActiveMenu], [IsAdd], [IsEdit], [IsDelete], [IsExport], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (5, 4, N'M1A', N'M1', 1, 0, 0, 0, 0, CAST(0x0000A61300000000 AS DateTime), N'admin', CAST(0x0000ACD300BB057B AS DateTime), N'admin')
INSERT [dbo].[UserRoles] ([ID], [IDRole], [MenuCode], [ParentMenuCode], [IsActiveMenu], [IsAdd], [IsEdit], [IsDelete], [IsExport], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (6, 4, N'M1B', N'M1', 1, 0, 0, 0, 0, CAST(0x0000ACAE00F1384D AS DateTime), N'System', CAST(0x0000ACD300BB0584 AS DateTime), N'admin')
INSERT [dbo].[UserRoles] ([ID], [IDRole], [MenuCode], [ParentMenuCode], [IsActiveMenu], [IsAdd], [IsEdit], [IsDelete], [IsExport], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (9, 4, N'M2', N'', 1, 0, 0, 0, 0, CAST(0x0000A61300000000 AS DateTime), N'admin', CAST(0x0000ACD300BB0572 AS DateTime), N'admin')
INSERT [dbo].[UserRoles] ([ID], [IDRole], [MenuCode], [ParentMenuCode], [IsActiveMenu], [IsAdd], [IsEdit], [IsDelete], [IsExport], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (10, 4, N'M2A', N'M2', 1, 0, 0, 0, 0, CAST(0x0000A61300000000 AS DateTime), N'admin', CAST(0x0000ACD300BB057B AS DateTime), N'admin')
INSERT [dbo].[UserRoles] ([ID], [IDRole], [MenuCode], [ParentMenuCode], [IsActiveMenu], [IsAdd], [IsEdit], [IsDelete], [IsExport], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (11, 4, N'M3', N'', 0, 0, 0, 0, 0, CAST(0x0000ACAE00F1384D AS DateTime), N'System', CAST(0x0000ACD300BB0584 AS DateTime), N'admin')
INSERT [dbo].[UserRoles] ([ID], [IDRole], [MenuCode], [ParentMenuCode], [IsActiveMenu], [IsAdd], [IsEdit], [IsDelete], [IsExport], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (12, 4, N'M3A', N'M3', 0, 0, 0, 0, 0, CAST(0x0000ACAE00F1384D AS DateTime), N'System', CAST(0x0000ACD300BB0584 AS DateTime), N'admin')
INSERT [dbo].[UserRoles] ([ID], [IDRole], [MenuCode], [ParentMenuCode], [IsActiveMenu], [IsAdd], [IsEdit], [IsDelete], [IsExport], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (13, 5, N'M1', N'', 0, 0, 0, 0, 0, CAST(0x0000A61300000000 AS DateTime), N'admin', CAST(0x0000ACD300BB0572 AS DateTime), N'admin')
INSERT [dbo].[UserRoles] ([ID], [IDRole], [MenuCode], [ParentMenuCode], [IsActiveMenu], [IsAdd], [IsEdit], [IsDelete], [IsExport], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (14, 5, N'M1A', N'M1', 0, 0, 0, 0, 0, CAST(0x0000A61300000000 AS DateTime), N'admin', CAST(0x0000ACD300BB057B AS DateTime), N'admin')
INSERT [dbo].[UserRoles] ([ID], [IDRole], [MenuCode], [ParentMenuCode], [IsActiveMenu], [IsAdd], [IsEdit], [IsDelete], [IsExport], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (15, 5, N'M1B', N'M1', 0, 0, 0, 0, 0, CAST(0x0000ACAE00F1384D AS DateTime), N'System', CAST(0x0000ACD300BB0584 AS DateTime), N'admin')
INSERT [dbo].[UserRoles] ([ID], [IDRole], [MenuCode], [ParentMenuCode], [IsActiveMenu], [IsAdd], [IsEdit], [IsDelete], [IsExport], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (16, 5, N'M2', N'', 0, 0, 0, 0, 0, CAST(0x0000A61300000000 AS DateTime), N'admin', CAST(0x0000ACD300BB0572 AS DateTime), N'admin')
INSERT [dbo].[UserRoles] ([ID], [IDRole], [MenuCode], [ParentMenuCode], [IsActiveMenu], [IsAdd], [IsEdit], [IsDelete], [IsExport], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (17, 5, N'M2A', N'M2', 0, 0, 0, 0, 0, CAST(0x0000A61300000000 AS DateTime), N'admin', CAST(0x0000ACD300BB057B AS DateTime), N'admin')
INSERT [dbo].[UserRoles] ([ID], [IDRole], [MenuCode], [ParentMenuCode], [IsActiveMenu], [IsAdd], [IsEdit], [IsDelete], [IsExport], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (18, 5, N'M3', N'', 1, 0, 0, 0, 0, CAST(0x0000ACAE00F1384D AS DateTime), N'System', CAST(0x0000ACD300BB0584 AS DateTime), N'admin')
INSERT [dbo].[UserRoles] ([ID], [IDRole], [MenuCode], [ParentMenuCode], [IsActiveMenu], [IsAdd], [IsEdit], [IsDelete], [IsExport], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (19, 5, N'M3A', N'M3', 1, 0, 0, 0, 0, CAST(0x0000ACAE00F1384D AS DateTime), N'System', CAST(0x0000ACD300BB0584 AS DateTime), N'admin')
INSERT [dbo].[UserRoles] ([ID], [IDRole], [MenuCode], [ParentMenuCode], [IsActiveMenu], [IsAdd], [IsEdit], [IsDelete], [IsExport], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (20, 4, N'M4', N'', 1, 0, 0, 0, 0, CAST(0x0000ACAE00F1384D AS DateTime), N'System', CAST(0x0000ACD300BB0584 AS DateTime), N'admin')
INSERT [dbo].[UserRoles] ([ID], [IDRole], [MenuCode], [ParentMenuCode], [IsActiveMenu], [IsAdd], [IsEdit], [IsDelete], [IsExport], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (21, 4, N'M4A', N'M4', 1, 0, 0, 0, 0, CAST(0x0000ACAE00F1384D AS DateTime), N'System', CAST(0x0000ACD300BB0584 AS DateTime), N'admin')
INSERT [dbo].[UserRoles] ([ID], [IDRole], [MenuCode], [ParentMenuCode], [IsActiveMenu], [IsAdd], [IsEdit], [IsDelete], [IsExport], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (22, 5, N'M4', N'', 1, 0, 0, 0, 0, CAST(0x0000ACAE00F1384D AS DateTime), N'System', CAST(0x0000ACD300BB0584 AS DateTime), N'admin')
INSERT [dbo].[UserRoles] ([ID], [IDRole], [MenuCode], [ParentMenuCode], [IsActiveMenu], [IsAdd], [IsEdit], [IsDelete], [IsExport], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdateBy]) VALUES (23, 5, N'M4A', N'M4', 1, 0, 0, 0, 0, CAST(0x0000ACAE00F1384D AS DateTime), N'System', CAST(0x0000ACD300BB0584 AS DateTime), N'admin')
SET IDENTITY_INSERT [dbo].[UserRoles] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([ID], [IDRole], [IDLocation], [Code], [UserName], [Fullname], [Email], [Password], [IsLogin], [IsActive], [LastLoginDate], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (4, 4, 4, N'4', N'admin', N'User Administrator', N'admin@yahoo.com', N'lDhAPRogMl5q+1iw3rGSKw==', 0, 1, CAST(0x0000AD6901697579 AS DateTime), CAST(0x0000ACAE0117AD9A AS DateTime), N'System', CAST(0x0000ACCE009E371D AS DateTime), N'admin')
INSERT [dbo].[Users] ([ID], [IDRole], [IDLocation], [Code], [UserName], [Fullname], [Email], [Password], [IsLogin], [IsActive], [LastLoginDate], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (5, 5, 4, N'4', N'iwan', N'Iwan Setiawan', N'iwan@yahoo.com', N'lDhAPRogMl5q+1iw3rGSKw==', 0, 1, CAST(0x0000AD69015A7A72 AS DateTime), CAST(0x0000ACAE0117AD9A AS DateTime), N'System', NULL, NULL)
INSERT [dbo].[Users] ([ID], [IDRole], [IDLocation], [Code], [UserName], [Fullname], [Email], [Password], [IsLogin], [IsActive], [LastLoginDate], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (6, 5, 4, N'4', N'desy', N'Desy Agutin', N'desy@yahoo.com', N'lDhAPRogMl5q+1iw3rGSKw==', 0, 1, CAST(0x0000AD690158202E AS DateTime), CAST(0x0000ACAE0117AD9A AS DateTime), N'System', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
