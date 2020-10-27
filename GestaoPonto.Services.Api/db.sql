USE [gestaoponto]
GO

CREATE TABLE [dbo].[PointRegisters](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CollaboratorId] [int] NULL,
	[Register] [datetimeoffset](7) NULL,
	[EventIdentifier] [char](10) NULL,
	PRIMARY KEY (ID)
);

CREATE TABLE [dbo].[Collaborators](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NULL,
	[Username] [varchar](255) NULL,
	[Password] [varchar](255) NULL,
	[Role] [varchar](255) NULL,
	PRIMARY KEY (ID)
) 