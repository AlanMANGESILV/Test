using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Paye paye1 = new Paye("alan", "MANG", 3456);

           
            paye1.HeureTravail = 60;
            paye1.Commission = true;
            paye1.CommissionSalariedEmployees = false;
            Console.WriteLine(paye1.Salaire1());


            Console.ReadKey();
        }
    }
}
