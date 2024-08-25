using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Christ_Bestellungsliste.Model
{
    public class Bestellung
    {
        public bool BitAndBiteCard { get; set; }
        public List<Posten> Bestellposten { get; set; }

        public Bestellung(bool bitAndBiteCard) 
        {
            BitAndBiteCard = bitAndBiteCard;
            Bestellposten = new List<Posten>();
        }

        public void HinzufuegenPosten(Posten posten)
        {
            Bestellposten.Add(posten);
        }

        public double BerechneBestellung(double Preis)
        {
            double gesamtPreis = 0;
            foreach(var posten in Bestellposten)
            {
                gesamtPreis += posten.BerechnePreis(Preis);
            }

            if (BitAndBiteCard)
            {
                gesamtPreis *= 0.9;
            }
            return gesamtPreis;
        }
    }
}
