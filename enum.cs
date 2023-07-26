namespace enums;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Gunler.Pazar);
        Console.WriteLine((int)Gunler.Perşembe);

        int sıcaklık =32;
        if(sıcaklık<=(int)havaDurumu.Normal)
            System.Console.WriteLine("Dışarı çıkmak için havanın biraz daha ısınmasını bekleyelim");
        else if(sıcaklık>=(int)havaDurumu.Sıcak)
            System.Console.WriteLine("Dışarı çıkmak için çok sıcak bir gün");
        else if(sıcaklık>=(int)havaDurumu.Normal && sıcaklık<(int)havaDurumu.Coksıcak)
            System.Console.WriteLine("Hadi dışarıya çıkalım!");
    }
}
enum Gunler
{
    Pazartesi,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma,
    Cumartesi,
    Pazar
}
enum havaDurumu
{
    Soguk =5,
    Normal = 20,
    Sıcak = 25,
    Coksıcak = 30
}
