SET IDENTITY_INSERT [dbo].[MessagingType] ON
INSERT INTO [dbo].[MessagingType] ([Id], [MethodName]) VALUES (1, N'SMS')
INSERT INTO [dbo].[MessagingType] ([Id], [MethodName]) VALUES (2, N'Online')
SET IDENTITY_INSERT [dbo].[MessagingType] OFF
SET IDENTITY_INSERT [dbo].[Receiver] ON
INSERT INTO [dbo].[Receiver] ([Id], [ReceiverName], [ReceiverEmail], [RecieverMobile]) VALUES (1, N'Chris Miller', N'chris@gmail.com', N'02188893456')
INSERT INTO [dbo].[Receiver] ([Id], [ReceiverName], [ReceiverEmail], [RecieverMobile]) VALUES (2, N'Lance Harrison ', N'lance@gmail.com', N'02144435678')
SET IDENTITY_INSERT [dbo].[Receiver] OFF
SET IDENTITY_INSERT [dbo].[Sender] ON
INSERT INTO [dbo].[Sender] ([Id], [SenderName], [SenderEmail]) VALUES (1, N'Frank Stuart', N'frank@gmail.com')
INSERT INTO [dbo].[Sender] ([Id], [SenderName], [SenderEmail]) VALUES (2, N'Jimmy Hemsworth', N'jimmy@gmail.com')
SET IDENTITY_INSERT [dbo].[Sender] OFF
SET IDENTITY_INSERT [dbo].[Message] ON
INSERT INTO [dbo].[Message] ([Id], [SenderId], [ReceiverId], [MessagingTypeId], [MessageBody]) VALUES (1, 1, 1, 2, N'Hello I am sending an online message')
INSERT INTO [dbo].[Message] ([Id], [SenderId], [ReceiverId], [MessagingTypeId], [MessageBody]) VALUES (2, 2, 2, 1, N'Hello this is an SMS initiated via Web')
SET IDENTITY_INSERT [dbo].[Message] OFF
