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
            Debug.WriteLine("Pedro was here!");
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
        public IActionResult InsertNumber(NumberStats obj)
        {



            _applicationDbContext.NumberStats.Add(obj);
            _applicationDbContext.SaveChanges();
            Debug.WriteLine("Pedro was here");
            return Redirect("Index");
        }
    }
}
