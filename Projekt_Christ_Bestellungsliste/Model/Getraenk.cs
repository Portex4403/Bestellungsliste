using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Christ_Bestellungsliste.Model
{
    internal class Getraenk : Posten
    {        
        public bool Alkoholisch { get; set; }
        public bool HappyHour { get; set; }

        public Getraenk(bool alkoholisch, bool happyHour, string name, double preis)
        {
            Alkoholisch = alkoholisch;
            HappyHour = happyHour;
            base.Name = name;
            base.Preis = preis;
        }

        public override double BerechnePreis(double preis)
        {
            if (Alkoholisch)
            {
                return Preis * (HappyHour? 0.75 : 1);
            }
            else
            {
                return Preis;
            }
        }
    }
}
