using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lotto
{
    class Program
    {

        static int[] het52 = new int[5];
        static int het;
        static int[,] hetek = new int[51, 5];
        static void Main(string[] args)
        {

            ElsoFeladat();
            Console.WriteLine();
            MasodikFeladat();
            Console.WriteLine();
            HarmadikFeladat();
            Console.WriteLine();
            NegyedikFeladat();
            Console.WriteLine();
            OtodikFeladat();
            Console.WriteLine();
            HatodikFeladat();
            Console.WriteLine();
            HetedikFeladat();
            Console.WriteLine();
            NyolcadikFeladat();
            Console.WriteLine();
            KilencedikFeladat();



            Console.ReadKey();
        }

        private static void KilencedikFeladat()
        {
            Console.WriteLine("9. feladat");
        }

        private static void NyolcadikFeladat()
        {
            Console.WriteLine("8. feladat");
        }

        private static void HetedikFeladat()
        {
            Console.WriteLine("7. feladat");
        }

        private static void HatodikFeladat()
        {
            Console.WriteLine("6. feladat");
        }

        private static void OtodikFeladat()
        {
            Console.WriteLine("5. feladat");
        }

        private static void NegyedikFeladat()
        {
            Console.WriteLine($"4. feladat: {het + 1}. hét számai: ");
            AdatokBeolvasasa();
            AdottHetSzamainakKiirasa();

        }

        private static void AdottHetSzamainakKiirasa()
        {
            for (int oszlop = 0; oszlop < 5; oszlop++)
            {
                Console.Write($"{hetek[het,oszlop],3}");
            }
        }

        private static void AdatokBeolvasasa()
        {
            int sor = 0;
            StreamReader be = new StreamReader("lottosz.dat");

            while (!be.EndOfStream)
            {
                string[] a = be.ReadLine().Split(' ');
                for (int oszlop = 0; oszlop < 5; oszlop++)
                {
                    hetek[sor, oszlop] = Convert.ToInt32(a[oszlop]);
                }

                sor++;
            }

            be.Close();
        }

        private static void HarmadikFeladat()
        {
            Console.WriteLine("3. feladat");
            Console.Write("Adjon meg egy 1-51 közötti számot: ");
            het = Convert.ToInt32(Console.ReadLine())-1;
        }

        private static void MasodikFeladat()
        {
            Console.WriteLine("2. feladat");

            for (int i = 0; i < het52.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < het52.Length; j++)
                {
                    if (het52[min] > het52[j])
                    {
                        min = j;
                    }
                }
                int temp = het52[i];
                het52[i] = het52[min];
                het52[min] = temp;
            }

            Console.Write("A lottó számok növekvő sorrendben: ");
            foreach (var item in het52)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

        }

        private static void ElsoFeladat()
        {
            Console.WriteLine("1. feladat");


            for (int i = 0; i < het52.Length; i++)
            {
                Console.Write($"Kérem a(z) {i+1}. számot: ");
                het52[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
