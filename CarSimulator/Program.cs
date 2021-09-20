using System;
using static CarSimulator.Physics1D;
using static CarSimulator.State;
namespace CarSimulator
{
    class Program
    {
        
        static void Main(string[] args)
        {

            State state1 = new State();
            Console.WriteLine("t:{0}, a:{1}, v:{2}, x1:{3}", state1.time, state1.acceleration, state1.velocity, state1.position);
             state1.Set (2, 20, 200, 2000);
            Console.WriteLine("t:{0}, a:{1}, v:{2}, x1:{3} ", state1.time, state1.acceleration, state1.velocity, state1.position);
            // read in car mass
/*
            Console.WriteLine("Enter the mass of the car (kg): ");
            double mass;
            mass = Convert.ToDouble(Console.ReadLine());

            // read in engine force
            Console.WriteLine("Enter the net force of the engine (N): ");
            double engine_force;
            engine_force = Convert.ToDouble(Console.ReadLine());

            // read in drag area coefficient
            Console.WriteLine("Enter the car's drag area (m^2): ");
            double drag_area;
            drag_area = Convert.ToDouble(Console.ReadLine());

            // read in time step
            Console.WriteLine("Enter the simulation time step (s): ");
            double dt;
            dt = Convert.ToDouble(Console.ReadLine());

            // read in total number of simulation steps
            Console.WriteLine("Enter the number of time steps (int): ");
            int N;
            N = Convert.ToInt32(Console.ReadLine());

            // initialize the car's state
            double x0 = 0;  // initial position
            double v = 0;  // initial velocity
            double t = 0;  // initial time
            double fd, x1, a; // drag force and secondary position and acceleration
            a = 0;
            fd = 0;

            // run the simulation
            for (int i = 0; i < N; ++i)
            {
                // TODO: COMPUTE UPDATED STATE HERE

                a = (a < 0) ? 0: Compute_acceleration(engine_force-fd, mass) ;
                v = Compute_velocity(v, a, dt);
                x1 = Compute_position(x0, v, dt);
                fd = 0.500 * 1.225 * drag_area * Math.Pow(v, 2);
                t += dt;  // increment time
                x0 = x1;

                // print the time and current state
                Console.WriteLine("t:{0}, a:{1}, v:{2}, x1:{3}, fd:{4} ", t, a, v, x1, fd);
            }
*/
        }
    }
}
