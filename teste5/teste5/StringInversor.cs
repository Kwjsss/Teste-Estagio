using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste5
{
    internal class StringInversor
    {
        public string Inverter(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] caracteres = input.ToCharArray();

            int esquerda = 0;
            int direita = caracteres.Length - 1;

            while (esquerda < direita)
            {
                char temp = caracteres[esquerda];
                caracteres[esquerda] = caracteres[direita];
                caracteres[direita] = temp;

                esquerda++;
                direita--;
            }

            return new string(caracteres);
        }
    }

}

