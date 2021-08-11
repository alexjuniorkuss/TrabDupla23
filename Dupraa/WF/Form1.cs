using Data.Models;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF
{
    public partial class Form1 : Form
    {
        LanchesRepository repoL;
        BebidasRepository repoB;
        public Form1()
        {
            InitializeComponent();
            repoL = new LanchesRepository();
            repoB = new BebidasRepository();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string id = txbId.Text;
            Bebidas model = new Bebidas();
            model.Nome = this.txbNome.Text;
            model.Tipo = this.txb_tipoB.Text;
            model.TeorAlcoolico = Convert.ToDecimal(this.txbTeor.Text);
            if (id.Equals(string.Empty))
            {
                repoB.Create(model);
            }
            else
            {
                txbId.Text = string.Empty;
                model.Id = Convert.ToInt32(id);
                repoB.Update(model);
            }
            this.txbNome.Text = String.Empty;
            this.txb_tipoB.Text = String.Empty;
            this.txbTeor.Text = String.Empty;
            Listar(repoB);
        }

        private void Listar(BebidasRepository repo)
        {
            dgBebidas.DataSource = null;
            dgBebidas.DataSource = repo.Read();
            dgBebidas.Refresh();
        }
        private void Listar(LanchesRepository repo)
        {
            dgBebidas.DataSource = null;
            dgBebidas.DataSource = repo.Read();
            dgBebidas.Refresh();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string id = txbIdL.Text;
            Lanches model = new Lanches();
            model.Tipo = this.txbTipo.Text;
            model.QtdItens = Convert.ToInt32(this.txbQtd.Text);
            model.Valor = Convert.ToDecimal(this.txbValor.Text);
            if (id.Equals(string.Empty))
            {
                repoL.Create(model);
            }
            else
            {
                txbIdL.Text = string.Empty;
                model.Id = Convert.ToInt32(id);
                repoL.Update(model);
            }
            this.txbTipo.Text = String.Empty;
            this.txbQtd.Text = String.Empty;
            this.txbValor.Text = String.Empty;
            Listar(repoL);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'refeicoesDbDataSet1.Bebidas'. Você pode movê-la ou removê-la conforme necessário.
            this.bebidasTableAdapter.Fill(this.refeicoesDbDataSet1.Bebidas);
            // TODO: esta linha de código carrega dados na tabela 'refeicoesDbDataSet.Lanches'. Você pode movê-la ou removê-la conforme necessário.
            this.lanchesTableAdapter.Fill(this.refeicoesDbDataSet.Lanches);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int item = e.ColumnIndex;
            if (item == 3)
            {
                List<Bebidas> list = repoB.Read();
                Bebidas beb = list[e.RowIndex];
                txbId.Text = beb.Id.ToString();
                txbNome.Text = beb.Nome;
                txb_tipoB.Text = beb.Tipo;
                txbTeor.Text = beb.TeorAlcoolico.ToString();
            }
            if (item == 4)
            {
                List<Bebidas> list = repoB.Read();
                Bebidas beb = list[e.RowIndex];
                repoB.Delete(beb.Id);
                Listar(repoB);
            }
        }
    }
}
