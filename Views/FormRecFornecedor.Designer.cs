namespace LaPizza.Views
{
    partial class FormRecFornecedor
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
            this.txtFornecedorId = new LaPizza.Controllers.LpText();
            this.IdCliente = new System.Windows.Forms.Label();
            this.txtFornecedorRazaoSocial = new LaPizza.Controllers.LpText();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFornecedorNomeFantasia = new LaPizza.Controllers.LpText();
            this.txtFornecedorCnpjCpf = new LaPizza.Controllers.LpText();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFornecedorInscricaoEstadual = new LaPizza.Controllers.LpText();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFornecedorTelefone = new LaPizza.Controllers.LpText();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFornecedorEndereco = new LaPizza.Controllers.LpText();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFornecedorNumero = new LaPizza.Controllers.LpText();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFornecedorCidade = new LaPizza.Controllers.LpText();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFornecedorEstado = new LaPizza.Controllers.LpText();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFornecedorEmail = new LaPizza.Controllers.LpText();
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFornecedorBairro = new LaPizza.Controllers.LpText();
            this.pnlPrincipal.SuspendLayout();
            this.pnlNomeRotina.SuspendLayout();
            this.pnlAcoesMenu.SuspendLayout();
            this.pnlAcoesRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.label11);
            this.pnlPrincipal.Controls.Add(this.txtFornecedorBairro);
            this.pnlPrincipal.Controls.Add(this.cbAtivo);
            this.pnlPrincipal.Controls.Add(this.label10);
            this.pnlPrincipal.Controls.Add(this.txtFornecedorEmail);
            this.pnlPrincipal.Controls.Add(this.label9);
            this.pnlPrincipal.Controls.Add(this.txtFornecedorEstado);
            this.pnlPrincipal.Controls.Add(this.label8);
            this.pnlPrincipal.Controls.Add(this.txtFornecedorCidade);
            this.pnlPrincipal.Controls.Add(this.label7);
            this.pnlPrincipal.Controls.Add(this.txtFornecedorNumero);
            this.pnlPrincipal.Controls.Add(this.label6);
            this.pnlPrincipal.Controls.Add(this.txtFornecedorEndereco);
            this.pnlPrincipal.Controls.Add(this.label5);
            this.pnlPrincipal.Controls.Add(this.txtFornecedorTelefone);
            this.pnlPrincipal.Controls.Add(this.label4);
            this.pnlPrincipal.Controls.Add(this.txtFornecedorInscricaoEstadual);
            this.pnlPrincipal.Controls.Add(this.label3);
            this.pnlPrincipal.Controls.Add(this.txtFornecedorCnpjCpf);
            this.pnlPrincipal.Controls.Add(this.label2);
            this.pnlPrincipal.Controls.Add(this.txtFornecedorNomeFantasia);
            this.pnlPrincipal.Controls.Add(this.label1);
            this.pnlPrincipal.Controls.Add(this.txtFornecedorRazaoSocial);
            this.pnlPrincipal.Controls.Add(this.IdCliente);
            this.pnlPrincipal.Controls.Add(this.txtFornecedorId);
            this.pnlPrincipal.Size = new System.Drawing.Size(645, 178);
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
            this.lbNomeRotina.Text = "Cadastro Fornecedor";
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 275);
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
            // txtFornecedorId
            // 
            this.txtFornecedorId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFornecedorId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedorId.ForeColor = System.Drawing.Color.Black;
            this.txtFornecedorId.Location = new System.Drawing.Point(12, 21);
            this.txtFornecedorId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtFornecedorId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtFornecedorId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtFornecedorId.Name = "txtFornecedorId";
            this.txtFornecedorId.Size = new System.Drawing.Size(70, 22);
            this.txtFornecedorId.TabIndex = 0;
            // 
            // IdCliente
            // 
            this.IdCliente.AutoSize = true;
            this.IdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.IdCliente.Location = new System.Drawing.Point(9, 3);
            this.IdCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.Size = new System.Drawing.Size(19, 17);
            this.IdCliente.TabIndex = 17;
            this.IdCliente.Text = "Id";
            // 
            // txtFornecedorRazaoSocial
            // 
            this.txtFornecedorRazaoSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFornecedorRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedorRazaoSocial.ForeColor = System.Drawing.Color.Black;
            this.txtFornecedorRazaoSocial.Location = new System.Drawing.Point(88, 21);
            this.txtFornecedorRazaoSocial.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtFornecedorRazaoSocial.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtFornecedorRazaoSocial.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtFornecedorRazaoSocial.Name = "txtFornecedorRazaoSocial";
            this.txtFornecedorRazaoSocial.Size = new System.Drawing.Size(296, 22);
            this.txtFornecedorRazaoSocial.TabIndex = 18;
            this.txtFornecedorRazaoSocial.TextChanged += new System.EventHandler(this.txtFornecedorRazaoSocial_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(85, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Razão Social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(387, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nome Fantasia";
            // 
            // txtFornecedorNomeFantasia
            // 
            this.txtFornecedorNomeFantasia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFornecedorNomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedorNomeFantasia.ForeColor = System.Drawing.Color.Black;
            this.txtFornecedorNomeFantasia.Location = new System.Drawing.Point(390, 21);
            this.txtFornecedorNomeFantasia.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtFornecedorNomeFantasia.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtFornecedorNomeFantasia.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtFornecedorNomeFantasia.Name = "txtFornecedorNomeFantasia";
            this.txtFornecedorNomeFantasia.Size = new System.Drawing.Size(248, 22);
            this.txtFornecedorNomeFantasia.TabIndex = 20;
            // 
            // txtFornecedorCnpjCpf
            // 
            this.txtFornecedorCnpjCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFornecedorCnpjCpf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedorCnpjCpf.ForeColor = System.Drawing.Color.Black;
            this.txtFornecedorCnpjCpf.Location = new System.Drawing.Point(12, 64);
            this.txtFornecedorCnpjCpf.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtFornecedorCnpjCpf.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtFornecedorCnpjCpf.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtFornecedorCnpjCpf.Name = "txtFornecedorCnpjCpf";
            this.txtFornecedorCnpjCpf.Size = new System.Drawing.Size(157, 22);
            this.txtFornecedorCnpjCpf.TabIndex = 22;
            this.txtFornecedorCnpjCpf.Leave += new System.EventHandler(this.txtFornecedorCnpjCpf_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(9, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "CNPJ/CPF";
            // 
            // txtFornecedorInscricaoEstadual
            // 
            this.txtFornecedorInscricaoEstadual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFornecedorInscricaoEstadual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedorInscricaoEstadual.ForeColor = System.Drawing.Color.Black;
            this.txtFornecedorInscricaoEstadual.Location = new System.Drawing.Point(175, 64);
            this.txtFornecedorInscricaoEstadual.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtFornecedorInscricaoEstadual.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtFornecedorInscricaoEstadual.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtFornecedorInscricaoEstadual.Name = "txtFornecedorInscricaoEstadual";
            this.txtFornecedorInscricaoEstadual.Size = new System.Drawing.Size(276, 22);
            this.txtFornecedorInscricaoEstadual.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(171, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Inscrição Estadual";
            // 
            // txtFornecedorTelefone
            // 
            this.txtFornecedorTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFornecedorTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedorTelefone.ForeColor = System.Drawing.Color.Black;
            this.txtFornecedorTelefone.Location = new System.Drawing.Point(457, 64);
            this.txtFornecedorTelefone.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtFornecedorTelefone.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtFornecedorTelefone.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtFornecedorTelefone.Name = "txtFornecedorTelefone";
            this.txtFornecedorTelefone.Size = new System.Drawing.Size(181, 22);
            this.txtFornecedorTelefone.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(453, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(8, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Endereço";
            // 
            // txtFornecedorEndereco
            // 
            this.txtFornecedorEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFornecedorEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedorEndereco.ForeColor = System.Drawing.Color.Black;
            this.txtFornecedorEndereco.Location = new System.Drawing.Point(12, 106);
            this.txtFornecedorEndereco.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtFornecedorEndereco.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtFornecedorEndereco.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtFornecedorEndereco.Name = "txtFornecedorEndereco";
            this.txtFornecedorEndereco.Size = new System.Drawing.Size(439, 22);
            this.txtFornecedorEndereco.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(454, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Número";
            // 
            // txtFornecedorNumero
            // 
            this.txtFornecedorNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFornecedorNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedorNumero.ForeColor = System.Drawing.Color.Black;
            this.txtFornecedorNumero.Location = new System.Drawing.Point(457, 106);
            this.txtFornecedorNumero.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtFornecedorNumero.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtFornecedorNumero.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtFornecedorNumero.Name = "txtFornecedorNumero";
            this.txtFornecedorNumero.Size = new System.Drawing.Size(75, 22);
            this.txtFornecedorNumero.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(9, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Cidade";
            // 
            // txtFornecedorCidade
            // 
            this.txtFornecedorCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFornecedorCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedorCidade.ForeColor = System.Drawing.Color.Black;
            this.txtFornecedorCidade.Location = new System.Drawing.Point(12, 148);
            this.txtFornecedorCidade.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtFornecedorCidade.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtFornecedorCidade.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtFornecedorCidade.Name = "txtFornecedorCidade";
            this.txtFornecedorCidade.Size = new System.Drawing.Size(140, 22);
            this.txtFornecedorCidade.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(535, 88);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Estado";
            // 
            // txtFornecedorEstado
            // 
            this.txtFornecedorEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFornecedorEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedorEstado.ForeColor = System.Drawing.Color.Black;
            this.txtFornecedorEstado.Location = new System.Drawing.Point(538, 106);
            this.txtFornecedorEstado.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtFornecedorEstado.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtFornecedorEstado.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtFornecedorEstado.Name = "txtFornecedorEstado";
            this.txtFornecedorEstado.Size = new System.Drawing.Size(100, 22);
            this.txtFornecedorEstado.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(260, 131);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "E-mail";
            // 
            // txtFornecedorEmail
            // 
            this.txtFornecedorEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFornecedorEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedorEmail.ForeColor = System.Drawing.Color.Black;
            this.txtFornecedorEmail.Location = new System.Drawing.Point(264, 148);
            this.txtFornecedorEmail.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtFornecedorEmail.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtFornecedorEmail.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtFornecedorEmail.Name = "txtFornecedorEmail";
            this.txtFornecedorEmail.Size = new System.Drawing.Size(310, 22);
            this.txtFornecedorEmail.TabIndex = 36;
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Checked = true;
            this.cbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAtivo.Location = new System.Drawing.Point(578, 147);
            this.cbAtivo.Margin = new System.Windows.Forms.Padding(4);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.cbAtivo.Size = new System.Drawing.Size(66, 22);
            this.cbAtivo.TabIndex = 38;
            this.cbAtivo.Text = "Ativo?";
            this.cbAtivo.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.Location = new System.Drawing.Point(155, 130);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 40;
            this.label11.Text = "Bairro";
            // 
            // txtFornecedorBairro
            // 
            this.txtFornecedorBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFornecedorBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedorBairro.ForeColor = System.Drawing.Color.Black;
            this.txtFornecedorBairro.Location = new System.Drawing.Point(158, 148);
            this.txtFornecedorBairro.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtFornecedorBairro.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtFornecedorBairro.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtFornecedorBairro.Name = "txtFornecedorBairro";
            this.txtFornecedorBairro.Size = new System.Drawing.Size(100, 22);
            this.txtFornecedorBairro.TabIndex = 39;
            // 
            // FormRecFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(645, 324);
            this.Name = "FormRecFornecedor";
            this.Text = "Cadastro Fornecedor";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlNomeRotina.ResumeLayout(false);
            this.pnlAcoesMenu.ResumeLayout(false);
            this.pnlAcoesMenu.PerformLayout();
            this.pnlAcoesRodape.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controllers.LpText txtFornecedorId;
        private System.Windows.Forms.Label IdCliente;
        private System.Windows.Forms.Label label1;
        private Controllers.LpText txtFornecedorRazaoSocial;
        private System.Windows.Forms.Label label2;
        private Controllers.LpText txtFornecedorNomeFantasia;
        private System.Windows.Forms.Label label3;
        private Controllers.LpText txtFornecedorCnpjCpf;
        private System.Windows.Forms.Label label7;
        private Controllers.LpText txtFornecedorNumero;
        private System.Windows.Forms.Label label6;
        private Controllers.LpText txtFornecedorEndereco;
        private System.Windows.Forms.Label label5;
        private Controllers.LpText txtFornecedorTelefone;
        private System.Windows.Forms.Label label4;
        private Controllers.LpText txtFornecedorInscricaoEstadual;
        private System.Windows.Forms.Label label10;
        private Controllers.LpText txtFornecedorEmail;
        private System.Windows.Forms.Label label9;
        private Controllers.LpText txtFornecedorEstado;
        private System.Windows.Forms.Label label8;
        private Controllers.LpText txtFornecedorCidade;
        public System.Windows.Forms.CheckBox cbAtivo;
        private System.Windows.Forms.Label label11;
        private Controllers.LpText txtFornecedorBairro;
    }
}
