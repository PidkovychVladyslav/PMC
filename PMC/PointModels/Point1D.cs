using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMC.PointModels
{
    /// <summary>
    /// Class of 1-dimensional point
    /// </summary>
    /// <typeparam name="T">Any numerical types</typeparam>
    /// <seealso cref="PMC.IPoint" />
    public class Point1D<T> : IPoint where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private readonly T x;

        /// <summary>
        /// Initializes a new instance of 1-dimensional point with x.
        /// </summary>
        /// <param name="x_">x-coordinates.</param>
        public Point1D(T x_)
        {
            this.x = x_;
        }

        /// <summary>
        /// Prints 1-dimensional point coordinates.
        /// </summary>
        public void Print()
        {
            Console.WriteLine("(x: {0})", x);
        }
    }
}
