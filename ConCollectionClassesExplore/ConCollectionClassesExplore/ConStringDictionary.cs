using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConCollectionClassesExplore
{
    class ConStringDictionary
    {
        static void Main()
        {
            StringDictionary strdict = new StringDictionary();
            strdict.Add("One", "first");
            strdict.Add("Two", "second");
            strdict.Add("Three", "third");
            strdict.Add("Four", "fourth");
            strdict.Add("Five", "fifth");

            foreach (DictionaryEntry v in strdict)
            {
                Console.WriteLine(v.Key +":"+ v.Value);
            }

            Console.WriteLine("contains key One :{0}",strdict.ContainsKey("One"));

            Console.WriteLine("containe value 'second': {0}", strdict.ContainsValue("second"));


            Console.WriteLine("remove key------");
            strdict.Remove("three");
            foreach (DictionaryEntry v1 in strdict)
            {
                Console.WriteLine(v1.Key +":"+ v1.Value);
            }

            Console.WriteLine("***copyto***");
            DictionaryEntry[] de = new DictionaryEntry[strdict.Count];
            strdict.CopyTo(de, 0);
            foreach (DictionaryEntry v3 in de)
            {
                Console.WriteLine(v3.Key + ":" + v3.Value);
            }

           
        }
    }
}
