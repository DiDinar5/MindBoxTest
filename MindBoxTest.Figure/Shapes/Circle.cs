using MindBoxTest.Figure.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace MindBoxTest.Figure.Shapes
{
    public class Circle : ICircle
    {
        public double Radius { get ; set ; }

        public Circle([Range(0, double.MaxValue)] double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius));

            Radius = radius;
        }


        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
