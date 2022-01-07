using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars_assemble
{
   static class Assemblyline
    {
       //static int speed;
       // static double productivity;

        static double sucess;
       

        public static void sucessrate(int speed)
        {
            //Console.WriteLine(" enter speed of the car.Enter the value 0 to 10");
            int Speed = speed;
             
            //speed = Convert.ToInt32(Console.ReadLine());
            if (Speed == 0)
            {
                sucess = 0;
            }
             else if ((Speed == 1 || Speed == 2 || Speed == 3 || Speed == 4))
            {
                sucess = 100;
            }
           else  if ((Speed == 5 || Speed == 6 || Speed == 7 || Speed == 8))
            {
                sucess = 90;
            }
            else  if (Speed == 9)
            {
                sucess= 80;
            }
            else  if (Speed == 10)
            {
                sucess= 77;
            }

            Console.WriteLine("sucessrate", +sucess);



        }
        public static double assemblylineproductionperhour(int speed)
        {
            int products = 221;
            double productionrateperhour;

            productionrateperhour = products * speed * (sucess / 100);
            Console.WriteLine("production rate per hour" );
           return (productionrateperhour);

        }
        public static double workingitemsperminute(double productionrateperhour)
        {
            double wpm;
            wpm = productionrateperhour / 60;
            //int.Parse(wpm);
           return wpm;


        }



    }
}

   
