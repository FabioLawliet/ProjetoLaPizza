namespace LaPizza.Views
{
    partial class FormEstado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEstadoId = new LaPizza.Controllers.LpText();
            this.lbId = new System.Windows.Forms.Label();
            this.txtEstadoNome = new LaPizza.Controllers.LpText();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstadoSigla = new LaPizza.Controllers.LpText();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            this.pnlNomeRotina.SuspendLayout();
            this.pnlAcoesRodape.SuspendLayout();
            this.pnlAcoesMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.txtEstadoSigla);
            this.pnlPrincipal.Controls.Add(this.label2);
            this.pnlPrincipal.Controls.Add(this.txtEstadoNome);
            this.pnlPrincipal.Controls.Add(this.label1);
            this.pnlPrincipal.Controls.Add(this.txtEstadoId);
            this.pnlPrincipal.Controls.Add(this.lbId);
            this.pnlPrincipal.Size = new System.Drawing.Size(645, 99);
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
            this.lbNomeRotina.Text = "Cadastro de Estado";
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 196);
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
            // txtEstadoId
            // 
            this.txtEstadoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstadoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstadoId.ForeColor = System.Drawing.Color.Black;
            this.txtEstadoId.Location = new System.Drawing.Point(13, 42);
            this.txtEstadoId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtEstadoId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtEstadoId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Integer;
            this.txtEstadoId.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstadoId.Name = "txtEstadoId";
            this.txtEstadoId.Size = new System.Drawing.Size(82, 22);
            this.txtEstadoId.TabIndex = 6;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(9, 22);
            this.lbId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 16);
            this.lbId.TabIndex = 5;
            this.lbId.Text = "Id";
            // 
            // txtEstadoNome
            // 
            this.txtEstadoNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstadoNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstadoNome.ForeColor = System.Drawing.Color.Black;
            this.txtEstadoNome.Location = new System.Drawing.Point(103, 42);
            this.txtEstadoNome.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtEstadoNome.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtEstadoNome.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtEstadoNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstadoNome.Name = "txtEstadoNome";
            this.txtEstadoNome.Size = new System.Drawing.Size(460, 22);
            this.txtEstadoNome.TabIndex = 8;
            this.txtEstadoNome.TextChanged += new System.EventHandler(this.txtEstadoNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome Estado";
            // 
            // txtEstadoSigla
            // 
            this.txtEstadoSigla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstadoSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstadoSigla.ForeColor = System.Drawing.Color.Black;
            this.txtEstadoSigla.Location = new System.Drawing.Point(571, 42);
            this.txtEstadoSigla.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtEstadoSigla.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtEstadoSigla.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtEstadoSigla.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstadoSigla.Name = "txtEstadoSigla";
            this.txtEstadoSigla.Size = new System.Drawing.Size(67, 22);
            this.txtEstadoSigla.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "UF Estado";
            // 
            // FormEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(645, 245);
            this.Name = "FormEstado";
            this.Text = "Cadastro de Estado";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlNomeRotina.ResumeLayout(false);
            this.pnlAcoesRodape.ResumeLayout(false);
            this.pnlAcoesMenu.ResumeLayout(false);
            this.pnlAcoesMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controllers.LpText txtEstadoId;
        private System.Windows.Forms.Label lbId;
        private Controllers.LpText txtEstadoSigla;
        private System.Windows.Forms.Label label2;
        private Controllers.LpText txtEstadoNome;
        private System.Windows.Forms.Label label1;
    }
}
