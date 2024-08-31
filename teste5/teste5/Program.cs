using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringInversor inversor = new StringInversor();

            string original = "Teste para o Estágio!";

            string invertida = inversor.Inverter(original);

            Console.WriteLine($"Original: {original}");
            Console.WriteLine($"Invertida: {invertida}");
            Console.ReadKey();
        }
    }
}

