using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebAppi.Models
{
    public partial class Calificacione
    {
        public int IdCali { get; set; }
        public int IdAlumno { get; set; }
        public int IdMateria { get; set; }
        public int Pparcial { get; set; }
        public int Sparcial { get; set; }
        public int Tparcial { get; set; }
        public int Calificaciones { get; set; }


    }
}
