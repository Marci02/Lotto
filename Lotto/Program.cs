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
        static void Main(string[] args)
        {

            ElsoFeladat();
            MasodikFeladat();
            HarmadikFeladat();
            NegyedikFeladat();
            OtodikFeladat();
            HatodikFeladat();
            HetedikFeladat();
            NyolcadikFeladat();
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
            Console.WriteLine("4. feladat");
        }

        private static void HarmadikFeladat()
        {
            Console.WriteLine("3. feladat");
        }

        private static void MasodikFeladat()
        {
            Console.WriteLine("2. feladat");
        }

        private static void ElsoFeladat()
        {
            Console.WriteLine("1. feladat");
        }
    }
}
