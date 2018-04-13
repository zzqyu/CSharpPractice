using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy_hw1
{
    public static class Item23_Generics{
        public static void Practice(){
            Console.WriteLine("\n예제: " + typeof(Item23_Generics).Name);
            dynamic a = 0, b = 1;
            Console.WriteLine("a = {0}, b = {1}", a, b);
            GSwap<dynamic>.Swap(ref a, ref b);
            Console.WriteLine("Swap(a, b)\ta = {0}, b = {1}", a, b);
            a = 100.1;
            b = (int)1;
            Console.WriteLine("a = {0}, b = {1}", a, b);
            GSwap<dynamic>.Swap(ref a, ref b);
            Console.WriteLine("Swap(a, b)\ta = {0}, b = {1}", a, b);
        }
        private static class GSwap<T> {
            public static void Swap(ref T a, ref T b){
                T _a = a, _b = b;
                a = _b;
                b = _a;
            }
        }
    }
}


