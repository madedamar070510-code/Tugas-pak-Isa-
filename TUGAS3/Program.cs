using System;
namespace tugas
{ 
class BangunTidur
{
    static void Main(string[] args)
    {
        Console.WriteLine("mulai");
        Console.WriteLine("alarm berbunyi");
        Console.WriteLine("matikan alarm");
        Console.WriteLine("bangun dari tempat tidur");
        Console.WriteLine("rapikan tempat tidur");
        Console.WriteLine("selesai");
        Mandi.Show(args);

        }
}
class Mandi
{
        public static void Show(string[] args)
        {
        Console.WriteLine("mulai");
        Console.WriteLine("Siapkan perlengkapan mandi");
        Console.WriteLine("Masuk ke kamar mandi");
        Console.WriteLine("mandi menggunakan sabun dan shampoo");
        Console.WriteLine("bilas dengan air");
        Console.WriteLine("keringkan badan");
        Console.WriteLine("selesai");
        Sarapan.Show(args);

        }
    }
class Sarapan
{
        public static void Show(string[] args)
        { 
        Console.WriteLine("mulai");
        Console.WriteLine("Siapkan makanan");
        Console.WriteLine("duduk di meja makan");
        Console.WriteLine("Makan hingga selesai");
        Console.WriteLine("rapikan peralatan makanan");
        Console.WriteLine("selesai");
            BerangkatSekolah.Show(args);

        }
    }
class BerangkatSekolah
{
        public static void Show(string[] args)
        {
        Console.WriteLine("mulai");
        Console.WriteLine("memakai seragam");
        Console.WriteLine("menyiapkan tas sekolah");
        Console.WriteLine("berpamitan kepada orang tua");
        Console.WriteLine("berangkat ke sekolah");
        Console.WriteLine("selesai");
            Belajarmalam.Show(args);
    }
}
class Belajarmalam
{
        public static void Show(string[] args)
        {
        Console.WriteLine("mulai");
        Console.WriteLine("siapkan buku pelajaran");
        Console.WriteLine("membaca materi");
        Console.WriteLine("mengerjakan tugas");
        Console.WriteLine("menyimpan buku");
        Console.WriteLine("selesai");
    }
}
}