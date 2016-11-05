using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D<int> p = new Point3D<int>(3,2,1);
            Point3D<int> p3 = new Point3D<int>(1, 2, 3);
            Position<int> c = new Position<int>();
            Position<int> c1 = new Position<int>();
            Point1D<double> p2 = new Point1D<double>(2.0);
            Matrix<int> m = new Matrix<int>();
            c.Add(p);
            c.Add(p3);
            //c.Add(p2);
            c1.Add(p3);
            c1.Add(p3);
            m.Add(c);
            m.Add(c1);
            c.Contains(p);
            foreach(var item in m)
            {
                for(int i = 0; i< item.Count; i++)
                {
                    item[i].Print();
                }
            }
            Matrix<int> matrix = new Matrix<int>();
            Position<int> position = new Position<int>();

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    position.Add(new Point2D<int>(i, j));
                }
                matrix.Add(position);
            }
            Console.WriteLine(matrix.Count);
        }
    }
}
