using System.Collections.Generic;
using System.Linq;
using EstudianteAppModels.Models; // Asegúrate de que este es el namespace correcto
using Microsoft.AspNetCore.Mvc;
using Qstom.QuoteIt.Core.Model.Cotizaciones.Entities;
using Usuario = Tarea.Models.Usuario;

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

        [HttpGet("{id}")]
        public ActionResult<Usuario> ObtenerTareaPorId(int id)
        {
            var tarea = _tareas.FirstOrDefault(t => t.Id == id);
            if (tarea == null)
                return NotFound(new { mensaje = "Tarea no encontrada" });

            return Ok(tarea);
        }

        [HttpPost]
        public ActionResult AgregarTarea([FromBody] Usuario tarea)
        {
            tarea.Id = _tareas.Count + 1;
            _tareas.Add(tarea);
            return CreatedAtAction(nameof(ObtenerTareaPorId), new { id = tarea.Id }, tarea);
        }

        [HttpPut("{id}")]
        public ActionResult ActualizarTarea(int id, [FromBody] Usuario tarea)
        {
            var tareaExistente = _tareas.FirstOrDefault(t => t.Id == id);
            if (tareaExistente == null)
                return NotFound(new { mensaje = "Tarea no encontrada" });

            tareaExistente.Nombre = tarea.Nombre;
            tareaExistente.Completada = tarea.Completada;
            return NoContent();
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