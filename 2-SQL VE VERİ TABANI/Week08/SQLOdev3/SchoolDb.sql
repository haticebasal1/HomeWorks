CREATE DATABASE SchoolDb
GO
USE SchoolDb
GO
CREATE TABLE Students(
    Id int PRIMARY KEY IDENTITY,
    Name NVARCHAR(max) NOT NULL,
    BirthDate INT NOT NULL,
)
GO
CREATE TABLE Courses(
    Id int PRIMARY KEY IDENTITY,
    Title NVARCHAR(max) NOT NULL,
    StudentId int not null,
    Credit int NOT NULL
    CONSTRAINT FK_Courses_StudentId FOREIGN KEY (StudentId) REFERENCES Students(Id)
)
GO

INSERT into Students(Name, BirthDate)
VALUES
('Emre',23),
('Zeynep',12),
('Ali',16);

INSERT into Courses(Title,StudentId,Credit)
VALUES
('Matematik',1,6),
('Fizik',1,4),
('Matematik',2,6),
('Fizik',2,4),
('Matematik',3,6),
('Fizik',3,4);
--SELECT*FROM Students
SELECT*FROM Courses