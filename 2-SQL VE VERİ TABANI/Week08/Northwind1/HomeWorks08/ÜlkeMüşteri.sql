SELECT
e.City,
COUNT(e.EmployeeID) AS 'Employees Count'
FROM Employees e
GROUP BY City
ORDER by 'Employees Count';