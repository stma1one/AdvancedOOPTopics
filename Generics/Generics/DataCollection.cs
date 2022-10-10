using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Generics
{
    class DataCollection<T>
    {
        private T[] arrData;
        private int numData;
        const int MAX = 1000;
        public DataCollection()
        {
            arrData = new T[MAX];
            numData = 0;
        }

        public void Add(T p)
        {
            if (numData < MAX)
            {
                arrData[numData++] = p;
            }
        }
    }
}
