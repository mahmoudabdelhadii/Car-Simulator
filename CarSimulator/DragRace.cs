using System;
using static CarSimulator.Car;
namespace CarSimulator

{
    public class DragRace
    {
        static void Main(string[] args)
        {
      
            Car myTesla = new Car("Tesla", 1500, 1000, 0.51);
            Car myPrius = new Car("Prius", 1000, 750, 0.43);

            
            // drive for 60 seconds with delta time of 1s

            double dt = 1;

            for (double t = 0; t < 3600; t += dt)
            {
                // print the time and current state
                // print who is in lead
                
                Console.WriteLine("t:{0}" , t);
                Console.WriteLine("Prius State - Position:{0} , acceleration:{1}, velocity: {2} ", myPrius.myCarState.position, myPrius.myCarState.acceleration, myPrius.myCarState.velocity);
                Console.WriteLine("Tesla State - Position:{0} , acceleration:{1}, velocity: {2} ", myTesla.myCarState.position, myTesla.myCarState.acceleration, myTesla.myCarState.velocity);
                myTesla.Drive(dt);
                myPrius.Drive(dt);
                if (myPrius.myCarState.position > myTesla.myCarState.position) 
                    Console.WriteLine("Prius is in the lead");
                else  Console.WriteLine("Tesla is in the lead");

                if ((myPrius.myCarState.position >= 403.2 || myTesla.myCarState.position >= 403.2)) break;

            }
        }
    }
}
