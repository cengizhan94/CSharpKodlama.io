using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        //ID
        public int id { get; set; }
        //Kategori ID
        public int CategoryId { get; set; }
        //Urun Adi
        public string ProductName { get; set; }
        //Urun Fiyati
        public double UnitPrice { get; set; }
        //Stok Adedi
        public int UnitsInStock { get; set; }

    }
}
