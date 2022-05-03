drop database DB;

create database DB;

create table Marca(
Id serial 
	Constraint pk_IdMarca 
	Primary Key,
Descricao varchar(40),
Ativa boolean);

create table Grupo(
Id serial 
	Constraint pk_IdGrupo
	Primary Key,
Descricao varchar(40),
Ativo boolean);

CREATE TABLE public.subgrupo
(
	id serial,
	idsubgrupo integer,
    descricao varchar(40),
    idgrupo integer,
    ativo boolean,
    CONSTRAINT pk_id PRIMARY KEY (id),
    CONSTRAINT "fk_idGrupo" FOREIGN KEY (idgrupo)
        REFERENCES public.grupo (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE RESTRICT
);

create table public.produto(
id serial,
	CONSTRAINT pk_idProduto PRIMARY KEY (id),
descricao varchar(50),
dataCadastro date,
idgrupo int,
	CONSTRAINT "fk_idGrupo" FOREIGN KEY (idgrupo)
	REFERENCES public.grupo (id) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,
idsubgrupo int,
	CONSTRAINT "fk_idSubgrupo" FOREIGN KEY (idsubgrupo)
	REFERENCES public.subgrupo (id) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,
idmarca int,
	CONSTRAINT "fk_idmarca" FOREIGN KEY (idmarca)
	REFERENCES public.marca (id) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,
codigoFabricante varchar(20),
infAdicionais varchar(100),
saldoEstoque decimal(10,2),
unidadeMedida varchar(3),
qtdeEstMin decimal(10,2),
qtdeEstIdeal decimal(10,2),
qtdeEstMax decimal(10,2),
precoAnterior decimal(10,2),
precoAtual decimal(10,2),
ativo boolean);

create table MovimentoEstoque(
idMovimento serial,
	CONSTRAINT pk_idMovimento PRIMARY KEY (idMovimento),
descricao varchar(50),
dataMovimento date,
usuarioMovimento varchar(50)
);

create table MovimentoEstoqueItens(
id serial primary key,
idMovimento int,
	CONSTRAINT "fk_idMovimento" FOREIGN KEY (idMovimento)
	REFERENCES public.controleestoque (idMovimento) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,
idProduto int,
	CONSTRAINT "fk_idproduto" FOREIGN KEY (idproduto)
	REFERENCES public.produto (id) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,
-- CONSTRAINT pk_ControleEstoqueItens PRIMARY KEY (idControleEstoque, idProduto),	
saldoestoqueanterior decimal(10,2),
tipomovimento varchar(1),
qtdemovimento decimal(10,2),
saldoestoquenovo decimal(10,2));


-- Insert dos registros

insert into marca values
(1,'MARCA 01',true),
(2,'MARCA 02',true),
(3,'MARCA 03',true),
(4,'MARCA 04',true),
(5,'MARCA 05',true);

insert into grupo values
(1,'GRUPO 01',true),
(2,'GRUPO 02',true),
(3,'GRUPO 03',true),
(4,'GRUPO 04',true),
(5,'GRUPO 05',true);

insert into subgrupo values
(1, 1,'SUBGRUPO 01', 1, true),
(1, 2,'SUBGRUPO 02', 1, true),
(2, 1,'SUBGRUPO 01', 2, true),
(2, 2,'SUBGRUPO 02', 2, true),
(3, 1,'SUBGRUPO 01', 3, true),
(3, 2,'SUBGRUPO 02', 3, true),
(4, 1,'SUBGRUPO 01', 4, true),
(4, 2,'SUBGRUPO 02', 4, true),
(5, 1,'SUBGRUPO 01', 5, true);
(5, 1,'SUBGRUPO 02', 5, true);

insert into produto values
(1,'PRODUTO01',CURRENT_DATE,1,1,1,'FABRICANTE','INF ADICIONAIS', 10,'UN',0,0,0,0,10.00,true),
(2,'PRODUTO02',CURRENT_DATE,1,1,1,'FABRICANTE','INF ADICIONAIS', 15,'UN',0,0,0,0,10.00,true),
(3,'PRODUTO03',CURRENT_DATE,1,1,1,'FABRICANTE','INF ADICIONAIS', 20,'UN',0,0,0,0,10.00,true),
(4,'PRODUTO04',CURRENT_DATE,1,1,1,'FABRICANTE','INF ADICIONAIS', 25,'UN',0,0,0,0,10.00,true),
(5,'PRODUTO05',CURRENT_DATE,1,1,1,'FABRICANTE','INF ADICIONAIS', 30,'UN',0,0,0,0,10.00,true);





