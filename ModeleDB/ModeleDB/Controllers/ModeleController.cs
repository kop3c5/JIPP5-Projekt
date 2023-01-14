using Microsoft.AspNetCore.Mvc;
using ModeleDB.Logic;
using ModeleDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModeleDB.Controllers
{
    public class ModeleController : Controller
    {
        ModeleManager modeleManager = new ModeleManager();
        public IActionResult Index()
        {
            var random = new Random();
            var model = new ModeleModel()
            {

                Name = $"Jeep Willys{random.Next(1, 100)}",
                Brand = "Tamiya"

            };
            modeleManager.AddModel(model);
            return View();
        }
    }
}
