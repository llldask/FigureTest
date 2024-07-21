using ConsoleApp5;

namespace TestProject1
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestArea1()
        {
            var result = new Triangle(30, 40, 50).GetArea();
            var expected = 600;
            Equals(result, expected);
        }
        [TestMethod]
        public void TestRectangular()
        {

            var result = new Triangle(30, 40, 50).IsRectangular();
            var expected = true;
            Equals(result, expected);

        }
        [TestMethod]
        public void TestRectangular2()
        {

            var result = new Triangle(7, 10, 15).IsRectangular();
            var expected = false;
            Equals(result, expected);

        }
    }
}
