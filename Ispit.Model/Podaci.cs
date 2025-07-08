using Ispit.Model.Klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model
{
    public class Podaci
    {
        public List<Banka> ListaBanki { get; }

        public List<Klijent> ListaKlijenata { get; }

        public Podaci()
        {
            ListaBanki = new List<Banka>()
            {
                new Banka() {Naziv = "Zagrebačka Banka", Simbol = "ZABA" },
                new Banka() {Naziv = "Privredna Banka Zagreb", Simbol = "PBZ" },
                new Banka() {Naziv = "Međimurska Banka", Simbol = "MB" }
            };

            ListaKlijenata = new List<Klijent>()
            {
                new Klijent() { ImePrezime = "Ivan Vidović", Banka = "ZABA", Stanje = 1987050.98 },
                new Klijent() { ImePrezime = "Petar Preradović", Banka = "PBZ", Stanje = 9856.57 },
                new Klijent() { ImePrezime = "Ivana Brlić Mažuranić", Banka = "PBZ", Stanje = 3004987.68 },
                new Klijent() { ImePrezime = "Nikolina Mikec", Banka = "MB", Stanje = 5875698 },
                new Klijent() { ImePrezime = "Nitko Nitković", Banka = "ZABA", Stanje = 0.69 },
                new Klijent() { ImePrezime = "Ivica Todorović", Banka = "PBZ", Stanje = 18987050.98 },
                new Klijent() { ImePrezime = "Zdravko Mamić", Banka = "MB", Stanje = 1999989.99 },
                new Klijent() { ImePrezime = "Andrej Plenković", Banka = "ZABA", Stanje = 50.98 },
                new Klijent() { ImePrezime = "Đelo Hađiselimović", Banka = "MB", Stanje = 8579645.87 },
                new Klijent() { ImePrezime = "Propali Slučajić", Banka = "ZABA", Stanje = 0}
            };
        }

    }
}
