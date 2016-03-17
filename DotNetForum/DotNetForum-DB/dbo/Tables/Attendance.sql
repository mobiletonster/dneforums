CREATE TABLE [dbo].[Attendance] (
    [ForumId]          INT      NOT NULL,
    [UserId]           INT      NOT NULL,
    [AttendanceTypeId] INT      NULL,
    [CreatedDate]      DATETIME NULL,
    [ModifiedDate]     DATETIME NULL,
    CONSTRAINT [PK_Attendance] PRIMARY KEY CLUSTERED ([ForumId] ASC, [UserId] ASC)
);



