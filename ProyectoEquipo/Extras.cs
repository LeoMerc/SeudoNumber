using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ProyectoEquipo
{
    public partial class Extras : Form
    {
        public Extras()
        {
            InitializeComponent();
        }

        private void btnv_Click(object sender, EventArgs e)
        {
            Process pro = new Process();
            pro.StartInfo.FileName = @"3Volados.txt";
            pro.Start();
        }

        private void btni_Click(object sender, EventArgs e)
        {
            Process pro = new Process();
            pro.StartInfo.FileName = @"4Inventarios.txt";
            pro.Start();
        }

        private void Extras_Load(object sender, EventArgs e)
        {

        }
    }
}
