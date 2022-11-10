// See https://aka.ms/new-console-template for more information


using Unidade1.ProblemaVertice;
using Unidade1.PyramidProblem;




//PyramidProblem(4);
class App
{
    static void Main(string[] args)
    {
        int option_user = 1;
        while (option_user != 3)
        {
            Console.WriteLine("=================");
            Console.WriteLine("1 - Problema Piramide");
            Console.WriteLine("2 - Problema Vertice");
            Console.Write("Digite o valor: ");
            option_user = Convert.ToInt32(Console.ReadLine());
            switch (option_user)
            {
                case 1:
                    Console.WriteLine("Digite a quantidade de linhas da piramide");
                    int quantLinhas = Convert.ToInt32(Console.ReadLine());
                    Pyramid.PyramidProblem(quantLinhas);
                break;
                
                case 2:
                    Console.WriteLine("Escolheu Vertice");
                break;
            }
        }


        Vertice v1 = new Vertice((float)2.1, (float)3.2);
        Console.Write(v1.toString());
    }
}


