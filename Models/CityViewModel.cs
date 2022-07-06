using System;
using Education.Data;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Education.Models
{
    public class CityViewModel
    {
        public CityViewModel()
        {
            Cities = new List<tbl_City>();
        }
        public int ID { get; set; }

        public string City_Name { get; set; }

        public int ProvinceID { get; set; }

        public tbl_Province tbl_Province;

        public SelectList Provinces { get; set; }

        public List<tbl_City> Cities;
    }
}
