USE [test]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 2020/6/2 20:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [uniqueidentifier] NULL,
	[Name] [varchar](200) NOT NULL,
	[Icon] [varchar](200) NULL,
	[ParentId] [uniqueidentifier] NULL,
	[SortId] [int] NULL,
	[IsDelete] [int] NULL,
	[CreateTime] [datetime] NULL,
	[Creator] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'f79e77b5-9bad-40b1-8e41-39d5ae256599', N'热门推荐', N'', N'00000000-0000-0000-0000-000000000000', 1, 0, CAST(0x0000ABCE00FC556B AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'9cc08987-811f-445e-ab46-8e9bd55dc67d', N'手机数码', N'', N'00000000-0000-0000-0000-000000000000', 2, 0, CAST(0x0000ABCE01031783 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'ac1c4d21-e80b-4162-90fe-a877fc3b2686', N'电脑办公', N'', N'00000000-0000-0000-0000-000000000000', 3, 0, CAST(0x0000ABCE01031783 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'30093657-8ba6-4ea0-b000-b20093ce0232', N'家用电器', N'', N'00000000-0000-0000-0000-000000000000', 4, 0, CAST(0x0000ABCE01031784 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'd719392d-317a-4baf-a16b-3fbf72128a86', N'计生情趣', N'', N'00000000-0000-0000-0000-000000000000', 5, 0, CAST(0x0000ABCE01031784 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'4418a17e-e3dd-4b55-b4e4-5feea95fd67a', N'美妆护肤', N'', N'00000000-0000-0000-0000-000000000000', 6, 0, CAST(0x0000ABCE01031784 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'3ac365d5-5e77-4290-b316-f8fba0f7cf2b', N'个护清洁', N'', N'00000000-0000-0000-0000-000000000000', 7, 0, CAST(0x0000ABCE01031784 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'234bba8b-7399-4b19-bd2d-9ec44eebd8c9', N'汽车生活', N'', N'00000000-0000-0000-0000-000000000000', 8, 0, CAST(0x0000ABCE01031784 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'0b8c3a13-27a7-4ed0-8e98-f89226353f81', N'京东超市', N'', N'00000000-0000-0000-0000-000000000000', 9, 0, CAST(0x0000ABCE01031784 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'93824649-36e1-4ec6-9860-53c3675fd255', N'男装', N'', N'00000000-0000-0000-0000-000000000000', 10, 0, CAST(0x0000ABCE01031784 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'377ce82a-e2a6-4c59-b0a4-d6f0a576faae', N'男鞋', N'', N'00000000-0000-0000-0000-000000000000', 11, 0, CAST(0x0000ABCE01031784 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'd439ecce-3ccc-4fa4-87a9-633f0a5fc760', N'女装', N'', N'00000000-0000-0000-0000-000000000000', 12, 0, CAST(0x0000ABCE01031784 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'4e8b8876-3f07-49a4-bd25-4c2d7b4a8445', N'女鞋', N'', N'00000000-0000-0000-0000-000000000000', 13, 0, CAST(0x0000ABCE01031784 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'314f23a0-f9fa-495d-ba28-e80c9fbc1307', N'母婴童装', N'', N'00000000-0000-0000-0000-000000000000', 14, 0, CAST(0x0000ABCE01031784 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'8333ec86-837d-4262-bf57-34e1bbb61d06', N'图书音像', N'', N'00000000-0000-0000-0000-000000000000', 15, 0, CAST(0x0000ABCE01031784 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'42d72e15-eb37-4fd1-8621-85325f957243', N'户外运动', N'', N'00000000-0000-0000-0000-000000000000', 16, 0, CAST(0x0000ABCE01031784 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'017e35a7-49c8-4e86-9b68-79ac5a1c1a58', N'内衣配饰', N'', N'00000000-0000-0000-0000-000000000000', 17, 0, CAST(0x0000ABCE01031784 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'41d9c40b-45ff-40c8-bc01-6b5f4abcd4e7', N'食品生鲜', N'', N'00000000-0000-0000-0000-000000000000', 18, 0, CAST(0x0000ABCE01031784 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'11c83096-d350-498a-8429-5653967c51f5', N'酒水饮料', N'', N'00000000-0000-0000-0000-000000000000', 19, 0, CAST(0x0000ABCE01031784 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'ad9e8f77-ed5e-43e3-92dc-5c12d0ddccdd', N'家具家装', N'', N'00000000-0000-0000-0000-000000000000', 20, 0, CAST(0x0000ABCE01031784 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'd08d5286-f1fa-4d26-9de5-8ca8fa799e1c', N'家居厨具', N'', N'00000000-0000-0000-0000-000000000000', 21, 0, CAST(0x0000ABCE01031784 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'8f3f974f-0aca-4299-9f6a-0621606162fe', N'箱包手袋', N'', N'00000000-0000-0000-0000-000000000000', 22, 0, CAST(0x0000ABCE01031784 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'fff0e75a-be35-4c6e-a201-915204c54391', N'钟表珠宝', N'', N'00000000-0000-0000-0000-000000000000', 23, 0, CAST(0x0000ABCE01031784 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'62250b75-54a2-4c4a-9b18-ed7109438fb5', N'玩具乐器', N'', N'00000000-0000-0000-0000-000000000000', 24, 0, CAST(0x0000ABCE01031784 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'd108449d-02fb-45c0-9ea6-4c77b3b6be3b', N'医药保健', N'', N'00000000-0000-0000-0000-000000000000', 25, 0, CAST(0x0000ABCE01031785 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'dad3d053-0d56-42ec-a04f-0373c7ebc836', N'宠物生活', N'', N'00000000-0000-0000-0000-000000000000', 26, 0, CAST(0x0000ABCE01031785 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'62dc4632-b45e-4a06-b52e-937b08077217', N'礼品鲜花', N'', N'00000000-0000-0000-0000-000000000000', 27, 0, CAST(0x0000ABCE01031785 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'823236f4-b393-4a2c-83f2-3ecb55504c00', N'农资绿植', N'', N'00000000-0000-0000-0000-000000000000', 28, 0, CAST(0x0000ABCE01031785 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'f54246ce-8d15-44ab-9798-cadbdf3ddec3', N'奢侈品', N'', N'00000000-0000-0000-0000-000000000000', 29, 0, CAST(0x0000ABCE01031785 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'b3a88f58-5abd-420f-b82b-856e38c02745', N'京东国际', N'', N'00000000-0000-0000-0000-000000000000', 30, 0, CAST(0x0000ABCE01031785 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'ce44c19c-8efa-4d59-9bc3-0f2ccec96b54', N'艺术邮币', N'', N'00000000-0000-0000-0000-000000000000', 31, 0, CAST(0x0000ABCE01031785 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'a5f68e46-5e19-44c2-8f45-185bd8feb703', N'二手商品', N'', N'00000000-0000-0000-0000-000000000000', 32, 0, CAST(0x0000ABCE01031786 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'574cccc9-0d05-4142-8946-7d66e5c51a80', N'特产馆', N'', N'00000000-0000-0000-0000-000000000000', 33, 0, CAST(0x0000ABCE01031786 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'364783e9-9389-446e-a21b-3746e12ce63b', N'京东金融', N'', N'00000000-0000-0000-0000-000000000000', 34, 0, CAST(0x0000ABCE01031786 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'de039e25-8f75-4546-b093-2fe02c309045', N'国际名牌', N'', N'00000000-0000-0000-0000-000000000000', 35, 0, CAST(0x0000ABCE01031787 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'a26c473d-928b-42a7-ac46-9c2a66dcd2e7', N'拍卖', N'', N'00000000-0000-0000-0000-000000000000', 36, 0, CAST(0x0000ABCE01031787 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'4aca992f-6931-45c0-a955-9ab530580f06', N'房产', N'', N'00000000-0000-0000-0000-000000000000', 37, 0, CAST(0x0000ABCE01031787 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'a7f32c71-5fb9-4bdc-ae09-7cda07ea1a54', N'工业品', N'', N'00000000-0000-0000-0000-000000000000', 38, 0, CAST(0x0000ABCE01031787 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'a12ae932-c43f-45a4-bc0d-ef7a66f71f8d', N'618大促', N'', N'f79e77b5-9bad-40b1-8e41-39d5ae256599', 1, 0, CAST(0x0000ABCE01068361 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'839c6755-df12-4f6d-8a1b-6ba3590abd88', N'热门分类', N'', N'f79e77b5-9bad-40b1-8e41-39d5ae256599', 2, 0, CAST(0x0000ABCE01068361 AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'3ef4529a-b3a5-4763-8b2a-00f3f4a57fb3', N'超嗨预售', N'/imager/3EF4529A-B3A5-4763-8B2A-00F3F4A57FB3.jpg', N'a12ae932-c43f-45a4-bc0d-ef7a66f71f8d', 1, 0, CAST(0x0000ABCE01081CDF AS DateTime), N'')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'c00aec78-717b-40b3-8510-0892046b7433', N'5G盛典', N'/imager/c00aec78-717b-40b3-8510-0892046b7433.jpg', N'a12ae932-c43f-45a4-bc0d-ef7a66f71f8d', 2, 0, CAST(0x0000ABCE014F898D AS DateTime), N'胡汉三')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'57ecedb0-9cc5-4dfa-b0eb-4f353cae4714', N'健康爆款', N'/imager/57ecedb0-9cc5-4dfa-b0eb-4f353cae4714.jpg', N'a12ae932-c43f-45a4-bc0d-ef7a66f71f8d', 3, 0, CAST(0x0000ABCE0150DB30 AS DateTime), N'胡汉三')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'413f052d-8f1f-47a4-95b7-58e39e0611bc', N'5G', N'/imager/413f052d-8f1f-47a4-95b7-58e39e0611bc.jpg', N'839c6755-df12-4f6d-8a1b-6ba3590abd88', 1, 0, CAST(0x0000ABCE0152724E AS DateTime), N'胡汉三')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'68dd7f68-3a02-4595-937d-3bd18158c819', N'电脑', N'/imager/68dd7f68-3a02-4595-937d-3bd18158c819.jpg', N'839c6755-df12-4f6d-8a1b-6ba3590abd88', 2, 0, CAST(0x0000ABCE0152FEFF AS DateTime), N'胡汉三')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'4090e690-b495-4162-b5be-db5d79b93a70', N'全面屏手机', N'/imager/4090e690-b495-4162-b5be-db5d79b93a70.jpg', N'839c6755-df12-4f6d-8a1b-6ba3590abd88', 3, 0, CAST(0x0000ABCE01535B9D AS DateTime), N'胡汉三')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'f16f5b36-112b-4a59-aedd-df5442229963', N'保健品', N'/imager/f16f5b36-112b-4a59-aedd-df5442229963.jpg', N'839c6755-df12-4f6d-8a1b-6ba3590abd88', 4, 0, CAST(0x0000ABCE0153BED6 AS DateTime), N'胡汉三')
INSERT [dbo].[Category] ([ID], [Name], [Icon], [ParentId], [SortId], [IsDelete], [CreateTime], [Creator]) VALUES (N'43e8c8cd-041f-4db5-bce7-a0b41a7dc6c3', N'口罩', N'/imager/43e8c8cd-041f-4db5-bce7-a0b41a7dc6c3.jpg', N'839c6755-df12-4f6d-8a1b-6ba3590abd88', 5, 0, CAST(0x0000ABCE01543944 AS DateTime), N'胡汉三')
