SET IDENTITY_INSERT [dbo].[Talents] ON
INSERT INTO [dbo].[Talents] ([TalentId], [TalentName], [TalentDescription], [CreatedDate], [ModifiedDate]) VALUES (1, N'C#', N'C# Development Language', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[Talents] ([TalentId], [TalentName], [TalentDescription], [CreatedDate], [ModifiedDate]) VALUES (2, N'JavaScript', N'Javascript language', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[Talents] ([TalentId], [TalentName], [TalentDescription], [CreatedDate], [ModifiedDate]) VALUES (3, N'HTML/CSS', N'HTML and CSS', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[Talents] ([TalentId], [TalentName], [TalentDescription], [CreatedDate], [ModifiedDate]) VALUES (4, N'NodeJS', N'Node JS stack', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[Talents] ([TalentId], [TalentName], [TalentDescription], [CreatedDate], [ModifiedDate]) VALUES (5, N'XAML', N'XAML declarative markup language', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[Talents] ([TalentId], [TalentName], [TalentDescription], [CreatedDate], [ModifiedDate]) VALUES (6, N'ASP.Net', N'ASP.Net WebApi', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[Talents] ([TalentId], [TalentName], [TalentDescription], [CreatedDate], [ModifiedDate]) VALUES (7, N'Management', N'Managing People or herding cats', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
SET IDENTITY_INSERT [dbo].[Talents] OFF

SET IDENTITY_INSERT [dbo].[Users] ON
INSERT INTO [dbo].[Users] ([UserId], [UserName], [FirstName], [LastName], [BirthDate], [Email], [CreatedDate], [ModifiedDate]) VALUES (1, N'mobiletonster', N'Tony', N'Spencer', N'1969-01-04 00:00:00', N'mobiletony@msn.com', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[Users] ([UserId], [UserName], [FirstName], [LastName], [BirthDate], [Email], [CreatedDate], [ModifiedDate]) VALUES (2, N'byerje', N'Jim', N'Byer', NULL, N'byerje@ldschurch.org', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[Users] ([UserId], [UserName], [FirstName], [LastName], [BirthDate], [Email], [CreatedDate], [ModifiedDate]) VALUES (3, N'gibby', N'Michael', N'Gibby', NULL, N'michael@ldschurch.org', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[Users] ([UserId], [UserName], [FirstName], [LastName], [BirthDate], [Email], [CreatedDate], [ModifiedDate]) VALUES (4, N'worthingtonjg', N'Jon', N'Worthington', NULL, N'worthingtonjg@ldschurch.org', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
SET IDENTITY_INSERT [dbo].[Users] OFF


SET IDENTITY_INSERT [dbo].[Forums] ON
INSERT INTO [dbo].[Forums] ([ForumId], [ForumName], [ForumDescription], [ForumPresenters], [ForumDate], [CreatedDate], [ModifiedDate]) VALUES (1, N'2015 November Forum', N'Never been a better time to be a .Net engineer', N'Tony Spencer', N'2015-11-04 00:00:00', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[Forums] ([ForumId], [ForumName], [ForumDescription], [ForumPresenters], [ForumDate], [CreatedDate], [ModifiedDate]) VALUES (2, N'2015 December Forum', N'Get down with Git and TFS', N'Dan Woodruff, David Reuckert', N'2015-12-09 00:00:00', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[Forums] ([ForumId], [ForumName], [ForumDescription], [ForumPresenters], [ForumDate], [CreatedDate], [ModifiedDate]) VALUES (3, N'2016 January Forum', N'Microsoft Technologies', N'Dave McKinstry', N'2016-01-27 00:00:00', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[Forums] ([ForumId], [ForumName], [ForumDescription], [ForumPresenters], [ForumDate], [CreatedDate], [ModifiedDate]) VALUES (4, N'2016 February Forum', N'Entity Framework', N'Tony Spencer', N'2016-02-25 00:00:00', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
SET IDENTITY_INSERT [dbo].[Forums] OFF

INSERT INTO [dbo].[Attendance] ([ForumId], [UserId], [AttendanceTypeId], [CreatedDate], [ModifiedDate]) VALUES (1, 1, 1, N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[Attendance] ([ForumId], [UserId], [AttendanceTypeId], [CreatedDate], [ModifiedDate]) VALUES (1, 2, 1, N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[Attendance] ([ForumId], [UserId], [AttendanceTypeId], [CreatedDate], [ModifiedDate]) VALUES (1, 3, 1, N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[Attendance] ([ForumId], [UserId], [AttendanceTypeId], [CreatedDate], [ModifiedDate]) VALUES (1, 4, 2, N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[Attendance] ([ForumId], [UserId], [AttendanceTypeId], [CreatedDate], [ModifiedDate]) VALUES (2, 1, 1, N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[Attendance] ([ForumId], [UserId], [AttendanceTypeId], [CreatedDate], [ModifiedDate]) VALUES (2, 2, 1, N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[Attendance] ([ForumId], [UserId], [AttendanceTypeId], [CreatedDate], [ModifiedDate]) VALUES (2, 3, 2, N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[Attendance] ([ForumId], [UserId], [AttendanceTypeId], [CreatedDate], [ModifiedDate]) VALUES (3, 1, 1, N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[Attendance] ([ForumId], [UserId], [AttendanceTypeId], [CreatedDate], [ModifiedDate]) VALUES (3, 2, 3, N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')

SET IDENTITY_INSERT [dbo].[ConnectionType] ON
INSERT INTO [dbo].[ConnectionType] ([TypeId], [TypeName], [TypeDescription], [CreatedDate], [ModifiedDate]) VALUES (1, N'Twitter', N'Twitter for tweeting', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[ConnectionType] ([TypeId], [TypeName], [TypeDescription], [CreatedDate], [ModifiedDate]) VALUES (2, N'Facebook', N'Facebook for posting', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[ConnectionType] ([TypeId], [TypeName], [TypeDescription], [CreatedDate], [ModifiedDate]) VALUES (3, N'Skype', N'Skype for messaging', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[ConnectionType] ([TypeId], [TypeName], [TypeDescription], [CreatedDate], [ModifiedDate]) VALUES (4, N'LinkedIn', N'Linked in for building phony circles of colleagues', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[ConnectionType] ([TypeId], [TypeName], [TypeDescription], [CreatedDate], [ModifiedDate]) VALUES (5, N'Slack', N'Slack for group messaging', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
SET IDENTITY_INSERT [dbo].[ConnectionType] OFF

INSERT INTO [dbo].[Connections] ([UserId], [TypeId], [Handle], [CreatedDate], [ModifiedDate]) VALUES (1, 1, N'mobiletonster', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[Connections] ([UserId], [TypeId], [Handle], [CreatedDate], [ModifiedDate]) VALUES (1, 2, N'tony@admonex.com', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[Connections] ([UserId], [TypeId], [Handle], [CreatedDate], [ModifiedDate]) VALUES (1, 3, N'mobiletony@msn.com', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[Connections] ([UserId], [TypeId], [Handle], [CreatedDate], [ModifiedDate]) VALUES (1, 5, N'@spencerto', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[Connections] ([UserId], [TypeId], [Handle], [CreatedDate], [ModifiedDate]) VALUES (2, 5, N'@byerje', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')

SET IDENTITY_INSERT [dbo].[AttendanceType] ON
INSERT INTO [dbo].[AttendanceType] ([TypeId], [TypeName], [TypeDescription], [CreatedDate], [ModifiedDate]) VALUES (1, N'InPerson', N'Attending the forum in person', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[AttendanceType] ([TypeId], [TypeName], [TypeDescription], [CreatedDate], [ModifiedDate]) VALUES (2, N'WebEx', N'Attending via web conferencing', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[AttendanceType] ([TypeId], [TypeName], [TypeDescription], [CreatedDate], [ModifiedDate]) VALUES (3, N'Recording', N'Attending by viewing the recording later.', N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
SET IDENTITY_INSERT [dbo].[AttendanceType] OFF

INSERT INTO [dbo].[UserTalents] ([UserId], [TalentId], [TalentProficiency], [CreatedDate], [ModifiedDate]) VALUES (1, 1, 4, N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[UserTalents] ([UserId], [TalentId], [TalentProficiency], [CreatedDate], [ModifiedDate]) VALUES (1, 2, 2, N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[UserTalents] ([UserId], [TalentId], [TalentProficiency], [CreatedDate], [ModifiedDate]) VALUES (2, 4, 4, N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[UserTalents] ([UserId], [TalentId], [TalentProficiency], [CreatedDate], [ModifiedDate]) VALUES (3, 7, 5, N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[UserTalents] ([UserId], [TalentId], [TalentProficiency], [CreatedDate], [ModifiedDate]) VALUES (4, 1, 5, N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
INSERT INTO [dbo].[UserTalents] ([UserId], [TalentId], [TalentProficiency], [CreatedDate], [ModifiedDate]) VALUES (4, 2, 3, N'2016-02-24 00:00:00', N'2016-02-24 00:00:00')
