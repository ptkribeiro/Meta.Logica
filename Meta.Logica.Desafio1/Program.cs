using System;

namespace Meta.Logica.Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[] { 2, 7, 11, 15 };
            Console.WriteLine(string.Format("Array utilizado: [{0}]", string.Join(", ", numeros)));
            Console.WriteLine("Digite o valor do alvo");
            int alvo = Convert.ToInt32(Console.ReadLine());
            bool somaEncontrada = false;
            for (int x = 0; x < numeros.Length; x++)
            {
                for (int y = x + 1; y < numeros.Length; y++)
                {
                    if (x != y && numeros[x] + numeros[y] == alvo)
                    {
                        somaEncontrada = true;
                        Console.WriteLine(String.Format("Os índices necessários para a soma são [{0}] e [{1}] pois {2} + {3} = {4}", x, y, numeros[x], numeros[y], alvo));                    }
                }
            }
            if (!somaEncontrada) 
                Console.WriteLine(String.Format("Nenhuma soma de dois elementos do array é possível chegar ao total de {0}", alvo));
            Console.ReadKey();
        }
    }
}
