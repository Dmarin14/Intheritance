using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInheritanceExcersize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var animals = new List<Animal>();

            Bird bird = new Bird("Cardinal", "Red and Black", 3 ,false, true, true, "Forest" ,false);

            animals.Add(bird);

            Reptile reptile = new Reptile("Red Eyed Crocodile", "Black", 1, true, 6.0, 2.0, "Rainforest", false);

            animals.Add(reptile);

            foreach (var item in animals)
            {
                Console.WriteLine($"----------------Animal Description---------------- {item}");
            }

            Console.ReadLine();
            /*Create an object of your Reptile class\
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
