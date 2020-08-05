using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Collections;

namespace ConCollectionClassesExplore
{
    class ConHybridDictionary
    {
        static void Main()
        {
            HybridDictionary Dict = new HybridDictionary();

            Dict.Add("One", "first");
            Dict.Add(1, "second");
            Dict.Add("two", "third");
            Dict.Add(2, "fourth");
            Dict.Add("three", "fifth");
            Dict.Add(3, "sixth");



            Console.WriteLine("Number of elements in myDict are :{0} ", Dict.Count);



            Console.WriteLine("copying the HybridDictionary entries to a Array index at the specified index ");
            DictionaryEntry[] Arr = new DictionaryEntry[Dict.Count];
            Dict.CopyTo(Arr, 0);



            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine(Arr[i].Key + " = " + Arr[i].Value);
            }
            Dict.Remove(1);

            Console.WriteLine("Number of elements pairs in Dict are :{0}", Dict.Count);



            Console.WriteLine("-----after removing the values----- ");
            IDictionaryEnumerator myEnumerator = Dict.GetEnumerator();
            while (myEnumerator.MoveNext())
            {
                Console.WriteLine(myEnumerator.Key + " = " + myEnumerator.Value);
            }
            Console.WriteLine("To check whether the HybridDictionary contains 'six'");
            Console.WriteLine(Dict.Contains("six"));

                        
            Console.WriteLine("To check whether the HybridDictionary is read-only.");
            Console.WriteLine(Dict.IsReadOnly);



            Console.WriteLine("To check whether the HybridDictionary is synchronized.");
            Console.WriteLine(Dict.IsSynchronized);



            HybridDictionary Dict1 = new HybridDictionary(false);



            Console.WriteLine(" Adding key/value pairs in Dict ");
            Dict.Add("A", "A");
            Dict.Add("a", "a");
            Dict.Add("B", "B");
            Dict.Add("C", "C");
            Dict.Add("D", "D");
            Dict.Add("d", "d");
            Dict.Add("E", "E");
            Dict.Add("F", "F");

            Console.WriteLine("Displaying the key/value pairs in Dict");



            foreach (DictionaryEntry de in Dict1)
                Console.WriteLine(de.Key + " " + de.Value);



            HybridDictionary Dict2 = new HybridDictionary(true);



            Console.WriteLine(" Adding key/value pairs in Dict ");
            Dict.Add("A", "A");
            Dict.Add("a", "a");
            Dict.Add("B", "B");
           Dict.Add("C", "C");
            Dict.Add("D", "D");
            Dict.Add("d", "d");
            Dict.Add("E", "E");
            Dict.Add("F", "F");
           
            Console.WriteLine("Displaying the key/value pairs in Dict");



            foreach (DictionaryEntry de in Dict2)
                Console.WriteLine(de.Key + " " + de.Value);
           
            HybridDictionary Dict3 = new HybridDictionary(10, false);
            foreach (DictionaryEntry de in Dict3)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }
            //This will throw an exception



            HybridDictionary Dict4 = new HybridDictionary(10, true);
            foreach (DictionaryEntry de in Dict4)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }
        }
    }
}
