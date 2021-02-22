using System;
using System.Linq;

namespace Meta.Logica.Desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mapa = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            int TotalRetido = 0;
            for (int x = 0; x < mapa.Max() - 1; x++)
            {
                for (int y = 1; y < mapa.Length - 1; y++)
                {
                    int proximaBarra = mapa.ToList().FindIndex(y + 1, a => a > x);
                    int aguaRetida = proximaBarra - y - 1;
                    if (mapa[y] > x && aguaRetida > 0)
                    {
                        TotalRetido+= aguaRetida;
                        y = proximaBarra - 1;
                    }
                }
            }
            Console.WriteLine(String.Format("A quantidade total de água retida é de {0}", TotalRetido));
            Console.ReadKey();
        }
    }
}
