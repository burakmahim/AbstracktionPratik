using System;

// Soyut Calisan Sınıfı
abstract class Calisan
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Departman { get; set; }

    // Her çalışan için görev metodunu tanımlıyoruz
    public abstract void Gorev();
}

// Yazılım Geliştirici Sınıfı (Calisan sınıfından miras alır)
class YazilimGelistirici : Calisan
{
    public override void Gorev()
    {
        Console.WriteLine("Yazılım geliştirici olarak çalışıyorum.");
    }
}

// Proje Yöneticisi Sınıfı (Calisan sınıfından miras alır)
class ProjeYoneticisi : Calisan
{
    public override void Gorev()
    {
        Console.WriteLine("Proje yöneticisi olarak çalışıyorum.");
    }
}

// Satış Temsilcisi Sınıfı (Calisan sınıfından miras alır)
class SatisTemsilcisi : Calisan
{
    public override void Gorev()
    {
        Console.WriteLine("Satış temsilcisi olarak çalışıyorum.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Yazılım Geliştirici nesnesi oluşturma ve görev metodu çağırma
        Calisan yazilimci = new YazilimGelistirici()
        {
            Ad = "Ahmet",
            Soyad = "Demir",
            Departman = "Yazılım"
        };
        Console.WriteLine($"{yazilimci.Ad} {yazilimci.Soyad} şirketin {yazilimci.Departman} departmanında çalışıyor.");
        yazilimci.Gorev();

        // Proje Yöneticisi nesnesi oluşturma ve görev metodu çağırma
        Calisan projeYoneticisi = new ProjeYoneticisi()
        {
            Ad = "Hasan",
            Soyad = "Çıldırmış",
            Departman = "Proje Yönetimi"
        };
        Console.WriteLine($"{projeYoneticisi.Ad} {projeYoneticisi.Soyad} şirketin {projeYoneticisi.Departman} departmanında çalışıyor.");
        projeYoneticisi.Gorev();

        // Satış Temsilcisi nesnesi oluşturma ve görev metodu çağırma
        Calisan satisTemsilcisi = new SatisTemsilcisi()
        {
            Ad = "Selin",
            Soyad = "Özgür",
            Departman = "Satış"
        };
        Console.WriteLine($"{satisTemsilcisi.Ad} {satisTemsilcisi.Soyad} şirketin {satisTemsilcisi.Departman} departmanında çalışıyor.");
        satisTemsilcisi.Gorev();
    }
}
