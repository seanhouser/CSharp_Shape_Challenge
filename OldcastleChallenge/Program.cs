using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldcastleChallenge
{
    class Program
    {
/*
    * ================
    * MAIN ENTRY POINT
    * ================
*/
        static void Main(string[] args)
        {
            // Create a new ShapeCollection object to store all shapes and maintain sum of areas
            ShapeCollection _shapes = new ShapeCollection();

            // Display the menu. Capture and store user selection, loop until exit option or illegal option selected
            int selection = RetrieveSelection();
            while (selection >= 1 && selection <= 3)
            {
                // Collect shape dimensions and implement new object based on user selection. Print the area of the shape
                IShape shape = BuildShape(selection);
                Console.WriteLine("The area of your shape is: " + shape.GetArea());

                // Add the new shape object to the ShapeCollection object. Print the current total area
                if (shape != _shapes)   // Prevent a collection from being added to itself
                {
                    _shapes.AddShape(shape);
                }
                Console.WriteLine("The sum of all the areas of all shapes is: " + _shapes.GetArea() + "\n");

                // Display the menu and capture next user selection
                selection = RetrieveSelection();
            } 
            Console.WriteLine("Now exiting");
        }


/*
    * ===============
    * UTILITY METHODS
    * ===============
*/
        // Prints the menu and returns user selection after checking it is a valid choice
        static int RetrieveSelection()
        {
            Console.WriteLine("Make your selection:\n1) Triangle\n2) Rectangle\n3) Circle\n4) Exit");
            string str_selection = Console.ReadLine();
            if (str_selection == "1" || str_selection == "2" || str_selection == "3")
            {
                int int_selection = int.Parse(str_selection);
                return int_selection;
            }
            else
            {
                return -99;
            }
        }


/*
    * ===========================
    * OBJECT CONSTRUCTION METHODS
    * ===========================
*/
        // Collects dimensions from the user and builds and returns a new shape
        static IShape BuildShape(int selection)
        {
            IShape shape = new Circle(0);
            double dimension1;
            double dimension2;

            // Based on the user selection, accept appropriate dimensions. Create and return the selected shape object
            switch (selection)
            {
                // Triangle
                case 1:
                    Console.WriteLine("Please Enter the base of the triangle");
                    dimension1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Please Enter the height of the triangle");
                    dimension2 = double.Parse(Console.ReadLine());
                    shape = new Triangle(dimension1, dimension2);
                    break;

                // Rectangle
                case 2: 
                    Console.WriteLine("Please Enter the length of the rectangle");
                    dimension1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Please Enter the width of the rectangle");
                    dimension2 = double.Parse(Console.ReadLine());
                    shape = new Rectangle(dimension1, dimension2);
                    break;
                
                // Circle
                case 3:
                    // Request radius or diameter and confirm valid selection
                    double dimension = 0;
                    Console.WriteLine("Would you like to enter the radius or diameter?\n1) Radius\n2) Diameter");
                    string str_selection = Console.ReadLine();
                    if (str_selection == "1" || str_selection == "2")
                    {
                        int circle_selection = int.Parse(str_selection);
                        switch (circle_selection)
                        {
                            // Based on the user selection, always create a Circle object using the radius of the circle
                            case 1:
                                Console.WriteLine("Please enter the radius of the circle: ");
                                dimension = double.Parse(Console.ReadLine());
                                break;
                            case 2:
                                Console.WriteLine("Please enter the diameter of the circle: ");
                                dimension = double.Parse(Console.ReadLine()) / 2;
                                break;
                        }
                        shape = new Circle(dimension);
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice");
                    }
                    break;
            }
            return shape;     
        }
    }
}
