using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Tarea.Models;

namespace Tareas.Controllers
{
    public class HomeController : Controller
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("http://localhost:5120/api/tareas");
            var json = await response.Content.ReadAsStringAsync();
            var tareas = JsonSerializer.Deserialize<List<Usuario>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return View(tareas ?? new List<Usuario>());
        }

        [HttpPost]
        public async Task<IActionResult> AgregarTarea(string Nombre, bool Completada = false)
        {
            var nuevaTarea = new Usuario { Nombre = Nombre, Completada = Completada };
            var json = JsonSerializer.Serialize(nuevaTarea);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            await _httpClient.PostAsync("http://localhost:5120/api/tareas", content);

            return RedirectToAction("Index");
        }

        [HttpPost("/Home/CompletarTarea/{id}")]
        public async Task<IActionResult> CompletarTarea(int id)
        {
            await _httpClient.PutAsync($"http://localhost:5120/api/tareas/completar/{id}", null);
            return RedirectToAction("Index");
        }

        [HttpPost("/Home/EditarTarea/{id}")]
        public async Task<IActionResult> EditarTarea(int id, string nombre)
        {
            var tarea = new { Nombre = nombre };
            var json = JsonSerializer.Serialize(tarea);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            await _httpClient.PutAsync($"http://localhost:5120/api/tareas/{id}", content);
            return RedirectToAction("Index");
        }

        [HttpDelete("/Home/EliminarTarea/{id}")]
        public async Task<IActionResult> EliminarTarea(int id)
        {
            await _httpClient.DeleteAsync($"http://localhost:5120/api/tareas/{id}");
            return RedirectToAction("Index");
        }
    }
}
