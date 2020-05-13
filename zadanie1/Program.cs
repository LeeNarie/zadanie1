using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(lib1.stpow("Love ", 4) + "\n");
            Console.WriteLine(lib1.rev("Love") + "\n");
            Console.WriteLine(lib1.remov("Победа", "Поб") + "\n");
            Console.WriteLine(lib1.leng("Koronavirus") + "\n");
            Console.ReadKey();
        }
    }
}
