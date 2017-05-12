INSERT INTO 
	Transportadora(nome, cnpj) 
VALUES
	("JADLOG", "66545022000150"),
	("SÃO MIGUEL", "23189501001191"),
	("REUNIDAS", "14466640000312"),
	("JAMEF", "25679733000137"),
	("KELLER", "55051198000290")
;

INSERT INTO 
	Frete(id_transportadora, cep_inicial, cep_final, valor, prazo) 
VALUES
	(1, "89035000", "89140000", "19.75", "6"),
	(2, "89035000", "89090000", "22.50", "5"),
	(2, "89090000", "89140000", "12.00", "8"),
	(3, "01010000", "04860000", "10.50", "4"),
	(3, "21640000", "23092000", "14.00", "5"),
	(3, "23000000", "23540000", "15.40", "6"),
	(4, "45607000", "49601000", "22.50", "5"),
	(5, "98060000", "99100000", "18.20", "10")
;

INSERT INTO
	Tipo_Produto(descricao)
VALUES
	("Camisa"),
	("Boné"),
	("Caneca")
;
	
INSERT INTO
	Categoria(descricao)
VALUES
	("Música"),
	("Games"),
	("Programação"),
	("Filmes")
;

INSERT INTO
	Endereco(rua, numero, bairro, cidade, uf, complemento)
VALUES
	("Rua Curitibanos", "301", "Vila Nova", "Blumenau", "SC", NULL),
	("Avenida Manoel Souza Chaves", "1892", "São Caetano", "Itabuna", "BA", "Ap. 12"),
	("Rua Virgem da Lapa", "114", "Campo Grande", "Rio de Janeiro", "RJ", NULL)
;

INSERT INTO
	Tipo_Usuario(descricao)
VALUES
	("Administrador"),
	("Cliente")
;

INSERT INTO
	Produto(id_Tproduto, id_categoria, nome, descricao, valor)
VALUES
	(1, 1, "Camiseta In The End", "Camisa da música In The End da banda Linkin Park - álbum Hybrid Theory.", "59.90"),
	(1, 2, "Camiseta The Cake is a Lie", "Camisa do jogo Portal - desenvolvido por Valve.", "39.90"),
	(3, 2, "Caneca Gamer Life", "Caneca tematizada no estilo gamer. Contém medidor de calor personalizado.", "44.90"),
	(1, 4, "Camiseta Filmes", "", "59.90"),
	(2, 1, "Boné Música", "", "29.90"),
	(2, 3, "Boné Programador", "", "24.90"),
	(3, 1, "Caneca Programador", "", "14.90"),
	(1, 1, "Camiseta Música", "", "49.90"),
	(1, 4, "Camiseta Filmes 2", "", "54.90"),
	(3, 4, "Caneca Filmes", "", "19.90")
;

INSERT INTO
	Usuario(id_endereco, id_Tusuario, cpfcnpj, dt_nascimento, nome, email, senha, dt_criacao, cep)
VALUES
	(1, 1, "09585120941", "1997-10-29", "Mateus Clemer Quintino", "mateus.clemer@gmail.com", "0321654987", "2017-02-28", "89035060"),
	(3, 2, "07561394622", "1995-11-02", "João Tanto Faz", "joao25cm@hotmail.com", "joao25cm", "2017-03-10", "21760350"),
	(2, 2, "12005946513", "1997-03-07", "Maria Qualquer Coisa", "maria9inha@yahoo.com.br", "senha", "2017-04-24", "45607338")
;

INSERT INTO
	Venda(id_frete, id_usuario, valor_total, dt_realizacao)
VALUES
	(1, 1, "79.65", "2017-02-29"),
	(5, 2, "238.50", "2017-03-10"),
	(7, 3, "292.00", "2017-05-01"),
	(2, 1, "62.30", "2017-02-29")
;

INSERT INTO
	Venda_Produto(id_venda, id_produto, qtde, valor)
VALUES
	(1, 1, "1", "59.90"),
	(2, 3, "5", "224.50"),
	(3, 8, "3", "149.70"),
	(3, 4, "2", "119.80"),
	(4, 6, "1", "24.90"),
	(4, 7, "1", "14.90")
;