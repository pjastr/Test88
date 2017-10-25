using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Samochod
    {
        private string model;
        public double pojemnoscSilnika;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private double cena;

        public double Cena
        {
            get { return cena; }
            set { cena = value; }
        }

        public string Marka { get; set; }
        
    }
}
