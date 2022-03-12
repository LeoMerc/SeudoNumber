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
    public partial class PruebaVolados : Form
    {
        int n, si, no;
        double[] numPseu;

        private void PruebaVolados_Load(object sender, EventArgs e)
        {

        }

        private void btnjugar_Click(object sender, EventArgs e)
        {
            int j = Int32.Parse(txtjuegos.Text);
            double ap = Double.Parse(txtapuesta.Text), mi = Double.Parse(txtmontoinicial.Text), cl = Double.Parse(txttope.Text), dobleteo, total = 0;
            for (int i = 0; i < j; i++)
            {
                int lolo = tablaresultados.Rows.Add();
                double red = Math.Round(numPseu[i], 5);
                string values = red.ToString("0.00000");
                tablaresultados.Rows[lolo].Cells[0].Value = i + 1;
                tablaresultados.Rows[lolo].Cells[1].Value = values;
                if (ap > total)
                {
                    ap = Double.Parse(txtapuesta.Text);
                }
                if (red > 0.5)
                {
                    tablaresultados.Rows[lolo].Cells[4].Value = ap;
                    tablaresultados.Rows[lolo].Cells[2].Value = mi;
                    tablaresultados.Rows[lolo].Cells[3].Value = "Ganó";
                    total = mi + ap;
                    mi = total;
                    ap = Double.Parse(txtapuesta.Text);
                    tablaresultados.Rows[lolo].Cells[5].Value = total;
                    si++;
                }
                else
                {
                    tablaresultados.Rows[lolo].Cells[4].Value = ap;
                    tablaresultados.Rows[lolo].Cells[2].Value = mi;
                    tablaresultados.Rows[lolo].Cells[3].Value = "Perdió";
                    total = mi - ap;
                    dobleteo = ap * 2;
                    ap = dobleteo;
                    mi = total;
                    tablaresultados.Rows[lolo].Cells[5].Value = total;
                    no++;
                }

                if (total <= 0)
                {
                    tablaresultados.Rows[lolo].Cells[6].Value = "Quiebra";
                    break;
                }
                else if (total >= cl)
                {
                    tablaresultados.Rows[lolo].Cells[6].Value = "Si";
                    break;
                }
                else
                {
                    tablaresultados.Rows[lolo].Cells[6].Value = "No";
                }
            }
            //Mensaje de victoria
            if (si > no)
            {
                lblVictoriaMagistral.Text = "Felicidades!!! Tienes muy buena suerte, ve a las Vegas que ganas todo\n:)";
            }
            else if (si == no)
            {
                lblVictoriaMagistral.Text = "No tienes ni buena ni mala suerte, si vas a las Vegas tal vez ganes algo,\npero no es seguro\n:/ ";
            }
            else
            {
                lblVictoriaMagistral.Text = "Tienes una suerte pesima, ve a las Vegas y te quedas pobre\n:'( ";
            }
        }

        public PruebaVolados(int n, double[] array)
        {
            InitializeComponent();
            this.n = n;
            numPseu = new double[n];
            for (int r = 0; r < n; r++)
            {
                numPseu[r] = array[r];
            }
        }
    }
}
