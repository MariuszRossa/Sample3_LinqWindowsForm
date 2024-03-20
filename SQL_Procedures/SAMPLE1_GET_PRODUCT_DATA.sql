USE [AdventureWorks2017]
GO
/****** Object:  StoredProcedure [dbo].[SAMPLE1_GET_PRODUCT_DATA]    Script Date: 20.03.2024 22:36:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SAMPLE1_GET_PRODUCT_DATA]
AS
BEGIN
    SELECT 
	    PR.[ProductID]
        ,[Name]
        ,[ProductNumber]
        ,ISNULL([Color], '') [Color]
        ,[SafetyStockLevel]
        ,[ReorderPoint]
        ,[ListPrice]
        ,ISNULL([Size], '') [Size]
        ,[SellStartDate]
    FROM 
        [AdventureWorks2017].[Production].[Product] PR
        LEFT JOIN [AdventureWorks2017].[Production].[ProductProductPhoto] PP_ID ON PP_ID.[ProductID] = PR.ProductID
        LEFT JOIN [AdventureWorks2017].[Production].[ProductPhoto] PP ON PP_ID.ProductPhotoID = PP.ProductPhotoID
	WHERE 
		(
			PR.SellEndDate IS NULL OR
			PR.SellEndDate <= GETDATE()
		)
END