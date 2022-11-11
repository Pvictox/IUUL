using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unidade1.ProblemaVertice;

namespace Unidade1.Formas
{
    public class Triangulo
    {
        private enum tipoTriangulo
        {
            EQUILATERO = 0,
            ISOSCEÇES = 1,
            ESCALENO = 2
        }

        private List<Vertice> vertices = new List<Vertice>();
        private List<float> medidasLados = new List<float>();
        private float perimetro = 0;
        private int idTipoTriangulo = 0;
        private float AreaTriangulo = 0;

        public float Perimetro
        {
            get { return perimetro; }
        }

        public String TipoTriangulo
        {
            get {
                var enumDisplay = (tipoTriangulo)this.idTipoTriangulo;
                return enumDisplay.ToString();
            }
        }

        public float returnAreaTriangulo
        {
            get
            {
                return AreaTriangulo;
            }
        }

        public Triangulo(Vertice v1, Vertice v2, Vertice v3)
        {
            if (checkIfTriangule(v1, v2, v3))
            {
                this.GetVertices().Add(v1);
                this.GetVertices().Add(v2);
                this.GetVertices().Add(v3);
                this.calculaPerimetro();
                this.assignTipoTriangulo();
                this.calcularAreaTriangulo();

            }
            else {
                Console.Write("Não é possível existir esse triangulo");
            }
        }


        public void calcularAreaTriangulo()
        {
            float lado1 = this.getMedidasLados().ElementAt(0);
            float lado2 = this.getMedidasLados().ElementAt(1);
            float lado3 = this.getMedidasLados().ElementAt(2);
            float S = this.perimetro / 2;
            this.AreaTriangulo = (float)Math.Sqrt( S * (S-lado1) * (S-lado2) * (S-lado3));

        }

       
        public void assignTipoTriangulo()
        {
            float lado1 = this.getMedidasLados().ElementAt(0);
            float lado2 = this.getMedidasLados().ElementAt(1);
            float lado3 = this.getMedidasLados().ElementAt(2);

            if ((lado1 == lado2) && (lado2 == lado3))
            {
                this.idTipoTriangulo = (int)tipoTriangulo.EQUILATERO;
            }else if ( (lado2 != lado3) && (lado1 != lado2) && (lado1 != lado3))
            {
                this.idTipoTriangulo = (int)tipoTriangulo.ESCALENO;
            }
            else
            {
                this.idTipoTriangulo = (int)tipoTriangulo.ISOSCEÇES;
            }
        }
        public List<float> getMedidasLados()
        {
            return this.medidasLados; 
        }
              

        private void calculaPerimetro()
        {
            foreach (var p in this.getMedidasLados())
            {
                this.perimetro += p;
            }
        }

        public String toString()
        {
            float lado1 = this.getMedidasLados().ElementAt(0);
            float lado2 = this.getMedidasLados().ElementAt(1);
            float lado3 = this.getMedidasLados().ElementAt(2);

            return "Lado AB = " + lado1 + " | Lado BC = " + lado2 + " | Lado AC = " + lado3 + " | TIPO: "+ this.TipoTriangulo +" | Area = "+this.returnAreaTriangulo;
        }

        public List<Vertice> GetVertices() { return this.vertices; }

        private bool checkIfTriangule(Vertice v1, Vertice v2, Vertice v3)
        {
            this.getMedidasLados().Add(v1.euclidianDistance(v2));
            this.getMedidasLados().Add(v2.euclidianDistance(v3));
            this.getMedidasLados().Add(v3.euclidianDistance(v1));

            if (getMedidasLados().ElementAt(0) + getMedidasLados().ElementAt(1) > getMedidasLados().ElementAt(2))
            {
                if (getMedidasLados().ElementAt(0) + getMedidasLados().ElementAt(2) > getMedidasLados().ElementAt(1))
                {
                    if (getMedidasLados().ElementAt(2) + getMedidasLados().ElementAt(1) > getMedidasLados().ElementAt(0))
                    {
                        return true;
                    }
                }
            }
            this.getMedidasLados().Clear();
            return false;

        }

        public bool isEqualTriangulo(Triangulo t2)
        {
            if (this.getMedidasLados().ElementAt(0) == t2.getMedidasLados().ElementAt(0))
            {
                if (this.getMedidasLados().ElementAt(1) == t2.getMedidasLados().ElementAt(1))
                {
                    if (this.getMedidasLados().ElementAt(2) == t2.getMedidasLados().ElementAt(2))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool isSemelhanteTriangulo(Triangulo t2)
        {
            //Semelhança LLL
            float proporcaoAB = this.getMedidasLados().ElementAt(0) / t2.getMedidasLados().ElementAt(0);
            float proporcaoBC = this.getMedidasLados().ElementAt(1) / t2.getMedidasLados().ElementAt(1);
            float proporcaoAC = this.getMedidasLados().ElementAt(2) / t2.getMedidasLados().ElementAt(2);

            if (proporcaoAB == proporcaoBC) { 
                if (proporcaoBC == proporcaoAC)
                {
                    return true;
                }
            }
            return false;
        }


    }
}
