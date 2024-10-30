using System;

public class BaseGeometrikSekil
{
    public double Genislik { get; set; }
    public double Yukseklik { get; set; }

    public virtual double AlanHesapla() // Base sınıfta genel AlanHesapla() metodu
    {
        return 0; // Diğer sınıflar tarafından ezileceği için default bir değer veriyoruz
    }
}

public class Kare : BaseGeometrikSekil
{
    public override double AlanHesapla()
    {
        return Genislik * Yukseklik;
    }
}

public class Dikdortgen : BaseGeometrikSekil
{
    public override double AlanHesapla()
    {
        return Genislik * Yukseklik;
    }
}

public class DikUcgen : BaseGeometrikSekil
{
    public override double AlanHesapla()
    {
        return (Genislik * Yukseklik) / 2;
    }
}

class Program
{
    static void Main()
    {
        // Kare Nesnesi
        Kare kare = new Kare { Genislik = 5, Yukseklik = 5 };
        Console.WriteLine("Kare Alanı: " + kare.AlanHesapla());

        // Dikdörtgen Nesnesi
        Dikdortgen dikdortgen = new Dikdortgen { Genislik = 4, Yukseklik = 6 };
        Console.WriteLine("Dikdörtgen Alanı: " + dikdortgen.AlanHesapla());

        // Dik Üçgen Nesnesi
        DikUcgen dikUcgen = new DikUcgen { Genislik = 3, Yukseklik = 4 };
        Console.WriteLine("Dik Üçgen Alanı: " + dikUcgen.AlanHesapla());
    }
}