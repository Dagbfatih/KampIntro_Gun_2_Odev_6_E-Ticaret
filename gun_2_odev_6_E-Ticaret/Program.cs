using System;

namespace gun_2_odev_6_E_Ticaret
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; 
            product product1 = new product();
            product1.productName = "LG Monitor";
            product1.price = 2000;
            product1.discount = -1;
            product1.soldNumber = 30;

            product product2 = new product();
            product2.productName = "Logitech G432 Headset";
            product2.price = 650; // 591.5
            product2.discount = 9; // %9
            product2.soldNumber = 10;

            product product3 = new product();
            product3.productName = "Xiaomi Redmi Note 8";
            product3.price = 1700; // 1530
            product3.discount = 10; // %10
            product3.soldNumber = 20;

            product[] products = new product[] { product1, product2, product3 };

            Console.WriteLine("||||||||||||||||||||||| FOREACH LOOP |||||||||||||||||||||||\n");
            foreach (var pr in products) // You can write 'product' instead of 'var'
            {
                Console.WriteLine("Name Of Product: \t\t" + pr.productName);
                
                if (pr.discount == -1)
                    Console.WriteLine("Price Of Product: \t\t" + pr.price + " TL");
                else if (pr.discount < 0)
                    Console.WriteLine("Please enter a valid percentage...");
                else
                {
                    pr.price = (pr.price * (100 - pr.discount)) / 100;
                    Console.WriteLine("Price Of product: \t\t" + pr.price + " TL - %" + pr.discount + " Discounted");
                }
                Console.WriteLine("number of products sold: \t" + pr.soldNumber + " PCS Sold");
                Console.WriteLine("---------\n");
            }

            Console.WriteLine("||||||||||||||||||||||||| FOR LOOP |||||||||||||||||||||||||\n");
            for (; i < products.Length; i++)
            {
                Console.WriteLine("Name Of Product: \t\t" + products[i].productName);

                if (products[i].discount == -1)
                    Console.WriteLine("Price Of Product: \t\t" + products[i].price + " TL");
                else if (products[i].discount < 0)
                    Console.WriteLine("Please enter a valid percentage...");
                else
                    Console.WriteLine("Price Of product: \t\t" + products[i].price + " TL - %" + products[i].discount + " Discounted");

                Console.WriteLine("number of products sold: \t" + products[i].soldNumber + " PCS Sold");
                Console.WriteLine("---------\n");
            }
            i = 0;

            Console.WriteLine("|||||||||||||||||||||||| WHILE LOOP ||||||||||||||||||||||||\n");
            while ( i < products.Length )
            {
                Console.WriteLine("Name Of Product: \t\t" + products[i].productName);

                if (products[i].discount == -1)
                    Console.WriteLine("Price Of Product: \t\t" + products[i].price + " TL");
                else if (products[i].discount < 0)
                    Console.WriteLine("Please enter a valid percentage...");
                else
                    Console.WriteLine("Price Of product: \t\t" + products[i].price + " TL - %" + products[i].discount + " Discounted");

                Console.WriteLine("number of products sold: \t" + products[i].soldNumber + " PCS Sold");
                Console.WriteLine("---------\n");
                i++;
            }
        }
    }

    class product
    {
        public string productName { get; set; }
        public double price { get; set; }
        public int discount { get; set; } // in percent to discount. İf there is no discount enter '-1'.
        public int soldNumber { get; set; }
    }
}
