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
            //SortedList<int, int>[] partitions = new SortedList<int, int>[n]; // Optional mit SortedList
            List<int>[] partitions = new List<int>[n];

            for (int i = 0; i < n; i++)
            {
                //partitions[i] = new SortedList<int, int>();
                partitions[i] = new List<int>();
            }
            //Bucket fertig definiert

            foreach (int i in arrayToSort)
            {
                int pi = (int)Convert.ChangeType(i, typeof(int)) - min;
                //partitions[pi].Add(i, i);
                partitions[pi].Add(i);
            }
            //Werte in Bucket schmeissen

            int iSorted = 0;

            //foreach (SortedList<int, int> p in partitions)
            foreach (List<int> p in partitions)
            {
                //foreach (int key in p.Keys)
                foreach (int i in p)
                {
                    //arrayToSort[iSorted++] = p[key];
                    arrayToSort[iSorted] = i;
                    iSorted++;
                }
            }
        }

    }
}
