using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class DataCollection<T>
    {
        private T[] arrData;
        private int numData;
        const int MAX = 1000;
        public DataCollection()
        {
            this.arrData = new T[MAX];
            this.numData = 0;
        }

        public void Add(T p)
        {
            if (this.numData < MAX)
            {
                this.arrData[numData++] = p;
            }
        }
    }
}
