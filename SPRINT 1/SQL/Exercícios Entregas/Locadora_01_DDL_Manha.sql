CREATE DATABASE Locadora_01_DDL_manha

USE Locadora_01_DDL_manha;

CREATE TABLE Empresa (
	idEmpresa	INT PRIMARY KEY IDENTITY,
	NomeEmpresa	VARCHAR (200)
);

CREATE TABLE Cliente (
	idCliente	INT PRIMARY KEY IDENTITY,
	NomeCliente	VARCHAR (200) NOT NULL,
	CPF			VARCHAR (20) NOT NULL
);

CREATE TABLE Marca (
	idMarca		INT PRIMARY KEY IDENTITY,
	NomeMarca	VARCHAR (200)
);

CREATE TABLE Modelo (
	idModelo	INT PRIMARY KEY IDENTITY,
	idMarca		INT FOREIGN KEY REFERENCES Marca (idMarca),
	NomeCarro	VARCHAR (200)
);

CREATE TABLE Veiculo (
	idVeiculo	INT PRIMARY KEY IDENTITY,
	idEmpresa	INT FOREIGN KEY REFERENCES Empresa (idEmpresa),
	idModelo	INT FOREIGN KEY REFERENCES Modelo (idModelo),
	Placa		VARCHAR (15) NOT NULL
);

CREATE TABLE Aluguel (
	idAluguel	INT PRIMARY KEY IDENTITY,
	idCliente	INT FOREIGN KEY REFERENCES Cliente (idCliente),
	idVeiculo	INT FOREIGN KEY REFERENCES Veiculo (idVeiculo),
	DataInicio	DATE,
	DataFim		DATE
);
