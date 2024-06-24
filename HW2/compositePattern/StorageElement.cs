using HW2.Charts;
using System;

namespace HW2.compositePattern
{
    internal abstract class StorageElement : sub
    {


        public abstract long getSize();
        public abstract string getName();


        internal abstract string getPath();
    }
}
