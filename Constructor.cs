using System;
namespace classC_;
class Program
{
    static void Main(string[] args)
    {
        /* 
        Söz Dizini
        class SinifAdi
        {
            [Erişim Belirleyici] [Veri Tipi] ÖzellikAd;
            [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi(Parametre Listesi)
            {
                Metot Komutları
            }
        }

        # Erişim Belirleyiciler
        Public - Genel erişim, sınıfın içindeki herhangi bir
        Private 
        Internal
        Protected
        */
        Calisan calisan1 = new Calisan("Ali","YILMAZ",23456789,"İnsan Kaynakları");
        calisan1.CalisaninBilgileri();
        System.Console.WriteLine("--------------------------------");

        Calisan calisan2 = new Calisan();
        calisan2.Ad="Veli";
        calisan2.Soyad ="KARAKOĞLU";
        calisan2.No=12345678;
        calisan2.Departman = "Muhasebe";
        calisan2.CalisaninBilgileri();
    }
    
    
}

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Calisan(string ad, string soyad, int no, string departman)
    {
        this.Ad= ad;
        this.Soyad = soyad;
        this.No=no;
        this.Departman = departman;
    }
    public Calisan(){}

    public void CalisaninBilgileri()
    {
        Console.WriteLine("Çalışanın Adı:{0}",Ad);
        Console.WriteLine("Çalışanın Soyadı:{0}",Soyad);
        Console.WriteLine("Çalışanın Numarası:{0}",No);
        Console.WriteLine("Çalışanın Departmanı:{0}",Departman);
    }
}
