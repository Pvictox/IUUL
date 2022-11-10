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

        
        public String toString()
        {
            return "X = " + this.getX() + ", Y = " + this.getY();
        }
    }
}
