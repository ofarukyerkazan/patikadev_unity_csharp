using System;
using System.Collections;

namespace arraylist;
class Program
{
    static void Main(string[] args)
    {
        // System.Collections namespace
        ArrayList liste = new ArrayList();
        liste.Add("Ömer");
        liste.Add(2);
        liste.Add(true);
        liste.Add('M');

        //içerisinde verilere erişim
        System.Console.WriteLine(liste[1]);
        foreach(var item in liste)
            System.Console.WriteLine(item);
        
        //AddRange
        System.Console.WriteLine("***** AddRange *****");
        string[] renkler = {"kırmızı","sarı","yeşil"};
        List<int> sayilar = new List<int>(){1,8,3,7,9,92,5};
        liste.AddRange(renkler);
        liste.AddRange(sayilar);

        foreach(var item in liste)
            System.Console.WriteLine(item);

        //Sort
        System.Console.WriteLine("***** Sort *******");
        liste.Sort();
    }
}
