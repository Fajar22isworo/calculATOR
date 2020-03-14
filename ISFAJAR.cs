using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_dinamis

{
    class Program
    {
            static void Main(string[] args)
            {
                Console.Title = "Aplikasi kalkulator dinamis";
                Console.WriteLine();
                Console.WriteLine("|    DAFTAR UTAMA   |");
                Console.WriteLine("|1=>Penjumlahan     |");
                Console.WriteLine("|2=>Pengurangan     |");
                Console.WriteLine("|3=>Perkalian       |");
                Console.WriteLine("|4=>Pembagian       |");
                Console.WriteLine("MASUKAN MENU ANDA [1,2,3,4] : ");
                int J = int.Parse(Console.ReadLine());
                if (J == 1)
                {
                    Console.WriteLine("Inputkan Nilai Pertama : ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inputkan Nilai Kedua : ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("\nHasil Penambahan " + a + " + " + b + " = " + penambahan(a, b));
                    Console.WriteLine();
                    Console.WriteLine("TEKAN KEY UNTUK KELUAR");
                    Console.ReadKey();
                }
                else if (J == 2)
                {
                    Console.WriteLine("Inputkan Nilai Pertama : ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inputkan Nilai Kedua : ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + pengurangan(a, b));
                    Console.WriteLine();
                    Console.WriteLine("TEKAN KEY UNTUK KELUAR");
                    Console.ReadKey();
                }
                else if (J == 3)
                {
                    Console.WriteLine("Inputkan Nilai Pertama : ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inputkan Nilai Kedua : ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Hasil Perkalian " + a + " * " + b + " = " + perkalian(a, b));
                    Console.WriteLine();
                    Console.WriteLine("TEKAN KEY UNTUK KELUAR");
                    Console.ReadKey();
                }
                else if (J == 4)
                {
                    Console.WriteLine("Inputkan Nilai Pertama : ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inputkan Nilai Kedua : ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Hasil Pembagian " + a + " / " + b + " = " + pembagian(a, b));
                    Console.WriteLine();
                    Console.WriteLine("TEKAN KEY UNTUK KELUAR");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("MAAF,INPUTAN ANDA SALAH");
                    Console.WriteLine();
                    Console.WriteLine("\nTEKAN KEY UNTUK KELUAR");
                    Console.ReadKey();

                }
                int penambahan(int a, int b)
                {
                    return a + b;
                }
                int pengurangan(int a, int b)
                {
                    return a - b;
                }
                int perkalian(int a, int b)
                {
                    return a * b;
                }
                int pembagian(int a, int b)
                {
                    return a / b;
                }
            }
       
    }

}