using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem(); // dostislem = instance = örnek
            dortIslem.Topla(5, 7);
            dortIslem.Topla(8, 32);
        }
    }
}
