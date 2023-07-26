namespace Encapsulation;
class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Isim = "Ömer Faruk";
        ogrenci.Soyisim= "YERKAZAN";
        ogrenci.Ogrencino=123456789;
        ogrenci.Sinif=3;
        ogrenci.OgrenciBilgileriGetir();

        ogrenci.SiniffAtlat();
        ogrenci.OgrenciBilgileriGetir();
    }
}

class Ogrenci
{
    private string isim;
    private string soyisim;
    private int ogrencino;
    private int sinif;

    public string Isim 
    { 
        get { return isim;} 
        set {isim = value;} 
    }

    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Sinif 
    { 
        get => sinif; 
        set 
        {
            if(value<1)
                System.Console.WriteLine("Sınıf En Az 1 Olabilir!");
            else
                sinif = value; 
        }
        
    }
    public int Ogrencino { get => ogrencino; set => ogrencino = value; }

    public Ogrenci(string ısim, string soyisim, int ogrencino, int sinif)
    {
        Isim = ısim;
        Soyisim = soyisim;
        Ogrencino = ogrencino;
        Sinif = sinif;
    }

    public Ogrenci(){}

    public void OgrenciBilgileriGetir()
    {
        System.Console.WriteLine("-------- Öğrenci Bilgileri --------");
        System.Console.WriteLine("Öğrenci Adı       :{0}",this.Isim);
        System.Console.WriteLine("Öğrenci Soyadı    :{0}",this.Soyisim);
        System.Console.WriteLine("Öğrenci No        :{0}",this.Ogrencino);
        System.Console.WriteLine("Ögrenci Sınıf     :{0}",this.Sinif);

    }
    public void SiniffAtlat()
    {
        this.Sinif = this.Sinif +1;
    }

    public void SinifDusur()
    {
        this.Sinif-=1; 
    }
}
