using System;
using System.Collections.Generic;
using System.Text;

namespace Fruit_Machine
{
    public class Grid
    {
        string top1;
        string top2;
        string top3;
        string random1;
        string random2;
        string random3;
        string bottom1;
        string bottom2;
        string bottom3;

        public void format()
        {
            string stringer = "==============================";
            Console.SetCursorPosition((Console.WindowWidth - stringer.Length) / 2, Console.CursorTop);
        }
        public void printGrid(string top1, string top2, string top3, string random1, string random2, string random3, string bottom1, string bottom2, string bottom3)
        {
            Console.WriteLine("");
            format();
            Console.WriteLine("==============================");
            format();
            Console.WriteLine("   " + top1 + " " + top2 + " " + top3);
            format();
            Console.WriteLine("==============================");
            format();
            Console.WriteLine(">  " + random1 + " " + random2 + " " + random3 + "  <");
            format();
            Console.WriteLine("==============================");
            format();
            Console.WriteLine("   " + bottom1 + " " + bottom2 + " " + bottom3);
            format();
            Console.WriteLine("==============================");
            format();
            Console.WriteLine("");
            format();
            this.top1 = top1;
            this.top2 = top2;
            this.top3 = top3;
            this.random1 = random1;
            this.random2 = random2;
            this.random3 = random3;
            this.bottom1 = bottom1;
            this.bottom2 = bottom2;
            this.bottom3 = bottom3;

        }

    }
}
