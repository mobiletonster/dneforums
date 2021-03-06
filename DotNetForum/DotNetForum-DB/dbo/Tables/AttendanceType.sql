﻿CREATE TABLE [dbo].[AttendanceType] (
    [TypeId]          INT           IDENTITY (1, 1) NOT NULL,
    [TypeName]        VARCHAR (100) NULL,
    [TypeDescription] VARCHAR (250) NULL,
    [CreatedDate]     DATETIME      NULL,
    [ModifiedDate]    DATETIME      NULL,
    CONSTRAINT [PK_AttendanceType] PRIMARY KEY CLUSTERED ([TypeId] ASC)
);

