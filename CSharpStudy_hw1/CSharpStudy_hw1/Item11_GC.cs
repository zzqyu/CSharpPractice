using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy_hw1
{
    public static class Item11_GC
    {
        private class Item
        {
            public int A { get; set; }
            public Item(int i) { A = i; }
        }
        public static void Practice()
        {
            Console.WriteLine("\n예제: " + typeof(Item11_GC).Name);
            Item i1, i2, i3, i4, i5;
            i1 = new Item(1);
            i2 = new Item(2);
            i4 = new Item(4);
            i5 = new Item(5);
            i3 = i5;
            Item[] iArray1 = { i1, i2, i3, i4, i5 };

            foreach(Item i in iArray1)
            {
                Console.WriteLine("{0} is {1}", i.GetType().Name, i.A);
            }
            i3 = null;
            i5 = i2;
            System.GC.Collect();
            Item[] iArray2 = { i1, i2, i3, i4, i5 };
            foreach (Item i in iArray2)
            {
                Item temp = i ?? new Item(0);
                Console.WriteLine("{0} is {1}", temp.GetType().Name, temp.A==0?"null": temp.A.ToString());
            }

        }
    }
}

