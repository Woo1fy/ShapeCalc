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
            double expectedArea = 78.5;
            Circle circle = new Circle(radius);

            double actualArea = circle.GetShapeArea();

            Assert.AreEqual(expectedArea, actualArea, 0.1, "Shape area is not calculated correctly");
        }
    }
}