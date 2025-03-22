CREATE DATABASE SalesDb
GO
USE SalesDb
GO
CREATE TABLE Customers(
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(50) not NULL,
    Email NVARCHAR(50) not null
)
GO
CREATE TABLE Orders(
    Id INT PRIMARY KEY IDENTITY,
    OrderDate DATETIME not null,
    CustomerId INT not null,
   TotalAmount DECIMAL(10,2) not NULL
   CONSTRAINT FK_Orders_Customers FOREIGN KEY (CustomerId) REFERENCES Customers(Id)
)
GO
INSERT into Customers(Name,Email)
VALUES
('Ali Yılmaz','ali@example.com'),
('Zeynep Kaya', 'zeynep@example.com'),
('Mehmet Demir','mehmet@example.com');

INSERT into Orders(OrderDate,CustomerId,TotalAmount)
VALUES
('2024-03-01',1,250.00),
('2024-03-05',1,125.50),
('2024-02-20',2,89.99),
('2024-02-25',2,299.99),
('2024-03-10',3,159.75),
('2024-03-12',3,49.90);

