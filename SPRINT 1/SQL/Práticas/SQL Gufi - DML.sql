USE Gufi_Manha;

INSERT INTO TipoUsuario (TituloTipoUsuario)
VALUES		('Administrador'),
			('Comum');

INSERT INTO TipoEvento (TituloTipoEvento)
VALUES		('C#'),
			('React'),
			('SQL');

INSERT INTO	Instituicao (CNPJ, NomeFantasia, Endereco)
VALUES	('11111111111111', 'Escola SENAI de Informatica', 'Alameda Bar�o de Limeira,539');

INSERT INTO Usuario (Nome, Email, Senha, DataCadastro, Genero, idTipoUsuario)
VALUES		('Administrador', 'adm@adm.com', 'adm123', '2020-02-06', 'N�o Informado', 1),
			('Carol', 'carol@email.com', 'carol123', '2020-02-06', 'Feminino', 2),
			('Saulo', 'saulo@emaial.com', 'saulo123', '2020-02-06', 'Masculino', 2);

INSERT INTO Evento (NomeEvento, DataEvento, Descricao, AcessoLivre, idInstituicao, idTipoEvento)
VALUES		('Orienta��o a Objetos', '2020-02-07', 'Conceito sobre os pilares da programa��o orientada a objetos', 1, 1, 1),
			('Ciclo de Vida', '2020-02-08', 'Como utilizar os ciclos de vida com a biblioteca ReactJs', 0, 1, 2),
			('Introdu��o a SQL', '2020-02-09', 'Comandos b�sicos utilizando SQL Server', 1, 1, 3);

INSERT INTO Presenca (idUsuario,idEvento, Situacao)
VALUES		(2, 2, 'Confirmada'),
			(2, 3, 'N�o Confirmada'),
			(3, 1, 'Confirmada');