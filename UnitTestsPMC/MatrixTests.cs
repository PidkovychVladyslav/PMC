using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMC;
using PMC.PointModels;

namespace UnitTestsPMC
{
    [TestClass]
    public class MatrixTests
    {
        Matrix<int> matrix;
        Position<int> position;

        [TestInitialize]
        public void TestInitialize()
        {
            matrix = new Matrix<int>();
            position = new Position<int>();

            for (int i = 0; i < 100; i++)
            {
                position = new Position<int>();
                for (int j = 0; j < 100; j++)
                {
                    position.Add(new Point2D<int>(i,j));
                }
                matrix.Add(position);
            }
        }

        [TestMethod]
        public void MatrixAddTest()
        {
            Point2D<int> p = new Point2D<int>(-1, -1);
            Position<int> ptest = new Position<int>();
            ptest.Add(p);
            matrix.Add(ptest);
            Assert.IsTrue(ptest.Contains(p));
            Assert.IsTrue(matrix.Contains(ptest));
        }

        [TestMethod]
        public void MatrixRemoveTest()
        {
            Point2D<int> p = new Point2D<int>(-1, -1);
            Position<int> ptest = new Position<int>();
            ptest.Add(p);
            matrix.Add(ptest);
            matrix.Remove(ptest);
            Assert.IsFalse(matrix.Contains(ptest));
        }

        [TestMethod]
        public void MatrixCountTest()
        {

            Point2D<int> p = new Point2D<int>(-1, -1);
            Position<int> ptest = new Position<int>();
            ptest.Add(p);
            matrix.Add(ptest);
            int count = matrix.Count;
            matrix.Add(ptest);
            Assert.AreEqual(count, matrix.Count - 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DifferentPositionsTest()
        {
            Point1D<int> p = new Point1D<int>(1);
            Position<int> ptest = new Position<int>();
            ptest.Add(p);
            matrix.Add(ptest);
        }
    }
}
