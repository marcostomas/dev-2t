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
VALUES		(1, 2, 'A Tabua da Esmeralda', 1974-06-17, 

