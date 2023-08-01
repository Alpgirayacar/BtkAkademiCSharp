// See https://aka.ms/new-console-template for more information
using AttributeTemel;

Console.WriteLine("Hello, World!");
UrunEntity urn = new UrunEntity();
urn.UrunAdi = "Pentium CPU";
urn.Fiyat = 9000;
urn.SonSatisTarihi = DateTime.Now.AddDays(30);
urn.Insert();