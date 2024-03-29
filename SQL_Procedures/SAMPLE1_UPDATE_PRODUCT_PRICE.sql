﻿USE [AdventureWorks2017]
GO
/****** Object:  StoredProcedure [dbo].[SAMPLE1_UPDATE_PRODUCT_PRICE]    Script Date: 20.03.2024 22:38:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[SAMPLE1_UPDATE_PRODUCT_PRICE]
(
	@ProductiD INT
	,@ListPrice MONEY
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
		DECLARE @DATE DATETIME= GETDATE()

		UPDATE [AdventureWorks2017].[Production].[Product]
		SET [ListPrice] = @ListPrice, ModifiedDate = @DATE
		WHERE ProductID = @ProductiD

		--CHECK AND UPDATE LAST HISTORY DATA - USEFULL IN PRODUCT PRICE UPDATE
		IF 
		(
			EXISTS 
			(
				SELECT 1 
				FROM [AdventureWorks2017].[Production].[ProductListPriceHistory] 
				WHERE ProductID = @ProductiD AND EndDate IS NULL 
			)
		)
		BEGIN 
			UPDATE [AdventureWorks2017].[Production].[ProductListPriceHistory] 
			SET EndDate = @DATE
			WHERE ProductID = @ProductiD AND EndDate IS NULL 
		END

		--INSERT PRICE HISTORY
		INSERT INTO [AdventureWorks2017].[Production].[ProductListPriceHistory] 
		(
			[ProductID]
			,[StartDate]
			,[ListPrice]
			,[ModifiedDate]
		)
		VALUES
		(
			@ProductiD
			,@DATE
			,@ListPrice
			,@DATE
		)
	END
END

