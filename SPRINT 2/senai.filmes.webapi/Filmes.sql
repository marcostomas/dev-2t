CREATE DATABASE Filmes;

USE Filmes;

CREATE TABLE Genero (
	IdGenero INT PRIMARY KEY IDENTITY,
	Genero VARCHAR(255) UNIQUE NOT NULL
);

CREATE TABLE Filmes (
	IdFilme INT PRIMARY KEY IDENTITY,
	Titulo VARCHAR(255) UNIQUE NOT NULL,
	IdGenero INT FOREIGN KEY REFERENCES Genero (IdGenero)
);

INSERT INTO Genero (Genero)
VALUES ('Drama'),('Ação');

INSERT INTO Genero (Genero)
VALUES ('Terror');

INSERT INTO Filmes (Titulo, IdGenero)
VALUES ('A vida é bela', 1), ('Rambo', 2);

SELECT Genero.Genero, Filmes.Titulo FROM Genero INNER JOIN Filmes ON Genero.IdGenero = Filmes.IdGenero;

SELECT * FROM Genero;