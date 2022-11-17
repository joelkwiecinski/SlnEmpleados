using LibreriaEmpleado.Models.Derivada;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models
{

    [Table("Departamentos")]
    public class Departamento
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }

        public List<Empleado> Empleados { get; set; }

        public Departamento(int id, string nombre, List<Empleado> empleados)
        {
            Id = id;
            Nombre = nombre;
            Empleados = empleados;
        }
    }
}
