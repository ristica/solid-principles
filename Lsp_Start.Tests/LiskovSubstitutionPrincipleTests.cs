using Lsp_Start.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lsp_Start.Tests
{
    [TestClass]
    public class LiskovSubstitutionPrincipleTests
    {
        [TestMethod]
        public void TestRectangleArea()
        {
            var r = new Rectangle
            {
                Height = 2,
                Width = 3
            };
            Assert.AreEqual(6, AreaCalculator.CalculateArea(r));
        }

        [TestMethod]
        public void TestSquare3X3()
        {
            var s = new Square
            {
                Height = 3
            };

            Assert.AreEqual(9, AreaCalculator.CalculateArea(s));
        }

        [TestMethod]
        public void Test4X5SquareArea()
        {
            Rectangle r = new Square();
            r.Height = 5;
            r.Width = 4;

            // FAILED!!!
            // Assert.AreEqual failed. Expected:<20>. Actual:<16>.
            Assert.AreEqual(20, AreaCalculator.CalculateArea(r));
        }
    }
}
