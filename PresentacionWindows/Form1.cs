using LibreriaEmpleado.Models;
using LibreriaEmpleado.Models.Derivada;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentacionWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Empleado> Empleados = new List<Empleado> { };

        private void btnCargarMostrar_Click(object sender, EventArgs e)
        {
            // Vamos a crear los empleados
            Empleado empleado1 = new Empleado() { Id = 1, Nombre = "Jorge", Apellido = "Saez", Legajo = 34214 };
            Empleado empleado2 = new Empleado() { Id = 2, Nombre = "Anastasio", Apellido = "Popeye", Legajo = 86572 };
            Empleado empleado3 = new Empleado() { Id = 3, Nombre = "Armando", Apellido = "Estebanquito", Legajo = 6563 };

            Empleados.Add(empleado1);
            Empleados.Add(empleado2);
            Empleados.Add(empleado3);

            // Creamos el departamento
            string TituloDep = Interaction.InputBox("Ingresa el nombre del nuevo departamento de la empresa:");
            while (TituloDep.Length < 1)
            {
                MessageBox.Show("Tenés que ingresar un nombre");
                TituloDep = Interaction.InputBox("Ingresa el nombre del nuevo departamento de la empresa:");
            }
            Departamento NuevoDepartamento = new Departamento(0, TituloDep, Empleados);

            foreach (Empleado emp in Empleados)
            {
                emp.Departamento = NuevoDepartamento;
            }

            dataGridView1.DataSource = NuevoDepartamento.Empleados;
        }
    }
}
