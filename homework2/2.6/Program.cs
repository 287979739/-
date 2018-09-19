using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("请输入用户指定数据：");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}的因子有：", n);
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("{0}", i);
                    if (n != i) Console.Write(",");
                }
            }
            Console.Read();
        }
    }
}
