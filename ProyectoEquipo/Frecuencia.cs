using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpreadsheetLight;

namespace ProyectoEquipo
{
    public partial class Frecuencia : Form
    {
        int n;
        double[] numPseu;
        double FE;
        public Frecuencia(int n, double[] array)
        {
            InitializeComponent();
            this.n = n;
            numPseu = new double[n];
            for (int r = 0; r < n; r++)
            {
                numPseu[r] = array[r];
            }
        }

        private void Frecuencia_Load(object sender, EventArgs e)
        {
            string Direccion1 = "tabla_chi_cuadrado.xlsx";
            SLDocument sl = new SLDocument(Direccion1);
            int valor = 2;
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(valor, 1)))
            {
                int lolo = chicua.Rows.Add();
                chicua.Rows[lolo].Cells[0].Value = sl.GetCellValueAsDouble(valor, 1);
                chicua.Rows[lolo].Cells[1].Value = sl.GetCellValueAsDouble(valor, 2);
                chicua.Rows[lolo].Cells[2].Value = sl.GetCellValueAsDouble(valor, 3);
                chicua.Rows[lolo].Cells[3].Value = sl.GetCellValueAsDouble(valor, 4);
                chicua.Rows[lolo].Cells[4].Value = sl.GetCellValueAsDouble(valor, 5);
                chicua.Rows[lolo].Cells[5].Value = sl.GetCellValueAsDouble(valor, 6);
                chicua.Rows[lolo].Cells[6].Value = sl.GetCellValueAsDouble(valor, 7);
                chicua.Rows[lolo].Cells[7].Value = sl.GetCellValueAsDouble(valor, 8);
                chicua.Rows[lolo].Cells[8].Value = sl.GetCellValueAsDouble(valor, 9);
                chicua.Rows[lolo].Cells[9].Value = sl.GetCellValueAsDouble(valor, 10);
                chicua.Rows[lolo].Cells[10].Value = sl.GetCellValueAsDouble(valor, 11);
                chicua.Rows[lolo].Cells[11].Value = sl.GetCellValueAsDouble(valor, 12);
                chicua.Rows[lolo].Cells[12].Value = sl.GetCellValueAsDouble(valor, 13);
                chicua.Rows[lolo].Cells[13].Value = sl.GetCellValueAsDouble(valor, 14);
                chicua.Rows[lolo].Cells[14].Value = sl.GetCellValueAsDouble(valor, 15);
                chicua.Rows[lolo].Cells[15].Value = sl.GetCellValueAsDouble(valor, 16);
                chicua.Rows[lolo].Cells[16].Value = sl.GetCellValueAsDouble(valor, 17);
                chicua.Rows[lolo].Cells[17].Value = sl.GetCellValueAsDouble(valor, 18);
                chicua.Rows[lolo].Cells[18].Value = sl.GetCellValueAsDouble(valor, 19);
                chicua.Rows[lolo].Cells[19].Value = sl.GetCellValueAsDouble(valor, 20);
                chicua.Rows[lolo].Cells[20].Value = sl.GetCellValueAsDouble(valor, 21);
                chicua.Rows[lolo].Cells[21].Value = sl.GetCellValueAsDouble(valor, 22);
                chicua.Rows[lolo].Cells[22].Value = sl.GetCellValueAsDouble(valor, 23);
                chicua.Rows[lolo].Cells[23].Value = sl.GetCellValueAsDouble(valor, 24);
                chicua.Rows[lolo].Cells[24].Value = sl.GetCellValueAsDouble(valor, 25);
                chicua.Rows[lolo].Cells[25].Value = sl.GetCellValueAsDouble(valor, 26);
                chicua.Rows[lolo].Cells[26].Value = sl.GetCellValueAsDouble(valor, 27);
                chicua.Rows[lolo].Cells[27].Value = sl.GetCellValueAsDouble(valor, 28);
                chicua.Rows[lolo].Cells[28].Value = sl.GetCellValueAsDouble(valor, 29);
                chicua.Rows[lolo].Cells[29].Value = sl.GetCellValueAsDouble(valor, 30);
                valor++;
            }
        }

        private void btnSeparacion_Click(object sender, EventArgs e)
        {
            float intervalo = Int32.Parse(txtintervalos.Text);
            FE = n / intervalo;

            for(int i = 0; i < intervalo; i++)
            {
                int lolo = tablaresultados.Rows.Add();
                double uno = i * (1 / intervalo), dos = (i + 1) * (1 / intervalo);
                uno= Math.Truncate(100 * uno) / 100;  dos = Math.Truncate(100 * dos) / 100;
                string tres = uno.ToString() + " - " + dos.ToString();
                tablaresultados.Rows[lolo].Cells[0].Value = tres;
                tablaresultados.Rows[lolo].Cells[1].Value = Math.Truncate(100 * FE) / 100;
                int cont = 0;
                for (int l = 0; l < n; l++)
                {
                    
                    if (numPseu[l] > uno && numPseu[l] <= dos)
                    {
                        cont++;
                        tablaresultados.Rows[lolo].Cells[2].Value = cont;
                    }
                }
            }
        }

        private void btnResultadoTablas_Click(object sender, EventArgs e)
        {
            ValorCalculadoChiCuadrada.Visible = false;
            int intervalo = Int32.Parse(txtintervalos.Text), y = 0;
            double Resultado = 0;

            for (int l = 0; l < intervalo; l++)
            {
                ValorCalculadoChiCuadrada.Text = tablaresultados.Rows[l].Cells[2].Value.ToString();
                double FOi= double.Parse(ValorCalculadoChiCuadrada.Text);

                double Formula = Math.Pow((FOi - FE), 2) / FE;
                Resultado = Resultado + Formula;
            }
            Resultado = Math.Truncate(100000 * Resultado) / 100000;
            ValorCalculadoChiCuadrada.BackColor = Color.MediumPurple;
            ValorCalculadoChiCuadrada.Visible = true;
            ValorCalculadoChiCuadrada.Text = "Valor calculado de Chi-cuadrada\n" + Resultado.ToString();

            for (int i = 0; i < 30; i++)
            {
                if (chicua.Rows[0].Cells[i].Value.ToString() == cbalfa.Text)
                {
                    y = chicua.Rows[0].Cells[i].ColumnIndex;
                
                }
            }
            prueba.Text = chicua.Rows[intervalo - 1].Cells[y].Value.ToString();
            double vtabla = Double.Parse(prueba.Text);
            if (Resultado <= vtabla)
            {
                chicua.Enabled = true;
                prueba.Visible = true;
                prueba.Text = (Resultado.ToString() + " <= " + vtabla.ToString()+
                "\nLos valores estan distribuidos uniformemente de acuerdo a la prueba de la frecuencia.");
            }
            else
            {
                prueba.Visible = true;
                prueba.Text = (Resultado.ToString() + " > " + vtabla.ToString() +
                "\nLos valores NO estan distribuidos uniformemente de acuerdo a la prueba de la frecuencia.");
            }
        }
    }
}
