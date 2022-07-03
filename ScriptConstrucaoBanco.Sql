--CREATE DATABASE db;

/****************************************************************************
TABELA MARCA
****************************************************************************/
create sequence marca_seq increment 1 start 1;
CREATE TABLE PUBLIC.MARCA(
IdMarca integer primary key default nextval('marca_seq'),
Descricao varchar(50),
Ativa bool);

INSERT INTO MARCA (Descricao, Ativa)
VALUES
('MARCA 01',true),
('MARCA 02',true),
('MARCA 03',true),
('MARCA 04',true),
('MARCA 05',true);

/****************************************************************************
TABELA GRUPO
****************************************************************************/
create sequence grupo_seq increment 1 start 1;
CREATE TABLE PUBLIC.GRUPO(
IdGrupo integer primary key default nextval('grupo_seq'),
Descricao varchar(50),
Ativo bool);

INSERT INTO GRUPO (Descricao, Ativo)
VALUES
('GRUPO 01',true),
('GRUPO 02',true),
('GRUPO 03',true),
('GRUPO 04',true),
('GRUPO 05',true);

/****************************************************************************
TABELA SUBGRUPO
****************************************************************************/
create sequence subgrupo_seq increment 1 start 1;
CREATE TABLE PUBLIC.SUBGRUPO(
Id integer primary key default nextval('subgrupo_seq'),
IdGrupo int,
	CONSTRAINT "FK_idGrupo_TSubgrupo" FOREIGN KEY (IdGrupo)
	REFERENCES PUBLIC.GRUPO (IdGrupo) MATCH SIMPLE
	ON UPDATE NO ACTION
	ON DELETE RESTRICT,
IdSubgrupo int,
Descricao varchar(50),
Ativo bool);

INSERT INTO PUBLIC.SUBGRUPO (IdGrupo, IdSubGrupo, Descricao, Ativo)
VALUES
(1, 1, 'SUBGRUPO 01', true),
(1, 2, 'SUBGRUPO 02', true),
(2, 1, 'SUBGRUPO 01', true),
(2, 2, 'SUBGRUPO 02', true),
(3, 1, 'SUBGRUPO 01', true),
(3, 2, 'SUBGRUPO 02', true),
(4, 1, 'SUBGRUPO 01', true),
(4, 2, 'SUBGRUPO 02', true),
(5, 1, 'SUBGRUPO 01', true),
(5, 2, 'SUBGRUPO 02', true);

/****************************************************************************
TABELA UNIDADE MEDIDA
****************************************************************************/
create sequence unidademedida_seq increment 1 start 1;
CREATE TABLE PUBLIC.UNIDADEMEDIDA(
IdUnidMedida integer primary key default nextval('unidademedida_seq'),
Descricao varchar(50),
Sigla varchar(3),
Ativa bool);

INSERT INTO UNIDADEMEDIDA (Descricao, Sigla, Ativa)
VALUES
('UNIDADE', 'UN', true),
('PEÇA'   , 'PC', true),
('METRO'  , 'MT', true),
('LITRO'  , 'LT', true);

/****************************************************************************
TABELA PRODUTO 
****************************************************************************/
create sequence produto_seq increment 1 start 1;
CREATE TABLE PUBLIC.PRODUTO(
IdProduto integer primary key default nextval('produto_seq'),
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

insert into produto (Descricao, DataCadastro, Ativo, IdGrupo, IdSubGrupo, IdMarca, IdUnidMedida, 
CodigoFabricante, InfAdicionais, SaldoEstoque, QtdeEstMin, QtdeEstIdeal, QtdeEstMax, PrecoAnterior, PrecoAtual)
values
('Pizza P Salgada',CURRENT_DATE, true, 1, 1, 1, 1, 'FABRICANTE','INF ADICIONAIS', 99, 0,0,0,0,50.00),
('Pizza G Salgada',CURRENT_DATE, true, 1, 1, 1, 1, 'FABRICANTE','INF ADICIONAIS', 99, 0,0,0,0,60.00),
('Pizza GG Salgada',CURRENT_DATE, true, 1, 1, 1, 1, 'FABRICANTE','INF ADICIONAIS', 99, 0,0,0,0,70.00),
('Pizza P Doce',CURRENT_DATE, true, 1, 1, 1, 1, 'FABRICANTE','INF ADICIONAIS', 99, 0,0,0,0,50.00),
('Pizza G Doce',CURRENT_DATE, true, 1, 1, 1, 1, 'FABRICANTE','INF ADICIONAIS', 99, 0,0,0,0,60.00),
('Pizza GG Doce',CURRENT_DATE, true, 1, 1, 1, 1, 'FABRICANTE','INF ADICIONAIS', 99, 0,0,0,0,70.00),
('Refrigerante Garrafa 1L',CURRENT_DATE, true, 1, 1, 1, 1, 'FABRICANTE','INF ADICIONAIS', 99, 0,0,0,0,9.00),
('Refrigerante Lata 300ml',CURRENT_DATE, true, 1, 1, 1, 1, 'FABRICANTE','INF ADICIONAIS', 99, 0,0,0,0,4.00),
('Suco Laranja',CURRENT_DATE, true, 1, 1, 1, 1, 'FABRICANTE','INF ADICIONAIS', 99, 0,0,0,0,8.00),
('Suco Morango',CURRENT_DATE, true, 1, 1, 1, 1, 'FABRICANTE','INF ADICIONAIS', 99, 0,0,0,0,8.00),
('Suco Abacaxi',CURRENT_DATE, true, 1, 1, 1, 1, 'FABRICANTE','INF ADICIONAIS', 99, 0,0,0,0,8.00);

/****************************************************************************
TABELA MOVIMENTO DE ESTOQUE
****************************************************************************/
create sequence movimentoestoque_seq increment 1 start 1;
create table public.MovimentoEstoque(
IdMovimentoEstoque integer primary key default nextval('movimentoestoque_seq'),
Descricao varchar(50),
DataMovimento date,
UsuarioMovimento varchar(50)
);

create sequence movimentoestoqueitem_seq increment 1 start 1;
create table public.MovimentoEstoqueItens(
Id integer primary key default nextval('movimentoestoqueitem_seq'),
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
create sequence estado_seq increment 1 start 1;
CREATE TABLE ESTADO(
IdEstado integer primary key default nextval('estado_seq'),
Nome varchar(50),
Sigla varchar(2));

INSERT INTO estado (nome, sigla) VALUES
('Acre', 'AC'),
('Alagoas', 'AL'),
('Amazonas', 'AM'),
('Amapá', 'AP'),
('Bahia', 'BA'),
('Ceará', 'CE'),
('Distrito Federal', 'DF'),
('Espírito Santo', 'ES'),
('Goiás', 'GO'),
('Maranhão', 'MA'),
('Minas Gerais', 'MG'),
('Mato Grosso do Sul', 'MS'),
('Mato Grosso', 'MT'),
('Pará', 'PA'),
('Paraíba', 'PB'),
('Pernambuco', 'PE'),
('Piauí', 'PI'),
('Paraná', 'PR'),
('Rio de Janeiro', 'RJ'),
('Rio Grande do Norte', 'RN'),
('Rondônia', 'RO'),
('Roraima', 'RR'),
('Rio Grande do Sul', 'RS'),
('Santa Catarina', 'SC'),
('Sergipe', 'SE'),
('São Paulo', 'SP'),
('Tocantins', 'TO');

/****************************************************************************
TABELA CIDADE
****************************************************************************/
create sequence cidade_seq increment 1 start 1;
CREATE TABLE CIDADE(
IdCidade integer primary key default nextval('cidade_seq'),
Nome varchar(100),
IdEstado int, 
	CONSTRAINT "fk_idEstado_TCidade" FOREIGN KEY (idEstado)
	REFERENCES public.Estado (idEstado) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT);
	
INSERT INTO cidade (nome, idestado) 
VALUES	
('CASCAVEL', 18),
('CURITIBA', 18),
('FOZ DO IGUAÇU', 18),
('TOLEDO', 18);

/****************************************************************************
TABELA CLIENTE
****************************************************************************/
create sequence cliente_seq increment 1 start 1;
CREATE TABLE CLIENTE(
IdCliente integer primary key default nextval('cliente_seq'),
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
create sequence tipopedido_seq increment 1 start 1;
CREATE TABLE PUBLIC.TIPOPEDIDO(
idTipoPedido integer primary key default nextval('tipopedido_seq'),
Sigla varchar(3),
Descricao varchar(50),
Ativo bool);

INSERT INTO TIPOPEDIDO (SIGLA, DESCRICAO, ATIVO)
VALUES
('NOR', 'VENDA NORMAL', true),
('ORC', 'ORÇAMENTO'   , true);

/****************************************************************************
TABELA FORMA PAGAMENTO
****************************************************************************/
create sequence formapagamento_seq increment 1 start 1;
CREATE TABLE PUBLIC.FORMAPAGAMENTO(
idFormaPagamento integer primary key default nextval('formapagamento_seq'),
Descricao varchar(50),
PermiteDinheiro bool,
PermitePIX bool,
PermiteCartaoDeb bool,
PermiteCartaoCred bool,
PermiteCheque bool,
PermiteCrediario bool,
ativa bool);

INSERT INTO FORMAPAGAMENTO (Descricao, PermiteDinheiro, PermitePIX, PermiteCartaoDeb, 
PermiteCartaoCred, PermiteCheque, PermiteCrediario, ativa)
VALUES 
('DINHEIRO', true, true, true, true, true, true, true),
('CARTAO CREDITO', true, true, true, true, true, true, true),
('CARTAO DEBITO', true, true, true, true, true, true, true);

/****************************************************************************
TABELA PEDIDO DE VENDA
****************************************************************************/
create sequence pedidovenda_seq increment 1 start 1;
create table PedidoVenda(
idPedido integer primary key default nextval('pedidovenda_seq'),
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
vlrTotalBruto numeric(18,2),
vlrTotalDescontos numeric(18,2));

create sequence pedidovendaitem_seq increment 1 start 1;
create table pedidoitem(
idItem integer primary key default nextval('pedidovendaitem_seq'),
idPedido int,
	CONSTRAINT "fk_idPedido_TPedidoVendaItem" FOREIGN KEY (idPedido)
	REFERENCES public.pedidovenda (idpedido) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,
idProduto int,
	CONSTRAINT "fk_idProduto_TPedidoVendaItem" FOREIGN KEY (idproduto)
	REFERENCES public.produto (idproduto) MATCH SIMPLE
	ON UPDATE NO ACTION
    ON DELETE RESTRICT,
Qtde numeric(18,4),
vlrUnitario numeric(18,2),
vlrBruto numeric(18,2),
vlrDesconto numeric(18,2));

/****************************************************************************
TABELA USUARIO
****************************************************************************/
create sequence usuario_seq increment 1 start 1;
CREATE TABLE USUARIO(
IdUsuario integer primary key default nextval('usuario_seq'),
Nome varchar(100),
LoginUsuario varchar(20),
LoginSenha varchar(20),
UsuarioAdm bool,
Ativo bool);

Insert into usuario (Nome, LoginUsuario, LoginSenha, UsuarioAdm, Ativo)
VALUES('ADMINISTRADOR', 'ADM', 'AMD123', TRUE, TRUE);

/****************************************************************************
TABELA FORNECEDOR
****************************************************************************/
create sequence fornecedor_seq increment 1 start 1;
CREATE TABLE FORNECEDOR(
IdFornecedor integer primary key default nextval('fornecedor_seq'),
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
create sequence entradamercadoria_seq increment 1 start 1;
CREATE TABLE ENTRADAMERCADORIA(
IdEntradaMerc integer primary key default nextval('entradamercadoria_seq'),
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

create sequence entradamercadoriaitem_seq increment 1 start 1;
CREATE TABLE ENTRADAMERCADORIAITEM(
Id integer primary key default nextval('entradamercadoriaitem_seq'),
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