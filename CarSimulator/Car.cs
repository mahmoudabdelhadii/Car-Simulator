using System;
using static CarSimulator.Physics1D;
namespace CarSimulator

{
    public class Prius : Car
    {
        public Prius() : base()
        {

        }
        public Prius(string model, double mass, double engineForce, double dragArea) : base(model, mass, engineForce, dragArea)
        {
            base.model = model;
            base.mass = mass;
            base.engineForce = engineForce;
            base.dragArea = dragArea;
        }
    }
    public class Mazda3 : Car
    {
        public Mazda3() : base()
        {

        }
        public Mazda3(string model, double mass, double engineForce, double dragArea) : base(model, mass, engineForce, dragArea)
        {
            base.model = model;
            base.mass = mass;
            base.engineForce = engineForce;
            base.dragArea = dragArea;
        }
    }
    public class Tesla3 : Car
    {
        public Tesla3() : base()
        {

        }
        public Tesla3(string model, double mass, double engineForce, double dragArea) : base(model, mass, engineForce, dragArea)
        {
            base.model = model;
            base.mass = mass;
            base.engineForce = engineForce;
            base.dragArea = dragArea;
        }
    }
    public class Herbie : Car
    {
        public Herbie() : base()
        {

        }
        public Herbie(string model, double mass, double engineForce, double dragArea) : base(model, mass, engineForce, dragArea)
        {
            base.model = model;
            base.mass = mass;
            base.engineForce = engineForce;
            base.dragArea = dragArea;
        }
    }


    public class Car
    {
        protected double mass;
        protected string model;
        protected double dragArea;
        protected double engineForce;
        //public State myCarState;
        public State myCarState;
        /// implement constructor and methods
        public Car()            //initial constructor
        {
            myCarState = new State();
            //Console.WriteLine("Constructor 3 called - Car init construct");
            //Console.WriteLine(" Car init - mass:{0}, model:{1}, engforce:{2}, dragarea:{3} ", mass, model, engineForce, dragArea);
        }
        public Car (string model, double mass, double engineForce, double dragArea)
        {
           myCarState = new State();
           this.mass = mass;
           this.model = model;
           this.engineForce = engineForce;
           this.dragArea = dragArea;
           
          

           //Console.WriteLine("Constructor 4 called - car overloaded");
           //Console.WriteLine("Car overloaded - mass:{0}, model:{1}, engforce:{2}, dragarea:{3} ", mass, model, engineForce, dragArea);
           //Console.WriteLine(" car overloaded - positionn:{0}, velocity:{1}, acc:{2}, time:{3} ", myCarState.position, myCarState.velocity, myCarState.acceleration, myCarState.time);
        }
        public string GetModel()
        {
            //Console.WriteLine("Enter the model of the car: ");
            //return Console.ReadLine();
            return model;
        }
        public double GetMass()
        {
            //Console.WriteLine("Enter the mass of the car (kg): ");
            //return Convert.ToDouble(Console.ReadLine());
            return mass;
        }
        public void Accelerate(bool on)
        {
            double a = 0;
            if (on)
            {
               a =  myCarState.acceleration;
            }
            else a = 0;
        }
        public void Drive(double dt)
        {
            double x0 ;  // initial position
            double v;  // initial velocity
            double t;  // initial time
            double fd, x1, a; // drag force and secondary position and acceleration
            x0 = myCarState.position;
            v = myCarState.velocity;
            t = myCarState.time;

            fd = 0.500 * 1.225 * dragArea * Math.Pow(v, 2);
            a = Compute_acceleration(engineForce - fd, mass);
            v = Compute_velocity(v, a, dt);
            x1 = Compute_position(x0, v, dt);
            t += dt;
            myCarState.Set(x1, v, a, t);
            
            //myCarState.Set(a,v)
           
        }
        public State GetState()
        {
            return myCarState;
        }


        //implement inheritence


    }
}
