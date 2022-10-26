
namespace LaPizza.Views
{
    partial class FormEntMercadoria
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
            this.lbUnidadeMedidaDescricao = new System.Windows.Forms.Label();
            this.txtFornecedor = new LaPizza.Controllers.LpText();
            this.PesquisaFornecedor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtAbertura = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtConclusao = new System.Windows.Forms.DateTimePicker();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbPendente = new System.Windows.Forms.RadioButton();
            this.rbCancelar = new System.Windows.Forms.RadioButton();
            this.rbEfetivar = new System.Windows.Forms.RadioButton();
            this.txtInfAdicionais = new LaPizza.Controllers.LpText();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFrete = new LaPizza.Controllers.LpText();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOutrosCustos = new LaPizza.Controllers.LpText();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalLiquido = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDescontos = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalBruto = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pesquisaProduto = new System.Windows.Forms.Panel();
            this.txtProduto = new LaPizza.Controllers.LpText();
            this.label15 = new System.Windows.Forms.Label();
            this.txtQtde = new LaPizza.Controllers.LpText();
            this.label16 = new System.Windows.Forms.Label();
            this.txtVlrUnit = new LaPizza.Controllers.LpText();
            this.label17 = new System.Windows.Forms.Label();
            this.txtVlrDesc = new LaPizza.Controllers.LpText();
            this.label18 = new System.Windows.Forms.Label();
            this.txtVlrTotal = new LaPizza.Controllers.LpText();
            this.label19 = new System.Windows.Forms.Label();
            this.txtVlrVenda = new LaPizza.Controllers.LpText();
            this.DGVProdutos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtChaveNota = new LaPizza.Controllers.LpText();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumeroNota = new LaPizza.Controllers.LpText();
            this.pnlPrincipal.SuspendLayout();
            this.pnlNomeRotina.SuspendLayout();
            this.pnlAcoesRodape.SuspendLayout();
            this.pnlAcoesMenu.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProdutos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.panel1);
            this.pnlPrincipal.Controls.Add(this.DGVProdutos);
            this.pnlPrincipal.Controls.Add(this.pnlTotal);
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 88);
            this.pnlPrincipal.Size = new System.Drawing.Size(1045, 441);
            // 
            // pnlNomeRotina
            // 
            this.pnlNomeRotina.Size = new System.Drawing.Size(1045, 40);
            // 
            // btnAcaoAdicionar
            // 
            this.btnAcaoAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAcaoAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.Location = new System.Drawing.Point(857, 6);
            this.btnAcaoAdicionar.Click += new System.EventHandler(this.btnAcaoAdicionar_Click);
            // 
            // btnAcaoEditar
            // 
            this.btnAcaoEditar.FlatAppearance.BorderSize = 0;
            this.btnAcaoEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.Location = new System.Drawing.Point(904, 6);
            this.btnAcaoEditar.Click += new System.EventHandler(this.btnAcaoEditar_Click);
            // 
            // btnAcaoConsultar
            // 
            this.btnAcaoConsultar.FlatAppearance.BorderSize = 0;
            this.btnAcaoConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.Location = new System.Drawing.Point(951, 6);
            this.btnAcaoConsultar.Click += new System.EventHandler(this.btnAcaoConsultar_Click);
            // 
            // lbNomeRotina
            // 
            this.lbNomeRotina.Size = new System.Drawing.Size(1045, 40);
            this.lbNomeRotina.Text = "Form1";
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 529);
            this.pnlAcoesRodape.Size = new System.Drawing.Size(1045, 40);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.Location = new System.Drawing.Point(845, 6);
            this.btnCancelar.Size = new System.Drawing.Size(93, 28);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSair.Location = new System.Drawing.Point(945, 6);
            this.btnSair.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnSair.Size = new System.Drawing.Size(93, 28);
            // 
            // btnAcaoExcluir
            // 
            this.btnAcaoExcluir.FlatAppearance.BorderSize = 0;
            this.btnAcaoExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.Location = new System.Drawing.Point(998, 6);
            this.btnAcaoExcluir.Click += new System.EventHandler(this.btnAcaoExcluir_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(745, 6);
            this.btnConfirmar.Size = new System.Drawing.Size(93, 28);
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(897, 6);
            // 
            // pnlAcoesMenu
            // 
            this.pnlAcoesMenu.Location = new System.Drawing.Point(0, 40);
            this.pnlAcoesMenu.Size = new System.Drawing.Size(1045, 48);
            // 
            // lbUnidadeMedidaDescricao
            // 
            this.lbUnidadeMedidaDescricao.AutoSize = true;
            this.lbUnidadeMedidaDescricao.Location = new System.Drawing.Point(503, 50);
            this.lbUnidadeMedidaDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUnidadeMedidaDescricao.Name = "lbUnidadeMedidaDescricao";
            this.lbUnidadeMedidaDescricao.Size = new System.Drawing.Size(147, 16);
            this.lbUnidadeMedidaDescricao.TabIndex = 33;
            this.lbUnidadeMedidaDescricao.Text = "Informações Adicionais";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedor.ForeColor = System.Drawing.Color.Black;
            this.txtFornecedor.Location = new System.Drawing.Point(591, 22);
            this.txtFornecedor.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtFornecedor.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtFornecedor.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(221, 22);
            this.txtFornecedor.TabIndex = 3;
            // 
            // PesquisaFornecedor
            // 
            this.PesquisaFornecedor.BackgroundImage = global::LaPizza.Properties.Resources.AcaoConsultarHover;
            this.PesquisaFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PesquisaFornecedor.Location = new System.Drawing.Point(811, 22);
            this.PesquisaFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.PesquisaFornecedor.Name = "PesquisaFornecedor";
            this.PesquisaFornecedor.Size = new System.Drawing.Size(27, 25);
            this.PesquisaFornecedor.TabIndex = 39;
            this.PesquisaFornecedor.Click += new System.EventHandler(this.PesquisaFornecedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Fornecedor";
            // 
            // dtAbertura
            // 
            this.dtAbertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAbertura.Location = new System.Drawing.Point(325, 22);
            this.dtAbertura.Margin = new System.Windows.Forms.Padding(4);
            this.dtAbertura.Name = "dtAbertura";
            this.dtAbertura.Size = new System.Drawing.Size(125, 22);
            this.dtAbertura.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Data abertura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Data conclusão";
            // 
            // dtConclusao
            // 
            this.dtConclusao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtConclusao.Location = new System.Drawing.Point(460, 22);
            this.dtConclusao.Margin = new System.Windows.Forms.Padding(4);
            this.dtConclusao.Name = "dtConclusao";
            this.dtConclusao.Size = new System.Drawing.Size(125, 22);
            this.dtConclusao.TabIndex = 2;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbPendente);
            this.gbStatus.Controls.Add(this.rbCancelar);
            this.gbStatus.Controls.Add(this.rbEfetivar);
            this.gbStatus.Location = new System.Drawing.Point(8, 7);
            this.gbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Padding = new System.Windows.Forms.Padding(4);
            this.gbStatus.Size = new System.Drawing.Size(309, 43);
            this.gbStatus.TabIndex = 0;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // rbPendente
            // 
            this.rbPendente.AutoSize = true;
            this.rbPendente.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbPendente.Location = new System.Drawing.Point(215, 19);
            this.rbPendente.Margin = new System.Windows.Forms.Padding(4);
            this.rbPendente.Name = "rbPendente";
            this.rbPendente.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.rbPendente.Size = new System.Drawing.Size(90, 20);
            this.rbPendente.TabIndex = 2;
            this.rbPendente.Text = "Pendente";
            this.rbPendente.UseVisualStyleBackColor = true;
            // 
            // rbCancelar
            // 
            this.rbCancelar.AutoSize = true;
            this.rbCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbCancelar.Location = new System.Drawing.Point(81, 19);
            this.rbCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.rbCancelar.Name = "rbCancelar";
            this.rbCancelar.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.rbCancelar.Size = new System.Drawing.Size(224, 20);
            this.rbCancelar.TabIndex = 1;
            this.rbCancelar.Text = "Cancelar";
            this.rbCancelar.UseVisualStyleBackColor = true;
            // 
            // rbEfetivar
            // 
            this.rbEfetivar.AutoSize = true;
            this.rbEfetivar.Checked = true;
            this.rbEfetivar.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbEfetivar.Location = new System.Drawing.Point(4, 19);
            this.rbEfetivar.Margin = new System.Windows.Forms.Padding(4);
            this.rbEfetivar.Name = "rbEfetivar";
            this.rbEfetivar.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.rbEfetivar.Size = new System.Drawing.Size(77, 20);
            this.rbEfetivar.TabIndex = 0;
            this.rbEfetivar.TabStop = true;
            this.rbEfetivar.Text = "Efetivar";
            this.rbEfetivar.UseVisualStyleBackColor = true;
            // 
            // txtInfAdicionais
            // 
            this.txtInfAdicionais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInfAdicionais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInfAdicionais.ForeColor = System.Drawing.Color.Black;
            this.txtInfAdicionais.Location = new System.Drawing.Point(507, 70);
            this.txtInfAdicionais.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtInfAdicionais.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtInfAdicionais.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtInfAdicionais.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfAdicionais.Multiline = true;
            this.txtInfAdicionais.Name = "txtInfAdicionais";
            this.txtInfAdicionais.Size = new System.Drawing.Size(531, 24);
            this.txtInfAdicionais.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(840, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Frete";
            // 
            // txtFrete
            // 
            this.txtFrete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFrete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFrete.ForeColor = System.Drawing.Color.Black;
            this.txtFrete.Location = new System.Drawing.Point(844, 22);
            this.txtFrete.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtFrete.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtFrete.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtFrete.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrete.MaxLength = 10;
            this.txtFrete.Name = "txtFrete";
            this.txtFrete.Size = new System.Drawing.Size(93, 22);
            this.txtFrete.TabIndex = 4;
            this.txtFrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFrete.TextChanged += new System.EventHandler(this.txtFrete_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(941, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Outros Custos";
            // 
            // txtOutrosCustos
            // 
            this.txtOutrosCustos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutrosCustos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOutrosCustos.ForeColor = System.Drawing.Color.Black;
            this.txtOutrosCustos.Location = new System.Drawing.Point(945, 22);
            this.txtOutrosCustos.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtOutrosCustos.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtOutrosCustos.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtOutrosCustos.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutrosCustos.MaxLength = 10;
            this.txtOutrosCustos.Name = "txtOutrosCustos";
            this.txtOutrosCustos.Size = new System.Drawing.Size(93, 22);
            this.txtOutrosCustos.TabIndex = 5;
            this.txtOutrosCustos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOutrosCustos.TextChanged += new System.EventHandler(this.txtOutrosCustos_TextChanged);
            // 
            // pnlTotal
            // 
            this.pnlTotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTotal.Controls.Add(this.tableLayoutPanel1);
            this.pnlTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotal.Location = new System.Drawing.Point(0, 350);
            this.pnlTotal.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(1045, 91);
            this.pnlTotal.TabIndex = 51;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.23383F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.76617F));
            this.tableLayoutPanel1.Controls.Add(this.lblTotalLiquido, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDescontos, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalBruto, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(745, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 91);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // lblTotalLiquido
            // 
            this.lblTotalLiquido.AutoSize = true;
            this.lblTotalLiquido.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLiquido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalLiquido.Location = new System.Drawing.Point(256, 58);
            this.lblTotalLiquido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalLiquido.Name = "lblTotalLiquido";
            this.lblTotalLiquido.Size = new System.Drawing.Size(40, 27);
            this.lblTotalLiquido.TabIndex = 8;
            this.lblTotalLiquido.Text = "0,00";
            this.lblTotalLiquido.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(4, 4);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Total Bruto:";
            // 
            // lblDescontos
            // 
            this.lblDescontos.AutoSize = true;
            this.lblDescontos.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescontos.Location = new System.Drawing.Point(260, 31);
            this.lblDescontos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescontos.Name = "lblDescontos";
            this.lblDescontos.Size = new System.Drawing.Size(36, 27);
            this.lblDescontos.TabIndex = 15;
            this.lblDescontos.Text = "0,00";
            this.lblDescontos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(4, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Descontos:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(4, 58);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Total Liquido:";
            // 
            // lblTotalBruto
            // 
            this.lblTotalBruto.AutoSize = true;
            this.lblTotalBruto.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBruto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalBruto.Location = new System.Drawing.Point(260, 4);
            this.lblTotalBruto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalBruto.Name = "lblTotalBruto";
            this.lblTotalBruto.Size = new System.Drawing.Size(36, 27);
            this.lblTotalBruto.TabIndex = 14;
            this.lblTotalBruto.Text = "0,00";
            this.lblTotalBruto.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 98);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 16);
            this.label14.TabIndex = 54;
            this.label14.Text = "Produto";
            // 
            // pesquisaProduto
            // 
            this.pesquisaProduto.BackgroundImage = global::LaPizza.Properties.Resources.AcaoConsultarHover;
            this.pesquisaProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pesquisaProduto.Location = new System.Drawing.Point(365, 114);
            this.pesquisaProduto.Margin = new System.Windows.Forms.Padding(4);
            this.pesquisaProduto.Name = "pesquisaProduto";
            this.pesquisaProduto.Size = new System.Drawing.Size(27, 25);
            this.pesquisaProduto.TabIndex = 53;
            this.pesquisaProduto.Click += new System.EventHandler(this.pesquisaProduto_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.SystemColors.Window;
            this.txtProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.ForeColor = System.Drawing.Color.Black;
            this.txtProduto.Location = new System.Drawing.Point(8, 114);
            this.txtProduto.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtProduto.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtProduto.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.ReadOnly = true;
            this.txtProduto.Size = new System.Drawing.Size(363, 22);
            this.txtProduto.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(395, 96);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 16);
            this.label15.TabIndex = 56;
            this.label15.Text = "Quantidade";
            // 
            // txtQtde
            // 
            this.txtQtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtde.ForeColor = System.Drawing.Color.Black;
            this.txtQtde.Location = new System.Drawing.Point(399, 114);
            this.txtQtde.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtQtde.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtQtde.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtQtde.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtde.MaxLength = 10;
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(99, 22);
            this.txtQtde.TabIndex = 10;
            this.txtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQtde.Leave += new System.EventHandler(this.txtQtde_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(503, 95);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 16);
            this.label16.TabIndex = 58;
            this.label16.Text = "Vlr Unitário";
            // 
            // txtVlrUnit
            // 
            this.txtVlrUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVlrUnit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVlrUnit.ForeColor = System.Drawing.Color.Black;
            this.txtVlrUnit.Location = new System.Drawing.Point(507, 114);
            this.txtVlrUnit.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtVlrUnit.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtVlrUnit.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtVlrUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txtVlrUnit.MaxLength = 10;
            this.txtVlrUnit.Name = "txtVlrUnit";
            this.txtVlrUnit.Size = new System.Drawing.Size(99, 22);
            this.txtVlrUnit.TabIndex = 11;
            this.txtVlrUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVlrUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVlrUnit_KeyPress);
            this.txtVlrUnit.Leave += new System.EventHandler(this.txtVlrUnit_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(611, 95);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 16);
            this.label17.TabIndex = 60;
            this.label17.Text = "Vlr Desconto";
            // 
            // txtVlrDesc
            // 
            this.txtVlrDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVlrDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVlrDesc.ForeColor = System.Drawing.Color.Black;
            this.txtVlrDesc.Location = new System.Drawing.Point(615, 114);
            this.txtVlrDesc.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtVlrDesc.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtVlrDesc.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtVlrDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtVlrDesc.MaxLength = 10;
            this.txtVlrDesc.Name = "txtVlrDesc";
            this.txtVlrDesc.Size = new System.Drawing.Size(99, 22);
            this.txtVlrDesc.TabIndex = 12;
            this.txtVlrDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVlrDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVlrDesc_KeyPress);
            this.txtVlrDesc.Leave += new System.EventHandler(this.txtVlrDesc_Leave);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(719, 95);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 16);
            this.label18.TabIndex = 62;
            this.label18.Text = "Vlr Total";
            // 
            // txtVlrTotal
            // 
            this.txtVlrTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVlrTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVlrTotal.ForeColor = System.Drawing.Color.Black;
            this.txtVlrTotal.Location = new System.Drawing.Point(723, 114);
            this.txtVlrTotal.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtVlrTotal.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtVlrTotal.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtVlrTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtVlrTotal.MaxLength = 10;
            this.txtVlrTotal.Name = "txtVlrTotal";
            this.txtVlrTotal.Size = new System.Drawing.Size(99, 22);
            this.txtVlrTotal.TabIndex = 13;
            this.txtVlrTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVlrTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVlrTotal_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(827, 95);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 16);
            this.label19.TabIndex = 64;
            this.label19.Text = "Preço Venda";
            // 
            // txtVlrVenda
            // 
            this.txtVlrVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVlrVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVlrVenda.ForeColor = System.Drawing.Color.Black;
            this.txtVlrVenda.Location = new System.Drawing.Point(831, 114);
            this.txtVlrVenda.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtVlrVenda.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtVlrVenda.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtVlrVenda.Margin = new System.Windows.Forms.Padding(4);
            this.txtVlrVenda.MaxLength = 10;
            this.txtVlrVenda.Name = "txtVlrVenda";
            this.txtVlrVenda.Size = new System.Drawing.Size(99, 22);
            this.txtVlrVenda.TabIndex = 14;
            this.txtVlrVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DGVProdutos
            // 
            this.DGVProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProdutos.Location = new System.Drawing.Point(8, 154);
            this.DGVProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.DGVProdutos.Name = "DGVProdutos";
            this.DGVProdutos.ReadOnly = true;
            this.DGVProdutos.RowHeadersWidth = 51;
            this.DGVProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProdutos.Size = new System.Drawing.Size(1031, 170);
            this.DGVProdutos.TabIndex = 1;
            this.DGVProdutos.TabStop = false;
            this.DGVProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProdutos_CellClick);
            this.DGVProdutos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DGVProdutos_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInserir);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtChaveNota);
            this.panel1.Controls.Add(this.txtQtde);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtVlrTotal);
            this.panel1.Controls.Add(this.txtVlrUnit);
            this.panel1.Controls.Add(this.txtVlrDesc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.PesquisaFornecedor);
            this.panel1.Controls.Add(this.txtFornecedor);
            this.panel1.Controls.Add(this.gbStatus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.txtFrete);
            this.panel1.Controls.Add(this.txtOutrosCustos);
            this.panel1.Controls.Add(this.txtVlrVenda);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNumeroNota);
            this.panel1.Controls.Add(this.dtConclusao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtAbertura);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.pesquisaProduto);
            this.panel1.Controls.Add(this.txtInfAdicionais);
            this.panel1.Controls.Add(this.txtProduto);
            this.panel1.Controls.Add(this.lbUnidadeMedidaDescricao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 146);
            this.panel1.TabIndex = 0;
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.IndianRed;
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInserir.Location = new System.Drawing.Point(939, 114);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(100, 25);
            this.btnInserir.TabIndex = 15;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 70;
            this.label7.Text = "Chave NF";
            // 
            // txtChaveNota
            // 
            this.txtChaveNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChaveNota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChaveNota.ForeColor = System.Drawing.Color.Black;
            this.txtChaveNota.Location = new System.Drawing.Point(143, 70);
            this.txtChaveNota.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtChaveNota.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtChaveNota.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtChaveNota.Margin = new System.Windows.Forms.Padding(4);
            this.txtChaveNota.MaxLength = 50;
            this.txtChaveNota.Name = "txtChaveNota";
            this.txtChaveNota.Size = new System.Drawing.Size(355, 22);
            this.txtChaveNota.TabIndex = 7;
            this.txtChaveNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 68;
            this.label6.Text = "N° NF";
            // 
            // txtNumeroNota
            // 
            this.txtNumeroNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroNota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroNota.ForeColor = System.Drawing.Color.Black;
            this.txtNumeroNota.Location = new System.Drawing.Point(8, 70);
            this.txtNumeroNota.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtNumeroNota.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtNumeroNota.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtNumeroNota.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroNota.MaxLength = 10;
            this.txtNumeroNota.Name = "txtNumeroNota";
            this.txtNumeroNota.Size = new System.Drawing.Size(126, 22);
            this.txtNumeroNota.TabIndex = 6;
            this.txtNumeroNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormEntMercadoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1045, 569);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormEntMercadoria";
            this.Text = "";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlNomeRotina.ResumeLayout(false);
            this.pnlAcoesRodape.ResumeLayout(false);
            this.pnlAcoesMenu.ResumeLayout(false);
            this.pnlAcoesMenu.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProdutos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbUnidadeMedidaDescricao;
        private Controllers.LpText txtFornecedor;
        private System.Windows.Forms.Panel PesquisaFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbPendente;
        private System.Windows.Forms.RadioButton rbCancelar;
        private System.Windows.Forms.RadioButton rbEfetivar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtConclusao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtAbertura;
        private System.Windows.Forms.Label label5;
        private Controllers.LpText txtOutrosCustos;
        private System.Windows.Forms.Label label4;
        private Controllers.LpText txtFrete;
        private Controllers.LpText txtInfAdicionais;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.DataGridView DGVProdutos;
        private System.Windows.Forms.Label label19;
        private Controllers.LpText txtVlrVenda;
        private System.Windows.Forms.Label label18;
        private Controllers.LpText txtVlrTotal;
        private System.Windows.Forms.Label label17;
        private Controllers.LpText txtVlrDesc;
        private System.Windows.Forms.Label label16;
        private Controllers.LpText txtVlrUnit;
        private System.Windows.Forms.Label label15;
        private Controllers.LpText txtQtde;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pesquisaProduto;
        private Controllers.LpText txtProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private Controllers.LpText txtChaveNota;
        private System.Windows.Forms.Label label6;
        private Controllers.LpText txtNumeroNota;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTotalLiquido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDescontos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalBruto;
    }
}
