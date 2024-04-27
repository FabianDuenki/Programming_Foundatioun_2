using System;

namespace MB11.SortComparison.SortingAlgorithms
{
    public class BucketSort3 : SortAlgorithm
    {
        public override string Name => "Bucketsort3";
        public override void Sort(IList<int> arrayToSort)
        {
            int max = arrayToSort.Max();
            int min = arrayToSort.Min();
            int n = max + 1;
            int[] partitions = new int[n];
            int iSorted = 0;

            foreach (int i in arrayToSort){
                partitions[i] = i;
            }

            foreach (int p in partitions)
            {
                if (p != 0)
                {
                    arrayToSort[iSorted] = p;
                    iSorted++;
                }
            }
        }
    }
}
