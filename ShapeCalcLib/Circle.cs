namespace ShapeCalcLib
{
    public class Circle : Shape
    {
        public double Radius { get; private set; }

        public override double GetShapeArea() => Math.PI * Math.Pow(Radius, 2);

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException($"Radius of a {nameof(Circle).ToLower()} must be positive values.");
            }

            Radius = radius;
        }
    }
}
