using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Education.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<tbl_Province> tbl_Province { get; set; }
        public DbSet<tbl_City> tbl_City { get; set; }
        public DbSet<tbl_Student> tbl_Student { get; set; }
        public DbSet<tbl_Field> tbl_Field { get; set; }
        public DbSet<tbl_Level> tbl_Level { get; set; }
    }
    
}
