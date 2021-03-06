USE [MRP]
GO
/****** Object:  StoredProcedure [dbo].[CalcMRP]    Script Date: 16.05.2013 23:36:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Anton K. Pozhidaev
-- Create date: 2013.05.15
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[CalcMRP] 
	-- Add the parameters for the stored procedure here
	@start_day bigint = -1, 
	@end_day bigint = -1,
	@min_stock BIGINT, -- минимальное кол-во которое должно быть на складе
	@pDays BIGINT, -- кол-во дней на которые закупается 
	@max_Stock BIGINT -- максимальное кол-во товара, которое может хранится на складе
	--@res INT OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @PART_ID BIGINT,
			@cur_day BIGINT,
			@min_req BIGINT, 
			@pVal BIGINT 
	DECLARE part_cursor CURSOR FAST_FORWARD FOR -- может надо использовать static
	SELECT PART_ID FROM Part
	TRUNCATE TABLE Purchase
	
	if (SELECT MAX(Qty) from Part) > @max_Stock
		RETURN 1
	OPEN part_cursor;
	
	FETCH NEXT FROM part_cursor
	INTO @PART_ID

	WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @cur_day = @start_day
		WHILE @cur_day < @end_day
		BEGIN
			SET @min_req = dbo.CalcRequirements(@cur_day , @cur_day, @PART_ID)
			IF @min_req > @max_Stock
				RETURN 2
			 
			SET @pVal = dbo.CalcPurchase(@cur_day, @PART_ID, @min_stock,@pDays,@max_Stock)
			IF @pVal > 0
			BEGIN
			INSERT  INTO Purchase (Date, PART_ID, Qty)
			VALUES (@cur_day, @PART_ID,@pVal)
			END
			SET @cur_day = @cur_day + 1
		END

		FETCH NEXT FROM part_cursor
		INTO @PART_ID
	END
	CLOSE part_cursor
	DEALLOCATE part_cursor
	RETURN 0
END


GO
/****** Object:  UserDefinedFunction [dbo].[CalcPurchase]    Script Date: 16.05.2013 23:36:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Anton K. Pozhidaev
-- Create date: 2013.05.15
-- Description:	Функция расчитывает сколько надо купить компонентов определенного типа в определенный день
-- =============================================
CREATE FUNCTION [dbo].[CalcPurchase]
(
	@day BIGINT, --день
	@PART_ID BIGINT, -- ИД компонента
	@min_stock BIGINT, -- минимальное кол-во которое должно быть на складе
	@pDays BIGINT, -- кол-во дней на которые закупается 
	@max_Stock BIGINT -- максимальное кол-во товара, которое может хранится на складе

)
RETURNS BIGINT
AS
BEGIN
	-- Declare the return variable here
	DECLARE @res BIGINT,
	@was BIGINT,
	@next_req BIGINT,
	@min_req BIGINT, 
	@free_stock BIGINT
	
	-- Add the T-SQL statements to compute the return value here
	SET @was = (select Qty FROM Part WHERE PART_ID = @PART_ID) - 
	dbo.CalcRequirements(1,@day-1,@PART_ID) +dbo.CalcPurchased(1,@day-1,@PART_ID)
	IF ( @was <= @min_stock )
	BEGIN
		SET @next_req = dbo.CalcRequirements(@day , @day + @pDays - 1, @PART_ID)
		SET @free_stock = @max_Stock - @was
		SET @res = (Select Case When @next_req < @free_stock
               Then @next_req Else @free_stock End)
	END
	ELSE 
		SET @res = 0
	RETURN ISNULL(@res,0)
END

GO
/****** Object:  UserDefinedFunction [dbo].[CalcPurchased]    Script Date: 16.05.2013 23:36:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[CalcPurchased]
(
	@start_day BIGINT,
	@end_day BIGINT,
	@PART_ID BIGINT
)
RETURNS BIGINT
AS
BEGIN
	-- Declare the return variable here
	DECLARE @req BIGINT
	
	-- Add the T-SQL statements to compute the return value here
	SET @req = (SELECT Sum(p.Qty) FROM [dbo].[Purchase] as p 
	WHERE p.PART_ID = @PART_ID and @start_day <= p.Date and p.Date <= @end_day)
	
	RETURN ISNULL(@req, 0)
END

GO
/****** Object:  UserDefinedFunction [dbo].[CalcRequirements]    Script Date: 16.05.2013 23:36:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[CalcRequirements]
(
	@start_day BIGINT,
	@end_day BIGINT,
	@PART_ID BIGINT
)
RETURNS BIGINT
AS
BEGIN
	-- Declare the return variable here
	DECLARE @req BIGINT
	SET @req = -1;
	-- Add the T-SQL statements to compute the return value here
	SET @req = (SELECT Sum(o.Qty*pa.Qty) FROM [dbo].[Order] as o JOIN dbo.Part_assy as pa ON  o.ASSY_ID = pa.ASSY_ID
	WHERE pa.PART_ID = @PART_ID and @start_day <= o.Date and o.Date <= @end_day)

	-- Return the result of the function
	RETURN ISNULL(@req, 0)

END

GO
/****** Object:  Table [dbo].[Assy]    Script Date: 16.05.2013 23:36:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Assy](
	[ASSY_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](30) NOT NULL,
 CONSTRAINT [Unique_Identifier2] PRIMARY KEY CLUSTERED 
(
	[ASSY_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Client]    Script Date: 16.05.2013 23:36:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Client](
	[CLIENT_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](30) NOT NULL,
 CONSTRAINT [Unique_Identifier3] PRIMARY KEY CLUSTERED 
(
	[CLIENT_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Order]    Script Date: 16.05.2013 23:36:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[ORDER_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Date] [bigint] NOT NULL,
	[Qty] [bigint] NOT NULL,
	[CLIENT_ID] [bigint] NOT NULL,
	[ASSY_ID] [bigint] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[ORDER_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Part]    Script Date: 16.05.2013 23:36:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Part](
	[PART_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](30) NOT NULL,
	[Qty] [bigint] NOT NULL,
 CONSTRAINT [Unique_Identifier1] PRIMARY KEY CLUSTERED 
(
	[PART_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Part_Assy]    Script Date: 16.05.2013 23:36:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Part_Assy](
	[PART_ID] [bigint] NOT NULL,
	[ASSY_ID] [bigint] NOT NULL,
	[Qty] [bigint] NOT NULL,
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Part_Assy] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_Part_Assy] UNIQUE NONCLUSTERED 
(
	[PART_ID] ASC,
	[ASSY_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Purchase]    Script Date: 16.05.2013 23:36:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase](
	[PURCHASE_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Date] [bigint] NOT NULL,
	[Qty] [bigint] NOT NULL,
	[PART_ID] [bigint] NOT NULL,
 CONSTRAINT [Unique_Identifier5] PRIMARY KEY CLUSTERED 
(
	[PURCHASE_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [Relationship2] FOREIGN KEY([CLIENT_ID])
REFERENCES [dbo].[Client] ([CLIENT_ID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [Relationship2]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [Relationship4] FOREIGN KEY([ASSY_ID])
REFERENCES [dbo].[Assy] ([ASSY_ID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [Relationship4]
GO
ALTER TABLE [dbo].[Part_Assy]  WITH CHECK ADD  CONSTRAINT [Relationship1_Assy] FOREIGN KEY([ASSY_ID])
REFERENCES [dbo].[Assy] ([ASSY_ID])
GO
ALTER TABLE [dbo].[Part_Assy] CHECK CONSTRAINT [Relationship1_Assy]
GO
ALTER TABLE [dbo].[Part_Assy]  WITH CHECK ADD  CONSTRAINT [Relationship1_Part] FOREIGN KEY([PART_ID])
REFERENCES [dbo].[Part] ([PART_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Part_Assy] CHECK CONSTRAINT [Relationship1_Part]
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [Relationship6] FOREIGN KEY([PART_ID])
REFERENCES [dbo].[Part] ([PART_ID])
GO
ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [Relationship6]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [ValidValuesDate] CHECK  (([Date]>=(1)))
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [ValidValuesDate]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [ValidValuesQty2] CHECK  (([Qty]>=(1)))
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [ValidValuesQty2]
GO
ALTER TABLE [dbo].[Part]  WITH CHECK ADD  CONSTRAINT [ValidValuesQty1] CHECK  (([Qty]>=(0)))
GO
ALTER TABLE [dbo].[Part] CHECK CONSTRAINT [ValidValuesQty1]
GO
ALTER TABLE [dbo].[Part_Assy]  WITH CHECK ADD  CONSTRAINT [CheckConstraint1] CHECK  (([Qty]>=(1)))
GO
ALTER TABLE [dbo].[Part_Assy] CHECK CONSTRAINT [CheckConstraint1]
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [ValidValuesQty3] CHECK  (([Qty]>=(1)))
GO
ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [ValidValuesQty3]
GO
