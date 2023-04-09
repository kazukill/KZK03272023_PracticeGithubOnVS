using KZK03272023_PracticeGithubOnVS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KZK03272023_PracticeGithubOnVS
{
    class Program
    {
        static void Main(string[] args)
        {


            //var kazukiPerson = new PersonModel() { Name = "Kazuki", Age = 19, HairColor = "Dark Blue" };
            //var waiterOccupation = new OccupationModel() { Name = "Waiter", Description = "Serves food to the customers.", Type = "Full Time" };

            //Creates Persons
            var personList = new List<PersonModel>()
            {
                new PersonModel() { 
                    Name = "Kazuki", 
                    Age = 19, 
                    HairColor = "Dark Blue", 
                    Occupation = new OccupationModel() { 
                        Name = "Waiter", 
                        Description = "Serves food to the customers.", 
                        Type = "Full Time" 
                    }
                },
                new PersonModel() { 
                    Name = "Yui", 
                    Age= 18, 
                    HairColor = "Pink",
                    Occupation = new OccupationModel() { 
                        Name = "Student", 
                        Description = "Goes to school.", 
                        Type = "Does not Apply"
                    }
                }
            };

            //Creates Occupations
            var occupationList = new List<OccupationModel>()
            {
                new OccupationModel() { 
                    Name = "Waiter", 
                    Description = "Serves food to the customers.", 
                    Type = "Full Time" 
                },
                new OccupationModel() { Name = "Student", 
                    Description = "Goes to school.", 
                    Type = "Does not Apply"
                }
            };


            foreach (var person in personList)
            {
                Console.WriteLine("Name: " + person.Name + 
                    "\nAge: " + person.Age + 
                    "\nHair Color: " + person.HairColor +
                    "\nOccupation: " + person.Occupation.Name);
                Console.WriteLine();
            }
            Console.ReadLine();

            //Console.WriteLine("Hello World");
            //useCalculator();

            //ADDED COMMENT!!!
            //ADDED COMMENT2!!
            //Add directly to master remote comment
            //Add directly to master remote comment 2
            //RYN CHANGE!!
            //try git fetch
            //try git pull origin master on master branch
        }

        static void useCalculator()
        {
            int x = Calculator.Addition(1, 1);
            Console.WriteLine("1 + 1 = " + x);

            int y = Calculator.Subtraction(1, 1);
            Console.WriteLine("1 - 1 = " + y);

            int z = Calculator.Multiply(3, 2);
            Console.WriteLine("3 * 2 = " + z);

            int v = Calculator.Divide(6, 2);
            Console.WriteLine("6 / 2 = " + v);

            int b = Calculator.Modulo(7, 2);
            Console.WriteLine("7 % 2 = " + b);

            //Line Added By Derp
            //potato
            int c = Calculator.Addition(3, 5);
            Console.WriteLine("3 + 5 = " + c);
            Console.ReadLine();
        }
    }
}
