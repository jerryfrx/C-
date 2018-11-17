using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp5
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            Boy boy = new Boy();
            Girl girl = new Girl();

            //订阅事件 +=  (一个事件有两个事件处理器)
            //Action是响应者的时间处理器
            timer.Elapsed += boy.Action;
            timer.Elapsed += girl.Action;

            timer.Start();
            Console.ReadLine();
        }
    }
    class Boy
    {
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Jump!");
        }
    }
    class Girl
    {
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Sing!");
        }
    }
}
