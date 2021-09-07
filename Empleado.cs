using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyPans
{
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lblcedula_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Chlistboxpanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Valortotalventa_TextChanged(object sender, EventArgs e)
        {
            double Numpanaliñado, Numpannoaliñado, Numpanespecial, Valorventa;

            Numpanaliñado = Convert.ToDouble(NumpanA);
            Numpannoaliñado = Convert.ToDouble(NumpanNA);
            Numpanespecial = Convert.ToDouble(NumpanE);
            Valorventa = (Numpanaliñado * 1000) + (Numpannoaliñado * 500) + (Numpanespecial * 2000);
            string valorventatext;
            valorventatext = Convert.ToString(Valorventa);
            Valortotalventa.Text = valorventatext;

        }

        private void Btnvender_Click(object sender, EventArgs e)
        {
            
        }
    }
}
