using Delegates.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Anonymous
{
    public class AnonyDemo
    {
        public static bool Check(int[] arr, int x, DlgBool<int> dlg)
        {
            //return dlg.Invoke(arr,x);
            return dlg(arr, x);
        }
        #region Do we really need to declare a method?
        public static void AnonDemo(int[] arr, int x)
        {
            Console.WriteLine(Check(arr, x, delegate (int[] a, int b) { return a[0] == b; }));
        }
        #endregion

        #region Using Lambda makes it more Readble...
        public static void LambdaDemo(int[] arr, int x)
        {
            Console.WriteLine(Check(arr, x, (int[] a, int b) => { return a[0] == b; }));
        }
        
        #endregion
    }
}
