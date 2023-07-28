    namespace Telefon_Rehber_Uygulaması;
class Program
{
    public static void Menu()
    {
        Console.WriteLine("Lütfen Yapmak istediğiniz işlemi seçiniz!");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Yeni Numara Kaydetmek        (1)");
        Console.WriteLine("Varolan Numarayı Silmek      (2)");
        Console.WriteLine("Varolan Numarayı Güncelleme  (3)");
        Console.WriteLine("Rehberi Listelemek           (4)");
        Console.WriteLine("Rehberde Arama Yapmak        (5)");
    }
    static void Main(string[] args)
    {
        Rehber rehber = new Rehber();
        Menu();
        int giris;
        while ((!int.TryParse(Console.ReadLine(),out giris)) || giris<0 || giris>5 )
        {
            Menu();
        }
        switch (giris)
        {
            case 1:
                    rehber.NoKayit();
                    break;

            case 2:
                    rehber.NoSilme();
                    break;
            case 3:
                    rehber.noGuncelleme();
                    break;
            
            case 4:
                    rehber.Listeleme();
                    break;
            
            case 5:
                    rehber.Arama();
                    break;
            
            default:
					Console.WriteLine("Hatalı seçim yaptınız!");
					break;
        }
        Console.ReadKey();
    }
}
