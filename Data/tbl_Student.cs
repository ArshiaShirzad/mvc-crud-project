using System;
namespace Education.Data
{
    public class tbl_Student
    {
        public tbl_Student()
        {
        }
        //Main Fields are declared Here
        public int ID { get; set; }
        public string Student_Name { get; set; }
        public string Student_LastName { get; set; }
        public string Student_Gender { get; set; }
        public string Student_FatherName { get; set; }
        public string Student_Address { get; set; }
        public string Student_Number { get; set; }
        public string Student_ValidateNumber { get; set; }

        //foreign keys are declared here
        public int CityID { get; set; }
        
    }
}
