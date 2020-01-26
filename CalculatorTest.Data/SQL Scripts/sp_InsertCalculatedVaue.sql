USE [Calculator]
GO

/****** Object:  StoredProcedure [dbo].[InsertCalculatedVaue]    Script Date: 24-Jan-20 4:32:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[InsertCalculatedVaue]
(
		@functionName varchar(50)
			,@functionTotal varchar(50)
)
AS 
BEGIN

SET NOCOUNT ON;
INSERT INTO [dbo].[SimpleCalculatorResult] ([FunctionName] ,[FunctionTotal], [CreatedOn])
     VALUES (ISNULL(@functionName, '''')  ,ISNULL(@functionTotal, ''''), GETDATE() )
END


GO


