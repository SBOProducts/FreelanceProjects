/****** Object:  Table [dbo].[Property]    Script Date: 10/26/2014 9:53:15 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[Property](
	[PropertyId] [int] IDENTITY(1,1) NOT NULL,
	[PageId] [int] NOT NULL,
	[ArticleHtml] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Lat] [varchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Long] [varchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PhotoUrl] [varchar](900) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PhotoCaption] [varchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Price] [varchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[SoldDate] [varchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Zestimate] [varchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PriceSQFt] [varchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Address] [varchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PropertyData] [varchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[LotSize] [varchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[YearBuilt] [varchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_Property] PRIMARY KEY CLUSTERED 
(
	[PropertyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

