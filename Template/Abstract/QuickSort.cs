using System;
using System.Collections.Generic;

namespace Template.Abstract
{
    public class QuickSort<T> : SortAlgorithm<T> where T : IComparable<T>
    {
        public QuickSort(List<T> sortSets) : base(sortSets)
        {
        }

        protected override void OutResult()
        {
            Console.WriteLine("QuickSort Result");
            foreach (var item in SortSets)
                Console.WriteLine(item + " ");
        }

        protected override List<T> Sort(List<T> sortSets)
        {
            if (sortSets.Count <= 1) return sortSets;

            int pivotPosition = sortSets.Count / 2;
            T pivotValue = sortSets[pivotPosition];

            sortSets.RemoveAt(pivotPosition);
            
            List<T> smaller = new List<T>();
            List<T> greater = new List<T>();
            
            foreach (T item in sortSets)
            {
                if (item.CompareTo(pivotValue) <= 0 )
                {
                    smaller.Add(item);
                }
                else
                {
                    greater.Add(item);
                }
            }
            var sorted = Sort(smaller);
            sorted.Add(pivotValue);
            sorted.AddRange(Sort(greater));
            return sorted;
        }
    }
}
