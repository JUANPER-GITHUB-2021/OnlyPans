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
    public partial class iniciarsesion : Form
    {
        string UsuarioAdmin = "Carla.Flores1998";
        string ContraseñaAdmin = "123456";
        string UsuarioEmpleado1 = "Maria.Gomez2001";
        string ContraseñaEmpleado1 = "456789";
        string UsuarioEmpleado2 = "Juan.Avila2000";
        string ContraseñaEmpleado2 = "123789";

        public iniciarsesion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iniciarsesion_Load(object sender, EventArgs e)
        {

        }

        private void Btniniciar_Click(object sender, EventArgs e)
        {
            if (Txtboxusuario.Text == UsuarioAdmin && Txtboxcontraseña.Text == ContraseñaAdmin)
            {
                Txtboxusuario.Clear();
                Txtboxcontraseña.Clear();
                Administrador Form = new Administrador();
                Form.ShowDialog();
            }
            else
            {
                if (Txtboxusuario.Text == UsuarioEmpleado1 && Txtboxcontraseña.Text == ContraseñaEmpleado1)
                {
                    Txtboxusuario.Clear();
                    Txtboxcontraseña.Clear();
                    Empleado Form1 = new Empleado();
                    Form1.ShowDialog();
                }
                else
                {
                    if (Txtboxusuario.Text == UsuarioEmpleado2 && Txtboxcontraseña.Text == ContraseñaEmpleado2)
                    {
                        Txtboxusuario.Clear();
                        Txtboxcontraseña.Clear();
                        Empleado Form2 = new Empleado();
                        Form2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos, Intentelo nuevamente");
                        Txtboxusuario.Clear();
                        Txtboxcontraseña.Clear();
                        return;
                    }
                }
            }
        }

        private void Txtboxusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lblcontraseña_Click(object sender, EventArgs e)
        {

        }

        private void Txtboxcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}