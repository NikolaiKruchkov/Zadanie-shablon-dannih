using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_Shablon_dannih
{
    public enum Categories
    {
        Eda,
        Technika
    }
    public class Product
    {
        public string Nazvanie { get; set; }
        public int Cena { get; set; }
        public string Izobragenie { get; set; }
        public Categories Category { get; set; }
        
    }
}
