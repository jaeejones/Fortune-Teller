using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string firstName;
            string lastName;
            int age;
            string color;
            int siblings; Can declare variables here or short cut and use it directly in the code */


            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine();
            Console.WriteLine("***********************************");
            Console.WriteLine();
            Console.WriteLine("Welcome to the Fortune Teller Game");
            Console.WriteLine();
            Console.WriteLine("************************************");

            Console.WriteLine();
            Console.WriteLine("What is your first name?");
            Console.WriteLine("Please enter first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("What is your last name?");
            Console.WriteLine("Please enter last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("What is your age?");
            Console.WriteLine("Please enter your age:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("In what month were you born?");
            Console.WriteLine("Please enter month:");
            string month = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("What is your favorite ROYGBIV color?");
            Console.WriteLine("Please enter color choice or type help for lists of colors:");
             string color = Console.ReadLine();

            if (color.ToLower()=="help") /* an if method is needed here to display the colors that user will need */
            {
                Console.WriteLine("The colors are; red, orange, yellow, green, blue, indigo, or violet.");
                Console.WriteLine("Please enter color choice:");
                Console.ReadLine();
            }

            
            Console.WriteLine();
            Console.WriteLine("How many siblings do you have?");
            Console.WriteLine("Please enter nunber:");
             int siblings = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            /* Will use if statements here*/

            if (userAge % 2 == 1)
            {
                Console.WriteLine(" {0} {1} You will retire in 10 years.", firstName, lastName);
            }
            if( userAge % 2 != 1)
            {
                Console.WriteLine(" {0} {1} You will retire in 20 years.", firstName, lastName);
            }
            Console.WriteLine();
            if (siblings == 0)
            {
                Console.WriteLine("{0} {1} You will live on the St. Thomas Island", firstName, lastName);
            }
            else if (siblings == 1)
            {
                Console.WriteLine(" {0} {1} You will live in Arizona", firstName, lastName);
            }
            else if (siblings == 2)
            {
                Console.WriteLine( " {0} {1} You will live in Canada", firstName, lastName);
            }
            else if (siblings == 3)
            {
                Console.WriteLine(" {0} {1} You will live in Colorado", firstName, lastName);
            }
            else if (siblings >= 4) 
                {
                Console.WriteLine(" {0} {1} You will live in Florida", firstName, lastName);
            }
            
            switch (color) /*using switch statments to practice*/
            {
                case "red":
                    Console.WriteLine("Land Rover");
                    break;
                case "orange":
                    Console.WriteLine("Ford Truck");
                    break;
                case "yellow":
                    Console.WriteLine("Volkswagan Beetle");
                    break;
                case "green":
                    Console.WriteLine("Nissan Leaf");
                    break;
                case "blue":
                    Console.WriteLine("2006 Toyota Camry");
                    break;
                case "indigo":
                    Console.WriteLine("BMW Beamer");
                    break;
                case "violet":
                    Console.WriteLine("Jaguar");
                    break;
                                   
            }
            Console.ReadLine(); 
        }
    }
}
