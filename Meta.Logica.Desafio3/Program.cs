using System;

namespace Meta.Logica.Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] preco = new int[] { 7, 1, 4, 3, 6, 4 };
            LucroMaximo(preco);
            preco = new int[] { 7, 6, 4, 3, 1 };
            LucroMaximo(preco);
        }

        static void LucroMaximo(int[] precos)
        {
            int lucro = 0, diacompra = 0, diavenda = 0;
            Console.WriteLine(String.Format("Os valores das ações que serão avaliadas são {0}", String.Join(", ", precos)));
            for (int x = 0; x < precos.Length; x++)
            {
                for (int y = x + 1; y < precos.Length; y++)
                {
                    if (precos[y] - precos[x] > lucro)
                    {
                        diacompra = x;
                        diavenda = y;
                        lucro = precos[diavenda] - precos[diacompra];
                    }
                }
            }
            if (lucro > 0) 
                Console.WriteLine(String.Format("Melhor lucro é de {0}, comprando no dia {1} e vendendo no dia {2} ({3} - {4} = {0})", lucro, diacompra + 1, diavenda + 1, precos[diavenda], precos[diacompra]));
            else
                Console.WriteLine("Nenhuma transação deve ser feita, lucro máximo igual a 0");
            Console.ReadKey();
        }
    }
}
