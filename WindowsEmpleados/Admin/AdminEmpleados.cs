using LibreriaEmpleado.Models.Derivada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using WindowsEmpleados.Data;

namespace WindowsEmpleados.Admin
{
    public static class AdminEmpleados
    {

        public static DbEmpleadosContext context = new DbEmpleadosContext();

        public static int Insertar(Empleado empleado)
        {
            if (empleado != null)
            {
                context.Empleados.Add(empleado);
                int filasAfectadas = context.SaveChanges();
                return filasAfectadas;
            } else
            {
                return 0;
            }
        }

        public static List<Empleado> Listar()
        {
            return context.Empleados.ToList();
        }

    }
}
