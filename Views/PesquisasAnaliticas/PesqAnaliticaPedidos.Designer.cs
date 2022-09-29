namespace LaPizza.Views.PesquisasAnaliticas
{
    partial class PesqAnaliticaPedidos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPedidos = new System.Windows.Forms.Label();
            this.GridPedidos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.GridProdutos = new System.Windows.Forms.DataGridView();
            this.cbPesquisarAtivos = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lbOrdenar = new System.Windows.Forms.Label();
            this.lbPesquisarApenas = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BoxFiltro = new System.Windows.Forms.GroupBox();
            this.ProdutoColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoColDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoColQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoColVlrUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoColVlrDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoColVlrBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoColAbertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoColFechamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoColPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoColTipoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoColDescontos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoColVlrBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPrincipal.SuspendLayout();
            this.pnlNomeRotina.SuspendLayout();
            this.pnlAcoesRodape.SuspendLayout();
            this.pnlAcoesMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPedidos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).BeginInit();
            this.BoxFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.GridProdutos);
            this.pnlPrincipal.Controls.Add(this.panel2);
            this.pnlPrincipal.Controls.Add(this.GridPedidos);
            this.pnlPrincipal.Controls.Add(this.panel1);
            this.pnlPrincipal.Controls.Add(this.BoxFiltro);
            this.pnlPrincipal.Size = new System.Drawing.Size(828, 483);
            // 
            // pnlNomeRotina
            // 
            this.pnlNomeRotina.Size = new System.Drawing.Size(828, 40);
            // 
            // btnAcaoAdicionar
            // 
            this.btnAcaoAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAcaoAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.Location = new System.Drawing.Point(688, 5);
            // 
            // btnAcaoEditar
            // 
            this.btnAcaoEditar.FlatAppearance.BorderSize = 0;
            this.btnAcaoEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.Location = new System.Drawing.Point(723, 5);
            // 
            // btnAcaoConsultar
            // 
            this.btnAcaoConsultar.FlatAppearance.BorderSize = 0;
            this.btnAcaoConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.Location = new System.Drawing.Point(758, 5);
            // 
            // lbNomeRotina
            // 
            this.lbNomeRotina.Size = new System.Drawing.Size(828, 40);
            this.lbNomeRotina.Text = "Form1";
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 562);
            this.pnlAcoesRodape.Size = new System.Drawing.Size(828, 40);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.Location = new System.Drawing.Point(678, 5);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSair.Location = new System.Drawing.Point(753, 5);
            // 
            // btnAcaoExcluir
            // 
            this.btnAcaoExcluir.FlatAppearance.BorderSize = 0;
            this.btnAcaoExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.Location = new System.Drawing.Point(793, 5);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(603, 5);
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(718, 5);
            // 
            // pnlAcoesMenu
            // 
            this.pnlAcoesMenu.Size = new System.Drawing.Size(828, 39);
            this.pnlAcoesMenu.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.lbPedidos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 20);
            this.panel1.TabIndex = 42;
            // 
            // lbPedidos
            // 
            this.lbPedidos.AutoSize = true;
            this.lbPedidos.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPedidos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPedidos.Location = new System.Drawing.Point(0, 0);
            this.lbPedidos.Name = "lbPedidos";
            this.lbPedidos.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lbPedidos.Size = new System.Drawing.Size(62, 17);
            this.lbPedidos.TabIndex = 0;
            this.lbPedidos.Text = "PEDIDOS";
            // 
            // GridPedidos
            // 
            this.GridPedidos.AllowUserToDeleteRows = false;
            this.GridPedidos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PedidoColId,
            this.PedidoColAbertura,
            this.PedidoColFechamento,
            this.PedidoColCliente,
            this.PedidoColPagamento,
            this.PedidoColStatus,
            this.PedidoColTipoPedido,
            this.PedidoColDescontos,
            this.PedidoColVlrBruto});
            this.GridPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridPedidos.Location = new System.Drawing.Point(0, 82);
            this.GridPedidos.MultiSelect = false;
            this.GridPedidos.Name = "GridPedidos";
            this.GridPedidos.ReadOnly = true;
            this.GridPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPedidos.Size = new System.Drawing.Size(828, 162);
            this.GridPedidos.TabIndex = 43;
            this.GridPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPedidos_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 20);
            this.panel2.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRODUTOS";
            // 
            // GridProdutos
            // 
            this.GridProdutos.AllowUserToDeleteRows = false;
            this.GridProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdutoColId,
            this.ProdutoColDescricao,
            this.ProdutoColQtde,
            this.ProdutoColVlrUnitario,
            this.ProdutoColVlrDesconto,
            this.ProdutoColVlrBruto});
            this.GridProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridProdutos.Location = new System.Drawing.Point(0, 264);
            this.GridProdutos.MultiSelect = false;
            this.GridProdutos.Name = "GridProdutos";
            this.GridProdutos.ReadOnly = true;
            this.GridProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProdutos.Size = new System.Drawing.Size(828, 219);
            this.GridProdutos.TabIndex = 45;
            // 
            // cbPesquisarAtivos
            // 
            this.cbPesquisarAtivos.FormattingEnabled = true;
            this.cbPesquisarAtivos.Items.AddRange(new object[] {
            "Ativos",
            "Inativos",
            "Ativos/Inativos"});
            this.cbPesquisarAtivos.Location = new System.Drawing.Point(377, 30);
            this.cbPesquisarAtivos.Name = "cbPesquisarAtivos";
            this.cbPesquisarAtivos.Size = new System.Drawing.Size(219, 21);
            this.cbPesquisarAtivos.TabIndex = 8;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Cód. Produto",
            "Desc. Produto"});
            this.cbStatus.Location = new System.Drawing.Point(208, 30);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(163, 21);
            this.cbStatus.TabIndex = 7;
            // 
            // lbOrdenar
            // 
            this.lbOrdenar.AutoSize = true;
            this.lbOrdenar.Location = new System.Drawing.Point(205, 15);
            this.lbOrdenar.Name = "lbOrdenar";
            this.lbOrdenar.Size = new System.Drawing.Size(40, 13);
            this.lbOrdenar.TabIndex = 39;
            this.lbOrdenar.Text = "Status:";
            // 
            // lbPesquisarApenas
            // 
            this.lbPesquisarApenas.AutoSize = true;
            this.lbPesquisarApenas.Location = new System.Drawing.Point(374, 14);
            this.lbPesquisarApenas.Name = "lbPesquisarApenas";
            this.lbPesquisarApenas.Size = new System.Drawing.Size(111, 13);
            this.lbPesquisarApenas.TabIndex = 40;
            this.lbPesquisarApenas.Text = "Forma de Pagamento:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.IndianRed;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPesquisar.Location = new System.Drawing.Point(602, 31);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(167, 20);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Data inicial:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Data final:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(108, 31);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker2.TabIndex = 50;
            // 
            // BoxFiltro
            // 
            this.BoxFiltro.Controls.Add(this.dateTimePicker2);
            this.BoxFiltro.Controls.Add(this.label3);
            this.BoxFiltro.Controls.Add(this.dateTimePicker1);
            this.BoxFiltro.Controls.Add(this.lbPesquisarApenas);
            this.BoxFiltro.Controls.Add(this.label2);
            this.BoxFiltro.Controls.Add(this.btnPesquisar);
            this.BoxFiltro.Controls.Add(this.cbStatus);
            this.BoxFiltro.Controls.Add(this.cbPesquisarAtivos);
            this.BoxFiltro.Controls.Add(this.lbOrdenar);
            this.BoxFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoxFiltro.Location = new System.Drawing.Point(0, 0);
            this.BoxFiltro.Name = "BoxFiltro";
            this.BoxFiltro.Size = new System.Drawing.Size(828, 62);
            this.BoxFiltro.TabIndex = 39;
            this.BoxFiltro.TabStop = false;
            this.BoxFiltro.Text = "Filtros";
            // 
            // ProdutoColId
            // 
            this.ProdutoColId.DataPropertyName = "idproduto";
            this.ProdutoColId.HeaderText = "Produto";
            this.ProdutoColId.Name = "ProdutoColId";
            this.ProdutoColId.ReadOnly = true;
            this.ProdutoColId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProdutoColId.Width = 60;
            // 
            // ProdutoColDescricao
            // 
            this.ProdutoColDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProdutoColDescricao.DataPropertyName = "produtodescricao";
            this.ProdutoColDescricao.FillWeight = 300F;
            this.ProdutoColDescricao.HeaderText = "Desc. Produto";
            this.ProdutoColDescricao.Name = "ProdutoColDescricao";
            this.ProdutoColDescricao.ReadOnly = true;
            // 
            // ProdutoColQtde
            // 
            this.ProdutoColQtde.DataPropertyName = "qtde";
            this.ProdutoColQtde.HeaderText = "Qtde";
            this.ProdutoColQtde.Name = "ProdutoColQtde";
            this.ProdutoColQtde.ReadOnly = true;
            this.ProdutoColQtde.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProdutoColQtde.Width = 80;
            // 
            // ProdutoColVlrUnitario
            // 
            this.ProdutoColVlrUnitario.DataPropertyName = "vlrunitario";
            this.ProdutoColVlrUnitario.HeaderText = "Vlr Unit.";
            this.ProdutoColVlrUnitario.Name = "ProdutoColVlrUnitario";
            this.ProdutoColVlrUnitario.ReadOnly = true;
            this.ProdutoColVlrUnitario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProdutoColVlrUnitario.Width = 80;
            // 
            // ProdutoColVlrDesconto
            // 
            this.ProdutoColVlrDesconto.DataPropertyName = "vlrdesconto";
            this.ProdutoColVlrDesconto.HeaderText = "Vlr Desc.";
            this.ProdutoColVlrDesconto.Name = "ProdutoColVlrDesconto";
            this.ProdutoColVlrDesconto.ReadOnly = true;
            this.ProdutoColVlrDesconto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProdutoColVlrDesconto.Width = 80;
            // 
            // ProdutoColVlrBruto
            // 
            this.ProdutoColVlrBruto.DataPropertyName = "vlrbruto";
            this.ProdutoColVlrBruto.HeaderText = "Vlr Bruto";
            this.ProdutoColVlrBruto.Name = "ProdutoColVlrBruto";
            this.ProdutoColVlrBruto.ReadOnly = true;
            this.ProdutoColVlrBruto.Width = 80;
            // 
            // PedidoColId
            // 
            this.PedidoColId.DataPropertyName = "idpedido";
            this.PedidoColId.HeaderText = "Pedido";
            this.PedidoColId.Name = "PedidoColId";
            this.PedidoColId.ReadOnly = true;
            this.PedidoColId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PedidoColId.Width = 60;
            // 
            // PedidoColAbertura
            // 
            this.PedidoColAbertura.DataPropertyName = "dataabertura";
            this.PedidoColAbertura.HeaderText = "Data Abertura";
            this.PedidoColAbertura.Name = "PedidoColAbertura";
            this.PedidoColAbertura.ReadOnly = true;
            this.PedidoColAbertura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PedidoColAbertura.Width = 70;
            // 
            // PedidoColFechamento
            // 
            this.PedidoColFechamento.DataPropertyName = "datafechamento";
            this.PedidoColFechamento.HeaderText = "Data Fechamento";
            this.PedidoColFechamento.Name = "PedidoColFechamento";
            this.PedidoColFechamento.ReadOnly = true;
            this.PedidoColFechamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PedidoColFechamento.Width = 70;
            // 
            // PedidoColCliente
            // 
            this.PedidoColCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PedidoColCliente.DataPropertyName = "clientenome";
            this.PedidoColCliente.HeaderText = "Cliente";
            this.PedidoColCliente.Name = "PedidoColCliente";
            this.PedidoColCliente.ReadOnly = true;
            this.PedidoColCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PedidoColPagamento
            // 
            this.PedidoColPagamento.DataPropertyName = "formapagamentodescricao";
            this.PedidoColPagamento.HeaderText = "Form. Pag.";
            this.PedidoColPagamento.Name = "PedidoColPagamento";
            this.PedidoColPagamento.ReadOnly = true;
            this.PedidoColPagamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PedidoColPagamento.Width = 160;
            // 
            // PedidoColStatus
            // 
            this.PedidoColStatus.DataPropertyName = "status";
            this.PedidoColStatus.HeaderText = "Status";
            this.PedidoColStatus.Name = "PedidoColStatus";
            this.PedidoColStatus.ReadOnly = true;
            this.PedidoColStatus.Width = 60;
            // 
            // PedidoColTipoPedido
            // 
            this.PedidoColTipoPedido.DataPropertyName = "idtipopedido";
            this.PedidoColTipoPedido.HeaderText = "Tipo Pedido";
            this.PedidoColTipoPedido.Name = "PedidoColTipoPedido";
            this.PedidoColTipoPedido.ReadOnly = true;
            this.PedidoColTipoPedido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PedidoColTipoPedido.Width = 80;
            // 
            // PedidoColDescontos
            // 
            this.PedidoColDescontos.DataPropertyName = "vlrtotaldescontos";
            this.PedidoColDescontos.HeaderText = "Descontos";
            this.PedidoColDescontos.Name = "PedidoColDescontos";
            this.PedidoColDescontos.ReadOnly = true;
            this.PedidoColDescontos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PedidoColDescontos.Width = 60;
            // 
            // PedidoColVlrBruto
            // 
            this.PedidoColVlrBruto.DataPropertyName = "vlrtotalbruto";
            this.PedidoColVlrBruto.HeaderText = "Valor Bruto";
            this.PedidoColVlrBruto.Name = "PedidoColVlrBruto";
            this.PedidoColVlrBruto.ReadOnly = true;
            this.PedidoColVlrBruto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PedidoColVlrBruto.Width = 60;
            // 
            // PesqAnaliticaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(828, 602);
            this.Name = "PesqAnaliticaPedidos";
            this.Text = "";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlNomeRotina.ResumeLayout(false);
            this.pnlAcoesRodape.ResumeLayout(false);
            this.pnlAcoesMenu.ResumeLayout(false);
            this.pnlAcoesMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPedidos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).EndInit();
            this.BoxFiltro.ResumeLayout(false);
            this.BoxFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridProdutos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridPedidos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbPedidos;
        private System.Windows.Forms.GroupBox BoxFiltro;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbPesquisarApenas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbPesquisarAtivos;
        private System.Windows.Forms.Label lbOrdenar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoColDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoColQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoColVlrUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoColVlrDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoColVlrBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoColAbertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoColFechamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoColPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoColStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoColTipoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoColDescontos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoColVlrBruto;
    }
}
