namespace strmethod;
class Program
{
    static void Main(string[] args)
    {
        string degisken = "Dersimiz Csharp, Hoşgeldiniz!";
        string degisken2 = "Dersimiz Csharp, ";

        Console.WriteLine(degisken.Length); // degiskenin karakter sayısını verir
        Console.WriteLine(degisken.ToUpper()); // Tüm harfleri büyük yapar 
        Console.WriteLine(degisken.ToLower()); // Tüm harfleri küçük yapar 
        Console.WriteLine(string.Concat(degisken," Merhaba")); // degiskenin içine atana metnin sonuna girilen metin eklenir.
        
        //Compare, CompareTo
        Console.WriteLine(degisken.CompareTo(degisken2)); //degiskenin karakteri sayısı degisken2 den büyükse 1 yazar eşitse 0 küçükse -1
        Console.WriteLine(String.Compare(degisken,degisken2,true));
        Console.WriteLine(String.Compare(degisken,degisken2,false));

        //Contanis
        Console.WriteLine(degisken.Contains(degisken2));
        Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
        Console.WriteLine(degisken.StartsWith("Merhaba"));

        //Indexof
        Console.WriteLine(degisken.IndexOf("Cs"));
        System.Console.WriteLine(degisken.IndexOf("Ömer"));
        System.Console.WriteLine(degisken.LastIndexOf("i"));

        //Insert
        System.Console.WriteLine(degisken.Insert(0,"Merhaba! ")); //sıfırncı indeksten başlayarak yazdırır.

        //PadRight, PadLeft 
        Console.WriteLine(degisken + degisken2.PadLeft(30)); //padleft ile 30 tane boşluk degisken2'nin sol tarafına
        System.Console.WriteLine(degisken.PadRight(50,'_')+degisken2); //padright ile 30 tane boşluk degiskenin sağ tarafına

        //Remove
        System.Console.WriteLine(degisken.Remove(10)); //10 karakterden sonrasını kaldırır.

        //Replace
        System.Console.WriteLine(degisken.Replace("Csharp","C#")); //seçilen metin ile yeni metinin değişimi yapılır.

        //Split
        System.Console.WriteLine(degisken.Split(' ')[2]); 

        //Substring
        System.Console.WriteLine(degisken.Substring(4));
    }
}
