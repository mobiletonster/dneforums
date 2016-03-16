CREATE TABLE [dbo].[UserTalents] (
    [UserId]            INT      NOT NULL,
    [TalentId]          INT      NOT NULL,
    [TalentProficiency] INT      NULL,
    [CreatedDate]       DATETIME NULL,
    [ModifiedDate]      DATETIME NULL,
    CONSTRAINT [PK_UserTalents] PRIMARY KEY CLUSTERED ([UserId] ASC, [TalentId] ASC)
);

