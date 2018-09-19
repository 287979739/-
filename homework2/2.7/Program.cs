using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            Console.WriteLine("请输入十个数：");
            for (int i = 0; i < 10; i++)
            {
                string s = Console.ReadLine();
                int x = int.Parse(s);
                num[i] = x;
            }

            /* for(int n =0;n<10;n++)
             {
                 Console .WriteLine (num[n]);
             }*/
            int max = num[0];
            for (int n = 1; n < 10; n++)
            {
                if (max < num[n])
                    max = num[n];

            }
            Console.WriteLine("最大值是{0}", max);
            int min = num[0];

            for (int a = 1; a < 10; a++)
            {
                if (min > num[a])
                    min = num[a];
            }
            Console.WriteLine("最小值是{0}", min);
            int all = 0;
            for (int h = 0; h < 10; h++)
            {
                all = all + num[h];
            }
            double average = all / 10;
            double sum = all;
            Console.WriteLine("平均值是{0}", average);
            Console.WriteLine("和是{0}", sum);
            Console.ReadKey(false);
        }
    }
}
