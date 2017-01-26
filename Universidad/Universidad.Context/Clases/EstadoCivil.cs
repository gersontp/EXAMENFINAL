using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Context.Clases
{
   public  class EstadoCivil
    {

       public EstadoCivil()
       {
           Alumno = new List<Alumno>();
       }
        public int EstadoCivilId { get; set; }

        [DisplayName("Estado Civil")]
        public string Descripcion { get; set; }

        public List<Alumno> Alumno { get; set; }
    }
}
