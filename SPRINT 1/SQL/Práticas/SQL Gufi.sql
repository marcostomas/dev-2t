/* Cria o banco de dados com o nome Gufi */
CREATE DATABASE Gufi;

/* Define o banco de dados a ser utilizado */
USE Gufi;

/* Criação das Tabelas */
CREATE TABLE TipoUsuario (
	idTipoUsuario		INT PRIMARY KEY IDENTITY,
	TituloTipoUsuario	VARCHAR(255) NOT NULL
);

CREATE TABLE TipoEvento (
	idTipoEvento		INT PRIMARY KEY IDENTITY,
	TituloTipoEvento	VARCHAR(255) NOT NULL
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