USE [Emlak]
GO

/****** Object:  Table [dbo].[evbilgileri]    Script Date: 14.03.2020 16:46:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[evbilgileri](
	[Site] [nvarchar](50) NOT NULL,
	[Blok] [nvarchar](50) NOT NULL,
	[No] [int] NOT NULL,
	[SahipId] [int] NOT NULL
) ON [PRIMARY]
GO


