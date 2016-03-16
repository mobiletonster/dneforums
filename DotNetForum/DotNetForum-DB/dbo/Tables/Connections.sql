CREATE TABLE [dbo].[Connections] (
    [UserId]       INT           NOT NULL,
    [TypeId]       INT           NOT NULL,
    [Handle]       VARCHAR (100) NULL,
    [CreatedDate]  DATETIME      NULL,
    [ModifiedDate] DATETIME      NULL,
    CONSTRAINT [PK_Connections] PRIMARY KEY CLUSTERED ([UserId] ASC, [TypeId] ASC)
);

