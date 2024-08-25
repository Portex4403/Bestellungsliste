using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Christ_Bestellungsliste.Model
{
    public abstract class Posten
    {
        public string Name { get; set; }
        public double Preis { get; set; }

        public abstract double BerechnePreis(double Preis);
    }
}
