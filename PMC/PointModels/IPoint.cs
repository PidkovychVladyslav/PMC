using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
