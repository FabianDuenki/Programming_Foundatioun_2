using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    internal class Bucket
    {
        public Bucket(List<int> elements) {
            Elements = elements;
        }
        List<int> Elements {
            get
            {
                return this.Elements;
            }
            set
            {
                foreach (int element in value)
                {
                    int index = element / 10;
                    this.Elements.
                }
            }
        }
    }
}
