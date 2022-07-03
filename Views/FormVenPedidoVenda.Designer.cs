namespace LaPizza.Views
{
    partial class FormVenPedidoVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCarrinho = new System.Windows.Forms.Button();
            this.lbPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new LaPizza.Controllers.LpText();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbIdPedido = new System.Windows.Forms.Label();
            this.lbNumeroPedido = new System.Windows.Forms.Label();
            this.btnPesquisaCliente = new System.Windows.Forms.Button();
            this.btnPesquisaFormaPagamento = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStatusPedido = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.cbFicha = new System.Windows.Forms.ComboBox();
            this.cbTipoPedido = new System.Windows.Forms.ComboBox();
            this.txtFormaPagamento = new LaPizza.Controllers.LpText();
            this.txtCliente = new LaPizza.Controllers.LpText();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTotalLiquido = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTotalDescontos = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTotalBruto = new System.Windows.Forms.Label();
            this.GridProdutos = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlPrincipal.SuspendLayout();
            this.pnlNomeRotina.SuspendLayout();
            this.pnlAcoesRodape.SuspendLayout();
            this.pnlAcoesMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTopo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.pnlTotal);
            this.pnlPrincipal.Controls.Add(this.panel4);
            this.pnlPrincipal.Controls.Add(this.panel1);
            this.pnlPrincipal.Controls.Add(this.pnlTopo);
            this.pnlPrincipal.Size = new System.Drawing.Size(784, 442);
            // 
            // pnlNomeRotina
            // 
            this.pnlNomeRotina.Size = new System.Drawing.Size(784, 40);
            // 
            // btnAcaoAdicionar
            // 
            this.btnAcaoAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAcaoAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.Location = new System.Drawing.Point(644, 5);
            this.btnAcaoAdicionar.Visible = false;
            // 
            // btnAcaoEditar
            // 
            this.btnAcaoEditar.FlatAppearance.BorderSize = 0;
            this.btnAcaoEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.Location = new System.Drawing.Point(679, 5);
            this.btnAcaoEditar.Visible = false;
            // 
            // btnAcaoConsultar
            // 
            this.btnAcaoConsultar.FlatAppearance.BorderSize = 0;
            this.btnAcaoConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.Location = new System.Drawing.Point(714, 5);
            // 
            // lbNomeRotina
            // 
            this.lbNomeRotina.Size = new System.Drawing.Size(784, 40);
            this.lbNomeRotina.Text = "Pedido de Venda";
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 521);
            this.pnlAcoesRodape.Size = new System.Drawing.Size(784, 40);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.Location = new System.Drawing.Point(634, 5);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSair.Location = new System.Drawing.Point(709, 5);
            // 
            // btnAcaoExcluir
            // 
            this.btnAcaoExcluir.FlatAppearance.BorderSize = 0;
            this.btnAcaoExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.Location = new System.Drawing.Point(749, 5);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(559, 5);
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(674, 5);
            this.splitter3.Visible = false;
            // 
            // pnlAcoesMenu
            // 
            this.pnlAcoesMenu.Size = new System.Drawing.Size(784, 39);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.panel1.Controls.Add(this.btnCarrinho);
            this.panel1.Controls.Add(this.lbPesquisa);
            this.panel1.Controls.Add(this.txtPesquisa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 93);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 50);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 50);
            this.panel1.TabIndex = 9;
            // 
            // btnCarrinho
            // 
            this.btnCarrinho.BackColor = System.Drawing.Color.Transparent;
            this.btnCarrinho.BackgroundImage = global::LaPizza.Properties.Resources.CarrinhoCompras;
            this.btnCarrinho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCarrinho.FlatAppearance.BorderSize = 0;
            this.btnCarrinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarrinho.Location = new System.Drawing.Point(746, 9);
            this.btnCarrinho.Name = "btnCarrinho";
            this.btnCarrinho.Size = new System.Drawing.Size(30, 30);
            this.btnCarrinho.TabIndex = 4;
            this.btnCarrinho.Tag = "Lista";
            this.btnCarrinho.UseVisualStyleBackColor = false;
            this.btnCarrinho.Click += new System.EventHandler(this.btnCarrinho_Click);
            // 
            // lbPesquisa
            // 
            this.lbPesquisa.AutoSize = true;
            this.lbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesquisa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbPesquisa.Location = new System.Drawing.Point(4, 3);
            this.lbPesquisa.Name = "lbPesquisa";
            this.lbPesquisa.Size = new System.Drawing.Size(58, 13);
            this.lbPesquisa.TabIndex = 3;
            this.lbPesquisa.Text = "Pesquisa";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.ForeColor = System.Drawing.Color.Black;
            this.txtPesquisa.Location = new System.Drawing.Point(7, 19);
            this.txtPesquisa.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtPesquisa.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtPesquisa.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(733, 20);
            this.txtPesquisa.TabIndex = 2;
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlTopo.Controls.Add(this.panel2);
            this.pnlTopo.Controls.Add(this.btnPesquisaCliente);
            this.pnlTopo.Controls.Add(this.btnPesquisaFormaPagamento);
            this.pnlTopo.Controls.Add(this.label4);
            this.pnlTopo.Controls.Add(this.cbStatusPedido);
            this.pnlTopo.Controls.Add(this.label3);
            this.pnlTopo.Controls.Add(this.label2);
            this.pnlTopo.Controls.Add(this.label1);
            this.pnlTopo.Controls.Add(this.lbCliente);
            this.pnlTopo.Controls.Add(this.cbFicha);
            this.pnlTopo.Controls.Add(this.cbTipoPedido);
            this.pnlTopo.Controls.Add(this.txtFormaPagamento);
            this.pnlTopo.Controls.Add(this.txtCliente);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.ForeColor = System.Drawing.Color.Snow;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(784, 93);
            this.pnlTopo.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(629, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 93);
            this.panel2.TabIndex = 48;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lbIdPedido, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbNumeroPedido, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 11);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.85714F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.14286F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(155, 70);
            this.tableLayoutPanel2.TabIndex = 49;
            // 
            // lbIdPedido
            // 
            this.lbIdPedido.AutoSize = true;
            this.lbIdPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbIdPedido.Font = new System.Drawing.Font("October Twilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdPedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbIdPedido.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbIdPedido.Location = new System.Drawing.Point(3, 0);
            this.lbIdPedido.Name = "lbIdPedido";
            this.lbIdPedido.Size = new System.Drawing.Size(149, 22);
            this.lbIdPedido.TabIndex = 3;
            this.lbIdPedido.Text = "Nº Pedido";
            this.lbIdPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNumeroPedido
            // 
            this.lbNumeroPedido.AutoSize = true;
            this.lbNumeroPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNumeroPedido.Font = new System.Drawing.Font("October Twilight", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroPedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNumeroPedido.Location = new System.Drawing.Point(3, 22);
            this.lbNumeroPedido.Name = "lbNumeroPedido";
            this.lbNumeroPedido.Size = new System.Drawing.Size(149, 48);
            this.lbNumeroPedido.TabIndex = 2;
            this.lbNumeroPedido.Text = "0";
            this.lbNumeroPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPesquisaCliente
            // 
            this.btnPesquisaCliente.BackgroundImage = global::LaPizza.Properties.Resources.AcaoConsultarHover;
            this.btnPesquisaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisaCliente.FlatAppearance.BorderSize = 0;
            this.btnPesquisaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisaCliente.Location = new System.Drawing.Point(277, 15);
            this.btnPesquisaCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnPesquisaCliente.Name = "btnPesquisaCliente";
            this.btnPesquisaCliente.Size = new System.Drawing.Size(25, 25);
            this.btnPesquisaCliente.TabIndex = 47;
            this.btnPesquisaCliente.UseVisualStyleBackColor = true;
            this.btnPesquisaCliente.Click += new System.EventHandler(this.btnPesquisaCliente_Click);
            // 
            // btnPesquisaFormaPagamento
            // 
            this.btnPesquisaFormaPagamento.BackgroundImage = global::LaPizza.Properties.Resources.AcaoConsultarHover;
            this.btnPesquisaFormaPagamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisaFormaPagamento.FlatAppearance.BorderSize = 0;
            this.btnPesquisaFormaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisaFormaPagamento.Location = new System.Drawing.Point(578, 15);
            this.btnPesquisaFormaPagamento.Margin = new System.Windows.Forms.Padding(0);
            this.btnPesquisaFormaPagamento.Name = "btnPesquisaFormaPagamento";
            this.btnPesquisaFormaPagamento.Size = new System.Drawing.Size(25, 25);
            this.btnPesquisaFormaPagamento.TabIndex = 46;
            this.btnPesquisaFormaPagamento.UseVisualStyleBackColor = true;
            this.btnPesquisaFormaPagamento.Click += new System.EventHandler(this.btnPesquisaFormaPagamento_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(305, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Status Pedido";
            // 
            // cbStatusPedido
            // 
            this.cbStatusPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusPedido.FormattingEnabled = true;
            this.cbStatusPedido.Location = new System.Drawing.Point(308, 60);
            this.cbStatusPedido.Name = "cbStatusPedido";
            this.cbStatusPedido.Size = new System.Drawing.Size(220, 21);
            this.cbStatusPedido.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(531, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Ficha/Mesa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(4, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tipo Pedido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(305, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Forma Pagamento:";
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCliente.Location = new System.Drawing.Point(4, 4);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(42, 13);
            this.lbCliente.TabIndex = 37;
            this.lbCliente.Text = "Cliente:";
            // 
            // cbFicha
            // 
            this.cbFicha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFicha.FormattingEnabled = true;
            this.cbFicha.Location = new System.Drawing.Point(534, 60);
            this.cbFicha.Name = "cbFicha";
            this.cbFicha.Size = new System.Drawing.Size(71, 21);
            this.cbFicha.TabIndex = 36;
            // 
            // cbTipoPedido
            // 
            this.cbTipoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPedido.FormattingEnabled = true;
            this.cbTipoPedido.Location = new System.Drawing.Point(7, 60);
            this.cbTipoPedido.Name = "cbTipoPedido";
            this.cbTipoPedido.Size = new System.Drawing.Size(295, 21);
            this.cbTipoPedido.TabIndex = 4;
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFormaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFormaPagamento.ForeColor = System.Drawing.Color.Black;
            this.txtFormaPagamento.Location = new System.Drawing.Point(308, 20);
            this.txtFormaPagamento.LpCorFoco = System.Drawing.Color.White;
            this.txtFormaPagamento.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtFormaPagamento.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.ReadOnly = true;
            this.txtFormaPagamento.Size = new System.Drawing.Size(295, 20);
            this.txtFormaPagamento.TabIndex = 35;
            // 
            // txtCliente
            // 
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.ForeColor = System.Drawing.Color.Black;
            this.txtCliente.Location = new System.Drawing.Point(7, 20);
            this.txtCliente.LpCorFoco = System.Drawing.Color.White;
            this.txtCliente.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtCliente.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(295, 20);
            this.txtCliente.TabIndex = 33;
            // 
            // pnlTotal
            // 
            this.pnlTotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTotal.Controls.Add(this.tableLayoutPanel1);
            this.pnlTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotal.Location = new System.Drawing.Point(0, 375);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(784, 67);
            this.pnlTotal.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.23383F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.76617F));
            this.tableLayoutPanel1.Controls.Add(this.lbTotalLiquido, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbTotalDescontos, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbTotalBruto, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(559, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(225, 67);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // lbTotalLiquido
            // 
            this.lbTotalLiquido.AutoSize = true;
            this.lbTotalLiquido.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTotalLiquido.Font = new System.Drawing.Font("October Twilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalLiquido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTotalLiquido.Location = new System.Drawing.Point(187, 43);
            this.lbTotalLiquido.Name = "lbTotalLiquido";
            this.lbTotalLiquido.Size = new System.Drawing.Size(35, 20);
            this.lbTotalLiquido.TabIndex = 8;
            this.lbTotalLiquido.Text = "0,00";
            this.lbTotalLiquido.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("October Twilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Total Bruto:";
            // 
            // lbTotalDescontos
            // 
            this.lbTotalDescontos.AutoSize = true;
            this.lbTotalDescontos.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTotalDescontos.Font = new System.Drawing.Font("October Twilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalDescontos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTotalDescontos.Location = new System.Drawing.Point(187, 23);
            this.lbTotalDescontos.Name = "lbTotalDescontos";
            this.lbTotalDescontos.Size = new System.Drawing.Size(35, 20);
            this.lbTotalDescontos.TabIndex = 15;
            this.lbTotalDescontos.Text = "0,00";
            this.lbTotalDescontos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("October Twilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(3, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Descontos:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("October Twilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(3, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Total Liquido:";
            // 
            // lbTotalBruto
            // 
            this.lbTotalBruto.AutoSize = true;
            this.lbTotalBruto.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTotalBruto.Font = new System.Drawing.Font("October Twilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalBruto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTotalBruto.Location = new System.Drawing.Point(187, 3);
            this.lbTotalBruto.Name = "lbTotalBruto";
            this.lbTotalBruto.Size = new System.Drawing.Size(35, 20);
            this.lbTotalBruto.TabIndex = 14;
            this.lbTotalBruto.Text = "0,00";
            this.lbTotalBruto.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // GridProdutos
            // 
            this.GridProdutos.AllowUserToDeleteRows = false;
            this.GridProdutos.AllowUserToOrderColumns = true;
            this.GridProdutos.AllowUserToResizeColumns = false;
            this.GridProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.GridProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridProdutos.BackgroundColor = System.Drawing.Color.White;
            this.GridProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridProdutos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridProdutos.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridProdutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GridProdutos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GridProdutos.Location = new System.Drawing.Point(0, 0);
            this.GridProdutos.MultiSelect = false;
            this.GridProdutos.Name = "GridProdutos";
            this.GridProdutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridProdutos.RowHeadersWidth = 23;
            this.GridProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridProdutos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.GridProdutos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProdutos.Size = new System.Drawing.Size(784, 235);
            this.GridProdutos.TabIndex = 1;
            this.GridProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProdutos_CellDoubleClick);
            this.GridProdutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GridProdutos_KeyPress);
            // 
            // check
            // 
            this.check.HeaderText = "";
            this.check.Image = global::LaPizza.Properties.Resources.vazio;
            this.check.Name = "check";
            this.check.Width = 20;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.GridProdutos);
            this.panel4.Location = new System.Drawing.Point(0, 140);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(784, 235);
            this.panel4.TabIndex = 10;
            // 
            // FormVenPedidoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.MaximumSize = new System.Drawing.Size(870, 600);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "FormVenPedidoVenda";
            this.Text = "Pedido de Venda";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlNomeRotina.ResumeLayout(false);
            this.pnlAcoesRodape.ResumeLayout(false);
            this.pnlAcoesMenu.ResumeLayout(false);
            this.pnlAcoesMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbPesquisa;
        private Controllers.LpText txtPesquisa;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.ComboBox cbFicha;
        private System.Windows.Forms.ComboBox cbTipoPedido;
        private Controllers.LpText txtFormaPagamento;
        private Controllers.LpText txtCliente;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStatusPedido;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnPesquisaCliente;
        private System.Windows.Forms.Button btnPesquisaFormaPagamento;
        private System.Windows.Forms.Label lbTotalLiquido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbIdPedido;
        private System.Windows.Forms.Label lbNumeroPedido;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTotalDescontos;
        private System.Windows.Forms.Label lbTotalBruto;
        private System.Windows.Forms.DataGridViewImageColumn check;
        public System.Windows.Forms.DataGridView GridProdutos;
        private System.Windows.Forms.Button btnCarrinho;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
