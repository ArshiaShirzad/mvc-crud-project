using System;
using Education.Data;
using System.Collections.Generic;
namespace Education.Models
{
    public class LevelViewModel
    {
        public LevelViewModel()
        {
            Levels = new List<tbl_Level>();
        }
        public int ID { get; set; }
        public string Level_Degree { get; set; }


        public List<tbl_Level> Levels { get; set; }
    }
}
