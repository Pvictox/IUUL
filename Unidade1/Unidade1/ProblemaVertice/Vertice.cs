using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.ProblemaVertice
{
    public class Vertice
    {
        private float X, Y;

        public Vertice(float x, float y)        {
            this.X = x;
            this.Y = y;
        }


        public float getX()
        {
            return this.X;
        }

        public float getY()
        {
            return this.Y;
        }

        public void moveVertice(float X, float Y)
        {
            this.X = X; this.Y = Y;
        }

        public bool equalVertice(Vertice v2)
        {
            if (this.X == v2.getX() && this.Y == v2.getY())
            {
                return true;
            }
            return false;
        }
        public float euclidianDistance(Vertice v2)
        {
            double somaPotencia = Math.Pow(v2.getX() - this.getX(), 2) + Math.Pow(v2.getY() - this.getY(), 2);
            float d = (float)Math.Sqrt(somaPotencia);
            return d;
        }
        
        public String toString()
        {
            return "X = " + this.getX() + ", Y = " + this.getY();
        }
    }
}
