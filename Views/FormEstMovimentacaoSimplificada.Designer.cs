namespace LaPizza.Views
{
    partial class FormEstMovimentacaoSimplificada
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
            this.txtMovimentoId = new LaPizza.Controllers.LpText();
            this.lbEntradaId = new System.Windows.Forms.Label();
            this.lbEntradaDescricao = new System.Windows.Forms.Label();
            this.txtMovimentoDescricao = new LaPizza.Controllers.LpText();
            this.boxFiltro = new System.Windows.Forms.GroupBox();
            this.btnInserirItem = new System.Windows.Forms.Button();
            this.rbMovimentoSaida = new System.Windows.Forms.RadioButton();
            this.rbMovimentoEntrada = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbEntradaQtde = new System.Windows.Forms.Label();
            this.txtQtdeMovimento = new LaPizza.Controllers.LpText();
            this.lbSaldoEstoque = new System.Windows.Forms.Label();
            this.txtSaldoEstoque = new LaPizza.Controllers.LpText();
            this.lbEmbalagem = new System.Windows.Forms.Label();
            this.txtUnidadeMedida = new LaPizza.Controllers.LpText();
            this.lbProdutoDescricao = new System.Windows.Forms.Label();
            this.txtProdutoDescricao = new LaPizza.Controllers.LpText();
            this.lbProdutoId = new System.Windows.Forms.Label();
            this.txtProdutoId = new LaPizza.Controllers.LpText();
            this.gridMovimentos = new System.Windows.Forms.DataGridView();
            this.pnlPrincipal.SuspendLayout();
            this.pnlNomeRotina.SuspendLayout();
            this.pnlAcoesMenu.SuspendLayout();
            this.pnlAcoesRodape.SuspendLayout();
            this.boxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.gridMovimentos);
            this.pnlPrincipal.Controls.Add(this.boxFiltro);
            this.pnlPrincipal.Controls.Add(this.lbEntradaDescricao);
            this.pnlPrincipal.Controls.Add(this.txtMovimentoDescricao);
            this.pnlPrincipal.Controls.Add(this.lbEntradaId);
            this.pnlPrincipal.Controls.Add(this.txtMovimentoId);
            this.pnlPrincipal.Size = new System.Drawing.Size(584, 397);
            // 
            // pnlNomeRotina
            // 
            this.pnlNomeRotina.Size = new System.Drawing.Size(584, 40);
            // 
            // pnlAcoesMenu
            // 
            this.pnlAcoesMenu.Size = new System.Drawing.Size(584, 39);
            // 
            // btnAcaoAdicionar
            // 
            this.btnAcaoAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAcaoAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.Location = new System.Drawing.Point(444, 5);
            this.btnAcaoAdicionar.Click += new System.EventHandler(this.btnAcaoAdicionar_Click);
            // 
            // btnAcaoEditar
            // 
            this.btnAcaoEditar.FlatAppearance.BorderSize = 0;
            this.btnAcaoEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.Location = new System.Drawing.Point(479, 5);
            this.btnAcaoEditar.Visible = false;
            // 
            // btnAcaoConsultar
            // 
            this.btnAcaoConsultar.FlatAppearance.BorderSize = 0;
            this.btnAcaoConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.Location = new System.Drawing.Point(514, 5);
            this.btnAcaoConsultar.Click += new System.EventHandler(this.btnAcaoConsultar_Click);
            // 
            // lbNomeRotina
            // 
            this.lbNomeRotina.Size = new System.Drawing.Size(584, 40);
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 476);
            this.pnlAcoesRodape.Size = new System.Drawing.Size(584, 40);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.Location = new System.Drawing.Point(434, 5);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSair.Location = new System.Drawing.Point(509, 5);
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAcaoExcluir
            // 
            this.btnAcaoExcluir.FlatAppearance.BorderSize = 0;
            this.btnAcaoExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.Location = new System.Drawing.Point(549, 5);
            this.btnAcaoExcluir.Click += new System.EventHandler(this.btnAcaoExcluir_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(359, 5);
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(474, 5);
            this.splitter3.Visible = false;
            // 
            // txtMovimentoId
            // 
            this.txtMovimentoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMovimentoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMovimentoId.ForeColor = System.Drawing.Color.Black;
            this.txtMovimentoId.Location = new System.Drawing.Point(22, 31);
            this.txtMovimentoId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtMovimentoId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtMovimentoId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Integer;
            this.txtMovimentoId.Name = "txtMovimentoId";
            this.txtMovimentoId.Size = new System.Drawing.Size(62, 20);
            this.txtMovimentoId.TabIndex = 0;
            // 
            // lbEntradaId
            // 
            this.lbEntradaId.AutoSize = true;
            this.lbEntradaId.Location = new System.Drawing.Point(19, 15);
            this.lbEntradaId.Name = "lbEntradaId";
            this.lbEntradaId.Size = new System.Drawing.Size(16, 13);
            this.lbEntradaId.TabIndex = 1;
            this.lbEntradaId.Text = "Id";
            // 
            // lbEntradaDescricao
            // 
            this.lbEntradaDescricao.AutoSize = true;
            this.lbEntradaDescricao.Location = new System.Drawing.Point(87, 15);
            this.lbEntradaDescricao.Name = "lbEntradaDescricao";
            this.lbEntradaDescricao.Size = new System.Drawing.Size(124, 13);
            this.lbEntradaDescricao.TabIndex = 3;
            this.lbEntradaDescricao.Text = "Descrição do movimento";
            // 
            // txtMovimentoDescricao
            // 
            this.txtMovimentoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMovimentoDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMovimentoDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtMovimentoDescricao.Location = new System.Drawing.Point(90, 31);
            this.txtMovimentoDescricao.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtMovimentoDescricao.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtMovimentoDescricao.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtMovimentoDescricao.Name = "txtMovimentoDescricao";
            this.txtMovimentoDescricao.Size = new System.Drawing.Size(472, 20);
            this.txtMovimentoDescricao.TabIndex = 1;
            // 
            // boxFiltro
            // 
            this.boxFiltro.Controls.Add(this.btnInserirItem);
            this.boxFiltro.Controls.Add(this.rbMovimentoSaida);
            this.boxFiltro.Controls.Add(this.rbMovimentoEntrada);
            this.boxFiltro.Controls.Add(this.label1);
            this.boxFiltro.Controls.Add(this.lbEntradaQtde);
            this.boxFiltro.Controls.Add(this.txtQtdeMovimento);
            this.boxFiltro.Controls.Add(this.lbSaldoEstoque);
            this.boxFiltro.Controls.Add(this.txtSaldoEstoque);
            this.boxFiltro.Controls.Add(this.lbEmbalagem);
            this.boxFiltro.Controls.Add(this.txtUnidadeMedida);
            this.boxFiltro.Controls.Add(this.lbProdutoDescricao);
            this.boxFiltro.Controls.Add(this.txtProdutoDescricao);
            this.boxFiltro.Controls.Add(this.lbProdutoId);
            this.boxFiltro.Controls.Add(this.txtProdutoId);
            this.boxFiltro.Location = new System.Drawing.Point(11, 57);
            this.boxFiltro.Name = "boxFiltro";
            this.boxFiltro.Padding = new System.Windows.Forms.Padding(5);
            this.boxFiltro.Size = new System.Drawing.Size(560, 103);
            this.boxFiltro.TabIndex = 4;
            this.boxFiltro.TabStop = false;
            this.boxFiltro.Text = "Filtro";
            // 
            // btnInserirItem
            // 
            this.btnInserirItem.Location = new System.Drawing.Point(375, 69);
            this.btnInserirItem.Name = "btnInserirItem";
            this.btnInserirItem.Size = new System.Drawing.Size(176, 23);
            this.btnInserirItem.TabIndex = 4;
            this.btnInserirItem.Text = "Inserir movimento";
            this.btnInserirItem.UseVisualStyleBackColor = true;
            this.btnInserirItem.Click += new System.EventHandler(this.btnInserirItem_Click);
            // 
            // rbMovimentoSaida
            // 
            this.rbMovimentoSaida.AutoSize = true;
            this.rbMovimentoSaida.Location = new System.Drawing.Point(80, 75);
            this.rbMovimentoSaida.Name = "rbMovimentoSaida";
            this.rbMovimentoSaida.Size = new System.Drawing.Size(54, 17);
            this.rbMovimentoSaida.TabIndex = 4;
            this.rbMovimentoSaida.Text = "Saída";
            this.rbMovimentoSaida.UseVisualStyleBackColor = true;
            // 
            // rbMovimentoEntrada
            // 
            this.rbMovimentoEntrada.AutoSize = true;
            this.rbMovimentoEntrada.Location = new System.Drawing.Point(12, 75);
            this.rbMovimentoEntrada.Name = "rbMovimentoEntrada";
            this.rbMovimentoEntrada.Size = new System.Drawing.Size(62, 17);
            this.rbMovimentoEntrada.TabIndex = 3;
            this.rbMovimentoEntrada.Text = "Entrada";
            this.rbMovimentoEntrada.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tipo de movimento";
            // 
            // lbEntradaQtde
            // 
            this.lbEntradaQtde.AutoSize = true;
            this.lbEntradaQtde.Location = new System.Drawing.Point(140, 57);
            this.lbEntradaQtde.Name = "lbEntradaQtde";
            this.lbEntradaQtde.Size = new System.Drawing.Size(96, 13);
            this.lbEntradaQtde.TabIndex = 14;
            this.lbEntradaQtde.Text = "Qtde movimentada";
            // 
            // txtQtdeMovimento
            // 
            this.txtQtdeMovimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdeMovimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtdeMovimento.ForeColor = System.Drawing.Color.Black;
            this.txtQtdeMovimento.Location = new System.Drawing.Point(143, 73);
            this.txtQtdeMovimento.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtQtdeMovimento.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtQtdeMovimento.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Currency;
            this.txtQtdeMovimento.Name = "txtQtdeMovimento";
            this.txtQtdeMovimento.Size = new System.Drawing.Size(97, 20);
            this.txtQtdeMovimento.TabIndex = 3;
            this.txtQtdeMovimento.Leave += new System.EventHandler(this.txtQtdeMovimentada_Leave);
            // 
            // lbSaldoEstoque
            // 
            this.lbSaldoEstoque.AutoSize = true;
            this.lbSaldoEstoque.Location = new System.Drawing.Point(462, 18);
            this.lbSaldoEstoque.Name = "lbSaldoEstoque";
            this.lbSaldoEstoque.Size = new System.Drawing.Size(75, 13);
            this.lbSaldoEstoque.TabIndex = 12;
            this.lbSaldoEstoque.Text = "Saldo estoque";
            // 
            // txtSaldoEstoque
            // 
            this.txtSaldoEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaldoEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaldoEstoque.ForeColor = System.Drawing.Color.Black;
            this.txtSaldoEstoque.Location = new System.Drawing.Point(465, 34);
            this.txtSaldoEstoque.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtSaldoEstoque.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtSaldoEstoque.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtSaldoEstoque.Name = "txtSaldoEstoque";
            this.txtSaldoEstoque.Size = new System.Drawing.Size(87, 20);
            this.txtSaldoEstoque.TabIndex = 11;
            // 
            // lbEmbalagem
            // 
            this.lbEmbalagem.AutoSize = true;
            this.lbEmbalagem.Location = new System.Drawing.Point(372, 18);
            this.lbEmbalagem.Name = "lbEmbalagem";
            this.lbEmbalagem.Size = new System.Drawing.Size(62, 13);
            this.lbEmbalagem.TabIndex = 10;
            this.lbEmbalagem.Text = "Embalagem";
            // 
            // txtUnidadeMedida
            // 
            this.txtUnidadeMedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnidadeMedida.ForeColor = System.Drawing.Color.Black;
            this.txtUnidadeMedida.Location = new System.Drawing.Point(375, 34);
            this.txtUnidadeMedida.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtUnidadeMedida.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtUnidadeMedida.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtUnidadeMedida.Name = "txtUnidadeMedida";
            this.txtUnidadeMedida.Size = new System.Drawing.Size(84, 20);
            this.txtUnidadeMedida.TabIndex = 9;
            this.txtUnidadeMedida.TextChanged += new System.EventHandler(this.txtUnidadeMedida_TextChanged);
            // 
            // lbProdutoDescricao
            // 
            this.lbProdutoDescricao.AutoSize = true;
            this.lbProdutoDescricao.Location = new System.Drawing.Point(76, 18);
            this.lbProdutoDescricao.Name = "lbProdutoDescricao";
            this.lbProdutoDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbProdutoDescricao.TabIndex = 8;
            this.lbProdutoDescricao.Text = "Descrição";
            // 
            // txtProdutoDescricao
            // 
            this.txtProdutoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdutoDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProdutoDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtProdutoDescricao.Location = new System.Drawing.Point(79, 34);
            this.txtProdutoDescricao.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtProdutoDescricao.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtProdutoDescricao.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtProdutoDescricao.Name = "txtProdutoDescricao";
            this.txtProdutoDescricao.Size = new System.Drawing.Size(290, 20);
            this.txtProdutoDescricao.TabIndex = 7;
            // 
            // lbProdutoId
            // 
            this.lbProdutoId.AutoSize = true;
            this.lbProdutoId.Location = new System.Drawing.Point(8, 18);
            this.lbProdutoId.Name = "lbProdutoId";
            this.lbProdutoId.Size = new System.Drawing.Size(62, 13);
            this.lbProdutoId.TabIndex = 6;
            this.lbProdutoId.Text = "Produto(F2)";
            // 
            // txtProdutoId
            // 
            this.txtProdutoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdutoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProdutoId.ForeColor = System.Drawing.Color.Black;
            this.txtProdutoId.Location = new System.Drawing.Point(11, 34);
            this.txtProdutoId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtProdutoId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtProdutoId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Integer;
            this.txtProdutoId.Name = "txtProdutoId";
            this.txtProdutoId.Size = new System.Drawing.Size(62, 20);
            this.txtProdutoId.TabIndex = 2;
            this.txtProdutoId.TextChanged += new System.EventHandler(this.txtProdutoId_TextChanged);
            this.txtProdutoId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProdutoId_KeyUp);
            // 
            // gridMovimentos
            // 
            this.gridMovimentos.AllowUserToAddRows = false;
            this.gridMovimentos.AllowUserToResizeColumns = false;
            this.gridMovimentos.AllowUserToResizeRows = false;
            this.gridMovimentos.BackgroundColor = System.Drawing.Color.White;
            this.gridMovimentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMovimentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridMovimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMovimentos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridMovimentos.Location = new System.Drawing.Point(11, 166);
            this.gridMovimentos.Name = "gridMovimentos";
            this.gridMovimentos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMovimentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridMovimentos.RowHeadersVisible = false;
            this.gridMovimentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridMovimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMovimentos.Size = new System.Drawing.Size(560, 219);
            this.gridMovimentos.TabIndex = 5;
            // 
            // FormEstMovimentacaoSimplificada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(584, 516);
            this.KeyPreview = true;
            this.Name = "FormEstMovimentacaoSimplificada";
            this.ShowIcon = false;
            this.Text = "FormEstControleEstoque";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlNomeRotina.ResumeLayout(false);
            this.pnlAcoesMenu.ResumeLayout(false);
            this.pnlAcoesMenu.PerformLayout();
            this.pnlAcoesRodape.ResumeLayout(false);
            this.boxFiltro.ResumeLayout(false);
            this.boxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovimentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controllers.LpText txtMovimentoId;
        private System.Windows.Forms.Label lbEntradaId;
        private System.Windows.Forms.Label lbEntradaDescricao;
        private Controllers.LpText txtMovimentoDescricao;
        private System.Windows.Forms.DataGridView gridMovimentos;
        private System.Windows.Forms.GroupBox boxFiltro;
        private System.Windows.Forms.Button btnInserirItem;
        private System.Windows.Forms.RadioButton rbMovimentoSaida;
        private System.Windows.Forms.RadioButton rbMovimentoEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbEntradaQtde;
        private Controllers.LpText txtQtdeMovimento;
        private System.Windows.Forms.Label lbSaldoEstoque;
        private Controllers.LpText txtSaldoEstoque;
        private System.Windows.Forms.Label lbEmbalagem;
        private Controllers.LpText txtUnidadeMedida;
        private System.Windows.Forms.Label lbProdutoDescricao;
        private Controllers.LpText txtProdutoDescricao;
        private System.Windows.Forms.Label lbProdutoId;
        private Controllers.LpText txtProdutoId;
    }
}
