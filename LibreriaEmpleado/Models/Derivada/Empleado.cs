using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models.Derivada
{

    [Table("Empleados")]
    public class Empleado : Persona
    {

        [Required]
        public int Legajo { get; set; }

        public Departamento Departamento { get; set; }

        public Empleado(int id, string nombre, string apellido, int legajo) : base(id, nombre, apellido)
        {
            Legajo = legajo;
        }

        public Empleado() { }

    }
}
