USE Gufi_Manha;

SELECT Nome, Email, Senha, DataCadastro, Genero, TituloTipoUsuario  FROM Usuario
INNER JOIN TipoUsuario ON Usuario.idTipoUsuario = TipoUsuario.idTipoUsuario;

SELECT CNPJ, NomeFantasia, Endereco FROM Instituicao;

SELECT TituloTipoEvento FROM TipoEvento;

SELECT NomeEvento, DataEvento, Descricao, AcessoLivre, NomeFantasia, CNPJ, Endereco, TituloTipoEvento FROM Evento
INNER JOIN Instituicao ON Evento.idInstituicao = Instituicao.idInstituicao
INNER JOIN TipoEvento ON Evento.idTipoEvento = TipoEvento.idTipoEvento
WHERE AcessoLivre = 1;

SELECT NomeEvento, DataEvento, Descricao, AcessoLivre, NomeFantasia, CNPJ, Endereco, TituloTipoEvento, Nome, Email, Genero FROM Evento
INNER JOIN Instituicao ON Evento.idInstituicao = Instituicao.idInstituicao
INNER JOIN TipoEvento ON Evento.idTipoEvento = TipoEvento.idTipoEvento
INNER JOIN Presenca ON Evento.idEvento = Presenca.idEvento
INNER JOIN Usuario ON Presenca.idUsuario = Usuario.idUsuario
WHERE Usuario.idUsuario = 2;

---------------------------------------------------------------EXTRAS------------------------------------------------------------------------
/* Extra 1 */

--Forma 1

SELECT NomeEvento, DataEvento, Descricao, REPLACE(REPLACE (AcessoLivre, '1' , 'Público'), '0', 'Privado'), NomeFantasia, CNPJ, Endereco, TituloTipoEvento FROM Evento
INNER JOIN Instituicao ON Evento.idInstituicao = Instituicao.idInstituicao
INNER JOIN TipoEvento ON Evento.idTipoEvento = TipoEvento.idTipoEvento
WHERE AcessoLivre = 1;

--Forma 2

SELECT NomeEvento,
CASE AcessoLivre
	WHEN 1 THEN	'Publico'
	WHEN 0 THEN 'Privado'
END AS Acesso FROM Evento;

/* Extra 2 */

SELECT NomeEvento, DataEvento, Descricao, AcessoLivre, NomeFantasia, CNPJ, Endereco, TituloTipoEvento, Nome, Email, Genero, Situacao FROM Evento
INNER JOIN Instituicao ON Evento.idInstituicao = Instituicao.idInstituicao
INNER JOIN TipoEvento ON Evento.idTipoEvento = TipoEvento.idTipoEvento
INNER JOIN Presenca ON Evento.idEvento = Presenca.idEvento
INNER JOIN Usuario ON Presenca.idUsuario = Usuario.idUsuario
WHERE Usuario.idUsuario = 2 AND Presenca.Situacao = 'Confirmada';

