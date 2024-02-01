    using MindBoxTest.Figure.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace MindBoxTest.Figure.Shapes
{
    public class Triangle : ITriangle
    {
        private double sideA;
        private double sideB;
        private double sideC;

        [Range(0, double.MaxValue)]
        public double SideA
        {
            get => sideA; set
            {
                if (!IsValid(value, sideB, sideC))
                {
                    throw new ArgumentException();
                }
                sideA = value;
            }
        }

        [Range(0, double.MaxValue)]
        public double SideB
        {
            get => sideB; set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException();
                if (!IsValid(sideA, value, sideC))
                {
                    throw new ArgumentException();
                }
                sideB = value;
            }
        }

        [Range(0, double.MaxValue)]
        public double SideC
        {
            get => sideC; set
            {
                if(value <= 0)
                    throw new ArgumentOutOfRangeException();

                if (!IsValid(sideA, sideB, value))
                {
                    throw new ArgumentException();
                }
                sideC = value;
            }
        }

        private bool IsValid(double a, double b, double c)
        {
            if (a + b <= c)
                return false;

            return true;
        }

        public Triangle([Range(0, double.MaxValue)] double a,
            [Range(0, double.MaxValue)] double b,
            [Range(0, double.MaxValue)] double c)
        {
            if (a <= 0)
                throw new ArgumentOutOfRangeException(nameof(a));

            if (b <= 0)
                throw new ArgumentOutOfRangeException(nameof(b));

            if (c <= 0)
                throw new ArgumentOutOfRangeException(nameof(c));

            if (!IsValid(a, b, c))
            {
                throw new ArgumentException();
            }

            sideA = a;
            sideB = b;
            sideC = c;
        }

        public double GetArea()
        {
            var semiPerimeter = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }
    }
}
