using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Context.Clases
{
    public class Genero
    {

        public Genero()
        {
            Alumno = new List<Alumno>();

        } 
        public int GeneroId { get; set; }

        [DisplayName("Genero")]
        public string Descripcion { get; set; }

        public List<Alumno> Alumno { get; set; }
        
    }
}
