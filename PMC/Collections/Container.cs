using System;
using System.Collections.Generic;

namespace PMC.Collections
{
    /// <summary>
    /// Collection of Matrixes
    /// </summary>
    /// <typeparam name="T">Any numeric types</typeparam>
    /// <seealso cref="PMC.Collector{PMC.Matrix{T}}" />
    public class Container<T> : Collector<Matrix<T>> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        /// <summary>
        /// Adds element into collection <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        /// <param name="item">Object to add into collection <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
        /// <exception cref="ArgumentException">Throws exception while trying to add Matrix of another size</exception>
        public override void Add(Matrix<T> item)
        {
            if (collector.Count != 0)
            {
                if (collector[0].Count == item.Count)
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
