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

            double expectedArea = 6;
            Triangle triangle = new Triangle(a, b, c);

            double actualArea = triangle.GetShapeArea();

            Assert.AreEqual(expectedArea, actualArea, 0.1, "Triangle area is not calculated correctly");
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

            Assert.AreEqual(expected, actual, "Triangle type is not calculated correctly");
        }
    }
}
