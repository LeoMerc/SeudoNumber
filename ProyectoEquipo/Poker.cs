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
    public partial class Poker : Form
    {
        int it;
        double[] NumPseudoA;
        public Poker(int n, double[] array)
        {
            InitializeComponent();
            it = n;
            NumPseudoA = new double[it];
            for (int a = 0; a < it; a++)
            {
                NumPseudoA[a] = array[a];
            }
        }

        public int doble = 0, triple = 0, poker = 0, ti = 0;
        public int FOpar = 0, FOdospar = 0, FOter = 0, FOpoker = 0, FOpt = 0, FOti = 0, FOtd = 0;

        private void Poker_Load_1(object sender, EventArgs e)
        {
            string Direccion = "tabla_chi_cuadrado.xlsx";
            SLDocument sl = new SLDocument(Direccion);
            int valor = 2;
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(valor, 1)))
            {
                int lolo = chicua2.Rows.Add();
                chicua2.Rows[lolo].Cells[0].Value = sl.GetCellValueAsDouble(valor, 1);
                chicua2.Rows[lolo].Cells[1].Value = sl.GetCellValueAsDouble(valor, 2);
                chicua2.Rows[lolo].Cells[2].Value = sl.GetCellValueAsDouble(valor, 3);
                chicua2.Rows[lolo].Cells[3].Value = sl.GetCellValueAsDouble(valor, 4);
                chicua2.Rows[lolo].Cells[4].Value = sl.GetCellValueAsDouble(valor, 5);
                chicua2.Rows[lolo].Cells[5].Value = sl.GetCellValueAsDouble(valor, 6);
                chicua2.Rows[lolo].Cells[6].Value = sl.GetCellValueAsDouble(valor, 7);
                chicua2.Rows[lolo].Cells[7].Value = sl.GetCellValueAsDouble(valor, 8);
                chicua2.Rows[lolo].Cells[8].Value = sl.GetCellValueAsDouble(valor, 9);
                chicua2.Rows[lolo].Cells[9].Value = sl.GetCellValueAsDouble(valor, 10);
                chicua2.Rows[lolo].Cells[10].Value = sl.GetCellValueAsDouble(valor, 11);
                chicua2.Rows[lolo].Cells[11].Value = sl.GetCellValueAsDouble(valor, 12);
                chicua2.Rows[lolo].Cells[12].Value = sl.GetCellValueAsDouble(valor, 13);
                chicua2.Rows[lolo].Cells[13].Value = sl.GetCellValueAsDouble(valor, 14);
                chicua2.Rows[lolo].Cells[14].Value = sl.GetCellValueAsDouble(valor, 15);
                chicua2.Rows[lolo].Cells[15].Value = sl.GetCellValueAsDouble(valor, 16);
                chicua2.Rows[lolo].Cells[16].Value = sl.GetCellValueAsDouble(valor, 17);
                chicua2.Rows[lolo].Cells[17].Value = sl.GetCellValueAsDouble(valor, 18);
                chicua2.Rows[lolo].Cells[18].Value = sl.GetCellValueAsDouble(valor, 19);
                chicua2.Rows[lolo].Cells[19].Value = sl.GetCellValueAsDouble(valor, 20);
                chicua2.Rows[lolo].Cells[20].Value = sl.GetCellValueAsDouble(valor, 21);
                chicua2.Rows[lolo].Cells[21].Value = sl.GetCellValueAsDouble(valor, 22);
                chicua2.Rows[lolo].Cells[22].Value = sl.GetCellValueAsDouble(valor, 23);
                chicua2.Rows[lolo].Cells[23].Value = sl.GetCellValueAsDouble(valor, 24);
                chicua2.Rows[lolo].Cells[24].Value = sl.GetCellValueAsDouble(valor, 25);
                chicua2.Rows[lolo].Cells[25].Value = sl.GetCellValueAsDouble(valor, 26);
                chicua2.Rows[lolo].Cells[26].Value = sl.GetCellValueAsDouble(valor, 27);
                chicua2.Rows[lolo].Cells[27].Value = sl.GetCellValueAsDouble(valor, 28);
                chicua2.Rows[lolo].Cells[28].Value = sl.GetCellValueAsDouble(valor, 29);
                chicua2.Rows[lolo].Cells[29].Value = sl.GetCellValueAsDouble(valor, 30);
                valor++;
            }
        }

        public int c0 = 0, c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0, c7 = 0, c8 = 0, c9 = 0;
        public double chicalculada;

        private void btncomparar_Click(object sender, EventArgs e)
        {
            int y = 0;

            for (int i = 0; i < 30; i++)
            {
                if (chicua2.Rows[0].Cells[i].Value.ToString() == cbalfa.Text)
                {
                    y = chicua2.Rows[0].Cells[i].ColumnIndex;
                }
            }
            prueba.Text = chicua2.Rows[6].Cells[y].Value.ToString();
            double vtabla = Double.Parse(prueba.Text);
            if (chicalculada <= vtabla)
            {
                chicua2.Enabled = true;
                prueba.Visible = true;
                prueba.Text = (chicalculada.ToString() + " <= " + vtabla.ToString() +
                "\nLos valores estan distribuidos uniformemente de acuerdo a la prueba de poker.");
            }
            else
            {
                prueba.Visible = true;
                prueba.Text = (chicalculada.ToString() + " > " + vtabla.ToString() +
                "\nLos valores NO estan distribuidos uniformemente de acuerdo a la prueba de poker.");
            }
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            //Clasificacion de eventos
            for (int i = 0; i < NumPseudoA.Length; i++)
            {
                int lolo = tablaresultados.Rows.Add();
                double redondeado = Math.Round(NumPseudoA[i], 5);
                string values = redondeado.ToString("0.00000");
                tablaresultados.Rows[lolo].Cells[0].Value = i + 1;
                tablaresultados.Rows[lolo].Cells[1].Value = values;
                pokerino(lolo, values);
            }

            //FE
            double TD = it * 0.30240;
            double UP = it * 0.50400;
            double DP = it * 0.10800;
            double TI = it * 0.07200;
            double TIP = it * 0.00900;
            double CI = it * 0.00450;
            double TIS = it * 0.00010;

            //Chi calculada
            double chitd = Math.Round(Math.Pow(FOtd - TD, 2) / TD, 5);
            double chipar = Math.Round(Math.Pow(FOpar - UP, 2) / UP, 5);
            double chidospares = Math.Round(Math.Pow(FOdospar - DP, 2) / DP, 5);
            double chitercia = Math.Round(Math.Pow(FOter - TI, 2) / TI, 5);
            double chiterpar = Math.Round(Math.Pow(FOpt - TIP, 2) / TIP, 5);
            double chipoker = Math.Round(Math.Pow(FOpoker - CI, 2) / CI, 5);
            double chiti = Math.Round(Math.Pow(FOti - TIS, 2) / TIS, 5);

            //Despliegue
            string[] fila = new string[] { "Todos Diferentes", FOtd.ToString(), "0.30240", TD.ToString(), chitd.ToString() };
            tablaPoker.Rows.Add(fila);

            fila = new string[] { "Un par", FOpar.ToString(), "0.50400", UP.ToString(), chipar.ToString() };
            tablaPoker.Rows.Add(fila);

            fila = new string[] { "Dos Pares ", FOdospar.ToString(), "0.10800", DP.ToString(), chidospares.ToString() };
            tablaPoker.Rows.Add(fila);

            fila = new string[] { "Tres Iguales", FOter.ToString(), " 0.07200", TI.ToString(), chitercia.ToString() };
            tablaPoker.Rows.Add(fila);

            fila = new string[] { "Tres Iguales y un Par", FOpt.ToString(), "0.00900", TIP.ToString(), chiterpar.ToString() };
            tablaPoker.Rows.Add(fila);

            fila = new string[] { "Cuatro Iguales ", FOpoker.ToString(), "0.00450", CI.ToString(), chipoker.ToString() };
            tablaPoker.Rows.Add(fila);

            fila = new string[] { "Todos Iguales ", FOti.ToString(), "0.00010", TIS.ToString(), chiti.ToString() };
            tablaPoker.Rows.Add(fila);

            lblfo.Text = (FOtd + FOpar + FOdospar + FOter + FOpt + FOpoker + FOti).ToString();
            lblprobeve.Text = "1";
            lblfe.Text = (TD + UP + DP + TI + TIP + CI + TIS).ToString();
            chicalculada = chitd + chipar + chidospares + chitercia + chiterpar + chipoker + chiti;
            lblsumchic.Text = chicalculada.ToString();
        }

        public void pokerino(int lolo, string values)
        {
            char[] n = values.ToArray();
            c0 = 0; c1 = 0; c2 = 0; c3 = 0; c4 = 0; c5 = 0; c6 = 0; c7 = 0; c8 = 0; c9 = 0;

            for (int f = 2; f < n.Length; f++)
            {   
                if (n[f].ToString() == 0.ToString()) { c0++; }
                if (n[f].ToString() == 1.ToString()) { c1++; }
                if (n[f].ToString() == 2.ToString()) { c2++; }
                if (n[f].ToString() == 3.ToString()) { c3++; }
                if (n[f].ToString() == 4.ToString()) { c4++; }
                if (n[f].ToString() == 5.ToString()) { c5++; }
                if (n[f].ToString() == 6.ToString()) { c6++; }
                if (n[f].ToString() == 7.ToString()) { c7++; }
                if (n[f].ToString() == 8.ToString()) { c8++; }
                if (n[f].ToString() == 9.ToString()) { c9++; }
            }


            int[] val = new int[10];
            val[0] = c0;
            val[1] = c1;
            val[2] = c2;
            val[3] = c3;
            val[4] = c4;
            val[5] = c5;
            val[6] = c6;
            val[7] = c7;
            val[8] = c8;
            val[9] = c9;
            doble = 0; triple = 0; poker = 0; ti = 0;

            for (int f = 0; f < val.Length; f++)
            {

                if (val[f].ToString() == 2.ToString()) { doble++; }

                if (val[f].ToString() == 3.ToString()) { triple++; }

                if (val[f].ToString() == 4.ToString()) { poker++; }

                if (val[f].ToString() == 5.ToString()) { ti++; }

            }

            if (ti.ToString() == 1.ToString()) { tablaresultados.Rows[lolo].Cells[2].Value = "Todos Iguales"; FOti++; }

            else if (poker.ToString() == 1.ToString()) { tablaresultados.Rows[lolo].Cells[2].Value = "Poker"; FOpoker++; }

            else if (doble.ToString() == 1.ToString() && triple.ToString() == 1.ToString()) { tablaresultados.Rows[lolo].Cells[2].Value = "Un Par y Una Tercia"; FOpt++; }

            else if (triple.ToString() == 1.ToString()) { tablaresultados.Rows[lolo].Cells[2].Value = "Una Tercia"; FOter++; }

            else if (doble.ToString() == 2.ToString()) { tablaresultados.Rows[lolo].Cells[2].Value = "Dos Pares"; FOdospar++; }

            else if (doble.ToString() == 1.ToString()) { tablaresultados.Rows[lolo].Cells[2].Value = "Un par"; FOpar++; }

            else { tablaresultados.Rows[lolo].Cells[2].Value = "Todos Diferentes"; FOtd++; }
        }
    }
}
