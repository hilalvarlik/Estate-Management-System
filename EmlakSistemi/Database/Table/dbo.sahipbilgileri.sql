USE [Emlak]
GO

/****** Object:  Table [dbo].[sahipbilgileri]    Script Date: 14.03.2020 16:47:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[sahipbilgileri](
	[id] [int] NOT NULL,
	[adý] [nvarchar](50) NOT NULL,
	[telefon] [char](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


