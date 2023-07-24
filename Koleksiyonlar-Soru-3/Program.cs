using System.Collections;
namespace Koleksiyonlar_Soru_3;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Bir kelime giriniz");
        string cumle = Console.ReadLine().ToLower();
        ArrayList list = new ArrayList();
        foreach (char harfler in cumle)
        {
            if (sesli(harfler))
            {
                if (!list.Contains(harfler))
                {
                    list.Add(harfler);
                }
            }
        }
        list.Sort();
        System.Console.WriteLine("Cümledeki sesli harfler");
        foreach (char s in list )
        {
            System.Console.Write(s+" ");
        }
    }

    static bool sesli(char harfler)
    {
        return "aeiöoüu".Contains(harfler);
    }
}
