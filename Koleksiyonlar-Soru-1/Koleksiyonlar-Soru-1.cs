using System;
using System.Collections;
namespace Koleksiyonlar_Soru_1;
class Program
{
    static void Main(string[] args)
    {
        ArrayList asal = new ArrayList();
        ArrayList asalolmayan = new ArrayList();
        System.Console.WriteLine("sayı giriniz");
        for (int i = 0; i < 4; i++)
        {
            int sayi = int.Parse(Console.ReadLine());
            if(asall(sayi))
            {
                asal.Add(sayi);
            }
            else
            {
                asalolmayan.Add(sayi);   
            }
        }
        System.Console.WriteLine("Asal olanlar");
        foreach (var s in asal)
        {
            System.Console.WriteLine(s);
        }

        System.Console.WriteLine("Asal olmayanlar");  
        foreach (var s in asalolmayan)
        {
            System.Console.WriteLine(s);
        }

        System.Console.WriteLine("Asal olanların sıralaması");
        asal.Sort();
        asal.Reverse();  
        foreach (var s in asal)
        {
            System.Console.WriteLine(s);
        }


        System.Console.WriteLine("Asal olmayanların sıralaması");
        asalolmayan.Sort();
        asalolmayan.Reverse();
        foreach (var s in asalolmayan)
        {
            System.Console.WriteLine(s);
        }

        System.Console.Write("Asalların adedi:"); 
        int count = asal.Count;
        System.Console.WriteLine(count);

        System.Console.Write("Asal olmayanların adedi:"); 
        int olmayancount = asalolmayan.Count;
        System.Console.WriteLine(olmayancount);

        int toplam = 0;
        for (int i = 0; i < asal.Count; i++)
        {
            toplam+= (int)asal[i];
        }
        System.Console.WriteLine("Asal sayıların toplamı:" +toplam);

        int otoplam=0;
        for (int i = 0; i < asalolmayan.Count; i++)
        {
            otoplam+=(int)asalolmayan[i];
        }
        System.Console.WriteLine("Asal olmayanların toplamı:" + otoplam);

        System.Console.WriteLine("Asal sayıların ortalaması" + toplam/count);
        System.Console.WriteLine("Asal olmayan sayıların ortalaması" + otoplam/olmayancount);
        
    }
    private static bool asall(int sayi)
    {
        if (sayi<2)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(sayi); i++)
        {
            if(sayi%i==0)
            {
                return false;
            }
        }
        return true;
    }
}
