USE [Emlak]
GO

/****** Object:  Table [dbo].[emlakekleme]    Script Date: 14.03.2020 16:43:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[emlakekleme](
	[site] [nvarchar](50) NOT NULL,
	[blok] [nvarchar](50) NOT NULL,
	[no] [int] NOT NULL,
	[katno] [int] NOT NULL,
	[metrekare] [int] NOT NULL,
	[odasayisi] [nvarchar](50) NOT NULL,
	[evdurumu] [nvarchar](50) NOT NULL,
	[fiyat] [int] NOT NULL
) ON [PRIMARY]
GO


