using System;

namespace PMC.PointModels
{
    /// <summary>
    /// Generic interface of point
    /// </summary>
    public interface IPoint<T>
    {
        /// <summary>
        /// Prints coordinates.
        /// </summary>
        void Print();
    }
}
