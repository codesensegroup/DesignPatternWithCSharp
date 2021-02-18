using System.Collections.Generic;

namespace Template.Abstract
{
    public abstract class SortAlgorithm<T>
    {

        protected List<T> SortSets;

        public SortAlgorithm(List<T> sortSets)
        {
            this.SortSets = sortSets;
        }

        public void Run()
        {
            SortSets = Sort(SortSets);
            OutResult();
        }

        protected abstract List<T> Sort(List<T> sort);
        protected abstract void OutResult();
    }
}
