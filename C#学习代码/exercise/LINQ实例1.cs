//统计数字n转换成2进制后，有多少个1
using System;
using System.Linq;

namespace ConsoleApp14 {
    class Program {
        public static void Main(string[] args ) {
            int n = 100;
            var count = Convert.ToString(n,2).Count(x=>x=='1');
            Console.WriteLine(count);
        }
    }
}