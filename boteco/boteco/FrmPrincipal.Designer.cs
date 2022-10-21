namespace boteco
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxCliente = new System.Windows.Forms.PictureBox();
            this.pbxProdutos = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbxFuncionarios = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbxVenda = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbxFechar = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.vendaToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.funcionáriosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.cadastroToolStripMenuItem.Text = "cadastro";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.vendaToolStripMenuItem.Text = "venda";
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // pbxCliente
            // 
            this.pbxCliente.Image = global::boteco.Properties.Resources.cliente;
            this.pbxCliente.Location = new System.Drawing.Point(25, 86);
            this.pbxCliente.Name = "pbxCliente";
            this.pbxCliente.Size = new System.Drawing.Size(118, 139);
            this.pbxCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCliente.TabIndex = 2;
            this.pbxCliente.TabStop = false;
            this.pbxCliente.Click += new System.EventHandler(this.pbxCliente_Click);
            // 
            // pbxProdutos
            // 
            this.pbxProdutos.Image = global::boteco.Properties.Resources.produto;
            this.pbxProdutos.Location = new System.Drawing.Point(177, 86);
            this.pbxProdutos.Name = "pbxProdutos";
            this.pbxProdutos.Size = new System.Drawing.Size(118, 139);
            this.pbxProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProdutos.TabIndex = 4;
            this.pbxProdutos.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produtos";
            // 
            // pbxFuncionarios
            // 
            this.pbxFuncionarios.Image = global::boteco.Properties.Resources.funcionario;
            this.pbxFuncionarios.Location = new System.Drawing.Point(343, 86);
            this.pbxFuncionarios.Name = "pbxFuncionarios";
            this.pbxFuncionarios.Size = new System.Drawing.Size(118, 139);
            this.pbxFuncionarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFuncionarios.TabIndex = 6;
            this.pbxFuncionarios.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Funcionário";
            // 
            // pbxVenda
            // 
            this.pbxVenda.Image = global::boteco.Properties.Resources.venda;
            this.pbxVenda.Location = new System.Drawing.Point(502, 86);
            this.pbxVenda.Name = "pbxVenda";
            this.pbxVenda.Size = new System.Drawing.Size(118, 139);
            this.pbxVenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxVenda.TabIndex = 8;
            this.pbxVenda.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(543, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Venda";
            // 
            // pbxFechar
            // 
            this.pbxFechar.Image = global::boteco.Properties.Resources.sair;
            this.pbxFechar.Location = new System.Drawing.Point(655, 86);
            this.pbxFechar.Name = "pbxFechar";
            this.pbxFechar.Size = new System.Drawing.Size(118, 139);
            this.pbxFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFechar.TabIndex = 10;
            this.pbxFechar.TabStop = false;
            this.pbxFechar.Click += new System.EventHandler(this.pbxFechar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(693, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fechar";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxFechar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbxVenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbxFuncionarios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbxProdutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbxCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "boteco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxCliente;
        private System.Windows.Forms.PictureBox pbxProdutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxFuncionarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbxVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbxFechar;
        private System.Windows.Forms.Label label5;
    }
}

