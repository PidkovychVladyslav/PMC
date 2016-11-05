using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMC;
using PMC.PointModels;

namespace UnitTestsPMC
{
    [TestClass]
    public class ContainerTests
    {
        Matrix<int> matrix;
        Position<int> position;
        Container<int> container;

        [TestInitialize]
        public void TestInitialize()
        {
            for (int k = 0; k < 5; k++)
            {
                container = new Container<int>();
                matrix = new Matrix<int>();
                for (int i = 0; i < 100; i++)
                {
                    position = new Position<int>();
                    for (int j = 0; j < 100; j++)
                    {
                        position.Add(new Point2D<int>(i, j));
                    }
                    matrix.Add(position);
                }
                container.Add(matrix);
            }
        }

        [TestMethod]
        public void ContainerAddTest()
        {
            Point2D<int> p = new Point2D<int>(-1, -1);
            Position<int> ptest = new Position<int>();
            Matrix<int> mtest = new Matrix<int>();
            ptest.Add(p);
            for(int i = 0; i < 100; i ++)
            {
                mtest.Add(ptest);
            }
            container.Add(mtest);
            Assert.IsTrue(container.Contains(mtest));
        }

        [TestMethod]
        public void MatrixRemoveTest()
        {
            Point2D<int> p = new Point2D<int>(-1, -1);
            Position<int> ptest = new Position<int>();
            Matrix<int> mtest = new Matrix<int>();
            ptest.Add(p);
            for (int i = 0; i < 100; i++)
            {
                mtest.Add(ptest);
            }
            container.Add(mtest);
            container.Remove(mtest);
            Assert.IsFalse(container.Contains(mtest));
        }

        [TestMethod]
        public void MatrixCountTest()
        {

            Point2D<int> p = new Point2D<int>(-1, -1);
            Position<int> ptest = new Position<int>();
            Matrix<int> mtest = new Matrix<int>();
            ptest.Add(p);
            for (int i = 0; i < 100; i++)
            {
                mtest.Add(ptest);
            }
            int count = container.Count;
            container.Add(mtest);
            Assert.AreEqual(count, container.Count - 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DifferentSizeMatrixTest()
        {
            Point2D<int> p = new Point2D<int>(-1, -1);
            Position<int> ptest = new Position<int>();
            Matrix<int> mtest = new Matrix<int>();
            ptest.Add(p);
            mtest.Add(ptest);
            container.Add(mtest);
        }
    }
}
