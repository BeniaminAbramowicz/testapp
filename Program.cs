using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int h;
            double b, w = 1.5;

            Console.WriteLine("Wprowadź wysokość h z której zrzucana jest piłka: ");
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wprowadź współczynnik b wysokości odbicia piłki - zakres od 0 do 1: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Mama zobaczyła piłkę " + Algorythm.CountResult(h, w, b) + " razy");
            
            Console.ReadKey();
        }
    }
}
