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

drop table subgrupo;

CREATE TABLE public.subgrupo
(
	id serial,
    descricao character varying(40) COLLATE pg_catalog."default",
    idgrupo integer,
    ativo boolean,
    CONSTRAINT pk_idsubgrupo PRIMARY KEY (id),
    CONSTRAINT "fk_idGrupo" FOREIGN KEY (idgrupo)
        REFERENCES public.grupo (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE RESTRICT
        NOT VALID
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
    ON DELETE RESTRICT
    NOT VALID,
idsubgrupo int,
	CONSTRAINT "fk_idSubgrupo" FOREIGN KEY (idsubgrupo)
	REFERENCES public.subgrupo (id) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT
    NOT VALID,
idmarca int,
	CONSTRAINT "fk_idmarca" FOREIGN KEY (idmarca)
	REFERENCES public.marca (id) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT
    NOT VALID,
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

create table ControleEstoque(
id serial,
	CONSTRAINT pk_idControleEstoque PRIMARY KEY (id),
descricao varchar(50),
datamovimentacao date,
usuariomovimentacao varchar(50)
);

create table ControleEstoqueItens(
id serial,
	CONSTRAINT pk_idControleEstoqueItens PRIMARY KEY (id),
idControleEstoque serial,
idproduto int,
	CONSTRAINT "fk_idproduto" FOREIGN KEY (idproduto)
	REFERENCES public.produto (id) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,
saldoestoqueanterior decimal(10,2),
tipomovimento varchar(1),
qtdemovimento decimal(10,2),
saldoestoquenovo decimal(10,2));


-- Insert dos registros

insert into marca values
(1,'MARCA01',true),
(2,'MARCA02',true),
(3,'MARCA03',true),
(4,'MARCA04',true),
(5,'MARCA05',true);

insert into grupo values
(1,'GRUPO01',true),
(2,'GRUPO02',true),
(3,'GRUPO03',true),
(4,'GRUPO04',true),
(5,'GRUPO05',true);

insert into subgrupo values
(1,'SUBGRUPO01', 1, true),
(2,'SUBGRUPO02', 1, true),
(3,'SUBGRUPO03', 1, true),
(4,'SUBGRUPO04', 1, true),
(5,'SUBGRUPO05', 1, true);

insert into produto values
(1,'PRODUTO01',CURRENT_DATE,1,1,1,'fabricante','inf adicionais', 10,'UN',0,0,0,0,10.00,true),
(2,'PRODUTO02',CURRENT_DATE,1,1,1,'fabricante','inf adicionais', 15,'UN',0,0,0,0,10.00,true),
(3,'PRODUTO03',CURRENT_DATE,1,1,1,'fabricante','inf adicionais', 20,'UN',0,0,0,0,10.00,true),
(4,'PRODUTO04',CURRENT_DATE,1,1,1,'fabricante','inf adicionais', 25,'UN',0,0,0,0,10.00,true),
(5,'PRODUTO05',CURRENT_DATE,1,1,1,'fabricante','inf adicionais', 30,'UN',0,0,0,0,10.00,true);


