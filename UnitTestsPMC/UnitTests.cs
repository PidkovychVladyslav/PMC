using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMC;

namespace UnitTestsPMC
{
    [TestClass]
    public class UnitTests
    {
        Matrix<int> matrix;
        Position<int> position = new Position<int>();
        Point2D<int> p1 = new Point2D<int>(2, 3);
        Point2D<int> p2 = new Point2D<int>(3, 3);

        [TestMethod]
        public void PositionAddTest()
        {
            position.Add(p1);
            Assert.IsTrue(position.Contains(p1));
        }
    }
}
