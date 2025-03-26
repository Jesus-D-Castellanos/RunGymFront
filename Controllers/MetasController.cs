using Newtonsoft.Json;
using RunGymFront.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace RunGymFront.controllers
{
    public class MetasController : Controller
    {
        string apiUrl = ConfigurationManager.AppSettings["Api"].ToString();

        public ActionResult Metas()
        {
            return View();
        }

        // POST: Registro/Metas
        [HttpPost]
        public async Task<ActionResult> Metas(Metas model)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);
                    client.DefaultRequestHeaders.Clear();

                    string json = JsonConvert.SerializeObject(model);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync("api/Metas/PostMetas", content);

                    // Verificar el código de estado de la respuesta
                    if (!ModelState.IsValid)
                    {
                        return View();
                    }

                    // Lógica para guardar el usuario...

                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                // Si algo sale mal en el código, capturar el error
                TempData["Error"] = $"Hubo un error al procesar la solicitud: {ex.Message}";
                return RedirectToAction("Metas", "Metas");
            }
        }
    }
}
