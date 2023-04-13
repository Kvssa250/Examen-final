using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class T_infraccion
    {
        public int Multa { get; set; }
        private List<string> razon;
        public T_infraccion(int multa)
        {
            Multa = 0;
            razon = new List<string>();
        }
        public void obstruccion()
        { 
            Multa = Multa + 1800;
            razon.Add("Usted ha creado una obstruccion de transito, por lo que se le agregara una multa de RD$ 1800.");
        }
        public void semaforo()
        {
            Multa = Multa + 5950;
            razon.Add("Usted se ha pasado un semaforo rojo, por lo que se le agregara una multa de RD$ 5950.");
        }
        public void celular()
        {
            Multa = Multa + 3750;
            razon.Add("Usted manejaba mientras veia el celular, por lo que se le agregara una multa de RD$ 3750.");
        }
        public void cinturon()
        {
            Multa = Multa + 2560;
            razon.Add("Usted manejaba sin el cinturon de seguridad, por lo que se le agregara una multa de RD$ 2560.");
        }
        public void lic_vencida()
        {
            Multa = Multa + 3890;
            razon.Add("Usted manejaba con la licencia vencida, por lo que se le agregara una multa de RD$ 3890.");
        }
        public void nulo()
        {
            Multa = 0;
        }
        public void Total()
        {
            if (razon.Count > 0)
            {
                foreach (string x in razon)
                {
                    Console.WriteLine(x);
                }
                Console.WriteLine($"Su total a pagar es de {Multa}");
            }
            else 
            {
                Console.WriteLine("Usted no tienen ninguna multa que pagar.");
            }
        }
    }
}
