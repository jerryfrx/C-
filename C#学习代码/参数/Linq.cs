using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Linq;

//Linq的使用，lamda表达式，扩展方法
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 10, 11, 12, 32, 12 };
            bool result = myList.All(list => list >= 10);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

}
