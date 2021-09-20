using System;
namespace CarSimulator
{
    public class State
    {
        public double position;
        public double velocity;
        public double acceleration;
        public double time;

        //implement methods like set, constructors (if applicable)
         public State() 
           
        {
            //Console.WriteLine("Constructor 1 called");
           // Console.WriteLine(" st - init pos:{0}, vel:{1}, acc:{2}, time:{3} ", position, velocity, acceleration, time);
        }
        public State(double position, double velocity, double acceleration, double time)
            : this()
        {
            //Console.WriteLine("Constructor 2 called");
            //Console.WriteLine(" st - overloaded pos:{0}, vel:{1}, acc:{2},time:{3} ", position, velocity, acceleration, time);
        }

        public void Set (double position, double velocity, double acceleration, double time)
        {
            this.position = position;
            this.velocity = velocity;
            this.acceleration = acceleration;
            this.time = time;

            // new State(position, velocity, acceleration, time);
            /*
            {
                position = position,
                velocity = velocity,
                acceleration = acceleration,
                time = time
            };
          */

            //Console.WriteLine("Method called");
        //Console.WriteLine("Set Method pos:{0}, vel:{1}, acc:{2}, time:{3} ", this.position, this.velocity, this.acceleration, this.time);
        }
        



    }
}
