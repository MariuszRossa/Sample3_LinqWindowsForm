USE [AdventureWorks2017]
GO
/****** Object:  StoredProcedure [dbo].[SAMPLE1_UPDATE_DISABLE_PRODUCT_SELLS]    Script Date: 20.03.2024 22:38:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SAMPLE1_UPDATE_DISABLE_PRODUCT_SELLS]
(
	@ProductiD INT
)
AS
BEGIN
	IF
	(
		EXISTS
		(
			SELECT 1 
			FROM [AdventureWorks2017].[Production].[Product] 
			WHERE ProductID = @ProductiD
		)
	)
	BEGIN 
		DECLARE @DATE DATETIME = GETDATE()

		UPDATE [AdventureWorks2017].[Production].[Product] 
		SET SellEndDate = @DATE
		WHERE ProductID = @ProductiD
	END
END