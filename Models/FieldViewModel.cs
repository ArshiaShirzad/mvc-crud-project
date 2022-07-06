using System;
using Education.Data;
using System.Collections.Generic;
namespace Education.Models
{
    public class FieldViewModel
    {
        public FieldViewModel()
        {
            Fields = new List<tbl_Field>();
        }
        public int ID { get; set; }
        public string Field_Name { get; set; }

        public List<tbl_Field> Fields;
    }
}
