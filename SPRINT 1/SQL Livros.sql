
--comando para criar banco de dados
-- DDL Linguagem de Definição de Dados
CREATE DATABASE RoteiroLivros;

USE RoteiroLivros;

CREATE TABLE Generos (
	idGenero INT PRIMARY KEY IDENTITY,
	Nome	 VARCHAR(200)	NOT NULL
);

CREATE TABLE Autores (
	idAutor INT PRIMARY KEY,
	NomeAutor VARCHAR (200)
);

CREATE TABLE Livros (
	idLivro INT PRIMARY KEY IDENTITY,
	Titulo VARCHAR (255),
	idGenero INT FOREIGN KEY REFERENCES Generos (idGenero),
	idAutor INT FOREIGN KEY REFERENCES Autores (idAutor)
);

SELECT * FROM Autores;
SELECT * FROM Livros;
SELECT * FROM Generos;