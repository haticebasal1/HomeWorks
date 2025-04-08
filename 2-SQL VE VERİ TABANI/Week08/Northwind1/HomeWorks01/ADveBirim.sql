SELECT
p.ProductName,
od.UnitPrice
FROM Products p JOIN OrderDetails od on od.ProductID=p.ProductID