namespace MB11.SortComparison.SortingAlgorithms
{
    public class BucketSort : SortAlgorithm
    {
        public override string Name => "BucketSort";
        public override void Sort(IList<int> arrayToSort)
        {
            var n = arrayToSort.Count;

            IList<int>[] buckets = new IList<int>[31];
            for (int i = 0; i < 31; i++)
            {
                buckets[i] = new List<int>();
            }

            for (int i = 0; i < n; i++)
            {
                int j = (int)(arrayToSort[i] / 10);
                buckets[j].Add(arrayToSort[j]);
            }

            for (int i = 0; i < n; i++)
            {
                foreach (IList<int> bucket in buckets)
                {
                    arrayToSort[i] = bucket[i];
                }
            }
        }




        private void BubbleSort(IList<int> arrayToSort)
        {
            var swapMade = true;
            var n = arrayToSort.Count - 1;
            for (var i = 0; i < n && swapMade; i++)
            {
                swapMade = false;

                for (var j = n; j > i; j--)
                {
                    var num1 = arrayToSort[j - 1];
                    var num2 = arrayToSort[j];
                    if (num1 > num2)
                    {
                        SwapItems(arrayToSort, j - 1, j);
                        swapMade = true;
                    }
                }
            }
        }

        private void SwapItems(IList<int> arrayToSort, int index1, int index2)
        {
            //int temp = arrayToSort[index1];
            //arrayToSort[index1] = arrayToSort[index2];
            //arrayToSort[index2] = temp;

            var temp = arrayToSort[index1];
            arrayToSort[index1] = arrayToSort[index2];
            arrayToSort[index2] = temp;
        }
    }
}
