using System;
using System.Collections;

namespace Telefon_Rehber_Uygulaması;
public class kisi
{
    private string ad,soyad,telno;

    public kisi(string ad, string soyad, string telno)
    {
        this.Ad = ad;
        this.soyad = soyad;
        this.telno = telno;
    }

    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string TelNo { get; set;}
}