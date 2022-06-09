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
            this.txtProdutoId = new LaPizza.Controllers.LpText();
            this.BoxInformacoesGerais = new System.Windows.Forms.GroupBox();
            this.lbInfAdicionais = new System.Windows.Forms.Label();
            this.txtInfAdicionais = new LaPizza.Controllers.LpText();
            this.lbCodigoFabricante = new System.Windows.Forms.Label();
            this.txtCodigoFabricante = new LaPizza.Controllers.LpText();
            this.lbMarcaDescricao = new System.Windows.Forms.Label();
            this.lbSubgrupoDescricao = new System.Windows.Forms.Label();
            this.txtSubgrupoDescricao = new LaPizza.Controllers.LpText();
            this.txtMarcaDescricao = new LaPizza.Controllers.LpText();
            this.lbSubgrupo = new System.Windows.Forms.Label();
            this.lbMarcaId = new System.Windows.Forms.Label();
            this.txtSubgrupoId = new LaPizza.Controllers.LpText();
            this.txtMarcaId = new LaPizza.Controllers.LpText();
            this.lbGrupoDescricao = new System.Windows.Forms.Label();
            this.txtGrupoDescricao = new LaPizza.Controllers.LpText();
            this.lbGrupo = new System.Windows.Forms.Label();
            this.txtGrupoId = new LaPizza.Controllers.LpText();
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.lbDataCadastro = new System.Windows.Forms.Label();
            this.txtDataCadastro = new LaPizza.Controllers.LpText();
            this.lbProdutoDescricao = new System.Windows.Forms.Label();
            this.txtProdutoDescricao = new LaPizza.Controllers.LpText();
            this.lbProdutoId = new System.Windows.Forms.Label();
            this.BoxEstoque = new System.Windows.Forms.GroupBox();
            this.lbQtdeEstMax = new System.Windows.Forms.Label();
            this.txtQtdeEstMax = new LaPizza.Controllers.LpText();
            this.lbQtdeEstIdeal = new System.Windows.Forms.Label();
            this.txtQtdeEstIdeal = new LaPizza.Controllers.LpText();
            this.lbQtdeEstMin = new System.Windows.Forms.Label();
            this.txtQtdeEstMin = new LaPizza.Controllers.LpText();
            this.lbUnidadeMedida = new System.Windows.Forms.Label();
            this.txtUnidadeMedida = new LaPizza.Controllers.LpText();
            this.lbSaldoEstoque = new System.Windows.Forms.Label();
            this.txtSaldoEstoque = new LaPizza.Controllers.LpText();
            this.BoxPrecos = new System.Windows.Forms.GroupBox();
            this.lbPrecoAnterior = new System.Windows.Forms.Label();
            this.lbPrecoAtual = new System.Windows.Forms.Label();
            this.txtPrecoAnterior = new LaPizza.Controllers.LpText();
            this.txtPrecoAtual = new LaPizza.Controllers.LpText();
            this.pnlPrincipal.SuspendLayout();
            this.pnlNomeRotina.SuspendLayout();
            this.pnlAcoesMenu.SuspendLayout();
            this.pnlAcoesRodape.SuspendLayout();
            this.BoxInformacoesGerais.SuspendLayout();
            this.BoxEstoque.SuspendLayout();
            this.BoxPrecos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.BoxPrecos);
            this.pnlPrincipal.Controls.Add(this.BoxEstoque);
            this.pnlPrincipal.Controls.Add(this.BoxInformacoesGerais);
            this.pnlPrincipal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlPrincipal.Padding = new System.Windows.Forms.Padding(5);
            this.pnlPrincipal.Size = new System.Drawing.Size(670, 215);
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
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 294);
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
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(560, 5);
            // 
            // txtProdutoId
            // 
            this.txtProdutoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdutoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProdutoId.ForeColor = System.Drawing.Color.Black;
            this.txtProdutoId.Location = new System.Drawing.Point(7, 32);
            this.txtProdutoId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtProdutoId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtProdutoId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Integer;
            this.txtProdutoId.Name = "txtProdutoId";
            this.txtProdutoId.Size = new System.Drawing.Size(71, 20);
            this.txtProdutoId.TabIndex = 12;
            // 
            // BoxInformacoesGerais
            // 
            this.BoxInformacoesGerais.Controls.Add(this.lbInfAdicionais);
            this.BoxInformacoesGerais.Controls.Add(this.txtInfAdicionais);
            this.BoxInformacoesGerais.Controls.Add(this.lbCodigoFabricante);
            this.BoxInformacoesGerais.Controls.Add(this.txtCodigoFabricante);
            this.BoxInformacoesGerais.Controls.Add(this.lbMarcaDescricao);
            this.BoxInformacoesGerais.Controls.Add(this.lbSubgrupoDescricao);
            this.BoxInformacoesGerais.Controls.Add(this.txtSubgrupoDescricao);
            this.BoxInformacoesGerais.Controls.Add(this.txtMarcaDescricao);
            this.BoxInformacoesGerais.Controls.Add(this.lbSubgrupo);
            this.BoxInformacoesGerais.Controls.Add(this.lbMarcaId);
            this.BoxInformacoesGerais.Controls.Add(this.txtSubgrupoId);
            this.BoxInformacoesGerais.Controls.Add(this.txtMarcaId);
            this.BoxInformacoesGerais.Controls.Add(this.lbGrupoDescricao);
            this.BoxInformacoesGerais.Controls.Add(this.txtGrupoDescricao);
            this.BoxInformacoesGerais.Controls.Add(this.lbGrupo);
            this.BoxInformacoesGerais.Controls.Add(this.txtGrupoId);
            this.BoxInformacoesGerais.Controls.Add(this.cbAtivo);
            this.BoxInformacoesGerais.Controls.Add(this.lbDataCadastro);
            this.BoxInformacoesGerais.Controls.Add(this.txtDataCadastro);
            this.BoxInformacoesGerais.Controls.Add(this.lbProdutoDescricao);
            this.BoxInformacoesGerais.Controls.Add(this.txtProdutoDescricao);
            this.BoxInformacoesGerais.Controls.Add(this.lbProdutoId);
            this.BoxInformacoesGerais.Controls.Add(this.txtProdutoId);
            this.BoxInformacoesGerais.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoxInformacoesGerais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxInformacoesGerais.Location = new System.Drawing.Point(5, 5);
            this.BoxInformacoesGerais.Name = "BoxInformacoesGerais";
            this.BoxInformacoesGerais.Size = new System.Drawing.Size(660, 138);
            this.BoxInformacoesGerais.TabIndex = 13;
            this.BoxInformacoesGerais.TabStop = false;
            this.BoxInformacoesGerais.Text = "Informações Gerais";
            // 
            // lbInfAdicionais
            // 
            this.lbInfAdicionais.AutoSize = true;
            this.lbInfAdicionais.Location = new System.Drawing.Point(227, 94);
            this.lbInfAdicionais.Name = "lbInfAdicionais";
            this.lbInfAdicionais.Size = new System.Drawing.Size(116, 13);
            this.lbInfAdicionais.TabIndex = 34;
            this.lbInfAdicionais.Text = "Informações Adicionais";
            // 
            // txtInfAdicionais
            // 
            this.txtInfAdicionais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInfAdicionais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInfAdicionais.ForeColor = System.Drawing.Color.Black;
            this.txtInfAdicionais.Location = new System.Drawing.Point(230, 110);
            this.txtInfAdicionais.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtInfAdicionais.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtInfAdicionais.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtInfAdicionais.Name = "txtInfAdicionais";
            this.txtInfAdicionais.Size = new System.Drawing.Size(423, 20);
            this.txtInfAdicionais.TabIndex = 33;
            // 
            // lbCodigoFabricante
            // 
            this.lbCodigoFabricante.AutoSize = true;
            this.lbCodigoFabricante.Location = new System.Drawing.Point(3, 94);
            this.lbCodigoFabricante.Name = "lbCodigoFabricante";
            this.lbCodigoFabricante.Size = new System.Drawing.Size(82, 13);
            this.lbCodigoFabricante.TabIndex = 32;
            this.lbCodigoFabricante.Text = "Cód. Fabricante";
            // 
            // txtCodigoFabricante
            // 
            this.txtCodigoFabricante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoFabricante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoFabricante.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoFabricante.Location = new System.Drawing.Point(6, 110);
            this.txtCodigoFabricante.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtCodigoFabricante.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtCodigoFabricante.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtCodigoFabricante.Name = "txtCodigoFabricante";
            this.txtCodigoFabricante.Size = new System.Drawing.Size(215, 20);
            this.txtCodigoFabricante.TabIndex = 31;
            // 
            // lbMarcaDescricao
            // 
            this.lbMarcaDescricao.AutoSize = true;
            this.lbMarcaDescricao.Location = new System.Drawing.Point(498, 55);
            this.lbMarcaDescricao.Name = "lbMarcaDescricao";
            this.lbMarcaDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbMarcaDescricao.TabIndex = 30;
            this.lbMarcaDescricao.Text = "Descrição";
            // 
            // lbSubgrupoDescricao
            // 
            this.lbSubgrupoDescricao.AutoSize = true;
            this.lbSubgrupoDescricao.Location = new System.Drawing.Point(294, 55);
            this.lbSubgrupoDescricao.Name = "lbSubgrupoDescricao";
            this.lbSubgrupoDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbSubgrupoDescricao.TabIndex = 26;
            this.lbSubgrupoDescricao.Text = "Descrição";
            // 
            // txtSubgrupoDescricao
            // 
            this.txtSubgrupoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubgrupoDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubgrupoDescricao.Enabled = false;
            this.txtSubgrupoDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtSubgrupoDescricao.Location = new System.Drawing.Point(297, 71);
            this.txtSubgrupoDescricao.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtSubgrupoDescricao.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtSubgrupoDescricao.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtSubgrupoDescricao.Name = "txtSubgrupoDescricao";
            this.txtSubgrupoDescricao.Size = new System.Drawing.Size(144, 20);
            this.txtSubgrupoDescricao.TabIndex = 25;
            // 
            // txtMarcaDescricao
            // 
            this.txtMarcaDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarcaDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarcaDescricao.Enabled = false;
            this.txtMarcaDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtMarcaDescricao.Location = new System.Drawing.Point(501, 71);
            this.txtMarcaDescricao.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtMarcaDescricao.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtMarcaDescricao.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtMarcaDescricao.Name = "txtMarcaDescricao";
            this.txtMarcaDescricao.Size = new System.Drawing.Size(152, 20);
            this.txtMarcaDescricao.TabIndex = 29;
            // 
            // lbSubgrupo
            // 
            this.lbSubgrupo.AutoSize = true;
            this.lbSubgrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubgrupo.Location = new System.Drawing.Point(224, 55);
            this.lbSubgrupo.Name = "lbSubgrupo";
            this.lbSubgrupo.Size = new System.Drawing.Size(71, 13);
            this.lbSubgrupo.TabIndex = 24;
            this.lbSubgrupo.Text = "Subgrupo(F2)";
            // 
            // lbMarcaId
            // 
            this.lbMarcaId.AutoSize = true;
            this.lbMarcaId.Location = new System.Drawing.Point(444, 55);
            this.lbMarcaId.Name = "lbMarcaId";
            this.lbMarcaId.Size = new System.Drawing.Size(55, 13);
            this.lbMarcaId.TabIndex = 28;
            this.lbMarcaId.Text = "Marca(F2)";
            // 
            // txtSubgrupoId
            // 
            this.txtSubgrupoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubgrupoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubgrupoId.ForeColor = System.Drawing.Color.Black;
            this.txtSubgrupoId.Location = new System.Drawing.Point(227, 71);
            this.txtSubgrupoId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtSubgrupoId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtSubgrupoId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Integer;
            this.txtSubgrupoId.Name = "txtSubgrupoId";
            this.txtSubgrupoId.Size = new System.Drawing.Size(71, 20);
            this.txtSubgrupoId.TabIndex = 23;
            this.txtSubgrupoId.TextChanged += new System.EventHandler(this.txtSubgrupoId_TextChanged);
            this.txtSubgrupoId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSubgrupoId_KeyUp);
            // 
            // txtMarcaId
            // 
            this.txtMarcaId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarcaId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarcaId.ForeColor = System.Drawing.Color.Black;
            this.txtMarcaId.Location = new System.Drawing.Point(447, 71);
            this.txtMarcaId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtMarcaId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtMarcaId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Integer;
            this.txtMarcaId.Name = "txtMarcaId";
            this.txtMarcaId.Size = new System.Drawing.Size(55, 20);
            this.txtMarcaId.TabIndex = 27;
            this.txtMarcaId.TextChanged += new System.EventHandler(this.txtMarcaId_TextChanged);
            this.txtMarcaId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMarcaId_KeyUp);
            // 
            // lbGrupoDescricao
            // 
            this.lbGrupoDescricao.AutoSize = true;
            this.lbGrupoDescricao.Location = new System.Drawing.Point(58, 55);
            this.lbGrupoDescricao.Name = "lbGrupoDescricao";
            this.lbGrupoDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbGrupoDescricao.TabIndex = 22;
            this.lbGrupoDescricao.Text = "Descrição";
            // 
            // txtGrupoDescricao
            // 
            this.txtGrupoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrupoDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGrupoDescricao.Enabled = false;
            this.txtGrupoDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtGrupoDescricao.Location = new System.Drawing.Point(61, 71);
            this.txtGrupoDescricao.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtGrupoDescricao.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtGrupoDescricao.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtGrupoDescricao.Name = "txtGrupoDescricao";
            this.txtGrupoDescricao.Size = new System.Drawing.Size(160, 20);
            this.txtGrupoDescricao.TabIndex = 21;
            this.txtGrupoDescricao.TextChanged += new System.EventHandler(this.txtGrupoDescricao_TextChanged);
            // 
            // lbGrupo
            // 
            this.lbGrupo.AutoSize = true;
            this.lbGrupo.Location = new System.Drawing.Point(4, 55);
            this.lbGrupo.Name = "lbGrupo";
            this.lbGrupo.Size = new System.Drawing.Size(54, 13);
            this.lbGrupo.TabIndex = 20;
            this.lbGrupo.Text = "Grupo(F2)";
            // 
            // txtGrupoId
            // 
            this.txtGrupoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrupoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGrupoId.ForeColor = System.Drawing.Color.Black;
            this.txtGrupoId.Location = new System.Drawing.Point(7, 71);
            this.txtGrupoId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtGrupoId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtGrupoId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Integer;
            this.txtGrupoId.Name = "txtGrupoId";
            this.txtGrupoId.Size = new System.Drawing.Size(55, 20);
            this.txtGrupoId.TabIndex = 19;
            this.txtGrupoId.TextChanged += new System.EventHandler(this.txtGrupoId_TextChanged);
            this.txtGrupoId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGrupoId_KeyUp);
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Location = new System.Drawing.Point(601, 32);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.cbAtivo.Size = new System.Drawing.Size(56, 19);
            this.cbAtivo.TabIndex = 18;
            this.cbAtivo.Text = "Ativo?";
            this.cbAtivo.UseVisualStyleBackColor = true;
            // 
            // lbDataCadastro
            // 
            this.lbDataCadastro.AutoSize = true;
            this.lbDataCadastro.Location = new System.Drawing.Point(498, 16);
            this.lbDataCadastro.Name = "lbDataCadastro";
            this.lbDataCadastro.Size = new System.Drawing.Size(75, 13);
            this.lbDataCadastro.TabIndex = 17;
            this.lbDataCadastro.Text = "Data Cadastro";
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataCadastro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDataCadastro.ForeColor = System.Drawing.Color.Black;
            this.txtDataCadastro.Location = new System.Drawing.Point(502, 32);
            this.txtDataCadastro.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtDataCadastro.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtDataCadastro.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Date;
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(93, 20);
            this.txtDataCadastro.TabIndex = 16;
            this.txtDataCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbProdutoDescricao
            // 
            this.lbProdutoDescricao.AutoSize = true;
            this.lbProdutoDescricao.Location = new System.Drawing.Point(81, 16);
            this.lbProdutoDescricao.Name = "lbProdutoDescricao";
            this.lbProdutoDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbProdutoDescricao.TabIndex = 15;
            this.lbProdutoDescricao.Text = "Descrição";
            // 
            // txtProdutoDescricao
            // 
            this.txtProdutoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdutoDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProdutoDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtProdutoDescricao.Location = new System.Drawing.Point(84, 32);
            this.txtProdutoDescricao.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtProdutoDescricao.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtProdutoDescricao.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtProdutoDescricao.Name = "txtProdutoDescricao";
            this.txtProdutoDescricao.Size = new System.Drawing.Size(412, 20);
            this.txtProdutoDescricao.TabIndex = 14;
            this.txtProdutoDescricao.TextChanged += new System.EventHandler(this.txtProdutoDescricao_TextChanged);
            // 
            // lbProdutoId
            // 
            this.lbProdutoId.AutoSize = true;
            this.lbProdutoId.Location = new System.Drawing.Point(3, 16);
            this.lbProdutoId.Name = "lbProdutoId";
            this.lbProdutoId.Size = new System.Drawing.Size(16, 13);
            this.lbProdutoId.TabIndex = 13;
            this.lbProdutoId.Text = "Id";
            // 
            // BoxEstoque
            // 
            this.BoxEstoque.Controls.Add(this.lbQtdeEstMax);
            this.BoxEstoque.Controls.Add(this.txtQtdeEstMax);
            this.BoxEstoque.Controls.Add(this.lbQtdeEstIdeal);
            this.BoxEstoque.Controls.Add(this.txtQtdeEstIdeal);
            this.BoxEstoque.Controls.Add(this.lbQtdeEstMin);
            this.BoxEstoque.Controls.Add(this.txtQtdeEstMin);
            this.BoxEstoque.Controls.Add(this.lbUnidadeMedida);
            this.BoxEstoque.Controls.Add(this.txtUnidadeMedida);
            this.BoxEstoque.Controls.Add(this.lbSaldoEstoque);
            this.BoxEstoque.Controls.Add(this.txtSaldoEstoque);
            this.BoxEstoque.Dock = System.Windows.Forms.DockStyle.Left;
            this.BoxEstoque.Location = new System.Drawing.Point(5, 143);
            this.BoxEstoque.Name = "BoxEstoque";
            this.BoxEstoque.Size = new System.Drawing.Size(461, 67);
            this.BoxEstoque.TabIndex = 14;
            this.BoxEstoque.TabStop = false;
            this.BoxEstoque.Text = "Estoque";
            // 
            // lbQtdeEstMax
            // 
            this.lbQtdeEstMax.AutoSize = true;
            this.lbQtdeEstMax.Location = new System.Drawing.Point(367, 16);
            this.lbQtdeEstMax.Name = "lbQtdeEstMax";
            this.lbQtdeEstMax.Size = new System.Drawing.Size(77, 13);
            this.lbQtdeEstMax.TabIndex = 50;
            this.lbQtdeEstMax.Text = "Qtde Est. Max.";
            // 
            // txtQtdeEstMax
            // 
            this.txtQtdeEstMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdeEstMax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtdeEstMax.ForeColor = System.Drawing.Color.Black;
            this.txtQtdeEstMax.Location = new System.Drawing.Point(370, 32);
            this.txtQtdeEstMax.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtQtdeEstMax.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtQtdeEstMax.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Currency;
            this.txtQtdeEstMax.Name = "txtQtdeEstMax";
            this.txtQtdeEstMax.Size = new System.Drawing.Size(85, 20);
            this.txtQtdeEstMax.TabIndex = 49;
            this.txtQtdeEstMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbQtdeEstIdeal
            // 
            this.lbQtdeEstIdeal.AutoSize = true;
            this.lbQtdeEstIdeal.Location = new System.Drawing.Point(277, 16);
            this.lbQtdeEstIdeal.Name = "lbQtdeEstIdeal";
            this.lbQtdeEstIdeal.Size = new System.Drawing.Size(77, 13);
            this.lbQtdeEstIdeal.TabIndex = 48;
            this.lbQtdeEstIdeal.Text = "Qtde Est. Ideal";
            // 
            // txtQtdeEstIdeal
            // 
            this.txtQtdeEstIdeal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdeEstIdeal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtdeEstIdeal.ForeColor = System.Drawing.Color.Black;
            this.txtQtdeEstIdeal.Location = new System.Drawing.Point(280, 32);
            this.txtQtdeEstIdeal.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtQtdeEstIdeal.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtQtdeEstIdeal.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Currency;
            this.txtQtdeEstIdeal.Name = "txtQtdeEstIdeal";
            this.txtQtdeEstIdeal.Size = new System.Drawing.Size(85, 20);
            this.txtQtdeEstIdeal.TabIndex = 47;
            this.txtQtdeEstIdeal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbQtdeEstMin
            // 
            this.lbQtdeEstMin.AutoSize = true;
            this.lbQtdeEstMin.Location = new System.Drawing.Point(186, 16);
            this.lbQtdeEstMin.Name = "lbQtdeEstMin";
            this.lbQtdeEstMin.Size = new System.Drawing.Size(74, 13);
            this.lbQtdeEstMin.TabIndex = 46;
            this.lbQtdeEstMin.Text = "Qtde Est. Min.";
            // 
            // txtQtdeEstMin
            // 
            this.txtQtdeEstMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdeEstMin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtdeEstMin.ForeColor = System.Drawing.Color.Black;
            this.txtQtdeEstMin.Location = new System.Drawing.Point(189, 32);
            this.txtQtdeEstMin.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtQtdeEstMin.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtQtdeEstMin.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Currency;
            this.txtQtdeEstMin.Name = "txtQtdeEstMin";
            this.txtQtdeEstMin.Size = new System.Drawing.Size(85, 20);
            this.txtQtdeEstMin.TabIndex = 45;
            this.txtQtdeEstMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbUnidadeMedida
            // 
            this.lbUnidadeMedida.AutoSize = true;
            this.lbUnidadeMedida.Location = new System.Drawing.Point(95, 16);
            this.lbUnidadeMedida.Name = "lbUnidadeMedida";
            this.lbUnidadeMedida.Size = new System.Drawing.Size(62, 13);
            this.lbUnidadeMedida.TabIndex = 44;
            this.lbUnidadeMedida.Text = "Un. Medida";
            // 
            // txtUnidadeMedida
            // 
            this.txtUnidadeMedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnidadeMedida.ForeColor = System.Drawing.Color.Black;
            this.txtUnidadeMedida.Location = new System.Drawing.Point(98, 32);
            this.txtUnidadeMedida.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtUnidadeMedida.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtUnidadeMedida.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtUnidadeMedida.Name = "txtUnidadeMedida";
            this.txtUnidadeMedida.Size = new System.Drawing.Size(85, 20);
            this.txtUnidadeMedida.TabIndex = 43;
            this.txtUnidadeMedida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbSaldoEstoque
            // 
            this.lbSaldoEstoque.AutoSize = true;
            this.lbSaldoEstoque.Location = new System.Drawing.Point(4, 16);
            this.lbSaldoEstoque.Name = "lbSaldoEstoque";
            this.lbSaldoEstoque.Size = new System.Drawing.Size(76, 13);
            this.lbSaldoEstoque.TabIndex = 42;
            this.lbSaldoEstoque.Text = "Saldo Estoque";
            // 
            // txtSaldoEstoque
            // 
            this.txtSaldoEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaldoEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaldoEstoque.ForeColor = System.Drawing.Color.Black;
            this.txtSaldoEstoque.Location = new System.Drawing.Point(7, 32);
            this.txtSaldoEstoque.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtSaldoEstoque.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtSaldoEstoque.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Currency;
            this.txtSaldoEstoque.Name = "txtSaldoEstoque";
            this.txtSaldoEstoque.Size = new System.Drawing.Size(85, 20);
            this.txtSaldoEstoque.TabIndex = 41;
            this.txtSaldoEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BoxPrecos
            // 
            this.BoxPrecos.Controls.Add(this.lbPrecoAnterior);
            this.BoxPrecos.Controls.Add(this.lbPrecoAtual);
            this.BoxPrecos.Controls.Add(this.txtPrecoAnterior);
            this.BoxPrecos.Controls.Add(this.txtPrecoAtual);
            this.BoxPrecos.Dock = System.Windows.Forms.DockStyle.Right;
            this.BoxPrecos.Location = new System.Drawing.Point(472, 143);
            this.BoxPrecos.Name = "BoxPrecos";
            this.BoxPrecos.Size = new System.Drawing.Size(193, 67);
            this.BoxPrecos.TabIndex = 15;
            this.BoxPrecos.TabStop = false;
            this.BoxPrecos.Text = "Preços";
            // 
            // lbPrecoAnterior
            // 
            this.lbPrecoAnterior.AutoSize = true;
            this.lbPrecoAnterior.Location = new System.Drawing.Point(3, 16);
            this.lbPrecoAnterior.Name = "lbPrecoAnterior";
            this.lbPrecoAnterior.Size = new System.Drawing.Size(74, 13);
            this.lbPrecoAnterior.TabIndex = 40;
            this.lbPrecoAnterior.Text = "Preço Anterior";
            // 
            // lbPrecoAtual
            // 
            this.lbPrecoAtual.AutoSize = true;
            this.lbPrecoAtual.Location = new System.Drawing.Point(95, 16);
            this.lbPrecoAtual.Name = "lbPrecoAtual";
            this.lbPrecoAtual.Size = new System.Drawing.Size(62, 13);
            this.lbPrecoAtual.TabIndex = 38;
            this.lbPrecoAtual.Text = "Preço Atual";
            // 
            // txtPrecoAnterior
            // 
            this.txtPrecoAnterior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoAnterior.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecoAnterior.Enabled = false;
            this.txtPrecoAnterior.ForeColor = System.Drawing.Color.Black;
            this.txtPrecoAnterior.Location = new System.Drawing.Point(6, 32);
            this.txtPrecoAnterior.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtPrecoAnterior.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtPrecoAnterior.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Currency;
            this.txtPrecoAnterior.Name = "txtPrecoAnterior";
            this.txtPrecoAnterior.Size = new System.Drawing.Size(87, 20);
            this.txtPrecoAnterior.TabIndex = 39;
            this.txtPrecoAnterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrecoAtual
            // 
            this.txtPrecoAtual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoAtual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecoAtual.ForeColor = System.Drawing.Color.Black;
            this.txtPrecoAtual.Location = new System.Drawing.Point(98, 32);
            this.txtPrecoAtual.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtPrecoAtual.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtPrecoAtual.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Currency;
            this.txtPrecoAtual.Name = "txtPrecoAtual";
            this.txtPrecoAtual.Size = new System.Drawing.Size(87, 20);
            this.txtPrecoAtual.TabIndex = 37;
            this.txtPrecoAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormEstProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(670, 334);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "FormEstProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlNomeRotina.ResumeLayout(false);
            this.pnlAcoesMenu.ResumeLayout(false);
            this.pnlAcoesMenu.PerformLayout();
            this.pnlAcoesRodape.ResumeLayout(false);
            this.BoxInformacoesGerais.ResumeLayout(false);
            this.BoxInformacoesGerais.PerformLayout();
            this.BoxEstoque.ResumeLayout(false);
            this.BoxEstoque.PerformLayout();
            this.BoxPrecos.ResumeLayout(false);
            this.BoxPrecos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbProdutoDescricao;
        private System.Windows.Forms.Label lbProdutoId;
        private System.Windows.Forms.Label lbDataCadastro;
        private System.Windows.Forms.Label lbMarcaDescricao;
        private System.Windows.Forms.Label lbSubgrupoDescricao;
        private System.Windows.Forms.Label lbSubgrupo;
        private System.Windows.Forms.Label lbMarcaId;
        private System.Windows.Forms.Label lbGrupoDescricao;
        private System.Windows.Forms.Label lbGrupo;
        private System.Windows.Forms.GroupBox BoxInformacoesGerais;
        private System.Windows.Forms.Label lbInfAdicionais;
        private System.Windows.Forms.Label lbCodigoFabricante;
        private System.Windows.Forms.GroupBox BoxPrecos;
        private System.Windows.Forms.Label lbPrecoAnterior;
        private System.Windows.Forms.Label lbPrecoAtual;
        private System.Windows.Forms.GroupBox BoxEstoque;
        private System.Windows.Forms.Label lbQtdeEstMax;
        private System.Windows.Forms.Label lbQtdeEstIdeal;
        private System.Windows.Forms.Label lbQtdeEstMin;
        private System.Windows.Forms.Label lbUnidadeMedida;
        private System.Windows.Forms.Label lbSaldoEstoque;
        public Controllers.LpText txtProdutoId;
        public Controllers.LpText txtProdutoDescricao;
        public Controllers.LpText txtDataCadastro;
        public Controllers.LpText txtSubgrupoDescricao;
        public Controllers.LpText txtMarcaDescricao;
        public Controllers.LpText txtSubgrupoId;
        public Controllers.LpText txtMarcaId;
        public Controllers.LpText txtGrupoDescricao;
        public Controllers.LpText txtGrupoId;
        public Controllers.LpText txtInfAdicionais;
        public Controllers.LpText txtCodigoFabricante;
        public Controllers.LpText txtPrecoAnterior;
        public Controllers.LpText txtPrecoAtual;
        public Controllers.LpText txtQtdeEstMax;
        public Controllers.LpText txtQtdeEstIdeal;
        public Controllers.LpText txtQtdeEstMin;
        public Controllers.LpText txtUnidadeMedida;
        public Controllers.LpText txtSaldoEstoque;
        public System.Windows.Forms.CheckBox cbAtivo;
    }
}
