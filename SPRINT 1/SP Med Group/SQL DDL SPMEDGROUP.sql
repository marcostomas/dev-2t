CREATE DATABASE SPMEDGROUP_MANHA;

USE SPMEDGROUP_MANHA;

CREATE TABLE Clinica (
	idClinica	INT PRIMARY KEY IDENTITY,
	CNPJ		CHAR(20) NOT NULL,
	RazaoSocial	CHAR(255) NOT NULL,
	Endereco	VARCHAR(255) NOT NULL
);

CREATE TABLE TipoUsuario (
	idTipoUsuario	INT PRIMARY KEY IDENTITY,
	TipoUsuario		VARCHAR(255) NOT NULL,
);

CREATE TABLE Usuario (
	idUsuario		INT PRIMARY KEY IDENTITY,
	idTipoUsuario	INT FOREIGN KEY REFERENCES TipoUsuario (idTipoUsuario) NOT NULL,
	idClinica		INT FOREIGN KEY REFERENCES Clinica (idClinica) NOT NULL,
	Email			VARCHAR(255) NOT NULL,
	Senha			VARCHAR(255) NOT NULL,
	Nome			VARCHAR(255) NOT NULL
);

CREATE TABLE Administrador (
	idUsuario	INT FOREIGN KEY REFERENCES Usuario (idUsuario) NOT NULL,
	CPF			CHAR(20) NOT NULL
);

CREATE TABLE Especialidade (
	idEspecialidade		INT PRIMARY KEY IDENTITY,
	TipoEspecialidade	VARCHAR(255)
);

CREATE TABLE Medico (
	idMedico		INT PRIMARY KEY IDENTITY,
	idEspecialidade	INT FOREIGN KEY REFERENCES Especialidade (idEspecialidade) NOT NULL,
	idUsuario		INT FOREIGN KEY REFERENCES Usuario (idUsuario) NOT NULL,
	CRM				CHAR (20)
);

CREATE TABLE Prontuario (
	idProntuario	INT PRIMARY KEY IDENTITY,
	idUsuario		INT FOREIGN KEY REFERENCES Usuario (idUsuario) NOT NULL,
	DataNascimento	DATETIME2 NOT NULL,
	Telefone		CHAR(20) NOT NULL,
	RG				CHAR(20) NOT NULL,
	CPF				CHAR(20) NOT NULL,
	Endereco		VARCHAR(255) NOT NULL
);

CREATE TABLE Atendimento (
	idAtendimento	INT PRIMARY KEY IDENTITY,
	idMedico		INT FOREIGN KEY REFERENCES Medico (idMedico) NOT NULL,
	idProntuario	INT FOREIGN KEY REFERENCES Prontuario (idProntuario) NOT NULL,
	DataAtendimento	DATETIME2,
	Situacao		VARCHAR(255)
);