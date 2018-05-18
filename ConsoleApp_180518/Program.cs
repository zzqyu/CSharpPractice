using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_180518
{
    class Program
    {
        static void _Main(string[] args)
        {
            ArrayList myAL = new ArrayList();
            myAL.Add("Hello");
            myAL.Add("world");
            myAL.Add("!");


            Console.WriteLine("Count:    {0}", myAL.Count);
            Console.WriteLine("Capacity: {0}", myAL.Capacity);
            Console.WriteLine("Values: ");
            PrintValues(myAL);
        }
        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object o in myList)
                Console.Write(" {0}", o);
            Console.WriteLine();
        }
    }
}
