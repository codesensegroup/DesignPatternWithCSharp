using System;
using System.Collections.Generic;
using System.Linq;

namespace Template.Abstract
{
    public class MergeSort<T> : SortAlgorithm<T> where T : IComparable<T>
    {

        public MergeSort(List<T> sortSets) : base(sortSets)
        {
        }

        protected override void OutResult()
        {
            Console.WriteLine("MerfeSort Result");
            foreach (var item in SortSets)
                Console.WriteLine(item + " ");
        }

        protected override List<T> Sort(List<T> sortSets)
        {
            if (sortSets.Count <= 1)
                return sortSets;

            var left = new List<T>();
            var right = new List<T>();

            int middle = sortSets.Count / 2;

            // Dividing
            for (int i = 0; i < middle; i++)
                left.Add(sortSets[i]);

            for (int i = middle; i < sortSets.Count; i++)
                right.Add(sortSets[i]);

            left = Sort(left);
            right = Sort(right);

            // Merge
            return Merge(left, right);
        }

        private List<T> Merge(List<T> left, List<T> right)
        {
            var result = new List<T>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    //Comparing
                    if (left.First().CompareTo(right.First()) <= 0)
                    {
                        result.Add(left.First());
                        //Rest first element
                        left.Remove(left.First());
                        continue;
                    }

                    result.Add(right.First());
                    right.Remove(right.First());

                    continue;
                }
                if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                    continue;
                }
                if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                    continue;
                }
            }
            return result;
        }
    }
}
