using PMC.Collections;
using System;

namespace PMC.Creator
{
    public abstract class Creator<T>
    {
        public abstract T Create();
    }
}
