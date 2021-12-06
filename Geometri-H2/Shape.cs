using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_H2
{
    public abstract class Shape
    {
        public double A { get; set; }
        public double B { get; set; }

        protected Shape(double a, double b)
        {
            A = a;
            B = b;
        }

        public abstract double GetCircumference();
        public abstract double GetArea();

        public override string ToString()
        {
            return $"Omkreds = {GetCircumference()} | Areal = {GetArea()}";
        }
    }
}
