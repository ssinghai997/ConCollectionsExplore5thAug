using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace ConCollectionClassesExplore
{
    class ConStringCollection
    {
        static void Main()
        {
            StringCollection strcoll = new StringCollection();
            strcoll.Add("This");
            strcoll.Add("is");
            strcoll.Add("string");
            strcoll.Add("collection");
            strcoll.Add("demo");

            Console.WriteLine("String Collection");
            foreach (var item in strcoll)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("count of string collection");
            int x = strcoll.Count;
            Console.WriteLine(x);

            Console.WriteLine("****copy to array****");
            string[] str1 = new string[strcoll.Count];
            strcoll.CopyTo(str1, 0);
            foreach (var item1 in str1)
            {
                Console.WriteLine(item1);
            }

            Console.WriteLine("***Add range method***");
            string[] str2 = new string[] { "All", "the", "best"};
            strcoll.AddRange(str2);
            foreach (var item2 in strcoll)
            {
                Console.WriteLine(item2);
            }

            Console.WriteLine("contains method");
            bool x1 = strcoll.Contains("collection");
            Console.WriteLine(x1);

            strcoll.Insert(5, "dear");
            foreach (var item3 in strcoll)
            {
                Console.WriteLine(item3);
            }


           bool b = strcoll.Equals("dear");
            Console.WriteLine("equals 'dear':{0}",b);


            Type t = strcoll.GetType();
            Console.WriteLine(t);

            Console.WriteLine("remove element at index 1");
            strcoll.RemoveAt(1);
            foreach (var item4 in strcoll)
            {
                Console.WriteLine(item4);
            }
            


        }
    }
}
