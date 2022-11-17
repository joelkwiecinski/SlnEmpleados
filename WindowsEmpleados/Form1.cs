using LibreriaEmpleado.Models.Derivada;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEmpleados.Admin;

namespace WindowsEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Empleado empleado1 = new Empleado() { Nombre = "Raúl", Apellido = "Montoya", Legajo = 45242 };
            if (AdminEmpleados.Insertar(empleado1) > 0)
            {
                MessageBox.Show("Insertado con éxito!");
            } else
            {
                MessageBox.Show("Hubo un error.");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dataGridMostrar.DataSource = AdminEmpleados.Listar();
        }
    }
}
