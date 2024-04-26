using Playground;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB11.SortComparison.SortingAlgorithms
{
    internal class BucketList
    {
        List<BucketList> Buckets
        {
            get
            {
                return this.Buckets;
            }
            set
            {
                for(int i = 0; i < 10; i++)
                {
                    this.Buckets.Add();
                }
                this.Buckets = value;
            }
        }
        public IList<int> BucketSort(IList<int> elements)
        {
            //this.Buckets = new Bucket(elements);
            //int biggest = 0;

            //foreach (int element in elements)
            //{
            //    if (biggest < element)
            //    {
            //        biggest = element;
            //    }
            //}
            foreach (int element in elements)
            {
                ChooseBetterName(element);
            }
            return null;
        }
        private int ChooseBetterName(int element)
        {
            int subElement = element / 10;
            int savedValue = element % 10;
            if (subElement != 0)
            {
                this.ChooseBetterName(subElement);
            }
            else
            {
                Bucket bucket = new Bucket;

            }
            for (int subElement = element / 10; subElement + 1 > 0; subElement /= subElement)
            {
                this.ChooseBetterName(element);
                BucketList bucketList = new BucketList();
            }
            return element;
        }
    }
}
