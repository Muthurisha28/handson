using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars_assemble
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Cars.Assemblylinesucessrate(6);
            Cars.assemblylineproductionperhour(6, 90);
            Cars.workingitemsperminute(1193.4); */
            Assemblyline.sucessrate(6);
            Assemblyline.assemblylineproductionperhour(6);
            Assemblyline.workingitemsperminute(6);

            Console.ReadKey();
        }
    }
}
