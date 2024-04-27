using System;

namespace MB11.SortComparison.SortingAlgorithms
{
    public class BucketSort1 : SortAlgorithm
    {
        public override string Name => "Bucketsort1";
        public override void Sort(IList<int> arrayToSort)
        {
            int max = arrayToSort.Max();
            int min = arrayToSort.Min();
            int n = max - min + 1;
            List<int>[] partitions = new List<int>[n];

            for (int i = 0; i < n; i++)
            {
                partitions[i] = new List<int>();
            }

            foreach (int i in arrayToSort)
            {
                int pi = (int)Convert.ChangeType(i, typeof(int)) - min;
                partitions[pi].Add(i);
            }

            int iSorted = 0;

            foreach (List<int> p in partitions)
            {
                foreach (int i in p)
                {
                    arrayToSort[iSorted] = i;
                    iSorted++;
                }
            }
        }
    }
}
