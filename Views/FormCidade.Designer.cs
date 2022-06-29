namespace LaPizza.Views
{
    partial class FormCidade
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
            this.txtCidadeIdEstado = new LaPizza.Controllers.LpText();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCidadeNome = new LaPizza.Controllers.LpText();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCidadeId = new LaPizza.Controllers.LpText();
            this.lbId = new System.Windows.Forms.Label();
            this.txtCidadeNomeEstado = new LaPizza.Controllers.LpText();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            this.pnlNomeRotina.SuspendLayout();
            this.pnlAcoesRodape.SuspendLayout();
            this.pnlAcoesMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.label3);
            this.pnlPrincipal.Controls.Add(this.txtCidadeNomeEstado);
            this.pnlPrincipal.Controls.Add(this.txtCidadeIdEstado);
            this.pnlPrincipal.Controls.Add(this.label2);
            this.pnlPrincipal.Controls.Add(this.txtCidadeNome);
            this.pnlPrincipal.Controls.Add(this.label1);
            this.pnlPrincipal.Controls.Add(this.txtCidadeId);
            this.pnlPrincipal.Controls.Add(this.lbId);
            this.pnlPrincipal.Size = new System.Drawing.Size(645, 89);
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
            this.lbNomeRotina.Text = "Cadastro de Cidade";
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 186);
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
            // txtCidadeIdEstado
            // 
            this.txtCidadeIdEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidadeIdEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidadeIdEstado.ForeColor = System.Drawing.Color.Black;
            this.txtCidadeIdEstado.Location = new System.Drawing.Point(431, 39);
            this.txtCidadeIdEstado.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtCidadeIdEstado.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtCidadeIdEstado.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Integer;
            this.txtCidadeIdEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidadeIdEstado.Name = "txtCidadeIdEstado";
            this.txtCidadeIdEstado.Size = new System.Drawing.Size(80, 22);
            this.txtCidadeIdEstado.TabIndex = 2;
            this.txtCidadeIdEstado.TextChanged += new System.EventHandler(this.txtCidadeIdEstado_TextChanged);
            this.txtCidadeIdEstado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCidadeIdEstado_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "IdEstado(F2)";
            // 
            // txtCidadeNome
            // 
            this.txtCidadeNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidadeNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidadeNome.ForeColor = System.Drawing.Color.Black;
            this.txtCidadeNome.Location = new System.Drawing.Point(79, 39);
            this.txtCidadeNome.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtCidadeNome.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtCidadeNome.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtCidadeNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidadeNome.Name = "txtCidadeNome";
            this.txtCidadeNome.Size = new System.Drawing.Size(344, 22);
            this.txtCidadeNome.TabIndex = 1;
            this.txtCidadeNome.TextChanged += new System.EventHandler(this.txtCidadeNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome Cidade";
            // 
            // txtCidadeId
            // 
            this.txtCidadeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidadeId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidadeId.ForeColor = System.Drawing.Color.Black;
            this.txtCidadeId.Location = new System.Drawing.Point(10, 39);
            this.txtCidadeId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtCidadeId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtCidadeId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Integer;
            this.txtCidadeId.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidadeId.Name = "txtCidadeId";
            this.txtCidadeId.Size = new System.Drawing.Size(61, 22);
            this.txtCidadeId.TabIndex = 0;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(6, 19);
            this.lbId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 16);
            this.lbId.TabIndex = 11;
            this.lbId.Text = "Id";
            // 
            // txtCidadeNomeEstado
            // 
            this.txtCidadeNomeEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidadeNomeEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidadeNomeEstado.ForeColor = System.Drawing.Color.Black;
            this.txtCidadeNomeEstado.Location = new System.Drawing.Point(511, 39);
            this.txtCidadeNomeEstado.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtCidadeNomeEstado.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtCidadeNomeEstado.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Integer;
            this.txtCidadeNomeEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidadeNomeEstado.Name = "txtCidadeNomeEstado";
            this.txtCidadeNomeEstado.Size = new System.Drawing.Size(127, 22);
            this.txtCidadeNomeEstado.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nome Estado";
            // 
            // FormCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(645, 235);
            this.Name = "FormCidade";
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

        private System.Windows.Forms.Label label3;
        private Controllers.LpText txtCidadeNomeEstado;
        private Controllers.LpText txtCidadeIdEstado;
        private System.Windows.Forms.Label label2;
        private Controllers.LpText txtCidadeNome;
        private System.Windows.Forms.Label label1;
        private Controllers.LpText txtCidadeId;
        private System.Windows.Forms.Label lbId;
    }
}
