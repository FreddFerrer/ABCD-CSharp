using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCexamen
{
    internal class Periodos
    {

        

        public static void ImprimirOriginales(DateTime[] fechas)
        {
            /*for(int i = 0; i < fechas.Length; i++)
            {
                Console.WriteLine("El Periodo 1 va desde: " + fechas[i].ToLongDateString() + "    hasta: " + fechas[i+1].ToLongDateString());
            }*/

            Console.WriteLine("El Periodo A va desde: " + fechas[0].ToLongDateString() + "    hasta: " + fechas[1].ToLongDateString());
            Console.WriteLine("El Periodo B va desde: " + fechas[2].ToLongDateString() + "    hasta: " + fechas[3].ToLongDateString());
            Console.WriteLine("El Periodo C va desde: " + fechas[4].ToLongDateString() + "    hasta: " + fechas[5].ToLongDateString());
            Console.WriteLine("El Periodo D va desde: " + fechas[6].ToLongDateString() + "    hasta: " + fechas[7].ToLongDateString());

        }

        

        




    }
}
