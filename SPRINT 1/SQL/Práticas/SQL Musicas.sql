CREATE DATABASE Musicas_manha;

USE Musicas_manha;

CREATE TABLE EstilosMusicas (
	idEstiloMuscial INT PRIMARY KEY IDENTITY,
	Nome			VARCHAR (200) NOT NULL
);

CREATE TABLE Artistas (
	idArtista		 INT PRIMARY KEY IDENTITY,
	idEstiloMusical  INT FOREIGN KEY REFERENCES EstilosMusicas (idEstiloMuscial),
	Nome			 VARCHAR (200)
);

--Altera��o Adiciona Coluna Nova
ALTER TABLE Artistas
ADD DataNascimento DATE;

SELECT * FROM Artistas;

--Altera��o Modificar Coluna
ALTER TABLE Artistas
ALTER COLUMN Nome CHAR;

--Altera��o Apagar Coluna
ALTER TABLE Artistas
DROP COLUMN Nome;

--Apagar
DROP TABLE EstilosMusicas