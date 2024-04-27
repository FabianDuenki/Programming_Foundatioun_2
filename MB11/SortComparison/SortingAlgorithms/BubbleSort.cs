using System;

namespace MB11.SortComparison.SortingAlgorithms
{
    public class BubbleSort : SortAlgorithm
    {
        public override string Name => "Bubblesort";
        public override void Sort(IList<int> arrayToSort)
        {
            bool swapped = true;
            int upperBound = arrayToSort.Count;

            while (swapped)
            {
                swapped = false;

                for (int i = 0; i < upperBound - 1; i++)
                {
                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        SwapItems(arrayToSort, i, i + 1);
                        swapped = true;
                    }
                }

                upperBound--;
            }
        }

        private void SwapItems(IList<int> arrayToSort, int index1, int index2)
        {
            int temp = arrayToSort[index1];
            arrayToSort[index1] = arrayToSort[index2];
            arrayToSort[index2] = temp;
        }
    }
}
