using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_Shop_core.Data.Models;

namespace WEB_Shop_core.Data
{
    public class AppDBContent : DbContext
    {
        public DbSet<Mebel> Mebels { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<RegisteViewModel> RegisteViewModel { get; set; }

        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
