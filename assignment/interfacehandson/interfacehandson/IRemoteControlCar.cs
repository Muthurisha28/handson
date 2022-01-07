using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacehandson
{
    interface IRemoteControlCar
    {
        double DistanceTravelled { get; set; }
        // static string GetHello() =>  throw new NotImplementedException() ;
        void Drive();


    }
    class ProductionRemoteControlcars:IRemoteControlCar//IComparable<T>
    {
        public void Drive()
        {
            Console.WriteLine("Production control cars are allowed inside the track");
          double DistanceTravelled = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Distance travelled by the production car is" + DistanceTravelled);
        }

    }

    class ExperimentalRemoteControlCar
    {

    }
}
