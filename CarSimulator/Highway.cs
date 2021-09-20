using System;
using System.Linq;
using static CarSimulator.Car;
using System.Collections.Generic;
namespace CarSimulator
   
{
    public class Highway
    {
        static void Main(string[] args)
        {
            int fleetNumberPerType = 25;
            double dt= 1;
            
            
            // and compute states
            for (int i = 0; i < fleetNumberPerType; i++)
            {
               
                Tesla3[] myTeslas = new Tesla3[fleetNumberPerType].Select(x => new Tesla3("Tesla" + (i+1).ToString(), 1500, 1000, 0.51)).ToArray();
                Prius [] myPriuses = new Prius[fleetNumberPerType].Select(x => new Prius("Prius" + (i+1).ToString(), 1000, 750, 0.43)).ToArray();
                Mazda3[] myMazdas = new Mazda3[fleetNumberPerType].Select(x => new Mazda3("Mazda" + (i+1).ToString(), 1600,1300,0.25)).ToArray();
                Herbie[] myHerbies = new Herbie[fleetNumberPerType].Select(x => new Herbie("Herbie" + (i+1).ToString(), 750,100,0.01 )).ToArray();
            }
            
                
                var myCars = new List<Car>();
            for (int i = 0; i < fleetNumberPerType; i++)
            {
                myCars.Add(new Tesla3("Tesla" +" " + (i+1).ToString(), 1500, 1000, 0.51));
                myCars.Add(new Mazda3("Prius" +" " + (i+1).ToString(), 1000, 750, 0.43));
                myCars.Add(new Prius("Mazda" +" " + (i+1).ToString(), 1600, 1300, 0.25));
                myCars.Add(new Herbie("Herbie" +" "+ (i+1).ToString(), 750, 1000, 0.01));
 }
            // loop through the time and list to drive all the vehicles
            for (double t = 0; t < 60; t += dt)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("time: {0}",myCars[0].myCarState.time);
                Console.WriteLine();
                for (int i = 0; i < 4* fleetNumberPerType; i++)
                {
                   
                    myCars[i].Drive(dt);
                    
                    Console.WriteLine("{0}    Position:{1} , acceleration:{2}, velocity: {3} ", myCars[i].GetModel(), myCars[i].myCarState.position, myCars[i].myCarState.acceleration, myCars[i].myCarState.velocity);
          
                }
            }
           



        }

    }
}
