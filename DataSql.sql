USE [OnlineCarShowroom]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 1/26/2022 7:22:14 PM ******/
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
/****** Object:  Table [dbo].[Cars]    Script Date: 1/26/2022 7:22:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CarName] [nvarchar](max) NULL,
	[Price] [float] NOT NULL,
	[CarImage] [nvarchar](max) NULL,
	[Type] [int] NULL,
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Companyes]    Script Date: 1/26/2022 7:22:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Companyes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CName] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Logo] [nvarchar](max) NULL,
 CONSTRAINT [PK_Companyes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220126062958_InitialCatalog', N'5.0.0')
GO
SET IDENTITY_INSERT [dbo].[Cars] ON 

INSERT [dbo].[Cars] ([Id], [CarName], [Price], [CarImage], [Type]) VALUES (11, N'Car1', 60000, N'~/uploads/CarBMW.jfif', 3)
INSERT [dbo].[Cars] ([Id], [CarName], [Price], [CarImage], [Type]) VALUES (12, N'Car2', 65000, N'~/uploads/Car2BMW.jfif', 3)
SET IDENTITY_INSERT [dbo].[Cars] OFF
GO
SET IDENTITY_INSERT [dbo].[Companyes] ON 

INSERT [dbo].[Companyes] ([Id], [CName], [Description], [Logo]) VALUES (1, N'mercedes', N'It is a German global automotive brand and is a subsidiary of Daimler. Mercedes-Benz is known for its luxury vehicles, vans, trucks, buses and ambulances. It is headquartered in Stuttgart in the state of Baden-Württemberg. The brand first appeared in 1926 with the birth of Daimler-Benz.', N'~/uploads/Mersides.jfif')
INSERT [dbo].[Companyes] ([Id], [CName], [Description], [Logo]) VALUES (3, N'BMW', N'BMW Automobiles Bayerische Motoren Werke AG, commonly known as Bavarian Motor Works, BMW or BMW AG, is a German automobile, motorcycle and engine manufacturing company founded in 1916. BMW is headquartered in Munich, Bavaria. It also owns and produces Mini cars, and is the parent company of Rolls-Royce Motor Cars', N'~/uploads/bmw-logo.png')
SET IDENTITY_INSERT [dbo].[Companyes] OFF
GO
