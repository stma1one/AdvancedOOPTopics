using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Delegate
{

    public delegate int DelegateMath(int x, int y);

    public delegate bool DlgBool<T>(T[] arr, T x);

    public delegate void  DlgPrint(string text);

    
    
    public class Demo
    {
        public Action<string> Print;
        public Func<int[], int, bool> DlgFun;
        public static bool IsExists<T>(T[] arr, T val)
        {
            foreach (T x in arr)
            {
                if (x.Equals(val))
                    return true;
            }
            return false;
        }
        public static bool IsAllBigger(int[] arr, int val)
        {
            foreach (int p in arr)
            {
                if (p >= val)
                    return false;
            }
            return true;
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Mul(int x, int y)
        {
            return x * y;
        }
    }
}
