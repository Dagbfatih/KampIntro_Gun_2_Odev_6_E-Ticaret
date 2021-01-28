using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryID = 2; // CategoryID 2 = Mobilya Kategorisi // CategoryID 5 = kırtasiye kategorisi
            product1.ProductName = "Masa";
            product1.UnitPrice = 1000;
            product1.UnitsInStock = 5;

            Product product2 = new Product() { ID = 2, UnitsInStock = 10, UnitPrice = 20, ProductName = "Kalem", CategoryID = 5 }; // sıralama fark etmez

            //PascalCase   //camelCase ||| PascalCase: her kelimenin ilk harfi büyük | camelCase: ilk kelimenin baş harfi küçük diğer kelimelerin baş harfleri büyük
            ProductManager productManager = new ProductManager();
            //                     Stack  =   Heap
        }
    }
}
