using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Universidad.Context.Clases;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace MVC.DTO
{
    public class AlumnoDTO
    {

      

        public int AlumnoId { get; set; }

        public string Codigo { get; set; }

        public string ApellidoPaterno { get; set; }

        public string ApellidoMaterno { get; set; }

        public string Nombres { get; set; }
        public DateTime Created { get; set; }

        public int EstadoCivilId { get; set; }

        public EstadoCivilDTO EstadoCivil { get; set; }

        public int GeneroId { get; set; }

        public GeneroDTO Genero { get; set; }
    }
}