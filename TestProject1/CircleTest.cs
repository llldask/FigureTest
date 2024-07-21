using ConsoleApp5;
namespace TestProject1
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void TestArea1()
        {
            var result = new Circle(10).GetArea();
            var expected = 314.16;
            Equals(result, expected);
        }
      
    }
}