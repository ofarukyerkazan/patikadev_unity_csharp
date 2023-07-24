using System.Collections;
namespace Koleksiyonlar_Soru_2;
class Program
{
    static void Main(string[] args)
    {
        ArrayList sayilar = new ArrayList();
        System.Console.WriteLine("Lütfen 20 tane sayı giriniz:");
        for (int i = 0; i < 20; i++)
        {
            System.Console.WriteLine("{0}.sayıyı giriniz:",i+1);
            int sayi = int.Parse(Console.ReadLine());
            sayilar.Add(sayi);
        }
        
        sayilar.Sort();
        System.Console.WriteLine("arrayın sıralaması");
        foreach (var item in sayilar)
            System.Console.WriteLine(item);

        System.Console.WriteLine("en küçükler");
        ArrayList enkucukler = new ArrayList(sayilar.GetRange(0,3));
        foreach (var item in enkucukler)
            System.Console.WriteLine(item);
        System.Console.WriteLine("en büyükler");
        ArrayList enbuyukler = new ArrayList(sayilar.GetRange(sayilar.Count-3,3));
        foreach (var item in enbuyukler)
            System.Console.WriteLine(item);

        double enkortalama = ort(enkucukler);
        double enbortalama = ort(enbuyukler);
        double ortoplam = enbortalama+enkortalama;
        System.Console.WriteLine("En küçüklerin ortalaması:"+enkortalama);
        System.Console.WriteLine("En büyüklerim ortalaması:"+enbortalama);
        System.Console.WriteLine("Ortalamaların toplamı:"+ortoplam);
        
        
        

    }
    static double ort(ArrayList lst)
    {
        int toplm =0;
        foreach (int s in lst)
        {
            toplm+=toplm;
        }
        return (double)toplm/lst.Count;
    } 
}
