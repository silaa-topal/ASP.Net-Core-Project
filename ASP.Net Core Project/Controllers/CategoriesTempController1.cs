using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Core_Project.Controllers
{
    public class CategoriesTempController1 : Controller
    {
        // GET: CategoriesTempController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: CategoriesTempController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoriesTempController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesTempController1/Create
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

        // GET: CategoriesTempController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoriesTempController1/Edit/5
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

        // GET: CategoriesTempController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoriesTempController1/Delete/5
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
