USE [Emlak]
GO

/****** Object:  Table [dbo].[kullanicilar]    Script Date: 14.03.2020 16:46:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[kullanicilar](
	[email] [nvarchar](50) NOT NULL,
	[kullaniciadi] [nvarchar](50) NOT NULL,
	[parola] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO


