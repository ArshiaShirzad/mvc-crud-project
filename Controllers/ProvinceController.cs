using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Education.Models;
using Microsoft.AspNetCore.Mvc;
using Education.Data;

namespace Education.Controllers
{
    
    public class ProvinceController : Controller
    {
        public readonly ApplicationDbContext _context;

        public ProvinceController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var query = _context.tbl_Province;
            ProvinceViewModel model = new ProvinceViewModel();
            model.Provinces = query.ToList();
            return View(model);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(ProvinceViewModel model)
        {
            tbl_Province Province = new tbl_Province() {
                Province_Name = model.Province_Name,
            };
            _context.tbl_Province.Add(Province);
            _context.SaveChanges();

            return RedirectToAction("index");

           
        }
        public IActionResult Delete(int ID)
        {
            var query = _context.tbl_Province.Where(x => x.ID == ID);

            if (query.Count() == 0)
            {

            }
            var query1 = _context.tbl_Province.Where(x => x.ID == ID).FirstOrDefault();


            _context.tbl_Province.Remove(query1);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
       
        public IActionResult Update(int ID)
        {

            var query1 = _context.tbl_Province.Where(x => x.ID == ID).FirstOrDefault();

            ProvinceViewModel model = new ProvinceViewModel();
            model.ID = query1.ID;
            model.Province_Name = query1.Province_Name;



            return View(model);
        }
        [HttpPost]
        public IActionResult Update(ProvinceViewModel model)
        {
            var query1 = _context.tbl_Province.Where(x => x.ID == model.ID).FirstOrDefault();
            query1.Province_Name = model.Province_Name;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}