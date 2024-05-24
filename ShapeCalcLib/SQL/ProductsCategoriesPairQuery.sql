SELECT 
	c.[Name] AS Category
	, p.[Name] AS Product

FROM Categories c
	JOIN CategoriesProducts cp 
		ON c.Id = cp.CategoryId
	RIGHT JOIN Products p 
		ON p.Id = cp.ProductId