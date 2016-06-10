using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7_Sort_Car
{

    public class Car : IComparable
    {
        private string model;
        private int yearOfProduction;
        private string color;
        private int currentSpeed;
        private static int maxSpeed;


        public Car()
        {
            model = "Porsche Cayenne";
            yearOfProduction = 2012;
            color = "white";
        }

        public Car(string ModelForConstructor, int YearProductForConstructor)
        {
            model = ModelForConstructor;
            yearOfProduction = YearProductForConstructor;
        }

        public Car(string Model, int YearProduct, string Color)
            : this(Model, YearProduct)
        {
            color = Color;
        }

        static Car()
        {
            Console.WriteLine("Max speed:{0}", maxSpeed);
            maxSpeed = 200;
        }

        public void Acceleration(int speedUp)
        {
            if ((currentSpeed + speedUp) <= maxSpeed)
            {
                currentSpeed = currentSpeed + speedUp;
                Console.WriteLine("current speed is : {0}", currentSpeed);
            }
            else
            {
                Console.WriteLine("Error: Max speed is :{0}!!! current speed: {1}", maxSpeed, currentSpeed);
            }
        }

        public void SlowDown(int slowDown)
        {
            if ((currentSpeed - slowDown) < 0)
            {
                currentSpeed = 0;
                Console.WriteLine("CAR IS STOPPED");
            }
            else if ((currentSpeed - slowDown) != 0)
            {
                currentSpeed = currentSpeed - slowDown;
                Console.WriteLine("slowDown is:{0}, current speed: {1}", slowDown, currentSpeed);
            }

            else
            {
                currentSpeed = 0;
                Console.WriteLine("Car is stopped. currentspeed: {0}", currentSpeed);
            }
            
        }

        public void PrintState()
        {
            Console.WriteLine("Model: {0},\n year of production: {1}, color: {2},\n current speed: {3}", model, yearOfProduction, color, currentSpeed);
        }



        public int CompareTo(object obj)
        {
            if (!(obj is IComparable))
            {
                Console.WriteLine("Error!!!");
            }
            else
            {
                Car year = (Car)obj;
                 
                int yearOfProductionOfThisCar = this.yearOfProduction;
                int yearOfProductionOfCarToCompare = year.yearOfProduction;//int yearOfProductionOfCarToCompare =(obj as Car).yearOfProduction;
                //if(yearOfProductionOfThisCar> yearOfProductionOfCarToCompare)
                //{
                //    return -1;
                //}
                //if (yearOfProductionOfThisCar< yearOfProductionOfCarToCompare)
                //{
                //    return 1;
                //}
                return yearOfProductionOfThisCar.CompareTo(yearOfProductionOfCarToCompare);
            }
            return yearOfProduction;
        }

        public override string ToString()
        {
            return string.Format("{0}",yearOfProduction);//("Car model is {0}, yearOfProduction is {1}, color is {2}", model, yearOfProduction, color);
        }




    }

}
