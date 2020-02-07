/* Cria o banco de dados com o nome Gufi */
CREATE DATABASE Gufi_Manha;

/* Define o banco de dados a ser utilizado */
USE Gufi_Manha;

/* Criação das Tabelas */
CREATE TABLE TipoUsuario (
	idTipoUsuario		INT PRIMARY KEY IDENTITY,
	TituloTipoUsuario	VARCHAR(255) NOT NULL UNIQUE
);

CREATE TABLE TipoEvento (
	idTipoEvento		INT PRIMARY KEY IDENTITY,
	TituloTipoEvento	VARCHAR(255) NOT NULL UNIQUE
);

CREATE TABLE Instituicao (
	idInstituicao	INT PRIMARY KEY IDENTITY,
	CNPJ			CHAR(14) NOT NULL UNIQUE,
	NomeFantasia	VARCHAR(255) NOT NULL UNIQUE,
	Endereco		VARCHAR(255) NOT NULL UNIQUE
);

CREATE TABLE Usuario (
	idUsuario		INT PRIMARY KEY IDENTITY,
	Nome			VARCHAR(255) NOT NULL,
	Email			VARCHAR(255) NOT NULL UNIQUE,
	Senha			VARCHAR(255) NOT NULL,
	DataCadastro	DATETIME2,
	Genero			VARCHAR(255),
	idTipoUsuario	INT FOREIGN KEY REFERENCES TipoUsuario(idTipoUsuario),
);

USE MASTER;

CREATE TABLE Evento (
	idEvento INT PRIMARY KEY IDENTITY,
	NomeEvento VARCHAR (255) NOT NULL,
	DataEvento DATETIME2 NOT NULL,
	Descricao VARCHAR (255) NOT NULL,
	AcessoLivre BIT DEFAULT (1) NOT NULL,
	idInstituicao INT FOREIGN KEY REFERENCES Instituicao (idInstituicao),
	idTipoEvento INT FOREIGN KEY REFERENCES TipoEvento (idTipoEvento)
);

CREATE TABLE Presenca (
	idPresenca INT PRIMARY KEY IDENTITY,
	idUsuario INT FOREIGN KEY REFERENCES Usuario (idUsuario),
	idEvento INT FOREIGN KEY REFERENCES Evento (idEvento),
	Situacao VARCHAR (255) NOT NULL
);