using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
 
    class Program
    {
        static void Main(string[] args)
        {
            Car porsche = new Car();
            porsche.PrintState();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Add speed to 100 km/h");
            porsche.Acceleration(100);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Add speed to 50 km/h");
            porsche.Acceleration(50);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Add speed to 60 km/h");
            porsche.Acceleration(60);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Slow down on 150 km/h");
            porsche.SlowDown(150);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Slow down on 60 km/h");
            porsche.SlowDown(60);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("print state:");
            porsche.PrintState();
            Console.WriteLine();

            Console.WriteLine("-----------------------------");
            Car opel = new Car("Opel", 2012);
            opel.PrintState();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Speed app to 170 km/h");
            opel.Acceleration(170);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Speed app to 30 km/h");
            opel.Acceleration(30);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Slow down on 100 km/h");
            opel.SlowDown(100);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Slow down on 110 km/h");
            opel.SlowDown(110);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("print state:");
            opel.PrintState();
            Console.WriteLine();

            Console.WriteLine("-----------------------------");
            Car honda = new Car("Honda",2008, "Jazz");
            honda.PrintState();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Speed up to 60 km/h");
            honda.Acceleration(60);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Speed up to 20 km/h");
            honda.Acceleration(20);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Slow down on 30 km/h");
            honda.SlowDown(30);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("print state:");
            honda.PrintState();



            Console.ReadKey();
        }
    }

}
