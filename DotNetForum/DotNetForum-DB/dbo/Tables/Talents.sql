CREATE TABLE [dbo].[Talents] (
    [TalentId]          INT           IDENTITY (1, 1) NOT NULL,
    [TalentName]        VARCHAR (100) NULL,
    [TalentDescription] VARCHAR (250) NULL,
    [CreatedDate]       DATETIME      NULL,
    [ModifiedDate]      DATETIME      NULL,
    CONSTRAINT [PK_Talents] PRIMARY KEY CLUSTERED ([TalentId] ASC)
);

