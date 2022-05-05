using System;

namespace ABCexamen
{
    class Program
    {
        public static void Main(String[] args)
        {
            DateTime[] dates = { new DateTime (2022, 01, 05), new DateTime (2022, 02, 20), //46 dias
                             new DateTime (2022, 01, 28), new DateTime (2022, 03, 15),    //46 dias
                             new DateTime (2022, 01, 07), new DateTime (2022, 01, 25),   //18 dias
                             new DateTime (2022, 03, 17), new DateTime (2022, 04, 04)   //18 dias
            };

            Periodos.ImprimirOriginales(dates);

            

            
        }
    }
}