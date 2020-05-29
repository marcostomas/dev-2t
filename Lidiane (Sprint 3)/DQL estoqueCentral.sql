USE estoqueCentral;

/****	C�DIGO LIDIANE:	****/
UPDATE Item set CategoriaID = 1 where quantidadeMinima = 0
UPDATE Item set CategoriaID = 2 where numeroLoteRequerido = 0
UPDATE Item set CategoriaID = 3 where quantidadeMinima = 1
UPDATE Item set CategoriaID = 4 where quantidadeMinima > 0
UPDATE Item set CategoriaID = 5 where CategoriaID is null

select * from item

select * from categoria

-- Cadastrando loja 1 e loja 2 na tabela Armaz�m
insert into Armazem(nome) values('Loja 1')
insert into Armazem(nome) values('Loja 2')

-- Outra op��o de alterar o Corp para Corporation
update Prestador set nome = replace(nome, 'Corp', 'Corporation') where nome like '%corp'

select * from Armazem

-- Alterar dados da loja 1 para id pares e loja 2 para ids impares
update item set LocalID = (select id from Armazem where nome = 'Loja 1') where id % 2 = 0
update item set LocalID = (select id from Armazem where nome = 'Loja 2') where id % 2 <> 0

select * from item 
-- 1. Apresentar os itens cadastrados
-- ID, Nome do Item, Se Registra Num lote, Quantidade M�nima, Nome do fornecedor, Local de Armazenagem

select i.id, i.nome, numeroLoteRequerido, quantidadeMinima, p.nome 'Fornecedor', a.nome 'Loja'
from item as I, Armazem A, Prestador P
where i.FonercedorID = p.id  and i.LocalID = a.id

--Mudando a apresenta��o de numeroLoteRequerido

select i.id, i.nome, iif(numeroLoteRequerido = 0, 'N�o','Sim') 'Lote Requerido', quantidadeMinima, p.nome 'Fornecedor', a.nome 'Loja'
from item I, Armazem A, Prestador p
where i.FonercedorID = p.Id and i.LocalID = a.ID


-- 2. Apresentar o nome do Fornecedor e seus itens
-- Requesito: Cada item ter� um fornecedor relacionado a ele, sendo poss�vel controlar os itens divididos por fornecedor

select * from item
select * from Prestador

-- Mostra os fornecedores e seus itens

select FonercedorID, p.nome, i.id, i.nome
from item I, Prestador p
where i.FonercedorID = p.Id

-- Mostra a quantidade de itens por fornecedor

select FonercedorID, p.nome, count(i.id) as 'Qtd Itens'
from Item I, Prestador P
where i.FonercedorID = p.Id
group by FonercedorID, p.nome

-- Explica��o 'GROUP BY'
select * from Item
select count(id) from Item --Conta o n�mero de rows (linhas)

-- 3. Apresentar o nome da transportadora e seus itens
-- Apresentar a transportadora e a Qtd de itens Entrada
-- Apresentar a transportadora e a Qtd de itens Saida
-- Requisito: A tranportadora ser� outro item importante na an�lise, pois devemos saber qual transportadora � mais utilizada
-- Para fazer a entrega dos produtos e qual � mais utilizada para fazer a sa�da

-- Inserir os dados da loja para as transa��es de venda

select * from Armazem
update Pedido set lojaID = 3 where id between 27 and 33
update Pedido set lojaID = 4 where id > 33

-- Insere dados nas transportadoras qu est�o sem regitro (= null)
select * from Prestador

select * from Item
select * from Pedido
select * from ItemPedido

--Nome das transportadoras, que fizeram o transporte
SELECT transportadoraID , pr.nome
from Pedido p, Prestador pr
where  p.transportadoraID = pr.Id

-- Mostra os itens que foram transportados 
select transportadoraID, pr.nome, p.ID, i.nome, itp.quantidade
from Pedido p, Prestador pr, ItemPedido  itp, Item i
where p.transportadoraID = pr.Id and p.ID = itp.pedidoID and i.ID = itp.itemID

-- Apresentar a transportadora e a Qtd de itens de Entrada

select * from TipoTransacao

select transportadoraID, pr.nome, p.ID, i.nome, itp.quantidade
from Pedido p, Prestador pr, ItemPedido itp, Item i, TipoTransacao tt
where p.transportadoraID = pr.Id and p.ID = itp.pedidoID and i.ID = itp.itemID and p.tipoTransacaoID = tt.Id AND tt.nome = 'Ordem de Compra'
