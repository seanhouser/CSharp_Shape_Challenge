using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldcastleChallenge
{
    class Circle : IShape
    {
/*
    * ======
    * FIELDS
    * ======
*/
        double circle_radius;       // radius of the circle
        double circle_diameter;     // diameter of the circle
        double area;                // area of the circle


/*
    * =======
    * METHODS
    * =======
*/
        // Constructor
        public Circle(double radius)
        {
            circle_radius = radius;
            circle_diameter = radius * 2;
            area = Math.PI * (circle_radius * circle_radius);
        }

        // Returns the area of the shape
        public double GetArea()
        {
            return area;
        }
    }
}
