using System;
namespace Education.Data
{
    public class tbl_City
    {
        public tbl_City()
        {
        }
        
        public int ID { get; set; }

        public string City_Name { get; set; }

        public int ProvinceID { get; set; }
        public tbl_Province tbl_Province;
    }
}

