using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    internal class Program
    {
        static int Tribonacci(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else if (num == 1 || num == 2)
            {
                return 1;
            }
            else
            {
                return Tribonacci(num - 1) + Tribonacci(num - 2) + Tribonacci(num - 3);
            }
        }

        static void Main(string[] args)
        {
            int num = 10; // Altere o valor de num para o N-ésimo número desejado
            Console.WriteLine($"O {num}-ésimo número da sequência de Tribonacci é: {Tribonacci(num)}");
            Console.ReadKey();
        }
    }
}
