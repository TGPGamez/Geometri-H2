using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_H2.Shapes
{
    public class Triangle : Shape
    {
        public double C { get; set; }

        public Triangle(double a, double b) : base(a, b)
        {
            C = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(B, 2));
        }

        public override double GetCircumference()
        {
            return A + B + C;
        }

        public override double GetArea()
        {
            return 0.5 * A * B;
        }

    }
}
