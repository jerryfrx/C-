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
            ////lamda表达式赋值给委托类型
            //Func<int, int, int> func = new Func<int, int, int>((int a,int b) => { return a + b; });
            //Console.WriteLine(func(1, 2));
            ////简化1
            //func = new Func<int, int, int>((a,b)=> { return a + b; });
            //Console.WriteLine(func(1, 2));
            ////简化2
            //func = (a, b) => { return a + b; };
            //Console.WriteLine(func(1, 2));
            
            var result = DoSomeCalc<int>((a, b) => { return a + b; }, 1, 2);
            //简化，泛型的类型推断
            result = DoSomeCalc((a, b) => { return a + b; }, 1, 2);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static T DoSomeCalc<T>(Func<T, T, T> func,T a,T b)
        {
            return func(a, b);
        }
    }
}

