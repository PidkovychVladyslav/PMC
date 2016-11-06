using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMC.Collections;
using PMC.PointModels;

namespace PMC.Creator
{
    public class PositionCreator<T> : Creator<Position<T>> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        public override Position<T> Create()
        {
            return new Position<T>();
        }
    }
}
