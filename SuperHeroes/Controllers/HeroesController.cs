using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroes.Controllers
{
    public class HeroesController : Controller
    {
        // Member Variable
        private ApplicationDbContext _context;

        //Constructor
        public HeroesController(ApplicationDbContext context) 
        {
            _context = context;
        }

        // GET: HeroesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HeroesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HeroesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HeroesController/Create
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

        // GET: HeroesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HeroesController/Edit/5
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

        // GET: HeroesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HeroesController/Delete/5
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
