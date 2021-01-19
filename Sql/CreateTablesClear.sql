drop Table [dbo].[Blog];
drop Table [dbo].[Comments];
drop Table [dbo].[Post];
drop Table [dbo].[User];

CREATE TABLE [dbo].[Blog] (
    [Id]              INT          NOT NULL identity(1,1),
    [UserID]          INT          NOT NULL,
    [BlogName]        VARCHAR (50) NOT NULL,
    [BackgroundImage] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Comments] (
    [Id]       INT          NOT NULL identity(1,1),
    [PostID]   INT          NOT NULL,
    [UserID]   INT          NOT NULL,
    [Title]    VARCHAR (50) NOT NULL,
    [Inserted] DATETIME     NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Post] (
    [Id]         INT          NOT NULL identity(1,1),
    [BlogId]     INT          NOT NULL,
    [Title]      VARCHAR (50) NOT NULL,
    [Data]       VARCHAR (2000) NOT NULL,
    [Inserted]   DATETIME     NULL,
    [TitleImage] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[User] (
    [Id]          INT          NOT NULL identity(1,1),
    [Email]       VARCHAR (50) NOT NULL,
    [Password]    VARCHAR (50) NOT NULL,
    [Name]        VARCHAR (50) NOT NULL,
    [Description] VARCHAR (50) NULL,
    [Type]        INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

ALTER TABLE [dbo].[Blog] WITH NOCHECK
    ADD CONSTRAINT [FK_Blog_UserID] FOREIGN KEY ([UserID]) REFERENCES [dbo].[User] ([Id]);
ALTER TABLE [dbo].[Comments] WITH NOCHECK
    ADD CONSTRAINT [FK_Comments_PostID] FOREIGN KEY ([PostID]) REFERENCES [dbo].[Post] ([Id]);
ALTER TABLE [dbo].[Comments] WITH NOCHECK
    ADD CONSTRAINT [FK_Comments_UserID] FOREIGN KEY ([UserID]) REFERENCES [dbo].[User] ([Id]);
ALTER TABLE [dbo].[Post] WITH NOCHECK
    ADD CONSTRAINT [FK_Post_BlogId] FOREIGN KEY ([BlogId]) REFERENCES [dbo].[Blog] ([Id]);

INSERT INTO [dbo].[User] values ('stanislaw.gilewicz@student.put.poznan.pl', 'password', 'admin', 'admin role', 2);