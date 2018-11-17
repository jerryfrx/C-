using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

//params关键字，简化数组
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //方法一
            //int[] array = new int[]{1,2,3};
            //var result = CaculateSum(array);
            //Console.WriteLine(result);
            //Console.ReadLine();

            //方法二，使用params关键字          
            var result = CaculateSum(1,2,3);
            Console.WriteLine(result);
            Console.ReadLine();

        }
        //static int CaculateSum(int[] intArray)
        //{
        //    int sum = 0;
        //    foreach (var item in intArray)
        //    {
        //        sum += item;
        //    }
        //    return sum;
        //}
        static int CaculateSum(params int[] intArray)
        {
            int sum = 0;
            foreach (var item in intArray)
            {
                sum += item;
            }
            return sum;
        }
    }   
}
