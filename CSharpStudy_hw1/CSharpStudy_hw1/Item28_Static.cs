using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy_hw1
{
    public static class Item28_Static
    {
        public static void Practice(){
            Console.WriteLine("\n예제: " + typeof(Item28_Static).Name);
            StaticClass.StaticFunc();
        }
        private static class StaticClass
        {
            public static void StaticFunc()
            {
                Console.WriteLine("This Function is static.");
            }
        }
    }
}
