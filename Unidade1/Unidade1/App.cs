// See https://aka.ms/new-console-template for more information


using System.Diagnostics.Tracing;
using System.Xml.Linq;
using Unidade1.Formas;
using Unidade1.ProblemaIntervalo;
using Unidade1.ProblemaVertice;
using Unidade1.PyramidProblem;




//PyramidProblem(4);
class App
{


    static void getXY(ref Vertice v1, int count)
    {
        Console.WriteLine("Digite, respectivamente X e Y do vertice "+count );
        float X = (float)Convert.ToDouble(Console.ReadLine());
        float Y = (float)Convert.ToDouble(Console.ReadLine());
        v1 = new Vertice(X, Y);
    }

    static DateTime getDate(ref int dia, ref int mes, ref int ano, ref int hora, ref int min, ref int seg)
    {
        Console.WriteLine("Digite o dia");
        dia = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o mes");
        mes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o ano");
        ano = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite as horas");
        hora = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite os minutos");
        min = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite os segundo");
        seg = Convert.ToInt32(Console.ReadLine());
        DateTime data = new DateTime(ano, mes, dia, hora, min, seg);
        return data;

    }
    static void Main(string[] args)
    {
        int option_user = 1;
        float X, Y;
        while (option_user < 8)
        {
            Console.WriteLine("=================");
            Console.WriteLine("1 - Problema Piramide");
            Console.WriteLine("2 - Problema Vertice");
            Console.WriteLine("3 - Problema Triangulo");
            Console.WriteLine("4 - Problema Poligono");
            Console.WriteLine("5 - Problema Intervalo");
            Console.WriteLine("6 - Problema Lista Intervalo");
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
                            getXY(ref v1, 1);
                            getXY(ref v2, 2);
                            Console.WriteLine("V1 -> " + v1.toString());
                            Console.WriteLine("V2 -> " + v2.toString());
                            Console.WriteLine("Distancia entre V1 e V2 = " + v1.euclidianDistance(v2));
                            break;

                        case 2:
                            if (v1 == null || v2 == null)
                            {
                                getXY(ref v1, 1);
                                getXY(ref v2, 2);
                            }
                            Console.WriteLine("1 - Mover Vertice 1 (" + v1.toString() + ")");
                            Console.WriteLine("2 - Mover Vertice 2 (" + v2.toString() + ")");
                            int movVertice = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite novos valores para X e Y");
                            X = (float)Convert.ToDouble(Console.ReadLine());
                            Y = (float)Convert.ToDouble(Console.ReadLine());
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
                            if (v1 == null || v2 == null)
                            {
                                getXY(ref v1, 1);
                                getXY(ref v2, 2);
                            }
                            Console.WriteLine("V1 => "+ v1.toString());
                            Console.WriteLine("V2 => "+ v2.toString());
                            Console.WriteLine("São iguais? R = " + v1.equalVertice(v2));
                            break;

                        default:
                            
                            break;
                    }
                    

                    break;

                case 3:
                    v1 = null;
                    v2 = null;
                    Vertice v3 = null;
                    getXY(ref v1, 1);
                    getXY(ref v2, 2);
                    getXY(ref v3, 3);
                    Triangulo t1 = new Triangulo(v1, v2, v3);
                    
                    if (t1.GetVertices().Count != 0)
                    {
                        Console.WriteLine("1 - Comparar com outro Triângulo");
                        Console.WriteLine("2 - Verificar perimetro");
                        int escolhaTriangulo = Convert.ToInt32(Console.ReadLine());
                        switch (escolhaTriangulo)
                        {
                            case 1:
                                v1 = null;
                                v2 = null;
                                v3 = null;
                                getXY(ref v1, 1);
                                getXY(ref v2, 2);
                                getXY(ref v3, 3);
                                Triangulo t2 = new Triangulo(v1, v2, v3);
                                if (t2.GetVertices().Count != 0)
                                {
                                    Console.WriteLine("São semelhantes? R = " + t1.isSemelhanteTriangulo(t2));
                                    Console.WriteLine("São iguais? R = " + t1.isEqualTriangulo(t2));
                                }
                                break;

                            case 2:
                                Console.WriteLine(t1.toString()) ;
                                Console.WriteLine("Perimetro do triangulo = " + t1.Perimetro);
                                break;
                        }
                    }

                    break;

                case 4:
                    v1 = null;
                    v2 = null;
                    v3 = null;
                    getXY(ref v1, 1);
                    getXY(ref v2, 2);
                    getXY(ref v3, 3);
                    try
                    {
                        Poligono p1 = new Poligono(v1, v2, v3);
                        int opcaoPoligono = 1;
                        while (opcaoPoligono < 4)
                        {
                            Console.WriteLine("1 - Adicionar Vertice");
                            Console.WriteLine("2 - Remover Vertice");
                            Console.WriteLine("3 - Ver Informaçoes do poligono");
                            opcaoPoligono = Convert.ToInt32(Console.ReadLine());
                            switch (opcaoPoligono)
                            {
                                case 1:
                                    Vertice vn = null;
                                    getXY(ref vn, p1.quantVertices+1);
                                    if (p1.AddVertice(vn))
                                    {
                                        Console.WriteLine("Adicionado Com sucesos");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Falha ao adicionar");
                                    }

                                    break;
                                case 2:
                                    vn = null;
                                    getXY(ref vn, p1.quantVertices+1);
                                    try
                                    {
                                        p1.RemoveVertice(vn);
                                    }catch(Exception e)
                                    {
                                        Console.WriteLine("Não foi possível excluir");
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Perimetro = " + p1.getPerimetro() + " || Quant. vertices = " + p1.quantVertices);
                                    break;
                            }
                        }
                        
                    }
                    catch(ArgumentNullException e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    
                    break;

                case 5:
                    int dia=0, mes=0, ano = 0, hora = 0, min = 0, seg = 0;
                    Console.WriteLine("===== DATA INICIAL =====");
                    DateTime dataInicial = getDate(ref dia, ref mes, ref ano, ref hora, ref min, ref seg);
                    Console.WriteLine("===== DATA FINAL =====");
                    DateTime dataFinal = getDate(ref dia, ref mes, ref ano, ref hora, ref min, ref seg);

                    try
                    {
                        Intervalo intervalo1 = new Intervalo(dataInicial, dataFinal);
                        Console.WriteLine("======= CRIAÇÃO DO SEGUNDO INTERVALO ======");
                        Console.WriteLine("===== DATA INICIAL =====");
                        dataInicial = getDate(ref dia, ref mes, ref ano, ref hora, ref min, ref seg);
                        Console.WriteLine("===== DATA FINAL =====");
                        dataFinal = getDate(ref dia, ref mes, ref ano, ref hora, ref min, ref seg);
                        Intervalo intervalo2 = new Intervalo(dataInicial, dataFinal);
                        bool hasIntervalo;
                        if (intervalo1.TemIntersecao(intervalo2) || intervalo2.TemIntersecao(intervalo1))
                        {
                            hasIntervalo= true;
                        }
                        else
                        {
                            hasIntervalo = false;
                        }
                        Console.WriteLine("Tem intevalo = " + hasIntervalo + " | Sao iguais = " + intervalo1.saoIguais(intervalo2));
                        Console.WriteLine("Duracao Intervalo 1 = " + intervalo1.Duracao) ;
                        Console.WriteLine("Duracao Intervalo 2 = " + intervalo2.Duracao);

                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Erro na hora de criar data");
                    }
                    break;

                case 6:
                    int opcaoListaIntervalo = 0;
                    ListaIntervalo lista = new ListaIntervalo();
                    while (opcaoListaIntervalo < 3)
                    {
                        
                        dia = 0; mes = 0; ano = 0; hora = 0; min = 0; seg = 0;
                        Console.WriteLine("1 - Adicionar na lista");
                        Console.WriteLine("2 - Ver lista");
                        opcaoListaIntervalo = Convert.ToInt32(Console.ReadLine());
                        switch(opcaoListaIntervalo)
                        {
                            case 1:
                                Console.WriteLine("===== DATA INICIAL =====");
                                dataInicial = getDate(ref dia, ref mes, ref ano, ref hora, ref min, ref seg);
                                Console.WriteLine("===== DATA FINAL =====");
                                dataFinal = getDate(ref dia, ref mes, ref ano, ref hora, ref min, ref seg);
                                Intervalo novoIntervalo = new Intervalo(dataInicial, dataFinal);
                                if (lista.AddIntevalo(novoIntervalo) == false)
                                {
                                    Console.WriteLine("Erro ao adicionar devido interssection");
                                }
                                else
                                {
                                    
                                    Console.WriteLine("Adicionado");
                                }

                                break;

                            case 2:
                                lista.ShowAllIntervalos();
                                break;
                        }
                    }
                    

                    break;
                default:
                    break;
            }
        }


 
    }
}


