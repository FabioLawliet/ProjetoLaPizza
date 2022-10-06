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
            this.idpedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataabertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datafechamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formapagamentodescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipopedidodescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlrtotaldescontos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlrtotalbruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.GridProdutos = new System.Windows.Forms.DataGridView();
            this.idproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtodescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlrunitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlrdesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlrbruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lbOrdenar = new System.Windows.Forms.Label();
            this.lbPesquisarApenas = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.BoxFiltro = new System.Windows.Forms.GroupBox();
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
            this.pnlPrincipal.Size = new System.Drawing.Size(878, 483);
            // 
            // pnlNomeRotina
            // 
            this.pnlNomeRotina.Size = new System.Drawing.Size(878, 40);
            // 
            // btnAcaoAdicionar
            // 
            this.btnAcaoAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAcaoAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.Location = new System.Drawing.Point(738, 5);
            // 
            // btnAcaoEditar
            // 
            this.btnAcaoEditar.FlatAppearance.BorderSize = 0;
            this.btnAcaoEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.Location = new System.Drawing.Point(773, 5);
            // 
            // btnAcaoConsultar
            // 
            this.btnAcaoConsultar.FlatAppearance.BorderSize = 0;
            this.btnAcaoConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.Location = new System.Drawing.Point(808, 5);
            // 
            // lbNomeRotina
            // 
            this.lbNomeRotina.Size = new System.Drawing.Size(878, 40);
            this.lbNomeRotina.Text = "Form1";
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 562);
            this.pnlAcoesRodape.Size = new System.Drawing.Size(878, 40);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.Location = new System.Drawing.Point(728, 5);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSair.Location = new System.Drawing.Point(803, 5);
            // 
            // btnAcaoExcluir
            // 
            this.btnAcaoExcluir.FlatAppearance.BorderSize = 0;
            this.btnAcaoExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.Location = new System.Drawing.Point(843, 5);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(653, 5);
            this.btnConfirmar.Visible = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(768, 5);
            // 
            // pnlAcoesMenu
            // 
            this.pnlAcoesMenu.Size = new System.Drawing.Size(878, 39);
            this.pnlAcoesMenu.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.lbPedidos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 20);
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
            this.idpedido,
            this.dataabertura,
            this.datafechamento,
            this.clientenome,
            this.formapagamentodescricao,
            this.status,
            this.tipopedidodescricao,
            this.vlrtotaldescontos,
            this.vlrtotalbruto});
            this.GridPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridPedidos.Location = new System.Drawing.Point(0, 82);
            this.GridPedidos.MultiSelect = false;
            this.GridPedidos.Name = "GridPedidos";
            this.GridPedidos.ReadOnly = true;
            this.GridPedidos.RowHeadersVisible = false;
            this.GridPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPedidos.Size = new System.Drawing.Size(878, 162);
            this.GridPedidos.TabIndex = 43;
            this.GridPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPedidos_CellClick);
            // 
            // idpedido
            // 
            this.idpedido.DataPropertyName = "idpedido";
            this.idpedido.HeaderText = "Pedido";
            this.idpedido.Name = "idpedido";
            this.idpedido.ReadOnly = true;
            this.idpedido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idpedido.Visible = false;
            this.idpedido.Width = 60;
            // 
            // dataabertura
            // 
            this.dataabertura.DataPropertyName = "dataabertura";
            this.dataabertura.HeaderText = "Data Abertura";
            this.dataabertura.Name = "dataabertura";
            this.dataabertura.ReadOnly = true;
            this.dataabertura.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataabertura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataabertura.Visible = false;
            this.dataabertura.Width = 70;
            // 
            // datafechamento
            // 
            this.datafechamento.DataPropertyName = "datafechamento";
            this.datafechamento.HeaderText = "Data Fechamento";
            this.datafechamento.Name = "datafechamento";
            this.datafechamento.ReadOnly = true;
            this.datafechamento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.datafechamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.datafechamento.Visible = false;
            this.datafechamento.Width = 70;
            // 
            // clientenome
            // 
            this.clientenome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clientenome.DataPropertyName = "clientenome";
            this.clientenome.HeaderText = "Cliente";
            this.clientenome.Name = "clientenome";
            this.clientenome.ReadOnly = true;
            this.clientenome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clientenome.Visible = false;
            // 
            // formapagamentodescricao
            // 
            this.formapagamentodescricao.DataPropertyName = "formapagamentodescricao";
            this.formapagamentodescricao.HeaderText = "Form. Pag.";
            this.formapagamentodescricao.Name = "formapagamentodescricao";
            this.formapagamentodescricao.ReadOnly = true;
            this.formapagamentodescricao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.formapagamentodescricao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.formapagamentodescricao.Visible = false;
            this.formapagamentodescricao.Width = 140;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.Visible = false;
            this.status.Width = 60;
            // 
            // tipopedidodescricao
            // 
            this.tipopedidodescricao.DataPropertyName = "tipopedidodescricao";
            this.tipopedidodescricao.HeaderText = "Tipo Pedido";
            this.tipopedidodescricao.Name = "tipopedidodescricao";
            this.tipopedidodescricao.ReadOnly = true;
            this.tipopedidodescricao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tipopedidodescricao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tipopedidodescricao.Visible = false;
            // 
            // vlrtotaldescontos
            // 
            this.vlrtotaldescontos.DataPropertyName = "vlrtotaldescontos";
            this.vlrtotaldescontos.HeaderText = "Descontos";
            this.vlrtotaldescontos.Name = "vlrtotaldescontos";
            this.vlrtotaldescontos.ReadOnly = true;
            this.vlrtotaldescontos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vlrtotaldescontos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.vlrtotaldescontos.Visible = false;
            this.vlrtotaldescontos.Width = 60;
            // 
            // vlrtotalbruto
            // 
            this.vlrtotalbruto.DataPropertyName = "vlrtotalbruto";
            this.vlrtotalbruto.HeaderText = "Valor Bruto";
            this.vlrtotalbruto.Name = "vlrtotalbruto";
            this.vlrtotalbruto.ReadOnly = true;
            this.vlrtotalbruto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vlrtotalbruto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.vlrtotalbruto.Visible = false;
            this.vlrtotalbruto.Width = 60;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 20);
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
            this.idproduto,
            this.produtodescricao,
            this.qtde,
            this.vlrunitario,
            this.vlrdesconto,
            this.vlrbruto});
            this.GridProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridProdutos.Location = new System.Drawing.Point(0, 264);
            this.GridProdutos.MultiSelect = false;
            this.GridProdutos.Name = "GridProdutos";
            this.GridProdutos.ReadOnly = true;
            this.GridProdutos.RowHeadersVisible = false;
            this.GridProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProdutos.Size = new System.Drawing.Size(878, 219);
            this.GridProdutos.TabIndex = 45;
            // 
            // idproduto
            // 
            this.idproduto.DataPropertyName = "idproduto";
            this.idproduto.HeaderText = "Produto";
            this.idproduto.Name = "idproduto";
            this.idproduto.ReadOnly = true;
            this.idproduto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idproduto.Visible = false;
            this.idproduto.Width = 60;
            // 
            // produtodescricao
            // 
            this.produtodescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.produtodescricao.DataPropertyName = "produtodescricao";
            this.produtodescricao.FillWeight = 300F;
            this.produtodescricao.HeaderText = "Desc. Produto";
            this.produtodescricao.Name = "produtodescricao";
            this.produtodescricao.ReadOnly = true;
            this.produtodescricao.Visible = false;
            // 
            // qtde
            // 
            this.qtde.DataPropertyName = "qtde";
            this.qtde.HeaderText = "Qtde";
            this.qtde.Name = "qtde";
            this.qtde.ReadOnly = true;
            this.qtde.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.qtde.Visible = false;
            this.qtde.Width = 80;
            // 
            // vlrunitario
            // 
            this.vlrunitario.DataPropertyName = "vlrunitario";
            this.vlrunitario.HeaderText = "Vlr Unit.";
            this.vlrunitario.Name = "vlrunitario";
            this.vlrunitario.ReadOnly = true;
            this.vlrunitario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.vlrunitario.Visible = false;
            this.vlrunitario.Width = 80;
            // 
            // vlrdesconto
            // 
            this.vlrdesconto.DataPropertyName = "vlrdesconto";
            this.vlrdesconto.HeaderText = "Vlr Desc.";
            this.vlrdesconto.Name = "vlrdesconto";
            this.vlrdesconto.ReadOnly = true;
            this.vlrdesconto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.vlrdesconto.Visible = false;
            this.vlrdesconto.Width = 80;
            // 
            // vlrbruto
            // 
            this.vlrbruto.DataPropertyName = "vlrbruto";
            this.vlrbruto.HeaderText = "Vlr Bruto";
            this.vlrbruto.Name = "vlrbruto";
            this.vlrbruto.ReadOnly = true;
            this.vlrbruto.Visible = false;
            this.vlrbruto.Width = 80;
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.Location = new System.Drawing.Point(433, 30);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(219, 21);
            this.cbFormaPagamento.TabIndex = 8;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(209, 30);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(218, 21);
            this.cbStatus.TabIndex = 7;
            // 
            // lbOrdenar
            // 
            this.lbOrdenar.AutoSize = true;
            this.lbOrdenar.Location = new System.Drawing.Point(206, 14);
            this.lbOrdenar.Name = "lbOrdenar";
            this.lbOrdenar.Size = new System.Drawing.Size(40, 13);
            this.lbOrdenar.TabIndex = 39;
            this.lbOrdenar.Text = "Status:";
            // 
            // lbPesquisarApenas
            // 
            this.lbPesquisarApenas.AutoSize = true;
            this.lbPesquisarApenas.Location = new System.Drawing.Point(430, 14);
            this.lbPesquisarApenas.Name = "lbPesquisarApenas";
            this.lbPesquisarApenas.Size = new System.Drawing.Size(110, 13);
            this.lbPesquisarApenas.TabIndex = 40;
            this.lbPesquisarApenas.Text = "Forma de pagamento:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.IndianRed;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPesquisar.Location = new System.Drawing.Point(658, 31);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(214, 20);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Data inicial:";
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(9, 31);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(94, 20);
            this.dtInicial.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Data final:";
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(109, 31);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(94, 20);
            this.dtFinal.TabIndex = 50;
            // 
            // BoxFiltro
            // 
            this.BoxFiltro.Controls.Add(this.dtFinal);
            this.BoxFiltro.Controls.Add(this.label3);
            this.BoxFiltro.Controls.Add(this.dtInicial);
            this.BoxFiltro.Controls.Add(this.lbPesquisarApenas);
            this.BoxFiltro.Controls.Add(this.label2);
            this.BoxFiltro.Controls.Add(this.btnPesquisar);
            this.BoxFiltro.Controls.Add(this.cbStatus);
            this.BoxFiltro.Controls.Add(this.cbFormaPagamento);
            this.BoxFiltro.Controls.Add(this.lbOrdenar);
            this.BoxFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoxFiltro.Location = new System.Drawing.Point(0, 0);
            this.BoxFiltro.Name = "BoxFiltro";
            this.BoxFiltro.Size = new System.Drawing.Size(878, 62);
            this.BoxFiltro.TabIndex = 39;
            this.BoxFiltro.TabStop = false;
            this.BoxFiltro.Text = "Filtros";
            // 
            // PesqAnaliticaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(878, 602);
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
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.Label lbPesquisarApenas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.Label lbOrdenar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtodescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlrunitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlrdesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlrbruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataabertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafechamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn formapagamentodescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipopedidodescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlrtotaldescontos;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlrtotalbruto;
    }
}
