using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy_hw1
{
    public static class Item24_Nullable
    {
        public static void Practice(){
            Console.WriteLine("\n예제: " + typeof(Item24_Nullable).Name);
            int?[] num = { null, 1, -1 };
            foreach (int? i in num)
            {
                Console.Write("This Value of Integer is {0}", i == null ? "null" : i.ToString());
                Console.WriteLine(" and IsPositive = {0}", IsPositive(i) == null ? "NULL" : IsPositive(i).ToString());
            }
        }
        private static bool? IsPositive(int? i)
        {
            return (i > 0) ? true : ((i < 0) ? false : (bool?)null);
        }
    }
}

