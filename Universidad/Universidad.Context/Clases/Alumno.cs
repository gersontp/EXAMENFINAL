using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Context.Clases
{
    public class Alumno
    {

        public int AlumnoId { get; set; }

        [DisplayName("Código")]
        public string Codigo { get; set; }

        public DateTime Created { get; set; }

        [DisplayName("Apellido Paterno")]
        public string ApellidoPaterno { get; set; }

        [DisplayName("Apellido Materno")]
        public string ApellidoMaterno { get; set; }

        [DisplayName("Nombres")]
        public string Nombres { get; set; }

        public Genero Genero { get; set; }
        [DisplayName("Genero")]
        public int GeneroId { get; set; }

        public EstadoCivil EstadoCivil { get; set; }
        [DisplayName("Estado Civil")]
        public int EstadoCivilId { get; set; }
    }
}
