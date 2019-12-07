SET IDENTITY_INSERT [dbo].[SalesTransaction] ON
INSERT INTO [dbo].[SalesTransaction] ([Id], [BuyerId], [PropertyId]) VALUES (1, 1, 3)
INSERT INTO [dbo].[SalesTransaction] ([Id], [BuyerId], [PropertyId]) VALUES (2, 1, 1)
SET IDENTITY_INSERT [dbo].[SalesTransaction] OFF
