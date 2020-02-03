CREATE DATABASE OptusManha

USE OptusManha

CREATE TABLE TiposUsuario(
	idTipoUsuario	INT PRIMARY KEY IDENTITY,
	Titulo			VARCHAR (200)
);

CREATE TABLE Usuarios(
	idUsuario		INT PRIMARY KEY IDENTITY,
	idTipoUsuario	INT FOREIGN KEY REFERENCES TiposUsuario(idTipoUsuario),
	Nome			VARCHAR (200)
);

CREATE TABLE Artistas(
	idArtista	INT PRIMARY KEY IDENTITY,
	Nome		VARCHAR (200)
);

CREATE TABLE Estilos(
	idEstilo INT PRIMARY KEY IDENTITY,
	Nome VARCHAR (200)
);

CREATE TABLE Albuns(
	idAlbum			INT PRIMARY KEY IDENTITY,
	idArtista		INT FOREIGN KEY REFERENCES Artistas (idArtista),
	idEstilo		INT FOREIGN KEY REFERENCES Estilos (idEstilo),
	Nome			VARCHAR (200),
	DataLancamento	DATE,
	QtdMinutos		TIME,
	Vizualizacao	BIGINT
);

SELECT * FROM Artistas
SELECT * FROM Albuns
SELECT * FROM Estilos
SELECT * FROM TiposUsuario
SELECT * FROM Usuarios

INSERT INTO	TiposUsuario (Titulo)
VALUES	('Administrador'),
		('Padrão');

INSERT INTO Artistas (Nome)
VALUES	('Jorge Ben Jor'),
		('Zeca Pagodinho'),
		('Marilia Mendonca'),
		('Jorge & Matheus'),
		('Carlos Henrique');

INSERT INTO Estilos (Nome)
VALUES		('Samba'),
			('Pagode'),
			('MPB'),
			('Sertanejo'),
			('Sofrencia');

INSERT INTO Usuarios (idTipoUsuario, Nome)
VALUES	(1, 'Marcos'),
		(2, 'Assesoria'),
		(2, 'Thiago'),
		(2, 'Carol'),
		(2, 'Saulo');

INSERT INTO	Albuns (idArtista, idEstilo, Nome, DataLancamento, QtdMinutos, Vizualizacao)
VALUES		(1, 2, 'A Tabua de Esmeralda', '2020-01-21', '00:40:00', 173000),
			(2, 1, 'Suor no Rosto', '2019-12-31', '00:41:00', 1739000),
			(3, 5, 'Todos os Cantos', '2018-12-21', '00:09:00', 689000),
			(4, 4, 'Terra Sem Cep', '2018-03-01', '00:40:00', 69000),
			(5, 3, 'A Tia Deu Em Cima de Mim', '2019-05-23', '00:07:00', 17000);

UPDATE Artistas
SET Nome = 'Chitaozinho & Xororo'
WHERE idArtista = 1;

UPDATE Usuarios
SET idTipoUsuario = 2
WHERE idUsuario = 1;

UPDATE Albuns
SET Vizualizacao = 123456
WHERE Vizualizacao = 17000;

DELETE FROM Albuns
WHERE idArtista = 1;

/* Relacionar Artista e Nome do Album */

SELECT idArtista, Nome FROM Albuns
WHERE idArtista LIKE 2;

-- Com Inner Join

SELECT * FROM Artistas
INNER JOIN Albuns ON Artistas.idArtista = Albuns.idArtista
WHERE  ALbuns.idArtista = 2



/* Albuns lançados na mesma data */

SELECT idAlbum, DataLancamento FROM Albuns
WHERE DataLancamento;

--Com o Inner Join

SELECT Artistas.Nome, Albuns.Nome, Albuns.DataLancamento FROM Artistas
INNER JOIN Albuns ON Artistas.idArtista = Albuns.idArtista
WHERE DataLancamento = '2019-12-31';



/* Artistas do Mesmo Estilo */

SELECT idArtista, idAlbum FROM Albuns
WHERE idAlbum = 4;



/* Albuns e Artistas e Ordenar por Lançamento */

SELECT idAlbum, idArtista, DataLancamento FROM Albuns
ORDER BY DataLancamento DESC;


-- Forma de Fazer 2

SELECT * FROM Albuns ORDER BY DataLancamento DESC;


-- Com Inner Join (Seguindo a Forma de fazer 2)

SELECT * FROM Albuns
INNER JOIN  Artistas ON Albuns.idArtista = Artistas.idArtista
ORDER BY DataLancamento DESC;



/* Selecionar os Artistas dos Mesmo Estilo Musical */

SELECT idArtista, idEstilo FROM Albuns WHERE idEstilo = 2;


-- Com Inner Join (Com 3 Tabelas)

SELECT Artistas.Nome, Estilos.Nome FROM Artistas
INNER JOIN Albuns ON Artistas.idArtista = Albuns.idArtista
INNER JOIN Estilos ON Estilos.idEstilo = Albuns.idEstilo;


---------------------------------------- EXEMPLOS & EXPLICAÇÕES------------------------------------

/* DQL - Lingugem de Consulta de Dados 

SELECT * FROM Artistas;

SELECT Nome FROM Artistas;

/* Da para se usar os símbolos de ' < , > , = '  (Operações) */

SELECT * FROM Albuns WHERE idAlbum = 1;

SELECT * FROM Albuns WHERE idAlbum > 1;


/* Comando 'OR' */

SELECT Nome, QtdMinutos FROM Albuns
WHERE (DataLancamento IS NULL) OR (Localizacao IS NULL)

SELECT Nome, QtdMinutos FROM Albuns
WHERE (DataLancamento IS NULL) OR (Localizacao IS NULL)

/* Filtro de Texto */

SELECT idArtista , Nome FROM Artistas
WHERE Nome LIKE 'Pitty%'; -- Começo da Frase 

SELECT idArtista , Nome FROM Artistas
WHERE Nome LIKE '%Pitty%'; -- Meio da Frase

SELECT idArtista , Nome FROM Artistas
WHERE Nome LIKE '%Pitty'; -- Final da Frase 


/* Ordenação  - Segue a ordem determinada por você */

SELECT idAlbum, Nome FROM Albuns
ORDER BY Visualizacao;

SELECT idAlbum, Nome, QtdMinutos FROM Albuns
ORDER BY QtdMinutos;

--Ordenação Invertida

SELECT idAlbum, Nome, QtdMinutos, DataLancamento FROM Albuns
ORDER BY QtdMinutos, DataLancamento DESC;

*/
