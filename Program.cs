using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Car obiekt = new Car(2.1,"Ford");

            Console.WriteLine("{0} {1}", obiekt.pojemnoscSilnika, obiekt.marka);
            Console.ReadKey();
        }
    }
}
