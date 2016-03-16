CREATE TABLE [dbo].[Attendance] (
    [ForumId]          INT      NOT NULL,
    [UserId]           INT      NOT NULL,
    [AttendanceTypeId] INT      NULL,
    [CreatedDate]      DATETIME NULL,
    [ModifiedDate]     DATETIME NULL,
    CONSTRAINT [PK_Attendance] PRIMARY KEY CLUSTERED ([ForumId] ASC, [UserId] ASC),
    CONSTRAINT [FK_Attendance_Forums] FOREIGN KEY ([ForumId]) REFERENCES [dbo].[Forums] ([ForumId]),
    CONSTRAINT [FK_Attendance_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId])
);

