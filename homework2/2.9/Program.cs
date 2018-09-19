using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            bool s;
            for (; i < 100; i++)
            {
                s = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        s = false;
                }
                if (s)
                    Console.WriteLine(i.ToString());
            }
        }
    }
}
