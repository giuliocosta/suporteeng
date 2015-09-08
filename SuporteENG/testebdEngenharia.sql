DROP DATABASE progengenharia;
CREATE DATABASE progengenharia;
USE progengenharia;

CREATE TABLE subsistemas(
 id INT UNSIGNED AUTO_INCREMENT NOT NULL,
 nome VARCHAR(50) NOT NULL,
 PRIMARY KEY (id)
);

INSERT INTO subsistemas VALUES (null, 'Captação');

CREATE TABLE combinacao(
 id INT UNSIGNED AUTO_INCREMENT NOT NULL,
 nome VARCHAR(50) NOT NULL,
 subsistemas_id INT UNSIGNED NOT NULL,
 PRIMARY KEY (id),
 FOREIGN KEY (subsistemas_id) REFERENCES subsistemas(id)
);

INSERT INTO combinacao VALUES (null, 'Mastro', 1);

CREATE TABLE produtos(
 id INT UNSIGNED AUTO_INCREMENT NOT NULL,
 codproduto VARCHAR(15) NOT NULL,
 descricao VARCHAR(100) NOT NULL,
 valor DOUBLE NOT NULL,
 PRIMARY KEY (id)
);

INSERT INTO produtos VALUES (null, 'TEL-155', 'Mastro 6M', 30.5);
INSERT INTO produtos VALUES (null, 'TEL-155', 'Abraçadeira', 0.30);

 CREATE TABLE kit(
 id INT UNSIGNED AUTO_INCREMENT NOT NULL,
 descricao VARCHAR(100) NOT NULL,
 combinacao_id INT UNSIGNED NOT NULL,
 PRIMARY KEY (id),
 FOREIGN KEY (combinacao_id) REFERENCES combinacao(id)
);

INSERT INTO kit VALUES(null, 'Mastro  6M Tradicional', 1);

CREATE TABLE prod_kit(
 id INT UNSIGNED AUTO_INCREMENT NOT NULL,
 produtos_id INT UNSIGNED NOT NULL,
 kit_id INT UNSIGNED NOT NULL,
 quantidade INT UNSIGNED NOT NULL,
 PRIMARY KEY (id),
 FOREIGN KEY (produtos_id) REFERENCES produtos(id),
 FOREIGN KEY (kit_id) REFERENCES kit(id)
);

INSERT INTO prod_kit VALUES (null, 1, 1, 1);
INSERT INTO prod_kit VALUES (null, 2, 1, 10);

CREATE TABLE orcamento(
 id INT UNSIGNED AUTO_INCREMENT NOT NULL,
 cliente VARCHAR(50) NOT NULL, 
 data DATE NOT NULL,
 PRIMARY KEY (id)
);

CREATE TABLE itens_orcamento(
 produtos_id INT UNSIGNED NOT NULL,
 quantidade INT UNSIGNED NOT NULL,
 orcamento_id INT UNSIGNED NOT NULL,
 FOREIGN KEY (produtos_id) REFERENCES produtos(id),
 FOREIGN KEY (orcamento_id) REFERENCES orcamento(id) 
);
------------------------------------------------------------------------------------------------------------------------------



--SELECT produtos.descricao, valor * quantidade FROM produtos JOIN prod_kit ON produtos_id = id WHERE kit_id = (SELECT id FROM kit WHERE descricao = 'Mastro  6M Tradicional');
--SELECT SUM(valor * quantidade) FROM produtos JOIN prod_kit ON produtos_id = id WHERE kit_id = (SELECT id FROM kit WHERE descricao = 'Mastro  6M Tradicional');

select sum(valorfinal) from itens_orcamento JOIN produtos ON produtos_id = produtos.id where orcamento_id = 1;


select orcamento_id as 'Id Orçamento', produtos_id as 'Id Produto', produtos.descricao 'Nome Produto', 
sum(valorfinal) as 'Preço', sum(valorfinal)/produtos.valor as 'Quantidade' 
from itens_orcamento 
JOIN produtos ON produtos_id = produtos.id 
where orcamento_id = 1;

select id as Id, cliente as Cliente, valor_total as 'Valor Total', date(data_orcamento) as Data from orcamento;

-----------------------------------------------|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

Editar orçamento ja cadastrado podendo inserir novos produtos

Id orçamento personalizada ddmm/yy-id










