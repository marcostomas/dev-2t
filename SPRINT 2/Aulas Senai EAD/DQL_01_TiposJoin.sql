CREATE DATABASE Tipos_Join
GO

USE Tipos_Join
GO

CREATE TABLE TiposUsuarios(
	IdTipoUsuario	INT PRIMARY KEY IDENTITY,
	Titulo			VARCHAR(150) UNIQUE
);
GO

CREATE TABLE Usuarios(
	IdUsuario		INT PRIMARY KEY IDENTITY,
	Nome			VARCHAR(150),
	IdTipoUsuario	INT FOREIGN KEY REFERENCES TiposUsuarios (IdTipoUsuario)
);
GO

INSERT INTO TiposUsuarios(Titulo)
VALUES		('Administrador'),
			('Comum');
GO

INSERT INTO Usuarios (Nome, IdTipoUsuario)
VALUES		('Usuario A', 1),
			('Usuario B', 2);
GO

--Insere usuário sem idTipoUsuario
INSERT INTO Usuarios (Nome)
VALUES		('Usuario C');
GO

--Lista todos os tipos de usuario
SELECT IdTipoUsuario, Titulo FROM TiposUsuarios;

--Lista todos os usuario
SELECT IdUsuario, Nome, IdTipoUsuario FROM Usuarios;

--Lista toddos os usuarios mostrando o titulo do tipo usuario
SELECT IdUsuario, Nome, Titulo FROM Usuarios
--Join ou Inner Join dará no mesmo. Ambos trarão o mesmo resultado
--Dados da Intersecção
JOIN TiposUsuarios 
ON Usuarios.IdTipoUsuario = TiposUsuarios.IdTipoUsuario

/*
Lista todos os uuarios mostrando as informações de tipo de usuario
mesmo que um usuario não tenha um tipo definido
*/
SELECT IdUsuario, Nome, Titulo FROM Usuarios
--Todos da primeira tabela mesmo que não seja atendido, com o que atender na segunda tabela
LEFT JOIN TiposUsuarios
ON Usuarios.IdTipoUsuario = TiposUsuarios.IdTipoUsuario;


--Todas as informações da segunda tabela e também da primeira, mas da primeira as que atenderem à condição
SELECT IdUsuario, Nome, Titulo FROM Usuarios
RIGHT JOIN TiposUsuarios
ON Usuarios.IdTipoUsuario = TiposUsuarios.IdTipoUsuario;
