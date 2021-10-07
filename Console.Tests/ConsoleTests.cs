using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Console.Tests
{
    [TestClass]
    public class ConsoleTests
    {
        [TestMethod]
        public void TestSum()
        {
            // Arrange
            int x = 10;
            int y = 20;
            int expected = 30;

            // Act
            SimpleClass obj = new SimpleClass();
            int actual = obj.Sum(x, y);

            // Asssert
            Assert.AreEqual(expected, actual);

        }
    }
}
