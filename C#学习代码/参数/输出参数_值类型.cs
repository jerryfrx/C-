using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

//模拟输出参数方法
namespace ConsoleApp5
{
    class Program
    {        
        static void Main(string[] args)
        {
            double x = 0;
            string input = Console.ReadLine();
            bool b = DoubleParse.TryParse(input, out x);
            if(b == true)
            {
                Console.WriteLine("{0}",x);
            }
            Console.ReadLine();
        }
    }
    class DoubleParse
    {
        public static bool TryParse(string input,out double result)
        {
            try
            {
                result = double.Parse(input);
                return true;
            }
            catch
            {
                result = 0;
                return false;
            }
        }
    }
}