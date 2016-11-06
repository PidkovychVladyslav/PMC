using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMC.PointModels;
using PMC.Collections;

namespace UnitTestsPMC
{
    [TestClass]
    public class PositionTests
    {
        Point2D<int> p1 = new Point2D<int>(2, 3);
        Point2D<int> p2 = new Point2D<int>(3, 3);
        Position<int> position;

        [TestInitialize]
        public void TestInitialize()
        {
            position = new Position<int>();

            for (int i = 0; i < 100; i++)
            {
                position.Add(new Point2D<int>(i, i));
            }
        }

        [TestMethod]
        public void PositionAddTest()
        {
            position.Add(p1);
            Assert.IsTrue(position.Contains(p1));
        }

        [TestMethod]
        public void PositionRemoveTest()
        {
            position.Add(p1);
            position.Remove(p1);
            Assert.IsFalse(position.Contains(p1));
        }

        [TestMethod]
        public void PositionCountTest()
        {
            int count = position.Count;
            position.Add(p1);
            position.Add(p2);
            Assert.AreEqual(position.Count - 2, count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DifferentPointsTest()
        {
            position.Add(new Point3D<int>(1, 1, 1));
        }
    }
}
