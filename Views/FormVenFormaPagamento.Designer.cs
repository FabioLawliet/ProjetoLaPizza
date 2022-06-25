namespace LaPizza.Views
{
    partial class FormVenFormaPagamento
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
            this.cbAtiva = new System.Windows.Forms.CheckBox();
            this.txtPagamentoDescricao = new LaPizza.Controllers.LpText();
            this.txtPagamentoId = new LaPizza.Controllers.LpText();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.cbPermiteDinheiro = new System.Windows.Forms.CheckBox();
            this.cbPermitePix = new System.Windows.Forms.CheckBox();
            this.cbPermiteCartaoDebito = new System.Windows.Forms.CheckBox();
            this.cbPermiteCartaoCredito = new System.Windows.Forms.CheckBox();
            this.gbPermissoes = new System.Windows.Forms.GroupBox();
            this.cbPermiteCheque = new System.Windows.Forms.CheckBox();
            this.cbPermiteCrediario = new System.Windows.Forms.CheckBox();
            this.pnlPrincipal.SuspendLayout();
            this.pnlNomeRotina.SuspendLayout();
            this.pnlAcoesRodape.SuspendLayout();
            this.pnlAcoesMenu.SuspendLayout();
            this.gbPermissoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.gbPermissoes);
            this.pnlPrincipal.Controls.Add(this.cbAtiva);
            this.pnlPrincipal.Controls.Add(this.txtPagamentoDescricao);
            this.pnlPrincipal.Controls.Add(this.txtPagamentoId);
            this.pnlPrincipal.Controls.Add(this.lbDescricao);
            this.pnlPrincipal.Controls.Add(this.lbId);
            this.pnlPrincipal.Size = new System.Drawing.Size(484, 148);
            // 
            // btnAcaoAdicionar
            // 
            this.btnAcaoAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAcaoAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.Click += new System.EventHandler(this.btnAcaoAdicionar_Click);
            // 
            // btnAcaoEditar
            // 
            this.btnAcaoEditar.FlatAppearance.BorderSize = 0;
            this.btnAcaoEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.Click += new System.EventHandler(this.btnAcaoEditar_Click);
            // 
            // btnAcaoConsultar
            // 
            this.btnAcaoConsultar.FlatAppearance.BorderSize = 0;
            this.btnAcaoConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.Click += new System.EventHandler(this.btnAcaoConsultar_Click);
            // 
            // lbNomeRotina
            // 
            this.lbNomeRotina.Text = "Cadastro Forma de Pagamento";
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 227);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAcaoExcluir
            // 
            this.btnAcaoExcluir.FlatAppearance.BorderSize = 0;
            this.btnAcaoExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.Click += new System.EventHandler(this.btnAcaoExcluir_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // cbAtiva
            // 
            this.cbAtiva.AutoSize = true;
            this.cbAtiva.Location = new System.Drawing.Point(424, 31);
            this.cbAtiva.Name = "cbAtiva";
            this.cbAtiva.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.cbAtiva.Size = new System.Drawing.Size(56, 19);
            this.cbAtiva.TabIndex = 24;
            this.cbAtiva.Text = "Ativa?";
            this.cbAtiva.UseVisualStyleBackColor = true;
            // 
            // txtPagamentoDescricao
            // 
            this.txtPagamentoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPagamentoDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPagamentoDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtPagamentoDescricao.Location = new System.Drawing.Point(82, 31);
            this.txtPagamentoDescricao.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtPagamentoDescricao.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtPagamentoDescricao.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtPagamentoDescricao.Name = "txtPagamentoDescricao";
            this.txtPagamentoDescricao.Size = new System.Drawing.Size(336, 20);
            this.txtPagamentoDescricao.TabIndex = 23;
            this.txtPagamentoDescricao.TextChanged += new System.EventHandler(this.txtPagamentoDescricao_TextChanged);
            // 
            // txtPagamentoId
            // 
            this.txtPagamentoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPagamentoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPagamentoId.ForeColor = System.Drawing.Color.Black;
            this.txtPagamentoId.Location = new System.Drawing.Point(13, 31);
            this.txtPagamentoId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtPagamentoId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtPagamentoId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Integer;
            this.txtPagamentoId.Name = "txtPagamentoId";
            this.txtPagamentoId.Size = new System.Drawing.Size(62, 20);
            this.txtPagamentoId.TabIndex = 22;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(79, 15);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbDescricao.TabIndex = 21;
            this.lbDescricao.Text = "Descrição";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(10, 15);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(16, 13);
            this.lbId.TabIndex = 20;
            this.lbId.Text = "Id";
            // 
            // cbPermiteDinheiro
            // 
            this.cbPermiteDinheiro.AutoSize = true;
            this.cbPermiteDinheiro.Location = new System.Drawing.Point(15, 19);
            this.cbPermiteDinheiro.Name = "cbPermiteDinheiro";
            this.cbPermiteDinheiro.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.cbPermiteDinheiro.Size = new System.Drawing.Size(65, 19);
            this.cbPermiteDinheiro.TabIndex = 25;
            this.cbPermiteDinheiro.Text = "Dinheiro";
            this.cbPermiteDinheiro.UseVisualStyleBackColor = true;
            // 
            // cbPermitePix
            // 
            this.cbPermitePix.AutoSize = true;
            this.cbPermitePix.Location = new System.Drawing.Point(115, 19);
            this.cbPermitePix.Name = "cbPermitePix";
            this.cbPermitePix.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.cbPermitePix.Size = new System.Drawing.Size(40, 19);
            this.cbPermitePix.TabIndex = 26;
            this.cbPermitePix.Text = "Pix";
            this.cbPermitePix.UseVisualStyleBackColor = true;
            // 
            // cbPermiteCartaoDebito
            // 
            this.cbPermiteCartaoDebito.AutoSize = true;
            this.cbPermiteCartaoDebito.Location = new System.Drawing.Point(228, 19);
            this.cbPermiteCartaoDebito.Name = "cbPermiteCartaoDebito";
            this.cbPermiteCartaoDebito.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.cbPermiteCartaoDebito.Size = new System.Drawing.Size(91, 19);
            this.cbPermiteCartaoDebito.TabIndex = 27;
            this.cbPermiteCartaoDebito.Text = "Cartao Débito";
            this.cbPermiteCartaoDebito.UseVisualStyleBackColor = true;
            // 
            // cbPermiteCartaoCredito
            // 
            this.cbPermiteCartaoCredito.AutoSize = true;
            this.cbPermiteCartaoCredito.Location = new System.Drawing.Point(354, 19);
            this.cbPermiteCartaoCredito.Name = "cbPermiteCartaoCredito";
            this.cbPermiteCartaoCredito.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.cbPermiteCartaoCredito.Size = new System.Drawing.Size(93, 19);
            this.cbPermiteCartaoCredito.TabIndex = 28;
            this.cbPermiteCartaoCredito.Text = "Cartao Crédito";
            this.cbPermiteCartaoCredito.UseVisualStyleBackColor = true;
            // 
            // gbPermissoes
            // 
            this.gbPermissoes.Controls.Add(this.cbPermiteCheque);
            this.gbPermissoes.Controls.Add(this.cbPermiteCrediario);
            this.gbPermissoes.Controls.Add(this.cbPermitePix);
            this.gbPermissoes.Controls.Add(this.cbPermiteCartaoCredito);
            this.gbPermissoes.Controls.Add(this.cbPermiteDinheiro);
            this.gbPermissoes.Controls.Add(this.cbPermiteCartaoDebito);
            this.gbPermissoes.Location = new System.Drawing.Point(13, 57);
            this.gbPermissoes.Name = "gbPermissoes";
            this.gbPermissoes.Size = new System.Drawing.Size(459, 82);
            this.gbPermissoes.TabIndex = 29;
            this.gbPermissoes.TabStop = false;
            this.gbPermissoes.Text = "Tipo de Pagamento Permitido";
            // 
            // cbPermiteCheque
            // 
            this.cbPermiteCheque.AutoSize = true;
            this.cbPermiteCheque.Location = new System.Drawing.Point(115, 48);
            this.cbPermiteCheque.Name = "cbPermiteCheque";
            this.cbPermiteCheque.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.cbPermiteCheque.Size = new System.Drawing.Size(63, 19);
            this.cbPermiteCheque.TabIndex = 30;
            this.cbPermiteCheque.Text = "Cheque";
            this.cbPermiteCheque.UseVisualStyleBackColor = true;
            // 
            // cbPermiteCrediario
            // 
            this.cbPermiteCrediario.AutoSize = true;
            this.cbPermiteCrediario.Location = new System.Drawing.Point(15, 48);
            this.cbPermiteCrediario.Name = "cbPermiteCrediario";
            this.cbPermiteCrediario.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.cbPermiteCrediario.Size = new System.Drawing.Size(67, 19);
            this.cbPermiteCrediario.TabIndex = 29;
            this.cbPermiteCrediario.Text = "Crediário";
            this.cbPermiteCrediario.UseVisualStyleBackColor = true;
            // 
            // FormVenFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(484, 267);
            this.Name = "FormVenFormaPagamento";
            this.Text = "";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlNomeRotina.ResumeLayout(false);
            this.pnlAcoesRodape.ResumeLayout(false);
            this.pnlAcoesMenu.ResumeLayout(false);
            this.pnlAcoesMenu.PerformLayout();
            this.gbPermissoes.ResumeLayout(false);
            this.gbPermissoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckBox cbAtiva;
        private Controllers.LpText txtPagamentoDescricao;
        private Controllers.LpText txtPagamentoId;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label lbId;
        public System.Windows.Forms.CheckBox cbPermiteDinheiro;
        public System.Windows.Forms.CheckBox cbPermiteCartaoDebito;
        public System.Windows.Forms.CheckBox cbPermitePix;
        private System.Windows.Forms.GroupBox gbPermissoes;
        public System.Windows.Forms.CheckBox cbPermiteCartaoCredito;
        public System.Windows.Forms.CheckBox cbPermiteCheque;
        public System.Windows.Forms.CheckBox cbPermiteCrediario;
    }
}
