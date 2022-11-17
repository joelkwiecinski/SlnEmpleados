using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models.Derivada
{
    public class Cliente : Persona
    {
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Cuit { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Telefono { get; set; }

        public Cliente(int id, string nombre, string apellido, string cuit, string telefono) : base(id, nombre, apellido)
        {
            Cuit = cuit;
            Telefono = telefono;
        }

        public Cliente() { }

    }
}
