namespace LaPizza.Views
{
    partial class FormEstSubgrupo
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
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.txtGrupoDescricao = new LaPizza.Controllers.LpText();
            this.txtGrupoId = new LaPizza.Controllers.LpText();
            this.lbGrupoDescricao = new System.Windows.Forms.Label();
            this.lbGrupoId = new System.Windows.Forms.Label();
            this.txtSubgrupoDescricao = new LaPizza.Controllers.LpText();
            this.txtSubgrupoId = new LaPizza.Controllers.LpText();
            this.lbSubgrupoDescricao = new System.Windows.Forms.Label();
            this.lbSubgrupoId = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            this.pnlNomeRotina.SuspendLayout();
            this.pnlAcoesMenu.SuspendLayout();
            this.pnlAcoesRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.txtSubgrupoDescricao);
            this.pnlPrincipal.Controls.Add(this.txtSubgrupoId);
            this.pnlPrincipal.Controls.Add(this.lbSubgrupoDescricao);
            this.pnlPrincipal.Controls.Add(this.lbSubgrupoId);
            this.pnlPrincipal.Controls.Add(this.cbAtivo);
            this.pnlPrincipal.Controls.Add(this.txtGrupoDescricao);
            this.pnlPrincipal.Controls.Add(this.txtGrupoId);
            this.pnlPrincipal.Controls.Add(this.lbGrupoDescricao);
            this.pnlPrincipal.Controls.Add(this.lbGrupoId);
            this.pnlPrincipal.Size = new System.Drawing.Size(485, 107);
            // 
            // pnlNomeRotina
            // 
            this.pnlNomeRotina.Size = new System.Drawing.Size(485, 40);
            // 
            // pnlAcoesMenu
            // 
            this.pnlAcoesMenu.Size = new System.Drawing.Size(485, 39);
            // 
            // btnAcaoAdicionar
            // 
            this.btnAcaoAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAcaoAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.Location = new System.Drawing.Point(345, 5);
            this.btnAcaoAdicionar.Click += new System.EventHandler(this.btnAcaoAdicionar_Click);
            // 
            // btnAcaoEditar
            // 
            this.btnAcaoEditar.FlatAppearance.BorderSize = 0;
            this.btnAcaoEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.Location = new System.Drawing.Point(380, 5);
            this.btnAcaoEditar.Click += new System.EventHandler(this.btnAcaoEditar_Click);
            // 
            // btnAcaoConsultar
            // 
            this.btnAcaoConsultar.FlatAppearance.BorderSize = 0;
            this.btnAcaoConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.Location = new System.Drawing.Point(415, 5);
            this.btnAcaoConsultar.Click += new System.EventHandler(this.btnAcaoConsultar_Click);
            // 
            // lbNomeRotina
            // 
            this.lbNomeRotina.Size = new System.Drawing.Size(485, 40);
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 186);
            this.pnlAcoesRodape.Size = new System.Drawing.Size(485, 40);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.Location = new System.Drawing.Point(335, 5);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSair.Location = new System.Drawing.Point(410, 5);
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAcaoExcluir
            // 
            this.btnAcaoExcluir.FlatAppearance.BorderSize = 0;
            this.btnAcaoExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.Location = new System.Drawing.Point(450, 5);
            this.btnAcaoExcluir.Click += new System.EventHandler(this.btnAcaoExcluir_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(260, 5);
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(375, 5);
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Checked = true;
            this.cbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAtivo.Location = new System.Drawing.Point(423, 70);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.cbAtivo.Size = new System.Drawing.Size(56, 19);
            this.cbAtivo.TabIndex = 3;
            this.cbAtivo.Text = "Ativo?";
            this.cbAtivo.UseVisualStyleBackColor = true;
            // 
            // txtGrupoDescricao
            // 
            this.txtGrupoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrupoDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGrupoDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtGrupoDescricao.Location = new System.Drawing.Point(81, 31);
            this.txtGrupoDescricao.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtGrupoDescricao.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtGrupoDescricao.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtGrupoDescricao.Name = "txtGrupoDescricao";
            this.txtGrupoDescricao.Size = new System.Drawing.Size(392, 20);
            this.txtGrupoDescricao.TabIndex = 28;
            // 
            // txtGrupoId
            // 
            this.txtGrupoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrupoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGrupoId.ForeColor = System.Drawing.Color.Black;
            this.txtGrupoId.Location = new System.Drawing.Point(12, 31);
            this.txtGrupoId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtGrupoId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtGrupoId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Integer;
            this.txtGrupoId.Name = "txtGrupoId";
            this.txtGrupoId.Size = new System.Drawing.Size(70, 20);
            this.txtGrupoId.TabIndex = 0;
            this.txtGrupoId.TextChanged += new System.EventHandler(this.txtGrupoId_TextChanged);
            this.txtGrupoId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGrupoId_KeyUp);
            // 
            // lbGrupoDescricao
            // 
            this.lbGrupoDescricao.AutoSize = true;
            this.lbGrupoDescricao.Location = new System.Drawing.Point(78, 15);
            this.lbGrupoDescricao.Name = "lbGrupoDescricao";
            this.lbGrupoDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbGrupoDescricao.TabIndex = 26;
            this.lbGrupoDescricao.Text = "Descrição";
            // 
            // lbGrupoId
            // 
            this.lbGrupoId.AutoSize = true;
            this.lbGrupoId.Location = new System.Drawing.Point(9, 15);
            this.lbGrupoId.Name = "lbGrupoId";
            this.lbGrupoId.Size = new System.Drawing.Size(54, 13);
            this.lbGrupoId.TabIndex = 25;
            this.lbGrupoId.Text = "Grupo(F2)";
            // 
            // txtSubgrupoDescricao
            // 
            this.txtSubgrupoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubgrupoDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubgrupoDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtSubgrupoDescricao.Location = new System.Drawing.Point(81, 70);
            this.txtSubgrupoDescricao.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtSubgrupoDescricao.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtSubgrupoDescricao.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtSubgrupoDescricao.Name = "txtSubgrupoDescricao";
            this.txtSubgrupoDescricao.Size = new System.Drawing.Size(336, 20);
            this.txtSubgrupoDescricao.TabIndex = 2;
            this.txtSubgrupoDescricao.TextChanged += new System.EventHandler(this.txtSubgrupoDescricao_TextChanged);
            // 
            // txtSubgrupoId
            // 
            this.txtSubgrupoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubgrupoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubgrupoId.ForeColor = System.Drawing.Color.Black;
            this.txtSubgrupoId.Location = new System.Drawing.Point(12, 70);
            this.txtSubgrupoId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtSubgrupoId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtSubgrupoId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Integer;
            this.txtSubgrupoId.Name = "txtSubgrupoId";
            this.txtSubgrupoId.Size = new System.Drawing.Size(70, 20);
            this.txtSubgrupoId.TabIndex = 1;
            this.txtSubgrupoId.TextChanged += new System.EventHandler(this.txtSubgrupoId_TextChanged);
            this.txtSubgrupoId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSubgrupoId_KeyUp);
            // 
            // lbSubgrupoDescricao
            // 
            this.lbSubgrupoDescricao.AutoSize = true;
            this.lbSubgrupoDescricao.Location = new System.Drawing.Point(78, 54);
            this.lbSubgrupoDescricao.Name = "lbSubgrupoDescricao";
            this.lbSubgrupoDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbSubgrupoDescricao.TabIndex = 31;
            this.lbSubgrupoDescricao.Text = "Descrição";
            // 
            // lbSubgrupoId
            // 
            this.lbSubgrupoId.AutoSize = true;
            this.lbSubgrupoId.Location = new System.Drawing.Point(9, 54);
            this.lbSubgrupoId.Name = "lbSubgrupoId";
            this.lbSubgrupoId.Size = new System.Drawing.Size(73, 13);
            this.lbSubgrupoId.TabIndex = 30;
            this.lbSubgrupoId.Text = "SubGrupo(F2)";
            // 
            // FormEstSubgrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(485, 226);
            this.Name = "FormEstSubgrupo";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlNomeRotina.ResumeLayout(false);
            this.pnlAcoesMenu.ResumeLayout(false);
            this.pnlAcoesMenu.PerformLayout();
            this.pnlAcoesRodape.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckBox cbAtivo;
        private Controllers.LpText txtGrupoDescricao;
        private Controllers.LpText txtGrupoId;
        private System.Windows.Forms.Label lbGrupoDescricao;
        private System.Windows.Forms.Label lbGrupoId;
        private Controllers.LpText txtSubgrupoDescricao;
        private Controllers.LpText txtSubgrupoId;
        private System.Windows.Forms.Label lbSubgrupoDescricao;
        private System.Windows.Forms.Label lbSubgrupoId;
    }
}
