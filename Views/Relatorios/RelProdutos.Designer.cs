namespace LaPizza.Views.Relatorios
{
    partial class RelProdutos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProdutoDescricao = new LaPizza.Controllers.LpText();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGrupoDescricao = new LaPizza.Controllers.LpText();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGrupoId = new LaPizza.Controllers.LpText();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubgrupoDescricao = new LaPizza.Controllers.LpText();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubgrupoId = new LaPizza.Controllers.LpText();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMarcaDescricao = new LaPizza.Controllers.LpText();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMarcaId = new LaPizza.Controllers.LpText();
            this.cbPesquisarAtivos = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTipoOrdenacao = new System.Windows.Forms.ComboBox();
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
            this.pnlPrincipal.Controls.Add(this.label5);
            this.pnlPrincipal.Controls.Add(this.txtSubgrupoDescricao);
            this.pnlPrincipal.Controls.Add(this.label6);
            this.pnlPrincipal.Controls.Add(this.txtSubgrupoId);
            this.pnlPrincipal.Controls.Add(this.label3);
            this.pnlPrincipal.Controls.Add(this.txtGrupoDescricao);
            this.pnlPrincipal.Controls.Add(this.label4);
            this.pnlPrincipal.Controls.Add(this.txtGrupoId);
            this.pnlPrincipal.Controls.Add(this.label2);
            this.pnlPrincipal.Controls.Add(this.txtProdutoDescricao);
            this.pnlPrincipal.Controls.Add(this.label1);
            this.pnlPrincipal.Controls.Add(this.txtProdutoId);
            this.pnlPrincipal.Size = new System.Drawing.Size(387, 225);
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
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 304);
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
            // txtProdutoId
            // 
            this.txtProdutoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdutoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProdutoId.ForeColor = System.Drawing.Color.Black;
            this.txtProdutoId.Location = new System.Drawing.Point(12, 31);
            this.txtProdutoId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtProdutoId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtProdutoId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtProdutoId.Name = "txtProdutoId";
            this.txtProdutoId.Size = new System.Drawing.Size(65, 20);
            this.txtProdutoId.TabIndex = 0;
            this.txtProdutoId.TextChanged += new System.EventHandler(this.txtProdutoId_TextChanged);
            this.txtProdutoId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProdutoId_KeyUp);
            this.txtProdutoId.Leave += new System.EventHandler(this.LeaveGenerico);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição";
            // 
            // txtProdutoDescricao
            // 
            this.txtProdutoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdutoDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProdutoDescricao.Enabled = false;
            this.txtProdutoDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtProdutoDescricao.Location = new System.Drawing.Point(76, 31);
            this.txtProdutoDescricao.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtProdutoDescricao.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtProdutoDescricao.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtProdutoDescricao.Name = "txtProdutoDescricao";
            this.txtProdutoDescricao.Size = new System.Drawing.Size(298, 20);
            this.txtProdutoDescricao.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descrição";
            // 
            // txtGrupoDescricao
            // 
            this.txtGrupoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrupoDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGrupoDescricao.Enabled = false;
            this.txtGrupoDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtGrupoDescricao.Location = new System.Drawing.Point(76, 70);
            this.txtGrupoDescricao.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtGrupoDescricao.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtGrupoDescricao.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtGrupoDescricao.Name = "txtGrupoDescricao";
            this.txtGrupoDescricao.Size = new System.Drawing.Size(298, 20);
            this.txtGrupoDescricao.TabIndex = 6;
            this.txtGrupoDescricao.TextChanged += new System.EventHandler(this.txtGrupoDescricao_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Grupo";
            // 
            // txtGrupoId
            // 
            this.txtGrupoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrupoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGrupoId.ForeColor = System.Drawing.Color.Black;
            this.txtGrupoId.Location = new System.Drawing.Point(12, 70);
            this.txtGrupoId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtGrupoId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtGrupoId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtGrupoId.Name = "txtGrupoId";
            this.txtGrupoId.Size = new System.Drawing.Size(65, 20);
            this.txtGrupoId.TabIndex = 1;
            this.txtGrupoId.TextChanged += new System.EventHandler(this.txtGrupoId_TextChanged);
            this.txtGrupoId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGrupoId_KeyUp);
            this.txtGrupoId.Leave += new System.EventHandler(this.LeaveGenerico);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Descrição";
            // 
            // txtSubgrupoDescricao
            // 
            this.txtSubgrupoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubgrupoDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubgrupoDescricao.Enabled = false;
            this.txtSubgrupoDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtSubgrupoDescricao.Location = new System.Drawing.Point(76, 109);
            this.txtSubgrupoDescricao.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtSubgrupoDescricao.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtSubgrupoDescricao.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtSubgrupoDescricao.Name = "txtSubgrupoDescricao";
            this.txtSubgrupoDescricao.Size = new System.Drawing.Size(298, 20);
            this.txtSubgrupoDescricao.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "SubGrupo";
            // 
            // txtSubgrupoId
            // 
            this.txtSubgrupoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubgrupoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubgrupoId.Enabled = false;
            this.txtSubgrupoId.ForeColor = System.Drawing.Color.Black;
            this.txtSubgrupoId.Location = new System.Drawing.Point(12, 109);
            this.txtSubgrupoId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtSubgrupoId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtSubgrupoId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtSubgrupoId.Name = "txtSubgrupoId";
            this.txtSubgrupoId.Size = new System.Drawing.Size(65, 20);
            this.txtSubgrupoId.TabIndex = 2;
            this.txtSubgrupoId.TextChanged += new System.EventHandler(this.txtSubgrupoId_TextChanged);
            this.txtSubgrupoId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSubgrupoId_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Descrição";
            // 
            // txtMarcaDescricao
            // 
            this.txtMarcaDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarcaDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarcaDescricao.Enabled = false;
            this.txtMarcaDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtMarcaDescricao.Location = new System.Drawing.Point(76, 148);
            this.txtMarcaDescricao.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtMarcaDescricao.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtMarcaDescricao.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtMarcaDescricao.Name = "txtMarcaDescricao";
            this.txtMarcaDescricao.Size = new System.Drawing.Size(298, 20);
            this.txtMarcaDescricao.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Marca";
            // 
            // txtMarcaId
            // 
            this.txtMarcaId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarcaId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarcaId.ForeColor = System.Drawing.Color.Black;
            this.txtMarcaId.Location = new System.Drawing.Point(12, 148);
            this.txtMarcaId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtMarcaId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtMarcaId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtMarcaId.Name = "txtMarcaId";
            this.txtMarcaId.Size = new System.Drawing.Size(65, 20);
            this.txtMarcaId.TabIndex = 3;
            this.txtMarcaId.TextChanged += new System.EventHandler(this.txtMarcaId_TextChanged);
            this.txtMarcaId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMarcaId_KeyUp);
            this.txtMarcaId.Leave += new System.EventHandler(this.LeaveGenerico);
            // 
            // cbPesquisarAtivos
            // 
            this.cbPesquisarAtivos.FormattingEnabled = true;
            this.cbPesquisarAtivos.Items.AddRange(new object[] {
            "Ativo/Inativos",
            "Ativos",
            "Inativos"});
            this.cbPesquisarAtivos.Location = new System.Drawing.Point(12, 187);
            this.cbPesquisarAtivos.Name = "cbPesquisarAtivos";
            this.cbPesquisarAtivos.Size = new System.Drawing.Size(151, 21);
            this.cbPesquisarAtivos.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ativos/Inativos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(166, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ordenar por:";
            // 
            // cbTipoOrdenacao
            // 
            this.cbTipoOrdenacao.FormattingEnabled = true;
            this.cbTipoOrdenacao.Items.AddRange(new object[] {
            "Cod. Produto",
            "Desc. Produto"});
            this.cbTipoOrdenacao.Location = new System.Drawing.Point(169, 187);
            this.cbTipoOrdenacao.Name = "cbTipoOrdenacao";
            this.cbTipoOrdenacao.Size = new System.Drawing.Size(205, 21);
            this.cbTipoOrdenacao.TabIndex = 5;
            // 
            // RelProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(387, 344);
            this.Name = "RelProdutos";
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

        private System.Windows.Forms.Label label7;
        private Controllers.LpText txtMarcaDescricao;
        private System.Windows.Forms.Label label8;
        private Controllers.LpText txtMarcaId;
        private System.Windows.Forms.Label label5;
        private Controllers.LpText txtSubgrupoDescricao;
        private System.Windows.Forms.Label label6;
        private Controllers.LpText txtSubgrupoId;
        private System.Windows.Forms.Label label3;
        private Controllers.LpText txtGrupoDescricao;
        private System.Windows.Forms.Label label4;
        private Controllers.LpText txtGrupoId;
        private System.Windows.Forms.Label label2;
        private Controllers.LpText txtProdutoDescricao;
        private System.Windows.Forms.Label label1;
        private Controllers.LpText txtProdutoId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTipoOrdenacao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbPesquisarAtivos;
    }
}
