using System;

namespace MB11.SortComparison.SortingAlgorithms
{
    public class BucketSort1 : SortAlgorithm
    {
        public override string Name => "Bucketsort1";
        public override void Sort(IList<int> arrayToSort)
        {
            // n is the range of numbers in arrayToSort
            int max = arrayToSort.Max();
            int min = arrayToSort.Min();
            int n = max - min + 1;
            List<int>[] partitions = new List<int>[n];

            // create a bucket for each number in the array
            for (int i = 0; i < n; i++)
            {
                partitions[i] = new List<int>();
            }

            // assign a number to it's corresponding bucket
            foreach (int i in arrayToSort)
            {
                // min is substracted to point to the correct index
                int pi = i - min;
                partitions[pi].Add(i);
            }

            // iSorted points to the index in arrayToSort
            int iSorted = 0;

            // iterate through all buckets
            foreach (List<int> p in partitions)
            {
                // iterate through elements of bucket
                foreach (int i in p)
                {
                    arrayToSort[iSorted] = i;
                    iSorted++;
                }
            }
        }
    }
}
