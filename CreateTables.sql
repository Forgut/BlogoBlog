CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Email] varchar(50) not null,
	[Password] varchar(50) not null,
	[Name] varchar(50) not null,
	[Description] varchar(50) null,
	[Type] int not null
)
