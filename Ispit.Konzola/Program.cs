using Ispit.Model;
using Ispit.Model.Klase;

namespace Ispit.Konzola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"***** PARCIJALNI ISPIT LINQ ********");
            var servisPodataka = new Podaci();



            #region GrupiranjeMilijunasa
            //*********** grupiranje milijunaša ***********

            var grupirajPremaBanci = servisPodataka.ListaKlijenata
                .Where(k => k.Stanje >= 1000000)
                .GroupBy(k => k.Banka)
                .Select(m => new GrupiraniMilijunasi()
                {
                    Banka = m.Key,
                    Milijunasi = m.Select(k => $" {k.ImePrezime}")
                });


            foreach (var grupa in grupirajPremaBanci)
            {
                Console.Write($"\n{grupa.Banka}:");

                bool first = true;
                foreach (var milijunas in grupa.Milijunasi)
                {
                    if (first)
                    {
                        Console.Write($" {milijunas}");
                        first = false;
                    }
                    else
                    {
                        Console.Write($" i {milijunas}");
                    }

                }
            }

            #endregion


            #region IspisMilijunasa
            //************* ispis milijunaša i banke u kojoj se nalazi **************

            var izvjestajMilijunasa = servisPodataka.ListaKlijenata
                .Where(k => k.Stanje >= 1000000)
                .Join(servisPodataka.ListaBanki,
                k => k.Banka,
                b => b.Simbol,
                (k, b) => new
                {
                    k.ImePrezime,
                    Banka = b.Naziv
                });


            Console.WriteLine("\n"); //prazni red 
            foreach (var item in izvjestajMilijunasa)
            {
                Console.WriteLine($"{item.ImePrezime} je u {item.Banka}");
            }

            #endregion




        }
    }
}
