// See https://aka.ms/new-console-template for more information


using System.Xml.Linq;
using Unidade1.ProblemaVertice;
using Unidade1.PyramidProblem;




//PyramidProblem(4);
class App
{


    static void getXY(ref Vertice v1, ref Vertice v2)
    {
        Console.WriteLine("Digite, respectivamente X e Y do vertice 1");
        float X = (float)Convert.ToDouble(Console.ReadLine());
        float Y = (float)Convert.ToDouble(Console.ReadLine());
        v1 = new Vertice(X, Y);
        Console.WriteLine("Digite, respectivamente X e Y do vertice 2");
        X = (float)Convert.ToDouble(Console.ReadLine());
        Y = (float)Convert.ToDouble(Console.ReadLine());
        v2 = new Vertice(X, Y);
    }

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
                    Vertice v1 = null;
                    Vertice v2 = null;
                    Console.WriteLine("1 - Calcular distância entre 2 vertices");
                    Console.WriteLine("2 - Mover um vertice para um ponto (X,Y)");
                    Console.WriteLine("3 - Verificar se V1 e V2 são iguais");
                    int escolhaVertice = Convert.ToInt32(Console.ReadLine());
                    switch (escolhaVertice)
                    {
                        case 1:
                            getXY(ref v1, ref v2);
                            Console.WriteLine("V1 -> " + v1.toString());
                            Console.WriteLine("V2 -> " + v2.toString());
                            Console.WriteLine("Distancia entre V1 e V2 = " + v1.euclidianDistance(v2));
                            break;

                        case 2:
                            if (v1 == null && v2 == null)
                            {
                                getXY(ref v1, ref v2);                            
                            }
                            Console.WriteLine("1 - Mover Vertice 1 (" + v1.toString() + ")");
                            Console.WriteLine("2 - Mover Vertice 2 (" + v2.toString() + ")");
                            int movVertice = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite novos valores para X e Y");
                            float X = (float)Convert.ToDouble(Console.ReadLine());
                            float Y = (float)Convert.ToDouble(Console.ReadLine());
                            switch (movVertice)
                            {
                                case 1:
                                    Console.WriteLine("Antes de mover => " + v1.toString());
                                    v1.moveVertice(X, Y);
                                    Console.WriteLine("Depois de mover => " + v1.toString());
                                    break;
                                case 2:
                                    Console.WriteLine("Antes de mover => " + v1.toString());
                                    v2.moveVertice(X, Y);
                                    Console.WriteLine("Depois de mover => " + v1.toString());
                                    break;
                            }                                                       
                        break;

                        case 3:
                            if (v1 == null && v2 == null)
                            {
                                getXY(ref v1, ref v2);
                            }
                            Console.WriteLine("V1 => "+ v1.toString());
                            Console.WriteLine("V2 => "+ v2.toString());
                            Console.WriteLine("São iguais? R = " + v1.equalVertice(v2));
                            break;

                        default:
                            
                            break;
                    }
                    

                    break;


                default:
                    break;
            }
        }


 
    }
}


