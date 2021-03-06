/****** Object:  Table [dbo].[EdmMetadata]    Script Date: 07/23/2011 11:18:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EdmMetadata]') AND type in (N'U'))
DROP TABLE [dbo].[EdmMetadata]
GO
/****** Object:  Table [dbo].[Trips]    Script Date: 07/23/2011 11:18:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Trips]') AND type in (N'U'))
DROP TABLE [dbo].[Trips]
GO
/****** Object:  Table [dbo].[Trips]    Script Date: 07/23/2011 11:18:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Trips]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Trips](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OdometerStart] [int] NOT NULL,
	[OdometerEnd] [int] NOT NULL,
 CONSTRAINT [PK__Trips__3214EC0703317E3D] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[EdmMetadata]    Script Date: 07/23/2011 11:18:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EdmMetadata]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EdmMetadata](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ModelHash] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK__EdmMetad__3214EC077F60ED59] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[EdmMetadata] ON
INSERT [dbo].[EdmMetadata] ([Id], [ModelHash]) VALUES (1, N'6150ABA713ACC7316BD1E8D3F8C22482B9E790D311B770C50E1051409A0D7E28')
SET IDENTITY_INSERT [dbo].[EdmMetadata] OFF
