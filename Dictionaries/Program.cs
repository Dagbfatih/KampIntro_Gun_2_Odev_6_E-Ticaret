using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> cities = new Dictionary<int, string>();
            cities.Add(1, "Adana");
            cities.Add(2, "Adıyaman");
            cities.Add(3, "Afyon");
            cities.Add(4, "Ağrı");
            cities.Add(5, "Amasya");
            cities.Add(6, "Ankara");
            cities.Add(7, "Antalya");
            cities.Add(14, "Bolu");

            //for (int i = 1; i <= cities.Count; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}
            //Console.WriteLine();

            foreach (var city in cities)
            {
                Console.Write(city.Key + " ");
                Console.WriteLine(city.Value);
            }

            Console.WriteLine("----------------------");

            Dictionary<string, string> capitals = new Dictionary<string, string>(); // başkentler
            capitals.Add("Turkey", "Ankara");
            capitals.Add("England", "London");
            capitals.Add("France", "Paris");
            capitals.Add("Germany", "Berlin");
            capitals.Add("Italy", "Rome");

            Console.WriteLine(capitals["Turkey"]); // turkey anahtarını çağırdım bana Ankara Değerini verdi

            foreach (var item in capitals)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

        }
    }
}
