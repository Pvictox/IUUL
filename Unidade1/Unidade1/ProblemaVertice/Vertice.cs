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


        public float returnX
        {
            get { return X; }
            set { X = value; }
        }

        public float returnY
        {
            get { return Y; }
            set { Y = value; }
        }
        public Vertice(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }


 
        public void moveVertice(float X, float Y)
        {
            this.X = X; this.Y = Y;
        }

        public bool equalVertice(Vertice v2)
        {
            if (this.X == v2.returnX && this.Y == v2.returnY)
            {
                return true;
            }
            return false;
        }
        public float euclidianDistance(Vertice v2)
        {
            double somaPotencia = Math.Pow(v2.returnX - this.X, 2) + Math.Pow(v2.returnY - this.Y, 2);
            float d = (float)Math.Sqrt(somaPotencia);
            return d;
        }
        
        public String toString()
        {
            return "X = " + this.X + ", Y = " + this.Y;
        }
    }
}
