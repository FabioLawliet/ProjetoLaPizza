namespace LaPizza.Views.PesquisasAnaliticas
{
    partial class PesqAnaliticaFornecedores
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
            this.GridFornecedor = new System.Windows.Forms.DataGridView();
            this.fornecedorid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerazao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfcnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadosigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxFiltro = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCidadeId = new LaPizza.Controllers.LpText();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeCidade = new LaPizza.Controllers.LpText();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.idfornecedor = new System.Windows.Forms.Label();
            this.txtFornecedorId = new LaPizza.Controllers.LpText();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPesquisarAtivos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoOrdenacao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeFornecedor = new LaPizza.Controllers.LpText();
            this.pnlPrincipal.SuspendLayout();
            this.pnlNomeRotina.SuspendLayout();
            this.pnlAcoesRodape.SuspendLayout();
            this.pnlAcoesMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFornecedor)).BeginInit();
            this.BoxFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.BoxFiltro);
            this.pnlPrincipal.Controls.Add(this.GridFornecedor);
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 59);
            this.pnlPrincipal.Size = new System.Drawing.Size(1048, 571);
            // 
            // pnlNomeRotina
            // 
            this.pnlNomeRotina.Size = new System.Drawing.Size(1048, 49);
            // 
            // btnAcaoAdicionar
            // 
            this.btnAcaoAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAcaoAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.Location = new System.Drawing.Point(860, 6);
            // 
            // btnAcaoEditar
            // 
            this.btnAcaoEditar.FlatAppearance.BorderSize = 0;
            this.btnAcaoEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.Location = new System.Drawing.Point(907, 6);
            // 
            // btnAcaoConsultar
            // 
            this.btnAcaoConsultar.FlatAppearance.BorderSize = 0;
            this.btnAcaoConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.Location = new System.Drawing.Point(954, 6);
            // 
            // lbNomeRotina
            // 
            this.lbNomeRotina.Size = new System.Drawing.Size(1048, 49);
            this.lbNomeRotina.Text = "Pesquisa Fornecedores";
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 630);
            this.pnlAcoesRodape.Size = new System.Drawing.Size(1048, 49);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.Location = new System.Drawing.Point(848, 6);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSair.Location = new System.Drawing.Point(948, 6);
            // 
            // btnAcaoExcluir
            // 
            this.btnAcaoExcluir.FlatAppearance.BorderSize = 0;
            this.btnAcaoExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.Location = new System.Drawing.Point(1001, 6);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(748, 6);
            this.btnConfirmar.Visible = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(900, 6);
            this.splitter3.Size = new System.Drawing.Size(7, 0);
            // 
            // pnlAcoesMenu
            // 
            this.pnlAcoesMenu.Size = new System.Drawing.Size(1048, 10);
            this.pnlAcoesMenu.Visible = false;
            // 
            // GridFornecedor
            // 
            this.GridFornecedor.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fornecedorid,
            this.nomerazao,
            this.rgie,
            this.cpfcnpj,
            this.endereco,
            this.numero,
            this.bairro,
            this.complemento,
            this.cep,
            this.idcidade,
            this.nome,
            this.estadosigla,
            this.telefone,
            this.celular,
            this.email,
            this.ativo});
            this.GridFornecedor.Location = new System.Drawing.Point(6, 96);
            this.GridFornecedor.Name = "GridFornecedor";
            this.GridFornecedor.RowHeadersWidth = 51;
            this.GridFornecedor.RowTemplate.Height = 24;
            this.GridFornecedor.Size = new System.Drawing.Size(1034, 522);
            this.GridFornecedor.TabIndex = 1;
            // 
            // fornecedorid
            // 
            this.fornecedorid.DataPropertyName = "idfornecedor";
            this.fornecedorid.HeaderText = "Fornecedor";
            this.fornecedorid.MinimumWidth = 6;
            this.fornecedorid.Name = "fornecedorid";
            this.fornecedorid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fornecedorid.Width = 125;
            // 
            // nomerazao
            // 
            this.nomerazao.DataPropertyName = "nomerazao";
            this.nomerazao.HeaderText = "Nome Fornecedor";
            this.nomerazao.MinimumWidth = 6;
            this.nomerazao.Name = "nomerazao";
            this.nomerazao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nomerazao.Width = 125;
            // 
            // rgie
            // 
            this.rgie.DataPropertyName = "rgie";
            this.rgie.HeaderText = "RG / Insc. Estadual";
            this.rgie.MinimumWidth = 6;
            this.rgie.Name = "rgie";
            this.rgie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.rgie.Width = 125;
            // 
            // cpfcnpj
            // 
            this.cpfcnpj.DataPropertyName = "cpfcnpj";
            this.cpfcnpj.HeaderText = "CPF / CNPJ";
            this.cpfcnpj.MinimumWidth = 6;
            this.cpfcnpj.Name = "cpfcnpj";
            this.cpfcnpj.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cpfcnpj.Width = 125;
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "endereco";
            this.endereco.HeaderText = "Endereço";
            this.endereco.MinimumWidth = 6;
            this.endereco.Name = "endereco";
            this.endereco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.endereco.Width = 125;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "Numero";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.numero.Width = 125;
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "bairro";
            this.bairro.HeaderText = "Bairro";
            this.bairro.MinimumWidth = 6;
            this.bairro.Name = "bairro";
            this.bairro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bairro.Width = 125;
            // 
            // complemento
            // 
            this.complemento.DataPropertyName = "complemento";
            this.complemento.HeaderText = "Complemento";
            this.complemento.MinimumWidth = 6;
            this.complemento.Name = "complemento";
            this.complemento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.complemento.Width = 125;
            // 
            // cep
            // 
            this.cep.DataPropertyName = "cep";
            this.cep.HeaderText = "Cep";
            this.cep.MinimumWidth = 6;
            this.cep.Name = "cep";
            this.cep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cep.Width = 125;
            // 
            // idcidade
            // 
            this.idcidade.DataPropertyName = "idcidade";
            this.idcidade.HeaderText = "Cidade";
            this.idcidade.MinimumWidth = 6;
            this.idcidade.Name = "idcidade";
            this.idcidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idcidade.Width = 125;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome Cidade";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nome.Width = 125;
            // 
            // estadosigla
            // 
            this.estadosigla.DataPropertyName = "estadosigla";
            this.estadosigla.HeaderText = "Estado";
            this.estadosigla.MinimumWidth = 6;
            this.estadosigla.Name = "estadosigla";
            this.estadosigla.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estadosigla.Width = 125;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "Telefone";
            this.telefone.MinimumWidth = 6;
            this.telefone.Name = "telefone";
            this.telefone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.telefone.Width = 125;
            // 
            // celular
            // 
            this.celular.DataPropertyName = "celular";
            this.celular.HeaderText = "Celular";
            this.celular.MinimumWidth = 6;
            this.celular.Name = "celular";
            this.celular.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.celular.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "E-mail";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.email.Width = 125;
            // 
            // ativo
            // 
            this.ativo.DataPropertyName = "ativo";
            this.ativo.HeaderText = "Ativo";
            this.ativo.MinimumWidth = 6;
            this.ativo.Name = "ativo";
            this.ativo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ativo.Width = 125;
            // 
            // BoxFiltro
            // 
            this.BoxFiltro.Controls.Add(this.label4);
            this.BoxFiltro.Controls.Add(this.txtCidadeId);
            this.BoxFiltro.Controls.Add(this.label5);
            this.BoxFiltro.Controls.Add(this.txtNomeCidade);
            this.BoxFiltro.Controls.Add(this.btnPesquisar);
            this.BoxFiltro.Controls.Add(this.idfornecedor);
            this.BoxFiltro.Controls.Add(this.txtFornecedorId);
            this.BoxFiltro.Controls.Add(this.label3);
            this.BoxFiltro.Controls.Add(this.cbPesquisarAtivos);
            this.BoxFiltro.Controls.Add(this.label2);
            this.BoxFiltro.Controls.Add(this.cbTipoOrdenacao);
            this.BoxFiltro.Controls.Add(this.label1);
            this.BoxFiltro.Controls.Add(this.txtNomeFornecedor);
            this.BoxFiltro.Location = new System.Drawing.Point(6, 7);
            this.BoxFiltro.Name = "BoxFiltro";
            this.BoxFiltro.Size = new System.Drawing.Size(1034, 83);
            this.BoxFiltro.TabIndex = 14;
            this.BoxFiltro.TabStop = false;
            this.BoxFiltro.Text = "Filtro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Id (F2)";
            // 
            // txtCidadeId
            // 
            this.txtCidadeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidadeId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidadeId.ForeColor = System.Drawing.Color.Black;
            this.txtCidadeId.Location = new System.Drawing.Point(269, 36);
            this.txtCidadeId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtCidadeId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtCidadeId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtCidadeId.Name = "txtCidadeId";
            this.txtCidadeId.Size = new System.Drawing.Size(50, 22);
            this.txtCidadeId.TabIndex = 24;
            this.txtCidadeId.TextChanged += new System.EventHandler(this.txtCidadeId_TextChanged);
            this.txtCidadeId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCidadeId_KeyUp);
            this.txtCidadeId.Leave += new System.EventHandler(this.txtCidadeId_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nome Cidade";
            // 
            // txtNomeCidade
            // 
            this.txtNomeCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCidade.Enabled = false;
            this.txtNomeCidade.ForeColor = System.Drawing.Color.Black;
            this.txtNomeCidade.Location = new System.Drawing.Point(319, 36);
            this.txtNomeCidade.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtNomeCidade.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtNomeCidade.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtNomeCidade.Name = "txtNomeCidade";
            this.txtNomeCidade.Size = new System.Drawing.Size(170, 22);
            this.txtNomeCidade.TabIndex = 22;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.IndianRed;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPesquisar.Location = new System.Drawing.Point(788, 32);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(216, 31);
            this.btnPesquisar.TabIndex = 21;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // idfornecedor
            // 
            this.idfornecedor.AutoSize = true;
            this.idfornecedor.Location = new System.Drawing.Point(14, 17);
            this.idfornecedor.Name = "idfornecedor";
            this.idfornecedor.Size = new System.Drawing.Size(44, 16);
            this.idfornecedor.TabIndex = 20;
            this.idfornecedor.Text = "Id (F2)";
            // 
            // txtFornecedorId
            // 
            this.txtFornecedorId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFornecedorId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedorId.ForeColor = System.Drawing.Color.Black;
            this.txtFornecedorId.Location = new System.Drawing.Point(17, 36);
            this.txtFornecedorId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtFornecedorId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtFornecedorId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtFornecedorId.Name = "txtFornecedorId";
            this.txtFornecedorId.Size = new System.Drawing.Size(50, 22);
            this.txtFornecedorId.TabIndex = 19;
            this.txtFornecedorId.TextChanged += new System.EventHandler(this.txtFornecedorId_TextChanged);
            this.txtFornecedorId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFornecedorId_KeyUp);
            this.txtFornecedorId.Leave += new System.EventHandler(this.txtFornecedorId_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Pesquisar apenas:";
            // 
            // cbPesquisarAtivos
            // 
            this.cbPesquisarAtivos.FormattingEnabled = true;
            this.cbPesquisarAtivos.Items.AddRange(new object[] {
            "Ativos",
            "Inativos",
            "Ativos/Inativos"});
            this.cbPesquisarAtivos.Location = new System.Drawing.Point(642, 35);
            this.cbPesquisarAtivos.Name = "cbPesquisarAtivos";
            this.cbPesquisarAtivos.Size = new System.Drawing.Size(122, 24);
            this.cbPesquisarAtivos.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ordernar por:";
            // 
            // cbTipoOrdenacao
            // 
            this.cbTipoOrdenacao.FormattingEnabled = true;
            this.cbTipoOrdenacao.Items.AddRange(new object[] {
            "Cód. Cliente",
            "Nome Cliente"});
            this.cbTipoOrdenacao.Location = new System.Drawing.Point(519, 35);
            this.cbTipoOrdenacao.Name = "cbTipoOrdenacao";
            this.cbTipoOrdenacao.Size = new System.Drawing.Size(122, 24);
            this.cbTipoOrdenacao.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome / Razão";
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFornecedor.Enabled = false;
            this.txtNomeFornecedor.ForeColor = System.Drawing.Color.Black;
            this.txtNomeFornecedor.Location = new System.Drawing.Point(67, 36);
            this.txtNomeFornecedor.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtNomeFornecedor.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtNomeFornecedor.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(170, 22);
            this.txtNomeFornecedor.TabIndex = 13;
            // 
            // PesqAnaliticaFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1048, 679);
            this.Name = "PesqAnaliticaFornecedores";
            this.Text = "";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlNomeRotina.ResumeLayout(false);
            this.pnlAcoesRodape.ResumeLayout(false);
            this.pnlAcoesMenu.ResumeLayout(false);
            this.pnlAcoesMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFornecedor)).EndInit();
            this.BoxFiltro.ResumeLayout(false);
            this.BoxFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridFornecedor;
        private System.Windows.Forms.GroupBox BoxFiltro;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label idfornecedor;
        private Controllers.LpText txtFornecedorId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPesquisarAtivos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoOrdenacao;
        private System.Windows.Forms.Label label1;
        private Controllers.LpText txtNomeFornecedor;
        private System.Windows.Forms.Label label4;
        private Controllers.LpText txtCidadeId;
        private System.Windows.Forms.Label label5;
        private Controllers.LpText txtNomeCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerazao;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgie;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfcnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadosigla;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativo;
    }
}
