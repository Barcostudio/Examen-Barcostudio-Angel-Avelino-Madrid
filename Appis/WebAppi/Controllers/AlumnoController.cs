using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


using Microsoft.EntityFrameworkCore;
using WebAppi.Models;

namespace WebAppi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {

        public readonly bdregistroescContext _dbcontext;

        public AlumnoController(bdregistroescContext _context)
        {
            _dbcontext = _context;
        }

        [HttpGet]
        [Route("Lista")]

        public IActionResult Lista()
        {
            List<Alumno> lista = new List<Alumno>();
            try
            {
                lista = _dbcontext.Alumnos.ToList();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", response = lista });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = lista });
            }
        }

        [HttpGet]
        [Route("Obtener/{idAlumno:int}")]
        public IActionResult Obtener(int idAlumno)
        {
            Alumno oAlumno = _dbcontext.Alumnos.Find(idAlumno);
            if (oAlumno == null)
            {
                return BadRequest("Alumno no encontrado");
            }

            try
            {
                oAlumno = _dbcontext.Alumnos.Where(p => p.IdAlumno == idAlumno).FirstOrDefault();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", response = oAlumno });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = oAlumno });
            }
        }

        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] Alumno objeto)
        {
            try
            {
                _dbcontext.Alumnos.Add(objeto);
                _dbcontext.SaveChanges();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }

        [HttpPut]
        [Route("Editar")]
        public IActionResult Editar([FromBody] Alumno objeto)
        {

            Alumno oAlumno = _dbcontext.Alumnos.Find(objeto.IdAlumno);
            if (oAlumno == null)
            {
                return BadRequest("Alumno no encontrado");
            }

            try
            {
                oAlumno.Nombre = objeto.Nombre is null ? oAlumno.Nombre : objeto.Nombre;
                oAlumno.ApellidoPa = objeto.ApellidoPa is null ? oAlumno.ApellidoPa : objeto.ApellidoPa;
                oAlumno.ApellidoMa = objeto.ApellidoMa is null ? oAlumno.ApellidoMa : objeto.ApellidoMa;
                oAlumno.Edad = objeto.Edad;
                oAlumno.Sexo = objeto.Sexo is null ? oAlumno.Sexo : objeto.Sexo;


                _dbcontext.Alumnos.Update(oAlumno);
                _dbcontext.SaveChanges();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }

        [HttpDelete]
        [Route("Eliminar/{idAlumno:int}")]
        public IActionResult Eliminar(int idAlumno)
        {
            Alumno oAlumno = _dbcontext.Alumnos.Find(idAlumno);
            if (oAlumno == null)
            {
                return BadRequest("Alumno no encontrado");
            }

            try
            {
                _dbcontext.Alumnos.Remove(oAlumno);
                _dbcontext.SaveChanges();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }
    }
}

