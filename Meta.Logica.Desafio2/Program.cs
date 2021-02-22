using System;
using System.Linq;

namespace Meta.Logica.Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] sequencia = new char[] { '{', '[', '(', ')', ']', '}' };
            Console.WriteLine(String.Format("A seguinte sequência de brackets será testada: {0}", String.Join(", ", sequencia)));
            Console.WriteLine(String.Format("A sequência de brackets{0}está balanceada", IsBalanceada(sequencia) ? " " : " não "));
            Console.ReadKey();
            sequencia = new char[] { '{', '[', '(', ']', ')', '}' };
            Console.WriteLine(String.Format("A seguinte sequência de brackets será testada: {0}", String.Join(", ", sequencia)));
            Console.WriteLine(String.Format("A sequência de brackets{0}está balanceada", IsBalanceada(sequencia) ? " " : " não "));
            Console.ReadKey();
            sequencia = new char[] { '{', '{', '[', '[', '(', '(', ')', ')', ']', ']', '}', '}' };
            Console.WriteLine(String.Format("A seguinte sequência de brackets será testada: {0}", String.Join(", ", sequencia)));
            Console.WriteLine(String.Format("A sequência de brackets{0}está balanceada", IsBalanceada(sequencia) ? " " : " não "));
            Console.ReadKey();
        }

        static bool IsBalanceada(char[] sequencia)
        {
            char[] brackets = new char[] { '(', ')', '[', ']', '{', '}' };
            for (int x = 0; x < sequencia.Length / 2; x++)
            {
                int bracketEsquerda = x;
                int bracketDireita = sequencia.Length - x - 1;
                bool bracketEsquerdaEsperado = brackets.ToList().FindIndex(br => br == sequencia[bracketEsquerda]) % 2 == 0;
                int bracketDireitaEsperado = brackets.ToList().FindIndex(br => br == sequencia[x]) + 1;
                if (!bracketEsquerdaEsperado || sequencia[bracketDireita] != brackets[bracketDireitaEsperado])
                {
                    Console.WriteLine(String.Format("O bracket '{0}' na posição {1} não balanceia com o bracket '{2}' na posição {3}", sequencia[bracketEsquerda], bracketEsquerda, sequencia[bracketDireita], bracketDireita));
                    return false;
                }
            }
            return true;
        }
    }
}
