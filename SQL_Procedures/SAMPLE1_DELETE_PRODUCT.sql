USE [AdventureWorks2017]
GO
/****** Object:  StoredProcedure [dbo].[SAMPLE1_DELETE_PRODUCT]    Script Date: 20.03.2024 22:38:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SAMPLE1_DELETE_PRODUCT_SELLS]
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
		DELETE FROM [AdventureWorks2017].[Production].[ProductListPriceHistory]
		WHERE ProductID = @ProductiD

		DELETE FROM [AdventureWorks2017].[Production].[Product]
		WHERE ProductID = @ProductiD
	END
END