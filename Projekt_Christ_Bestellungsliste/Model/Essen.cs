using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Christ_Bestellungsliste.Model
{
    internal class Essen : Posten
    {

        bool ExtraGross {  get; set; }
        public Essen(bool extraGross, string name, double preis)
        {
            ExtraGross = extraGross;
            base.Name = name;
            base.Preis = preis;
        }
        public override double BerechnePreis(double Preis)
        {
            return Preis * (ExtraGross ? 1.20 : 1); 
        }
    }
}
