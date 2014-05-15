using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemoGUI
{
    class Triangle : GeometricFigure
    {
        // constructor
        public Triangle(double h, double w)
            : base(h, w)
        { } // end constructor

        // definition of abstract method
        public override double ComputeArea()
        {
            return (Height * Width * 0.5);
        }
    }
}
