using HW2.compositePattern;
using System.Collections.Generic;


namespace HW2.Charts
{
    internal class concreteSub : sub
    {
        private List<StorageElement> subjectState;
        public List<StorageElement> subState
        {
            get { return subjectState; }
            set { subjectState = value; }

        }
    }
}
