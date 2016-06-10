using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name:");
            string userEnterWord = Console.ReadLine();
            Console.WriteLine("Hi: {0}.", userEnterWord);


            int EnteredDigit = 0;
            bool UserEnterDigit = false;
            Console.WriteLine("##########################_1-part_#################################");

            do
            {
                Console.WriteLine("Enter digit from 0 - 100:");
                UserEnterDigit = int.TryParse(Console.ReadLine(), out EnteredDigit);
                if (UserEnterDigit == false)
                {
                    Console.WriteLine("Please try again");
                }  
            }
            while (UserEnterDigit == false);
            
            if ((EnteredDigit < 0) || (EnteredDigit > 100))
            {
               Console.WriteLine("Enter digit ONLY from 0 - 100.");
               Console.ReadKey();
               Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("You entered: {0}", EnteredDigit);
                if ((EnteredDigit % 3 == 0) && (EnteredDigit % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (EnteredDigit % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (EnteredDigit % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine("Try next time");
                }
            }
            Console.WriteLine("################################_2-part_##########################################");

            for (int j = 0; j <=90; j ++) // if j <= 100, console dosen't display all text
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("J = {0}", j); 
                if ((j % 3 == 0) && (j % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz", j);
                }
                else if (j % 3 == 0)
                {
                    Console.WriteLine("Fizz", j);
                }

                else if (j % 5 == 0)
                {
                    Console.WriteLine("Buzz", j);
                }
                else
                {
                    Console.WriteLine("*****");
                }
            }
            Console.ReadKey();
        }
    }
}
