using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldcastleChallenge
{
    class Rectangle : IShape
    {
/*
    * ======
    * FIELDS
    * ======
*/
        double rectangle_length;    // length of the rectangle
        double rectangle_width;     // width of the rectangle
        double area;                // area of the rectangle


/*
    * =======
    * METHODS
    * =======
*/
        // Constructor
        public Rectangle(double r_length, double r_width)
        {
            rectangle_length = r_length;
            rectangle_width = r_width;
            area = rectangle_width * rectangle_length;
        }

        // Returns the area of the shape
        public double GetArea()
        {
            return area;
        }
    }
}
