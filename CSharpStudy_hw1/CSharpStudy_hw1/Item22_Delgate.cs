using System;
using System.Collections.Generic;delegate void Dlg(string str);


namespace CSharpStudy_hw1
{
    public static class Item22_Delgate
    {
        
        public static void Practice()
        {
            Console.WriteLine("\n예제: " + typeof(Item22_Delgate).Name);
            Practice1();
            Practice2();
            Practice3();
            Practice4();
            Practice5();

        }
        //DelegateChain
        delegate void DelegateChain();
        private static void Practice1()
        {
            Console.WriteLine("예제1");
            DelegateChain delegate1;
            delegate1 = new DelegateChain(Func1);
            delegate1 += Func2;
            delegate1();
        }
        private static void Func1(){ Console.WriteLine("Func1\n");}
        private static void Func2(){ Console.WriteLine("Func2\n");}

        //Callback
        delegate string MyDelegate(Object o);
        private static void Practice2()
        {
            Console.WriteLine("예제2");
            MyDelegate Json = new MyDelegate(ToJson);
            MyDelegate Xml = new MyDelegate(ToXml);
            Item item1 = new Item("홍길동", "서울", 30);
            Console.WriteLine("Object to Json\n"+Serialization(item1, Json));
            Console.WriteLine("Object to Xml\n"+Serialization(item1, Xml));

        }
        private static string Serialization(Object o, MyDelegate dlg)
        {
            return dlg(o);
        }
        private static string ToJson(Object o)
        {
            string answer = "{";
            foreach(var v in o.GetType().GetProperties())
            {
                answer += "\""+v.Name+"\": \"" + v.GetValue(o) + "\", ";
            }
            return answer += "\b\b}";
        }
        private static string ToXml(Object o)
        {
            string answer = "<"+ o.GetType().Name + ">\n";
            foreach (var v in o.GetType().GetProperties())
            {
                answer += "\t<" + v.Name + ">" + v.GetValue(o) + "</" + v.Name + ">\n";
            }
            return answer+= "</" + o.GetType().Name + ">\n";
        }
        private class Item
        {
            public Item(String Name, String Address, int Age)
            {
                this.Name = Name;
                this.Address = Address;
                this.Age = Age;
            }
            public String Name { get; set; }
            public String Address { get; set; }
            public int Age { get; set; }
        }
        //익명함수
        delegate void Dlg3();
        private static void Practice3()
        {
            Console.WriteLine("예제3");
            Dlg3 delegate1 = delegate () { Console.WriteLine("Func1\n"); };
            delegate1();
        }
        //Lambda1
        //delegate void Dlg3();
        delegate int Dlg4(int a, int b);
        private static void Practice4()
        {
            Console.WriteLine("예제4");
            Dlg3 delegate1 = () => Console.WriteLine("I'm Lambda!\n");
            Dlg4 add = null;
            add = (a, b) => a+b;
            delegate1();
            Console.WriteLine("1 + 2 = {0}" , add(1, 2));
        }
        //Lambda2
        delegate void Dlg5(List<int> list);
        private static void Practice5()
        {
            Console.WriteLine("예제5");
            List<int> alist = new List<int> { 5,76,4,3,6,56,54,43,3,76, 0 ,-10};
            Dlg5 printList = delegate (List<int> list)
            {
                Console.Write("aList = {");
                foreach (int i in alist)
                    Console.Write("{0}, ", i);
                Console.WriteLine("\b\b}");
            };
            printList(alist);
            alist.Sort((x, y) => x.CompareTo(y));
            Console.WriteLine("Sort Increasing order");
            printList(alist);
            alist.Sort((x, y) => y.CompareTo(x));
            Console.WriteLine("Sort Decreasing order");
            printList(alist);

        }
    }
}


