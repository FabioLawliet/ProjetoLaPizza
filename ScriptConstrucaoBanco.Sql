--CREATE DATABASE db;

/****************************************************************************
TABELA MARCA
****************************************************************************/
CREATE TABLE PUBLIC.MARCA(
IdMarca Serial Primary Key,
Descricao varchar(50),
Ativa bool);

INSERT INTO MARCA VALUES
(1,'MARCA 01',true),
(2,'MARCA 02',true),
(3,'MARCA 03',true),
(4,'MARCA 04',true),
(5,'MARCA 05',true);

/****************************************************************************
TABELA GRUPO
****************************************************************************/
CREATE TABLE PUBLIC.GRUPO(
IdGrupo Serial Primary Key,
Descricao varchar(50),
Ativo bool);

INSERT INTO GRUPO VALUES
(1,'GRUPO 01',true),
(2,'GRUPO 02',true),
(3,'GRUPO 03',true),
(4,'GRUPO 04',true),
(5,'GRUPO 05',true);

/****************************************************************************
TABELA SUBGRUPO
****************************************************************************/
CREATE TABLE PUBLIC.SUBGRUPO(
Id Serial Primary Key,
IdGrupo int,
	CONSTRAINT "FK_idGrupo_TSubgrupo" FOREIGN KEY (IdGrupo)
	REFERENCES PUBLIC.GRUPO (IdGrupo) MATCH SIMPLE
	ON UPDATE NO ACTION
	ON DELETE RESTRICT,
IdSubgrupo int,
Descricao varchar(50),
Ativo bool);

INSERT INTO PUBLIC.SUBGRUPO VALUES
( 1, 1, 1, 'SUBGRUPO 01', true),
( 2, 1, 2, 'SUBGRUPO 02', true),
( 3, 2, 1, 'SUBGRUPO 01', true),
( 4, 2, 2, 'SUBGRUPO 02', true),
( 5, 3, 1, 'SUBGRUPO 01', true),
( 6, 3, 2, 'SUBGRUPO 02', true),
( 7, 4, 1, 'SUBGRUPO 01', true),
( 8, 4, 2, 'SUBGRUPO 02', true),
( 9, 5, 1, 'SUBGRUPO 01', true),
(10, 5, 2, 'SUBGRUPO 02', true);

/****************************************************************************
TABELA UNIDADE MEDIDA
****************************************************************************/
CREATE TABLE PUBLIC.UNIDADEMEDIDA(
IdUnidMedida Serial PRIMARY KEY,
Descricao varchar(50),
Sigla varchar(3),
Ativa bool);

INSERT INTO UNIDADEMEDIDA VALUES
(1, 'UNIDADE', 'UN', true),
(2, 'PEÇA'   , 'PC', true),
(3, 'METRO'  , 'MT', true),
(4, 'LITRO'  , 'LT', true);

/****************************************************************************
TABELA PRODUTO 
****************************************************************************/
CREATE TABLE PUBLIC.PRODUTO(
IdProduto Serial PRIMARY KEY,
Descricao varchar(60),
DataCadastro varchar(20),
Ativo bool,
IdGrupo int,
	CONSTRAINT "FK_idGrupo_TProduto" FOREIGN KEY (IdGrupo)
	REFERENCES public.Grupo (IdGrupo) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,
IdSubGrupo int,
	CONSTRAINT "FK_idSubgrupo_TProduto" FOREIGN KEY (IdSubGrupo)
	REFERENCES public.Subgrupo (Id)
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,
IdMarca int,
	CONSTRAINT "FK_idMarca_TProduto" FOREIGN KEY (IdMarca)
	REFERENCES public.Marca (IdMarca) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,
IdUnidMedida int,
	CONSTRAINT "FK_idUnidMedida_TProduto" FOREIGN KEY (IdUnidMedida)
	REFERENCES public.UnidadeMedida (IdUnidMedida) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,	
CodigoFabricante varchar(20),
InfAdicionais varchar(100),
SaldoEstoque decimal(10,2),
QtdeEstMin decimal(10,2),
QtdeEstIdeal decimal(10,2),
QtdeEstMax decimal(10,2),
PrecoAnterior decimal(10,2),
PrecoAtual decimal(10,2));

insert into produto values
(1,'PRODUTO 01',CURRENT_DATE, true, 1, 1, 1, 1, 'FABRICANTE','INF ADICIONAIS', 10, 0,0,0,0,10.00),
(2,'PRODUTO 02',CURRENT_DATE, true, 1, 1, 1, 1, 'FABRICANTE','INF ADICIONAIS', 15, 0,0,0,0,10.00),
(3,'PRODUTO 03',CURRENT_DATE, true, 1, 1, 1, 1, 'FABRICANTE','INF ADICIONAIS', 20, 0,0,0,0,10.00),
(4,'PRODUTO 04',CURRENT_DATE, true, 1, 1, 1, 1, 'FABRICANTE','INF ADICIONAIS', 25, 0,0,0,0,10.00),
(5,'PRODUTO 05',CURRENT_DATE, true, 1, 1, 1, 1, 'FABRICANTE','INF ADICIONAIS', 30, 0,0,0,0,10.00);

/****************************************************************************
TABELA MOVIMENTO DE ESTOQUE
****************************************************************************/
create table public.MovimentoEstoque(
IdMovimentoEstoque serial PRIMARY KEY,
Descricao varchar(50),
DataMovimento date,
UsuarioMovimento varchar(50)
);

create table public.MovimentoEstoqueItens(
Id serial primary key,
IdMovimentoEstoque int,
	CONSTRAINT "FK_IdMovEstoque_TMovimentoEstoque" FOREIGN KEY (IdMovimentoEstoque)
	REFERENCES public.movimentoestoque (IdMovimentoEstoque) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,
idProduto int,
	CONSTRAINT "FK_IdProduto_TProduto" FOREIGN KEY (idProduto)
	REFERENCES public.Produto (idProduto) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,	
SaldoEstoqueAnterior decimal(10,2),
TipoMovimento varchar(1),
QtdeMovimento decimal(10,2),
SaldoEstoqueNovo decimal (10,2));

/****************************************************************************
TABELA ESTADO
****************************************************************************/
CREATE TABLE ESTADO(
IdEstado serial primary key,
Nome varchar(50),
Sigla varchar(2));

/****************************************************************************
TABELA CIDADE
****************************************************************************/
CREATE TABLE CIDADE(
IdCidade serial primary key,
Nome varchar(100),
IdEstado int, 
	CONSTRAINT "fk_idEstado_TCidade" FOREIGN KEY (idEstado)
	REFERENCES public.Estado (idEstado) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT);

/****************************************************************************
TABELA CLIENTE
****************************************************************************/
CREATE TABLE CLIENTE(
IdCliente serial primary key,
NomeRazao varchar(100),
RgIe varchar(14),
CpfCnpj varchar(14),
Endereco varchar(100),
Numero varchar(5),
Bairro varchar(100),
Complemento varchar(100),
Cep varchar(9),
IdCidade int,
	CONSTRAINT "fk_idCidade_TCliente" FOREIGN KEY (idCidade)
	REFERENCES public.Cidade (idCidade) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,
Telefone varchar(14),
Celular varchar(14),
Email varchar(100),
Ativo bool);

/****************************************************************************
TABELA TIPO PEDIDO
****************************************************************************/

CREATE TABLE PUBLIC.TIPOPEDIDO(
idTipoPedido serial primary key,
Sigla varchar(3),
Descricao varchar(50),
Ativo bool);

INSERT INTO TIPOPEDIDO VALUES
(1, 'NOR', 'VENDA NORMAL', true),
(2, 'ORC', 'ORÇAMENTO'   , true);

/****************************************************************************
TABELA FORMA PAGAMENTO
****************************************************************************/

CREATE TABLE PUBLIC.FORMAPAGAMENTO(
idFormaPagamento serial primary key,
Descricao varchar(50),
PermiteDinheiro bool,
PermitePIX bool,
PermiteCartaoDeb bool,
PermiteCartaoCred bool,
PermiteCheque bool,
PermiteCrediario bool,
ativa bool);

INSERT INTO FORMAPAGAMENTO VALUES
(1, 'A VISTA', false, true, true, false, true, true, true);

/****************************************************************************
TABELA PEDIDO DE VENDA
****************************************************************************/
create table PedidoVenda(
idPedido serial primary key,
idFicha int,
idFormaPagamento int,
	CONSTRAINT "fk_idFormaPagamento_TPedidoVenda" FOREIGN KEY (idFormaPagamento)
	REFERENCES public.FormaPagamento (idFormaPagamento) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,
idTipoPedido int,
	CONSTRAINT "fk_idTipoPedido_TPedidoVenda" FOREIGN KEY (idTipoPedido)
	REFERENCES public.TipoPedido (idTipoPedido) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,
idCliente int,
	CONSTRAINT "fk_idCliente_TPedidoVenda" FOREIGN KEY (idCliente)
	REFERENCES public.cliente (idCliente) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,
--idVendedor int,
dataPedido TimeStamp,
TotalValor numeric(18,2),
TotalDesconto numeric(18,2));

create table pedidoitem(
id serial primary key,
idPedido int,
	CONSTRAINT "fk_idPedido_TPedidoVendaItem" FOREIGN KEY (idPedido)
	REFERENCES public.pedidovenda (idpedido) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,
idPedidoItem int,
idProduto int,
	CONSTRAINT "fk_idProduto_TPedidoVendaItem" FOREIGN KEY (idproduto)
	REFERENCES public.produto (idproduto) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,
idUnidMedida int,
	CONSTRAINT "fk_idUnidMedida_TPedidoVendaItem" FOREIGN KEY (idUnidMedida)
	REFERENCES public.UnidadeMedida (idUnidMedida) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,
Qtde numeric(18,4),
vlrUnitario numeric(18,2),
vlrBruto numeric(18,2),
vlrDesconto numeric(18,2));

/****************************************************************************
TABELA USUARIO
****************************************************************************/
CREATE TABLE USUARIO(
IdUsuario serial primary key,
Nome varchar(100),
LoginUsuario varchar(20),
LoginSenha varchar(20),
UsuarioAdm bool,
Ativo bool);

Insert into usuario VALUES
(1, 'ADMINISTRADOR', 'ADM', 'AMD123', TRUE);

/****************************************************************************
TABELA FORNECEDOR
****************************************************************************/
CREATE TABLE FORNECEDOR(
IdFornecedor serial primary key,
NomeRazao varchar(100),
RgIe varchar(14),
CpfCnpj varchar(14),
Endereco varchar(100),
Numero varchar(5),
Bairro varchar(100),
Complemento varchar(100),
Cep varchar(9),
IdCidade int,
	CONSTRAINT "fk_idCidade_TFornecedor" FOREIGN KEY (idCidade)
	REFERENCES public.Cidade (idCidade) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,
Telefone varchar(14),
Celular varchar(14),
Email varchar(100),
Ativo bool);

/****************************************************************************
TABELA ENTRADAMERCADORIA
****************************************************************************/
CREATE TABLE ENTRADAMERCADORIA(
IdEntradaMerc serial primary key,
IdFornecedor int,
	CONSTRAINT "fk_idFornecedor_TEntradaMercadoria" FOREIGN KEY (idFornecedor)
	REFERENCES public.Fornecedor (idFornecedor) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,
DataAbertura date,  /* Data de abertura */
DataConclusao date, /* Data quando a entrada é concluida */
Status varchar(3),  /* EFE(Efetivada), CAN(Cancelada), PEN(Pendente) */
InfAdicionais varchar(100),
VlrFrete numeric(18,2),     /* ratear esse valor para os itens ao confirmar a entrada */
OutrosCustos numeric(18,2), /* ratear esse valor para os itens ao confirmar a entrada */
VlrUnitarioTotal numeric(18,2),
VlrLiquidoTotal numeric(18,2),
DescontoTotal numeric(18,2));

CREATE TABLE ENTRADAMERCADORIAITEM(
Id serial primary key,
IdEntradaMerc int,
	CONSTRAINT "fk_IdEntradaMerc_TEntradaMercadoriaItem" FOREIGN KEY (IdEntradaMerc)
	REFERENCES public.EntradaMercadoria (IdEntradaMerc) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,
IdEntradaMercItem int,
IdProduto int,
	CONSTRAINT "fk_idProduto_TEntradaMercadoriaItem" FOREIGN KEY (IdProduto)
	REFERENCES public.Produto (IdProduto) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,
Qtde numeric(18,2),
VlrUnitario numeric(18,2),
VlrUnitarioTotal numeric(18,2),
VlrDesconto numeric(18,2),
VlrLiquidoTotal numeric(18,2),
PrecoVenda numeric(18,2));






