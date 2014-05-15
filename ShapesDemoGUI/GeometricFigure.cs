// Written by Zack Rosales
// Program for page 486-7, # 6

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemoGUI
{
    abstract class GeometricFigure
    {
        // class attributes
        private double height;
        private double width;

        // constructor
        public GeometricFigure(double h, double w)
        {
            setClass(h, w);
        } // end constructor

        // properties
        public double Height
        {
            get
            {
                return height;
            } // end get
            set
            {
                if (value > 0.0)
                {
                    height = value;
                } // end if
                else
                {
                    height = 0.0;
                } // end else
            } // end set
        } // Height property end
        public double Width
        {
            get
            {
                return width;
            } // end get
            set
            {
                if (value > 0.0)
                {
                    width = value;
                } // end if
                else
                {
                    width = 0.0;
                } // end else
            } // end set
        } // Width property end

        // class set method start
        private void setClass(double h, double w)
        {
            Height = h;
            Width = w;
        } // class set method end

        // abstract method
        public abstract double ComputeArea();
    }
}
