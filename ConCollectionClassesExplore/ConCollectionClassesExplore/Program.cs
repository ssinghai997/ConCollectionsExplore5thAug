using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConCollectionClassesExplore
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCollection sc = new StringCollection();
            sc.Add("red");
            sc.Add("blue");           
            sc.Add("green");
            sc.Add("yellow");
            sc.Add("brown");

            StringEnumerator se = sc.GetEnumerator();
            Console.WriteLine("---move next method---");
            
            while(se.MoveNext())
            {
                
                Console.WriteLine( se.Current);
            }
            se.Reset();









            


        }
    }
}
