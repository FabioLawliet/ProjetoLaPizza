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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPesquisa = new System.Windows.Forms.Label();
            this.lpText1 = new LaPizza.Controllers.LpText();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStatusPedido = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.cbFicha = new System.Windows.Forms.ComboBox();
            this.cbTipoPedido = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFormaPagamento = new LaPizza.Controllers.LpText();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCliente = new LaPizza.Controllers.LpText();
            this.lbDataPedido = new System.Windows.Forms.Label();
            this.lbIdPedido = new System.Windows.Forms.Label();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTotalBruto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.GridProdutos = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlPrincipal.SuspendLayout();
            this.pnlNomeRotina.SuspendLayout();
            this.pnlAcoesRodape.SuspendLayout();
            this.pnlAcoesMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTopo.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.pnlTotal);
            this.pnlPrincipal.Controls.Add(this.panel4);
            this.pnlPrincipal.Controls.Add(this.panel1);
            this.pnlPrincipal.Controls.Add(this.pnlTopo);
            this.pnlPrincipal.Size = new System.Drawing.Size(854, 442);
            // 
            // pnlNomeRotina
            // 
            this.pnlNomeRotina.Size = new System.Drawing.Size(854, 40);
            // 
            // btnAcaoAdicionar
            // 
            this.btnAcaoAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAcaoAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.Location = new System.Drawing.Point(714, 5);
            this.btnAcaoAdicionar.Visible = false;
            // 
            // btnAcaoEditar
            // 
            this.btnAcaoEditar.FlatAppearance.BorderSize = 0;
            this.btnAcaoEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.Location = new System.Drawing.Point(749, 5);
            this.btnAcaoEditar.Visible = false;
            // 
            // btnAcaoConsultar
            // 
            this.btnAcaoConsultar.FlatAppearance.BorderSize = 0;
            this.btnAcaoConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.Location = new System.Drawing.Point(784, 5);
            // 
            // lbNomeRotina
            // 
            this.lbNomeRotina.Size = new System.Drawing.Size(854, 40);
            this.lbNomeRotina.Text = "Pedido de Venda";
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 521);
            this.pnlAcoesRodape.Size = new System.Drawing.Size(854, 40);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.Location = new System.Drawing.Point(704, 5);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSair.Location = new System.Drawing.Point(779, 5);
            // 
            // btnAcaoExcluir
            // 
            this.btnAcaoExcluir.FlatAppearance.BorderSize = 0;
            this.btnAcaoExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.Location = new System.Drawing.Point(819, 5);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(629, 5);
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(744, 5);
            this.splitter3.Visible = false;
            // 
            // pnlAcoesMenu
            // 
            this.pnlAcoesMenu.Size = new System.Drawing.Size(854, 39);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lbPesquisa);
            this.panel1.Controls.Add(this.lpText1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 50);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 50);
            this.panel1.TabIndex = 9;
            // 
            // lbPesquisa
            // 
            this.lbPesquisa.AutoSize = true;
            this.lbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesquisa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbPesquisa.Location = new System.Drawing.Point(4, 6);
            this.lbPesquisa.Name = "lbPesquisa";
            this.lbPesquisa.Size = new System.Drawing.Size(58, 13);
            this.lbPesquisa.TabIndex = 3;
            this.lbPesquisa.Text = "Pesquisa";
            // 
            // lpText1
            // 
            this.lpText1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lpText1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lpText1.ForeColor = System.Drawing.Color.Black;
            this.lpText1.Location = new System.Drawing.Point(5, 22);
            this.lpText1.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lpText1.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.lpText1.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.lpText1.Name = "lpText1";
            this.lpText1.Size = new System.Drawing.Size(843, 20);
            this.lpText1.TabIndex = 2;
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlTopo.Controls.Add(this.label11);
            this.pnlTopo.Controls.Add(this.label10);
            this.pnlTopo.Controls.Add(this.label4);
            this.pnlTopo.Controls.Add(this.cbStatusPedido);
            this.pnlTopo.Controls.Add(this.label3);
            this.pnlTopo.Controls.Add(this.label2);
            this.pnlTopo.Controls.Add(this.label1);
            this.pnlTopo.Controls.Add(this.lbCliente);
            this.pnlTopo.Controls.Add(this.cbFicha);
            this.pnlTopo.Controls.Add(this.cbTipoPedido);
            this.pnlTopo.Controls.Add(this.panel3);
            this.pnlTopo.Controls.Add(this.txtFormaPagamento);
            this.pnlTopo.Controls.Add(this.panel2);
            this.pnlTopo.Controls.Add(this.txtCliente);
            this.pnlTopo.Controls.Add(this.lbDataPedido);
            this.pnlTopo.Controls.Add(this.lbIdPedido);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.ForeColor = System.Drawing.Color.Snow;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(854, 90);
            this.pnlTopo.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("October Twilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(806, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 16);
            this.label11.TabIndex = 44;
            this.label11.Text = "Data:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("October Twilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(771, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 43;
            this.label10.Text = "N. Pedido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(433, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Status Pedido";
            // 
            // cbStatusPedido
            // 
            this.cbStatusPedido.FormattingEnabled = true;
            this.cbStatusPedido.Location = new System.Drawing.Point(436, 60);
            this.cbStatusPedido.Name = "cbStatusPedido";
            this.cbStatusPedido.Size = new System.Drawing.Size(145, 21);
            this.cbStatusPedido.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(294, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Ficha/Mesa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(294, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tipo Pedido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(4, 46);
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
            this.cbFicha.FormattingEnabled = true;
            this.cbFicha.Location = new System.Drawing.Point(297, 60);
            this.cbFicha.Name = "cbFicha";
            this.cbFicha.Size = new System.Drawing.Size(130, 21);
            this.cbFicha.TabIndex = 36;
            // 
            // cbTipoPedido
            // 
            this.cbTipoPedido.FormattingEnabled = true;
            this.cbTipoPedido.Location = new System.Drawing.Point(297, 20);
            this.cbTipoPedido.Name = "cbTipoPedido";
            this.cbTipoPedido.Size = new System.Drawing.Size(284, 21);
            this.cbTipoPedido.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::LaPizza.Properties.Resources.AcaoConsultarHover;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(271, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 20);
            this.panel3.TabIndex = 34;
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFormaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFormaPagamento.ForeColor = System.Drawing.Color.Black;
            this.txtFormaPagamento.Location = new System.Drawing.Point(7, 60);
            this.txtFormaPagamento.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtFormaPagamento.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtFormaPagamento.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.ReadOnly = true;
            this.txtFormaPagamento.Size = new System.Drawing.Size(284, 20);
            this.txtFormaPagamento.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::LaPizza.Properties.Resources.AcaoConsultarHover;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(271, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 20);
            this.panel2.TabIndex = 32;
            // 
            // txtCliente
            // 
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.ForeColor = System.Drawing.Color.Black;
            this.txtCliente.Location = new System.Drawing.Point(7, 20);
            this.txtCliente.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtCliente.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtCliente.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(284, 20);
            this.txtCliente.TabIndex = 33;
            // 
            // lbDataPedido
            // 
            this.lbDataPedido.AutoSize = true;
            this.lbDataPedido.Font = new System.Drawing.Font("October Twilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataPedido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDataPedido.Location = new System.Drawing.Point(723, 39);
            this.lbDataPedido.Name = "lbDataPedido";
            this.lbDataPedido.Size = new System.Drawing.Size(42, 16);
            this.lbDataPedido.TabIndex = 24;
            this.lbDataPedido.Text = "Data:";
            // 
            // lbIdPedido
            // 
            this.lbIdPedido.AutoSize = true;
            this.lbIdPedido.Font = new System.Drawing.Font("October Twilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdPedido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbIdPedido.Location = new System.Drawing.Point(687, 18);
            this.lbIdPedido.Name = "lbIdPedido";
            this.lbIdPedido.Size = new System.Drawing.Size(78, 16);
            this.lbIdPedido.TabIndex = 1;
            this.lbIdPedido.Text = "N. Pedido:";
            // 
            // pnlTotal
            // 
            this.pnlTotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTotal.Controls.Add(this.label9);
            this.pnlTotal.Controls.Add(this.label8);
            this.pnlTotal.Controls.Add(this.label7);
            this.pnlTotal.Controls.Add(this.label6);
            this.pnlTotal.Controls.Add(this.lbTotalBruto);
            this.pnlTotal.Controls.Add(this.label5);
            this.pnlTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotal.Location = new System.Drawing.Point(0, 375);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(854, 67);
            this.pnlTotal.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("October Twilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(743, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "TotalLiquido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("October Twilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(768, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Desconto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("October Twilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(613, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Total Liquido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("October Twilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(635, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Descontos:";
            // 
            // lbTotalBruto
            // 
            this.lbTotalBruto.AutoSize = true;
            this.lbTotalBruto.Font = new System.Drawing.Font("October Twilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalBruto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTotalBruto.Location = new System.Drawing.Point(766, 7);
            this.lbTotalBruto.Name = "lbTotalBruto";
            this.lbTotalBruto.Size = new System.Drawing.Size(68, 16);
            this.lbTotalBruto.TabIndex = 3;
            this.lbTotalBruto.Text = "TotaBruto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("October Twilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(634, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Bruto:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.GridProdutos);
            this.panel4.Location = new System.Drawing.Point(0, 140);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(854, 235);
            this.panel4.TabIndex = 10;
            // 
            // GridProdutos
            // 
            this.GridProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check});
            this.GridProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridProdutos.Location = new System.Drawing.Point(0, 0);
            this.GridProdutos.MultiSelect = false;
            this.GridProdutos.Name = "GridProdutos";
            this.GridProdutos.Size = new System.Drawing.Size(854, 235);
            this.GridProdutos.TabIndex = 13;
            // 
            // check
            // 
            this.check.HeaderText = "";
            this.check.Image = global::LaPizza.Properties.Resources.vazio;
            this.check.Name = "check";
            this.check.Width = 20;
            // 
            // FormVenPedidoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(854, 561);
            this.MaximumSize = new System.Drawing.Size(870, 600);
            this.MinimumSize = new System.Drawing.Size(870, 600);
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
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbPesquisa;
        private Controllers.LpText lpText1;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lbIdPedido;
        private System.Windows.Forms.Label lbDataPedido;
        private System.Windows.Forms.ComboBox cbFicha;
        private System.Windows.Forms.ComboBox cbTipoPedido;
        private System.Windows.Forms.Panel panel3;
        private Controllers.LpText txtFormaPagamento;
        private System.Windows.Forms.Panel panel2;
        private Controllers.LpText txtCliente;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStatusPedido;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTotalBruto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView GridProdutos;
        private System.Windows.Forms.DataGridViewImageColumn check;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}
