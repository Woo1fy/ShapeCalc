
namespace ShapeCalcLib
{

    public class Triangle : Shape
    {
        public double ASide { get; private set; }

        public double BSide { get; private set; }

        public double CSide { get; private set; }

        public override double GetShapeArea()
        {
            double s = (ASide + BSide + CSide) / 2;
            return Math.Sqrt(s * (s - ASide) * (s - BSide) * (s - CSide));
        }

        public Triangle(double aSide, double bSide, double cSide)
        {
            if (aSide <= 0 || bSide <= 0 || cSide <= 0)
            {
                throw new ArgumentOutOfRangeException($"Sides of a {nameof(Triangle).ToLower()} must be positive values.");
            }

            ASide = aSide;
            BSide = bSide;
            CSide = cSide;
        }

        public bool IsRightAngled()
        {
            double[] sides = { ASide, BSide, CSide };
            Array.Sort(sides);

            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }
    }
}
