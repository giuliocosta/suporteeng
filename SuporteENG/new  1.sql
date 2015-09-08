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