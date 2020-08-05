using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;

namespace ConCollectionClassesExplore
{
    class ConListDictionary
    {
        static void Main()
        {
            ListDictionary listDictionary = new ListDictionary();
            listDictionary.Add(1, "Aron");
            listDictionary.Add(2, "Smith");
            listDictionary.Add(3, "Ray");
            listDictionary.Add(4, "Todd");
            listDictionary.Add(5, "James");



            Console.WriteLine("List dictionary items");
            foreach (DictionaryEntry de in listDictionary)
            {
                Console.WriteLine("{0} = {1}", de.Key, de.Value);
            }



            bool bb = listDictionary.Contains(7);
            Console.WriteLine("Contains the key 7 in the list or not:{0}", bb);



            Console.WriteLine("Printing the element list using GetEnumerator method-----");
            IDictionaryEnumerator ide = listDictionary.GetEnumerator();
            DictionaryEntry dde;
            while (ide.MoveNext())
            {
                dde = (DictionaryEntry)ide.Current;
                Console.WriteLine("{0} = {1}", dde.Key, dde.Value);
            }



            DictionaryEntry[] arr = new DictionaryEntry[listDictionary.Count];
            listDictionary.CopyTo(arr, 0);
            Console.WriteLine("Printing the Copied Array");
            foreach (var arr1 in arr)
            {
                Console.WriteLine("{0}-->{1}", arr1.Key, arr1.Value);
            }
            listDictionary.Remove(4);
            Console.WriteLine("List Printing after removing the element from the index 4");
            foreach (DictionaryEntry item2 in listDictionary)
            {
                Console.WriteLine("{0} --> {1}", item2.Key, item2.Value);
            }
        }
    }
}
