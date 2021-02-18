using System;
using System.Collections.Generic;
using System.Linq;
using Template.Abstract;

namespace Template
{
    public class MergeSortWithGeneric<T> where T : IComparable<T>
    {
       

        public List<T> Sort(List<T> sort)
        {
            if (sort.Count <= 1)
                return sort;

            var left = new List<T>();
            var right = new List<T>();

            int middle = sort.Count / 2;

            // Dividing
            for (int i = 0; i < middle; i++)
                left.Add(sort[i]);

            for (int i = middle; i < sort.Count; i++)
                right.Add(sort[i]);

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
