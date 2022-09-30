namespace LaPizza.Views.PesquisasAnaliticas
{
    partial class PesqAnaliticaClientes
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
            this.GridCliente = new System.Windows.Forms.DataGridView();
            this.idcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerazao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfcnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadosigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoOrdenacao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPesquisarAtivos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idlcliente = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.BoxFiltro = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeCidade = new LaPizza.Controllers.LpText();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCidadeId = new LaPizza.Controllers.LpText();
            this.txtClienteId = new LaPizza.Controllers.LpText();
            this.txtNomeCliente = new LaPizza.Controllers.LpText();
            this.pnlPrincipal.SuspendLayout();
            this.pnlNomeRotina.SuspendLayout();
            this.pnlAcoesRodape.SuspendLayout();
            this.pnlAcoesMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCliente)).BeginInit();
            this.BoxFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.txtClienteId);
            this.pnlPrincipal.Controls.Add(this.label3);
            this.pnlPrincipal.Controls.Add(this.cbPesquisarAtivos);
            this.pnlPrincipal.Controls.Add(this.txtNomeCliente);
            this.pnlPrincipal.Controls.Add(this.GridCliente);
            this.pnlPrincipal.Controls.Add(this.BoxFiltro);
            this.pnlPrincipal.Size = new System.Drawing.Size(738, 533);
            // 
            // pnlNomeRotina
            // 
            this.pnlNomeRotina.Size = new System.Drawing.Size(738, 49);
            // 
            // btnAcaoAdicionar
            // 
            this.btnAcaoAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAcaoAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.Location = new System.Drawing.Point(550, 6);
            // 
            // btnAcaoEditar
            // 
            this.btnAcaoEditar.FlatAppearance.BorderSize = 0;
            this.btnAcaoEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.Location = new System.Drawing.Point(597, 6);
            // 
            // btnAcaoConsultar
            // 
            this.btnAcaoConsultar.FlatAppearance.BorderSize = 0;
            this.btnAcaoConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.Location = new System.Drawing.Point(644, 6);
            // 
            // lbNomeRotina
            // 
            this.lbNomeRotina.Size = new System.Drawing.Size(738, 49);
            this.lbNomeRotina.Text = "Pesquisa Clientes";
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 630);
            this.pnlAcoesRodape.Size = new System.Drawing.Size(738, 49);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.Location = new System.Drawing.Point(538, 6);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSair.Location = new System.Drawing.Point(638, 6);
            // 
            // btnAcaoExcluir
            // 
            this.btnAcaoExcluir.FlatAppearance.BorderSize = 0;
            this.btnAcaoExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.Location = new System.Drawing.Point(691, 6);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(-535, 6);
            this.btnConfirmar.Size = new System.Drawing.Size(1066, 37);
            this.btnConfirmar.Visible = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(590, 6);
            // 
            // pnlAcoesMenu
            // 
            this.pnlAcoesMenu.Enabled = false;
            this.pnlAcoesMenu.Size = new System.Drawing.Size(738, 48);
            this.pnlAcoesMenu.Visible = false;
            // 
            // GridCliente
            // 
            this.GridCliente.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcliente,
            this.nomerazao,
            this.rgie,
            this.cpfcnpj,
            this.endereco,
            this.numero,
            this.bairro,
            this.complemento,
            this.cep,
            this.idcidade,
            this.cidadenome,
            this.estadosigla,
            this.telefone,
            this.celular,
            this.email,
            this.ativo});
            this.GridCliente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridCliente.Location = new System.Drawing.Point(0, 180);
            this.GridCliente.Name = "GridCliente";
            this.GridCliente.RowHeadersWidth = 51;
            this.GridCliente.RowTemplate.Height = 24;
            this.GridCliente.Size = new System.Drawing.Size(738, 353);
            this.GridCliente.TabIndex = 0;
            // 
            // idcliente
            // 
            this.idcliente.DataPropertyName = "idcliente";
            this.idcliente.HeaderText = "Cliente";
            this.idcliente.MinimumWidth = 6;
            this.idcliente.Name = "idcliente";
            this.idcliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idcliente.Width = 125;
            // 
            // nomerazao
            // 
            this.nomerazao.DataPropertyName = "nomerazao";
            this.nomerazao.HeaderText = "Nome Cliente";
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
            this.numero.HeaderText = "Número";
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
            // cidadenome
            // 
            this.cidadenome.DataPropertyName = "cidadenome";
            this.cidadenome.HeaderText = "Nome Cidade";
            this.cidadenome.MinimumWidth = 6;
            this.cidadenome.Name = "cidadenome";
            this.cidadenome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cidadenome.Width = 125;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome / Razão";
            // 
            // cbTipoOrdenacao
            // 
            this.cbTipoOrdenacao.FormattingEnabled = true;
            this.cbTipoOrdenacao.Items.AddRange(new object[] {
            "Cód. Cliente",
            "Nome Cliente"});
            this.cbTipoOrdenacao.Location = new System.Drawing.Point(15, 83);
            this.cbTipoOrdenacao.Name = "cbTipoOrdenacao";
            this.cbTipoOrdenacao.Size = new System.Drawing.Size(122, 24);
            this.cbTipoOrdenacao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ordernar por:";
            // 
            // cbPesquisarAtivos
            // 
            this.cbPesquisarAtivos.FormattingEnabled = true;
            this.cbPesquisarAtivos.Items.AddRange(new object[] {
            "Ativos",
            "Inativos",
            "Ativos/Inativos"});
            this.cbPesquisarAtivos.Location = new System.Drawing.Point(142, 86);
            this.cbPesquisarAtivos.Name = "cbPesquisarAtivos";
            this.cbPesquisarAtivos.Size = new System.Drawing.Size(122, 24);
            this.cbPesquisarAtivos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pesquisar apenas:";
            // 
            // idlcliente
            // 
            this.idlcliente.AutoSize = true;
            this.idlcliente.Location = new System.Drawing.Point(12, 18);
            this.idlcliente.Name = "idlcliente";
            this.idlcliente.Size = new System.Drawing.Size(44, 16);
            this.idlcliente.TabIndex = 8;
            this.idlcliente.Text = "Id (F2)";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.IndianRed;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPesquisar.Location = new System.Drawing.Point(274, 81);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(421, 31);
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // BoxFiltro
            // 
            this.BoxFiltro.Controls.Add(this.idlcliente);
            this.BoxFiltro.Controls.Add(this.label5);
            this.BoxFiltro.Controls.Add(this.txtNomeCidade);
            this.BoxFiltro.Controls.Add(this.label4);
            this.BoxFiltro.Controls.Add(this.txtCidadeId);
            this.BoxFiltro.Controls.Add(this.label1);
            this.BoxFiltro.Controls.Add(this.label2);
            this.BoxFiltro.Controls.Add(this.btnPesquisar);
            this.BoxFiltro.Controls.Add(this.cbTipoOrdenacao);
            this.BoxFiltro.Location = new System.Drawing.Point(3, 3);
            this.BoxFiltro.Name = "BoxFiltro";
            this.BoxFiltro.Size = new System.Drawing.Size(728, 141);
            this.BoxFiltro.TabIndex = 13;
            this.BoxFiltro.TabStop = false;
            this.BoxFiltro.Text = "Filtro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nome Cidade";
            // 
            // txtNomeCidade
            // 
            this.txtNomeCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCidade.Enabled = false;
            this.txtNomeCidade.ForeColor = System.Drawing.Color.Black;
            this.txtNomeCidade.Location = new System.Drawing.Point(436, 36);
            this.txtNomeCidade.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtNomeCidade.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtNomeCidade.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtNomeCidade.Name = "txtNomeCidade";
            this.txtNomeCidade.Size = new System.Drawing.Size(259, 22);
            this.txtNomeCidade.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Id (F2)";
            // 
            // txtCidadeId
            // 
            this.txtCidadeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidadeId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidadeId.ForeColor = System.Drawing.Color.Black;
            this.txtCidadeId.Location = new System.Drawing.Point(386, 36);
            this.txtCidadeId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtCidadeId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtCidadeId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Integer;
            this.txtCidadeId.Name = "txtCidadeId";
            this.txtCidadeId.Size = new System.Drawing.Size(50, 22);
            this.txtCidadeId.TabIndex = 14;
            this.txtCidadeId.TextChanged += new System.EventHandler(this.txtCidadeId_TextChanged);
            this.txtCidadeId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCidadeId_KeyUp);
            // 
            // txtClienteId
            // 
            this.txtClienteId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClienteId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClienteId.ForeColor = System.Drawing.Color.Black;
            this.txtClienteId.Location = new System.Drawing.Point(18, 39);
            this.txtClienteId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtClienteId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtClienteId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Integer;
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(50, 22);
            this.txtClienteId.TabIndex = 7;
            this.txtClienteId.TextChanged += new System.EventHandler(this.txtClienteId_TextChanged);
            this.txtClienteId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtClienteId_KeyUp);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.ForeColor = System.Drawing.Color.Black;
            this.txtNomeCliente.Location = new System.Drawing.Point(68, 39);
            this.txtNomeCliente.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtNomeCliente.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtNomeCliente.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(259, 22);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // PesqAnaliticaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(738, 679);
            this.Name = "PesqAnaliticaClientes";
            this.Text = "";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlNomeRotina.ResumeLayout(false);
            this.pnlAcoesRodape.ResumeLayout(false);
            this.pnlAcoesMenu.ResumeLayout(false);
            this.pnlAcoesMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCliente)).EndInit();
            this.BoxFiltro.ResumeLayout(false);
            this.BoxFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridCliente;
        private Controllers.LpText txtNomeCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoOrdenacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPesquisarAtivos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label idlcliente;
        private Controllers.LpText txtClienteId;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox BoxFiltro;
        private System.Windows.Forms.Label label4;
        private Controllers.LpText txtCidadeId;
        private System.Windows.Forms.Label label5;
        private Controllers.LpText txtNomeCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerazao;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgie;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfcnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadosigla;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativo;
    }
}
