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
            this.RBBebida = new System.Windows.Forms.RadioButton();
            this.RBLanche = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // RBBebida
            // 
            this.RBBebida.AutoSize = true;
            this.RBBebida.Location = new System.Drawing.Point(27, 72);
            this.RBBebida.Name = "RBBebida";
            this.RBBebida.Size = new System.Drawing.Size(63, 17);
            this.RBBebida.TabIndex = 0;
            this.RBBebida.TabStop = true;
            this.RBBebida.Text = "Bebidas";
            this.RBBebida.UseVisualStyleBackColor = true;
            this.RBBebida.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RBLanche
            // 
            this.RBLanche.AutoSize = true;
            this.RBLanche.Location = new System.Drawing.Point(107, 72);
            this.RBLanche.Name = "RBLanche";
            this.RBLanche.Size = new System.Drawing.Size(61, 17);
            this.RBLanche.TabIndex = 1;
            this.RBLanche.TabStop = true;
            this.RBLanche.Text = "Lanche";
            this.RBLanche.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RBLanche);
            this.Controls.Add(this.RBBebida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RBBebida;
        private System.Windows.Forms.RadioButton RBLanche;
    }
}

