using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy_hw1
{
    public static class Item21_refout
    {
        public static void Practice()
        {
            Console.WriteLine("예제: " + typeof(Item21_refout).Name);
            int a, b;
            //ref 변수는 초기화 전에 사용 불가
            /*SwapRef(ref a, ref b);
            Console.WriteLine("SwapRef(ref a, ref b)");
            Console.WriteLine("a = {0}, b = {1}", a, b);*/
            a = 0;
            b = 1;
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Swap(a, b);
            Console.WriteLine("Swap(a, b)");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            SwapRef(ref a, ref b);
            Console.WriteLine("SwapRef(ref a, ref b)");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Out(out a, out b);
            Console.WriteLine("Out(out a, out b)");
            Console.WriteLine("a = {0}, b = {1}", a, b);


        }
        private static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        private static void SwapRef(ref int a, ref int b)
        {
            int _a = a, _b = b;
            a = _b;
            b = _a;
        }
        private static void Out(out int a, out int b)
        {
            a = 1;
            b = 10;
        }
        /* // out 키워드는 함수 호출 전 값이 있든 없든 값을 무시하고
         * 함수 내에서 초기화 후 사용해야 한다.
        private static void SwapOut(out int a, out int b)
        {
            int _a = a, _b = b;
            a = _b;
            b = _a;
        }*/
    }
}

