using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Komis.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Samochody.Any())
            {
                context.AddRange(
                new Samochod { Marka = "Ford", Model = "Mustang", RokProdukcji = 2016, Przebieg = "34 000 km", Pojemnosc = "4 900 cm3", RodzajPaliwa = "benzyna", Moc = "421 KM", Opis = "Mam do sprzedania samochod Ford Mustang", Cena = 160000M, ZdjecieURL = "/images/Mustang.jpg", MiniaturkaURL = "../Images/fordMustangMini.jpg", JestSamochodemTygodnia = true, JestWCentrali = true},
                new Samochod { Marka = "Audi", Model = "S5", RokProdukcji = 2013, Przebieg = "112 000 km", Pojemnosc = "3 000 cm3", RodzajPaliwa = "benzyna", Moc = "280 KM", Opis = "Mam do sprzedania samochod Audi S5", Cena = 115000M, ZdjecieURL = "/images/S5.jpg", MiniaturkaURL = "../Images/audiS5Mini.jpg", JestSamochodemTygodnia = true, JestWCentrali = true},
                new Samochod { Marka = "BMW", Model = "X4", RokProdukcji = 2017, Przebieg = "4 300 km", Pojemnosc = "1 995 cm3", RodzajPaliwa = "benzyna", Moc = "190 KM", Opis = "Mam do sprzedania samochod BMW X4", Cena = 194000M, ZdjecieURL = "/images/X4.jpg", MiniaturkaURL = "../Images/bmwX4mini.jpg", JestSamochodemTygodnia = true, JestWCentrali = true},
                new Samochod { Marka = "Chevrolet", Model = "Corvette", RokProdukcji = 1972, Przebieg = "28 000 km", Pojemnosc = "5 700 cm3", RodzajPaliwa = "benzyna", Moc = "300 KM", Opis = "Mam do sprzedania samochod Chevrolet Corvette", Cena = 90000M, ZdjecieURL = "/images/Corvette.jpg", MiniaturkaURL = "../Images/chevroletCorvetteMini.jpg", JestSamochodemTygodnia = true, JestWCentrali = true},
                new Samochod { Marka = "Nissan", Model = "Skyline", RokProdukcji = 1995, Przebieg = "144 000 km", Pojemnosc = "2 500 cm3", RodzajPaliwa = "benzyna", Moc = "410 KM", Opis = "Mam do sprzedania samochod Nissan Skyline", Cena = 120000M, ZdjecieURL = "/images/Skyline.jpg", MiniaturkaURL = "../Images/nissanSkylineMini.jpg", JestSamochodemTygodnia = true, JestWCentrali = true},
                new Samochod { Marka = "Jaguar", Model = "ZX", RokProdukcji = 2006, Przebieg = "78 000 km", Pojemnosc = "5 000 cm3", RodzajPaliwa = "benzyna", Moc = "510 KM", Opis = "Mam do sprzedania samochod Jaguar ZX", Cena = 169000M, ZdjecieURL = "/images/ZX.jpg", MiniaturkaURL = "../Images/jaguarZXMini.jpg", JestSamochodemTygodnia = true, JestWCentrali = false}
                    );
            }
            context.SaveChanges();
        }
    }
}
