using BoilerPlateRouletteSolution.Data;
using BoilerPlateRouletteSolution.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BoilerPlateRouletteSolution.Controllers
{
    public class NumberBetsController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext; // This is dependency injection. Read more about it 1º
        public NumberBetsController(ApplicationDbContext applicationDbContext) // This is dependency injection. Read more about it 1º
        {
            _applicationDbContext = applicationDbContext; // This is dependency injection. Read more about it 1º
            // This works because we already have added ApplicationDbContext in our services container.
        }
        public IActionResult Index()
        {
            IEnumerable<NumberStats> objList = _applicationDbContext.NumberStats;
            Debug.WriteLine(objList);

            return View(objList);
        }

        // GET FOR INSERT
        public IActionResult InsertNumber()
        {
            return View();
        }   
        
        // POST FOR INSERT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult InsertNumber(NumberStats obj) // User inserts a number, is passed here
        {
            //obj.Number % = 0;

            // number is even
            // Increment number's quantity
            // get color
            // Calculate statistic

            if (ModelState.IsValid)
            {
                  _applicationDbContext.NumberStats.Add(obj);
                //_applicationDbContext.NumberStats.Update(); ;

                  _applicationDbContext.SaveChanges();

                     return Redirect("Index");
            }
                return View(obj);


        }

        // GET FOR EDIT
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound(); // INVALID
            }

            NumberStats obj = _applicationDbContext.NumberStats.Find(id);
            if (obj == null)
            {
                return NotFound(); // Record was not found.
            }

            return View(obj); // Show the record if it was found on NumberStats
        }


        // POST FOR EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(NumberStats obj) // User inserts a number, is passed here
        {
            //obj.Number % = 0;

            // number is even
            // Increment number's quantity
            // get color
            // Calculate statistic

            if (ModelState.IsValid)
            {

                _applicationDbContext.NumberStats.Update(obj);
                _applicationDbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(obj);


        }

        // GET FOR DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound(); // INVALID
            }

            NumberStats obj = _applicationDbContext.NumberStats.Find(id); // We retrive the object based on ID
            if (obj == null)
            {
                return NotFound(); // Record was not found.
            }

            return View(obj); // Show the record if it was found on NumberStats
        }


        // POST FOR DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id) // User inserts a number, is passed here
        {
            //obj.Number % = 0;

            // number is even
            // Increment number's quantity
            // get color
            // Calculate statistic

            NumberStats obj = _applicationDbContext.NumberStats.Find(id); // We retrive the object based on ID
            if (obj == null)
            {
                return NotFound(); // If we have nothing to delete
            }
                _applicationDbContext.NumberStats.Remove(obj);
                _applicationDbContext.SaveChanges();

                return RedirectToAction("Index");


        }
    }
}
