using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod auto = new Samochod();
            auto.Model = "dfdsfs";
            auto.Cena = 34;
            auto.Marka = "dsdfd33";
            Console.WriteLine("podaj cene");
            string wejscie = Console.ReadLine();
            double.TryParse(wejscie, out auto.pojemnoscSilnika);
            
        }
    }
}
