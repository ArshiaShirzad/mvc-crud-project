using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Education.Data;
using Education.Models;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Education.Controllers
{
    public class LevelController : Controller
    {
        public readonly ApplicationDbContext _context;
        public LevelController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(LevelViewModel model)
        {
            tbl_Level Level = new tbl_Level()
            {
                Level_Degree = model.Level_Degree,
            };
            _context.tbl_Level.Add(Level);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}