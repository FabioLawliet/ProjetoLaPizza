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
saldoEstoque numeric(10,4),
unidadeMedida varchar(3),
qtdeEstMin numeric(10,4),
qtdeEstIdeal numeric(10,4),
qtdeEstMax numeric(10,4),
precoAnterior numeric(10,4),
precoAtual numeric(10,4),
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
idControleEstoque int,
	CONSTRAINT "fk_idControleEstoque" FOREIGN KEY (idControleEstoque)
	REFERENCES public.controleestoque (id) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT
    NOT VALID,
idproduto int,
	CONSTRAINT "fk_idproduto" FOREIGN KEY (idproduto)
	REFERENCES public.produto (id) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT
    NOT VALID,
saldoestoqueanterior numeric(10,2),
tipomovimento char,
qtdemovimento numeric(10,2),
saldoestoquenovo numeric(10,2));


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


