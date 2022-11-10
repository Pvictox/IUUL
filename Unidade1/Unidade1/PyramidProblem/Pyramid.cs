using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.PyramidProblem
{
    public class Pyramid
    {
        public static void PyramidProblem(int n)
        {
            if (n < 1)
            {
                Console.WriteLine("Digite um valor maior ou igual a 1");

            }
            else
            {
                int j = 0;
                for (int i = 0; i < n; i++)
                {
                    j = 0;
                    for (int l = 0; l < (n - i) + 1; l++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 0; j < i + 1; j++)
                    {

                        Console.Write(j + 1 + "");
                    }

                    for (j = j - 1; j > 0; j--)
                    {
                        Console.Write(j);
                    }

                    Console.WriteLine("");

                }

            }
        }
    }
}
