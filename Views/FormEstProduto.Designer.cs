namespace LaPizza.Views
{
    partial class FormEstProduto
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
            this.boxEstoque = new System.Windows.Forms.GroupBox();
            this.txtQtdeEstMax = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQtdeEstIdeal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQtdeEstMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnidadeMedida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaldoEstoque = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BoxPreco = new System.Windows.Forms.GroupBox();
            this.txtPrecoAnterior = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecoAtual = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMarcaDescricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGrupoDescricao = new System.Windows.Forms.TextBox();
            this.txtSubGrupoDescricao = new System.Windows.Forms.TextBox();
            this.txtInfAdicionais = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataCadastro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodFabricante = new System.Windows.Forms.TextBox();
            this.lbCodFabricante = new System.Windows.Forms.Label();
            this.txtMarcaId = new System.Windows.Forms.TextBox();
            this.lbMarca = new System.Windows.Forms.Label();
            this.txtSubGrupoId = new System.Windows.Forms.TextBox();
            this.lbSubGrupo = new System.Windows.Forms.Label();
            this.txtGrupoId = new System.Windows.Forms.TextBox();
            this.lbGrupo = new System.Windows.Forms.Label();
            this.lbAtivo = new System.Windows.Forms.Label();
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.txtProdutoDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.txtProdutoId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            this.pnlNomeRotina.SuspendLayout();
            this.pnlAcoesMenu.SuspendLayout();
            this.pnlAcoesRodape.SuspendLayout();
            this.boxEstoque.SuspendLayout();
            this.BoxPreco.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.groupBox1);
            this.pnlPrincipal.Controls.Add(this.BoxPreco);
            this.pnlPrincipal.Controls.Add(this.boxEstoque);
            this.pnlPrincipal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlPrincipal.Size = new System.Drawing.Size(670, 235);
            // 
            // pnlNomeRotina
            // 
            this.pnlNomeRotina.Size = new System.Drawing.Size(670, 40);
            // 
            // pnlAcoesMenu
            // 
            this.pnlAcoesMenu.Size = new System.Drawing.Size(670, 39);
            // 
            // btnAcaoAdicionar
            // 
            this.btnAcaoAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAcaoAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.Location = new System.Drawing.Point(530, 5);
            this.btnAcaoAdicionar.Click += new System.EventHandler(this.btnAcaoAdicionar_Click);
            // 
            // btnAcaoEditar
            // 
            this.btnAcaoEditar.FlatAppearance.BorderSize = 0;
            this.btnAcaoEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.Location = new System.Drawing.Point(565, 5);
            this.btnAcaoEditar.Click += new System.EventHandler(this.btnAcaoEditar_Click);
            // 
            // btnAcaoConsultar
            // 
            this.btnAcaoConsultar.FlatAppearance.BorderSize = 0;
            this.btnAcaoConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.Location = new System.Drawing.Point(600, 5);
            this.btnAcaoConsultar.Click += new System.EventHandler(this.btnAcaoConsultar_Click);
            // 
            // lbNomeRotina
            // 
            this.lbNomeRotina.Size = new System.Drawing.Size(670, 40);
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 314);
            this.pnlAcoesRodape.Size = new System.Drawing.Size(670, 40);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.Location = new System.Drawing.Point(520, 5);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSair.Location = new System.Drawing.Point(595, 5);
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAcaoExcluir
            // 
            this.btnAcaoExcluir.FlatAppearance.BorderSize = 0;
            this.btnAcaoExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.Location = new System.Drawing.Point(635, 5);
            this.btnAcaoExcluir.Click += new System.EventHandler(this.btnAcaoExcluir_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(445, 5);
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // boxEstoque
            // 
            this.boxEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.boxEstoque.Controls.Add(this.txtQtdeEstMax);
            this.boxEstoque.Controls.Add(this.label11);
            this.boxEstoque.Controls.Add(this.txtQtdeEstIdeal);
            this.boxEstoque.Controls.Add(this.label10);
            this.boxEstoque.Controls.Add(this.txtQtdeEstMin);
            this.boxEstoque.Controls.Add(this.label4);
            this.boxEstoque.Controls.Add(this.txtUnidadeMedida);
            this.boxEstoque.Controls.Add(this.label3);
            this.boxEstoque.Controls.Add(this.txtSaldoEstoque);
            this.boxEstoque.Controls.Add(this.label9);
            this.boxEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxEstoque.ForeColor = System.Drawing.SystemColors.Window;
            this.boxEstoque.Location = new System.Drawing.Point(10, 157);
            this.boxEstoque.Name = "boxEstoque";
            this.boxEstoque.Size = new System.Drawing.Size(448, 68);
            this.boxEstoque.TabIndex = 27;
            this.boxEstoque.TabStop = false;
            this.boxEstoque.Text = "Estoque";
            // 
            // txtQtdeEstMax
            // 
            this.txtQtdeEstMax.BackColor = System.Drawing.Color.White;
            this.txtQtdeEstMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdeEstMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeEstMax.Location = new System.Drawing.Point(356, 35);
            this.txtQtdeEstMax.Name = "txtQtdeEstMax";
            this.txtQtdeEstMax.Size = new System.Drawing.Size(80, 20);
            this.txtQtdeEstMax.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label11.Location = new System.Drawing.Point(352, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Qtde Est. Max";
            // 
            // txtQtdeEstIdeal
            // 
            this.txtQtdeEstIdeal.BackColor = System.Drawing.Color.White;
            this.txtQtdeEstIdeal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdeEstIdeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeEstIdeal.Location = new System.Drawing.Point(270, 35);
            this.txtQtdeEstIdeal.Name = "txtQtdeEstIdeal";
            this.txtQtdeEstIdeal.Size = new System.Drawing.Size(80, 20);
            this.txtQtdeEstIdeal.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label10.Location = new System.Drawing.Point(267, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Qtde Est. Ideal";
            // 
            // txtQtdeEstMin
            // 
            this.txtQtdeEstMin.BackColor = System.Drawing.Color.White;
            this.txtQtdeEstMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdeEstMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeEstMin.Location = new System.Drawing.Point(184, 35);
            this.txtQtdeEstMin.Name = "txtQtdeEstMin";
            this.txtQtdeEstMin.Size = new System.Drawing.Size(80, 20);
            this.txtQtdeEstMin.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(181, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Qtde Est. Min.";
            // 
            // txtUnidadeMedida
            // 
            this.txtUnidadeMedida.BackColor = System.Drawing.Color.White;
            this.txtUnidadeMedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnidadeMedida.Enabled = false;
            this.txtUnidadeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidadeMedida.Location = new System.Drawing.Point(98, 35);
            this.txtUnidadeMedida.Name = "txtUnidadeMedida";
            this.txtUnidadeMedida.Size = new System.Drawing.Size(80, 20);
            this.txtUnidadeMedida.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(95, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Un. Med.";
            // 
            // txtSaldoEstoque
            // 
            this.txtSaldoEstoque.BackColor = System.Drawing.Color.White;
            this.txtSaldoEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaldoEstoque.Enabled = false;
            this.txtSaldoEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoEstoque.Location = new System.Drawing.Point(12, 35);
            this.txtSaldoEstoque.Name = "txtSaldoEstoque";
            this.txtSaldoEstoque.Size = new System.Drawing.Size(80, 20);
            this.txtSaldoEstoque.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label9.Location = new System.Drawing.Point(10, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Saldo Estoque";
            // 
            // BoxPreco
            // 
            this.BoxPreco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BoxPreco.Controls.Add(this.txtPrecoAnterior);
            this.BoxPreco.Controls.Add(this.label8);
            this.BoxPreco.Controls.Add(this.txtPrecoAtual);
            this.BoxPreco.Controls.Add(this.label14);
            this.BoxPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxPreco.ForeColor = System.Drawing.SystemColors.Window;
            this.BoxPreco.Location = new System.Drawing.Point(478, 157);
            this.BoxPreco.Name = "BoxPreco";
            this.BoxPreco.Size = new System.Drawing.Size(182, 68);
            this.BoxPreco.TabIndex = 28;
            this.BoxPreco.TabStop = false;
            this.BoxPreco.Text = "Preço de Venda";
            // 
            // txtPrecoAnterior
            // 
            this.txtPrecoAnterior.BackColor = System.Drawing.Color.White;
            this.txtPrecoAnterior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoAnterior.Enabled = false;
            this.txtPrecoAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoAnterior.Location = new System.Drawing.Point(8, 35);
            this.txtPrecoAnterior.Name = "txtPrecoAnterior";
            this.txtPrecoAnterior.Size = new System.Drawing.Size(80, 20);
            this.txtPrecoAnterior.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Preço Ant.";
            // 
            // txtPrecoAtual
            // 
            this.txtPrecoAtual.BackColor = System.Drawing.Color.White;
            this.txtPrecoAtual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoAtual.Location = new System.Drawing.Point(92, 35);
            this.txtPrecoAtual.Name = "txtPrecoAtual";
            this.txtPrecoAtual.Size = new System.Drawing.Size(80, 20);
            this.txtPrecoAtual.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label14.Location = new System.Drawing.Point(90, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Preço Atual";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMarcaDescricao);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtGrupoDescricao);
            this.groupBox1.Controls.Add(this.txtSubGrupoDescricao);
            this.groupBox1.Controls.Add(this.txtInfAdicionais);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDataCadastro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodFabricante);
            this.groupBox1.Controls.Add(this.lbCodFabricante);
            this.groupBox1.Controls.Add(this.txtMarcaId);
            this.groupBox1.Controls.Add(this.lbMarca);
            this.groupBox1.Controls.Add(this.txtSubGrupoId);
            this.groupBox1.Controls.Add(this.lbSubGrupo);
            this.groupBox1.Controls.Add(this.txtGrupoId);
            this.groupBox1.Controls.Add(this.lbGrupo);
            this.groupBox1.Controls.Add(this.lbAtivo);
            this.groupBox1.Controls.Add(this.cbAtivo);
            this.groupBox1.Controls.Add(this.txtProdutoDescricao);
            this.groupBox1.Controls.Add(this.lbDescricao);
            this.groupBox1.Controls.Add(this.txtProdutoId);
            this.groupBox1.Controls.Add(this.lbId);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 143);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Gerais";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(486, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Descrição";
            // 
            // txtMarcaDescricao
            // 
            this.txtMarcaDescricao.BackColor = System.Drawing.Color.LightGray;
            this.txtMarcaDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarcaDescricao.Enabled = false;
            this.txtMarcaDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaDescricao.Location = new System.Drawing.Point(487, 71);
            this.txtMarcaDescricao.Name = "txtMarcaDescricao";
            this.txtMarcaDescricao.Size = new System.Drawing.Size(150, 20);
            this.txtMarcaDescricao.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(274, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Descrição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(64, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Descrição";
            // 
            // txtGrupoDescricao
            // 
            this.txtGrupoDescricao.BackColor = System.Drawing.Color.White;
            this.txtGrupoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrupoDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrupoDescricao.Location = new System.Drawing.Point(67, 71);
            this.txtGrupoDescricao.Name = "txtGrupoDescricao";
            this.txtGrupoDescricao.Size = new System.Drawing.Size(150, 20);
            this.txtGrupoDescricao.TabIndex = 67;
            // 
            // txtSubGrupoDescricao
            // 
            this.txtSubGrupoDescricao.BackColor = System.Drawing.Color.White;
            this.txtSubGrupoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubGrupoDescricao.Enabled = false;
            this.txtSubGrupoDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubGrupoDescricao.Location = new System.Drawing.Point(277, 71);
            this.txtSubGrupoDescricao.Name = "txtSubGrupoDescricao";
            this.txtSubGrupoDescricao.Size = new System.Drawing.Size(150, 20);
            this.txtSubGrupoDescricao.TabIndex = 66;
            // 
            // txtInfAdicionais
            // 
            this.txtInfAdicionais.BackColor = System.Drawing.Color.White;
            this.txtInfAdicionais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInfAdicionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfAdicionais.Location = new System.Drawing.Point(146, 110);
            this.txtInfAdicionais.Name = "txtInfAdicionais";
            this.txtInfAdicionais.Size = new System.Drawing.Size(491, 20);
            this.txtInfAdicionais.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(144, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Inf. Adicionais";
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.BackColor = System.Drawing.Color.White;
            this.txtDataCadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataCadastro.Enabled = false;
            this.txtDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataCadastro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDataCadastro.Location = new System.Drawing.Point(512, 32);
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(82, 20);
            this.txtDataCadastro.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(510, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Data Cadastro";
            // 
            // txtCodFabricante
            // 
            this.txtCodFabricante.BackColor = System.Drawing.Color.White;
            this.txtCodFabricante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFabricante.Location = new System.Drawing.Point(14, 110);
            this.txtCodFabricante.Name = "txtCodFabricante";
            this.txtCodFabricante.Size = new System.Drawing.Size(124, 20);
            this.txtCodFabricante.TabIndex = 61;
            // 
            // lbCodFabricante
            // 
            this.lbCodFabricante.AutoSize = true;
            this.lbCodFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodFabricante.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbCodFabricante.Location = new System.Drawing.Point(11, 94);
            this.lbCodFabricante.Name = "lbCodFabricante";
            this.lbCodFabricante.Size = new System.Drawing.Size(93, 13);
            this.lbCodFabricante.TabIndex = 60;
            this.lbCodFabricante.Text = "Código Fabricante";
            // 
            // txtMarcaId
            // 
            this.txtMarcaId.BackColor = System.Drawing.Color.White;
            this.txtMarcaId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarcaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaId.Location = new System.Drawing.Point(433, 71);
            this.txtMarcaId.Name = "txtMarcaId";
            this.txtMarcaId.Size = new System.Drawing.Size(55, 20);
            this.txtMarcaId.TabIndex = 59;
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbMarca.Location = new System.Drawing.Point(431, 55);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(37, 13);
            this.lbMarca.TabIndex = 58;
            this.lbMarca.Text = "Marca";
            // 
            // txtSubGrupoId
            // 
            this.txtSubGrupoId.BackColor = System.Drawing.Color.White;
            this.txtSubGrupoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubGrupoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubGrupoId.Location = new System.Drawing.Point(223, 71);
            this.txtSubGrupoId.Name = "txtSubGrupoId";
            this.txtSubGrupoId.Size = new System.Drawing.Size(55, 20);
            this.txtSubGrupoId.TabIndex = 57;
            // 
            // lbSubGrupo
            // 
            this.lbSubGrupo.AutoSize = true;
            this.lbSubGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubGrupo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbSubGrupo.Location = new System.Drawing.Point(221, 55);
            this.lbSubGrupo.Name = "lbSubGrupo";
            this.lbSubGrupo.Size = new System.Drawing.Size(55, 13);
            this.lbSubGrupo.TabIndex = 56;
            this.lbSubGrupo.Text = "SubGrupo";
            // 
            // txtGrupoId
            // 
            this.txtGrupoId.BackColor = System.Drawing.Color.White;
            this.txtGrupoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrupoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrupoId.Location = new System.Drawing.Point(13, 71);
            this.txtGrupoId.Name = "txtGrupoId";
            this.txtGrupoId.Size = new System.Drawing.Size(55, 20);
            this.txtGrupoId.TabIndex = 55;
            // 
            // lbGrupo
            // 
            this.lbGrupo.AutoSize = true;
            this.lbGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrupo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbGrupo.Location = new System.Drawing.Point(11, 55);
            this.lbGrupo.Name = "lbGrupo";
            this.lbGrupo.Size = new System.Drawing.Size(36, 13);
            this.lbGrupo.TabIndex = 54;
            this.lbGrupo.Text = "Grupo";
            // 
            // lbAtivo
            // 
            this.lbAtivo.AutoSize = true;
            this.lbAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAtivo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbAtivo.Location = new System.Drawing.Point(600, 16);
            this.lbAtivo.Name = "lbAtivo";
            this.lbAtivo.Size = new System.Drawing.Size(37, 13);
            this.lbAtivo.TabIndex = 53;
            this.lbAtivo.Text = "Ativo?";
            // 
            // cbAtivo
            // 
            this.cbAtivo.BackColor = System.Drawing.Color.Transparent;
            this.cbAtivo.Checked = true;
            this.cbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAtivo.FlatAppearance.BorderSize = 0;
            this.cbAtivo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.cbAtivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbAtivo.Location = new System.Drawing.Point(600, 35);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(14, 14);
            this.cbAtivo.TabIndex = 52;
            this.cbAtivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbAtivo.UseVisualStyleBackColor = false;
            // 
            // txtProdutoDescricao
            // 
            this.txtProdutoDescricao.BackColor = System.Drawing.Color.White;
            this.txtProdutoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdutoDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdutoDescricao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtProdutoDescricao.Location = new System.Drawing.Point(79, 32);
            this.txtProdutoDescricao.Name = "txtProdutoDescricao";
            this.txtProdutoDescricao.Size = new System.Drawing.Size(427, 20);
            this.txtProdutoDescricao.TabIndex = 51;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbDescricao.Location = new System.Drawing.Point(77, 16);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbDescricao.TabIndex = 50;
            this.lbDescricao.Text = "Descrição";
            // 
            // txtProdutoId
            // 
            this.txtProdutoId.BackColor = System.Drawing.Color.White;
            this.txtProdutoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdutoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdutoId.Location = new System.Drawing.Point(13, 32);
            this.txtProdutoId.Name = "txtProdutoId";
            this.txtProdutoId.Size = new System.Drawing.Size(60, 20);
            this.txtProdutoId.TabIndex = 49;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbId.Location = new System.Drawing.Point(11, 16);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(16, 13);
            this.lbId.TabIndex = 48;
            this.lbId.Text = "Id";
            // 
            // FormEstProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(670, 354);
            this.Name = "FormEstProduto";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlNomeRotina.ResumeLayout(false);
            this.pnlAcoesMenu.ResumeLayout(false);
            this.pnlAcoesMenu.PerformLayout();
            this.pnlAcoesRodape.ResumeLayout(false);
            this.boxEstoque.ResumeLayout(false);
            this.boxEstoque.PerformLayout();
            this.BoxPreco.ResumeLayout(false);
            this.BoxPreco.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BoxPreco;
        private System.Windows.Forms.GroupBox boxEstoque;
        public System.Windows.Forms.TextBox txtSaldoEstoque;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtQtdeEstMax;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtQtdeEstIdeal;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtQtdeEstMin;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtUnidadeMedida;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPrecoAnterior;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtPrecoAtual;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtMarcaDescricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtGrupoDescricao;
        public System.Windows.Forms.TextBox txtSubGrupoDescricao;
        public System.Windows.Forms.TextBox txtInfAdicionais;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtDataCadastro;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCodFabricante;
        private System.Windows.Forms.Label lbCodFabricante;
        public System.Windows.Forms.TextBox txtMarcaId;
        private System.Windows.Forms.Label lbMarca;
        public System.Windows.Forms.TextBox txtSubGrupoId;
        private System.Windows.Forms.Label lbSubGrupo;
        public System.Windows.Forms.TextBox txtGrupoId;
        private System.Windows.Forms.Label lbGrupo;
        private System.Windows.Forms.Label lbAtivo;
        public System.Windows.Forms.CheckBox cbAtivo;
        public System.Windows.Forms.TextBox txtProdutoDescricao;
        private System.Windows.Forms.Label lbDescricao;
        public System.Windows.Forms.TextBox txtProdutoId;
        private System.Windows.Forms.Label lbId;
    }
}
