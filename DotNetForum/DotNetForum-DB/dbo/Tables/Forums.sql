CREATE TABLE [dbo].[Forums] (
    [ForumId]          INT           IDENTITY (1, 1) NOT NULL,
    [ForumName]        VARCHAR (100) NULL,
    [ForumDescription] VARCHAR (250) NULL,
    [ForumPresenters]  VARCHAR (250) NULL,
    [ForumDate]        DATETIME      NULL,
    [CreatedDate]      DATETIME      NULL,
    [ModifiedDate]     DATETIME      NULL,
    CONSTRAINT [PK_Forums] PRIMARY KEY CLUSTERED ([ForumId] ASC)
);

