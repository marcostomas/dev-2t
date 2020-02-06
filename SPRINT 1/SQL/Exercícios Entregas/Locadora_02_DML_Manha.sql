USE Locadora_01_DDL_manha;

INSERT INTO Empresa (NomeEmpresa)
VALUES		('McBonalds');

INSERT INTO Cliente (NomeCliente, CPF)
VALUES		('Allan', '123.456.789-11'),
			('Jurandir', '123.456.789-11'),
			('André', '987.654.321-11'),
			('Thiago', '987.654..321-11'),
			('Carlos', '234.156.789-10');


INSERT INTO Marca (NomeMarca)
VALUES		('Volkswagen'),
			('GM'),
			('Fiat'),
			('Audi');

INSERT INTO Modelo (idMarca, NomeCarro)
VALUES		(1, 'Gol'),
			(2, 'Chevette'),
			(3, 'Uno'),
			(4, 'R8');

INSERT INTO Veiculo (idEmpresa, idModelo, Placa)
VALUES		(1, 1, 'ABC-1234'),
			(1, 2, 'ABC-9876'),
			(1, 3, 'DEF-2345'),
			(1, 4, 'KLM-0777');

INSERT INTO Aluguel (idCLiente, idVeiculo, DataInicio, DataFim)
VALUES		(1, 1, '2020-02-03', '2020-02-18'),
			(2, 2, '2020-02-04', '2020-02-19'),
			(3, 3, '2020-02-05', '2020-02-20'),
			(4, 4, '2020-02-05', '2020-02-20');