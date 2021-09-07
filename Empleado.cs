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

        }

        private void Btnvender_Click(object sender, EventArgs e)
        {
            double Numpanaliñado, Numpannoaliñado, Numpanespecial, Valorventa;

            Numpanaliñado = Convert.ToDouble(TxtNumPanA.Text);
            Numpannoaliñado = Convert.ToDouble(TxtNumPanNA.Text);
            Numpanespecial = Convert.ToDouble(TxtNumPanE.Text);
            Valorventa = ((Numpanaliñado * 1000) + (Numpannoaliñado * 500) + (Numpanespecial * 2000));
            string valorventatext;
            valorventatext = Convert.ToString(Valorventa);
            Valortotalventa.Text = valorventatext;
            RctxtboxVentas.Text = "VENTA \n" + "DATOS CLIENTE \n" + "Nombre: " + Txtboxnombre.Text + "\n" + "Cedula: " + Txtboxcedula.Text + "\n" + "DATOS VENTA \n" + "Numero Panes Aliñados: " + TxtNumPanA.Text
            + "\n" + "Numero Panes No Aliñados: " + TxtNumPanNA.Text + "\n" + "Numero Panes Especiales: " + TxtNumPanE.Text + "\n" + "Valor total de la venta: $" + Valortotalventa.Text + "\n" + "Hora de Venta: " + Txtboxhora.Text + "\n" + "-----------------------------------------------------------------------------------------------------" +
            "\n" + Txtboxguardado.Text;
            Clipboard.SetText(RctxtboxVentas.Text);
            Txtboxguardado.Text = Clipboard.GetText();
            String Historialventas = RctxtboxVentas.Text;
            Txtboxnombre.Clear();
            Txtboxcedula.Clear();
            TxtNumPanA.Clear();
            TxtNumPanNA.Clear();
            TxtNumPanE.Clear();
            Txtboxhora.Clear();
        }

        private void BtnCerrarsesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            iniciarsesion Form = new iniciarsesion();
            Form.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
