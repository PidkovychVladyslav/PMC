using PMC.PointModels;
using System;
using System.Collections.Generic;

namespace PMC.Collections
{
    /// <summary>
    /// Collection of Points
    /// </summary>
    /// <typeparam name="T">Any numeric types</typeparam>
    /// <seealso cref="PMC.Collector{PMC.IPoint}" />
    public class Position<T> : Collector<IPoint<T>> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        /// <summary>
        /// Adds element into collection <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        /// <param name="item">Object to add into collection <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
        /// <exception cref="ArgumentException">Throws exception while trying to add Point of another type</exception>
        public override void Add(IPoint<T> item)
        {
            if (collector.Count != 0)
            {
                if (collector[0].GetType() == item.GetType())
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

        /// <summary>
        /// Creates collection of Points.
        /// </summary>
        public override void Create()
        {
            collector = new List<IPoint<T>>();
        }
    }
}
