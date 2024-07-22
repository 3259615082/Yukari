using System;
namespace WagesManage
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "快递员工资计算";
            Console.Write("请输入快递员工号：");
            string id = Console.ReadLine();
            Console.Write("请输入快递员名称：");
            string name = Console.ReadLine();
            Console.Write("请输入快递员年龄：");
            int nl = int.Parse(Console.ReadLine());
            Console.Write("入职时长（年）：");
            int year = int.Parse(Console.ReadLine());
            Console.Write("薪资（月）：");
            int money = int.Parse(Console.ReadLine());
            int sum = year * 12 * money;
            Console.WriteLine($"工号：{id}\t名称：{name}\t年龄：{nl}\t入职时长：{year}\t月薪：{money}\t累计收入：{sum}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1.金牌快递员");
            Console.WriteLine("2.银牌快递员");
            Console.WriteLine("3.铜牌快递员");
            Console.ResetColor();
            Console.Write("请输入快递员等级编号：");
            int bh=int.Parse(Console.ReadLine());
            switch (bh)
            {
                case 1:
                    Console.WriteLine($"员工：{name}是金牌快递员，年终奖为12000元 2023年年收入为：{money*12+12000}元");
                    break;
                case 2:
                    Console.WriteLine($"员工：{name}是银牌快递员，年终奖为10000元 2023年年收入为：{money * 12 + 10000}元");
                    break;
                case 3:
                    Console.WriteLine($"员工：{name}是铜牌快递员，年终奖为8000元 2023年年收入为：{money * 12 + 8000}元");
                    break;
                default:
                    break;
            }

        }
    }
}
