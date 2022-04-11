namespace LaPizza.Views
{
    partial class FormBasePesquisa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.lbPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlAcoesRodape = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dbGridPesquisa = new System.Windows.Forms.DataGridView();
            this.pnlPesquisa.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.pnlAcoesRodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.BackColor = System.Drawing.Color.Brown;
            this.pnlPesquisa.Controls.Add(this.lbPesquisa);
            this.pnlPesquisa.Controls.Add(this.txtPesquisa);
            this.pnlPesquisa.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPesquisa.Location = new System.Drawing.Point(0, 0);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Size = new System.Drawing.Size(454, 60);
            this.pnlPesquisa.TabIndex = 1;
            // 
            // lbPesquisa
            // 
            this.lbPesquisa.AutoSize = true;
            this.lbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesquisa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbPesquisa.Location = new System.Drawing.Point(12, 18);
            this.lbPesquisa.Name = "lbPesquisa";
            this.lbPesquisa.Size = new System.Drawing.Size(58, 13);
            this.lbPesquisa.TabIndex = 1;
            this.lbPesquisa.Text = "Pesquisa";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Location = new System.Drawing.Point(12, 34);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(430, 20);
            this.txtPesquisa.TabIndex = 0;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlPrincipal.Controls.Add(this.pnlAcoesRodape);
            this.pnlPrincipal.Controls.Add(this.dbGridPesquisa);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 60);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(454, 431);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.pnlAcoesRodape.Controls.Add(this.btnConfirmar);
            this.pnlAcoesRodape.Controls.Add(this.splitter2);
            this.pnlAcoesRodape.Controls.Add(this.btnCancelar);
            this.pnlAcoesRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 391);
            this.pnlAcoesRodape.Name = "pnlAcoesRodape";
            this.pnlAcoesRodape.Padding = new System.Windows.Forms.Padding(5);
            this.pnlAcoesRodape.Size = new System.Drawing.Size(454, 40);
            this.pnlAcoesRodape.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.Location = new System.Drawing.Point(304, 5);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(70, 30);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "&Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Enabled = false;
            this.splitter2.Location = new System.Drawing.Point(374, 5);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(5, 30);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Location = new System.Drawing.Point(379, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 30);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // dbGridPesquisa
            // 
            this.dbGridPesquisa.AllowUserToAddRows = false;
            this.dbGridPesquisa.AllowUserToDeleteRows = false;
            this.dbGridPesquisa.AllowUserToResizeColumns = false;
            this.dbGridPesquisa.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dbGridPesquisa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dbGridPesquisa.BackgroundColor = System.Drawing.Color.White;
            this.dbGridPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbGridPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbGridPesquisa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dbGridPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbGridPesquisa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dbGridPesquisa.Location = new System.Drawing.Point(0, 0);
            this.dbGridPesquisa.MultiSelect = false;
            this.dbGridPesquisa.Name = "dbGridPesquisa";
            this.dbGridPesquisa.ReadOnly = true;
            this.dbGridPesquisa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dbGridPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbGridPesquisa.Size = new System.Drawing.Size(454, 431);
            this.dbGridPesquisa.TabIndex = 0;
            // 
            // FormBasePesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 491);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlPesquisa);
            this.Name = "FormBasePesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormBasePesquisa";
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlAcoesRodape.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbGridPesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Label lbPesquisa;
        public System.Windows.Forms.Panel pnlAcoesRodape;
        public System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Splitter splitter2;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.DataGridView dbGridPesquisa;
        public System.Windows.Forms.Panel pnlPesquisa;
        public System.Windows.Forms.TextBox txtPesquisa;
    }
}