using System;
using System.Collections;

namespace Telefon_Rehber_Uygulaması;
public class Rehber
{
    List<kisi> kisiler = new List<kisi>();
    public Rehber()
    {
        kisiler.Add(new kisi("Ömer","Yerkazan","12345"));
        kisiler.Add(new kisi("Ali", "Kaya", "67"));
        kisiler.Add(new kisi("Ahmet", "Çetinç","3242"));
        kisiler.Add(new kisi("Veli","Kavak","214325"));
        kisiler.Add(new kisi("Can","At","123245"));
    }

    public void NoKayit()
    {
        Console.WriteLine("**** Yeni Numara Kaydı ****");
        string ad = "";
        string soyad = "";
        string telno = "";
        
        bool adeger = false;
        bool soyadeger = false;
        bool telnodeger = false;
        while (!adeger || !soyadeger || !telnodeger) //degerlerin hepsi true olduğunda döngü sonlanır 
        {
            if(!adeger)
            {
                Console.Write("İsim Giriniz:");
                ad = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(ad)) //isimin dolu olup olmadığını kontrol eder
                {
                    System.Console.WriteLine("İSİM BOŞ BIRAKILAMAZ !!!!!!");
                }
                else
                    adeger = true; // ad dolmuş olur.
            }
            else if (!soyadeger)
            {
                Console.Write("Soyadı Giriniz:");
                soyad = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(soyad))
                {
                    System.Console.WriteLine("SOYİSİM BOL BIRAKILAMAZ !!!!!!");
                }
                else
                    soyadeger = true;
            }
            else if(!telnodeger)
            {
                Console.Write("Telefon Numarasını Giriniz:");
                telno= Console.ReadLine().Trim();
                if(long.TryParse(telno, out long cno) == false)
                {
                    System.Console.WriteLine("GEÇERSİZ TELEFON NUMARASI !!!!!!");
                }
                else
                    telnodeger =true ;
            }
            kisiler.Add(new kisi(ad,soyad,telno));
            System.Console.WriteLine("Kişi Ekleme İşlemi Başarılı");
        }
        
    }

    public void NoSilme()
    {
        string ad = "";
        string soyad = "";
        bool adeger = false;
        bool soyadeger = false;
        while(!adeger || soyadeger)
        {
            if (!adeger)
            {
                Console.Write("Numarasını silmek istediğiniz kişinin adını giriniz:");
                ad = Console.ReadLine().Trim();
                if(string.IsNullOrEmpty(ad))
                {
                    System.Console.WriteLine("İSİM BOŞ BIRAKILAMAZ !!!!!!");
                }
                else
                    adeger = true;
            }
            else if (!soyadeger)
            {
                Console.Write("Numarasını silmek istediğiniz kişinin soyadını giriniz:");
                soyad = Console.ReadLine().Trim();
                if(string.IsNullOrEmpty(ad))
                {
                    System.Console.WriteLine("SOYİSİM BOŞ BIRAKILAMAZ !!!!!!");
                }
                else
                    soyadeger = true;
            }

            var sonuc = kisiler.Find(x => x.Ad == ad && x.Soyad == soyad);
            if (sonuc != null)
            {
                kisiler.Remove(sonuc);
                System.Console.WriteLine("Kişi Listeden Silindi!!");
            }
            else
                System.Console.WriteLine("Kişi Bulunamadı");
        }
    }

    public void Listeleme()
    {
        Console.WriteLine("********* Rehberi Listele *********");
        List<kisi> listeleme = kisiler.OrderBy(x=>x.Ad).ToList();
        foreach (var item in listeleme)
        {
            System.Console.WriteLine("Ad        :" + item.Ad);
            System.Console.WriteLine("Soyad     :" + item.Soyad);
            System.Console.WriteLine("Tel No    :" + item.TelNo);
        }   
    }

    public void Arama()
    {
        Console.WriteLine("İsim ve soyisme göre arama yapmak için '1', Telefon numarasına göre arama yapmak için '2' seçiniz :");
		string secim = Console.ReadLine();
        if(secim == "1")
        {
            System.Console.Write("İsim giriniz :");
            string ad = Console.ReadLine();
            System.Console.WriteLine("Soyisim giriniz :");
            string soyad = Console.ReadLine();
            var sonuc = kisiler.Find(x=> x.Ad == ad && x.Soyad == soyad);
            if (sonuc != null)
            {
                System.Console.WriteLine(sonuc.Ad +    " ");
                System.Console.WriteLine(sonuc.Soyad + " ");
                System.Console.WriteLine(sonuc.TelNo + " ");
            }
            else
                System.Console.WriteLine("Kişi Bulunamadı  !!!!");
        }

        else if (secim == "2")
        {
            Console.WriteLine("Telefon numarası giriniz:");
			string no = Console.ReadLine();

            var sonuc = kisiler.Find(x=> x.TelNo == no);
            if(sonuc !=null)
            {
                System.Console.WriteLine(sonuc.Ad);
                System.Console.WriteLine(sonuc.Soyad);
                System.Console.WriteLine(sonuc.TelNo);
            }
            else
                System.Console.WriteLine("Kişi Bulunamadı  !!!!");
        }
    }

    public void noGuncelleme()
    {
        string ad = "";
        string soyad = "";
        string telno = "";
        bool adeger = false;
        bool soyadeger = false;
        bool telnodeger = false;
        while (!adeger || !soyadeger || !telnodeger)
        {
            if(!adeger)
            {
                System.Console.WriteLine("Güncelleme yapmak istediğiniz kişinin adını giriniz :");
                ad = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(ad))
                {
                    System.Console.WriteLine("İsim boş bırakılamaz");
                }
                else
                    adeger = true;
            }
            else if (!soyadeger)
            {
                Console.Write("Soyadı Giriniz:");
                soyad = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(soyad))
                {
                    System.Console.WriteLine("SOYİSİM BOL BIRAKILAMAZ !!!!!!");
                }
                else
                    soyadeger = true;
            }
            else if(!telnodeger)
            {
                Console.Write("10 Haneli Telefon Numarasını Giriniz:");
                telno= Console.ReadLine().Trim();
                var sonuc = kisiler.Find(x=> x.TelNo == telno);
                if (string.IsNullOrEmpty(telno))
                {
                    Console.WriteLine("Telefon numarası boş geçilemez");
                }
                else if(telno.Length == 10)
                {
                    if (long.TryParse(telno, out long cno) == false)
                    {
                        System.Console.WriteLine("Geçersiz telno");
                    }
                }
                else if (sonuc != null)
                {
                    System.Console.WriteLine("Kişi Bulundu");
                    System.Console.Write("Yeni telefon numarasını giriniz:");
                    string yenino= Console.ReadLine();
                    if(string.IsNullOrEmpty(yenino))
                    {
                        System.Console.WriteLine("Numara boş geçilemez");
                    }
                    else if(yenino.Length == 10)
                    {
                        if (long.TryParse(telno, out long cno) == false)
                        {
                            System.Console.WriteLine("Geçersiz telefon numarası");   
                        }
                        else
                        {
                            var sonucc = kisiler.Find(x=> x.TelNo == telno);
                            sonucc.TelNo = yenino;
                            System.Console.WriteLine("Güncelleme Başarılı");
                            telnodeger = true;
                        }
                    }
                    else
                        System.Console.WriteLine("Geçersiz TelNo");
                    
                }
                else
                {
                    System.Console.WriteLine("Kişi bulunamadı, Lütfen bir seçim daha yapınız");
                    Console.WriteLine("Güncellenemyi sonlandırmak için :'1'\n Yeniden denemek için:'2'");
						string secim = Console.ReadLine();
						if (secim == "1")
						{
							break;
						}
						else if (secim != "2")
						{
							Console.WriteLine("Hatalı giriş yaptınız");
						}
                }
            }
        }
    }
}