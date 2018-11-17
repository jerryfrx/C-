using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //C#类库中提供的最常用的两种委托Action 和 Func

            Calculator cal = new Calculator();
            Action act = new Action(cal.Report);

            //act();
            act.Invoke();

            Func<int, int, int> func1 = new Func<int, int, int>(cal.Add);
            Func<int, int, int> func2 = new Func<int, int, int>(cal.Sub);

            Console.WriteLine(func1.Invoke(100,200));
            Console.WriteLine(func2.Invoke(100,200));

            Console.ReadLine();
        }
    }
    class Calculator
    {
        public void Report()
        {
            Console.WriteLine("I have 3 Methods");
        }

        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Sub(int a ,int b)
        {
            return a - b;
        }
    }
}
