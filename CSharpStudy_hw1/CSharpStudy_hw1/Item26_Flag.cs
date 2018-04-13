using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy_hw1
{
    public static class Item26_Flag
    {
        [Flags]
        enum Days
        {
            None = 0x0, Sunday = 0x1, Monday = 0x2, Tuesday = 0x4,
            Wednesday = 0x8, Thursday = 0x10, Friday = 0x20, Saturday = 0x40
        }
        public static void Practice(){
            Console.WriteLine("\n예제: " + typeof(Item26_Flag).Name);
            SetAlarm(Days.Monday|Days.Tuesday);
            SetAlarm((Days)0x7f);
        }
        private static void SetAlarm(Days days)
        {
            Console.WriteLine("알람이 울리는 요일은 " + days.ToString());
        }
    }
}