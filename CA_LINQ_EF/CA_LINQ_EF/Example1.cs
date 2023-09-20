using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_LINQ_EF
{
    internal class Example1
    {
        static void Main(string[] args)
        {
            int[] Data = new int[] { 30, 10, 50, 83, 26, 75, 23, 24, 80, 78, 90, 55 };
            var ResultQuery = from X in Data select X;
            var EVQuery= from X in Data where X%2==0 select X;
            foreach( var a in ResultQuery ) {
            Console.Write(a+" ");}
            Console.WriteLine("\n Even Numbers");
            foreach (var X in EVQuery) { 
            Console.Write(X+" ");}
            Console.WriteLine("\n Count of Even Numbers is" + EVQuery.Count());
            Console.WriteLine("\n Sum of Even Numbers is" + EVQuery.Sum());
        }
    }
}
