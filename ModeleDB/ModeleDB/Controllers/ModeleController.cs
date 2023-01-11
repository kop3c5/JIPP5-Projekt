using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModeleDB.Controllers
{
    public class ModeleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
