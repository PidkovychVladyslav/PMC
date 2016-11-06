using System;

namespace PMC.Collections
{
    /// <summary>
    /// Collection of Containers
    /// </summary>
    /// <typeparam name="T">Any numeric types</typeparam>
    /// <seealso cref="PMC.Collector{PMC.Container{T}}" />
    public class Containers<T> : Collector<Container<T>> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        /// <summary>
        /// Adds element into collection <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        /// <param name="item">Object to add into collection <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
        /// <exception cref="ArgumentException">Throws exception while trying to add Container of another size</exception>
        public override void Add(Container<T> item)
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
