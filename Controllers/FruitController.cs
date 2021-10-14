using fruitApplicationM3.Models;
using fruitApplicationM3.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fruitApplicationM3.Controllers
{

    public class FruitController : Controller
    {
        private readonly IFruitrepo repo;
        public FruitController(IFruitrepo _repo)
        {
            repo = _repo;
        }
        public IActionResult Index()
        {
            return View(repo.GetFruits());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Fruit fruit)
        {
            repo.Createfruit(fruit);
            return RedirectToAction("Index");
        }


    }
}
