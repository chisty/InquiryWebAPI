CREATE DATABASE [CustomerInquiry]
GO

USE [CustomerInquiry]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 5/29/2019 4:29:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [numeric](10, 0) IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NULL,
	[Email] [nvarchar](25) NOT NULL,
	[Mobile] [numeric](10, 0) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 5/29/2019 4:29:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[Id] [numeric](10, 0) IDENTITY(1,1) NOT NULL,
	[CustomerId] [numeric](10, 0) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[CurrencyCode] [nvarchar](10) NOT NULL,
	[Status] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerID], [Name], [Email], [Mobile]) VALUES (CAST(1 AS Numeric(10, 0)), N'Dan Brown', N'dan.brown@gmail.com', CAST(123456789 AS Numeric(10, 0)))
INSERT [dbo].[Customers] ([CustomerID], [Name], [Email], [Mobile]) VALUES (CAST(2 AS Numeric(10, 0)), N'Tony Stark', N'ironman@gmail.com', CAST(167994575 AS Numeric(10, 0)))
INSERT [dbo].[Customers] ([CustomerID], [Name], [Email], [Mobile]) VALUES (CAST(3 AS Numeric(10, 0)), N'Silvia Austin', N'silvia@yahoo.com', CAST(789789456 AS Numeric(10, 0)))
INSERT [dbo].[Customers] ([CustomerID], [Name], [Email], [Mobile]) VALUES (CAST(4 AS Numeric(10, 0)), N'Ahmed Chisty', N'chisty@gmail.com', CAST(989898984 AS Numeric(10, 0)))
INSERT [dbo].[Customers] ([CustomerID], [Name], [Email], [Mobile]) VALUES (CAST(5 AS Numeric(10, 0)), N'Tasmia Junainah', N'junainah@mail.com', CAST(777777777 AS Numeric(10, 0)))
SET IDENTITY_INSERT [dbo].[Customers] OFF
SET IDENTITY_INSERT [dbo].[Transactions] ON 

INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(1 AS Numeric(10, 0)), CAST(1 AS Numeric(10, 0)), CAST(N'2015-12-31 10:30:00.000' AS DateTime), CAST(100.50 AS Decimal(18, 2)), N'USD', N'Success')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(2 AS Numeric(10, 0)), CAST(1 AS Numeric(10, 0)), CAST(N'2016-12-31 12:30:00.000' AS DateTime), CAST(200.00 AS Decimal(18, 2)), N'USD', N'Success')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(3 AS Numeric(10, 0)), CAST(1 AS Numeric(10, 0)), CAST(N'2017-02-25 14:10:00.000' AS DateTime), CAST(375.25 AS Decimal(18, 2)), N'BDT', N'Canceled')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(4 AS Numeric(10, 0)), CAST(1 AS Numeric(10, 0)), CAST(N'2018-12-31 20:30:00.000' AS DateTime), CAST(500.00 AS Decimal(18, 2)), N'BDT', N'Success')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(5 AS Numeric(10, 0)), CAST(1 AS Numeric(10, 0)), CAST(N'2018-10-01 22:10:00.000' AS DateTime), CAST(450.00 AS Decimal(18, 2)), N'BDT', N'Failed')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(6 AS Numeric(10, 0)), CAST(1 AS Numeric(10, 0)), CAST(N'2017-06-25 18:50:00.000' AS DateTime), CAST(300.00 AS Decimal(18, 2)), N'JPY', N'Success')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(7 AS Numeric(10, 0)), CAST(1 AS Numeric(10, 0)), CAST(N'2019-01-31 11:30:00.000' AS DateTime), CAST(500.00 AS Decimal(18, 2)), N'USD', N'Canceled')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(8 AS Numeric(10, 0)), CAST(2 AS Numeric(10, 0)), CAST(N'2018-12-31 10:30:00.000' AS DateTime), CAST(200.00 AS Decimal(18, 2)), N'THB', N'Success')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(9 AS Numeric(10, 0)), CAST(2 AS Numeric(10, 0)), CAST(N'2018-12-31 12:30:00.000' AS DateTime), CAST(215.00 AS Decimal(18, 2)), N'THB', N'Success')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(10 AS Numeric(10, 0)), CAST(2 AS Numeric(10, 0)), CAST(N'2019-02-25 14:10:00.000' AS DateTime), CAST(310.25 AS Decimal(18, 2)), N'USD', N'Canceled')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(11 AS Numeric(10, 0)), CAST(2 AS Numeric(10, 0)), CAST(N'2018-06-06 20:30:00.000' AS DateTime), CAST(400.00 AS Decimal(18, 2)), N'SGD', N'Success')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(12 AS Numeric(10, 0)), CAST(2 AS Numeric(10, 0)), CAST(N'2018-10-01 22:10:00.000' AS DateTime), CAST(450.00 AS Decimal(18, 2)), N'BDT', N'Failed')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(13 AS Numeric(10, 0)), CAST(2 AS Numeric(10, 0)), CAST(N'2017-06-25 18:50:00.000' AS DateTime), CAST(750.00 AS Decimal(18, 2)), N'JPY', N'Success')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(14 AS Numeric(10, 0)), CAST(2 AS Numeric(10, 0)), CAST(N'2019-01-31 15:30:00.000' AS DateTime), CAST(600.00 AS Decimal(18, 2)), N'THB', N'Canceled')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(15 AS Numeric(10, 0)), CAST(3 AS Numeric(10, 0)), CAST(N'2015-12-31 10:30:00.000' AS DateTime), CAST(100.50 AS Decimal(18, 2)), N'USD', N'Success')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(16 AS Numeric(10, 0)), CAST(3 AS Numeric(10, 0)), CAST(N'2016-12-31 12:30:00.000' AS DateTime), CAST(200.00 AS Decimal(18, 2)), N'USD', N'Success')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(17 AS Numeric(10, 0)), CAST(3 AS Numeric(10, 0)), CAST(N'2017-02-25 14:10:00.000' AS DateTime), CAST(375.25 AS Decimal(18, 2)), N'BDT', N'Canceled')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(18 AS Numeric(10, 0)), CAST(3 AS Numeric(10, 0)), CAST(N'2018-12-31 20:30:00.000' AS DateTime), CAST(500.00 AS Decimal(18, 2)), N'BDT', N'Success')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(19 AS Numeric(10, 0)), CAST(3 AS Numeric(10, 0)), CAST(N'2018-10-01 22:10:00.000' AS DateTime), CAST(450.00 AS Decimal(18, 2)), N'BDT', N'Failed')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(20 AS Numeric(10, 0)), CAST(3 AS Numeric(10, 0)), CAST(N'2017-06-25 18:50:00.000' AS DateTime), CAST(300.00 AS Decimal(18, 2)), N'JPY', N'Success')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(21 AS Numeric(10, 0)), CAST(3 AS Numeric(10, 0)), CAST(N'2019-01-31 11:30:00.000' AS DateTime), CAST(500.00 AS Decimal(18, 2)), N'USD', N'Canceled')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(22 AS Numeric(10, 0)), CAST(4 AS Numeric(10, 0)), CAST(N'2018-12-31 10:30:00.000' AS DateTime), CAST(200.00 AS Decimal(18, 2)), N'THB', N'Success')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(23 AS Numeric(10, 0)), CAST(4 AS Numeric(10, 0)), CAST(N'2018-12-31 12:30:00.000' AS DateTime), CAST(215.00 AS Decimal(18, 2)), N'THB', N'Success')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(24 AS Numeric(10, 0)), CAST(4 AS Numeric(10, 0)), CAST(N'2019-02-25 14:10:00.000' AS DateTime), CAST(310.25 AS Decimal(18, 2)), N'USD', N'Canceled')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(25 AS Numeric(10, 0)), CAST(4 AS Numeric(10, 0)), CAST(N'2018-06-06 20:30:00.000' AS DateTime), CAST(400.00 AS Decimal(18, 2)), N'SGD', N'Success')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(26 AS Numeric(10, 0)), CAST(4 AS Numeric(10, 0)), CAST(N'2018-10-01 22:10:00.000' AS DateTime), CAST(450.00 AS Decimal(18, 2)), N'BDT', N'Failed')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(27 AS Numeric(10, 0)), CAST(4 AS Numeric(10, 0)), CAST(N'2017-06-25 18:50:00.000' AS DateTime), CAST(750.00 AS Decimal(18, 2)), N'JPY', N'Success')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(28 AS Numeric(10, 0)), CAST(4 AS Numeric(10, 0)), CAST(N'2019-01-31 15:30:00.000' AS DateTime), CAST(600.00 AS Decimal(18, 2)), N'THB', N'Canceled')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(29 AS Numeric(10, 0)), CAST(5 AS Numeric(10, 0)), CAST(N'2015-12-31 10:30:00.000' AS DateTime), CAST(100.50 AS Decimal(18, 2)), N'USD', N'Success')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(30 AS Numeric(10, 0)), CAST(5 AS Numeric(10, 0)), CAST(N'2016-12-31 12:30:00.000' AS DateTime), CAST(200.00 AS Decimal(18, 2)), N'USD', N'Success')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(31 AS Numeric(10, 0)), CAST(5 AS Numeric(10, 0)), CAST(N'2017-02-25 14:10:00.000' AS DateTime), CAST(375.25 AS Decimal(18, 2)), N'BDT', N'Canceled')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(32 AS Numeric(10, 0)), CAST(5 AS Numeric(10, 0)), CAST(N'2018-12-31 20:30:00.000' AS DateTime), CAST(500.00 AS Decimal(18, 2)), N'BDT', N'Success')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(33 AS Numeric(10, 0)), CAST(5 AS Numeric(10, 0)), CAST(N'2018-10-01 22:10:00.000' AS DateTime), CAST(450.00 AS Decimal(18, 2)), N'BDT', N'Failed')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(34 AS Numeric(10, 0)), CAST(5 AS Numeric(10, 0)), CAST(N'2017-06-25 18:50:00.000' AS DateTime), CAST(300.00 AS Decimal(18, 2)), N'JPY', N'Success')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(35 AS Numeric(10, 0)), CAST(5 AS Numeric(10, 0)), CAST(N'2019-01-31 11:30:00.000' AS DateTime), CAST(500.00 AS Decimal(18, 2)), N'USD', N'Canceled')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(36 AS Numeric(10, 0)), CAST(5 AS Numeric(10, 0)), CAST(N'2018-12-31 10:30:00.000' AS DateTime), CAST(200.00 AS Decimal(18, 2)), N'THB', N'Success')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(37 AS Numeric(10, 0)), CAST(5 AS Numeric(10, 0)), CAST(N'2018-12-31 12:30:00.000' AS DateTime), CAST(215.00 AS Decimal(18, 2)), N'THB', N'Success')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(38 AS Numeric(10, 0)), CAST(5 AS Numeric(10, 0)), CAST(N'2019-02-25 14:10:00.000' AS DateTime), CAST(310.25 AS Decimal(18, 2)), N'USD', N'Canceled')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(39 AS Numeric(10, 0)), CAST(5 AS Numeric(10, 0)), CAST(N'2018-06-06 20:30:00.000' AS DateTime), CAST(400.00 AS Decimal(18, 2)), N'SGD', N'Success')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(40 AS Numeric(10, 0)), CAST(5 AS Numeric(10, 0)), CAST(N'2018-10-01 22:10:00.000' AS DateTime), CAST(450.00 AS Decimal(18, 2)), N'BDT', N'Failed')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(41 AS Numeric(10, 0)), CAST(5 AS Numeric(10, 0)), CAST(N'2017-06-25 18:50:00.000' AS DateTime), CAST(750.00 AS Decimal(18, 2)), N'JPY', N'Success')
INSERT [dbo].[Transactions] ([Id], [CustomerId], [Date], [Amount], [CurrencyCode], [Status]) VALUES (CAST(42 AS Numeric(10, 0)), CAST(5 AS Numeric(10, 0)), CAST(N'2019-01-31 15:30:00.000' AS DateTime), CAST(600.00 AS Decimal(18, 2)), N'THB', N'Canceled')
SET IDENTITY_INSERT [dbo].[Transactions] OFF
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_Transactions_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [FK_Transactions_Customers]
GO
