using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldcastleChallenge
{
    class Triangle : IShape
    {
/*
    * ======
    * FIELDS
    * ======
*/
        double triangle_base;       // base of the triangle
        double triangle_height;     // height of the triangle
        double area;                // area of the triangle


/*
    * =======
    * METHODS
    * =======
*/
        // Constructor
        public Triangle(double t_base, double t_height)
        {
            triangle_base = t_base;
            triangle_height = t_height;
            area = (triangle_height * triangle_base) / 2;
        }

        // Returns the area of the shape
        public double GetArea()
        {
            return area;
        }

    }
}
