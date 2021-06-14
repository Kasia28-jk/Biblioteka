using Biblioteka_WebApplication.Models;
using Biblioteka_WebApplication.Models.DBModels;
using System;
using System.Linq;

namespace Biblioteka_WebApplication.Data
{
    public class DbInitializer
    {
        public static void Initialize(BibliotekaContext context)
        {
            context.Database.EnsureCreated();

            // Look for any uzytkownicy
            if (context.Uzytkownik.Any())
            {
                return;   // DB has been seeded
            }

            var uzytkowniks = new Uzytkownik[]
            {
            new Uzytkownik{Status="Bibliotekarz", Login ="Katarzyna", Hasło = "zzz"},
            new Uzytkownik{Status="Bibliotekarz", Login ="Edyta", Hasło = "zzz"},
            new Uzytkownik{Status="Czytelnik", Login ="User1", Hasło = "zzz"},
            new Uzytkownik{Status="Czytelnik", Login ="User2", Hasło = "zzz"},
            new Uzytkownik{Status="Czytelnik", Login ="User3", Hasło = "zzz"}
            };
            foreach (Uzytkownik u in uzytkowniks)
            {
                context.Uzytkownik.Add(u);
            }
            context.SaveChanges();

            var ksiazkis = new Ksiazka[]
            {
                new Ksiazka{ Tytul="Pamiętnik",Imie="Nicholas",Nazwisko="Sparks",LiczbaStron=350,Ebook=true},
                new Ksiazka{ Tytul="List w butelce",Imie="Nicholas",Nazwisko="Sparks",LiczbaStron=290,Ebook=true},
                new Ksiazka{ Tytul="Tango",Imie="Sławomir",Nazwisko="Mrożek",LiczbaStron=350,Ebook=false},
                new Ksiazka{ Tytul="Mistrz i Małgorzata",Imie="Michał",Nazwisko="Bułhakow",LiczbaStron=350,Ebook=false},
                new Ksiazka{ Tytul="Mały Książę",Imie="Antoine",Nazwisko="de Saint-Exupéry",LiczbaStron=80,Ebook=true},
                new Ksiazka{ Tytul="Pamiętam cię",Imie="Yrsa",Nazwisko="Sigurdardóttir",LiczbaStron=350,Ebook=true},
                new Ksiazka{ Tytul="Harry potter i kamień filozoficzny",Imie="J.K.",Nazwisko="Rowling",LiczbaStron=600,Ebook=true}
            };
            foreach (Ksiazka k in ksiazkis)
            {
                context.Ksiazki.Add(k);
            }
            context.SaveChanges();

           var gatunki = new Gatunek[]
           {
                new Gatunek{Nazwa="Horror"},
                new Gatunek{Nazwa="Dramat"},
                new Gatunek{Nazwa="Romans"},
                new Gatunek{Nazwa="Fantastyka"},
                new Gatunek{Nazwa="Literatura obyczajowa"},
                new Gatunek{Nazwa="Biografia"},
                new Gatunek{Nazwa="Historyczna"},
                new Gatunek{Nazwa="Wiersze"},
                new Gatunek{Nazwa="Satyra"}
           };
            foreach (Gatunek g in gatunki)
            {
                context.Gatuneki.Add(g);
            }
            context.SaveChanges();

            var wypozyczenia = new Wypozyczenie[]
           {
                new Wypozyczenie {DataWypozyczenia=DateTime.Parse("2020-09-01"),DataOddania = DateTime.Parse("2020-10-10"), KsiazkaID=1, UzytkownikID=3},
                new Wypozyczenie {DataWypozyczenia=DateTime.Parse("2020-09-02"),DataOddania = DateTime.Parse("2020-10-28"),KsiazkaID=3, UzytkownikID=1},
                new Wypozyczenie {DataWypozyczenia=DateTime.Parse("2020-09-02"),DataOddania = DateTime.Parse("2020-11-03"),KsiazkaID=4, UzytkownikID=4},
                new Wypozyczenie {DataWypozyczenia=DateTime.Parse("2020-09-02"),DataOddania = DateTime.Parse("2020-11-10"),KsiazkaID=6, UzytkownikID=4},
                new Wypozyczenie {DataWypozyczenia=DateTime.Parse("2020-09-02"),DataOddania = DateTime.Parse("2020-11-10"),KsiazkaID=5, UzytkownikID=1},
           };
            foreach (Wypozyczenie w in wypozyczenia)
            {
                context.Wypozyczenia.Add(w);
            }
            context.SaveChanges();
            /*
            var relacja = new RelacjaKG[]
             {
                new RelacjaKG {KsiazkaID=1, GatunekID=3},
                new RelacjaKG {KsiazkaID=2, GatunekID=3},
                new RelacjaKG {KsiazkaID=2, GatunekID=2},
                new RelacjaKG {KsiazkaID=3, GatunekID=2},
                new RelacjaKG {KsiazkaID=4, GatunekID=9},
                new RelacjaKG {KsiazkaID=5, GatunekID=5},
                new RelacjaKG {KsiazkaID=5, GatunekID=4},
                new RelacjaKG {KsiazkaID=6, GatunekID=1},
                new RelacjaKG {KsiazkaID=7, GatunekID=4}
             };

            foreach (RelacjaKG r in relacja)
            {
                context.RelacjaKG.Add(r);
            }
            context.SaveChanges();*/
        }
    }
}
