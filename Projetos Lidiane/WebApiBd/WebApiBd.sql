CREATE DATABASE WebApiBd
GO

USE WebApiBd
GO

CREATE TABLE Selecao(
	Id INT PRIMARY KEY NOT NULL IDENTITY,
	Nome VARCHAR(255) NOT NULL,
	Bandeira IMAGE,
	Uniforme IMAGE,
	Escalacao VARCHAR(10)
)
GO

CREATE TABLE Jogador(
	Id INT PRIMARY KEY NOT NULL IDENTITY,
	Nome VARCHAR(255) NOT NULL,
	Nascimento DATETIME NOT NULL,
	Posicao VARCHAR(255) NOT NULL,
	QTDEFaltas INT NOT NULL DEFAULT(0),
	QTDECartoesAmarelo INT NOT NULL DEFAULT(0),
	QTDECartoesVermelho INT NOT NULL DEFAULT(0),
	Informacoes TEXT NOT NULL,
	NumeroCamisa INT NOT NULL,
	Foto IMAGE,
	SelecaoID INT FOREIGN KEY REFERENCES Selecao(Id)
)
GO


INSERT INTO Selecao(Nome)
VALUES		('Brasil'),
			('Argentina'),
			('M�xico');
GO

SELECT * FROM Selecao
GO