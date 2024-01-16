using System;

namespace CA_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instatiation of a class
            Forest f = new Forest("Amazon", 32, 100);
            Console.WriteLine(f.Name + " " + f.Trees);

            // Combining user input & set()
            Console.WriteLine("What is the area of the {0} forest?", f.Name);
            int temp = -1;
            while(!int.TryParse(Console.ReadLine(), out temp))
            {
                Console.WriteLine("Value must be an integer greater than 0...");
            }
            f.Area = temp;
            Console.WriteLine(f.Area);



            // Get and Set using Properties
            f.Area = 32; // calls set()
            Console.WriteLine(f.Area); // calls get()

            // Calling methods
            f.Information();
            f.AgeX(3);
            f.Information();

            /* Static Fields and Methods allow you to maintain and display information
             * about the class, and *all* instances contained within.
             * In this case, you can display information about all Forests.
             */
            Console.WriteLine("The number of instanced Forests is: {0}", Forest.ForestsCreated);
            Forest f2 = new Forest("Lamington", 120, 12);
            Forest f3 = new Forest("Redwood", 1200, 1212);
            Console.WriteLine("After creating more Forests..");
            Console.WriteLine("The number of instanced Forests is: {0}", Forest.ForestsCreated);

        }
    }
}