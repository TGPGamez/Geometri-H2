using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_H2.Shapes
{
    public class Square : Shape
    {
        public Square(double a) : base(a, a) { }

        public override double GetCircumference()
        {
            return (A * 2) + (B * 2);
        }

        public override double GetArea()
        {
            return A * B;
        }
    }
}
