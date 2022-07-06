using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Education.Data;
using Education.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Education.Controllers
{
    public class CityController : Controller
    {
        public readonly ApplicationDbContext _context;

        public CityController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var query = _context.tbl_City;
            CityViewModel model = new CityViewModel();
            model.Cities = query.ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            CityViewModel model1 = new CityViewModel();
            model1.Provinces = new SelectList(_context.tbl_Province, "ID", "Province_Name");

            return View(model1);
        }
        [HttpPost]
        public IActionResult Create(CityViewModel model)
        {

            tbl_City City = new tbl_City()
            {
                City_Name = model.City_Name,
                ProvinceID = model.ProvinceID,
            };

            _context.tbl_City.Add(City);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int ID)
        {

            var query = _context.tbl_City.Where(x => x.ID == ID);

            if (query.Count() == 0)
            {

            }
            var query1 = _context.tbl_City.Where(x => x.ID == ID).FirstOrDefault();


            _context.tbl_City.Remove(query1);
            _context.SaveChanges();

            return RedirectToAction("Index");

            
        }
        public IActionResult Update(int ID)
        {
            var query = _context.tbl_City.Where(x => x.ID == ID).FirstOrDefault();
            CityViewModel model = new CityViewModel();
            model.Provinces = new SelectList(_context.tbl_Province, "ID", "Province_Name");
            model.ID = query.ID;
            model.City_Name = query.City_Name;
            model.ProvinceID = query.ProvinceID;
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(CityViewModel model)
        {
            var query1 = _context.tbl_City.Where(x => x.ID == model.ID).FirstOrDefault();
            query1.City_Name = model.City_Name;
            query1.ProvinceID = model.ProvinceID;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}