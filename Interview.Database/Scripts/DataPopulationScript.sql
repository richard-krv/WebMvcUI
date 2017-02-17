
USE [Interview.Database]
GO

/****** Object:  Table [dbo].[Manufacturer]    Script Date: 15/01/2016 10:31:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[Range]    Script Date: 15/01/2016 10:31:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

SET ANSI_PADDING OFF
GO

INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (7, N'Audi')
GO

INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (10, N'BMW')
GO

INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (31, N'Ford')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (34, N'3 Series', 10, N'21598.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (69, N'5 Series', 10, N'21291.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (76, N'6 Series', 10, N'21082.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (81, N'7 Series', 10, N'21050.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (107, N'A3', 7, N'20884.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (108, N'A4', 7, N'20847.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (109, N'A6', 7, N'21521.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (110, N'A8', 7, N'21311.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (232, N'Fiesta', 31, N'21015.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (233, N'Focus', 31, N'21497.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (241, N'Galaxy', 31, NULL)
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (265, N'KA', 31, N'20777.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (286, N'M3', 10, N'21447.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (287, N'M5', 10, N'21224.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (314, N'Mondeo', 31, NULL)
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (470, N'TT', 7, N'21524.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (527, N'RS4', 7, N'21025.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (538, N'X5', 10, N'21225.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (552, N'Alpina', 10, N'21554.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (623, N'RS6', 7, NULL)
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (656, N'Z4', 10, N'21063.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (679, N'X3', 10, N'21449.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (699, N'1 Series', 10, N'21555.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (737, N'M6', 10, N'21152.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (748, N'Q7', 7, NULL)
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (763, N'S-Max', 31, N'21580.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (777, N'R8', 7, N'21578.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (790, N'C-Max', 31, NULL)
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (795, N'A5', 7, N'20848.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (832, N'X6', 10, N'21510.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (835, N'Kuga', 31, N'21036.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (852, N'Q5', 7, N'20980.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (879, N'X1', 10, N'21599.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (887, N'A6 Allroad', 7, N'21617.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (888, N'A4 Allroad', 7, NULL)
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (903, N'A1', 7, N'21608.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (907, N'RS5', 7, N'21026.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (919, N'A7', 7, N'21522.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (920, N'Grand C-Max', 31, N'21564.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (929, N'RS3', 7, N'21532.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (940, N'Q3', 7, N'21615.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (971, N'B-Max', 31, N'20886.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (980, N'X6 M', 10, N'21534.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (981, N'X5 M', 10, N'21464.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (1004, N'RS7', 7, NULL)
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (1012, N'Grand Tourneo Connect', 31, NULL)
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (1013, N'Tourneo Connect', 31, NULL)
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (1017, N'4 Series', 10, N'21451.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (1019, N'I3', 10, N'21268.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (1024, N'RS Q3', 7, N'21561.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (1026, N'Ecosport', 31, N'21411.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (1029, N'2 Series', 10, N'21294.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (1039, N'Transit Courier', 31, N'21421.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (1041, N'M4', 10, N'21509.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (1046, N'X4', 10, N'21450.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (1048, N'I8', 10, N'21446.png')
GO

INSERT [dbo].[Range] ([RangeId], [RangeName], [ManufacturerId], [ImageFile]) VALUES (1067, N'Mustang', 31, N'21565.png')
GO
