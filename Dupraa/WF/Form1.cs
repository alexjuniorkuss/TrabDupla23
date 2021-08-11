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
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            BebidasRepository repo = new BebidasRepository();
            Bebidas model = new Bebidas();
            model.Nome = this.txbNome.Text;
            model.Tipo = this.txb_tipoB.Text;
            model.TeorAlcoolico = Convert.ToDecimal(this.txbTeor.Text);
            repo.Create(model);
            this.txbNome.Text = String.Empty;
            this.txb_tipoB.Text = String.Empty;
            this.txbTeor.Text = String.Empty;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            LanchesRepository repo = new LanchesRepository();
            Lanches model = new Lanches();
            model.Tipo = this.txbTipo.Text;
            model.QtdItens = Convert.ToInt32(this.txbQtd.Text);
            model.Valor = Convert.ToDecimal(this.txbValor.Text);
            repo.Create(model);
            this.txbTipo.Text = String.Empty;
            this.txbQtd.Text = String.Empty;
            this.txbValor.Text = String.Empty;
        }
    }
}
