SET IDENTITY_INSERT [dbo].[AttendanceType] ON
INSERT INTO [dbo].[AttendanceType] ([TypeId], [TypeName], [TypeDescription], [CreatedDate], [ModifiedDate]) VALUES (1, N'InPerson', N'Attending the forum in person', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[AttendanceType] ([TypeId], [TypeName], [TypeDescription], [CreatedDate], [ModifiedDate]) VALUES (2, N'WebEx', N'Attending via web conferencing', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[AttendanceType] ([TypeId], [TypeName], [TypeDescription], [CreatedDate], [ModifiedDate]) VALUES (3, N'Recording', N'Attending by viewing the recording later.', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
SET IDENTITY_INSERT [dbo].[AttendanceType] OFF
