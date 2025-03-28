using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Tarea.Models;

namespace Tareas.Controllers
{
    [ApiController]
    [Route("api/tareas")]
    public class TareaController : ControllerBase
    {
        private static readonly List<Usuario> _tareas = new();

        [HttpGet]
        public ActionResult<List<Usuario>> ObtenerTareas()
        {
            return Ok(_tareas);
        }

        [HttpPost]
        public ActionResult AgregarTarea([FromBody] Usuario tarea)
        {
            if (tarea == null)
                return BadRequest(new { mensaje = "La tarea no puede ser nula" });

            tarea.Id = _tareas.Count + 1;
            _tareas.Add(tarea);
            return CreatedAtAction(nameof(ObtenerTareas), new { id = tarea.Id }, tarea);
        }

        [HttpPut("{id}")]
        public ActionResult ActualizarTarea(int id, [FromBody] Usuario tarea)
        {
            var tareaExistente = _tareas.FirstOrDefault(t => t.Id == id);
            if (tareaExistente == null)
                return NotFound(new { mensaje = "Tarea no encontrada" });

            tareaExistente.Nombre = tarea.Nombre;
            return NoContent();
        }

        [HttpPut("completar/{id}")]
        public ActionResult CompletarTarea(int id)
        {
            var tarea = _tareas.FirstOrDefault(t => t.Id == id);
            if (tarea == null)
                return NotFound(new { mensaje = "Tarea no encontrada" });

            tarea.Completada = !tarea.Completada;
            return Ok(new { tarea.Id, tarea.Completada });
        }

        [HttpDelete("{id}")]
        public ActionResult EliminarTarea(int id)
        {
            var eliminados = _tareas.RemoveAll(t => t.Id == id);
            if (eliminados == 0)
                return NotFound(new { mensaje = "Tarea no encontrada" });

            return NoContent();
        }
    }
}


