using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace WebApplication2.Controllers
{
    public class Registro 
    {
        public string Nombre { get; set; }
        public string Apartamento { get; set; }
        public string Documento { get; set; }
    }

    public class PruebasController : Controller
    {
        // GET: PruebasController
        public async Task<ActionResult> Index()
        {
            var get = await new HttpClient().GetAsync("https://localhost:7234/WeatherForecast/GetReals");

            var x = await get.Content.ReadAsStringAsync();
            var jj = JsonConvert.DeserializeObject<List<Registro>>(x);

            return View();
        }

        // GET: PruebasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PruebasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PruebasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PruebasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PruebasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PruebasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PruebasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
