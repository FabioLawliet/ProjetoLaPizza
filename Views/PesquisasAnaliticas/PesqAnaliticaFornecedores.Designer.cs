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
            this.idfornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.fornecedorid = new System.Windows.Forms.Label();
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
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 48);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlPrincipal.Size = new System.Drawing.Size(786, 464);
            // 
            // pnlNomeRotina
            // 
            this.pnlNomeRotina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlNomeRotina.Size = new System.Drawing.Size(786, 40);
            // 
            // btnAcaoAdicionar
            // 
            this.btnAcaoAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAcaoAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.Location = new System.Drawing.Point(647, 4);
            this.btnAcaoAdicionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAcaoAdicionar.MaximumSize = new System.Drawing.Size(30, 32);
            this.btnAcaoAdicionar.MinimumSize = new System.Drawing.Size(22, 24);
            this.btnAcaoAdicionar.Size = new System.Drawing.Size(30, 24);
            // 
            // btnAcaoEditar
            // 
            this.btnAcaoEditar.FlatAppearance.BorderSize = 0;
            this.btnAcaoEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.Location = new System.Drawing.Point(682, 4);
            this.btnAcaoEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAcaoEditar.MaximumSize = new System.Drawing.Size(30, 32);
            this.btnAcaoEditar.MinimumSize = new System.Drawing.Size(22, 24);
            this.btnAcaoEditar.Size = new System.Drawing.Size(30, 24);
            // 
            // btnAcaoConsultar
            // 
            this.btnAcaoConsultar.FlatAppearance.BorderSize = 0;
            this.btnAcaoConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.Location = new System.Drawing.Point(717, 4);
            this.btnAcaoConsultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAcaoConsultar.MaximumSize = new System.Drawing.Size(30, 32);
            this.btnAcaoConsultar.MinimumSize = new System.Drawing.Size(22, 24);
            this.btnAcaoConsultar.Size = new System.Drawing.Size(30, 24);
            // 
            // lbNomeRotina
            // 
            this.lbNomeRotina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNomeRotina.Size = new System.Drawing.Size(786, 40);
            this.lbNomeRotina.Text = "Pesquisa Fornecedores";
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 512);
            this.pnlAcoesRodape.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAcoesRodape.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAcoesRodape.Size = new System.Drawing.Size(786, 40);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.Location = new System.Drawing.Point(637, 4);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Size = new System.Drawing.Size(70, 32);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSair.Location = new System.Drawing.Point(712, 4);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSair.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSair.Size = new System.Drawing.Size(70, 32);
            // 
            // btnAcaoExcluir
            // 
            this.btnAcaoExcluir.FlatAppearance.BorderSize = 0;
            this.btnAcaoExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.Location = new System.Drawing.Point(752, 4);
            this.btnAcaoExcluir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAcaoExcluir.MaximumSize = new System.Drawing.Size(30, 32);
            this.btnAcaoExcluir.MinimumSize = new System.Drawing.Size(22, 24);
            this.btnAcaoExcluir.Size = new System.Drawing.Size(30, 24);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(562, 4);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirmar.Size = new System.Drawing.Size(70, 32);
            this.btnConfirmar.Visible = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(677, 4);
            this.splitter3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter3.Size = new System.Drawing.Size(5, 0);
            // 
            // pnlAcoesMenu
            // 
            this.pnlAcoesMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAcoesMenu.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAcoesMenu.Size = new System.Drawing.Size(786, 8);
            this.pnlAcoesMenu.Visible = false;
            // 
            // GridFornecedor
            // 
            this.GridFornecedor.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfornecedor,
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
            this.GridFornecedor.Location = new System.Drawing.Point(4, 78);
            this.GridFornecedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GridFornecedor.Name = "GridFornecedor";
            this.GridFornecedor.RowHeadersWidth = 51;
            this.GridFornecedor.RowTemplate.Height = 24;
            this.GridFornecedor.Size = new System.Drawing.Size(776, 424);
            this.GridFornecedor.TabIndex = 1;
            // 
            // idfornecedor
            // 
            this.idfornecedor.DataPropertyName = "idfornecedor";
            this.idfornecedor.HeaderText = "Fornecedor";
            this.idfornecedor.MinimumWidth = 6;
            this.idfornecedor.Name = "idfornecedor";
            this.idfornecedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idfornecedor.Width = 125;
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
            this.BoxFiltro.Controls.Add(this.fornecedorid);
            this.BoxFiltro.Controls.Add(this.txtFornecedorId);
            this.BoxFiltro.Controls.Add(this.label3);
            this.BoxFiltro.Controls.Add(this.cbPesquisarAtivos);
            this.BoxFiltro.Controls.Add(this.label2);
            this.BoxFiltro.Controls.Add(this.cbTipoOrdenacao);
            this.BoxFiltro.Controls.Add(this.label1);
            this.BoxFiltro.Controls.Add(this.txtNomeFornecedor);
            this.BoxFiltro.Location = new System.Drawing.Point(4, 6);
            this.BoxFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BoxFiltro.Name = "BoxFiltro";
            this.BoxFiltro.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BoxFiltro.Size = new System.Drawing.Size(776, 67);
            this.BoxFiltro.TabIndex = 14;
            this.BoxFiltro.TabStop = false;
            this.BoxFiltro.Text = "Filtro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Id (F2)";
            // 
            // txtCidadeId
            // 
            this.txtCidadeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidadeId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidadeId.ForeColor = System.Drawing.Color.Black;
            this.txtCidadeId.Location = new System.Drawing.Point(202, 29);
            this.txtCidadeId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtCidadeId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtCidadeId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtCidadeId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCidadeId.Name = "txtCidadeId";
            this.txtCidadeId.Size = new System.Drawing.Size(38, 20);
            this.txtCidadeId.TabIndex = 24;
            this.txtCidadeId.TextChanged += new System.EventHandler(this.txtCidadeId_TextChanged);
            this.txtCidadeId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCidadeId_KeyUp);
            this.txtCidadeId.Leave += new System.EventHandler(this.txtCidadeId_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nome Cidade";
            // 
            // txtNomeCidade
            // 
            this.txtNomeCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCidade.Enabled = false;
            this.txtNomeCidade.ForeColor = System.Drawing.Color.Black;
            this.txtNomeCidade.Location = new System.Drawing.Point(239, 29);
            this.txtNomeCidade.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtNomeCidade.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtNomeCidade.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtNomeCidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeCidade.Name = "txtNomeCidade";
            this.txtNomeCidade.Size = new System.Drawing.Size(128, 20);
            this.txtNomeCidade.TabIndex = 22;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.IndianRed;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPesquisar.Location = new System.Drawing.Point(591, 26);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(162, 25);
            this.btnPesquisar.TabIndex = 21;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // fornecedorid
            // 
            this.fornecedorid.AutoSize = true;
            this.fornecedorid.Location = new System.Drawing.Point(10, 14);
            this.fornecedorid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fornecedorid.Name = "fornecedorid";
            this.fornecedorid.Size = new System.Drawing.Size(37, 13);
            this.fornecedorid.TabIndex = 20;
            this.fornecedorid.Text = "Id (F2)";
            // 
            // txtFornecedorId
            // 
            this.txtFornecedorId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFornecedorId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedorId.ForeColor = System.Drawing.Color.Black;
            this.txtFornecedorId.Location = new System.Drawing.Point(13, 29);
            this.txtFornecedorId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtFornecedorId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtFornecedorId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtFornecedorId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFornecedorId.Name = "txtFornecedorId";
            this.txtFornecedorId.Size = new System.Drawing.Size(38, 20);
            this.txtFornecedorId.TabIndex = 19;
            this.txtFornecedorId.TextChanged += new System.EventHandler(this.txtFornecedorId_TextChanged);
            this.txtFornecedorId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFornecedorId_KeyUp);
            this.txtFornecedorId.Leave += new System.EventHandler(this.txtFornecedorId_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
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
            this.cbPesquisarAtivos.Location = new System.Drawing.Point(482, 28);
            this.cbPesquisarAtivos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPesquisarAtivos.Name = "cbPesquisarAtivos";
            this.cbPesquisarAtivos.Size = new System.Drawing.Size(92, 21);
            this.cbPesquisarAtivos.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ordernar por:";
            // 
            // cbTipoOrdenacao
            // 
            this.cbTipoOrdenacao.FormattingEnabled = true;
            this.cbTipoOrdenacao.Items.AddRange(new object[] {
            "Cód. Cliente",
            "Nome Cliente"});
            this.cbTipoOrdenacao.Location = new System.Drawing.Point(389, 28);
            this.cbTipoOrdenacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTipoOrdenacao.Name = "cbTipoOrdenacao";
            this.cbTipoOrdenacao.Size = new System.Drawing.Size(92, 21);
            this.cbTipoOrdenacao.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome / Razão";
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFornecedor.Enabled = false;
            this.txtNomeFornecedor.ForeColor = System.Drawing.Color.Black;
            this.txtNomeFornecedor.Location = new System.Drawing.Point(50, 29);
            this.txtNomeFornecedor.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtNomeFornecedor.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtNomeFornecedor.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtNomeFornecedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(128, 20);
            this.txtNomeFornecedor.TabIndex = 13;
            // 
            // PesqAnaliticaFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(786, 552);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label fornecedorid;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idfornecedor;
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
