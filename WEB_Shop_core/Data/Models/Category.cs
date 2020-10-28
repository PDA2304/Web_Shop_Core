using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_Shop_core.Data.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categoryname { get; set; }
        public List<Mebel> Mebels{ get; set; }
    }
}
