using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy_hw1
{
    public static class Item27_var
    {
        public static void Practice()
        {
            Console.WriteLine("예제: " + typeof(Item27_var).Name);
            //암시적으로 형식화 된 변수는 한번에 여러개 선언불가
            //var v1, v2, v3, v4;
            //암시적으로 형식화 된 변수는 선언 즉시 초기화 해야 한다.
            /*var v1;
            var v2;
            var v3;
            var v4;*/
            var v1 = 1;
            var v2 = 12.5f;
            var v3 = "I'm v3 that is var type.";
            var v4 = new List<string>{ "string 1", "string 2", "string 3" };
            var v = new List<object>{ v1, v2, v3, v4 };
            int i = 0;

            foreach(var temp in v)
            {
                string strTemp = temp.ToString();
                if (temp.GetType().Name.Contains("List"))
                {
                    strTemp = "{";
                    foreach (string item in (List<string>)temp)
                        strTemp += item + ", ";
                    strTemp += "\b\b}";

                }

                Console.WriteLine("\"v{0}\" whose type is \"{1}\", equal to \"{2}\". ", i++, temp.GetType().Name, strTemp);
            }
            


        }
    }
}
