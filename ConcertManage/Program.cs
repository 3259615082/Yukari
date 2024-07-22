using System;
namespace ConcertManage 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "演唱会举办信息管理";
            Console.Write("请输入艺人名称：");
            string name=Console.ReadLine();
            Console.Write("请输入艺人性别：");
            string sex=Console.ReadLine();
            while (true)
            {
                Console.Write("请输入演唱会类型：");
                string type = Console.ReadLine();
                if(type=="小型演唱会")
                {
                    break;
                }
                else if(type=="中型演唱会")
                {
                    break;
                }
                else if(type=="大型演唱会")
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("演唱会类型只能输入小型演唱会、中型演唱会和大型演唱会！");
                    Console.ResetColor();
                }
            }
            Console.Write("请输入演唱会举办时间：");
            DateTime time= DateTime.Parse(Console.ReadLine());
            Console.Write("请输入演唱会举办地址：");
            string add= Console.ReadLine();
            Console.Write("请输入赞助商赞助金额（万元）：");
            int zzje=int.Parse(Console.ReadLine());
            while (true)
            {
                if(zzje>=30)
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("演唱会赞助商赞助金额至少30万元起步！");
                    Console.ResetColor(); 
                }
            }
            Console.WriteLine($"艺人名称：{name}\t性别：{sex}\t");
        }
    }
}

