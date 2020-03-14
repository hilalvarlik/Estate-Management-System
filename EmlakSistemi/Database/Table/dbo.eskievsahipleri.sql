USE [Emlak]
GO

/****** Object:  Table [dbo].[eskievsahipleri]    Script Date: 14.03.2020 16:45:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[eskievsahipleri](
	[id] [int] NOT NULL,
	[adý] [nvarchar](50) NOT NULL,
	[telefon] [char](10) NOT NULL
) ON [PRIMARY]
GO


