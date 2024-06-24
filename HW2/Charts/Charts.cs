using HW2.compositePattern;
using System.Collections.Generic;


namespace HW2.Charts
{
    internal abstract class Charts : Observer
    {
        private List<StorageElement> observerState;
        private concreteSub sub;

        public Charts(concreteSub sub)
        {
            this.sub = sub;
        }

        public override void Update()
        {
            observerState = sub.subState;
            createCharts(observerState);
        }
        public concreteSub Subject
        {
            get { return sub; }
            set { sub = value; }
        }
        public abstract void createCharts(List<StorageElement> observerState);
    }
}
