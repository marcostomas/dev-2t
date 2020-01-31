--DDL - LInguagem deDefinição de Dados

--Create Database - Cria o Banco de Dados
CREATE DATABASE Sstop_Manha

-- Use <banco> - Indica o bando de Dados que irei usar
USE Sstop_Manha

-- Create Table - Cria Tabela
CREATE TABLE EstilosMusicais (
	idEstiloMusical INT PRIMARY KEY IDENTITY,
	Nome			VARCHAR (200)
);

CREATE TABLE Artistas (
	idArtista		INT PRIMARY KEY IDENTITY,
	Nome			VARCHAR (200),
	idEstiloMusical INT FOREIGN KEY REFERENCES EstilosMusicais (idEstiloMusical)
);

--Alter Table - Alterar Adicionar Novo Atributo
ALTER TABLE EstilosMusicais
ADD Descricao VARCHAR (200);


--Drop Database - Excluir Banco de Dados
DROP DATABASE Sstop_Manha;

USE MASTER;

--DML - Linguagem de manipulaçãoa de Dados

--Insert - COMANDO DE INSERIR DADOS

INSERT INTO EstilosMusicais(Nome, Descricao)
VALUES	('Samba','Estilo Musical'),
		('Jazz','Estilo Top'),
		('Pop', 'Estilo Popular');

--Mostra Tabelinha de Resultados
SELECT * FROM EstilosMusicais;

INSERT INTO Artistas (Nome,idEstiloMusical)
VALUES	('Zeca Pagodinho',2),
		('Frank',3);

SELECT * FROM EstilosMusicais;
SELECT * FROM Artistas;

--Update - Alterar Dados dentro das Tabelas
UPDATE Artistas
SET Nome = 'Alcione'
WHERE idArtista = 1; 

UPDATE Artistas
SET idArtista = 1
WHERE idArtista = 1;

--Delete - Apagar os Dados da Tabela
DELETE FROM Artistas
WHERE idArtista = 3; 