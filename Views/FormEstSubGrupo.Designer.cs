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
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlPrincipal.Size = new System.Drawing.Size(647, 132);
            // 
            // pnlNomeRotina
            // 
            this.pnlNomeRotina.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlNomeRotina.Size = new System.Drawing.Size(647, 49);
            // 
            // pnlAcoesMenu
            // 
            this.pnlAcoesMenu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlAcoesMenu.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.pnlAcoesMenu.Size = new System.Drawing.Size(647, 48);
            // 
            // btnAcaoAdicionar
            // 
            this.btnAcaoAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAcaoAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.Location = new System.Drawing.Point(405, 7);
            this.btnAcaoAdicionar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAcaoAdicionar.MaximumSize = new System.Drawing.Size(71, 60);
            this.btnAcaoAdicionar.MinimumSize = new System.Drawing.Size(53, 46);
            this.btnAcaoAdicionar.Size = new System.Drawing.Size(53, 46);
            this.btnAcaoAdicionar.Click += new System.EventHandler(this.btnAcaoAdicionar_Click);
            // 
            // btnAcaoEditar
            // 
            this.btnAcaoEditar.FlatAppearance.BorderSize = 0;
            this.btnAcaoEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.Location = new System.Drawing.Point(465, 7);
            this.btnAcaoEditar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAcaoEditar.MaximumSize = new System.Drawing.Size(71, 60);
            this.btnAcaoEditar.MinimumSize = new System.Drawing.Size(53, 46);
            this.btnAcaoEditar.Size = new System.Drawing.Size(53, 46);
            this.btnAcaoEditar.Click += new System.EventHandler(this.btnAcaoEditar_Click);
            // 
            // btnAcaoConsultar
            // 
            this.btnAcaoConsultar.FlatAppearance.BorderSize = 0;
            this.btnAcaoConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.Location = new System.Drawing.Point(525, 7);
            this.btnAcaoConsultar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAcaoConsultar.MaximumSize = new System.Drawing.Size(71, 60);
            this.btnAcaoConsultar.MinimumSize = new System.Drawing.Size(53, 46);
            this.btnAcaoConsultar.Size = new System.Drawing.Size(53, 46);
            this.btnAcaoConsultar.Click += new System.EventHandler(this.btnAcaoConsultar_Click);
            // 
            // lbNomeRotina
            // 
            this.lbNomeRotina.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbNomeRotina.Size = new System.Drawing.Size(647, 49);
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 229);
            this.pnlAcoesRodape.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlAcoesRodape.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.pnlAcoesRodape.Size = new System.Drawing.Size(647, 49);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.Location = new System.Drawing.Point(445, 7);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCancelar.Size = new System.Drawing.Size(93, 35);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSair.Location = new System.Drawing.Point(545, 7);
            this.btnSair.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSair.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.btnSair.Size = new System.Drawing.Size(93, 35);
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAcaoExcluir
            // 
            this.btnAcaoExcluir.FlatAppearance.BorderSize = 0;
            this.btnAcaoExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.Location = new System.Drawing.Point(585, 7);
            this.btnAcaoExcluir.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAcaoExcluir.MaximumSize = new System.Drawing.Size(71, 60);
            this.btnAcaoExcluir.MinimumSize = new System.Drawing.Size(53, 46);
            this.btnAcaoExcluir.Size = new System.Drawing.Size(53, 46);
            this.btnAcaoExcluir.Click += new System.EventHandler(this.btnAcaoExcluir_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(345, 7);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnConfirmar.Size = new System.Drawing.Size(93, 35);
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(458, 7);
            this.splitter3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.splitter3.Size = new System.Drawing.Size(7, 34);
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Checked = true;
            this.cbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAtivo.Location = new System.Drawing.Point(564, 86);
            this.cbAtivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.cbAtivo.Size = new System.Drawing.Size(66, 22);
            this.cbAtivo.TabIndex = 3;
            this.cbAtivo.Text = "Ativo?";
            this.cbAtivo.UseVisualStyleBackColor = true;
            // 
            // txtGrupoDescricao
            // 
            this.txtGrupoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrupoDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGrupoDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtGrupoDescricao.Location = new System.Drawing.Point(108, 38);
            this.txtGrupoDescricao.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtGrupoDescricao.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtGrupoDescricao.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtGrupoDescricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGrupoDescricao.Name = "txtGrupoDescricao";
            this.txtGrupoDescricao.Size = new System.Drawing.Size(522, 22);
            this.txtGrupoDescricao.TabIndex = 28;
            // 
            // txtGrupoId
            // 
            this.txtGrupoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrupoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGrupoId.ForeColor = System.Drawing.Color.Black;
            this.txtGrupoId.Location = new System.Drawing.Point(16, 38);
            this.txtGrupoId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtGrupoId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtGrupoId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Integer;
            this.txtGrupoId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGrupoId.Name = "txtGrupoId";
            this.txtGrupoId.Size = new System.Drawing.Size(93, 22);
            this.txtGrupoId.TabIndex = 0;
            this.txtGrupoId.TextChanged += new System.EventHandler(this.txtGrupoId_TextChanged);
            this.txtGrupoId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGrupoId_KeyUp);
            // 
            // lbGrupoDescricao
            // 
            this.lbGrupoDescricao.AutoSize = true;
            this.lbGrupoDescricao.Location = new System.Drawing.Point(104, 18);
            this.lbGrupoDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGrupoDescricao.Name = "lbGrupoDescricao";
            this.lbGrupoDescricao.Size = new System.Drawing.Size(69, 16);
            this.lbGrupoDescricao.TabIndex = 26;
            this.lbGrupoDescricao.Text = "Descrição";
            // 
            // lbGrupoId
            // 
            this.lbGrupoId.AutoSize = true;
            this.lbGrupoId.Location = new System.Drawing.Point(12, 18);
            this.lbGrupoId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGrupoId.Name = "lbGrupoId";
            this.lbGrupoId.Size = new System.Drawing.Size(67, 16);
            this.lbGrupoId.TabIndex = 25;
            this.lbGrupoId.Text = "Grupo(F2)";
            // 
            // txtSubgrupoDescricao
            // 
            this.txtSubgrupoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubgrupoDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubgrupoDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtSubgrupoDescricao.Location = new System.Drawing.Point(108, 86);
            this.txtSubgrupoDescricao.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtSubgrupoDescricao.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtSubgrupoDescricao.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtSubgrupoDescricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubgrupoDescricao.Name = "txtSubgrupoDescricao";
            this.txtSubgrupoDescricao.Size = new System.Drawing.Size(447, 22);
            this.txtSubgrupoDescricao.TabIndex = 2;
            this.txtSubgrupoDescricao.TextChanged += new System.EventHandler(this.txtSubgrupoDescricao_TextChanged);
            // 
            // txtSubgrupoId
            // 
            this.txtSubgrupoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubgrupoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubgrupoId.ForeColor = System.Drawing.Color.Black;
            this.txtSubgrupoId.Location = new System.Drawing.Point(16, 86);
            this.txtSubgrupoId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtSubgrupoId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtSubgrupoId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Integer;
            this.txtSubgrupoId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubgrupoId.Name = "txtSubgrupoId";
            this.txtSubgrupoId.Size = new System.Drawing.Size(93, 22);
            this.txtSubgrupoId.TabIndex = 1;
            this.txtSubgrupoId.TextChanged += new System.EventHandler(this.txtSubgrupoId_TextChanged);
            this.txtSubgrupoId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSubgrupoId_KeyUp);
            // 
            // lbSubgrupoDescricao
            // 
            this.lbSubgrupoDescricao.AutoSize = true;
            this.lbSubgrupoDescricao.Location = new System.Drawing.Point(104, 66);
            this.lbSubgrupoDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSubgrupoDescricao.Name = "lbSubgrupoDescricao";
            this.lbSubgrupoDescricao.Size = new System.Drawing.Size(69, 16);
            this.lbSubgrupoDescricao.TabIndex = 31;
            this.lbSubgrupoDescricao.Text = "Descrição";
            // 
            // lbSubgrupoId
            // 
            this.lbSubgrupoId.AutoSize = true;
            this.lbSubgrupoId.Location = new System.Drawing.Point(12, 66);
            this.lbSubgrupoId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSubgrupoId.Name = "lbSubgrupoId";
            this.lbSubgrupoId.Size = new System.Drawing.Size(91, 16);
            this.lbSubgrupoId.TabIndex = 30;
            this.lbSubgrupoId.Text = "SubGrupo(F2)";
            // 
            // FormEstSubgrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(647, 278);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
