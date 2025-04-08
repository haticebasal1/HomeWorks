SELECT
e.EmployeeID,
e.FirstName+' '+e.LastName as 'Ad Soyad',
COUNT(o.OrderID) AS 'Total Order'
FROM Employees e LEFT JOIN Orders o on e.EmployeeID=o.EmployeeID
GROUP BY e.EmployeeID,e.FirstName+' '+e.LastName
ORDER BY 'Ad Soyad' DESC;
