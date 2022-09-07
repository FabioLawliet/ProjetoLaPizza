namespace LaPizza
{
    partial class FormPrincipal
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
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.pnlSubMenuGeral = new System.Windows.Forms.Panel();
            this.btnGerEstado = new System.Windows.Forms.Button();
            this.btnGerCidade = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMenuGeral = new System.Windows.Forms.Button();
            this.pnlSubMenuUsuario = new System.Windows.Forms.Panel();
            this.btnUsuControleAutonomia = new System.Windows.Forms.Button();
            this.btnUsuControleAcesso = new System.Windows.Forms.Button();
            this.btnUsuCadastro = new System.Windows.Forms.Button();
            this.btnMenuUsuario = new System.Windows.Forms.Button();
            this.pnlSubMenuFornecedor = new System.Windows.Forms.Panel();
            this.btnFornCadastro = new System.Windows.Forms.Button();
            this.btnMenuFornecedor = new System.Windows.Forms.Button();
            this.pnlSubMenuEstoque = new System.Windows.Forms.Panel();
            this.btnEstEntradaMerc = new System.Windows.Forms.Button();
            this.btnEstMovimentacaoSimplificada = new System.Windows.Forms.Button();
            this.btnEstProduto = new System.Windows.Forms.Button();
            this.btnEstUnidadeMedida = new System.Windows.Forms.Button();
            this.btnEstSubGrupo = new System.Windows.Forms.Button();
            this.btnEstGrupo = new System.Windows.Forms.Button();
            this.btnEstMarca = new System.Windows.Forms.Button();
            this.btnMenuEstoque = new System.Windows.Forms.Button();
            this.pnlSubMenuVenda = new System.Windows.Forms.Panel();
            this.btnVenRegistrar = new System.Windows.Forms.Button();
            this.btnVenPedido = new System.Windows.Forms.Button();
            this.btnVenFormaPagamento = new System.Windows.Forms.Button();
            this.btnMenuVenda = new System.Windows.Forms.Button();
            this.pnlSubMenuCliente = new System.Windows.Forms.Panel();
            this.btnCliCadastro = new System.Windows.Forms.Button();
            this.btnMenuCliente = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnPesqProdutos = new System.Windows.Forms.Button();
            this.pnlLateral.SuspendLayout();
            this.pnlMenuLateral.SuspendLayout();
            this.pnlSubMenuGeral.SuspendLayout();
            this.pnlSubMenuUsuario.SuspendLayout();
            this.pnlSubMenuFornecedor.SuspendLayout();
            this.pnlSubMenuEstoque.SuspendLayout();
            this.pnlSubMenuVenda.SuspendLayout();
            this.pnlSubMenuCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.Black;
            this.pnlLateral.Controls.Add(this.pnlMenuLateral);
            this.pnlLateral.Controls.Add(this.pnlLogo);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.ForeColor = System.Drawing.Color.Transparent;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(250, 749);
            this.pnlLateral.TabIndex = 4;
            // 
            // pnlMenuLateral
            // 
            this.pnlMenuLateral.AutoScroll = true;
            this.pnlMenuLateral.BackColor = System.Drawing.Color.Black;
            this.pnlMenuLateral.Controls.Add(this.pnlSubMenuGeral);
            this.pnlMenuLateral.Controls.Add(this.btnMenuGeral);
            this.pnlMenuLateral.Controls.Add(this.pnlSubMenuUsuario);
            this.pnlMenuLateral.Controls.Add(this.btnMenuUsuario);
            this.pnlMenuLateral.Controls.Add(this.pnlSubMenuFornecedor);
            this.pnlMenuLateral.Controls.Add(this.btnMenuFornecedor);
            this.pnlMenuLateral.Controls.Add(this.pnlSubMenuEstoque);
            this.pnlMenuLateral.Controls.Add(this.btnMenuEstoque);
            this.pnlMenuLateral.Controls.Add(this.pnlSubMenuVenda);
            this.pnlMenuLateral.Controls.Add(this.btnMenuVenda);
            this.pnlMenuLateral.Controls.Add(this.pnlSubMenuCliente);
            this.pnlMenuLateral.Controls.Add(this.btnMenuCliente);
            this.pnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuLateral.Location = new System.Drawing.Point(0, 100);
            this.pnlMenuLateral.Name = "pnlMenuLateral";
            this.pnlMenuLateral.Size = new System.Drawing.Size(250, 649);
            this.pnlMenuLateral.TabIndex = 5;
            // 
            // pnlSubMenuGeral
            // 
            this.pnlSubMenuGeral.AutoSize = true;
            this.pnlSubMenuGeral.Controls.Add(this.btnGerEstado);
            this.pnlSubMenuGeral.Controls.Add(this.btnGerCidade);
            this.pnlSubMenuGeral.Controls.Add(this.button3);
            this.pnlSubMenuGeral.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuGeral.Location = new System.Drawing.Point(0, 610);
            this.pnlSubMenuGeral.Name = "pnlSubMenuGeral";
            this.pnlSubMenuGeral.Size = new System.Drawing.Size(233, 75);
            this.pnlSubMenuGeral.TabIndex = 11;
            this.pnlSubMenuGeral.Tag = "pnlSubMenu";
            // 
            // btnGerEstado
            // 
            this.btnGerEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnGerEstado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGerEstado.FlatAppearance.BorderSize = 0;
            this.btnGerEstado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGerEstado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnGerEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerEstado.ForeColor = System.Drawing.Color.White;
            this.btnGerEstado.Location = new System.Drawing.Point(0, 50);
            this.btnGerEstado.Name = "btnGerEstado";
            this.btnGerEstado.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGerEstado.Size = new System.Drawing.Size(233, 25);
            this.btnGerEstado.TabIndex = 6;
            this.btnGerEstado.Tag = "btnSubMenu";
            this.btnGerEstado.Text = "Estado";
            this.btnGerEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerEstado.UseVisualStyleBackColor = false;
            this.btnGerEstado.Click += new System.EventHandler(this.btnGerEstado_Click);
            // 
            // btnGerCidade
            // 
            this.btnGerCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnGerCidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGerCidade.FlatAppearance.BorderSize = 0;
            this.btnGerCidade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGerCidade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnGerCidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerCidade.ForeColor = System.Drawing.Color.White;
            this.btnGerCidade.Location = new System.Drawing.Point(0, 25);
            this.btnGerCidade.Name = "btnGerCidade";
            this.btnGerCidade.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGerCidade.Size = new System.Drawing.Size(233, 25);
            this.btnGerCidade.TabIndex = 5;
            this.btnGerCidade.Tag = "btnSubMenu";
            this.btnGerCidade.Text = "Cidade";
            this.btnGerCidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerCidade.UseVisualStyleBackColor = false;
            this.btnGerCidade.Click += new System.EventHandler(this.btnGerCidade_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(233, 25);
            this.button3.TabIndex = 4;
            this.button3.Tag = "btnSubMenu";
            this.button3.Text = "Opcao";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnMenuGeral
            // 
            this.btnMenuGeral.BackColor = System.Drawing.Color.Black;
            this.btnMenuGeral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuGeral.FlatAppearance.BorderSize = 0;
            this.btnMenuGeral.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMenuGeral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnMenuGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuGeral.ForeColor = System.Drawing.Color.White;
            this.btnMenuGeral.Location = new System.Drawing.Point(0, 575);
            this.btnMenuGeral.Name = "btnMenuGeral";
            this.btnMenuGeral.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuGeral.Size = new System.Drawing.Size(233, 35);
            this.btnMenuGeral.TabIndex = 12;
            this.btnMenuGeral.Tag = "btnMenu";
            this.btnMenuGeral.Text = "Geral";
            this.btnMenuGeral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuGeral.UseVisualStyleBackColor = false;
            this.btnMenuGeral.Click += new System.EventHandler(this.btnMenuGeral_Click);
            // 
            // pnlSubMenuUsuario
            // 
            this.pnlSubMenuUsuario.AutoSize = true;
            this.pnlSubMenuUsuario.Controls.Add(this.btnUsuControleAutonomia);
            this.pnlSubMenuUsuario.Controls.Add(this.btnUsuControleAcesso);
            this.pnlSubMenuUsuario.Controls.Add(this.btnUsuCadastro);
            this.pnlSubMenuUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuUsuario.Location = new System.Drawing.Point(0, 500);
            this.pnlSubMenuUsuario.Name = "pnlSubMenuUsuario";
            this.pnlSubMenuUsuario.Size = new System.Drawing.Size(233, 75);
            this.pnlSubMenuUsuario.TabIndex = 9;
            this.pnlSubMenuUsuario.Tag = "pnlSubMenu";
            // 
            // btnUsuControleAutonomia
            // 
            this.btnUsuControleAutonomia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnUsuControleAutonomia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuControleAutonomia.FlatAppearance.BorderSize = 0;
            this.btnUsuControleAutonomia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUsuControleAutonomia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnUsuControleAutonomia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuControleAutonomia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuControleAutonomia.ForeColor = System.Drawing.Color.White;
            this.btnUsuControleAutonomia.Location = new System.Drawing.Point(0, 50);
            this.btnUsuControleAutonomia.Name = "btnUsuControleAutonomia";
            this.btnUsuControleAutonomia.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUsuControleAutonomia.Size = new System.Drawing.Size(233, 25);
            this.btnUsuControleAutonomia.TabIndex = 6;
            this.btnUsuControleAutonomia.Tag = "btnSubMenu";
            this.btnUsuControleAutonomia.Text = "Controle de Autonomia";
            this.btnUsuControleAutonomia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuControleAutonomia.UseVisualStyleBackColor = false;
            // 
            // btnUsuControleAcesso
            // 
            this.btnUsuControleAcesso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnUsuControleAcesso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuControleAcesso.FlatAppearance.BorderSize = 0;
            this.btnUsuControleAcesso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUsuControleAcesso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnUsuControleAcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuControleAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuControleAcesso.ForeColor = System.Drawing.Color.White;
            this.btnUsuControleAcesso.Location = new System.Drawing.Point(0, 25);
            this.btnUsuControleAcesso.Name = "btnUsuControleAcesso";
            this.btnUsuControleAcesso.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUsuControleAcesso.Size = new System.Drawing.Size(233, 25);
            this.btnUsuControleAcesso.TabIndex = 5;
            this.btnUsuControleAcesso.Tag = "btnSubMenu";
            this.btnUsuControleAcesso.Text = "Controle de Acesso";
            this.btnUsuControleAcesso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuControleAcesso.UseVisualStyleBackColor = false;
            // 
            // btnUsuCadastro
            // 
            this.btnUsuCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnUsuCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuCadastro.FlatAppearance.BorderSize = 0;
            this.btnUsuCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUsuCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnUsuCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuCadastro.ForeColor = System.Drawing.Color.White;
            this.btnUsuCadastro.Location = new System.Drawing.Point(0, 0);
            this.btnUsuCadastro.Name = "btnUsuCadastro";
            this.btnUsuCadastro.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUsuCadastro.Size = new System.Drawing.Size(233, 25);
            this.btnUsuCadastro.TabIndex = 4;
            this.btnUsuCadastro.Tag = "btnSubMenu";
            this.btnUsuCadastro.Text = "Cadastro de Usuário";
            this.btnUsuCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuCadastro.UseVisualStyleBackColor = false;
            this.btnUsuCadastro.Click += new System.EventHandler(this.btnUsuCadastro_Click);
            // 
            // btnMenuUsuario
            // 
            this.btnMenuUsuario.BackColor = System.Drawing.Color.Black;
            this.btnMenuUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuUsuario.FlatAppearance.BorderSize = 0;
            this.btnMenuUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMenuUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnMenuUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuUsuario.ForeColor = System.Drawing.Color.White;
            this.btnMenuUsuario.Location = new System.Drawing.Point(0, 465);
            this.btnMenuUsuario.Name = "btnMenuUsuario";
            this.btnMenuUsuario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuUsuario.Size = new System.Drawing.Size(233, 35);
            this.btnMenuUsuario.TabIndex = 10;
            this.btnMenuUsuario.Tag = "btnMenu";
            this.btnMenuUsuario.Text = "Usuário";
            this.btnMenuUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuUsuario.UseVisualStyleBackColor = false;
            this.btnMenuUsuario.Click += new System.EventHandler(this.btnMenuUsuario_Click);
            // 
            // pnlSubMenuFornecedor
            // 
            this.pnlSubMenuFornecedor.AutoSize = true;
            this.pnlSubMenuFornecedor.Controls.Add(this.btnFornCadastro);
            this.pnlSubMenuFornecedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuFornecedor.Location = new System.Drawing.Point(0, 440);
            this.pnlSubMenuFornecedor.Name = "pnlSubMenuFornecedor";
            this.pnlSubMenuFornecedor.Size = new System.Drawing.Size(233, 25);
            this.pnlSubMenuFornecedor.TabIndex = 7;
            this.pnlSubMenuFornecedor.Tag = "pnlSubMenu";
            // 
            // btnFornCadastro
            // 
            this.btnFornCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnFornCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFornCadastro.FlatAppearance.BorderSize = 0;
            this.btnFornCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFornCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnFornCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornCadastro.ForeColor = System.Drawing.Color.White;
            this.btnFornCadastro.Location = new System.Drawing.Point(0, 0);
            this.btnFornCadastro.Name = "btnFornCadastro";
            this.btnFornCadastro.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnFornCadastro.Size = new System.Drawing.Size(233, 25);
            this.btnFornCadastro.TabIndex = 4;
            this.btnFornCadastro.Tag = "btnSubMenu";
            this.btnFornCadastro.Text = "Cadastro de Fornecedor";
            this.btnFornCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFornCadastro.UseVisualStyleBackColor = false;
            this.btnFornCadastro.Click += new System.EventHandler(this.btnFornCadastro_Click);
            // 
            // btnMenuFornecedor
            // 
            this.btnMenuFornecedor.BackColor = System.Drawing.Color.Black;
            this.btnMenuFornecedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuFornecedor.FlatAppearance.BorderSize = 0;
            this.btnMenuFornecedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMenuFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnMenuFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnMenuFornecedor.Location = new System.Drawing.Point(0, 405);
            this.btnMenuFornecedor.Name = "btnMenuFornecedor";
            this.btnMenuFornecedor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuFornecedor.Size = new System.Drawing.Size(233, 35);
            this.btnMenuFornecedor.TabIndex = 8;
            this.btnMenuFornecedor.Tag = "btnMenu";
            this.btnMenuFornecedor.Text = "Fornecedor";
            this.btnMenuFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuFornecedor.UseVisualStyleBackColor = false;
            this.btnMenuFornecedor.Click += new System.EventHandler(this.btnMenuFornecedor_Click);
            // 
            // pnlSubMenuEstoque
            // 
            this.pnlSubMenuEstoque.AutoSize = true;
            this.pnlSubMenuEstoque.Controls.Add(this.btnPesqProdutos);
            this.pnlSubMenuEstoque.Controls.Add(this.btnEstEntradaMerc);
            this.pnlSubMenuEstoque.Controls.Add(this.btnEstMovimentacaoSimplificada);
            this.pnlSubMenuEstoque.Controls.Add(this.btnEstProduto);
            this.pnlSubMenuEstoque.Controls.Add(this.btnEstUnidadeMedida);
            this.pnlSubMenuEstoque.Controls.Add(this.btnEstSubGrupo);
            this.pnlSubMenuEstoque.Controls.Add(this.btnEstGrupo);
            this.pnlSubMenuEstoque.Controls.Add(this.btnEstMarca);
            this.pnlSubMenuEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuEstoque.Location = new System.Drawing.Point(0, 205);
            this.pnlSubMenuEstoque.Name = "pnlSubMenuEstoque";
            this.pnlSubMenuEstoque.Size = new System.Drawing.Size(233, 200);
            this.pnlSubMenuEstoque.TabIndex = 5;
            this.pnlSubMenuEstoque.Tag = "pnlSubMenu";
            // 
            // btnEstEntradaMerc
            // 
            this.btnEstEntradaMerc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnEstEntradaMerc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstEntradaMerc.FlatAppearance.BorderSize = 0;
            this.btnEstEntradaMerc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEstEntradaMerc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnEstEntradaMerc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstEntradaMerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstEntradaMerc.ForeColor = System.Drawing.Color.White;
            this.btnEstEntradaMerc.Location = new System.Drawing.Point(0, 150);
            this.btnEstEntradaMerc.Name = "btnEstEntradaMerc";
            this.btnEstEntradaMerc.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEstEntradaMerc.Size = new System.Drawing.Size(233, 25);
            this.btnEstEntradaMerc.TabIndex = 17;
            this.btnEstEntradaMerc.Tag = "btnSubMenu";
            this.btnEstEntradaMerc.Text = "Entrada de Mercadoria";
            this.btnEstEntradaMerc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstEntradaMerc.UseVisualStyleBackColor = false;
            this.btnEstEntradaMerc.Click += new System.EventHandler(this.btnEstEntradaMerc_Click);
            // 
            // btnEstMovimentacaoSimplificada
            // 
            this.btnEstMovimentacaoSimplificada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnEstMovimentacaoSimplificada.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstMovimentacaoSimplificada.FlatAppearance.BorderSize = 0;
            this.btnEstMovimentacaoSimplificada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEstMovimentacaoSimplificada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnEstMovimentacaoSimplificada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstMovimentacaoSimplificada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstMovimentacaoSimplificada.ForeColor = System.Drawing.Color.White;
            this.btnEstMovimentacaoSimplificada.Location = new System.Drawing.Point(0, 125);
            this.btnEstMovimentacaoSimplificada.Name = "btnEstMovimentacaoSimplificada";
            this.btnEstMovimentacaoSimplificada.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEstMovimentacaoSimplificada.Size = new System.Drawing.Size(233, 25);
            this.btnEstMovimentacaoSimplificada.TabIndex = 16;
            this.btnEstMovimentacaoSimplificada.Tag = "btnSubMenu";
            this.btnEstMovimentacaoSimplificada.Text = "Movimentação Simplificada";
            this.btnEstMovimentacaoSimplificada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstMovimentacaoSimplificada.UseVisualStyleBackColor = false;
            this.btnEstMovimentacaoSimplificada.Click += new System.EventHandler(this.btnEstControle_Click);
            // 
            // btnEstProduto
            // 
            this.btnEstProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnEstProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstProduto.FlatAppearance.BorderSize = 0;
            this.btnEstProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEstProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnEstProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstProduto.ForeColor = System.Drawing.Color.White;
            this.btnEstProduto.Location = new System.Drawing.Point(0, 100);
            this.btnEstProduto.Name = "btnEstProduto";
            this.btnEstProduto.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEstProduto.Size = new System.Drawing.Size(233, 25);
            this.btnEstProduto.TabIndex = 15;
            this.btnEstProduto.Tag = "btnSubMenu";
            this.btnEstProduto.Text = "Cadastro de Produto";
            this.btnEstProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstProduto.UseVisualStyleBackColor = false;
            this.btnEstProduto.Click += new System.EventHandler(this.btnEstProduto_Click);
            // 
            // btnEstUnidadeMedida
            // 
            this.btnEstUnidadeMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnEstUnidadeMedida.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstUnidadeMedida.FlatAppearance.BorderSize = 0;
            this.btnEstUnidadeMedida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEstUnidadeMedida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnEstUnidadeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstUnidadeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstUnidadeMedida.ForeColor = System.Drawing.Color.White;
            this.btnEstUnidadeMedida.Location = new System.Drawing.Point(0, 75);
            this.btnEstUnidadeMedida.Name = "btnEstUnidadeMedida";
            this.btnEstUnidadeMedida.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEstUnidadeMedida.Size = new System.Drawing.Size(233, 25);
            this.btnEstUnidadeMedida.TabIndex = 14;
            this.btnEstUnidadeMedida.Tag = "btnSubMenu";
            this.btnEstUnidadeMedida.Text = "Cadastro de Unidade de Medida";
            this.btnEstUnidadeMedida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstUnidadeMedida.UseVisualStyleBackColor = false;
            this.btnEstUnidadeMedida.Click += new System.EventHandler(this.btnEstUnidadeMedida_Click);
            // 
            // btnEstSubGrupo
            // 
            this.btnEstSubGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnEstSubGrupo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstSubGrupo.FlatAppearance.BorderSize = 0;
            this.btnEstSubGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEstSubGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnEstSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstSubGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstSubGrupo.ForeColor = System.Drawing.Color.White;
            this.btnEstSubGrupo.Location = new System.Drawing.Point(0, 50);
            this.btnEstSubGrupo.Name = "btnEstSubGrupo";
            this.btnEstSubGrupo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEstSubGrupo.Size = new System.Drawing.Size(233, 25);
            this.btnEstSubGrupo.TabIndex = 7;
            this.btnEstSubGrupo.Tag = "btnSubMenu";
            this.btnEstSubGrupo.Text = "Cadastro de Subgrupo";
            this.btnEstSubGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstSubGrupo.UseVisualStyleBackColor = false;
            this.btnEstSubGrupo.Click += new System.EventHandler(this.btnEstSubGrupo_Click);
            // 
            // btnEstGrupo
            // 
            this.btnEstGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnEstGrupo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstGrupo.FlatAppearance.BorderSize = 0;
            this.btnEstGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEstGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnEstGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstGrupo.ForeColor = System.Drawing.Color.White;
            this.btnEstGrupo.Location = new System.Drawing.Point(0, 25);
            this.btnEstGrupo.Name = "btnEstGrupo";
            this.btnEstGrupo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEstGrupo.Size = new System.Drawing.Size(233, 25);
            this.btnEstGrupo.TabIndex = 6;
            this.btnEstGrupo.Tag = "btnSubMenu";
            this.btnEstGrupo.Text = "Cadastro de Grupo";
            this.btnEstGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstGrupo.UseVisualStyleBackColor = false;
            this.btnEstGrupo.Click += new System.EventHandler(this.btnEstGrupo_Click);
            // 
            // btnEstMarca
            // 
            this.btnEstMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnEstMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstMarca.FlatAppearance.BorderSize = 0;
            this.btnEstMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEstMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnEstMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstMarca.ForeColor = System.Drawing.Color.White;
            this.btnEstMarca.Location = new System.Drawing.Point(0, 0);
            this.btnEstMarca.Name = "btnEstMarca";
            this.btnEstMarca.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEstMarca.Size = new System.Drawing.Size(233, 25);
            this.btnEstMarca.TabIndex = 5;
            this.btnEstMarca.Tag = "btnSubMenu";
            this.btnEstMarca.Text = "Cadastro de Marca";
            this.btnEstMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstMarca.UseVisualStyleBackColor = false;
            this.btnEstMarca.Click += new System.EventHandler(this.btnEstMarca_Click);
            // 
            // btnMenuEstoque
            // 
            this.btnMenuEstoque.BackColor = System.Drawing.Color.Black;
            this.btnMenuEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuEstoque.FlatAppearance.BorderSize = 0;
            this.btnMenuEstoque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMenuEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnMenuEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuEstoque.ForeColor = System.Drawing.Color.White;
            this.btnMenuEstoque.Location = new System.Drawing.Point(0, 170);
            this.btnMenuEstoque.Name = "btnMenuEstoque";
            this.btnMenuEstoque.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuEstoque.Size = new System.Drawing.Size(233, 35);
            this.btnMenuEstoque.TabIndex = 6;
            this.btnMenuEstoque.Tag = "btnMenu";
            this.btnMenuEstoque.Text = "Estoque";
            this.btnMenuEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuEstoque.UseVisualStyleBackColor = false;
            this.btnMenuEstoque.Click += new System.EventHandler(this.btnMenuEstoque_Click);
            // 
            // pnlSubMenuVenda
            // 
            this.pnlSubMenuVenda.AutoSize = true;
            this.pnlSubMenuVenda.Controls.Add(this.btnVenRegistrar);
            this.pnlSubMenuVenda.Controls.Add(this.btnVenPedido);
            this.pnlSubMenuVenda.Controls.Add(this.btnVenFormaPagamento);
            this.pnlSubMenuVenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuVenda.Location = new System.Drawing.Point(0, 95);
            this.pnlSubMenuVenda.Name = "pnlSubMenuVenda";
            this.pnlSubMenuVenda.Size = new System.Drawing.Size(233, 75);
            this.pnlSubMenuVenda.TabIndex = 3;
            this.pnlSubMenuVenda.Tag = "pnlSubMenu";
            // 
            // btnVenRegistrar
            // 
            this.btnVenRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnVenRegistrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVenRegistrar.FlatAppearance.BorderSize = 0;
            this.btnVenRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVenRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnVenRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnVenRegistrar.Location = new System.Drawing.Point(0, 50);
            this.btnVenRegistrar.Name = "btnVenRegistrar";
            this.btnVenRegistrar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnVenRegistrar.Size = new System.Drawing.Size(233, 25);
            this.btnVenRegistrar.TabIndex = 10;
            this.btnVenRegistrar.Tag = "btnSubMenu";
            this.btnVenRegistrar.Text = "Registrar Venda";
            this.btnVenRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnVenPedido
            // 
            this.btnVenPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnVenPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVenPedido.FlatAppearance.BorderSize = 0;
            this.btnVenPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVenPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnVenPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenPedido.ForeColor = System.Drawing.Color.White;
            this.btnVenPedido.Location = new System.Drawing.Point(0, 25);
            this.btnVenPedido.Name = "btnVenPedido";
            this.btnVenPedido.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnVenPedido.Size = new System.Drawing.Size(233, 25);
            this.btnVenPedido.TabIndex = 9;
            this.btnVenPedido.Tag = "btnSubMenu";
            this.btnVenPedido.Text = "Pedido de Venda";
            this.btnVenPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenPedido.UseVisualStyleBackColor = false;
            this.btnVenPedido.Click += new System.EventHandler(this.btnVenPedido_Click);
            // 
            // btnVenFormaPagamento
            // 
            this.btnVenFormaPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnVenFormaPagamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVenFormaPagamento.FlatAppearance.BorderSize = 0;
            this.btnVenFormaPagamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVenFormaPagamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnVenFormaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenFormaPagamento.ForeColor = System.Drawing.Color.White;
            this.btnVenFormaPagamento.Location = new System.Drawing.Point(0, 0);
            this.btnVenFormaPagamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVenFormaPagamento.Name = "btnVenFormaPagamento";
            this.btnVenFormaPagamento.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnVenFormaPagamento.Size = new System.Drawing.Size(233, 25);
            this.btnVenFormaPagamento.TabIndex = 8;
            this.btnVenFormaPagamento.Tag = "btnSubMenu";
            this.btnVenFormaPagamento.Text = "Cadastro Forma de Pagamento";
            this.btnVenFormaPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenFormaPagamento.UseVisualStyleBackColor = false;
            this.btnVenFormaPagamento.Click += new System.EventHandler(this.btnVenFormaPagamento_Click);
            // 
            // btnMenuVenda
            // 
            this.btnMenuVenda.BackColor = System.Drawing.Color.Black;
            this.btnMenuVenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuVenda.FlatAppearance.BorderSize = 0;
            this.btnMenuVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMenuVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnMenuVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuVenda.ForeColor = System.Drawing.Color.White;
            this.btnMenuVenda.Location = new System.Drawing.Point(0, 60);
            this.btnMenuVenda.Name = "btnMenuVenda";
            this.btnMenuVenda.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuVenda.Size = new System.Drawing.Size(233, 35);
            this.btnMenuVenda.TabIndex = 4;
            this.btnMenuVenda.Tag = "btnMenu";
            this.btnMenuVenda.Text = "Venda";
            this.btnMenuVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuVenda.UseVisualStyleBackColor = false;
            this.btnMenuVenda.Click += new System.EventHandler(this.btnMenuVenda_Click);
            // 
            // pnlSubMenuCliente
            // 
            this.pnlSubMenuCliente.AutoSize = true;
            this.pnlSubMenuCliente.Controls.Add(this.btnCliCadastro);
            this.pnlSubMenuCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuCliente.Location = new System.Drawing.Point(0, 35);
            this.pnlSubMenuCliente.Name = "pnlSubMenuCliente";
            this.pnlSubMenuCliente.Size = new System.Drawing.Size(233, 25);
            this.pnlSubMenuCliente.TabIndex = 0;
            this.pnlSubMenuCliente.Tag = "pnlSubMenu";
            // 
            // btnCliCadastro
            // 
            this.btnCliCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCliCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliCadastro.FlatAppearance.BorderSize = 0;
            this.btnCliCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCliCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnCliCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCliCadastro.Location = new System.Drawing.Point(0, 0);
            this.btnCliCadastro.Name = "btnCliCadastro";
            this.btnCliCadastro.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCliCadastro.Size = new System.Drawing.Size(233, 25);
            this.btnCliCadastro.TabIndex = 4;
            this.btnCliCadastro.Tag = "btnSubMenu";
            this.btnCliCadastro.Text = "Cadastro de Cliente";
            this.btnCliCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliCadastro.UseVisualStyleBackColor = false;
            this.btnCliCadastro.Click += new System.EventHandler(this.btnCliCadastro_Click);
            // 
            // btnMenuCliente
            // 
            this.btnMenuCliente.BackColor = System.Drawing.Color.Black;
            this.btnMenuCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuCliente.FlatAppearance.BorderSize = 0;
            this.btnMenuCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMenuCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnMenuCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCliente.ForeColor = System.Drawing.Color.White;
            this.btnMenuCliente.Location = new System.Drawing.Point(0, 0);
            this.btnMenuCliente.Name = "btnMenuCliente";
            this.btnMenuCliente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuCliente.Size = new System.Drawing.Size(233, 35);
            this.btnMenuCliente.TabIndex = 0;
            this.btnMenuCliente.Tag = "btnMenu";
            this.btnMenuCliente.Text = "Cliente";
            this.btnMenuCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuCliente.UseVisualStyleBackColor = false;
            this.btnMenuCliente.Click += new System.EventHandler(this.btnMenuCliente_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Brown;
            this.pnlLogo.BackgroundImage = global::LaPizza.Properties.Resources.Logo2;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(250, 100);
            this.pnlLogo.TabIndex = 4;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.pnlPrincipal.BackgroundImage = global::LaPizza.Properties.Resources.Logo15_;
            this.pnlPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(250, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1114, 749);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // btnPesqProdutos
            // 
            this.btnPesqProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnPesqProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPesqProdutos.FlatAppearance.BorderSize = 0;
            this.btnPesqProdutos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPesqProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnPesqProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqProdutos.ForeColor = System.Drawing.Color.White;
            this.btnPesqProdutos.Location = new System.Drawing.Point(0, 175);
            this.btnPesqProdutos.Name = "btnPesqProdutos";
            this.btnPesqProdutos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPesqProdutos.Size = new System.Drawing.Size(233, 25);
            this.btnPesqProdutos.TabIndex = 18;
            this.btnPesqProdutos.Tag = "btnSubMenu";
            this.btnPesqProdutos.Text = "Pesquisa de Produtos";
            this.btnPesqProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesqProdutos.UseVisualStyleBackColor = false;
            this.btnPesqProdutos.Click += new System.EventHandler(this.btnPesqProdutos_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 749);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlLateral);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "La Pizza";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlLateral.ResumeLayout(false);
            this.pnlMenuLateral.ResumeLayout(false);
            this.pnlMenuLateral.PerformLayout();
            this.pnlSubMenuGeral.ResumeLayout(false);
            this.pnlSubMenuUsuario.ResumeLayout(false);
            this.pnlSubMenuFornecedor.ResumeLayout(false);
            this.pnlSubMenuEstoque.ResumeLayout(false);
            this.pnlSubMenuVenda.ResumeLayout(false);
            this.pnlSubMenuCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Panel pnlMenuLateral;
        private System.Windows.Forms.Panel pnlSubMenuGeral;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnMenuGeral;
        private System.Windows.Forms.Panel pnlSubMenuUsuario;
        private System.Windows.Forms.Button btnUsuControleAutonomia;
        private System.Windows.Forms.Button btnUsuControleAcesso;
        private System.Windows.Forms.Button btnUsuCadastro;
        private System.Windows.Forms.Button btnMenuUsuario;
        private System.Windows.Forms.Panel pnlSubMenuFornecedor;
        private System.Windows.Forms.Button btnFornCadastro;
        private System.Windows.Forms.Button btnMenuFornecedor;
        private System.Windows.Forms.Button btnMenuEstoque;
        private System.Windows.Forms.Panel pnlSubMenuVenda;
        private System.Windows.Forms.Button btnMenuVenda;
        private System.Windows.Forms.Panel pnlSubMenuCliente;
        private System.Windows.Forms.Button btnCliCadastro;
        private System.Windows.Forms.Button btnMenuCliente;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlSubMenuEstoque;
        private System.Windows.Forms.Button btnEstEntradaMerc;
        private System.Windows.Forms.Button btnEstMovimentacaoSimplificada;
        private System.Windows.Forms.Button btnEstProduto;
        private System.Windows.Forms.Button btnEstUnidadeMedida;
        private System.Windows.Forms.Button btnEstSubGrupo;
        private System.Windows.Forms.Button btnEstGrupo;
        private System.Windows.Forms.Button btnEstMarca;
        private System.Windows.Forms.Button btnGerCidade;
        private System.Windows.Forms.Button btnGerEstado;
        private System.Windows.Forms.Button btnVenRegistrar;
        private System.Windows.Forms.Button btnVenPedido;
        private System.Windows.Forms.Button btnVenFormaPagamento;
        private System.Windows.Forms.Button btnPesqProdutos;
    }
}

