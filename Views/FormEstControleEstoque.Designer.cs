namespace LaPizza.Views
{
    partial class FormEstControleEstoque
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
            this.txtEntradaId = new LaPizza.Controllers.LpText();
            this.lbEntradaId = new System.Windows.Forms.Label();
            this.lbEntradaDescricao = new System.Windows.Forms.Label();
            this.txtEntradaDescricao = new LaPizza.Controllers.LpText();
            this.boxFiltro = new System.Windows.Forms.GroupBox();
            this.btnInserirItem = new System.Windows.Forms.Button();
            this.rbMovimentaSaida = new System.Windows.Forms.RadioButton();
            this.rbMovimentaEntrada = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbEntradaQtde = new System.Windows.Forms.Label();
            this.txtQtdeMovimentada = new LaPizza.Controllers.LpText();
            this.lbSaldoEstoque = new System.Windows.Forms.Label();
            this.txtSaldoEstoque = new LaPizza.Controllers.LpText();
            this.lbEmbalagem = new System.Windows.Forms.Label();
            this.txtUnidadeMedida = new LaPizza.Controllers.LpText();
            this.lbProdutoDescricao = new System.Windows.Forms.Label();
            this.txtProdutoDescricao = new LaPizza.Controllers.LpText();
            this.lbProdutoId = new System.Windows.Forms.Label();
            this.txtProdutoId = new LaPizza.Controllers.LpText();
            this.gridItens = new System.Windows.Forms.DataGridView();
            this.pnlPrincipal.SuspendLayout();
            this.pnlNomeRotina.SuspendLayout();
            this.pnlAcoesMenu.SuspendLayout();
            this.pnlAcoesRodape.SuspendLayout();
            this.boxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItens)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.gridItens);
            this.pnlPrincipal.Controls.Add(this.boxFiltro);
            this.pnlPrincipal.Controls.Add(this.lbEntradaDescricao);
            this.pnlPrincipal.Controls.Add(this.txtEntradaDescricao);
            this.pnlPrincipal.Controls.Add(this.lbEntradaId);
            this.pnlPrincipal.Controls.Add(this.txtEntradaId);
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
            // txtEntradaId
            // 
            this.txtEntradaId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntradaId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEntradaId.ForeColor = System.Drawing.Color.Black;
            this.txtEntradaId.Location = new System.Drawing.Point(22, 31);
            this.txtEntradaId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtEntradaId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtEntradaId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Integer;
            this.txtEntradaId.Name = "txtEntradaId";
            this.txtEntradaId.Size = new System.Drawing.Size(62, 20);
            this.txtEntradaId.TabIndex = 0;
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
            this.lbEntradaDescricao.Size = new System.Drawing.Size(142, 13);
            this.lbEntradaDescricao.TabIndex = 3;
            this.lbEntradaDescricao.Text = "Descrição da movimentação";
            // 
            // txtEntradaDescricao
            // 
            this.txtEntradaDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntradaDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEntradaDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtEntradaDescricao.Location = new System.Drawing.Point(90, 31);
            this.txtEntradaDescricao.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtEntradaDescricao.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtEntradaDescricao.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtEntradaDescricao.Name = "txtEntradaDescricao";
            this.txtEntradaDescricao.Size = new System.Drawing.Size(472, 20);
            this.txtEntradaDescricao.TabIndex = 2;
            // 
            // boxFiltro
            // 
            this.boxFiltro.Controls.Add(this.btnInserirItem);
            this.boxFiltro.Controls.Add(this.rbMovimentaSaida);
            this.boxFiltro.Controls.Add(this.rbMovimentaEntrada);
            this.boxFiltro.Controls.Add(this.label1);
            this.boxFiltro.Controls.Add(this.lbEntradaQtde);
            this.boxFiltro.Controls.Add(this.txtQtdeMovimentada);
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
            this.btnInserirItem.Location = new System.Drawing.Point(464, 69);
            this.btnInserirItem.Name = "btnInserirItem";
            this.btnInserirItem.Size = new System.Drawing.Size(87, 23);
            this.btnInserirItem.TabIndex = 19;
            this.btnInserirItem.Text = "Inserir Item";
            this.btnInserirItem.UseVisualStyleBackColor = true;
            this.btnInserirItem.Click += new System.EventHandler(this.btnInserirItem_Click);
            // 
            // rbMovimentaSaida
            // 
            this.rbMovimentaSaida.AutoSize = true;
            this.rbMovimentaSaida.Location = new System.Drawing.Point(182, 75);
            this.rbMovimentaSaida.Name = "rbMovimentaSaida";
            this.rbMovimentaSaida.Size = new System.Drawing.Size(54, 17);
            this.rbMovimentaSaida.TabIndex = 18;
            this.rbMovimentaSaida.TabStop = true;
            this.rbMovimentaSaida.Text = "Saída";
            this.rbMovimentaSaida.UseVisualStyleBackColor = true;
            // 
            // rbMovimentaEntrada
            // 
            this.rbMovimentaEntrada.AutoSize = true;
            this.rbMovimentaEntrada.Location = new System.Drawing.Point(114, 75);
            this.rbMovimentaEntrada.Name = "rbMovimentaEntrada";
            this.rbMovimentaEntrada.Size = new System.Drawing.Size(62, 17);
            this.rbMovimentaEntrada.TabIndex = 17;
            this.rbMovimentaEntrada.TabStop = true;
            this.rbMovimentaEntrada.Text = "Entrada";
            this.rbMovimentaEntrada.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tipo de movimentação";
            // 
            // lbEntradaQtde
            // 
            this.lbEntradaQtde.AutoSize = true;
            this.lbEntradaQtde.Location = new System.Drawing.Point(8, 57);
            this.lbEntradaQtde.Name = "lbEntradaQtde";
            this.lbEntradaQtde.Size = new System.Drawing.Size(96, 13);
            this.lbEntradaQtde.TabIndex = 14;
            this.lbEntradaQtde.Text = "Qtde movimentada";
            // 
            // txtQtdeMovimentada
            // 
            this.txtQtdeMovimentada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdeMovimentada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtdeMovimentada.ForeColor = System.Drawing.Color.Black;
            this.txtQtdeMovimentada.Location = new System.Drawing.Point(11, 73);
            this.txtQtdeMovimentada.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtQtdeMovimentada.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtQtdeMovimentada.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Currency;
            this.txtQtdeMovimentada.Name = "txtQtdeMovimentada";
            this.txtQtdeMovimentada.Size = new System.Drawing.Size(97, 20);
            this.txtQtdeMovimentada.TabIndex = 13;
            this.txtQtdeMovimentada.Leave += new System.EventHandler(this.txtQtdeMovimentada_Leave);
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
            this.lbProdutoId.Size = new System.Drawing.Size(50, 13);
            this.lbProdutoId.TabIndex = 6;
            this.lbProdutoId.Text = "Produto+";
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
            this.txtProdutoId.TabIndex = 5;
            this.txtProdutoId.TextChanged += new System.EventHandler(this.txtProdutoId_TextChanged);
            this.txtProdutoId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProdutoId_KeyUp);
            // 
            // gridItens
            // 
            this.gridItens.AllowUserToAddRows = false;
            this.gridItens.AllowUserToResizeColumns = false;
            this.gridItens.AllowUserToResizeRows = false;
            this.gridItens.BackgroundColor = System.Drawing.Color.White;
            this.gridItens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridItens.Location = new System.Drawing.Point(11, 166);
            this.gridItens.Name = "gridItens";
            this.gridItens.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItens.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridItens.RowHeadersVisible = false;
            this.gridItens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridItens.Size = new System.Drawing.Size(560, 219);
            this.gridItens.TabIndex = 5;
            // 
            // FormEstControleEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(584, 516);
            this.KeyPreview = true;
            this.Name = "FormEstControleEstoque";
            this.Text = "FormEstControleEstoque";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlNomeRotina.ResumeLayout(false);
            this.pnlAcoesMenu.ResumeLayout(false);
            this.pnlAcoesMenu.PerformLayout();
            this.pnlAcoesRodape.ResumeLayout(false);
            this.boxFiltro.ResumeLayout(false);
            this.boxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controllers.LpText txtEntradaId;
        private System.Windows.Forms.Label lbEntradaId;
        private System.Windows.Forms.Label lbEntradaDescricao;
        private Controllers.LpText txtEntradaDescricao;
        private System.Windows.Forms.DataGridView gridItens;
        private System.Windows.Forms.GroupBox boxFiltro;
        private System.Windows.Forms.Button btnInserirItem;
        private System.Windows.Forms.RadioButton rbMovimentaSaida;
        private System.Windows.Forms.RadioButton rbMovimentaEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbEntradaQtde;
        private Controllers.LpText txtQtdeMovimentada;
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
