SELECT
c.CategoryName,
COUNT(p.ProductID) as 'PRODUCT_COUNT'
FROM Categories c LEFT JOIN Products p on c.CategoryID=p.CategoryID
GROUP BY C.CategoryName;