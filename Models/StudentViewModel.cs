using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Education.Data;
namespace Education.Models
{
    public class StudentViewModel
    {
        public StudentViewModel()
        {
            Students = new List<tbl_Student>();
        }

        public int ID { get; set; }
        public string Student_Name { get; set; }
        public string Student_LastName { get; set; }
        public string Student_Gender { get; set; }
        public string Student_FatherName { get; set; }
        public string Student_Address { get; set; }
        public string Student_Number { get; set; }
        public string Student_ValidateNumber { get; set; }
        //foreign key
        public int CityID { get; set; }
        public tbl_Student tbl_Student;
        //for dropdown list
        public SelectList Cities { get; set; }
        //make a list for index page
        public List<tbl_Student> Students;

    }
}
