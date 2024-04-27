using System;

namespace MB11.SortComparison.SortingAlgorithms
{
    public class BucketSort2 : SortAlgorithm
    {
        public override string Name => "Bucketsort2";
        public override void Sort(IList<int> arrayToSort)
        {
            var n = arrayToSort.Count;
            var maxValue = arrayToSort.Max();

            var partition = (int)(maxValue / 10)+1;

            IList<int>[] buckets = new IList<int>[partition]; //array von IList
            //MessageBox.Show("" + arrayToSort.Max());
            for (int i = 0; i < partition; i++)
            {
                buckets[i] = new List<int>();
            }

            for (int i = 0; i < n; i++)
            {
                int j = (int)(arrayToSort[i] / 10); 
                buckets[j].Add(arrayToSort[i]);
            }


            int x = 0;

            foreach (var p in buckets)
            {
                foreach (var q in p)

                {
                    arrayToSort[x] = q;
                    x++;
                }
            }

        }
    }
}
