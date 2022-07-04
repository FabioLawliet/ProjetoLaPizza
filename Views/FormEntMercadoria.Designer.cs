
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalLiquido = new System.Windows.Forms.Label();
            this.lblDescontos = new System.Windows.Forms.Label();
            this.lbTotalBruto = new System.Windows.Forms.Label();
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
            this.ColumnCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVlrUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVlrDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVlrTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPrincipal.SuspendLayout();
            this.pnlNomeRotina.SuspendLayout();
            this.pnlAcoesRodape.SuspendLayout();
            this.pnlAcoesMenu.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.DGVProdutos);
            this.pnlPrincipal.Controls.Add(this.label19);
            this.pnlPrincipal.Controls.Add(this.txtVlrVenda);
            this.pnlPrincipal.Controls.Add(this.label18);
            this.pnlPrincipal.Controls.Add(this.txtVlrTotal);
            this.pnlPrincipal.Controls.Add(this.label17);
            this.pnlPrincipal.Controls.Add(this.txtVlrDesc);
            this.pnlPrincipal.Controls.Add(this.label16);
            this.pnlPrincipal.Controls.Add(this.txtVlrUnit);
            this.pnlPrincipal.Controls.Add(this.label15);
            this.pnlPrincipal.Controls.Add(this.txtQtde);
            this.pnlPrincipal.Controls.Add(this.label14);
            this.pnlPrincipal.Controls.Add(this.pesquisaProduto);
            this.pnlPrincipal.Controls.Add(this.txtProduto);
            this.pnlPrincipal.Controls.Add(this.pnlTotal);
            this.pnlPrincipal.Controls.Add(this.label5);
            this.pnlPrincipal.Controls.Add(this.txtOutrosCustos);
            this.pnlPrincipal.Controls.Add(this.label4);
            this.pnlPrincipal.Controls.Add(this.txtFrete);
            this.pnlPrincipal.Controls.Add(this.txtInfAdicionais);
            this.pnlPrincipal.Controls.Add(this.gbStatus);
            this.pnlPrincipal.Controls.Add(this.label3);
            this.pnlPrincipal.Controls.Add(this.dtConclusao);
            this.pnlPrincipal.Controls.Add(this.label2);
            this.pnlPrincipal.Controls.Add(this.dtAbertura);
            this.pnlPrincipal.Controls.Add(this.label1);
            this.pnlPrincipal.Controls.Add(this.PesquisaFornecedor);
            this.pnlPrincipal.Controls.Add(this.txtFornecedor);
            this.pnlPrincipal.Controls.Add(this.lbUnidadeMedidaDescricao);
            this.pnlPrincipal.Size = new System.Drawing.Size(691, 343);
            // 
            // pnlNomeRotina
            // 
            this.pnlNomeRotina.Size = new System.Drawing.Size(691, 40);
            // 
            // btnAcaoAdicionar
            // 
            this.btnAcaoAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAcaoAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.Location = new System.Drawing.Point(551, 5);
            this.btnAcaoAdicionar.Click += new System.EventHandler(this.btnAcaoAdicionar_Click);
            // 
            // btnAcaoEditar
            // 
            this.btnAcaoEditar.FlatAppearance.BorderSize = 0;
            this.btnAcaoEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.Location = new System.Drawing.Point(586, 5);
            this.btnAcaoEditar.Click += new System.EventHandler(this.btnAcaoEditar_Click);
            // 
            // btnAcaoConsultar
            // 
            this.btnAcaoConsultar.FlatAppearance.BorderSize = 0;
            this.btnAcaoConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.Location = new System.Drawing.Point(621, 5);
            this.btnAcaoConsultar.Click += new System.EventHandler(this.btnAcaoConsultar_Click);
            // 
            // lbNomeRotina
            // 
            this.lbNomeRotina.Size = new System.Drawing.Size(691, 40);
            this.lbNomeRotina.Text = "Form1";
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 422);
            this.pnlAcoesRodape.Size = new System.Drawing.Size(691, 40);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.Location = new System.Drawing.Point(541, 5);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSair.Location = new System.Drawing.Point(616, 5);
            // 
            // btnAcaoExcluir
            // 
            this.btnAcaoExcluir.FlatAppearance.BorderSize = 0;
            this.btnAcaoExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.Location = new System.Drawing.Point(656, 5);
            this.btnAcaoExcluir.Click += new System.EventHandler(this.btnAcaoExcluir_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(466, 5);
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(581, 5);
            // 
            // pnlAcoesMenu
            // 
            this.pnlAcoesMenu.Size = new System.Drawing.Size(691, 39);
            // 
            // lbUnidadeMedidaDescricao
            // 
            this.lbUnidadeMedidaDescricao.AutoSize = true;
            this.lbUnidadeMedidaDescricao.Location = new System.Drawing.Point(500, 2);
            this.lbUnidadeMedidaDescricao.Name = "lbUnidadeMedidaDescricao";
            this.lbUnidadeMedidaDescricao.Size = new System.Drawing.Size(116, 13);
            this.lbUnidadeMedidaDescricao.TabIndex = 33;
            this.lbUnidadeMedidaDescricao.Text = "Informações Adicionais";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedor.ForeColor = System.Drawing.Color.Black;
            this.txtFornecedor.Location = new System.Drawing.Point(5, 18);
            this.txtFornecedor.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtFornecedor.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtFornecedor.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(284, 20);
            this.txtFornecedor.TabIndex = 1;
            // 
            // PesquisaFornecedor
            // 
            this.PesquisaFornecedor.BackgroundImage = global::LaPizza.Properties.Resources.AcaoConsultarHover;
            this.PesquisaFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PesquisaFornecedor.Location = new System.Drawing.Point(269, 18);
            this.PesquisaFornecedor.Name = "PesquisaFornecedor";
            this.PesquisaFornecedor.Size = new System.Drawing.Size(20, 20);
            this.PesquisaFornecedor.TabIndex = 39;
            this.PesquisaFornecedor.Click += new System.EventHandler(this.PesquisaFornecedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Fornecedor";
            // 
            // dtAbertura
            // 
            this.dtAbertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAbertura.Location = new System.Drawing.Point(295, 18);
            this.dtAbertura.Name = "dtAbertura";
            this.dtAbertura.Size = new System.Drawing.Size(98, 20);
            this.dtAbertura.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Data abertura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Data conclusão";
            // 
            // dtConclusao
            // 
            this.dtConclusao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtConclusao.Location = new System.Drawing.Point(399, 18);
            this.dtConclusao.Name = "dtConclusao";
            this.dtConclusao.Size = new System.Drawing.Size(98, 20);
            this.dtConclusao.TabIndex = 3;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbPendente);
            this.gbStatus.Controls.Add(this.rbCancelar);
            this.gbStatus.Controls.Add(this.rbEfetivar);
            this.gbStatus.Location = new System.Drawing.Point(258, 46);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(239, 35);
            this.gbStatus.TabIndex = 7;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // rbPendente
            // 
            this.rbPendente.AutoSize = true;
            this.rbPendente.Location = new System.Drawing.Point(158, 13);
            this.rbPendente.Name = "rbPendente";
            this.rbPendente.Size = new System.Drawing.Size(71, 17);
            this.rbPendente.TabIndex = 2;
            this.rbPendente.Text = "Pendente";
            this.rbPendente.UseVisualStyleBackColor = true;
            // 
            // rbCancelar
            // 
            this.rbCancelar.AutoSize = true;
            this.rbCancelar.Location = new System.Drawing.Point(82, 13);
            this.rbCancelar.Name = "rbCancelar";
            this.rbCancelar.Size = new System.Drawing.Size(67, 17);
            this.rbCancelar.TabIndex = 1;
            this.rbCancelar.Text = "Cancelar";
            this.rbCancelar.UseVisualStyleBackColor = true;
            // 
            // rbEfetivar
            // 
            this.rbEfetivar.AutoSize = true;
            this.rbEfetivar.Checked = true;
            this.rbEfetivar.Location = new System.Drawing.Point(6, 13);
            this.rbEfetivar.Name = "rbEfetivar";
            this.rbEfetivar.Size = new System.Drawing.Size(61, 17);
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
            this.txtInfAdicionais.Location = new System.Drawing.Point(503, 18);
            this.txtInfAdicionais.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtInfAdicionais.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtInfAdicionais.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtInfAdicionais.Multiline = true;
            this.txtInfAdicionais.Name = "txtInfAdicionais";
            this.txtInfAdicionais.Size = new System.Drawing.Size(180, 63);
            this.txtInfAdicionais.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Frete";
            // 
            // txtFrete
            // 
            this.txtFrete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFrete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFrete.ForeColor = System.Drawing.Color.Black;
            this.txtFrete.Location = new System.Drawing.Point(5, 61);
            this.txtFrete.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtFrete.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtFrete.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtFrete.MaxLength = 10;
            this.txtFrete.Name = "txtFrete";
            this.txtFrete.Size = new System.Drawing.Size(118, 20);
            this.txtFrete.TabIndex = 5;
            this.txtFrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFrete.TextChanged += new System.EventHandler(this.txtFrete_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Outros Custos";
            // 
            // txtOutrosCustos
            // 
            this.txtOutrosCustos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutrosCustos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOutrosCustos.ForeColor = System.Drawing.Color.Black;
            this.txtOutrosCustos.Location = new System.Drawing.Point(129, 61);
            this.txtOutrosCustos.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtOutrosCustos.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtOutrosCustos.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtOutrosCustos.MaxLength = 10;
            this.txtOutrosCustos.Name = "txtOutrosCustos";
            this.txtOutrosCustos.Size = new System.Drawing.Size(123, 20);
            this.txtOutrosCustos.TabIndex = 6;
            this.txtOutrosCustos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOutrosCustos.TextChanged += new System.EventHandler(this.txtOutrosCustos_TextChanged);
            // 
            // pnlTotal
            // 
            this.pnlTotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTotal.Controls.Add(this.label11);
            this.pnlTotal.Controls.Add(this.label12);
            this.pnlTotal.Controls.Add(this.label13);
            this.pnlTotal.Controls.Add(this.label9);
            this.pnlTotal.Controls.Add(this.label8);
            this.pnlTotal.Controls.Add(this.lblTotalLiquido);
            this.pnlTotal.Controls.Add(this.lblDescontos);
            this.pnlTotal.Controls.Add(this.lbTotalBruto);
            this.pnlTotal.Controls.Add(this.lblTotalBruto);
            this.pnlTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotal.Location = new System.Drawing.Point(0, 269);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(691, 74);
            this.pnlTotal.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(463, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Total Liquido:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(485, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Descontos:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(482, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "Total Bruto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(743, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "TotalLiquido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(768, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Desconto";
            // 
            // lblTotalLiquido
            // 
            this.lblTotalLiquido.AutoSize = true;
            this.lblTotalLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLiquido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalLiquido.Location = new System.Drawing.Point(605, 45);
            this.lblTotalLiquido.Name = "lblTotalLiquido";
            this.lblTotalLiquido.Size = new System.Drawing.Size(40, 17);
            this.lblTotalLiquido.TabIndex = 5;
            this.lblTotalLiquido.Text = "0,00";
            // 
            // lblDescontos
            // 
            this.lblDescontos.AutoSize = true;
            this.lblDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescontos.Location = new System.Drawing.Point(609, 24);
            this.lblDescontos.Name = "lblDescontos";
            this.lblDescontos.Size = new System.Drawing.Size(36, 17);
            this.lblDescontos.TabIndex = 4;
            this.lblDescontos.Text = "0,00";
            // 
            // lbTotalBruto
            // 
            this.lbTotalBruto.AutoSize = true;
            this.lbTotalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalBruto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTotalBruto.Location = new System.Drawing.Point(766, 7);
            this.lbTotalBruto.Name = "lbTotalBruto";
            this.lbTotalBruto.Size = new System.Drawing.Size(71, 17);
            this.lbTotalBruto.TabIndex = 3;
            this.lbTotalBruto.Text = "TotaBruto";
            // 
            // lblTotalBruto
            // 
            this.lblTotalBruto.AutoSize = true;
            this.lblTotalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBruto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalBruto.Location = new System.Drawing.Point(609, 7);
            this.lblTotalBruto.Name = "lblTotalBruto";
            this.lblTotalBruto.Size = new System.Drawing.Size(36, 17);
            this.lblTotalBruto.TabIndex = 2;
            this.lblTotalBruto.Text = "0,00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "Produto";
            // 
            // pesquisaProduto
            // 
            this.pesquisaProduto.BackgroundImage = global::LaPizza.Properties.Resources.AcaoConsultarHover;
            this.pesquisaProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pesquisaProduto.Location = new System.Drawing.Point(269, 99);
            this.pesquisaProduto.Name = "pesquisaProduto";
            this.pesquisaProduto.Size = new System.Drawing.Size(20, 20);
            this.pesquisaProduto.TabIndex = 53;
            this.pesquisaProduto.Click += new System.EventHandler(this.pesquisaProduto_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.ForeColor = System.Drawing.Color.Black;
            this.txtProduto.Location = new System.Drawing.Point(5, 99);
            this.txtProduto.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtProduto.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtProduto.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.ReadOnly = true;
            this.txtProduto.Size = new System.Drawing.Size(284, 20);
            this.txtProduto.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(292, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 56;
            this.label15.Text = "Quantidade";
            // 
            // txtQtde
            // 
            this.txtQtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtde.ForeColor = System.Drawing.Color.Black;
            this.txtQtde.Location = new System.Drawing.Point(295, 99);
            this.txtQtde.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtQtde.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtQtde.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtQtde.MaxLength = 10;
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(71, 20);
            this.txtQtde.TabIndex = 9;
            this.txtQtde.Text = "1";
            this.txtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtde_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(367, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 58;
            this.label16.Text = "Valor Unitário";
            // 
            // txtVlrUnit
            // 
            this.txtVlrUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVlrUnit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVlrUnit.ForeColor = System.Drawing.Color.Black;
            this.txtVlrUnit.Location = new System.Drawing.Point(370, 99);
            this.txtVlrUnit.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtVlrUnit.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtVlrUnit.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtVlrUnit.MaxLength = 10;
            this.txtVlrUnit.Name = "txtVlrUnit";
            this.txtVlrUnit.Size = new System.Drawing.Size(71, 20);
            this.txtVlrUnit.TabIndex = 10;
            this.txtVlrUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVlrUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVlrUnit_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(444, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 13);
            this.label17.TabIndex = 60;
            this.label17.Text = "Valor Desconto";
            // 
            // txtVlrDesc
            // 
            this.txtVlrDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVlrDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVlrDesc.ForeColor = System.Drawing.Color.Black;
            this.txtVlrDesc.Location = new System.Drawing.Point(447, 99);
            this.txtVlrDesc.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtVlrDesc.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtVlrDesc.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtVlrDesc.MaxLength = 10;
            this.txtVlrDesc.Name = "txtVlrDesc";
            this.txtVlrDesc.Size = new System.Drawing.Size(71, 20);
            this.txtVlrDesc.TabIndex = 11;
            this.txtVlrDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVlrDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVlrDesc_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(521, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 62;
            this.label18.Text = "Valor Total";
            // 
            // txtVlrTotal
            // 
            this.txtVlrTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVlrTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVlrTotal.ForeColor = System.Drawing.Color.Black;
            this.txtVlrTotal.Location = new System.Drawing.Point(524, 99);
            this.txtVlrTotal.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtVlrTotal.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtVlrTotal.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtVlrTotal.MaxLength = 10;
            this.txtVlrTotal.Name = "txtVlrTotal";
            this.txtVlrTotal.Size = new System.Drawing.Size(71, 20);
            this.txtVlrTotal.TabIndex = 12;
            this.txtVlrTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVlrTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVlrTotal_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(598, 83);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 13);
            this.label19.TabIndex = 64;
            this.label19.Text = "Preço Venda";
            // 
            // txtVlrVenda
            // 
            this.txtVlrVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVlrVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVlrVenda.ForeColor = System.Drawing.Color.Black;
            this.txtVlrVenda.Location = new System.Drawing.Point(601, 99);
            this.txtVlrVenda.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtVlrVenda.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtVlrVenda.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtVlrVenda.MaxLength = 10;
            this.txtVlrVenda.Name = "txtVlrVenda";
            this.txtVlrVenda.Size = new System.Drawing.Size(82, 20);
            this.txtVlrVenda.TabIndex = 13;
            this.txtVlrVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVlrVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVlrVenda_KeyPress);
            // 
            // DGVProdutos
            // 
            this.DGVProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCod,
            this.ColumnDesc,
            this.ColumnQtde,
            this.ColumnVlrUnit,
            this.ColumnVlrDesconto,
            this.ColumnVlrTotal});
            this.DGVProdutos.Location = new System.Drawing.Point(6, 125);
            this.DGVProdutos.Name = "DGVProdutos";
            this.DGVProdutos.ReadOnly = true;
            this.DGVProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProdutos.Size = new System.Drawing.Size(677, 138);
            this.DGVProdutos.TabIndex = 65;
            this.DGVProdutos.TabStop = false;
            this.DGVProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProdutos_CellClick);
            this.DGVProdutos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DGVProdutos_KeyUp);
            // 
            // ColumnCod
            // 
            this.ColumnCod.HeaderText = "Cód. Produto";
            this.ColumnCod.Name = "ColumnCod";
            this.ColumnCod.ReadOnly = true;
            this.ColumnCod.Visible = false;
            // 
            // ColumnDesc
            // 
            this.ColumnDesc.HeaderText = "Descrição";
            this.ColumnDesc.Name = "ColumnDesc";
            this.ColumnDesc.ReadOnly = true;
            this.ColumnDesc.Visible = false;
            // 
            // ColumnQtde
            // 
            this.ColumnQtde.HeaderText = "Qtde";
            this.ColumnQtde.Name = "ColumnQtde";
            this.ColumnQtde.ReadOnly = true;
            this.ColumnQtde.Visible = false;
            // 
            // ColumnVlrUnit
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0";
            this.ColumnVlrUnit.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnVlrUnit.HeaderText = "Vlr unitário";
            this.ColumnVlrUnit.Name = "ColumnVlrUnit";
            this.ColumnVlrUnit.ReadOnly = true;
            this.ColumnVlrUnit.Visible = false;
            // 
            // ColumnVlrDesconto
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0,00";
            this.ColumnVlrDesconto.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnVlrDesconto.HeaderText = "Desconto";
            this.ColumnVlrDesconto.Name = "ColumnVlrDesconto";
            this.ColumnVlrDesconto.ReadOnly = true;
            this.ColumnVlrDesconto.Visible = false;
            // 
            // ColumnVlrTotal
            // 
            this.ColumnVlrTotal.HeaderText = "Vlr total";
            this.ColumnVlrTotal.Name = "ColumnVlrTotal";
            this.ColumnVlrTotal.ReadOnly = true;
            this.ColumnVlrTotal.Visible = false;
            // 
            // FormEntMercadoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(691, 462);
            this.Name = "FormEntMercadoria";
            this.Text = "";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlNomeRotina.ResumeLayout(false);
            this.pnlAcoesRodape.ResumeLayout(false);
            this.pnlAcoesMenu.ResumeLayout(false);
            this.pnlAcoesMenu.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProdutos)).EndInit();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalLiquido;
        private System.Windows.Forms.Label lblDescontos;
        private System.Windows.Forms.Label lbTotalBruto;
        private System.Windows.Forms.Label lblTotalBruto;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVlrUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVlrDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVlrTotal;
    }
}
