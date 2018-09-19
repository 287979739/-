using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";

            Console.Write("请从键盘上输入第一个数: ");
            s = Console.ReadLine();
            double a = Int32.Parse(s);
            Console.Write("请从键盘上输入第一个数: ");
            s = Console.ReadLine();
            double b = Int32.Parse(s);
            double product = a * b;
            Console.Write("两数积为: " + product);
        }
    }
}
