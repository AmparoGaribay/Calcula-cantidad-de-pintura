using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagnostico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtHabitaciones.Text = "";
            txtLitros.Text = "";
            panel1.Visible = false;

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtHabitaciones.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese datos", "Diagnostico", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                int valor = int.Parse(txtHabitaciones.Text);
                int resultado = ((valor * 8) / 2);
                txtLitros.Text = resultado.ToString();
                panel1.Visible = true;

            }
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas Salir", "Diagnostico", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Application.Exit();
            }

            
        }
    }
}
