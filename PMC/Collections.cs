using PMC.PointModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMC
{
    /// <summary>
    /// Collection of Points
    /// </summary>
    /// <typeparam name="T">Any numeric types</typeparam>
    /// <seealso cref="PMC.Collector{PMC.IPoint}" />
    public class Position<T> : Collector<IPoint> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        /// <summary>
        /// Adds element into collection <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        /// <param name="item">Object to add into collection <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
        /// <exception cref="ArgumentException"></exception>
        public override void Add(IPoint item)
        {
            if(collector.Count!=0)
            {
                if(collector[0].GetType() == item.GetType())
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
        /// <exception cref="ArgumentException"></exception>
        public override void Add(Position<T> item)
        {
            if (collector.Count != 0)
            {
                if (collector[0].First().GetType() == item.First().GetType())
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
        /// <exception cref="ArgumentException"></exception>
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
        /// <exception cref="ArgumentException"></exception>
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
