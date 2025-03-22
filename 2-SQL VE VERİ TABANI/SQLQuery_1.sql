CREATE DATABASE SchoolDb
GO
USE SchoolDb
GO

CREATE TABLE Students(
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(max) not NULL,
    BirthDate DATETIME NOT NULL
)
GO
CREATE TABLE Courses(
    Id INT PRIMARY KEY IDENTITY,
    Title NVARCHAR(max) not null,
    StudentId INT NOT null,
    Credit 
)
