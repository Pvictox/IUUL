using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.ProblemaIntervalo
{
    public class Intervalo
    {
        private DateTime dataInicial, dataFinal;


        public String Duracao
        {
            get
            {
                TimeSpan dur = this.dataFinal - this.dataInicial;
                return dur.ToString();
            }
        }
        public DateTime DataInicial{
            get
            {
                return this.dataInicial;
            }
        }

        public DateTime DataFinal {
            get { return this.dataFinal;}
        }

        public Intervalo(DateTime inicio, DateTime final)
        {
            TimeSpan diferencaDate = final.Subtract(inicio);
            if (diferencaDate.Days < 0)
            {
                throw new Exception();
            }
            else
            {
                this.dataInicial = inicio; this.dataFinal = final;
            }
        }


        public bool saoIguais(Intervalo it)
        {
            if (this.dataInicial == it.dataInicial && this.dataFinal == it.dataFinal) { return true; };
            return false;
        }
        public bool TemIntersecao(Intervalo it)
        {
            if (this.dataInicial < it.dataFinal && it.DataInicial < this.dataFinal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public String toString()
        {
            return "Data Inical: " + this.dataInicial + " | Data final: " + this.dataFinal;
        }
    }
}
