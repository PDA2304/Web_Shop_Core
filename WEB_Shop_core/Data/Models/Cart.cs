using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_Shop_core.Data.Models
{
    public class Cart : SuccZakk
    {
        public Cart()
        {
            CartLines = new List<Mebel>();
        }
        public List<Mebel> CartLines { get; set; }

        public uint FinalPrice
        {
            get
            {
                uint sum = 0;
                foreach (var product in CartLines)
                {
                    sum += product.prise;
                }
                return sum;
            }
        }
    }
}
