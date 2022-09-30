using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


using Microsoft.EntityFrameworkCore;
using WebAppi.Models;

namespace WebAppi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriaController : ControllerBase
    {
        public readonly bdregistroescContext _dbcontext;

        public MateriaController(bdregistroescContext _context)
        {
            _dbcontext = _context;
        }

        [HttpGet]
        [Route("Lista")]

        public IActionResult Lista()
        {
            List<Materia> lista = new List<Materia>();
            try
            {
                lista = _dbcontext.Materias.ToList();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", response = lista });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = lista });
            }
        }

        [HttpGet]
        [Route("Obtener/{idMateria:int}")]
        public IActionResult Obtener(int idMateria)
        {
            Materia oMateria = _dbcontext.Materias.Find(idMateria);
            if (oMateria == null)
            {
                return BadRequest("Materia no encontrada");
            }

            try
            {
                oMateria = _dbcontext.Materias.Where(p => p.IdMateria == idMateria).FirstOrDefault();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", response = oMateria });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = oMateria });
            }
        }

        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] Materia objeto)
        {
            try
            {
                _dbcontext.Materias.Add(objeto);
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
        public IActionResult Editar([FromBody] Materia objeto)
        {

            Materia oMateria = _dbcontext.Materias.Find(objeto.IdMateria);
            if (oMateria == null)
            {
                return BadRequest("Materia no encontrada");
            }

            try
            {
              
                oMateria.Descripcion = objeto.Descripcion is null ? oMateria.Descripcion : objeto.Descripcion;
              

                _dbcontext.Materias.Update(oMateria);
                _dbcontext.SaveChanges();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }

        [HttpDelete]
        [Route("Eliminar/{idMateria:int}")]
        public IActionResult Eliminar(int idMateria)
        {
            Materia oMateria = _dbcontext.Materias.Find(idMateria);
            if (oMateria == null)
            {
                return BadRequest("Materia no encontrada");
            }

            try
            {
                _dbcontext.Materias.Remove(oMateria);
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
