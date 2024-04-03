using System;
namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        //Dizi Tanımlama

        string[] renkler = new string[5];
        string[] hayvanlar = {"Kedi","Köpek","Aslan","Yılan"};
        int[] dizi;
        dizi = new int[5];

        //Dizilere değere atama ve erişim
        renkler[0]= "Sarı";
        dizi[4] = 23;
        Console.WriteLine(hayvanlar[0]);
        Console.WriteLine(renkler[0]);
        Console.WriteLine(dizi[3]);

        //Döngüler dizi kullanımı
        // Klavyeden girilen n tane sayının ortalamasını hesaplayan program

        Console.Write("Lütfen dizi uzunluğunu giriniz:");
        int diziuzunlugu = int.Parse(Console.ReadLine());
        int[] sayidizisi = new int[diziuzunlugu];
        for (int i = 0; i < diziuzunlugu; i++)
        {
            Console.Write("Lütfen {0}.Sayıyı giriniz:", i+1);
            sayidizisi[i] = int.Parse(Console.ReadLine());

        }

        int toplam=0;
        foreach (var sayi in sayidizisi)
        {
            toplam+=sayi;
        }
        Console.WriteLine("Sayıların toplamı:" + toplam);
        Console.WriteLine("Sayıların ortalaması:" + toplam/diziuzunlugu);

    }
}
