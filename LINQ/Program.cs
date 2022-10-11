using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;
using LINQ;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i=100;
            #region Extensions Methods
            i.About();
            #endregion


            #region LINQ

            int[] arr = { 4, 7, 8, -24, -5 };
            int[] arr2= arr.Where(x => x > 0).ToArray();
            int sum = arr.Sum(x=>x*x);
            int[] arr3=arr.OrderBy(x=>x).Where(x=>x < 0).ToArray();
            
            #endregion
        }
    }
}