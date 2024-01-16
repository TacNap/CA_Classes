using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Learn a bit more about namespace functionality
namespace CA_Classes
{
    // Classes are simply custom data types
    // ?? Internal ?? 
    internal class Forest
    {
        /* The below shows a number of methods of validation */
        /* 'Property' refers to the uppercase member with get() and set() methods */

        /* Note:
         * PRIVATE can only be accessed by code within the same class - this file.
         * PUBLIC can be accessed by any class.
         * Also, there is a loose-standard order for fields, properties, etc...
         */

        // FIELDS
        private string name;
        private List<string> whiteList = new List<string>
        {
            "Amazon",
            "Lamington",
            "Redwood"

        };
        public string Name
        {
            get { return name; }
            
            // Validation of 'name'.
            // Uses whitelist to check against allowed names.
            set
            {
                if (whiteList.Contains(value))
                {
                    name = value;
                }
                else
                {
                    name = "unknown";
                }
            }
        }

        // Automatic properties! 
        // No need to define even the field.
        // In the background, the field is defined as:
        // private int _trees;
        public int Trees
        {
            get;
            set;
        }
        
        /* Static Fields & Properties.
         *
         */
        private static int forestsCreated;
        public static int ForestsCreated
        {
            get { return forestsCreated; }
            set { forestsCreated = value; }
        }

        /* Note:
         * You can also REMOVE set() entirely, or set it to PRIVATE
         * such that no code outside of this class can set the value
         */

        /* Basic property with validation.
         * 'Area' acts as the gatekeeper for 'area',
         * Allowing only validated values in.
         * get() & set() allow for validation.
         */ 
        public int area; // Presumably this would be private in practice
        public int Area 
        {
            get { return area; }
            set 
            {
                if (value < 0) { area = 0; Console.WriteLine("Floored to 0");  }
                else { area = value; }
            }
        }

        // CONSTRUCTORS
        public Forest(string Name, int Area,  int Trees)
        {
            this.Name = Name;
            this.Area = Area;
            this.Trees = Trees;
            ForestsCreated++;
        }

        // METHODS
        public void Information()
        {
            Console.WriteLine("This is the {0} Forest, featuring {1} trees,\n" +
                "across an area of {2}m^2", Name, Trees, Area);
        }

        // This is stupid and is just for demonstration sake
        // :)
        private void AgeOneYear()
        {
            Trees += 20;
            Area += 10;
        }

        public void AgeX(int years)
        {
            for(int i = 0; i < years; i++)
            {
                AgeOneYear();
            }
            Console.WriteLine("The {0} Forest has been aged {1} year/s.", Name, years);
        }

        // A static method can only access static members
        public static void Overview()
        {
            Console.WriteLine("There are {0} existing Forests.", ForestsCreated);
        }

    }
}
