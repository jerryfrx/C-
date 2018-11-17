using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

//自定义事件
namespace ConsoleApp5
{
    class Program
    {        
        static void Main(string[] args)
        {

        }
    }
    class Student
    {
        //私有字段
        private int age;

        //公有属性,属性是字段的包装器
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    age = value;
                }
                else
                {
                    throw new Exception("age set error!");
                }
            }
        }
    }
}