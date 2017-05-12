CREATE TABLE Categoria (
  id_categoria INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  descricao VARCHAR(30) NOT NULL,
  PRIMARY KEY(id_categoria)
);

CREATE TABLE Endereco (
  id_endereco INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  rua VARCHAR(100) NOT NULL,
  numero SMALLINT(5) UNSIGNED NOT NULL,
  bairro VARCHAR(30) NOT NULL,
  cidade VARCHAR(30) NOT NULL,
  uf CHAR(2) NOT NULL,
  complemento VARCHAR(50) NULL,
  PRIMARY KEY(id_endereco)
);

CREATE TABLE Frete (
  id_frete INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  id_transportadora INTEGER UNSIGNED NOT NULL,
  cep_inicial INTEGER(8) UNSIGNED NOT NULL,
  cep_final INTEGER(8) UNSIGNED NOT NULL,
  valor DECIMAL(5,2) NOT NULL,
  prazo TINYINT(2) UNSIGNED NOT NULL,
  PRIMARY KEY(id_frete)
);

CREATE TABLE Produto (
  id_produto INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  id_Tproduto INTEGER UNSIGNED NOT NULL,
  id_categoria INTEGER UNSIGNED NOT NULL,
  nome VARCHAR(50) NOT NULL,
  descricao VARCHAR(255) NULL,
  valor DECIMAL(7,2) NOT NULL,
  PRIMARY KEY(id_produto)
);

CREATE TABLE Tipo_Produto (
  id_Tproduto INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  descricao VARCHAR(30) NOT NULL,
  PRIMARY KEY(id_Tproduto)
);

CREATE TABLE Tipo_Usuario (
  id_Tusuario INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  descricao VARCHAR(20) NOT NULL,
  PRIMARY KEY(id_Tusuario)
);

CREATE TABLE Transportadora (
  id_transportadora INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  nome VARCHAR(100) NOT NULL,
  cnpj BIGINT(14) NOT NULL,
  PRIMARY KEY(id_transportadora)
);

CREATE TABLE Usuario (
  id_usuario INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  id_endereco INTEGER UNSIGNED NOT NULL,
  id_Tusuario INTEGER UNSIGNED NOT NULL,
  cpfcnpj BIGINT(14) NOT NULL,
  dt_nascimento DATE NOT NULL,
  nome VARCHAR(50) NOT NULL,
  email VARCHAR(100) NOT NULL,
  senha VARCHAR(50) NOT NULL,
  dt_criacao DATE NOT NULL,
  cep INTEGER(8) UNSIGNED NOT NULL,
  PRIMARY KEY(id_usuario)
);

CREATE TABLE Venda (
  id_venda INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  id_frete INTEGER UNSIGNED NOT NULL,
  id_usuario INTEGER UNSIGNED NOT NULL,
  valor_total DECIMAL(8,2) NOT NULL,
  dt_realizacao DATE NOT NULL,
  PRIMARY KEY(id_venda)
);

CREATE TABLE Venda_Produto (
  id_venda INTEGER UNSIGNED NOT NULL,
  id_produto INTEGER UNSIGNED NOT NULL,
  qtde TINYINT(3) UNSIGNED NOT NULL,
  valor DECIMAL(8,2) NOT NULL,
  PRIMARY KEY(id_venda, id_produto)
);