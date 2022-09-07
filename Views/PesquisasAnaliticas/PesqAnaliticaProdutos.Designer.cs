namespace LaPizza.Views.PesquisasAnaliticas
{
    partial class PesqAnaliticaProdutos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BoxFiltro = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lbMovimentacoes = new System.Windows.Forms.Label();
            this.cbMovimentacoes = new System.Windows.Forms.ComboBox();
            this.lbEstoque = new System.Windows.Forms.Label();
            this.cbSaldoEstoque = new System.Windows.Forms.ComboBox();
            this.lbPesquisarApenas = new System.Windows.Forms.Label();
            this.lbOrdenar = new System.Windows.Forms.Label();
            this.cbTipoOrdenacao = new System.Windows.Forms.ComboBox();
            this.cbPesquisarAtivos = new System.Windows.Forms.ComboBox();
            this.lbMarcaDescricao = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbSubgrupoDescricao = new System.Windows.Forms.Label();
            this.txtMarcaId = new LaPizza.Controllers.LpText();
            this.txtSubgrupoDescricao = new LaPizza.Controllers.LpText();
            this.txtMarcaDescricao = new LaPizza.Controllers.LpText();
            this.lbSubgrupo = new System.Windows.Forms.Label();
            this.txtGrupoId = new LaPizza.Controllers.LpText();
            this.txtSubgrupoId = new LaPizza.Controllers.LpText();
            this.lbGrupo = new System.Windows.Forms.Label();
            this.lbGrupoDescricao = new System.Windows.Forms.Label();
            this.txtGrupoDescricao = new LaPizza.Controllers.LpText();
            this.pnlPrincipal.SuspendLayout();
            this.pnlNomeRotina.SuspendLayout();
            this.pnlAcoesRodape.SuspendLayout();
            this.pnlAcoesMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.BoxFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.BoxFiltro);
            this.pnlPrincipal.Controls.Add(this.dataGridView1);
            this.pnlPrincipal.Padding = new System.Windows.Forms.Padding(5);
            this.pnlPrincipal.Size = new System.Drawing.Size(786, 433);
            // 
            // pnlNomeRotina
            // 
            this.pnlNomeRotina.Size = new System.Drawing.Size(786, 40);
            // 
            // btnAcaoAdicionar
            // 
            this.btnAcaoAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAcaoAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.Location = new System.Drawing.Point(646, 5);
            // 
            // btnAcaoEditar
            // 
            this.btnAcaoEditar.FlatAppearance.BorderSize = 0;
            this.btnAcaoEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.Location = new System.Drawing.Point(681, 5);
            // 
            // btnAcaoConsultar
            // 
            this.btnAcaoConsultar.FlatAppearance.BorderSize = 0;
            this.btnAcaoConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.Location = new System.Drawing.Point(716, 5);
            // 
            // lbNomeRotina
            // 
            this.lbNomeRotina.Size = new System.Drawing.Size(786, 40);
            this.lbNomeRotina.Text = "Form1";
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 512);
            this.pnlAcoesRodape.Size = new System.Drawing.Size(786, 40);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.Location = new System.Drawing.Point(636, 5);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSair.Location = new System.Drawing.Point(711, 5);
            // 
            // btnAcaoExcluir
            // 
            this.btnAcaoExcluir.FlatAppearance.BorderSize = 0;
            this.btnAcaoExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.Location = new System.Drawing.Point(751, 5);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(561, 5);
            this.btnConfirmar.Visible = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(676, 5);
            // 
            // pnlAcoesMenu
            // 
            this.pnlAcoesMenu.Size = new System.Drawing.Size(786, 39);
            this.pnlAcoesMenu.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 423);
            this.dataGridView1.TabIndex = 36;
            // 
            // BoxFiltro
            // 
            this.BoxFiltro.Controls.Add(this.btnPesquisar);
            this.BoxFiltro.Controls.Add(this.lbMovimentacoes);
            this.BoxFiltro.Controls.Add(this.cbMovimentacoes);
            this.BoxFiltro.Controls.Add(this.lbEstoque);
            this.BoxFiltro.Controls.Add(this.cbSaldoEstoque);
            this.BoxFiltro.Controls.Add(this.lbPesquisarApenas);
            this.BoxFiltro.Controls.Add(this.lbOrdenar);
            this.BoxFiltro.Controls.Add(this.cbTipoOrdenacao);
            this.BoxFiltro.Controls.Add(this.cbPesquisarAtivos);
            this.BoxFiltro.Controls.Add(this.lbMarcaDescricao);
            this.BoxFiltro.Controls.Add(this.lbMarca);
            this.BoxFiltro.Controls.Add(this.lbSubgrupoDescricao);
            this.BoxFiltro.Controls.Add(this.txtMarcaId);
            this.BoxFiltro.Controls.Add(this.txtSubgrupoDescricao);
            this.BoxFiltro.Controls.Add(this.txtMarcaDescricao);
            this.BoxFiltro.Controls.Add(this.lbSubgrupo);
            this.BoxFiltro.Controls.Add(this.txtGrupoId);
            this.BoxFiltro.Controls.Add(this.txtSubgrupoId);
            this.BoxFiltro.Controls.Add(this.lbGrupo);
            this.BoxFiltro.Controls.Add(this.lbGrupoDescricao);
            this.BoxFiltro.Controls.Add(this.txtGrupoDescricao);
            this.BoxFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoxFiltro.Location = new System.Drawing.Point(5, 5);
            this.BoxFiltro.Name = "BoxFiltro";
            this.BoxFiltro.Size = new System.Drawing.Size(776, 140);
            this.BoxFiltro.TabIndex = 37;
            this.BoxFiltro.TabStop = false;
            this.BoxFiltro.Text = "Filtros";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.IndianRed;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPesquisar.Location = new System.Drawing.Point(450, 103);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(316, 25);
            this.btnPesquisar.TabIndex = 45;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // lbMovimentacoes
            // 
            this.lbMovimentacoes.AutoSize = true;
            this.lbMovimentacoes.Location = new System.Drawing.Point(608, 54);
            this.lbMovimentacoes.Name = "lbMovimentacoes";
            this.lbMovimentacoes.Size = new System.Drawing.Size(85, 13);
            this.lbMovimentacoes.TabIndex = 44;
            this.lbMovimentacoes.Text = "Movimentações:";
            // 
            // cbMovimentacoes
            // 
            this.cbMovimentacoes.FormattingEnabled = true;
            this.cbMovimentacoes.Items.AddRange(new object[] {
            "Com movimentação",
            "Sem movimentação"});
            this.cbMovimentacoes.Location = new System.Drawing.Point(611, 69);
            this.cbMovimentacoes.Name = "cbMovimentacoes";
            this.cbMovimentacoes.Size = new System.Drawing.Size(155, 21);
            this.cbMovimentacoes.TabIndex = 43;
            // 
            // lbEstoque
            // 
            this.lbEstoque.AutoSize = true;
            this.lbEstoque.Location = new System.Drawing.Point(447, 54);
            this.lbEstoque.Name = "lbEstoque";
            this.lbEstoque.Size = new System.Drawing.Size(94, 13);
            this.lbEstoque.TabIndex = 42;
            this.lbEstoque.Text = "Saldo de Estoque:";
            // 
            // cbSaldoEstoque
            // 
            this.cbSaldoEstoque.FormattingEnabled = true;
            this.cbSaldoEstoque.Items.AddRange(new object[] {
            "Positivo",
            "Negativo",
            "Positivo/Negativo"});
            this.cbSaldoEstoque.Location = new System.Drawing.Point(450, 69);
            this.cbSaldoEstoque.Name = "cbSaldoEstoque";
            this.cbSaldoEstoque.Size = new System.Drawing.Size(155, 21);
            this.cbSaldoEstoque.TabIndex = 41;
            // 
            // lbPesquisarApenas
            // 
            this.lbPesquisarApenas.AutoSize = true;
            this.lbPesquisarApenas.Location = new System.Drawing.Point(608, 16);
            this.lbPesquisarApenas.Name = "lbPesquisarApenas";
            this.lbPesquisarApenas.Size = new System.Drawing.Size(94, 13);
            this.lbPesquisarApenas.TabIndex = 40;
            this.lbPesquisarApenas.Text = "Pesquisar apenas:";
            // 
            // lbOrdenar
            // 
            this.lbOrdenar.AutoSize = true;
            this.lbOrdenar.Location = new System.Drawing.Point(447, 16);
            this.lbOrdenar.Name = "lbOrdenar";
            this.lbOrdenar.Size = new System.Drawing.Size(66, 13);
            this.lbOrdenar.TabIndex = 39;
            this.lbOrdenar.Text = "Ordenar por:";
            // 
            // cbTipoOrdenacao
            // 
            this.cbTipoOrdenacao.FormattingEnabled = true;
            this.cbTipoOrdenacao.Items.AddRange(new object[] {
            "Cód. Produto",
            "Desc. Produto"});
            this.cbTipoOrdenacao.Location = new System.Drawing.Point(450, 30);
            this.cbTipoOrdenacao.Name = "cbTipoOrdenacao";
            this.cbTipoOrdenacao.Size = new System.Drawing.Size(155, 21);
            this.cbTipoOrdenacao.TabIndex = 38;
            // 
            // cbPesquisarAtivos
            // 
            this.cbPesquisarAtivos.FormattingEnabled = true;
            this.cbPesquisarAtivos.Items.AddRange(new object[] {
            "Ativos",
            "Inativos",
            "Ativos/Inativos"});
            this.cbPesquisarAtivos.Location = new System.Drawing.Point(611, 30);
            this.cbPesquisarAtivos.Name = "cbPesquisarAtivos";
            this.cbPesquisarAtivos.Size = new System.Drawing.Size(155, 21);
            this.cbPesquisarAtivos.TabIndex = 37;
            // 
            // lbMarcaDescricao
            // 
            this.lbMarcaDescricao.AutoSize = true;
            this.lbMarcaDescricao.Location = new System.Drawing.Point(72, 15);
            this.lbMarcaDescricao.Name = "lbMarcaDescricao";
            this.lbMarcaDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbMarcaDescricao.TabIndex = 35;
            this.lbMarcaDescricao.Text = "Descrição";
            this.lbMarcaDescricao.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(3, 16);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(55, 13);
            this.lbMarca.TabIndex = 15;
            this.lbMarca.Text = "Marca(F2)";
            // 
            // lbSubgrupoDescricao
            // 
            this.lbSubgrupoDescricao.AutoSize = true;
            this.lbSubgrupoDescricao.Location = new System.Drawing.Point(72, 93);
            this.lbSubgrupoDescricao.Name = "lbSubgrupoDescricao";
            this.lbSubgrupoDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbSubgrupoDescricao.TabIndex = 34;
            this.lbSubgrupoDescricao.Text = "Descrição";
            // 
            // txtMarcaId
            // 
            this.txtMarcaId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarcaId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarcaId.ForeColor = System.Drawing.Color.Black;
            this.txtMarcaId.Location = new System.Drawing.Point(6, 31);
            this.txtMarcaId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtMarcaId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtMarcaId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtMarcaId.Name = "txtMarcaId";
            this.txtMarcaId.Size = new System.Drawing.Size(70, 20);
            this.txtMarcaId.TabIndex = 17;
            // 
            // txtSubgrupoDescricao
            // 
            this.txtSubgrupoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubgrupoDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubgrupoDescricao.Enabled = false;
            this.txtSubgrupoDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtSubgrupoDescricao.Location = new System.Drawing.Point(75, 108);
            this.txtSubgrupoDescricao.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtSubgrupoDescricao.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtSubgrupoDescricao.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtSubgrupoDescricao.Name = "txtSubgrupoDescricao";
            this.txtSubgrupoDescricao.Size = new System.Drawing.Size(368, 20);
            this.txtSubgrupoDescricao.TabIndex = 33;
            // 
            // txtMarcaDescricao
            // 
            this.txtMarcaDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarcaDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarcaDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtMarcaDescricao.Location = new System.Drawing.Point(75, 31);
            this.txtMarcaDescricao.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtMarcaDescricao.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtMarcaDescricao.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtMarcaDescricao.Name = "txtMarcaDescricao";
            this.txtMarcaDescricao.Size = new System.Drawing.Size(368, 20);
            this.txtMarcaDescricao.TabIndex = 18;
            // 
            // lbSubgrupo
            // 
            this.lbSubgrupo.AutoSize = true;
            this.lbSubgrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubgrupo.Location = new System.Drawing.Point(3, 93);
            this.lbSubgrupo.Name = "lbSubgrupo";
            this.lbSubgrupo.Size = new System.Drawing.Size(71, 13);
            this.lbSubgrupo.TabIndex = 32;
            this.lbSubgrupo.Text = "Subgrupo(F2)";
            // 
            // txtGrupoId
            // 
            this.txtGrupoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrupoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGrupoId.ForeColor = System.Drawing.Color.Black;
            this.txtGrupoId.Location = new System.Drawing.Point(6, 70);
            this.txtGrupoId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtGrupoId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtGrupoId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Integer;
            this.txtGrupoId.Name = "txtGrupoId";
            this.txtGrupoId.Size = new System.Drawing.Size(70, 20);
            this.txtGrupoId.TabIndex = 27;
            // 
            // txtSubgrupoId
            // 
            this.txtSubgrupoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubgrupoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubgrupoId.ForeColor = System.Drawing.Color.Black;
            this.txtSubgrupoId.Location = new System.Drawing.Point(6, 108);
            this.txtSubgrupoId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtSubgrupoId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtSubgrupoId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Integer;
            this.txtSubgrupoId.Name = "txtSubgrupoId";
            this.txtSubgrupoId.Size = new System.Drawing.Size(70, 20);
            this.txtSubgrupoId.TabIndex = 31;
            // 
            // lbGrupo
            // 
            this.lbGrupo.AutoSize = true;
            this.lbGrupo.Location = new System.Drawing.Point(3, 54);
            this.lbGrupo.Name = "lbGrupo";
            this.lbGrupo.Size = new System.Drawing.Size(54, 13);
            this.lbGrupo.TabIndex = 28;
            this.lbGrupo.Text = "Grupo(F2)";
            // 
            // lbGrupoDescricao
            // 
            this.lbGrupoDescricao.AutoSize = true;
            this.lbGrupoDescricao.Location = new System.Drawing.Point(72, 54);
            this.lbGrupoDescricao.Name = "lbGrupoDescricao";
            this.lbGrupoDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbGrupoDescricao.TabIndex = 30;
            this.lbGrupoDescricao.Text = "Descrição";
            // 
            // txtGrupoDescricao
            // 
            this.txtGrupoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrupoDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGrupoDescricao.Enabled = false;
            this.txtGrupoDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtGrupoDescricao.Location = new System.Drawing.Point(75, 70);
            this.txtGrupoDescricao.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtGrupoDescricao.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtGrupoDescricao.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtGrupoDescricao.Name = "txtGrupoDescricao";
            this.txtGrupoDescricao.Size = new System.Drawing.Size(368, 20);
            this.txtGrupoDescricao.TabIndex = 29;
            // 
            // PesqAnaliticaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(786, 552);
            this.Name = "PesqAnaliticaProdutos";
            this.Text = "";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlNomeRotina.ResumeLayout(false);
            this.pnlAcoesRodape.ResumeLayout(false);
            this.pnlAcoesMenu.ResumeLayout(false);
            this.pnlAcoesMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.BoxFiltro.ResumeLayout(false);
            this.BoxFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BoxFiltro;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lbMovimentacoes;
        private System.Windows.Forms.ComboBox cbMovimentacoes;
        private System.Windows.Forms.Label lbEstoque;
        private System.Windows.Forms.ComboBox cbSaldoEstoque;
        private System.Windows.Forms.Label lbPesquisarApenas;
        private System.Windows.Forms.Label lbOrdenar;
        private System.Windows.Forms.ComboBox cbTipoOrdenacao;
        private System.Windows.Forms.ComboBox cbPesquisarAtivos;
        private System.Windows.Forms.Label lbMarcaDescricao;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbSubgrupoDescricao;
        private Controllers.LpText txtMarcaId;
        public Controllers.LpText txtSubgrupoDescricao;
        private Controllers.LpText txtMarcaDescricao;
        private System.Windows.Forms.Label lbSubgrupo;
        public Controllers.LpText txtGrupoId;
        public Controllers.LpText txtSubgrupoId;
        private System.Windows.Forms.Label lbGrupo;
        private System.Windows.Forms.Label lbGrupoDescricao;
        public Controllers.LpText txtGrupoDescricao;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
