CREATE DATABASE CinemaDb
GO
USE CinemaDb
GO
CREATE TABLE Genres(
    Id int PRIMARY KEY IDENTITY,
    Name NVARCHAR(max) not null
)
GO
CREATE TABLE Movies(
    Id int PRIMARY KEY IDENTITY,
    Title NVARCHAR (max) not null,
    GenreId int not null,
    ReleaseYear int not NULL,
    CONSTRAINT FK_Movies_Genres FOREIGN KEY (GenreId) REFERENCES Genres(Id)
)
GO

INSERT into Genres(Name)
VALUES
('Aksiyon'),
('Romantik'),
('Bilim Kurgu');

INSERT into Movies(Title,GenreId,ReleaseYear)
VALUES
('Inception (Başlangıç)',1,2010),
('Titanic',1,1997),
('Inception (Başlangıç)',2,2010),
('Titanic',2,1997),
('Inception (Başlangıç)',3,2010),
('Titanic',3,1997);
SELECT*FROM Movies