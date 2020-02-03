USE Locadora_01_DDL_manha;

SELECT NomeEmpresa, NomeCliente, CPF, NomeCarro, Placa, DataInicio, DataFim
FROM Aluguel INNER JOIN Cliente ON Aluguel.idCliente = Cliente.idCliente
INNER JOIN Veiculo ON Veiculo.idVeiculo = Aluguel.idVeiculo
INNER JOIN Empresa ON Empresa.idEmpresa = Veiculo.idEmpresa
INNER JOIN Modelo ON Modelo.idModelo = Veiculo.idModelo;