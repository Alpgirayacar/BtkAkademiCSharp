// See https://aka.ms/new-console-template for more information

using AttributaBtkOrnek;

Ogrenci ogrenci = new Ogrenci();
ogrenci.Bolum = "İşletme";
ogrenci.Adi = "İbrahim";
ogrenci.Soyadi = "Gökyar";


if (!ZorunlulukKontrolu.Dogrula(ogrenci))
{
    Console.WriteLine("Öğrenci bilgileri doğrulamadan geçemedi!");
}
else
{
    Console.WriteLine("form başarılı");
}
