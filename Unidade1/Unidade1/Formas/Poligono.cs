using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unidade1.ProblemaVertice;

namespace Unidade1.Formas
{
    public class Poligono
    {
        private List<Vertice> vertices;
        private List<float> medidaLados;
        private float perimetro;

        public int quantVertices
        {
            get
            {
                return this.vertices.Count;
            }
        }
        public Poligono(Vertice v1, Vertice v2, Vertice v3) {
            if (v1 == null || v2 == null || v3 == null) throw new ArgumentNullException();
            else
            {
                this.vertices = new List<Vertice>
                {
                    v1,
                    v2,
                    v3
                };
                this.medidaLados = new List<float>();
                calcularLados();
                this.perimetro = 0;
                calcularPerimetro();
            }
        }

        private void calcularLados()
        {
            for (int i=0; i<this.vertices.Count; i++)
            {
                //Liga o ultimo com o primeiro vertice
                if(i == this.vertices.Count - 1)
                {
                    this.medidaLados.Add(this.vertices.ElementAt(i).euclidianDistance(this.vertices.ElementAt(0)));

                }
                else
                {
                    this.medidaLados.Add(this.vertices.ElementAt(i).euclidianDistance(this.vertices.ElementAt(i + 1)));
                }
            }
        }

        public List<Vertice> getVertices()
        {
            return this.vertices;
        }

        private void calcularPerimetro()
        {
            foreach (var valor in this.medidaLados)
            {
                this.perimetro += valor;
            }
        }

        public float getPerimetro()
        {
            return this.perimetro;
        }

        public bool AddVertice(Vertice v1)
        {
            if (this.getVertices().Contains(v1)) return false;
            else
            {
                this.getVertices().Add(v1);
                calcularLados();
                calcularPerimetro();
                return true;
            }
        }

        public void RemoveVertice(Vertice v)
        {
            if (this.getVertices().Count == 3)
            {
                throw new Exception();
            }else if (this.getVertices().Contains(v) == false)
            {
                throw new Exception();
            }
            else
            {
                this.getVertices().Remove(v);
                calcularLados();
                calcularPerimetro();
            }
        }
    }
}
