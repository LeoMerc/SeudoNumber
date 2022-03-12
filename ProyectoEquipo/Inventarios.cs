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
using System.Data.SqlClient;

namespace ProyectoEquipo
{
    public partial class Inventarios : Form
    {
        double[] factor = new double[12];
        double[] probini = new double[26];
        double[] probfin = new double[26];
        double[] probabilidad = new double[26];
        double faltantetot = 0;
        double costoorden = 50, costoinventario = 26, costofaltante = 25, faltafinal, inventariofinal, pedidofinal, ctototal;

        private void Inventarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioDataSet.Tabla' Puede moverla o quitarla según sea necesario.
            this.tablaTableAdapter.Fill(this.inventarioDataSet.Tabla);
            string Direccion = "Inventarios.xlsx";
            SLDocument sl = new SLDocument(Direccion);
            int valor = 2;
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(valor, 1)))
            {
                int lolo = probas.Rows.Add();
                probas.Rows[lolo].Cells[0].Value = sl.GetCellValueAsDouble(valor, 1);
                probas.Rows[lolo].Cells[1].Value = sl.GetCellValueAsDouble(valor, 2);
                probas.Rows[lolo].Cells[2].Value = sl.GetCellValueAsDouble(valor, 3);
                probas.Rows[lolo].Cells[3].Value = sl.GetCellValueAsDouble(valor, 4);
                probas.Rows[lolo].Cells[4].Value = sl.GetCellValueAsDouble(valor, 5);
                probas.Rows[lolo].Cells[5].Value = sl.GetCellValueAsDouble(valor, 6);
                probas.Rows[lolo].Cells[6].Value = sl.GetCellValueAsDouble(valor, 7);
                probas.Rows[lolo].Cells[7].Value = sl.GetCellValueAsDouble(valor, 8);
                valor++;
            }
            for (int x = 0; x < 26; x++)
            {
                label4.Text = probas.Rows[x].Cells[0].Value.ToString();
                label5.Text = probas.Rows[x].Cells[2].Value.ToString();
                label6.Text = probas.Rows[x].Cells[3].Value.ToString();
                probabilidad[x] = Convert.ToDouble(label4.Text);
                probini[x] = Convert.ToDouble(label5.Text);
                probfin[x] = Convert.ToDouble(label6.Text);
            }

            for (int x = 0; x < 3; x++)
            {
                label4.Text = probas.Rows[x].Cells[4].Value.ToString();
                label5.Text = probas.Rows[x].Cells[6].Value.ToString();
                label6.Text = probas.Rows[x].Cells[7].Value.ToString();
                probabilidadmes[x] = Convert.ToInt32(label4.Text);
                probimes[x] = Convert.ToDouble(label5.Text);
                probfmes[x] = Convert.ToDouble(label6.Text);
            }
        }

        private void Predeterminados_Click(object sender, EventArgs e)
        {
            txtr.Text = "100"; txtinv.Text = "150"; txtmes.Text = "12"; textBox1.Text = "200";
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            string counta = dataGridView2.Rows.Count.ToString();
            int counta2 = Convert.ToInt32(counta);
            double[] costototal = new double[counta2 - 1];

            for (int x = 0; x < counta2 - 1; x++)
            {
                label4.Text = dataGridView2.Rows[x].Cells[5].Value.ToString();
                costototal[x] = Convert.ToDouble(label4.Text);
            }
            double min = costototal.Min();
            for (int x = 0; x < counta2 - 1; x++)
            {
                if (min.ToString() == dataGridView2.Rows[x].Cells[5].Value.ToString())
                {
                    dataGridView2.Rows[x].Cells[5].Style.BackColor = Color.LightBlue;
                }
                costototal[x] = Convert.ToDouble(label4.Text);
            }
            label7.Text = "La opcion mas conveniente ha sido marcada de color azul.";
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            int meses = Convert.ToInt32(txtmes.Text), mes = 1000, alcanzarmes = 0, valorsi = 0;
            double invinicial = Convert.ToInt32(txtinv.Text);
            double q = Convert.ToInt32(textBox1.Text), r2 = 0, orden = 0, demajustad = 0, invfinal = 0, demsim = 0, r = Convert.ToDouble(txtr.Text);
            double[] faltante = new double[meses];


            for (int i = 0; i < meses; i++)
            {

                for (int x = 0; x < 26; x++)
                {
                    if (numPseu[i + sumita] > probini[x] && numPseu[i + sumita] <= probfin[x])
                    {
                        demsim = probabilidad[x];
                    }
                }


                if (alcanzarmes == mes)
                {
                    invinicial = invinicial + q;
                    mes = 1000;
                    valorsi = 0;
                }

                else
                {
                    mes--;
                }

                demajustad = demsim * factor[i];

                if (demajustad > invinicial)
                {
                    faltante[i] = (demajustad - invinicial);
                }

                else
                {

                    for (int a = 0; a < meses; a++)
                    {
                        faltantetot = faltante[a] + faltantetot;
                        faltante[a] = 0;

                    }

                    invinicial = invinicial - faltantetot;
                    faltantetot = 0;
                }
                invfinal = invinicial - demajustad;

                if (invfinal <= 0)
                {
                    invfinal = 0;
                }

                if (valorsi == 0)
                {
                    if (invfinal < r)
                    {
                        orden = 1;
                        r2 = numPseu[i + sumita + 1];

                        for (int x = 0; x < 3; x++)
                        {
                            if (numPseu[i + sumita + 1] > probimes[x] && numPseu[i + sumita + 1] <= probfmes[x])
                            {
                                mes = probabilidadmes[x];
                                valorsi = 1000;
                            }
                        }
                    }

                    else
                    {
                        orden = 0;
                        r2 = 0;


                    }
                }

                else
                {
                    orden = 0;
                    r2 = 0;
                }

                double mensual = Math.Round(((invinicial + invfinal) / 2), 1);
                int lolo = dataGridView1.Rows.Add();
                dataGridView1.Rows[lolo].Cells[0].Value = i + 1;
                dataGridView1.Rows[lolo].Cells[1].Value = txtr.Text;
                dataGridView1.Rows[lolo].Cells[2].Value = Math.Round(invinicial);

                dataGridView1.Rows[lolo].Cells[3].Value = Math.Round(numPseu[i + sumita], 3);
                dataGridView1.Rows[lolo].Cells[4].Value = Math.Round(demajustad);
                dataGridView1.Rows[lolo].Cells[5].Value = Math.Round(invfinal);
                dataGridView1.Rows[lolo].Cells[6].Value = Math.Round(faltante[i]);
                dataGridView1.Rows[lolo].Cells[7].Value = Math.Round(orden);
                dataGridView1.Rows[lolo].Cells[8].Value = mensual;      //Inv Mensual;
                dataGridView1.Rows[lolo].Cells[9].Value = Math.Round(demsim);
                dataGridView1.Rows[lolo].Cells[10].Value = factor[i];
                dataGridView1.Rows[lolo].Cells[11].Value = Math.Round(r2, 3);

                faltafinal = faltafinal + faltante[i]; //cto falta 
                inventariofinal = inventariofinal + mensual;//ctoinv

                if (mes > 3)
                {
                    dataGridView1.Rows[lolo].Cells[12].Value = 0;
                }
                else
                {
                    dataGridView1.Rows[lolo].Cells[12].Value = mes;
                }
                invinicial = invfinal;
                if (orden == 1)
                {
                    sumita++;
                    pedidofinal++;  //ctopedido
                }

                if (invfinal < 0)
                {
                    invinicial = 0;
                }
            }
            faltafinal = Math.Truncate(faltafinal);
            pedidofinal = Math.Truncate(pedidofinal);


            faltafinal = faltafinal * costofaltante;
            inventariofinal = (inventariofinal / 12) * costoinventario;
            pedidofinal = pedidofinal * costoorden;
            ctototal = faltafinal + inventariofinal + pedidofinal;
            SqlConnection con = new SqlConnection(@"server=.; initial catalog = Inventario; integrated security = true");
            SqlCommand alt = new SqlCommand("insert into Tabla(Q, R, CostoFaltante, CostoInventario, CostoPedido, CostoTotal) values (@Q, @R, @CostoFaltante, @CostoInventario, @CostoPedido, @CostoTotal)", con);
            alt.Parameters.AddWithValue("Q", q);
            alt.Parameters.AddWithValue("R", txtr.Text);
            alt.Parameters.AddWithValue("CostoFaltante", faltafinal);
            alt.Parameters.AddWithValue("CostoInventario", inventariofinal);
            alt.Parameters.AddWithValue("CostoPedido", pedidofinal);
            alt.Parameters.AddWithValue("CostoTotal", ctototal);
            con.Open();
            alt.ExecuteNonQuery();
            con.Close();

            this.tablaTableAdapter.Fill(this.inventarioDataSet.Tabla);
        }

        int n, sumita = 0, asd = 100;

        double[] probimes = new double[3];
        double[] probfmes = new double[3];
        int[] probabilidadmes = new int[3];
        double[] numPseu;

        public Inventarios(int n, double[] array)
        {
            InitializeComponent();
            this.n = n;
            numPseu = new double[n];
            for (int r = 0; r < n; r++)
            {
                numPseu[r] = array[r];
            }

            //cambiar en documentacion esto
            factor[0] = 1.200;
            factor[1] = 1.000;
            factor[2] = 0.900;
            factor[3] = 0.800;
            factor[4] = 0.800;
            factor[5] = 0.700;
            factor[6] = 0.800;
            factor[7] = 0.900;
            factor[8] = 1.000;
            factor[9] = 1.200;
            factor[10] = 1.300;
            factor[11] = 1.400;

        }
    }
}
