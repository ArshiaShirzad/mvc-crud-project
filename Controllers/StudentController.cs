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
    public class StudentController : Controller

    {

        public readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var query = _context.tbl_Student;
            StudentViewModel model = new StudentViewModel();
            model.Students = query.ToList();


            return View(model);
        }


        public IActionResult Create()
        {

            StudentViewModel model1 = new StudentViewModel();
            model1.Cities = new SelectList(_context.tbl_City, "ID", "City_Name");

            return View(model1);
        }
        [HttpPost]
        public IActionResult Create(StudentViewModel model)
        {
            tbl_Student Student = new tbl_Student()
            {
                Student_Name = model.Student_Name,
                Student_LastName = model.Student_LastName,
                Student_FatherName = model.Student_FatherName,
                Student_Address = model.Student_Address,
                Student_Gender = model.Student_Gender,
                Student_Number = model.Student_Number,
                Student_ValidateNumber = model.Student_ValidateNumber,
                CityID=model.CityID,

            };
            _context.tbl_Student.Add(Student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int ID)
        {
            var query = _context.tbl_Student.Where(x => x.ID == ID);
            if (query.Count() == 0)
            {

            }
            var query1 = _context.tbl_Student.Where(x => x.ID == ID).FirstOrDefault();
            _context.tbl_Student.Remove(query1);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Update(int ID)
        {
            var query = _context.tbl_Student.Where(x => x.ID == ID).FirstOrDefault();
            StudentViewModel model = new StudentViewModel();
            model.Cities = new SelectList(_context.tbl_City,"ID","City_Name");
            model.ID = query.ID;
            model.Student_Name = query.Student_Name;
            model.Student_LastName = query.Student_LastName;
            model.Student_Gender = query.Student_Gender;
            model.Student_FatherName = query.Student_FatherName;
            model.Student_Address = query.Student_Address;
            model.Student_Number = query.Student_Number;
            model.Student_ValidateNumber = query.Student_ValidateNumber;
            model.CityID = query.CityID;


            return View(model);
        }
        [HttpPost]
        public IActionResult Update(StudentViewModel model)
        {
            var query2 = _context.tbl_Student.Where(x => x.ID == model.ID).FirstOrDefault();
            query2.ID = model.ID;
            query2.Student_Name = model.Student_Name;
            query2.Student_LastName = model.Student_LastName;
            query2.Student_Gender = model.Student_Gender;
            query2.Student_FatherName = model.Student_FatherName;
            query2.Student_Address = model.Student_Address;
            query2.Student_Number = model.Student_Number;
            query2.Student_ValidateNumber = model.Student_ValidateNumber;
            query2.CityID = model.CityID;
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}