using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Education.Models;
using Microsoft.AspNetCore.Mvc;
using Education.Data;

namespace Education.Controllers
{
    public class FieldController : Controller
    {
        public readonly ApplicationDbContext _context;
        public FieldController(ApplicationDbContext context)
        {
            _context = context;
        }



        public IActionResult Index()
        {
            var query = _context.tbl_Field;
            FieldViewModel model = new FieldViewModel();
            model.Fields = query.ToList();

            return View(model);
        }


        public IActionResult Create()
        {


            return View();
        }
        [HttpPost]
        public IActionResult Create(FieldViewModel model) {

            tbl_Field Field = new tbl_Field()
            {
                Field_Name = model.Field_Name,
            };
            _context.tbl_Field.Add(Field);
            _context.SaveChanges();
            
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int ID)
        {
            var query = _context.tbl_Field.Where(x => x.ID == ID);
            if (query.Count() == 0)
            {

            }
            var query1 = _context.tbl_Field.Where(x => x.ID == ID).FirstOrDefault();

            _context.tbl_Field.Remove(query1);
            _context.SaveChanges();


            return RedirectToAction("Index");

        }

        public IActionResult Update(int ID)
        {
            var query = _context.tbl_Field.Where(x => x.ID == ID).FirstOrDefault();
            FieldViewModel model = new FieldViewModel();
            model.ID = query.ID;
            model.Field_Name = query.Field_Name;

            return View(model);
        }
        [HttpPost]
        public IActionResult Update(FieldViewModel model)
        {
            var query1 = _context.tbl_Field.Where(x => x.ID == model.ID).FirstOrDefault();
            query1.Field_Name = model.Field_Name;
            _context.SaveChanges();



            return RedirectToAction("Index");
        }

    }
}