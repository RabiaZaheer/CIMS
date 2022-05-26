/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
USE [CIMS]

GO
/****** Object:  Table [dbo].[user_details]    ******/

SET IDENTITY_INSERT [dbo].[user_details] ON

INSERT [dbo].[user_details] ([UserId], [Username], [Password]) VALUES (5, N'Joe Green', N'password')

INSERT [dbo].[user_details] ([UserId], [Username], [Password]) VALUES (6, N'Jack Black', N'password')

SET IDENTITY_INSERT [dbo].[user_details] OFF
