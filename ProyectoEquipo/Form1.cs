using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEquipo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double a, c, x0, M;
        int n;
        double[] NumPseudoA;

        private void PFrecuencia_Click(object sender, EventArgs e)
        {
            Frecuencia f = new Frecuencia(n, NumPseudoA);
            f.ShowDialog();
        }

        private void PPoker_Click(object sender, EventArgs e)
        {
            Poker p = new Poker(n, NumPseudoA);
            p.ShowDialog();
            
        }

        private void EVolados_Click(object sender, EventArgs e)
        {
            PruebaVolados v = new PruebaVolados(n, NumPseudoA);
            v.ShowDialog();
        }

        private void EInventarios_Click(object sender, EventArgs e)
        {
            Inventarios i = new Inventarios(n, NumPseudoA);
            i.ShowDialog();
        }

        private void Extras_Click(object sender, EventArgs e)
        {
            Extras x = new Extras();
            x.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Predeterminados_Click(object sender, EventArgs e)
        {
            txta.Text = "101";
            txtc.Text = "221";
            txtx0.Text = "17";
            txtM.Text = "17001";
            txtn.Text = "325";
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            Generador();
        }

        public void Generador()
        {
            a = Double.Parse(txta.Text); //constante multiplicativa
            c = Double.Parse(txtc.Text); // aditiva 
            x0 = Double.Parse(txtx0.Text); //
            M = Double.Parse(txtM.Text); //modelo utilizado
            n = Int32.Parse(txtn.Text); //cantidad de numeros
            NumPseudoA = new double[n];

            for (int i = 0; i < n; i++)
            {
                double resul = (a * x0 + c) % M;
                int lolo = tablaresultados.Rows.Add();
                tablaresultados.Rows[lolo].Cells[0].Value = i + 1;
                tablaresultados.Rows[lolo].Cells[1].Value = x0;
                tablaresultados.Rows[lolo].Cells[2].Value = resul;
                double Rn = resul / M;
                double red = Math.Round(Rn, 5);
                string values = red.ToString("0.00000");
                tablaresultados.Rows[lolo].Cells[3].Value = values;
                x0 = resul;
                NumPseudoA[i] = Rn;
            }
        }
    }
}
