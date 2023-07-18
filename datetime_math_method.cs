
namespace datetime_math_method;
class Program
{
    static void Main(string[] args)
    {
        //DateTime Library
        System.Console.WriteLine(DateTime.Now); //şuanki tarihi ve saati verir.
        System.Console.WriteLine(DateTime.Now.Date); // sadece tarihi verir.
        System.Console.WriteLine(DateTime.Now.Day); // sadece günü verir
        System.Console.WriteLine(DateTime.Now.Month); // sadece ayı verir
        System.Console.WriteLine(DateTime.Now.Year); // sadece yılı verir
        System.Console.WriteLine(DateTime.Now.Hour); // sadece saati verir
        System.Console.WriteLine(DateTime.Now.Minute); // sadece dakikayı verir
        System.Console.WriteLine(DateTime.Now.Second); //sadece anlık saniyeyi verir

        System.Console.WriteLine(DateTime.Now.DayOfWeek); // bulunduğu günü verir
        System.Console.WriteLine(DateTime.Now.DayOfYear); // 365 günde kaçıncı günde olduğun gösterir

        System.Console.WriteLine(DateTime.Now.ToLongDateString()); // tarihi string olarak verir (ay ve günü)
        System.Console.WriteLine(DateTime.Now.ToShortDateString()); // sayısal olarak tarihi verir
        System.Console.WriteLine(DateTime.Now.ToLongTimeString()); // saati verir saniye dahil
        System.Console.WriteLine(DateTime.Now.ToShortTimeString()); // saati verir ama saniyeyi göstermez

        System.Console.WriteLine(DateTime.Now.AddDays(2)); // şuanki tarihe 2 gün ekler 
        System.Console.WriteLine(DateTime.Now.AddHours(3)); // anlık saate girilen değer kadar (3) ekleme yapar 
        System.Console.WriteLine(DateTime.Now.AddSeconds(5)); // program çalıştığı saniyeye girilen değer (5) kadar ekleme yapar 
        System.Console.WriteLine(DateTime.Now.AddMonths(2)); // bulunan aya ekleme yapar
        System.Console.WriteLine(DateTime.Now.AddYears(2)); // bulunan yıla ekleme yapar
        System.Console.WriteLine(DateTime.Now.AddMilliseconds(40)); // milisaniyeye ekleme yapar


        System.Console.WriteLine(DateTime.Now.ToString("dd")); // günü sayısal olarak verir
        System.Console.WriteLine(DateTime.Now.ToString("ddd")); // günün ilk 3 harfini alır
        System.Console.WriteLine(DateTime.Now.ToString("dddd")); // günün tamamını yazar

        System.Console.WriteLine(DateTime.Now.ToString("MM")); // ayı sayısal olarak verir
        System.Console.WriteLine(DateTime.Now.ToString("MMM")); // ayın ilk 3 harfini verir
        System.Console.WriteLine(DateTime.Now.ToString("MMMMM")); // ayın tamamını string olarak yazdırır.

        System.Console.WriteLine(DateTime.Now.ToString("yy"));
        System.Console.WriteLine(DateTime.Now.ToString("yyyy"));

        //Math Library 
        System.Console.WriteLine(Math.Abs(-25)); // mutlak değer
        System.Console.WriteLine(Math.Sin(10));
        System.Console.WriteLine(Math.Cos(10));
        System.Console.WriteLine(Math.Tan(10));
        System.Console.WriteLine(Math.Ceiling(23.1)); //ondalıklı sayıyı bir üst tam sayıya çevirir
        System.Console.WriteLine(Math.Round(22.3)); // ondalıklı sayıyı ondalığına göre tam sayıya çevirir
        System.Console.WriteLine(Math.Round(22.7));

        System.Console.WriteLine(Math.Max(2,6)); // hangi sayı yüksek ise onu yazdırır
        System.Console.WriteLine(Math.Min(2,6)); // hangi sayı düşük ise onu yazdırır

        System.Console.WriteLine(Math.Pow(3,4)); //3^4 = 81 üstünü alır
        System.Console.WriteLine(Math.Sqrt(16)); //girilen değerin karekökünü alır 
        System.Console.WriteLine(Math.Log(9)); // log e 
        System.Console.WriteLine(Math.Exp(9)); // e^3
        System.Console.WriteLine(Math.Log10(100)); 
    }
}
