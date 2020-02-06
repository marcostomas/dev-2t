CREATE DATABASE ExercicioLivro_Manha

USE ExercicioLivro_Manha;


CREATE TABLE GenerosLivros (
	idGenero INT PRIMARY KEY IDENTITY,
	Nome	 VARCHAR(200)	NOT NULL
);

CREATE TABLE AutoresLivros (
	idAutor INT PRIMARY KEY,
	NomeAutor VARCHAR (200)
);

CREATE TABLE NomeLivros (
	idLivro INT PRIMARY KEY IDENTITY,
	Titulo VARCHAR (255),
	idGenero INT FOREIGN KEY REFERENCES GenerosLivros (idGenero),
	idAutor INT FOREIGN KEY REFERENCES AutoresLivros (idAutor)
);

ALTER TABLE GenerosLivros
ADD Descricao VARCHAR (200);

INSERT INTO GenerosLivros (Nome, Descricao)
VALUES	('Ficcao', 'Narrativa Imaginaria ou irreal'),
		('Aventura', 'Historia onde um heroi enfrenta uma serie de obstaculos e demonstra coragem'),
		('Fantasia', 'Genero da ficcao que se usa geralmente fenomenos sobrenaturais ou magicos'),
		('Romance', 'Historia onde as personagens se envolvem e um romance e enfrentam obstaculos'),
		('Comedia', 'O que é engraçado, se faz rir. Agressivo ou não');

INSERT INTO AutoresLivros (NomeAutor, idAutor)
VALUES	('George Orwell', 1), 
		('Yann Martel', 2), 
		('J.K. Rowling', 3), 
		('Machado de Assis', 4), 
		('William Shakespeare', 5);

INSERT INTO NomeLivros (Titulo, idGenero, idAutor)
VALUES	('A Revolucao dos Bichos' , 1, 1),
		('As Aventuras de PI' , 2, 2),
		('Harry Potter', 3 , 3),
		('Memorias Postumas de Bras Cubas', 4, 4),
		('A Comedia dos Erros', 5, 5);

UPDATE GenerosLivros
SET Nome = 'Zé do Alho'
WHERE idGenero = 1;

UPDATE NomeLivros
SET idGenero = 2
WHERE idGenero = 1;

DELETE FROM NomeLivros
WHERE idAutor = 1;

SELECT * FROM AutoresLivros;
SELECT * FROM NomeLivros;
SELECT * FROM GenerosLivros;