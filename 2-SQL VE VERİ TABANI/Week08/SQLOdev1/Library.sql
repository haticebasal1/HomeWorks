CREATE DATABASE LibraryDb
GO
USE LibraryDb
GO
CREATE TABLE Authors(
    Id int PRIMARY KEY IDENTITY,
    Name NVARCHAR(Max) NOT NULL,
    BirthYear INT NOT NULL
)
GO
CREATE TABLE Books(
    Id INT PRIMARY KEY IDENTITY,
    Title NVARCHAR(Max) NOT NULL,
    AuthorId int NOT NULL,
    PublishedYear INT NOT NULL,
    CONSTRAINT FK_Books_Authors FOREIGN KEY (AuthorId) REFERENCES Authors(Id)
)
GO
INSERT Into Authors(Name, BirthYear)
VALUES
('Yeter Alık',1987),
('Defne Sert',1956),
('Alp Buruk',1967);

INSERT INTO Books(Title,AuthorId,PublishedYear)
VALUES
('Kırmızı Saçlı Kadın',1,2016),
('Masumiyet Müzesi',1,2008),
('Sevgi',2,2009),
('İskender',2,2011),
('İnce  Memed',3,1955),
('Yer Demir Gök Bakır',3,1963);
SELECT*FROM Books