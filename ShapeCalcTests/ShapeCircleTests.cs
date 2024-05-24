using ShapeCalcLib;

namespace ShapeCalcTests
{
    [TestClass]
    public class ShapeCircleTests
    {
        [TestMethod]
        public void Circle_WithValidRadius_GetShapeArea()
        {
            double radius = 5;
            double expected = 78.5;
            Circle circle = new Circle(radius);

            double actual = circle.GetShapeArea();

            Assert.AreEqual(expected, actual, 0.1, $"{nameof(Circle)} area is not calculated correctly");
        }
    }
}