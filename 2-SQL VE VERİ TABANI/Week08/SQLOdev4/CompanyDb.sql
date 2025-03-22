CREATE DATABASE CompanyDb
GO
USE CompanyDb
GO
CREATE TABLE Departments(
    Id int PRIMARY KEY IDENTITY,
    Name NVARCHAR(max) not null,
    Location NVARCHAR(max) not NULL
)
GO
CREATE table Employees(
    Id int PRIMARY key IDENTITY,
    Name NVARCHAR(max) not null,
    DepartmentId INT not null,
    Position NVARCHAR(max) not null,
    Salary int not null,
    CONSTRAINT FK_Employees_Departments FOREIGN key (DepartmentId) REFERENCES departments(Id)
)
GO

INSERT into Departments(Name,Location)
VALUES
('İnsan Kaynakları Departmanı','Ankara Ofisi'),
('Finans Departmanı','İstanbul Merkez'),
('Ar-Ge Departmanı','İzmir Teknoloji Parkı');

INSERT into Employees (Name,DepartmentId,Position,Salary)
VALUES
('Ayşe',1,'İnsan Kaynakları Müdürü',15.000),
('Kaan',1,'İnsan Kaynakları Müdürü',20.000),
('Ayşe',2,'Finans Direktörü',15.000),
('Kaan',2,'Finans Direktörü',20.000),
('Ayşe',3,'Başarılı Proje Yöneticisi',15.000),
('Kaan',3,'Başarılı Proje Yöneticisi',20.000);

SELECT*from Employees