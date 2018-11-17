using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        //自定义委托
        //委托就是一个类，只不过声明方式和普通类不同，类似于C语言的函数指针声明
        public delegate int Calc_Delegate(int x, int y);
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            Calc_Delegate cd1 = new Calc_Delegate(cal.Add);
            Calc_Delegate cd2 = new Calc_Delegate(cal.Sub);

            Console.WriteLine(cd1.Invoke(100,200));
            Console.WriteLine(cd2.Invoke(100,200));

            Console.ReadLine();
        }
    }
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
