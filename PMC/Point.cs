using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMC
{
    public interface IPoint
    {
        void Print();
    }

    public class Point1D<T> : IPoint where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private readonly T x;

        public Point1D(T x_)
        {
            this.x = x_;
        }

        public void Print()
        {
            Console.WriteLine("(x: {0})", x);
        }
    }

    public class Point2D<T> : IPoint where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private readonly T x;

        private readonly T y;

        public Point2D(T x_)
        {
            this.x = x_;
        }

        public Point2D(T x_, T y_)
        {
            this.x = x_;
            this.y = y_;
        }

        public void Print()
        {
            Console.WriteLine("(x,y: {0},{1})", x, y);
        }
    }

    public class Point3D<T>: IPoint where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private readonly T x;

        private readonly T y;

        private readonly T z;

        public Point3D(T x_)
        {
            this.x = x_;
        }

        public Point3D(T x_, T y_)
        {
            this.x = x_;
            this.y = y_;
        }

        public Point3D(T x_, T y_, T z_)
        {
            this.x = x_;
            this.y = y_;
            this.z = z_;
        }

        public void Print()
        {
            Console.WriteLine("(x,y,z: {0},{1},{2})", x, y, z);
        }
    }
}
