using System.Collections;
using System.Collections.Generic;

namespace PMC.Collections
{
    /// <summary>
    /// Generic abstract class of collection
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="System.Collections.Generic.ICollection{T}" />
    public abstract class Collector<T> : ICollection<T>
    {
        protected List<T> collector;
        private bool isReadOnly;

        /// <summary>
        /// Initializes a new instance of the <see cref="Collector{T}"/> class.
        /// </summary>
        public Collector()
        {
            this.collector = new List<T>();
        }

        /// <summary>
        /// Gets the number of elements contained in the interface <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        public int Count
        {
            get
            {
                return this.collector.Count;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the <see cref = "T: System.Collections.Generic.ICollection`1" /> is available for read-only.
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return this.isReadOnly;
            }
        }

        /// <summary>
        /// Indexer that gets or sets the <see cref="T"/> at the specified index.
        /// </summary>
        /// <value>
        /// <see cref="T"/>.
        /// </value>
        /// <param name="index">Index.</param>
        public T this[int index]
        {
            get { return this.collector[index]; }
            set { this.collector[index] = value; }
        }

        /// <summary>
        /// Adds element into collection <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        /// <param name="item">Object to add into collection <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
        public abstract void Add(T item);

        /// <summary>
        /// Deletes all elements from collection <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        public void Clear()
        {
            this.collector.Clear();
        }

        /// <summary>
        /// Determines whether the collection <see cref="T:System.Collections.Generic.ICollection`1" /> contains specified value.
        /// </summary>
        /// <param name="item">Object needed to be found into <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
        /// <returns>
        /// Value true, if object <paramref name="item" /> is found into <see cref="T:System.Collections.Generic.ICollection`1" />; else — returns false.
        /// </returns>
        public bool Contains(T item)
        {
            return this.collector.Contains(item);
        }

        /// <summary>
        /// Copies elements <see cref="T:System.Collections.Generic.ICollection`1" /> into array <see cref="T:System.Array" />, starting from defined index <see cref="T:System.Array" />.
        /// </summary>
        /// <param name="array">Array <see cref="T:System.Array" />into which copies element of <see cref="T:System.Collections.Generic.ICollection`1" />.Array <see cref="T:System.Array" /> must start indexation from zero.</param>
        /// <param name="arrayIndex">Index that counts from zero into <paramref name="array" />showing begin of copy.</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            this.collector.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// Interface <see cref="T:System.Collections.Generic.IEnumerator`1" /> which can be used to iterate through the collection.
        /// </returns>
        public IEnumerator<T> GetEnumerator()
        {
            return this.collector.GetEnumerator();
        }

        /// <summary>
        /// Removes the first instance of the specified object from the collection <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        /// <param name="item">The object to remove from the collection <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
        /// <returns>
        /// Value true, if element <paramref name="item" /> is succesfully deleted from <see cref="T:System.Collections.Generic.ICollection`1" />, else — returns false.This method also returns false, if the parameter <paramref name = "item" /> can not be found in the source interface <see cref = "T: System.Collections.Generic.ICollection`1" />.
        /// </returns>
        public bool Remove(T item)
        {
            return this.collector.Remove(item);
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// Object <see cref="T:System.Collections.IEnumerator" /> which can be used to iterate through the collection.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.collector.GetEnumerator();
        }
    }
}
