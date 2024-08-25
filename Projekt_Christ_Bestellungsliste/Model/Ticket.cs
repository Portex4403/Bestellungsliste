using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Christ_Bestellungsliste.Model
{
    internal class Ticket : Posten
    {
        DateTime Startzeit { get; set; }
        int Minuten { get; set; }

        public Ticket(DateTime startzeit, int minuten, string name, double preis)
        {
            Startzeit = startzeit; 
            Minuten = minuten;
            base.Name = name;
            base.Preis = preis;
        }

        public override double BerechnePreis(double Preis)
        {
            return Preis * Minuten;
        }
    }
}
