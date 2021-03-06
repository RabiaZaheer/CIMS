USE [CIMS]
GO
/****** Object:  Table [dbo].[Contact_Details]    Script Date: 25/05/2022 1:15:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact_Details](
	[ContactID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LasName] [nvarchar](50) NULL,
	[MobileNumber] [nvarchar](15) NULL,
	[EmailId] [nvarchar](75) NULL,
	[DOB] [datetime] NULL,
 CONSTRAINT [PK_Contact_Details] PRIMARY KEY CLUSTERED 
(
	[ContactID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_details]    Script Date: 25/05/2022 1:15:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_details](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_user_details] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Contact_Details] ON 

INSERT [dbo].[Contact_Details] ([ContactID], [FirstName], [LasName], [MobileNumber], [EmailId], [DOB]) VALUES (1, N'Smith', N'John', N'0419262334', N'js@hotmail.com', CAST(N'1990-12-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Contact_Details] ([ContactID], [FirstName], [LasName], [MobileNumber], [EmailId], [DOB]) VALUES (2, N'Jones', N'Jack', N'0411925383', N'JJ@yahoo.com', CAST(N'1991-08-31T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Contact_Details] OFF
GO
SET IDENTITY_INSERT [dbo].[user_details] ON 

INSERT [dbo].[user_details] ([UserId], [Username], [Password]) VALUES (1, N'John Smith', N'password')
INSERT [dbo].[user_details] ([UserId], [Username], [Password]) VALUES (2, N'Jack Jones', N'password')
INSERT [dbo].[user_details] ([UserId], [Username], [Password]) VALUES (5, N'Joe Green', N'password')
INSERT [dbo].[user_details] ([UserId], [Username], [Password]) VALUES (6, N'Jack Black', N'password')
SET IDENTITY_INSERT [dbo].[user_details] OFF
GO
