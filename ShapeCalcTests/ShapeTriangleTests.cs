using ShapeCalcLib;

namespace ShapeCalcTests
{
    [TestClass]
    public class ShapeTriangleTests
    {
        [TestMethod]
        public void Triangle_WithValidSidesValues_GetShapeArea()
        {
            double a = 3;
            double b = 4;
            double c = 5;

            double expected = 6;
            Triangle triangle = new Triangle(a, b, c);

            double actual = triangle.GetShapeArea();

            Assert.AreEqual(expected, actual, 0.1, $"{nameof(Triangle)} area is not calculated correctly");
        }

        [TestMethod]
        public void Triangle_WithValidSidesValues_IsRightAngled()
        {
            double a = 3;
            double b = 4;
            double c = 5;

            bool expected = true;
            Triangle triangle = new Triangle(a, b, c);

            bool actual = triangle.IsRightAngled();

            Assert.AreEqual(expected, actual, $"{nameof(Triangle)} type is not calculated correctly");
        }

        [TestMethod]
        public void Triangle_WithValidSidesValues_IsNotRightAngled()
        {
            double a = 4;
            double b = 5;
            double c = 6;

            bool expected = false;
            Triangle triangle = new Triangle(a, b, c);

            bool actual = triangle.IsRightAngled();

            Assert.AreEqual(expected, actual, $"{nameof(Triangle)} type is not calculated correctly");
        }
    }
}
