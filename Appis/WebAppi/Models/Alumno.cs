using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebAppi.Models
{
    public partial class Alumno
    {
 

        public int IdAlumno { get; set; }
        public string Nombre { get; set; } = null!;
        public string ApellidoPa { get; set; } = null!;
        public string ApellidoMa { get; set; } = null!;
        public int Edad { get; set; }
        public string Sexo { get; set; } = null!;
    }
}
