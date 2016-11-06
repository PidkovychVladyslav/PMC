using System;

namespace PMC.PointModels
{
    /// <summary>
    /// Class of 3-dimensional point
    /// </summary>
    /// <typeparam name="T">Takes any numerical types</typeparam>
    /// <seealso cref="PMC.IPoint" />
    public class Point3D<T> : IPoint<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private readonly T x;

        private readonly T y;

        private readonly T z;

        /// <summary>
        /// Initializes a new instance of 3-dimensional point with x.
        /// </summary>
        /// <param name="x_">x-coordinates.</param>
        public Point3D(T x_)
        {
            this.x = x_;
        }

        /// <summary>
        /// Initializes a new instance of 3-dimensional point with x,y.
        /// </summary>
        /// <param name="x_">x-coordinates.</param>
        /// <param name="y_">y-coordinates.</param>
        public Point3D(T x_, T y_)
        {
            this.x = x_;
            this.y = y_;
        }

        /// <summary>
        /// Initializes a new instance of 3-dimensional point with x,y,z.
        /// </summary>
        /// <param name="x_">x-coordinates.</param>
        /// <param name="y_">y-coordinates.</param>
        /// <param name="z_">z-coordinates.</param>
        public Point3D(T x_, T y_, T z_)
        {
            this.x = x_;
            this.y = y_;
            this.z = z_;
        }

        /// <summary>
        /// Prints 3-dimensional point coordinates.
        /// </summary>
        public void Print()
        {
            Console.WriteLine("(x,y,z: {0},{1},{2})", this.x, this.y, this.z);
        }
    }
}
