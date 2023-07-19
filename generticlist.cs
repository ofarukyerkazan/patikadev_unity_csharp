using System;
using System.Collections.Generic;
namespace generticlist;
class Program
{
    static void Main(string[] args)
    {
        //List<T> class 
        //System.Collections.Generic
        //T-> object türündendir.
        List<int> sayiListesi = new List<int>();
        sayiListesi.Add(23);
        sayiListesi.Add(34);
        sayiListesi.Add(26);
        sayiListesi.Add(6);
        sayiListesi.Add(92);
        
        List<string> renkler = new List<string>();
        renkler.Add("Sarı");
        renkler.Add("Kırmızı");
        renkler.Add("Bord");
        renkler.Add("Beyaz");
        renkler.Add("Mavi");

        //Count
        System.Console.WriteLine("Sayı adedi: "+sayiListesi.Count);
        System.Console.WriteLine("Renklerin adedi: "+renkler.Count);

        //Foreach ve List.Foreach ile elemanlara erişim
        System.Console.WriteLine("******Sayılar******");
        foreach (var sliste in sayiListesi)
            System.Console.WriteLine(sliste);

        

        System.Console.WriteLine("******Renkler******");
        foreach (var rliste in renkler)
            System.Console.WriteLine(rliste);
        
        sayiListesi.ForEach(sliste=> Console.WriteLine(sliste)); //tek satırda foreach kullanımı
        renkler.ForEach(rliste=> Console.WriteLine(rliste));

        //Listeden eleman çıkarma --> Remove
        sayiListesi.Remove(92);
        renkler.Remove("Mavi");
        sayiListesi.RemoveAt(0);
        renkler.RemoveAt(0); // 0.indeksdeki elemanı çıkarır.

        //Liste içerisinde arama --> Contanins
        if (sayiListesi.Contains(26))
        {
            System.Console.WriteLine("26 liste içinde bulundu");
        }

        //Eleman ile index'e erişim
        System.Console.WriteLine(renkler.BinarySearch("Bordo"));

        //Diziyi List'e çevirme
        string[] hayvanlar= {"Kedi","Köpek","Kuş"};
        List<string> hayvanListesi = new List<string>(hayvanlar);

        //Listeyi nasıl temizlerim
        hayvanListesi.Clear();

        //List içerisinde nesne tutmak
        List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

        Kullanıcılar kullanici1 = new Kullanıcılar();
        kullanici1.Isim="Ömer";
        kullanici1.Soyisim="Yerkazan";
        kullanici1.Yas=23;

        Kullanıcılar kullanici2 = new Kullanıcılar();
        kullanici2.Isim="Ali";
        kullanici2.Soyisim="Veli";
        kullanici2.Yas=31;

        kullanıcıListesi.Add(kullanici1);
        kullanıcıListesi.Add(kullanici2);

        List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
        yeniListe.Add(new Kullanıcılar(){Isim="Deniz",Soyisim="Ada",Yas=22});

        foreach (Kullanıcılar kullanici in kullanıcıListesi)
        {
            System.Console.WriteLine("Kullanıcı Adı: " + kullanici.Isim);
            System.Console.WriteLine("Kullanıcı Soyisim: " + kullanici.Soyisim);
            System.Console.WriteLine("Kullanıcı Yaş: " + kullanici.Yas);
        }
        yeniListe.Clear();
    }
}

public class Kullanıcılar
{
    private string isim;
    private string soyisim;
    private int yas;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }
}
