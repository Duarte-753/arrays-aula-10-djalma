using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_aula_10_djalma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] valores = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(String.Format("valor {0}", i));
                valores[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(String.Format("Elemento {0} = valor {1}", i, valores[i]));
            }

            // alteração da array 

            int posicao;

            Console.WriteLine("Qual posição:");
            posicao = int.Parse(Console.ReadLine());

            Console.WriteLine(String.Format("Novo Valor da posição {0}:", posicao));
            valores[posicao] = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(String.Format("Elemento {0} = Valor {1}",i, valores[i]));
            }    
        }
    }
}
