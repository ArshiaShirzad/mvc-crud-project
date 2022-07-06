using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Education.Data;
namespace Education.Models
{
    public class ProvinceViewModel
    {
        public ProvinceViewModel()
        {
            Provinces = new List<tbl_Province>();
        }
        
        public int ID { get; set; }

        public string Province_Name { get; set; }

        public List<tbl_Province> Provinces;
    }
}
