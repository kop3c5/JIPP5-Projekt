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
            var modelList = modeleManager.GetModels();
            return View(modelList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ModeleModel modeleModel)
        {
            modeleManager.AddModel(modeleModel);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            var model = modeleManager.GetModel(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult RemoveConfirm(int id)
        {
            modeleManager.RemoveModel(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = modeleManager.GetModel(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(ModeleModel model)
        {
            modeleManager.UpdateModel(model);
            return RedirectToAction("Index");
        }
    }
}
