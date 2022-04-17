using System;
using CretaceousClient.Models;
using Microsoft.AspNetCore.Mvc;

namespace CretaceousClient.Controllers
{
    public class AnimalController : Controller
    {
      public IActionResult Index()
      {
        var allAnimals = Animal.GetAnimals();
        return View(allAnimals);
      }
      
    }
}


