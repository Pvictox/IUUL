using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade1.ProblemaIntervalo
{
    public class ListaIntervalo
    {
        List<Intervalo> listIntervalos = new List<Intervalo>();


        public bool AddIntevalo(Intervalo it)
        {
            if (this.listIntervalos.Count == 0)
            {
                
                this.listIntervalos.Add(it);
                return true;
            }
            foreach (var intervalo in this.listIntervalos){
                if (intervalo.TemIntersecao(it) == true || it.TemIntersecao(intervalo) == true)
                {
                    return false;
                }
                else
                {
                    this.listIntervalos.Add(it);
                    return true;
                }
            }
            return false;
            
        }

        public void ShowAllIntervalos()
        {
            if (this.listIntervalos.Count == 0)
            {
                Console.WriteLine("Vazio");
            }
            List<Intervalo> sortList = this.listIntervalos.OrderBy(i => i.DataInicial).ToList();
            foreach (var intervalor in sortList)
            {
                Console.WriteLine(intervalor.toString());
            }
        }
    }
}
