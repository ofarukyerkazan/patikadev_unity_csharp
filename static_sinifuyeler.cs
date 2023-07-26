namespace static_sinifuyeler;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Çalışan Sayısı   :{0}",Calisan.CalisanSayisi);

        Calisan calisan = new Calisan("Ömer","Faruk","IK");
        Console.WriteLine("Çalışan Sayısı   :{0}",Calisan.CalisanSayisi);

        System.Console.WriteLine("Toplam    :{0}", Islemler.Topla(10,13));
        System.Console.WriteLine("Cıkartma  :{0}",Islemler.Cikar(33,10));
    }
}

class Calisan
{
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi; }

    private string ad;
    private string soyad;
    private string departman;

    static Calisan()
    {
        calisanSayisi =0;
    }

    public Calisan(string ad, string soyad, string departman)
    {
        this.ad = ad;
        this.soyad = soyad;
        this.departman = departman;
        calisanSayisi++;
    }

    
}
static class Islemler
    {
        public static long Topla(int s1,int s2)
        {
            return s1 + s2;
        }

        public static long Cikar(int s1,int s2)
        {
            return s1 - s2;
        }
    }
