using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    internal class BucketSort
    {
        public BucketSort(Array elements) {
            int bucketAmount = elements.Length / 10 + 1;
        }
        Bucket[] Buckets
        {
            get
            {
                return this.Buckets;
            }
            set
            {
                foreach (int element in value)
                {
                    int bucketPosition = element / 10;
                    if (this.Buckets[bucketPosition] != null){

                    }
                }
            }
        }
        int test {  get; set; }
    }
}
