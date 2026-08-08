uusing System;

class Program
{
    static void Main(string[] args)
    {
        bool berjalan = true;

        while (berjalan)
        {
            Console.Clear();
            Console.WriteLine("=============================================");
            Console.WriteLine("       PROGRAM ALGORITMA KEGIATAN SEHARI-HARI ");
            Console.WriteLine("=============================================");
            Console.WriteLine("1. Algoritma 1: Bangun Tidur");
            Console.WriteLine("2. Algoritma 2: Mandi");
            Console.WriteLine("3. Algoritma 3: Sarapan");
            Console.WriteLine("4. Algoritma 4: Berangkat Sekolah");
            Console.WriteLine("5. Algoritma 5: Belajar Malam");
            Console.WriteLine("6. Jalankan Semua Algoritma (Urut)");
            Console.WriteLine("0. Keluar");
            Console.WriteLine("=============================================");
            Console.Write("Pilih menu (0-6): ");

            string pilihan = Console.ReadLine();
            Console.WriteLine();

            switch (pilihan)
            {
                case "1":
                    AlgoritmaBangunTidur();
                    TungguTekanEnter();
                    break;
                case "2":
                    AlgoritmaMandi();
                    TungguTekanEnter();
                    break;
                case "3":
                    AlgoritmaSarapan();
                    TungguTekanEnter();
                    break;
                case "4":
                    AlgoritmaBerangkatSekolah();
                    TungguTekanEnter();
                    break;
                case "5":
                    AlgoritmaBelajarMalam();
                    TungguTekanEnter();
                    break;
                case "6":
                    JalankanSemuaAlgoritma();
                    TungguTekanEnter();
                    break;
                case "0":
                    berjalan = false;
                    Console.WriteLine("Program selesai. Terima kasih!");
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid! Silakan coba lagi.");
                    TungguTekanEnter();
                    break;
            }
        }
    }

    // Algoritma 1: Bangun Tidur
    static void AlgoritmaBangunTidur()
    {
        Console.WriteLine("--- Algoritma 1: Bangun Tidur ---");
        Console.WriteLine("[+] Mulai");
        Console.WriteLine("1. Alarm berbunyi");
        Console.WriteLine("2. Matikan alarm");
        Console.WriteLine("3. Bangun dari tempat tidur");
        Console.WriteLine("4. Rapikan tempat tidur");
        Console.WriteLine("[+] Selesai");
    }

    // Algoritma 2: Mandi
    static void AlgoritmaMandi()
    {
        Console.WriteLine("--- Algoritma 2: Mandi ---");
        Console.WriteLine("[+] Mulai");
        Console.WriteLine("1. Siapkan perlengkapan mandi");
        Console.WriteLine("2. Masuk ke kamar mandi");
        Console.WriteLine("3. Mandi menggunakan sabun dan shampo");
        Console.WriteLine("4. Bilas dengan air");
        Console.WriteLine("5. Keringkan badan");
        Console.WriteLine("[+] Selesai");
    }

    // Algoritma 3: Sarapan
    static void AlgoritmaSarapan()
    {
        Console.WriteLine("--- Algoritma 3: Sarapan ---");
        Console.WriteLine("[+] Mulai");
        Console.WriteLine("1. Siapkan makanan");
        Console.WriteLine("2. Duduk di meja makan");
        Console.WriteLine("3. Makan hingga selesai");
        Console.WriteLine("4. Rapikan peralatan makan");
        Console.WriteLine("[+] Selesai");
    }

    // Algoritma 4: Berangkat Sekolah
    static void AlgoritmaBerangkatSekolah()
    {
        Console.WriteLine("--- Algoritma 4: Berangkat Sekolah ---");
        Console.WriteLine("[+] Mulai");
        Console.WriteLine("1. Memakai seragam");
        Console.WriteLine("2. Menyiapkan tas sekolah");
        Console.WriteLine("3. Berpamitan kepada orang tua");
        Console.WriteLine("4. Berangkat ke sekolah");
        Console.WriteLine("[+] Selesai");
    }

    // Algoritma 5: Belajar Malam
    static void AlgoritmaBelajarMalam()
    {
        Console.WriteLine("--- Algoritma 5: Belajar Malam ---");
        Console.WriteLine("[+] Mulai");
        Console.WriteLine("1. Siapkan buku pelajaran");
        Console.WriteLine("2. Membaca materi");
        Console.WriteLine("3. Mengerjakan tugas");
        Console.WriteLine("4. Menyimpan buku");
        Console.WriteLine("[+] Selesai");
    }

    // Menjalankan seluruh alur kegiatan dari pagi sampai malam
    static void JalankanSemuaAlgoritma()
    {
        Console.WriteLine("=== MENJALANKAN SELURUH ALUR KEGIATAN SEHARI-HARI ===\n");
        
        AlgoritmaBangunTidur();
        Console.WriteLine("\n      |\n      v\n");
        
        AlgoritmaMandi();
        Console.WriteLine("\n      |\n      v\n");
        
        AlgoritmaSarapan();
        Console.WriteLine("\n      |\n      v\n");
        
        AlgoritmaBerangkatSekolah();
        Console.WriteLine("\n      |\n      v\n");
        
        AlgoritmaBelajarMalam();
    }

    // Fungsi pembantu untuk menahan layar
    static void TungguTekanEnter()
    {
        Console.WriteLine("\nTekan Enter untuk melanjutkan...");
        Console.ReadLine();
    }
}   