USE SPMEDGROUP_MANHA;

SELECT * FROM Administrador;
SELECT * FROM Atendimento;
SELECT * FROM Clinica;
SELECT * FROM Especialidade;
SELECT * FROM Medico;
SELECT * FROM Prontuario;
SELECT * FROM TipoUsuario;
SELECT * FROM Usuario;

SELECT CONVERT(VARCHAR, DataNascimento, 110) 'Data Nascimento' FROM Prontuario;

SELECT idUsuario,DataNascimento, DATEDIFF(YEAR,DataNascimento, GETDATE()) AS "Idade"
FROM Prontuario
GO

SELECT * FROM Prontuario INNER JOIN Atendimento ON Prontuario.idProntuario = Atendimento.idAtendimento;

SELECT * FROM Prontuario INNER JOIN Atendimento ON Prontuario.idProntuario = Atendimento.idProntuario
INNER JOIN Medico ON Atendimento.IdMedico = Medico.IdMedico;

SELECT * FROM Medico INNER JOIN Especialidade ON Medico.IdEspecialidade = Especialidade.IdEspecialidade;

SELECT Clinica.RazaoSocial, CNPJ, Endereco, Usuario.Nome, CRM, Email FROM Clinica INNER JOIN Usuario ON Clinica.IdClinica = Usuario.IdClinica
INNER JOIN Medico ON Usuario.IdUsuario = Medico.IdUsuario;

DELETE FROM Especialidade
WHERE IdEspecialidade = 15;

SELECT * FROM Usuario;

SELECT count (IdUsuario) AS QuantidadeUsuario FROM Usuario;

SELECT count (IdMedico) AS QuantidadeMedicoPorEspec FROM Medico INNER JOIN Especialidade ON  Medico.IdEspecialidade = Especialidade.IdEspecialidade
WHERE Especialidade.idEspecialidade = 2;
