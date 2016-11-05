using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMC
{
    public abstract class Collector<T>: ICollection<T>
    {
        protected List<T> collector;
        private bool isReadOnly;

        public Collector()
        {
            collector = new List<T>();
        }

        public T this[int index]
        {
            get { return collector[index]; }
            set { collector[index] = value; }
        }

        public abstract void Add(T item);

        public void Clear()
        {
            collector.Clear();
        }

        public bool Contains(T item)
        {
            return collector.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            collector.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return collector.GetEnumerator();
        }

        public bool Remove(T item)
        {
            return collector.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return collector.GetEnumerator();
        }

        public int Count
        {
            get
            {
                return collector.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return isReadOnly;
            }
        }
    }
}
