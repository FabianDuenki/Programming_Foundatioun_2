using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    internal class Bucket
    {
        public Bucket(int element) {
            Element = element;
        }
        int Element {
            get
            {
                return this.Element;
            }
            set
            {
                this.Element = value;
            }
        }
    }
}
