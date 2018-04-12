using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        struct Schedule
        {
            public int dayOfMonth;
            public string task;

            public Schedule(int i, string s)
            {
                dayOfMonth = i;
                task = s;
            }
        }

        public static void Main()
        {
            Schedule[] ourSchedule =
                new[]
                {
                    new Schedule(1, "Jog"),
                    new Schedule(3, "breakfast"),
                    new Schedule(6, "pet dog"),
                    new Schedule(15, "rest1"),
                    new Schedule(22, "sing opera"),
                    new Schedule(31, "rest2")
                };

            var week1Summary = from s in ourSchedule
                               where s.dayOfMonth >  0
                               where s.dayOfMonth <= 7
                               select s.task + " + dogs";

            var week3Summary = ourSchedule
                                 .Where(s => s.dayOfMonth >  14)
                                 .Where(t => t.dayOfMonth <= 21)
                                 .Select(s => s.task + " + cats");

            foreach (var t in week1Summary)
            {
                Console.WriteLine(t);
            }
            
            foreach (var t in week3Summary)
            {
                Console.WriteLine(t);
            }
        }
    }
}
