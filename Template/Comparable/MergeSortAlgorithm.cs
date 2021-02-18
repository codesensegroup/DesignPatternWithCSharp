using System.Collections.Generic;
using System.Linq;

namespace Template
{
    public class MergeSortAlgorithm
    {
        public List<int> Sort(List<int> unsortedSets)
        {
            if (unsortedSets.Count <= 1)
                return unsortedSets;

            var left = new List<int>();
            var right = new List<int>();

            int middle = unsortedSets.Count / 2;

            // Dividing
            for (int i = 0; i < middle; i++)
                left.Add(unsortedSets[i]);

            for (int i = middle; i < unsortedSets.Count; i++)
                right.Add(unsortedSets[i]);

            left = Sort(left);
            right = Sort(right);

            // Merge
            return Merge(left, right);

        }

        private List<int> Merge(List<int> left, List<int> right)
        {
            var result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    //Comparing
                    if (left.First() <= right.First())
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
