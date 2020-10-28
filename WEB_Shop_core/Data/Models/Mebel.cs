using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_Shop_core.Data.Models
{
    public class Mebel
    {
       [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; }
        public string factoryName { get; set; }
        public string img { get; set; }
        public uint prise { get; set; }
        public bool available { get; set; }// есть ли довар на скаладе  на скаладе
        public bool isFavourite { get; set; } // нужно ли выводить товар на главную странцу
        public int categoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
