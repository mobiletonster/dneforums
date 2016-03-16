CREATE TABLE [dbo].[Users] (
    [UserId]       INT           IDENTITY (1, 1) NOT NULL,
    [UserName]     VARCHAR (100) NULL,
    [Password]     VARCHAR (100) NULL,
    [FirstName]    VARCHAR (50)  NULL,
    [LastName]     VARCHAR (50)  NULL,
    [BirthDate]    DATETIME      NULL,
    [Email]        VARCHAR (100) NULL,
    [CreatedDate]  DATETIME      NULL,
    [ModifiedDate] DATETIME      NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserId] ASC)
);



