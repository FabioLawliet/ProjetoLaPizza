
namespace LaPizza.Views
{
    partial class FrmEstUsuario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lpTextRepSenha = new LaPizza.Controllers.LpText();
            this.label3 = new System.Windows.Forms.Label();
            this.lpTextSenha = new LaPizza.Controllers.LpText();
            this.label2 = new System.Windows.Forms.Label();
            this.lpTextUsuario = new LaPizza.Controllers.LpText();
            this.label1 = new System.Windows.Forms.Label();
            this.lpTextNomeComp = new LaPizza.Controllers.LpText();
            this.pnlPrincipal.SuspendLayout();
            this.pnlNomeRotina.SuspendLayout();
            this.pnlAcoesMenu.SuspendLayout();
            this.pnlAcoesRodape.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.groupBox1);
            this.pnlPrincipal.Controls.Add(this.label4);
            this.pnlPrincipal.Controls.Add(this.lpTextRepSenha);
            this.pnlPrincipal.Controls.Add(this.label3);
            this.pnlPrincipal.Controls.Add(this.lpTextSenha);
            this.pnlPrincipal.Controls.Add(this.label2);
            this.pnlPrincipal.Controls.Add(this.lpTextUsuario);
            this.pnlPrincipal.Controls.Add(this.label1);
            this.pnlPrincipal.Controls.Add(this.lpTextNomeComp);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlPrincipal.Size = new System.Drawing.Size(791, 309);
            // 
            // pnlNomeRotina
            // 
            this.pnlNomeRotina.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlNomeRotina.Size = new System.Drawing.Size(791, 49);
            // 
            // pnlAcoesMenu
            // 
            this.pnlAcoesMenu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlAcoesMenu.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.pnlAcoesMenu.Size = new System.Drawing.Size(791, 48);
            // 
            // btnAcaoAdicionar
            // 
            this.btnAcaoAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAcaoAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.Location = new System.Drawing.Point(549, 7);
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
            this.btnAcaoEditar.Location = new System.Drawing.Point(609, 7);
            this.btnAcaoEditar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAcaoEditar.MaximumSize = new System.Drawing.Size(71, 60);
            this.btnAcaoEditar.MinimumSize = new System.Drawing.Size(53, 46);
            this.btnAcaoEditar.Size = new System.Drawing.Size(53, 46);
            this.btnAcaoEditar.Click += new System.EventHandler(this.btnAcaoEditar_Click_1);
            // 
            // btnAcaoConsultar
            // 
            this.btnAcaoConsultar.FlatAppearance.BorderSize = 0;
            this.btnAcaoConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.Location = new System.Drawing.Point(669, 7);
            this.btnAcaoConsultar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAcaoConsultar.MaximumSize = new System.Drawing.Size(71, 60);
            this.btnAcaoConsultar.MinimumSize = new System.Drawing.Size(53, 46);
            this.btnAcaoConsultar.Size = new System.Drawing.Size(53, 46);
            this.btnAcaoConsultar.Click += new System.EventHandler(this.btnAcaoConsultar_Click_1);
            // 
            // lbNomeRotina
            // 
            this.lbNomeRotina.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbNomeRotina.Size = new System.Drawing.Size(791, 49);
            this.lbNomeRotina.Text = "Cadastro de Usuários";
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 406);
            this.pnlAcoesRodape.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlAcoesRodape.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.pnlAcoesRodape.Size = new System.Drawing.Size(791, 49);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.Location = new System.Drawing.Point(589, 7);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCancelar.Size = new System.Drawing.Size(93, 35);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSair.Location = new System.Drawing.Point(689, 7);
            this.btnSair.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSair.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.btnSair.Size = new System.Drawing.Size(93, 35);
            // 
            // btnAcaoExcluir
            // 
            this.btnAcaoExcluir.FlatAppearance.BorderSize = 0;
            this.btnAcaoExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.Location = new System.Drawing.Point(729, 7);
            this.btnAcaoExcluir.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAcaoExcluir.MaximumSize = new System.Drawing.Size(71, 60);
            this.btnAcaoExcluir.MinimumSize = new System.Drawing.Size(53, 46);
            this.btnAcaoExcluir.Size = new System.Drawing.Size(53, 46);
            this.btnAcaoExcluir.Click += new System.EventHandler(this.btnAcaoExcluir_Click_1);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(489, 7);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnConfirmar.Size = new System.Drawing.Size(93, 35);
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(602, 7);
            this.splitter3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.splitter3.Size = new System.Drawing.Size(7, 34);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbInativo);
            this.groupBox1.Controls.Add(this.rbAtivo);
            this.groupBox1.Location = new System.Drawing.Point(185, 225);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(153, 41);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // rbInativo
            // 
            this.rbInativo.AutoCheck = false;
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(73, 15);
            this.rbInativo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(67, 20);
            this.rbInativo.TabIndex = 1;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            this.rbInativo.Click += new System.EventHandler(this.rbInativo_Click);
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Location = new System.Drawing.Point(5, 15);
            this.rbAtivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(58, 20);
            this.rbAtivo.TabIndex = 0;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            this.rbAtivo.Click += new System.EventHandler(this.rbAtivo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Repetir Senha";
            // 
            // lpTextRepSenha
            // 
            this.lpTextRepSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lpTextRepSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lpTextRepSenha.ForeColor = System.Drawing.Color.Black;
            this.lpTextRepSenha.Location = new System.Drawing.Point(185, 198);
            this.lpTextRepSenha.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lpTextRepSenha.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.lpTextRepSenha.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.lpTextRepSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lpTextRepSenha.Name = "lpTextRepSenha";
            this.lpTextRepSenha.Size = new System.Drawing.Size(421, 22);
            this.lpTextRepSenha.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Senha";
            // 
            // lpTextSenha
            // 
            this.lpTextSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lpTextSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lpTextSenha.ForeColor = System.Drawing.Color.Black;
            this.lpTextSenha.Location = new System.Drawing.Point(185, 154);
            this.lpTextSenha.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lpTextSenha.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.lpTextSenha.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.lpTextSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lpTextSenha.Name = "lpTextSenha";
            this.lpTextSenha.Size = new System.Drawing.Size(421, 22);
            this.lpTextSenha.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Usuário";
            // 
            // lpTextUsuario
            // 
            this.lpTextUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lpTextUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lpTextUsuario.ForeColor = System.Drawing.Color.Black;
            this.lpTextUsuario.Location = new System.Drawing.Point(185, 108);
            this.lpTextUsuario.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lpTextUsuario.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.lpTextUsuario.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.lpTextUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lpTextUsuario.Name = "lpTextUsuario";
            this.lpTextUsuario.Size = new System.Drawing.Size(421, 22);
            this.lpTextUsuario.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nome Completo";
            // 
            // lpTextNomeComp
            // 
            this.lpTextNomeComp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lpTextNomeComp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lpTextNomeComp.ForeColor = System.Drawing.Color.Black;
            this.lpTextNomeComp.Location = new System.Drawing.Point(185, 63);
            this.lpTextNomeComp.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lpTextNomeComp.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.lpTextNomeComp.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.lpTextNomeComp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lpTextNomeComp.Name = "lpTextNomeComp";
            this.lpTextNomeComp.Size = new System.Drawing.Size(421, 22);
            this.lpTextNomeComp.TabIndex = 37;
            // 
            // FrmEstUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(791, 455);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmEstUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlNomeRotina.ResumeLayout(false);
            this.pnlAcoesMenu.ResumeLayout(false);
            this.pnlAcoesMenu.PerformLayout();
            this.pnlAcoesRodape.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.Label label4;
        private Controllers.LpText lpTextRepSenha;
        private System.Windows.Forms.Label label3;
        private Controllers.LpText lpTextSenha;
        private System.Windows.Forms.Label label2;
        private Controllers.LpText lpTextUsuario;
        private System.Windows.Forms.Label label1;
        private Controllers.LpText lpTextNomeComp;
    }
}
