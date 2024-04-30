using System;
using MB11.SortComparison.SortingAlgorithms;

namespace MB11.SortComparison.SortingAlgorithms
{
    public class BucketSort2 : SortAlgorithm
    {
        public override string Name => "Bucketsort2";
        public override void Sort(IList<int> arrayToSort)
        {
            int max = arrayToSort.Max();
            int min = arrayToSort.Min();
            int n = (max - min)/ 10 + 1;

            List<int>[] partitions = new List<int>[n];

            for (int i = 0; i < n; i++)
            {
                partitions[i] = new List<int>();
            }

            foreach (int i in arrayToSort)
            {
                int index = ((int)Convert.ChangeType(i, typeof(int)) - min)/10;
                partitions[index].Add(i);
            }

            int iSorted = 0;
            List<int> sortedBucket = new List<int>();

            foreach (List<int> bucket in partitions)
            {
                if (bucket.Count > 1)
                {
                    sortedBucket = Quicksort.quickSort(bucket, 0, bucket.Count - 1);
                }
                else
                {
                    sortedBucket = bucket;
                }
                foreach (int i in sortedBucket)
                {
                    arrayToSort[iSorted] = i;
                    iSorted++;
                }
            }

            //foreach (List<int> p in partitions)
            //{
            //    foreach (int i in p)
            //    {
            //        arrayToSort[iSorted] = i;
            //        iSorted++;
            //    }
            //}
        }
    }
}
