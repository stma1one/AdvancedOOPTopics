using Generics.Collections.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Collections
{
    public static class Demo
    {
        #region LIST
        public static void ListDemo()
        {
            #region Define List
            //Define a list of rectangles
            List<Rectangle> rectangles = new List<Rectangle>();
            Rectangle r1 = new Rectangle() { Length=2, Width=3};
            Rectangle r2 = new Rectangle(2, 3);
            Rectangle r3 = new Rectangle(3, 3);
            Rectangle r4 = new Rectangle(4, 3);
            Rectangle r5 = new Rectangle(5, 3);
            #endregion

            #region Add to List
            //Add rectangles to the list
            rectangles.Add(r1);
            rectangles.Add(r2);
            rectangles.Add(r3);
            rectangles.Add(r4);
            rectangles.Add(r5);
            #endregion

            #region loop through list
            //loop through the list using count and the [] operator

            Console.WriteLine("loop through the list using count and the [] operator");
            for (int i = 0; i < rectangles.Count; i++)
                Console.WriteLine(rectangles[i]);

            Console.WriteLine("Loop through the list using foreach");
            //Loop through the list using foreaach
            foreach (Rectangle r in rectangles)
                Console.WriteLine(r);
            #endregion

            #region Delete from list
            //Delete from a list
            rectangles.Remove(r5);
            rectangles.RemoveAt(0);
            Console.WriteLine("after delete r5 and index 0");
            foreach (Rectangle r in rectangles)
                Console.WriteLine(r);
            #endregion

            #region Update  a list

            //Update an object in a list
            rectangles[0] = r5;
            Console.WriteLine("after placing r5 in index 0");
            foreach (Rectangle r in rectangles)
                Console.WriteLine(r);
            #endregion

            #region transforming list to array and to new list
            //Copy to array
            Rectangle[] recArr = rectangles.ToArray();
            List<Rectangle> list = rectangles.ToList();

            Console.WriteLine("Copied list");
            foreach (Rectangle r in list)
                Console.WriteLine(r);

            Console.WriteLine("Array");
            foreach (Rectangle r in recArr)
                Console.WriteLine(r);
            #endregion

        }
        #endregion

        #region Dictionary
        public static void DictionaryDemo()
        {
            #region Define Dictionary
            //Define a dictinary of names and rectangles
            Dictionary<string, Rectangle> rectangles = new Dictionary<string, Rectangle>();
            Rectangle r1 = new Rectangle(1, 3);
            Rectangle r2 = new Rectangle(2, 3);
            Rectangle r3 = new Rectangle(3, 3);
            Rectangle r4 = new Rectangle(4, 3);
            Rectangle r5 = new Rectangle(5, 3);
            #endregion

            #region Add to Dictionary
            //Add rectangles to the list
            rectangles.Add("r1", r1);
            rectangles.Add("r2", r2);
            rectangles.Add("r3", r3);
            rectangles.Add("r4", r4);
            rectangles.Add("r5", r5);
            #endregion

            #region loop through Dictionary
            //loop through the dictionary using foreach and AsEnumerable()
            Console.WriteLine("loop through the list using count and the [] operator");

            for (int i = 0; i < rectangles.Count; i++)
            {
                Console.WriteLine("{0}:{1}", rectangles.ElementAt(i).Key, rectangles.ElementAt(i).Value);
            }
            
            foreach(var rectangle in rectangles)
            {
                Console.WriteLine("{0}:{1}",rectangle.Key,rectangle.Value);
            }
           foreach (KeyValuePair<string, Rectangle> r in rectangles.AsEnumerable())
            {
                Console.WriteLine("{0}:{1}", r.Key, r.Value);
            }
            #endregion

            #region Retrieve Value from Dictionary
            //Direct find operation based on key!
            Rectangle myR = rectangles["r2"];
            Console.WriteLine("after searching r2:{0}", myR);
            #endregion

            #region Delete from dictionary
            //Delete from a list
            rectangles.Remove("r5");
            Console.WriteLine("after delete r5");
            foreach (KeyValuePair<string, Rectangle> r in rectangles.AsEnumerable())
            {
                Console.WriteLine("{0}:{1}", r.Key, r.Value);
            }
            #endregion

            #region Update an item in Dictionary

            //Update an object in a list
            rectangles["r1"] = r5;
            Console.WriteLine("after placing r5 in key r1");
            foreach (KeyValuePair<string, Rectangle> r in rectangles.AsEnumerable())
            {
                Console.WriteLine("{0}:{1}", r.Key, r.Value);
            }
            #endregion
        }
        #endregion

    }
}
