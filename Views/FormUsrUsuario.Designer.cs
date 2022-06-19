
namespace LaPizza.Views
{
    partial class FormUsrUsuario
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
            this.label4 = new System.Windows.Forms.Label();
            this.lpTextRepSenha = new LaPizza.Controllers.LpText();
            this.label3 = new System.Windows.Forms.Label();
            this.lpTextSenha = new LaPizza.Controllers.LpText();
            this.label2 = new System.Windows.Forms.Label();
            this.lpTextUsuario = new LaPizza.Controllers.LpText();
            this.label1 = new System.Windows.Forms.Label();
            this.lpTextNomeComp = new LaPizza.Controllers.LpText();
            this.cbAtiva = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lpTextId = new LaPizza.Controllers.LpText();
            this.pnlPrincipal.SuspendLayout();
            this.pnlNomeRotina.SuspendLayout();
            this.pnlAcoesMenu.SuspendLayout();
            this.pnlAcoesRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.label5);
            this.pnlPrincipal.Controls.Add(this.lpTextId);
            this.pnlPrincipal.Controls.Add(this.cbAtiva);
            this.pnlPrincipal.Controls.Add(this.label4);
            this.pnlPrincipal.Controls.Add(this.lpTextRepSenha);
            this.pnlPrincipal.Controls.Add(this.label3);
            this.pnlPrincipal.Controls.Add(this.lpTextSenha);
            this.pnlPrincipal.Controls.Add(this.label2);
            this.pnlPrincipal.Controls.Add(this.lpTextUsuario);
            this.pnlPrincipal.Controls.Add(this.label1);
            this.pnlPrincipal.Controls.Add(this.lpTextNomeComp);
            this.pnlPrincipal.Size = new System.Drawing.Size(348, 164);
            // 
            // pnlNomeRotina
            // 
            this.pnlNomeRotina.Size = new System.Drawing.Size(348, 40);
            // 
            // pnlAcoesMenu
            // 
            this.pnlAcoesMenu.Size = new System.Drawing.Size(348, 39);
            // 
            // btnAcaoAdicionar
            // 
            this.btnAcaoAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAcaoAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.Location = new System.Drawing.Point(208, 5);
            this.btnAcaoAdicionar.Click += new System.EventHandler(this.btnAcaoAdicionar_Click);
            // 
            // btnAcaoEditar
            // 
            this.btnAcaoEditar.FlatAppearance.BorderSize = 0;
            this.btnAcaoEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.Location = new System.Drawing.Point(243, 5);
            this.btnAcaoEditar.Click += new System.EventHandler(this.btnAcaoEditar_Click_1);
            // 
            // btnAcaoConsultar
            // 
            this.btnAcaoConsultar.FlatAppearance.BorderSize = 0;
            this.btnAcaoConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.Location = new System.Drawing.Point(278, 5);
            this.btnAcaoConsultar.Click += new System.EventHandler(this.btnAcaoConsultar_Click_1);
            // 
            // lbNomeRotina
            // 
            this.lbNomeRotina.Size = new System.Drawing.Size(348, 40);
            this.lbNomeRotina.Text = "Cadastro de Usuários";
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 243);
            this.pnlAcoesRodape.Size = new System.Drawing.Size(348, 40);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.Location = new System.Drawing.Point(198, 5);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSair.Location = new System.Drawing.Point(273, 5);
            // 
            // btnAcaoExcluir
            // 
            this.btnAcaoExcluir.FlatAppearance.BorderSize = 0;
            this.btnAcaoExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.Location = new System.Drawing.Point(313, 5);
            this.btnAcaoExcluir.Click += new System.EventHandler(this.btnAcaoExcluir_Click_1);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(123, 5);
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(238, 5);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Repetir Senha";
            // 
            // lpTextRepSenha
            // 
            this.lpTextRepSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lpTextRepSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lpTextRepSenha.ForeColor = System.Drawing.Color.Black;
            this.lpTextRepSenha.Location = new System.Drawing.Point(170, 110);
            this.lpTextRepSenha.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lpTextRepSenha.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.lpTextRepSenha.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.lpTextRepSenha.Margin = new System.Windows.Forms.Padding(2);
            this.lpTextRepSenha.Name = "lpTextRepSenha";
            this.lpTextRepSenha.Size = new System.Drawing.Size(173, 20);
            this.lpTextRepSenha.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Senha";
            // 
            // lpTextSenha
            // 
            this.lpTextSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lpTextSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lpTextSenha.ForeColor = System.Drawing.Color.Black;
            this.lpTextSenha.Location = new System.Drawing.Point(6, 110);
            this.lpTextSenha.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lpTextSenha.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.lpTextSenha.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.lpTextSenha.Margin = new System.Windows.Forms.Padding(2);
            this.lpTextSenha.Name = "lpTextSenha";
            this.lpTextSenha.Size = new System.Drawing.Size(160, 20);
            this.lpTextSenha.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Usuário";
            // 
            // lpTextUsuario
            // 
            this.lpTextUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lpTextUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lpTextUsuario.ForeColor = System.Drawing.Color.Black;
            this.lpTextUsuario.Location = new System.Drawing.Point(6, 66);
            this.lpTextUsuario.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lpTextUsuario.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.lpTextUsuario.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.lpTextUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.lpTextUsuario.Name = "lpTextUsuario";
            this.lpTextUsuario.Size = new System.Drawing.Size(337, 20);
            this.lpTextUsuario.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nome Completo";
            // 
            // lpTextNomeComp
            // 
            this.lpTextNomeComp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lpTextNomeComp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lpTextNomeComp.ForeColor = System.Drawing.Color.Black;
            this.lpTextNomeComp.Location = new System.Drawing.Point(73, 28);
            this.lpTextNomeComp.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lpTextNomeComp.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.lpTextNomeComp.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.lpTextNomeComp.Margin = new System.Windows.Forms.Padding(2);
            this.lpTextNomeComp.Name = "lpTextNomeComp";
            this.lpTextNomeComp.Size = new System.Drawing.Size(270, 20);
            this.lpTextNomeComp.TabIndex = 37;
            // 
            // cbAtiva
            // 
            this.cbAtiva.AutoSize = true;
            this.cbAtiva.Location = new System.Drawing.Point(8, 135);
            this.cbAtiva.Name = "cbAtiva";
            this.cbAtiva.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.cbAtiva.Size = new System.Drawing.Size(56, 19);
            this.cbAtiva.TabIndex = 45;
            this.cbAtiva.Text = "Ativa?";
            this.cbAtiva.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Id";
            // 
            // lpTextId
            // 
            this.lpTextId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lpTextId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lpTextId.ForeColor = System.Drawing.Color.Black;
            this.lpTextId.Location = new System.Drawing.Point(7, 28);
            this.lpTextId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lpTextId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.lpTextId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.lpTextId.Margin = new System.Windows.Forms.Padding(2);
            this.lpTextId.Name = "lpTextId";
            this.lpTextId.Size = new System.Drawing.Size(62, 20);
            this.lpTextId.TabIndex = 46;
            // 
            // FormUsrUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(348, 283);
            this.Name = "FormUsrUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlNomeRotina.ResumeLayout(false);
            this.pnlAcoesMenu.ResumeLayout(false);
            this.pnlAcoesMenu.PerformLayout();
            this.pnlAcoesRodape.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private Controllers.LpText lpTextRepSenha;
        private System.Windows.Forms.Label label3;
        private Controllers.LpText lpTextSenha;
        private System.Windows.Forms.Label label2;
        private Controllers.LpText lpTextUsuario;
        private System.Windows.Forms.Label label1;
        private Controllers.LpText lpTextNomeComp;
        public System.Windows.Forms.CheckBox cbAtiva;
        private System.Windows.Forms.Label label5;
        private Controllers.LpText lpTextId;
    }
}
