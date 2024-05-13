using System;

namespace MB11.SortComparison.SortingAlgorithms
{
    public class BucketSort3 : SortAlgorithm
    {
        public override string Name => "Bucketsort3";
        public override void Sort(IList<int> arrayToSort)
        {
            
        }

        //public override void Sort(IList<int> arrayToSort)
        //{
        //    int max = arrayToSort.Max();
        //    int min = arrayToSort.Min();
        //    int n = max + 1;

        //    int[] sorted = new int[n];
        //    foreach (int i in arrayToSort)
        //    {
        //        sorted[i] = i;
        //    }

        //    //IList<IList<int>> sorted = new List<IList<int>>();
        //    //foreach(int i in arrayToSort)
        //    //{
        //    //    sorted[i].Add(new IList<int>);
        //    //}

        //    int iSorted = 0;

        //    foreach(int i in sorted)
        //    {
        //        if (i != 0)
        //        {
        //            arrayToSort[iSorted] = i;
        //            iSorted++;
        //        }
        //    }
        //}
    }
}
