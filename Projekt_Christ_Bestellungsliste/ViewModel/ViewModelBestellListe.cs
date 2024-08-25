using Projekt_Christ_Bestellungsliste.Model;
using Projekt_Christ_Bestellungsliste.View;
using Projekt_Christ_Bestellungsliste.ViewModel;
using System.Windows.Input;
using Projekt_Christ_Bestellungsliste.Commands;
using System.Collections.ObjectModel;

namespace Projekt_Christ_Bestellungsliste.ModelView
{
    public class BestellListeViewModel : ViewModelBase
    {
        public Bestellung AktuelleBestellung { get; set; }
        public ObservableCollection<Posten> Warenkorb { get; set; }

        public ICommand AddColaCommand { get; private set; }
        public ICommand AddPizzaCommand { get; private set; }
        public ICommand AddAlkoholCommand { get; private set; }
        public ICommand AddTicket1Command { get; private set; }
        public ICommand AddTicket12Command { get; private set; }
        public ICommand AddTicket24Command { get; private set; }

        public BestellListeViewModel()
        {
            AktuelleBestellung = new Bestellung(false);
            Warenkorb = new ObservableCollection<Posten>(AktuelleBestellung.Bestellposten);

            AddColaCommand = new RelayCommand(_ => AddGetraenk(new Getraenk(false, false, "Cola", 2.99)));
            AddAlkoholCommand = new RelayCommand(_ => AddGetraenk(new Getraenk(true, false, "Bier", 2.99)));
            AddPizzaCommand = new RelayCommand(_ => AddEssen(new Essen(false, "Pizza", 6.99)));
            AddTicket1Command = new RelayCommand(_ => AddTicket(new Ticket(DateTime.Now, 60, "Ticket1Stunde", 0.99)));
            AddTicket12Command = new RelayCommand(_ => AddTicket(new Ticket(DateTime.Now, 720, "Ticket12Stunde", 0.99)));
            AddTicket24Command = new RelayCommand(_ => AddTicket(new Ticket(DateTime.Now, 1440, "Ticket24Stunde", 0.99)));
        }

        private void AddGetraenk(Getraenk getraenk)
        {
            AktuelleBestellung.HinzufuegenPosten(getraenk);
            Warenkorb = new ObservableCollection<Posten>(AktuelleBestellung.Bestellposten);
            OnPropertyChanged(nameof(Warenkorb));
        }

        private void AddEssen(Essen essen)
        {
            AktuelleBestellung.HinzufuegenPosten(essen);
            Warenkorb = new ObservableCollection<Posten>(AktuelleBestellung.Bestellposten);
            OnPropertyChanged(nameof(Warenkorb));
        }

        private void AddTicket(Ticket ticket)
        {
            AktuelleBestellung.HinzufuegenPosten(ticket);
            Warenkorb = new ObservableCollection<Posten>(AktuelleBestellung.Bestellposten);
            OnPropertyChanged(nameof(Warenkorb));
        }
    }
}
