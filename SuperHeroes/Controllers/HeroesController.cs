using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroes.Data;
using SuperHeroes.Models;
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
            var listOfHeroes = _context.Heroes.ToList();
            return View(listOfHeroes);
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
        public ActionResult Create(Hero hero)  //this was changed
        {
            try
            {
                // TODO: Add insert logic here
                _context.Heroes.Add(hero);
                _context.SaveChanges();
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
            var findId = _context.Heroes.Find(id);
            return View(findId);
        }

        // POST: HeroesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Hero hero)
        {
            try
            {
                _context.Heroes.Update(hero);
                _context.SaveChanges();
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
