using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
namespace CS7._0_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string arg = Console.ReadLine();

            var (sum, count) = T_F(Strings.Split(arg, " "));
            Console.WriteLine($"Sum : {sum},Count : {count}");


            (int sum, int count) T_F(string[] values)
            {
                var r = (s:0,c:0);
                foreach(var v in values)
                {
                    /* r.s += int.Parse(v);
                     r.c++;*/
                    add(int.Parse(v), 1);
                }


                void add(int s, int c) { r.s += s; r.c += c; }

                return r;
            }
        }
    }
}
