USE SPMEDGROUP_MANHA;

INSERT INTO Clinica (CNPJ, RazaoSocial, Endereco)
VALUES		('86.400.902/0001-30', 'SP Medical Group', 'Alameda Barão de Limeira, 532 - São Paulo');

INSERT INTO  TipoUsuario (TipoUsuario)
VALUES		('Comum'),
			('Médico'),
			('Administrador');

INSERT INTO Usuario (idTipoUsuario, idClinica, Email, Senha, Nome)
VALUES		(3, 1, 'admin@spmedicalgroup.com.br', 'senhadoadmin', 'Leninha'),
			(2, 1, 'ricardo.lemos@spmedicalgroup.com.br', 'abc123', 'Ricardo Lemos'),
			(2, 1, 'roberto.possarle@spmedicalgroup.com.br', '123abc', 'Roberto Possarle'),
			(2, 1, 'helena.souza@spmedicalgroup.com.br', 'def345', 'Helena Souza'),
			(1, 1, 'ligia@gmail.com', '345def', 'Ligia'),
			(1, 1, 'alexandre@gmail.com', 'jotape', 'Alexandre'),
			(1, 1, 'fernando@gmail.com', 'abece', 'Fernando'),
			(1, 1, 'henrique@gmail.com', '18011995', 'Henrique'),
			(1, 1, 'joao@hotmail.com', '30211999', 'João'),
			(1, 1, 'bruno@gmail.com', 'abc26', 'Bruno'),
			(1, 1, 'mariana@outlook.com', 'Info@sala13', 'Mariana');

INSERT INTO Administrador (idUsuario, CPF)
VALUES		(1, '123.456.789-11');

INSERT INTO Especialidade (TipoEspecialidade)
VALUES		('Anestesiologia'),
			('Psiquiatria'),
			('Pediatria');

INSERT INTO Medico (idEspecialidade, idUsuario, CRM)
VALUES		(1, 2, '54356-SP'),
			(2, 3, '53452-SP'),
			(3, 4, '65463-SP');

INSERT INTO Prontuario (idUsuario, DataNascimento, Telefone, RG, CPF, Endereco)
VALUES		(5, '1983-10-13', '11 3456-7654', '43.522.543-5', '948.398.590-00', 'Rua Estado de Israel - 240, São Paulo - SP, 04022-000'),
			(6, '2001-07-23', '11 98765-6543', '32.654.345-7', '735.569.440-57', 'Avenida Paulista - 1578, Bela Vista, São Paulo - SP, 01310-200'),
			(7, '1978-10-10', '11 97208-4453', '54.636.525-3', '168.393.380-02', 'Avenida Ibirapuera - 2927, Indianopolis, São Paulo - SP, 04029-200'),
			(8, '1985-10-13', '11 3456-6543', '54.366.362-5', '143.326.547-65', 'Rua Vitória - 120, Vila São Jorge, Barueri - SP, 06402-030'),
			(9, '1975-08-27', '11 7656-6377', '32.544.444-1', '913.053.480-10', 'Rua Vereador Geraldo de Camargo - 66, Santa Luzia, Ribeirão Pires - SP, 09405-380'),
			(10, '1972-03-21', '11 95436-8769', '54.566.266-7', '797.992.990-04', 'Alameda dos Arapanés - 945, Indianopolis, São Paulo - SP, 04524-001'),
			(11, '2018-03-05','', '54.566.266-8', '137.719.130 - 39', 'Rua São Antonio - 232, Vila Universal, Barueri - SP, 06407-140');

INSERT INTO Atendimento (idMedico, idProntuario, DataAtendimento, Situacao)
VALUES		(3, 7, '2020-01-20 15:00:00', 'Realizada'),
			(2, 2, '2020-01-06 10:00:00', 'Cancelada'),
			(2, 3, '2020-02-07 11:00:00', 'Realizada'),
			(2, 2, '2018-02-06 10:00:00', 'Realizada'),
			(1, 4, '2019-02-07 11:00:00', 'Cancelada'),
			(3, 7, '2020-03-08 15:00:00', 'Agendada'),
			(2, 4, '2020-03-09 11:00:00', 'Agendada');