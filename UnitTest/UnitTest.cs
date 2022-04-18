using System;
using CalculateAreasDotNet;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void AreaRectangle()
        {
            double res = Program.AreaRectangleOrSquare(2, 2);
            Assert.IsTrue(4 == res);
        }

        [TestMethod]
        public void AreaCircle()
        {
            double res = Program.AreaCircle(2);
            Assert.IsTrue(Math.PI * 2 * 2 == res);
        }

        [TestMethod]
        public void AreaTriangle()
        {
            double res = Program.AreaTriangle(6, 8, 10);
            Assert.IsTrue(24 == res);
        }
    }
}
