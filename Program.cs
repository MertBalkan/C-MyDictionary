using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> weeks = new MyDictionary<string, int>();
           
            weeks.Add("pzt", 1);
            weeks.Add("sali", 2);
            weeks.Add("cars", 3);
            weeks.Add("pers", 4);
            weeks.Add("cuma", 5);
            weeks.Add("ctesi", 6);
            weeks.Add("pzr", 7);

            for (int i = 0; i < weeks.Lenght; i++)
            {
                Console.WriteLine(weeks.Keys[i] + "->" + weeks.Values[i]);
            }
   
        }
    }
}
