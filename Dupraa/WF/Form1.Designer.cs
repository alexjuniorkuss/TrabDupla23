namespace WF
{
    partial class Form1
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
            this.tab_Cadastros = new System.Windows.Forms.TabControl();
            this.tabLanches = new System.Windows.Forms.TabPage();
            this.tabBebidas = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lTipo = new System.Windows.Forms.Label();
            this.lQtd = new System.Windows.Forms.Label();
            this.btnSalvarLanche = new System.Windows.Forms.Button();
            this.txbTipo = new System.Windows.Forms.TextBox();
            this.txbQtd = new System.Windows.Forms.TextBox();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.lValor = new System.Windows.Forms.Label();
            this.txbTeor = new System.Windows.Forms.TextBox();
            this.lTeoor = new System.Windows.Forms.Label();
            this.txb_tipoB = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.btnSalvarBebida = new System.Windows.Forms.Button();
            this.lTipoBebida = new System.Windows.Forms.Label();
            this.lNome = new System.Windows.Forms.Label();
            this.tab_Cadastros.SuspendLayout();
            this.tabLanches.SuspendLayout();
            this.tabBebidas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Cadastros
            // 
            this.tab_Cadastros.Controls.Add(this.tabLanches);
            this.tab_Cadastros.Controls.Add(this.tabBebidas);
            this.tab_Cadastros.Location = new System.Drawing.Point(12, 48);
            this.tab_Cadastros.Name = "tab_Cadastros";
            this.tab_Cadastros.SelectedIndex = 0;
            this.tab_Cadastros.Size = new System.Drawing.Size(764, 361);
            this.tab_Cadastros.TabIndex = 0;
            // 
            // tabLanches
            // 
            this.tabLanches.Controls.Add(this.txbValor);
            this.tabLanches.Controls.Add(this.lValor);
            this.tabLanches.Controls.Add(this.txbQtd);
            this.tabLanches.Controls.Add(this.txbTipo);
            this.tabLanches.Controls.Add(this.btnSalvarLanche);
            this.tabLanches.Controls.Add(this.lQtd);
            this.tabLanches.Controls.Add(this.lTipo);
            this.tabLanches.Location = new System.Drawing.Point(4, 22);
            this.tabLanches.Name = "tabLanches";
            this.tabLanches.Padding = new System.Windows.Forms.Padding(3);
            this.tabLanches.Size = new System.Drawing.Size(756, 335);
            this.tabLanches.TabIndex = 0;
            this.tabLanches.Text = "Lanches";
            this.tabLanches.UseVisualStyleBackColor = true;
            // 
            // tabBebidas
            // 
            this.tabBebidas.Controls.Add(this.txbTeor);
            this.tabBebidas.Controls.Add(this.lTeoor);
            this.tabBebidas.Controls.Add(this.txb_tipoB);
            this.tabBebidas.Controls.Add(this.txbNome);
            this.tabBebidas.Controls.Add(this.btnSalvarBebida);
            this.tabBebidas.Controls.Add(this.lTipoBebida);
            this.tabBebidas.Controls.Add(this.lNome);
            this.tabBebidas.Location = new System.Drawing.Point(4, 22);
            this.tabBebidas.Name = "tabBebidas";
            this.tabBebidas.Padding = new System.Windows.Forms.Padding(3);
            this.tabBebidas.Size = new System.Drawing.Size(756, 335);
            this.tabBebidas.TabIndex = 1;
            this.tabBebidas.Text = "Bebidas";
            this.tabBebidas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastros";
            // 
            // lTipo
            // 
            this.lTipo.AutoSize = true;
            this.lTipo.Location = new System.Drawing.Point(79, 109);
            this.lTipo.Name = "lTipo";
            this.lTipo.Size = new System.Drawing.Size(28, 13);
            this.lTipo.TabIndex = 0;
            this.lTipo.Text = "Tipo";
            // 
            // lQtd
            // 
            this.lQtd.AutoSize = true;
            this.lQtd.Location = new System.Drawing.Point(79, 160);
            this.lQtd.Name = "lQtd";
            this.lQtd.Size = new System.Drawing.Size(62, 13);
            this.lQtd.TabIndex = 1;
            this.lQtd.Text = "Quantidade";
            // 
            // btnSalvarLanche
            // 
            this.btnSalvarLanche.Location = new System.Drawing.Point(193, 240);
            this.btnSalvarLanche.Name = "btnSalvarLanche";
            this.btnSalvarLanche.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarLanche.TabIndex = 3;
            this.btnSalvarLanche.Text = "Salvar";
            this.btnSalvarLanche.UseVisualStyleBackColor = true;
            this.btnSalvarLanche.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // txbTipo
            // 
            this.txbTipo.Location = new System.Drawing.Point(180, 106);
            this.txbTipo.Name = "txbTipo";
            this.txbTipo.Size = new System.Drawing.Size(100, 20);
            this.txbTipo.TabIndex = 4;
            // 
            // txbQtd
            // 
            this.txbQtd.Location = new System.Drawing.Point(180, 157);
            this.txbQtd.Name = "txbQtd";
            this.txbQtd.Size = new System.Drawing.Size(100, 20);
            this.txbQtd.TabIndex = 5;
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(180, 199);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(100, 20);
            this.txbValor.TabIndex = 7;
            // 
            // lValor
            // 
            this.lValor.AutoSize = true;
            this.lValor.Location = new System.Drawing.Point(79, 202);
            this.lValor.Name = "lValor";
            this.lValor.Size = new System.Drawing.Size(31, 13);
            this.lValor.TabIndex = 6;
            this.lValor.Text = "Valor";
            // 
            // txbTeor
            // 
            this.txbTeor.Location = new System.Drawing.Point(195, 177);
            this.txbTeor.Name = "txbTeor";
            this.txbTeor.Size = new System.Drawing.Size(100, 20);
            this.txbTeor.TabIndex = 15;
            // 
            // lTeoor
            // 
            this.lTeoor.AutoSize = true;
            this.lTeoor.Location = new System.Drawing.Point(94, 180);
            this.lTeoor.Name = "lTeoor";
            this.lTeoor.Size = new System.Drawing.Size(75, 13);
            this.lTeoor.TabIndex = 14;
            this.lTeoor.Text = "Teor Alcoólico";
            // 
            // txb_tipoB
            // 
            this.txb_tipoB.Location = new System.Drawing.Point(195, 135);
            this.txb_tipoB.Name = "txb_tipoB";
            this.txb_tipoB.Size = new System.Drawing.Size(100, 20);
            this.txb_tipoB.TabIndex = 13;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(195, 84);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 12;
            // 
            // btnSalvarBebida
            // 
            this.btnSalvarBebida.Location = new System.Drawing.Point(195, 210);
            this.btnSalvarBebida.Name = "btnSalvarBebida";
            this.btnSalvarBebida.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarBebida.TabIndex = 11;
            this.btnSalvarBebida.Text = "Salvar";
            this.btnSalvarBebida.UseVisualStyleBackColor = true;
            this.btnSalvarBebida.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lTipoBebida
            // 
            this.lTipoBebida.AutoSize = true;
            this.lTipoBebida.Location = new System.Drawing.Point(94, 138);
            this.lTipoBebida.Name = "lTipoBebida";
            this.lTipoBebida.Size = new System.Drawing.Size(28, 13);
            this.lTipoBebida.TabIndex = 9;
            this.lTipoBebida.Text = "Tipo";
            // 
            // lNome
            // 
            this.lNome.AutoSize = true;
            this.lNome.Location = new System.Drawing.Point(94, 87);
            this.lNome.Name = "lNome";
            this.lNome.Size = new System.Drawing.Size(35, 13);
            this.lNome.TabIndex = 8;
            this.lNome.Text = "Nome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tab_Cadastros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tab_Cadastros.ResumeLayout(false);
            this.tabLanches.ResumeLayout(false);
            this.tabLanches.PerformLayout();
            this.tabBebidas.ResumeLayout(false);
            this.tabBebidas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Cadastros;
        private System.Windows.Forms.TabPage tabLanches;
        private System.Windows.Forms.TabPage tabBebidas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lQtd;
        private System.Windows.Forms.Label lTipo;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.Label lValor;
        private System.Windows.Forms.TextBox txbQtd;
        private System.Windows.Forms.TextBox txbTipo;
        private System.Windows.Forms.Button btnSalvarLanche;
        private System.Windows.Forms.TextBox txbTeor;
        private System.Windows.Forms.Label lTeoor;
        private System.Windows.Forms.TextBox txb_tipoB;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Button btnSalvarBebida;
        private System.Windows.Forms.Label lTipoBebida;
        private System.Windows.Forms.Label lNome;
    }
}

