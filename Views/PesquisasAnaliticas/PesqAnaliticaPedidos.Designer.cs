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
            this.GridPedidos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GridProdutos = new System.Windows.Forms.DataGridView();
            this.lbPedidos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.ColPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDataAbertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDataFechamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVlrBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVlrUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVlrDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoColVlrBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pnlPrincipal.Size = new System.Drawing.Size(775, 483);
            // 
            // pnlNomeRotina
            // 
            this.pnlNomeRotina.Size = new System.Drawing.Size(775, 40);
            // 
            // btnAcaoAdicionar
            // 
            this.btnAcaoAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAcaoAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.Location = new System.Drawing.Point(635, 5);
            // 
            // btnAcaoEditar
            // 
            this.btnAcaoEditar.FlatAppearance.BorderSize = 0;
            this.btnAcaoEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.Location = new System.Drawing.Point(670, 5);
            // 
            // btnAcaoConsultar
            // 
            this.btnAcaoConsultar.FlatAppearance.BorderSize = 0;
            this.btnAcaoConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.Location = new System.Drawing.Point(705, 5);
            // 
            // lbNomeRotina
            // 
            this.lbNomeRotina.Size = new System.Drawing.Size(775, 40);
            this.lbNomeRotina.Text = "Form1";
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 562);
            this.pnlAcoesRodape.Size = new System.Drawing.Size(775, 40);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.Location = new System.Drawing.Point(625, 5);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSair.Location = new System.Drawing.Point(700, 5);
            // 
            // btnAcaoExcluir
            // 
            this.btnAcaoExcluir.FlatAppearance.BorderSize = 0;
            this.btnAcaoExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.Location = new System.Drawing.Point(740, 5);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(550, 5);
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(665, 5);
            // 
            // pnlAcoesMenu
            // 
            this.pnlAcoesMenu.Size = new System.Drawing.Size(775, 39);
            this.pnlAcoesMenu.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.lbPedidos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 20);
            this.panel1.TabIndex = 42;
            // 
            // GridPedidos
            // 
            this.GridPedidos.AllowUserToDeleteRows = false;
            this.GridPedidos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPedido,
            this.ColDataAbertura,
            this.ColDataFechamento,
            this.ColCliente,
            this.ColDesconto,
            this.ColVlrBruto,
            this.ColStatus,
            this.ColFormaPagamento,
            this.ColTipoPedido});
            this.GridPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridPedidos.Enabled = false;
            this.GridPedidos.Location = new System.Drawing.Point(0, 82);
            this.GridPedidos.MultiSelect = false;
            this.GridPedidos.Name = "GridPedidos";
            this.GridPedidos.ReadOnly = true;
            this.GridPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPedidos.Size = new System.Drawing.Size(775, 162);
            this.GridPedidos.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 20);
            this.panel2.TabIndex = 44;
            // 
            // GridProdutos
            // 
            this.GridProdutos.AllowUserToDeleteRows = false;
            this.GridProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.ColQtde,
            this.ColVlrUnitario,
            this.ColVlrDesconto,
            this.ProdutoColVlrBruto});
            this.GridProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridProdutos.Enabled = false;
            this.GridProdutos.Location = new System.Drawing.Point(0, 264);
            this.GridProdutos.MultiSelect = false;
            this.GridProdutos.Name = "GridProdutos";
            this.GridProdutos.ReadOnly = true;
            this.GridProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProdutos.Size = new System.Drawing.Size(775, 219);
            this.GridProdutos.TabIndex = 45;
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
            this.BoxFiltro.Size = new System.Drawing.Size(775, 62);
            this.BoxFiltro.TabIndex = 39;
            this.BoxFiltro.TabStop = false;
            this.BoxFiltro.Text = "Filtros";
            // 
            // ColPedido
            // 
            this.ColPedido.DataPropertyName = "idpedido";
            this.ColPedido.HeaderText = "Pedido";
            this.ColPedido.Name = "ColPedido";
            this.ColPedido.ReadOnly = true;
            this.ColPedido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColPedido.Width = 60;
            // 
            // ColDataAbertura
            // 
            this.ColDataAbertura.DataPropertyName = "dataabertura";
            this.ColDataAbertura.HeaderText = "Data Abertura";
            this.ColDataAbertura.Name = "ColDataAbertura";
            this.ColDataAbertura.ReadOnly = true;
            this.ColDataAbertura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColDataAbertura.Width = 70;
            // 
            // ColDataFechamento
            // 
            this.ColDataFechamento.DataPropertyName = "datafechamento";
            this.ColDataFechamento.HeaderText = "Data Fechamento";
            this.ColDataFechamento.Name = "ColDataFechamento";
            this.ColDataFechamento.ReadOnly = true;
            this.ColDataFechamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColDataFechamento.Width = 70;
            // 
            // ColCliente
            // 
            this.ColCliente.DataPropertyName = "idcliente";
            this.ColCliente.HeaderText = "Cliente";
            this.ColCliente.Name = "ColCliente";
            this.ColCliente.ReadOnly = true;
            this.ColCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColCliente.Width = 170;
            // 
            // ColDesconto
            // 
            this.ColDesconto.DataPropertyName = "vlrtotaldescontos";
            this.ColDesconto.HeaderText = "Descontos";
            this.ColDesconto.Name = "ColDesconto";
            this.ColDesconto.ReadOnly = true;
            this.ColDesconto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColDesconto.Width = 60;
            // 
            // ColVlrBruto
            // 
            this.ColVlrBruto.DataPropertyName = "vlrtotalbruto";
            this.ColVlrBruto.HeaderText = "Valor Bruto";
            this.ColVlrBruto.Name = "ColVlrBruto";
            this.ColVlrBruto.ReadOnly = true;
            this.ColVlrBruto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColVlrBruto.Width = 60;
            // 
            // ColStatus
            // 
            this.ColStatus.DataPropertyName = "status";
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            this.ColStatus.Width = 60;
            // 
            // ColFormaPagamento
            // 
            this.ColFormaPagamento.DataPropertyName = "idformapagamento";
            this.ColFormaPagamento.HeaderText = "Forma Pagamento";
            this.ColFormaPagamento.Name = "ColFormaPagamento";
            this.ColFormaPagamento.ReadOnly = true;
            this.ColFormaPagamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColTipoPedido
            // 
            this.ColTipoPedido.DataPropertyName = "idtipopedido";
            this.ColTipoPedido.HeaderText = "Tipo Pedido";
            this.ColTipoPedido.Name = "ColTipoPedido";
            this.ColTipoPedido.ReadOnly = true;
            this.ColTipoPedido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColTipoPedido.Width = 80;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idproduto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn2.FillWeight = 300F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Desc. Produto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 430;
            // 
            // ColQtde
            // 
            this.ColQtde.DataPropertyName = "qtde";
            this.ColQtde.HeaderText = "Qtde";
            this.ColQtde.Name = "ColQtde";
            this.ColQtde.ReadOnly = true;
            this.ColQtde.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColQtde.Width = 80;
            // 
            // ColVlrUnitario
            // 
            this.ColVlrUnitario.DataPropertyName = "vlrunitario";
            this.ColVlrUnitario.HeaderText = "Vlr Unit.";
            this.ColVlrUnitario.Name = "ColVlrUnitario";
            this.ColVlrUnitario.ReadOnly = true;
            this.ColVlrUnitario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColVlrUnitario.Width = 80;
            // 
            // ColVlrDesconto
            // 
            this.ColVlrDesconto.DataPropertyName = "vlrdesconto";
            this.ColVlrDesconto.HeaderText = "Vlr Desc.";
            this.ColVlrDesconto.Name = "ColVlrDesconto";
            this.ColVlrDesconto.ReadOnly = true;
            this.ColVlrDesconto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColVlrDesconto.Visible = false;
            this.ColVlrDesconto.Width = 80;
            // 
            // ProdutoColVlrBruto
            // 
            this.ProdutoColVlrBruto.DataPropertyName = "vlrbruto";
            this.ProdutoColVlrBruto.HeaderText = "Vlr Bruto";
            this.ProdutoColVlrBruto.Name = "ProdutoColVlrBruto";
            this.ProdutoColVlrBruto.ReadOnly = true;
            this.ProdutoColVlrBruto.Width = 80;
            // 
            // PesqAnaliticaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(775, 602);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVlrUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVlrDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoColVlrBruto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDataAbertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDataFechamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVlrBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipoPedido;
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
    }
}
