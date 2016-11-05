using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMC
{
    public class Position<T> : Collector<IPoint> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
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

    public class Matrix<T> : Collector<Position<T>> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
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

    public class Container<T> : Collector<Matrix<T>> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
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

    public class Containers<T> : Collector<Container<T>> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
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
