using System;
using System.Collections.Generic;
using Lsp_End.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lsp_End.Tests
{
    [TestClass]
    public class LiskovSubstituionPrincipleTests
    {
        [TestMethod]
        public void TestRectangleArea()
        {
            var r = new Lsp.Rectangle
            {
                Height = 2,
                Width = 3
            };
            Assert.AreEqual(6, r.CalculateArea());
        }

        [TestMethod]
        public void TestSquare3X3()
        {
            var s = new Lsp.Square
            {
                SideLength = 3
            };

            Assert.AreEqual(9, s.CalculateArea());
        }

        [TestMethod]
        public void Test4X5SquareArea()
        {
            Lsp.Shape shapeRectangle = new Lsp.Rectangle
            {
                Width = 4,
                Height = 5
            };

            Lsp.Shape shapeSquare = new Lsp.Square
            {
                SideLength = 3
            };

            Assert.AreEqual(20, shapeRectangle.CalculateArea());
            Assert.AreEqual(9, shapeSquare.CalculateArea());
        }
    }
}