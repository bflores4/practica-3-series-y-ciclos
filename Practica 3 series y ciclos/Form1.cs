using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3_series_y_ciclos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        serie serieExam = new serie();
        int x;
        int repeticiones;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt16(txtValorX.Text);
            repeticiones = Convert.ToInt16(txtNumRepeticiones.Text);
            txtResultado.Text = Convert.ToString(serieExam.serieLogaritmoNatural(x, repeticiones));
        }

        private void btnCoseno_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt16(txtValorX.Text);
            repeticiones = Convert.ToInt16(txtNumRepeticiones.Text);
            txtResultado.Text= Convert.ToString(serieExam.serieCoseno(x, repeticiones));
        }

        private void btnSeno_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt16(txtValorX.Text);
            repeticiones = Convert.ToInt16(txtNumRepeticiones.Text);
            txtResultado.Text = Convert.ToString(serieExam.serieSeno(x, repeticiones));
        }
    }
}
