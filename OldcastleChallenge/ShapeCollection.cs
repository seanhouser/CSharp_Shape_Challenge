using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldcastleChallenge
{
    class ShapeCollection : IShape
    {
/*
    * ======
    * FIELDS
    * ======
*/
        List<IShape> _shapes = new List<IShape>();  // List object to store shapes
        double area = 0;        // the sum of the areas of all shapes in the ShapeCollection object


/*
    * =======
    * METHODS
    * =======
*/
        // Adds a shape object to the List field
        public void AddShape(IShape shape)
        {
            _shapes.Add(shape);
            area += shape.GetArea();
        }

        // Returns the sum of the areas of all shapes in the ShapeCollection object
        public double GetArea()
        {
            return area;
        }

        // Returns true if the IShape object exists in this ShapeCollection object
        public bool Exists(IShape shape)
        {
            bool exists = false;
            foreach (IShape shape_object in _shapes)
            {
                if (shape_object == shape)
                {
                    exists = true;
                }
            }
            return exists;
        }
    }
}
