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
            this.txtEntradaId = new LaPizza.Controllers.LpText();
            this.lbEntradaId = new System.Windows.Forms.Label();
            this.lbEntradaDescricao = new System.Windows.Forms.Label();
            this.txtEntradaDescricao = new LaPizza.Controllers.LpText();
            this.boxFiltro = new System.Windows.Forms.GroupBox();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
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
            this.lpText1 = new LaPizza.Controllers.LpText();
            this.GridProdutos = new System.Windows.Forms.DataGridView();
            this.pnlPrincipal.SuspendLayout();
            this.pnlNomeRotina.SuspendLayout();
            this.pnlAcoesMenu.SuspendLayout();
            this.pnlAcoesRodape.SuspendLayout();
            this.boxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.GridProdutos);
            this.pnlPrincipal.Controls.Add(this.boxFiltro);
            this.pnlPrincipal.Controls.Add(this.lbEntradaDescricao);
            this.pnlPrincipal.Controls.Add(this.txtEntradaDescricao);
            this.pnlPrincipal.Controls.Add(this.lbEntradaId);
            this.pnlPrincipal.Controls.Add(this.txtEntradaId);
            this.pnlPrincipal.Size = new System.Drawing.Size(588, 397);
            // 
            // pnlNomeRotina
            // 
            this.pnlNomeRotina.Size = new System.Drawing.Size(588, 40);
            // 
            // pnlAcoesMenu
            // 
            this.pnlAcoesMenu.Size = new System.Drawing.Size(588, 39);
            // 
            // btnAcaoAdicionar
            // 
            this.btnAcaoAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAcaoAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.Location = new System.Drawing.Point(448, 5);
            // 
            // btnAcaoEditar
            // 
            this.btnAcaoEditar.FlatAppearance.BorderSize = 0;
            this.btnAcaoEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.Location = new System.Drawing.Point(483, 5);
            this.btnAcaoEditar.Visible = false;
            // 
            // btnAcaoConsultar
            // 
            this.btnAcaoConsultar.FlatAppearance.BorderSize = 0;
            this.btnAcaoConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.Location = new System.Drawing.Point(518, 5);
            // 
            // lbNomeRotina
            // 
            this.lbNomeRotina.Size = new System.Drawing.Size(588, 40);
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 476);
            this.pnlAcoesRodape.Size = new System.Drawing.Size(588, 40);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.Location = new System.Drawing.Point(438, 5);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSair.Location = new System.Drawing.Point(513, 5);
            // 
            // btnAcaoExcluir
            // 
            this.btnAcaoExcluir.FlatAppearance.BorderSize = 0;
            this.btnAcaoExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.Location = new System.Drawing.Point(553, 5);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(363, 5);
            // 
            // txtEntradaId
            // 
            this.txtEntradaId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntradaId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEntradaId.ForeColor = System.Drawing.Color.Black;
            this.txtEntradaId.Location = new System.Drawing.Point(12, 31);
            this.txtEntradaId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtEntradaId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtEntradaId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtEntradaId.Name = "txtEntradaId";
            this.txtEntradaId.Size = new System.Drawing.Size(62, 20);
            this.txtEntradaId.TabIndex = 0;
            // 
            // lbEntradaId
            // 
            this.lbEntradaId.AutoSize = true;
            this.lbEntradaId.Location = new System.Drawing.Point(12, 15);
            this.lbEntradaId.Name = "lbEntradaId";
            this.lbEntradaId.Size = new System.Drawing.Size(16, 13);
            this.lbEntradaId.TabIndex = 1;
            this.lbEntradaId.Text = "Id";
            // 
            // lbEntradaDescricao
            // 
            this.lbEntradaDescricao.AutoSize = true;
            this.lbEntradaDescricao.Location = new System.Drawing.Point(80, 15);
            this.lbEntradaDescricao.Name = "lbEntradaDescricao";
            this.lbEntradaDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbEntradaDescricao.TabIndex = 3;
            this.lbEntradaDescricao.Text = "Descrição";
            // 
            // txtEntradaDescricao
            // 
            this.txtEntradaDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntradaDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEntradaDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtEntradaDescricao.Location = new System.Drawing.Point(80, 31);
            this.txtEntradaDescricao.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtEntradaDescricao.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtEntradaDescricao.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtEntradaDescricao.Name = "txtEntradaDescricao";
            this.txtEntradaDescricao.Size = new System.Drawing.Size(496, 20);
            this.txtEntradaDescricao.TabIndex = 2;
            // 
            // boxFiltro
            // 
            this.boxFiltro.Controls.Add(this.btnAdicionarProduto);
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
            this.boxFiltro.Controls.Add(this.lpText1);
            this.boxFiltro.Location = new System.Drawing.Point(15, 57);
            this.boxFiltro.Name = "boxFiltro";
            this.boxFiltro.Size = new System.Drawing.Size(561, 103);
            this.boxFiltro.TabIndex = 4;
            this.boxFiltro.TabStop = false;
            this.boxFiltro.Text = "Filtro";
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(468, 71);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(87, 23);
            this.btnAdicionarProduto.TabIndex = 19;
            this.btnAdicionarProduto.Text = "Inserir Item";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            // 
            // rbMovimentaSaida
            // 
            this.rbMovimentaSaida.AutoSize = true;
            this.rbMovimentaSaida.Location = new System.Drawing.Point(177, 73);
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
            this.rbMovimentaEntrada.Location = new System.Drawing.Point(109, 73);
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
            this.label1.Location = new System.Drawing.Point(106, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tipo de movimentação";
            // 
            // lbEntradaQtde
            // 
            this.lbEntradaQtde.AutoSize = true;
            this.lbEntradaQtde.Location = new System.Drawing.Point(6, 55);
            this.lbEntradaQtde.Name = "lbEntradaQtde";
            this.lbEntradaQtde.Size = new System.Drawing.Size(97, 13);
            this.lbEntradaQtde.TabIndex = 14;
            this.lbEntradaQtde.Text = "Qtde Movimentada";
            // 
            // txtQtdeMovimentada
            // 
            this.txtQtdeMovimentada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdeMovimentada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtdeMovimentada.ForeColor = System.Drawing.Color.Black;
            this.txtQtdeMovimentada.Location = new System.Drawing.Point(6, 71);
            this.txtQtdeMovimentada.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtQtdeMovimentada.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtQtdeMovimentada.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtQtdeMovimentada.Name = "txtQtdeMovimentada";
            this.txtQtdeMovimentada.Size = new System.Drawing.Size(97, 20);
            this.txtQtdeMovimentada.TabIndex = 13;
            // 
            // lbSaldoEstoque
            // 
            this.lbSaldoEstoque.AutoSize = true;
            this.lbSaldoEstoque.Location = new System.Drawing.Point(468, 16);
            this.lbSaldoEstoque.Name = "lbSaldoEstoque";
            this.lbSaldoEstoque.Size = new System.Drawing.Size(76, 13);
            this.lbSaldoEstoque.TabIndex = 12;
            this.lbSaldoEstoque.Text = "Saldo Estoque";
            // 
            // txtSaldoEstoque
            // 
            this.txtSaldoEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaldoEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaldoEstoque.ForeColor = System.Drawing.Color.Black;
            this.txtSaldoEstoque.Location = new System.Drawing.Point(468, 32);
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
            this.lbEmbalagem.Location = new System.Drawing.Point(379, 16);
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
            this.txtUnidadeMedida.Location = new System.Drawing.Point(379, 32);
            this.txtUnidadeMedida.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtUnidadeMedida.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtUnidadeMedida.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtUnidadeMedida.Name = "txtUnidadeMedida";
            this.txtUnidadeMedida.Size = new System.Drawing.Size(84, 20);
            this.txtUnidadeMedida.TabIndex = 9;
            // 
            // lbProdutoDescricao
            // 
            this.lbProdutoDescricao.AutoSize = true;
            this.lbProdutoDescricao.Location = new System.Drawing.Point(74, 16);
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
            this.txtProdutoDescricao.Location = new System.Drawing.Point(74, 32);
            this.txtProdutoDescricao.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtProdutoDescricao.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtProdutoDescricao.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtProdutoDescricao.Name = "txtProdutoDescricao";
            this.txtProdutoDescricao.Size = new System.Drawing.Size(301, 20);
            this.txtProdutoDescricao.TabIndex = 7;
            // 
            // lbProdutoId
            // 
            this.lbProdutoId.AutoSize = true;
            this.lbProdutoId.Location = new System.Drawing.Point(6, 16);
            this.lbProdutoId.Name = "lbProdutoId";
            this.lbProdutoId.Size = new System.Drawing.Size(44, 13);
            this.lbProdutoId.TabIndex = 6;
            this.lbProdutoId.Text = "Produto";
            // 
            // lpText1
            // 
            this.lpText1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lpText1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lpText1.ForeColor = System.Drawing.Color.Black;
            this.lpText1.Location = new System.Drawing.Point(6, 32);
            this.lpText1.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lpText1.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.lpText1.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.lpText1.Name = "lpText1";
            this.lpText1.Size = new System.Drawing.Size(62, 20);
            this.lpText1.TabIndex = 5;
            // 
            // GridProdutos
            // 
            this.GridProdutos.BackgroundColor = System.Drawing.Color.White;
            this.GridProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProdutos.Location = new System.Drawing.Point(15, 166);
            this.GridProdutos.Name = "GridProdutos";
            this.GridProdutos.Size = new System.Drawing.Size(561, 219);
            this.GridProdutos.TabIndex = 5;
            // 
            // FormEstControleEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(588, 516);
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
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controllers.LpText txtEntradaId;
        private System.Windows.Forms.Label lbEntradaId;
        private System.Windows.Forms.Label lbEntradaDescricao;
        private Controllers.LpText txtEntradaDescricao;
        private System.Windows.Forms.DataGridView GridProdutos;
        private System.Windows.Forms.GroupBox boxFiltro;
        private System.Windows.Forms.Button btnAdicionarProduto;
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
        private Controllers.LpText lpText1;
    }
}
