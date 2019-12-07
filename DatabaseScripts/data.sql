INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'6f9db833-0f49-45da-a105-0e196576b81f', N'properyAdmin', N'properyAdmin', N'9f028d88-a090-4b47-aad4-95932ff3a9af')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'94557f5a-f2ab-4a64-a1cb-59cead0b321d', N'buyer', N'buyer', N'2a4935ee-ff17-427a-b624-837f4af55727')
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'71fb276f-8e58-4b08-8c54-7972b20197ca', N'admin@property.com', N'ADMIN@PROPERTY.COM', N'admin@property.com', N'ADMIN@PROPERTY.COM', 1, N'AQAAAAEAACcQAAAAEKmAgAbno5Onwdi7wxfeE6b6kTdG1P2bAC8ZoKbwxuPEdodiX2GvyW8ccMLMtCNlrQ==', N'Y3S2D2QWCYVH2RIOEN355VRY2PY35OKY', N'd3ca5545-0646-4092-b2e2-73f6418d7a5f', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'bd5ce5f9-7085-4907-b5a2-89bd24abbf37', N'james@property.com', N'JAMES@PROPERTY.COM', N'james@property.com', N'JAMES@PROPERTY.COM', 1, N'AQAAAAEAACcQAAAAEFl24SjDiloqiw6OZoXC9i0CYpfESPcLuiiDN+5EgfDW/LygEc7Ub6imoQoBnfgJ2w==', N'CT3JBSWTTHUV3WHVCGMHLE32XKHM5PAL', N'67796956-09bf-4527-b805-8a796a239422', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'71fb276f-8e58-4b08-8c54-7972b20197ca', N'6f9db833-0f49-45da-a105-0e196576b81f')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bd5ce5f9-7085-4907-b5a2-89bd24abbf37', N'94557f5a-f2ab-4a64-a1cb-59cead0b321d')
SET IDENTITY_INSERT [dbo].[Buyer] ON
INSERT INTO [dbo].[Buyer] ([Id], [Name], [Phone]) VALUES (1, N'james@property.com', N'021666789')
SET IDENTITY_INSERT [dbo].[Buyer] OFF
SET IDENTITY_INSERT [dbo].[Property] ON
INSERT INTO [dbo].[Property] ([Id], [Address], [SellingPrice], [Title], [Description]) VALUES (1, N'450B, Queen Street, Auckland ', 800000, N'A Luxury 4 Bedroom House', N'A Luxury 4 Bedroom House For sale for more information call 02156678903 ')
INSERT INTO [dbo].[Property] ([Id], [Address], [SellingPrice], [Title], [Description]) VALUES (2, N'430R, Great South Road, Otahuhu', 640000, N'Sale - Four Bedroom house ', N'A Four Bedroom house for sale in  otahuhu located with easy access to public transport, schools and shops ')
INSERT INTO [dbo].[Property] ([Id], [Address], [SellingPrice], [Title], [Description]) VALUES (3, N'300D, Great South Road,  Mt Wellington,  Auckland', 680000, N'Two floor House with 2 Kitchens and 6 bedrooms', N'A  family house with 2 kitchens and 6 large bedrooms ')
INSERT INTO [dbo].[Property] ([Id], [Address], [SellingPrice], [Title], [Description]) VALUES (4, N'567F, Symonds Street, Mount Eden, Auckland', 810000, N'3 Level Building for Sale ', N'Located with easy access to Auckland CBD,  A 3 floor building ')
SET IDENTITY_INSERT [dbo].[Property] OFF
SET IDENTITY_INSERT [dbo].[SalesTransaction] ON
INSERT INTO [dbo].[SalesTransaction] ([Id], [BuyerId], [PropertyId]) VALUES (1, 1, 3)
INSERT INTO [dbo].[SalesTransaction] ([Id], [BuyerId], [PropertyId]) VALUES (2, 1, 1)
SET IDENTITY_INSERT [dbo].[SalesTransaction] OFF
