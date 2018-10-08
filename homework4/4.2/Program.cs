using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication2
{
    class Order
    {
        public int Sno, Sage, Sclass;
        public string Sname, Ssex, Sdept;
        public DateTime Sbirth;

    }

    class OrderDetails
    {

        public static List<Order> Orders;
        public static int Count
        {
            get
            {
                return Orders.Count;
            }
        }

        static OrderDetails()
        {
            Orders = new List<Order>();
        }

        public static Order Information()
        {
            Order myOrder = new Order();
            Console.WriteLine("请输入要添加的订单信息：");
            Console.WriteLine("\n请输入订单号：");
            myOrder.Sno = int.Parse(Console.ReadLine());
            Console.WriteLine("\n请输入商品名称：");
            myOrder.Sname = Console.ReadLine();
            Console.WriteLine("\n请输入客户：");
            myOrder.Sdept = Console.ReadLine();


            return myOrder;

        }
        public void ShowStuInfo(Order myOrder)
        {
            if (myOrder == null) return;
            Console.WriteLine("订单的信息是: ");
            Console.Write("订单号:{0}", myOrder.Sno);
            Console.Write("\n商品名称: {0}", myOrder.Sname);
            Console.Write("\n客户:{0}", myOrder.Sdept);
            Console.WriteLine();
        }
        public Order Search(int Sno)
        {

            for (int i = 0; i < Orders.Count; i++)
            {
                if (Orders[i].Sno == Sno)
                {
                    return Orders[i];
                }

            }
            return null;

        }

        public void ADD(Order myOrder)
        {
            if (myOrder != null)
            {
                Orders.Add(myOrder);
                Console.WriteLine("我们现在有{0}名订单信息", Orders.Count);
            }
            else
                Console.WriteLine("信息有误,请核对后重新输入！");

        }

        public void Delete(int Sno)
        {
            Order Stu = Search(Sno);
            if (Stu != null)
            {
                Orders.Remove(Stu);
                Console.WriteLine("已经删除订单号为{0}的订单", Sno);
                Console.WriteLine("我们现在还有{0}名订单信息", Orders.Count);
            }
            else
                Console.WriteLine("未找到你要删除的订单，请核对后重新输入！");
        }

        public void Volume()
        {
            Console.WriteLine("查询到订单的总数为{0}", Orders.Count);
        }

        public static Order[] Search(string Sname)
        {
            List<Order> stuList = new List<Order>();

            for (int i = 0; i < Orders.Count; i++)
            {
                if (Orders[i].Sname == Sname)
                {
                    stuList.Add(Orders[i]);
                }
            }

            return stuList.ToArray();
        }
    }
    class Operate//用户操作类
    {
        public void Check()
        {
            do
            {
                Console.WriteLine
                ("请选择所要操作的种类：\n1、添加订单信息 \n2、删除订单信息 \n3、查询订单人数 \n4、查询订单信息（按订单号） \n5、查询订单信息（按商品名称）");
                int number = int.Parse(Console.ReadLine());
                if (number > 5 || number < 1)
                    Console.WriteLine("你的输入有误，请核对后重新输入");
                OrderDetails myOrderDetails = new OrderDetails();

                switch (number)
                {

                    case 1:
                        Order stu = OrderDetails.Information();
                        myOrderDetails.ADD(stu);
                        myOrderDetails.ShowStuInfo(stu);
                        break;
                    case 2:
                        Console.WriteLine("请输入你要删除的订单信息：");
                        Console.WriteLine("请输入订单的订单号：");
                        int Sno = int.Parse(Console.ReadLine());
                        myOrderDetails.Search(Sno);
                        myOrderDetails.Delete(Sno);
                        break;
                    case 3:
                        myOrderDetails.Volume();
                        break;
                    case 4:
                        Console.WriteLine("请输入你要查询的订单信息：");
                        Console.WriteLine("请输入订单的订单号：");
                        Sno = int.Parse(Console.ReadLine());
                        myOrderDetails.Search(Sno);
                        stu = myOrderDetails.Search(Sno);
                        myOrderDetails.ShowStuInfo(stu);
                        break;
                    case 5:
                        Console.WriteLine("请输入你要查询的订单信息：");
                        Console.WriteLine("请输入订单的商品名称：");
                        string Sname = Console.ReadLine();
                        Order[] stuList = OrderDetails.Search(Sname);
                        for (int i = 0; i < stuList.Length; i++)
                        {
                            myOrderDetails.ShowStuInfo(stuList[i]);
                        }
                        break;
                }
                Console.Write("Do you want to continue?(y/n)");
                if (Console.ReadLine() != "y")
                    break;

            } while (true);

        }

    }
    class Test//应用类
    {

        public static void Main(string[] args)
        {
            Operate myOperate = new Operate();
            myOperate.Check();
        }

    }
}