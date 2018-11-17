using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

//具名参数
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInfo("jerry", 18);

            PrintInfo(age: 18, name: "jerry");

            Console.ReadLine();
        }
        
        static void PrintInfo(string name,int age)
        {
            Console.WriteLine("Hello {0},you are {1}",name,age);
        }
    }   
}
