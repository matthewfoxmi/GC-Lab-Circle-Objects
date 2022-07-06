using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab_Circle_Objects
{
    internal class Circle
    {
        //properties
        public double radius;
        //public double area;
        //public double circumference;


        //constructor
        public Circle(double _radius)
        {
            radius = _radius;

        }

        //methods

        public double CalculateCircumference()
        {
            return 2 * (Math.PI * radius);
        }

        public string CalculateFormattedCircumference()
        {
            string formattedCircumference = FormatNumber(CalculateCircumference());
            return formattedCircumference; ;
        }

        public double CalculateArea()
        {   
            double area = Math.PI * radius * radius;
            return area;
                
        }

        public string CalculateFormattedArea()
        {
            string formattedArea = FormatNumber(CalculateArea());
            return formattedArea;
        }


        private string FormatNumber(double x)
        {
            //use for calculations
            return Math.Round(x,2).ToString();
        }
    }
}
