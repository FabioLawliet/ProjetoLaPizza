namespace LaPizza.Views.Relatorios
{
    partial class RelMarcas
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
            this.label10 = new System.Windows.Forms.Label();
            this.cbTipoOrdenacao = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbPesquisarAtivos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMarcaDescricao = new LaPizza.Controllers.LpText();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMarcaId = new LaPizza.Controllers.LpText();
            this.pnlPrincipal.SuspendLayout();
            this.pnlNomeRotina.SuspendLayout();
            this.pnlAcoesRodape.SuspendLayout();
            this.pnlAcoesMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.label10);
            this.pnlPrincipal.Controls.Add(this.cbTipoOrdenacao);
            this.pnlPrincipal.Controls.Add(this.label9);
            this.pnlPrincipal.Controls.Add(this.cbPesquisarAtivos);
            this.pnlPrincipal.Controls.Add(this.label7);
            this.pnlPrincipal.Controls.Add(this.txtMarcaDescricao);
            this.pnlPrincipal.Controls.Add(this.label8);
            this.pnlPrincipal.Controls.Add(this.txtMarcaId);
            this.pnlPrincipal.Size = new System.Drawing.Size(387, 104);
            // 
            // pnlNomeRotina
            // 
            this.pnlNomeRotina.Size = new System.Drawing.Size(387, 40);
            // 
            // btnAcaoAdicionar
            // 
            this.btnAcaoAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAcaoAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.Location = new System.Drawing.Point(247, 5);
            // 
            // btnAcaoEditar
            // 
            this.btnAcaoEditar.FlatAppearance.BorderSize = 0;
            this.btnAcaoEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.Location = new System.Drawing.Point(282, 5);
            // 
            // btnAcaoConsultar
            // 
            this.btnAcaoConsultar.FlatAppearance.BorderSize = 0;
            this.btnAcaoConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.Location = new System.Drawing.Point(317, 5);
            // 
            // lbNomeRotina
            // 
            this.lbNomeRotina.Size = new System.Drawing.Size(387, 40);
            this.lbNomeRotina.Text = "Form1";
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 183);
            this.pnlAcoesRodape.Size = new System.Drawing.Size(387, 40);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.Location = new System.Drawing.Point(237, 5);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSair.Location = new System.Drawing.Point(312, 5);
            // 
            // btnAcaoExcluir
            // 
            this.btnAcaoExcluir.FlatAppearance.BorderSize = 0;
            this.btnAcaoExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.Location = new System.Drawing.Point(352, 5);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(162, 5);
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(277, 5);
            // 
            // pnlAcoesMenu
            // 
            this.pnlAcoesMenu.Size = new System.Drawing.Size(387, 39);
            this.pnlAcoesMenu.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(166, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Ordenar por:";
            // 
            // cbTipoOrdenacao
            // 
            this.cbTipoOrdenacao.FormattingEnabled = true;
            this.cbTipoOrdenacao.Items.AddRange(new object[] {
            "Cod. Marca",
            "Desc. Marca"});
            this.cbTipoOrdenacao.Location = new System.Drawing.Point(169, 70);
            this.cbTipoOrdenacao.Name = "cbTipoOrdenacao";
            this.cbTipoOrdenacao.Size = new System.Drawing.Size(205, 21);
            this.cbTipoOrdenacao.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Ativos/Inativos";
            // 
            // cbPesquisarAtivos
            // 
            this.cbPesquisarAtivos.FormattingEnabled = true;
            this.cbPesquisarAtivos.Items.AddRange(new object[] {
            "Ativo/Inativos",
            "Ativos",
            "Inativos"});
            this.cbPesquisarAtivos.Location = new System.Drawing.Point(12, 70);
            this.cbPesquisarAtivos.Name = "cbPesquisarAtivos";
            this.cbPesquisarAtivos.Size = new System.Drawing.Size(151, 21);
            this.cbPesquisarAtivos.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Descrição";
            // 
            // txtMarcaDescricao
            // 
            this.txtMarcaDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarcaDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarcaDescricao.Enabled = false;
            this.txtMarcaDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtMarcaDescricao.Location = new System.Drawing.Point(76, 31);
            this.txtMarcaDescricao.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtMarcaDescricao.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtMarcaDescricao.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtMarcaDescricao.Name = "txtMarcaDescricao";
            this.txtMarcaDescricao.Size = new System.Drawing.Size(298, 20);
            this.txtMarcaDescricao.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Marca";
            // 
            // txtMarcaId
            // 
            this.txtMarcaId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarcaId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarcaId.ForeColor = System.Drawing.Color.Black;
            this.txtMarcaId.Location = new System.Drawing.Point(12, 31);
            this.txtMarcaId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtMarcaId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtMarcaId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtMarcaId.Name = "txtMarcaId";
            this.txtMarcaId.Size = new System.Drawing.Size(65, 20);
            this.txtMarcaId.TabIndex = 20;
            this.txtMarcaId.TextChanged += new System.EventHandler(this.txtMarcaId_TextChanged);
            this.txtMarcaId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMarcaId_KeyUp);
            // 
            // RelMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(387, 223);
            this.Name = "RelMarcas";
            this.Text = "";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlNomeRotina.ResumeLayout(false);
            this.pnlAcoesRodape.ResumeLayout(false);
            this.pnlAcoesMenu.ResumeLayout(false);
            this.pnlAcoesMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTipoOrdenacao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbPesquisarAtivos;
        private System.Windows.Forms.Label label7;
        private Controllers.LpText txtMarcaDescricao;
        private System.Windows.Forms.Label label8;
        private Controllers.LpText txtMarcaId;
    }
}
