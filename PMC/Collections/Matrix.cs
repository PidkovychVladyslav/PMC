using System;

namespace PMC.Collections
{
    /// <summary>
    /// Collection of Positions
    /// </summary>
    /// <typeparam name="T">Any numeric types</typeparam>
    /// <seealso cref="PMC.Collector{PMC.Position{T}}" />
    public class Matrix<T> : Collector<Position<T>> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        /// <summary>
        /// Adds element into collection <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        /// <param name="item">Object to add into collection <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
        /// <exception cref="ArgumentException">Throws exception while trying to add Position of another type</exception>
        public override void Add(Position<T> item)
        {
            if (collector.Count != 0)
            {
                if (collector[0][0].GetType() == item[0].GetType())
                {
                    collector.Add(item);
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            else
            {
                collector.Add(item);
            }
        }
    }
}
