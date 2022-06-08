drop database db;

create database db;

create table public.marca(
Id serial 
	Constraint pk_IdMarca 
	Primary Key,
Descricao varchar(40),
Ativa boolean);

create table public.grupo(
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

create table public.MovimentoEstoque(
idMovimento serial,
	CONSTRAINT pk_idMovimento PRIMARY KEY (idMovimento),
descricao varchar(50),
dataMovimento date,
usuarioMovimento varchar(50)
);

create table public.MovimentoEstoqueItens(
id serial primary key,
idMovimento int,
	CONSTRAINT "fk_idMovimento" FOREIGN KEY (idMovimento)
	REFERENCES public.movimentoestoque (idMovimento) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,
idProduto int,
	CONSTRAINT "fk_idproduto" FOREIGN KEY (idproduto)
	REFERENCES public.produto (id) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,	
saldoestoqueanterior decimal(10,2),
tipomovimento varchar(1),
qtdemovimento decimal(10,2),
saldoestoquenovo decimal(10,2));

create table usuario(
Id SERIAL PRIMARY KEY NOT NULL,
Nome VARCHAR(50),
Usuario VARCHAR(30),
Senha VARCHAR(30),
Ativo bool	
);

CREATE TABLE IF NOT EXISTS public.cliente
(
    id integer NOT NULL DEFAULT nextval('produto_id_seq'::regclass),
    nome character varying(50) COLLATE pg_catalog."default",
    sobrenome character varying(50) COLLATE pg_catalog."default",
    rg character varying(8) COLLATE pg_catalog."default",
    cpf character varying(11) COLLATE pg_catalog."default",
    endereco character varying(200) COLLATE pg_catalog."default",
    bairro character varying(50) COLLATE pg_catalog."default",
    cidade character varying(50) COLLATE pg_catalog."default",
    estado character varying(2) COLLATE pg_catalog."default",
    telefone character varying(13) COLLATE pg_catalog."default",
    email character varying(50) COLLATE pg_catalog."default",
    ativo boolean,
    numero character varying(5) COLLATE pg_catalog."default",
    CONSTRAINT cliente_pkey PRIMARY KEY (id)
);

-- Insert de registros genéricos

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
(2, 2,'SUBGRUPO 02', 1, true),
(3, 1,'SUBGRUPO 01', 2, true),
(4, 2,'SUBGRUPO 02', 2, true),
(5, 1,'SUBGRUPO 01', 3, true),
(6, 2,'SUBGRUPO 02', 3, true),
(7, 1,'SUBGRUPO 01', 4, true),
(8, 2,'SUBGRUPO 02', 4, true),
(9, 1,'SUBGRUPO 01', 5, true),
(10, 2,'SUBGRUPO 02', 5, true);

insert into produto values
(1,'PRODUTO 01',CURRENT_DATE,1,1,1,'FABRICANTE','INF ADICIONAIS', 10,'UN',0,0,0,0,10.00,true),
(2,'PRODUTO 02',CURRENT_DATE,1,1,1,'FABRICANTE','INF ADICIONAIS', 15,'UN',0,0,0,0,10.00,true),
(3,'PRODUTO 03',CURRENT_DATE,1,1,1,'FABRICANTE','INF ADICIONAIS', 20,'UN',0,0,0,0,10.00,true),
(4,'PRODUTO 04',CURRENT_DATE,1,1,1,'FABRICANTE','INF ADICIONAIS', 25,'UN',0,0,0,0,10.00,true),
(5,'PRODUTO 05',CURRENT_DATE,1,1,1,'FABRICANTE','INF ADICIONAIS', 30,'UN',0,0,0,0,10.00,true);