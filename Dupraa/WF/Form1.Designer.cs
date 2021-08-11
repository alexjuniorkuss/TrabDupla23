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
            this.components = new System.ComponentModel.Container();
            this.tab_Cadastros = new System.Windows.Forms.TabControl();
            this.tabLanches = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lanchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refeicoesDbDataSet = new WF.RefeicoesDbDataSet();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.lValor = new System.Windows.Forms.Label();
            this.txbQtd = new System.Windows.Forms.TextBox();
            this.txbTipo = new System.Windows.Forms.TextBox();
            this.btnSalvarLanche = new System.Windows.Forms.Button();
            this.lQtd = new System.Windows.Forms.Label();
            this.lTipo = new System.Windows.Forms.Label();
            this.tabBebidas = new System.Windows.Forms.TabPage();
            this.txbId = new System.Windows.Forms.TextBox();
            this.dgBebidas = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teorAlcoolicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bebidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refeicoesDbDataSet1 = new WF.RefeicoesDbDataSet1();
            this.txbTeor = new System.Windows.Forms.TextBox();
            this.lTeoor = new System.Windows.Forms.Label();
            this.txb_tipoB = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.btnSalvarBebida = new System.Windows.Forms.Button();
            this.lTipoBebida = new System.Windows.Forms.Label();
            this.lNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lanchesTableAdapter = new WF.RefeicoesDbDataSetTableAdapters.LanchesTableAdapter();
            this.bebidasTableAdapter = new WF.RefeicoesDbDataSet1TableAdapters.BebidasTableAdapter();
            this.txbIdL = new System.Windows.Forms.TextBox();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdItensDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editL = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteL = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tab_Cadastros.SuspendLayout();
            this.tabLanches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lanchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refeicoesDbDataSet)).BeginInit();
            this.tabBebidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bebidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refeicoesDbDataSet1)).BeginInit();
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
            this.tabLanches.Controls.Add(this.txbIdL);
            this.tabLanches.Controls.Add(this.dataGridView1);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoDataGridViewTextBoxColumn,
            this.qtdItensDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.editL,
            this.DeleteL});
            this.dataGridView1.DataSource = this.lanchesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(312, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(427, 181);
            this.dataGridView1.TabIndex = 8;
            // 
            // lanchesBindingSource
            // 
            this.lanchesBindingSource.DataMember = "Lanches";
            this.lanchesBindingSource.DataSource = this.refeicoesDbDataSet;
            // 
            // refeicoesDbDataSet
            // 
            this.refeicoesDbDataSet.DataSetName = "RefeicoesDbDataSet";
            this.refeicoesDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // txbQtd
            // 
            this.txbQtd.Location = new System.Drawing.Point(180, 157);
            this.txbQtd.Name = "txbQtd";
            this.txbQtd.Size = new System.Drawing.Size(100, 20);
            this.txbQtd.TabIndex = 5;
            // 
            // txbTipo
            // 
            this.txbTipo.Location = new System.Drawing.Point(180, 106);
            this.txbTipo.Name = "txbTipo";
            this.txbTipo.Size = new System.Drawing.Size(100, 20);
            this.txbTipo.TabIndex = 4;
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
            // lQtd
            // 
            this.lQtd.AutoSize = true;
            this.lQtd.Location = new System.Drawing.Point(79, 160);
            this.lQtd.Name = "lQtd";
            this.lQtd.Size = new System.Drawing.Size(62, 13);
            this.lQtd.TabIndex = 1;
            this.lQtd.Text = "Quantidade";
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
            // tabBebidas
            // 
            this.tabBebidas.Controls.Add(this.txbId);
            this.tabBebidas.Controls.Add(this.dgBebidas);
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
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(144, 52);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(17, 20);
            this.txbId.TabIndex = 17;
            this.txbId.Visible = false;
            // 
            // dgBebidas
            // 
            this.dgBebidas.AllowUserToAddRows = false;
            this.dgBebidas.AutoGenerateColumns = false;
            this.dgBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn1,
            this.teorAlcoolicoDataGridViewTextBoxColumn,
            this.Editar,
            this.Delete});
            this.dgBebidas.DataSource = this.bebidasBindingSource;
            this.dgBebidas.Location = new System.Drawing.Point(297, 79);
            this.dgBebidas.Name = "dgBebidas";
            this.dgBebidas.Size = new System.Drawing.Size(453, 150);
            this.dgBebidas.TabIndex = 16;
            this.dgBebidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 120;
            // 
            // tipoDataGridViewTextBoxColumn1
            // 
            this.tipoDataGridViewTextBoxColumn1.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn1.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn1.Name = "tipoDataGridViewTextBoxColumn1";
            // 
            // teorAlcoolicoDataGridViewTextBoxColumn
            // 
            this.teorAlcoolicoDataGridViewTextBoxColumn.DataPropertyName = "TeorAlcoolico";
            this.teorAlcoolicoDataGridViewTextBoxColumn.HeaderText = "TeorAlcoolico";
            this.teorAlcoolicoDataGridViewTextBoxColumn.Name = "teorAlcoolicoDataGridViewTextBoxColumn";
            this.teorAlcoolicoDataGridViewTextBoxColumn.Width = 90;
            // 
            // Editar
            // 
            this.Editar.DataPropertyName = "Id";
            this.Editar.HeaderText = "Edit";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 50;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Id";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 50;
            // 
            // bebidasBindingSource
            // 
            this.bebidasBindingSource.DataMember = "Bebidas";
            this.bebidasBindingSource.DataSource = this.refeicoesDbDataSet1;
            // 
            // refeicoesDbDataSet1
            // 
            this.refeicoesDbDataSet1.DataSetName = "RefeicoesDbDataSet1";
            this.refeicoesDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txbTeor
            // 
            this.txbTeor.Location = new System.Drawing.Point(137, 173);
            this.txbTeor.Name = "txbTeor";
            this.txbTeor.Size = new System.Drawing.Size(100, 20);
            this.txbTeor.TabIndex = 15;
            // 
            // lTeoor
            // 
            this.lTeoor.AutoSize = true;
            this.lTeoor.Location = new System.Drawing.Point(36, 176);
            this.lTeoor.Name = "lTeoor";
            this.lTeoor.Size = new System.Drawing.Size(75, 13);
            this.lTeoor.TabIndex = 14;
            this.lTeoor.Text = "Teor Alcoólico";
            // 
            // txb_tipoB
            // 
            this.txb_tipoB.Location = new System.Drawing.Point(137, 131);
            this.txb_tipoB.Name = "txb_tipoB";
            this.txb_tipoB.Size = new System.Drawing.Size(100, 20);
            this.txb_tipoB.TabIndex = 13;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(137, 80);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 12;
            // 
            // btnSalvarBebida
            // 
            this.btnSalvarBebida.Location = new System.Drawing.Point(137, 206);
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
            this.lTipoBebida.Location = new System.Drawing.Point(36, 134);
            this.lTipoBebida.Name = "lTipoBebida";
            this.lTipoBebida.Size = new System.Drawing.Size(28, 13);
            this.lTipoBebida.TabIndex = 9;
            this.lTipoBebida.Text = "Tipo";
            // 
            // lNome
            // 
            this.lNome.AutoSize = true;
            this.lNome.Location = new System.Drawing.Point(36, 83);
            this.lNome.Name = "lNome";
            this.lNome.Size = new System.Drawing.Size(35, 13);
            this.lNome.TabIndex = 8;
            this.lNome.Text = "Nome";
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
            // lanchesTableAdapter
            // 
            this.lanchesTableAdapter.ClearBeforeFill = true;
            // 
            // bebidasTableAdapter
            // 
            this.bebidasTableAdapter.ClearBeforeFill = true;
            // 
            // txbIdL
            // 
            this.txbIdL.Location = new System.Drawing.Point(193, 80);
            this.txbIdL.Name = "txbIdL";
            this.txbIdL.Size = new System.Drawing.Size(17, 20);
            this.txbIdL.TabIndex = 18;
            this.txbIdL.Visible = false;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 130;
            // 
            // qtdItensDataGridViewTextBoxColumn
            // 
            this.qtdItensDataGridViewTextBoxColumn.DataPropertyName = "QtdItens";
            this.qtdItensDataGridViewTextBoxColumn.HeaderText = "QtdItens";
            this.qtdItensDataGridViewTextBoxColumn.Name = "qtdItensDataGridViewTextBoxColumn";
            this.qtdItensDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtdItensDataGridViewTextBoxColumn.Width = 50;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editL
            // 
            this.editL.HeaderText = "Editar";
            this.editL.Name = "editL";
            this.editL.ReadOnly = true;
            this.editL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.editL.Width = 50;
            // 
            // DeleteL
            // 
            this.DeleteL.DataPropertyName = "Id";
            this.DeleteL.HeaderText = "Delete";
            this.DeleteL.Name = "DeleteL";
            this.DeleteL.ReadOnly = true;
            this.DeleteL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteL.Width = 50;
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab_Cadastros.ResumeLayout(false);
            this.tabLanches.ResumeLayout(false);
            this.tabLanches.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lanchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refeicoesDbDataSet)).EndInit();
            this.tabBebidas.ResumeLayout(false);
            this.tabBebidas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bebidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refeicoesDbDataSet1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private RefeicoesDbDataSet refeicoesDbDataSet;
        private System.Windows.Forms.BindingSource lanchesBindingSource;
        private RefeicoesDbDataSetTableAdapters.LanchesTableAdapter lanchesTableAdapter;
        private System.Windows.Forms.DataGridView dgBebidas;
        private RefeicoesDbDataSet1 refeicoesDbDataSet1;
        private System.Windows.Forms.BindingSource bebidasBindingSource;
        private RefeicoesDbDataSet1TableAdapters.BebidasTableAdapter bebidasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teorAlcoolicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.TextBox txbIdL;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdItensDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn editL;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteL;
    }
}

