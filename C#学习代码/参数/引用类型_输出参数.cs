using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

//引用类型的输出参数
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = null;
            bool b = StudentFactory.Create("jerry",19,out stu);
            Console.WriteLine("Student {0} is {1} years old!",stu.Name,stu.Age);
            Console.ReadLine();
        }
    }
    class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
    class StudentFactory
    {
        public static bool Create(string stuName,int stuAge,out Student result)
        {
            result = null;
            if (string.IsNullOrEmpty(stuName))
            {
                return false;
            }

            if (stuAge < 18 && stuAge > 80)
            {
                return false;
            }

            result = new Student() { Age = stuAge, Name = stuName };
            return true;
        }
    }
}
