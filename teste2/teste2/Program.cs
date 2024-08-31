using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci: ");
            int numero = int.Parse(Console.ReadLine());

            bool pertence = PertenceFibonacci(numero);

            if (pertence)
            {
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
            }
            Console.ReadKey();
        }

        static bool PertenceFibonacci(int n)
        {
            if (n < 0)
            {
                return false; 
            }

            if (n == 0 || n == 1)
            {
                return true;
            }

            int a = 0;
            int b = 1;
            while (b < n)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }

            return b == n;
        }
       
    }
}
