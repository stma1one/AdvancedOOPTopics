using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Generics
{
    public static class GenericsDemo
    {
        #region As We Know it
        public static bool Exists(int[] arr, int val)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == val)
                    return true;
            }
            return false;
        }
        #endregion
        #region Lets Go GENERICS
        public static T Search<T>(T[] arr, T val)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(val))
                    return arr[i];
            }
            return default;
        }
        #endregion
    }
}
