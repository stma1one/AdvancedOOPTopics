using Delegates.Delegate;

namespace Delegates
{
    internal class Program
    {
        public static bool Check( int[] arr,int x, DlgBool<int> dlg)
        {
            //return dlg.Invoke(arr,x);
            return dlg(arr, x);
        }

       
        
        static void Main(string[] args)
        {
            DelegateMath Do;
           

            Do= Demo.Add;
            int result = Do(4, 5);
            Console.WriteLine(result);
            Do= Demo.Mul;
            result = Do(4, 5);
            Console.WriteLine(result);

            DlgBool<int> test;
            test= Demo.IsExists;

            int[] arr = { 4, 7, 9, 11 };
            Console.WriteLine(test(arr,9 ));
            test += Demo.IsAllBigger;
            Console.WriteLine(test(arr, 9));
            Console.WriteLine(test(arr,12));

#region What if we could pass method as a Parameter?
            Console.WriteLine(Check(arr, 9, Demo.IsAllBigger));
            Console.WriteLine(Check(arr, 9, Demo.IsExists));


            #endregion

           



        }
    }
}