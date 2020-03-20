using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasProgram1
{
    class Program
    {

        static void Main(string[] args)
        {
            int input;
            int x;
            int y;
            int z;
            int keluar = 1;

            home:
            Console.Clear();
            Console.WriteLine("Selamat Datang di Program Latihan Bareng Syamsu :)\n");

            Console.WriteLine("Silahkan Pilih Menu yang diinginkan:\n" +
                "1. Program Print Bilangan Ganjil dan Bilangan Genap\n" +
                "2. Program Membuat Segitiga Siku-Siku\n" +
                "3. Program Deret Bilangan Fibonacci\n" +
                "4. Exit\n\n"+
                "Jadi menu apa yang kamu inginkan?\n");
                
             input=Convert.ToInt32(Console.ReadLine());

          switch (input)
            { case 1:
                    Console.Clear();
                    Console.WriteLine("Anda memilih Program Print Bilangan Ganjil dan Bilangan Genap\n\n" +
                        "Masukkan batas bilangan yang diinginkan: ");
                    input = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nNilai yang kamu masukkan adalah {0}", input);

                    Console.WriteLine("\nBilangan Genap: ");
                    for (x=1; x<=input; x++)
                    {
                        if (x%2==0)
                        {
                            Console.Write(x + ",");
                        }
                    }

                    Console.WriteLine("\nBilangan Ganjil");
                    for (x = 1; x <= input; x++)
                    {
                        if (x % 2 != 0)
                        {
                            Console.Write(x + ",");
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("Tekan tombol apapun untuk mengulang Program");
                    Console.ReadLine();
                    goto home;

                    break;


                case 2:
                    Console.Clear();
                    Console.WriteLine("Anda memilih Program Membuat Segitiga Siku-Siku\n\n" +
                        "Masukkan panjang alas yang diinginkan: ");
                    input = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nNilai yang kamu masukkan adalah {0}", input);
                    for (x=0;x<=input;x++)
                    {
                        for(y=1;y<=x;y++)
                        {
                            Console.Write("#");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine("Tekan tombol apapun untuk mengulang Program");
                    Console.ReadLine();
                    goto home;


                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Anda memilih Program Deret Bilangan Fibonacci\n"+
                    "Masukkan batas bilangan yang diinginkan: ");
                    input = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nNilai yang kamu masukkan adalah {0}\n", input);
                    x = 0;
                    y = 1;
                    for (int i=0;i<input;i++)
                    {
                        z = x + y;
                        x = y;
                        y = z;
                        Console.Write(z + ",");

                    }
                    Console.WriteLine();
                    Console.WriteLine("Tekan tombol apapun untuk mengulang Program");
                    Console.ReadLine();
                    goto home;

                    break;
                case 4:
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Input yang kamu masukkan salah, silahkan coba lagi");
                    Console.ReadLine();
                    goto home;
                    break;
            }
           

        }
    }
}
