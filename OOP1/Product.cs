using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; } // birim fiyat
        public int UnitsInStock { get; set; } // stoktaki birim adedi/sayısı

        // CRUD operations | Create -Read - Update - Delete

    }
}
