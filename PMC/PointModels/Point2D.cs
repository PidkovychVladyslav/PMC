using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMC.PointModels
{
    /// <summary>
    /// Class of 2-dimensional point
    /// </summary>
    /// <typeparam name="T">Takes any numerical types</typeparam>
    /// <seealso cref="PMC.IPoint" />
    public class Point2D<T> : IPoint where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private readonly T x;

        private readonly T y;


        /// <summary>
        /// Initializes a new instance of 2-dimensional point with x.
        /// </summary>
        /// <param name="x_">x-coordinates.</param>
        public Point2D(T x_)
        {
            this.x = x_;
        }

        /// <summary>
        /// Initializes a new instance of 2-dimensional point with x,y.
        /// </summary>
        /// <param name="x_">x-coordinates.</param>
        /// <param name="y_">y-coordinates.</param>
        public Point2D(T x_, T y_)
        {
            this.x = x_;
            this.y = y_;
        }

        /// <summary>
        /// Prints 2-dimensional point coordinates.
        /// </summary>
        public void Print()
        {
            Console.WriteLine("(x,y: {0},{1})", x, y);
        }
    }
}
