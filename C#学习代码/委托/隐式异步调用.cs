using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        //隐式异步调用
        
        static void Main(string[] args)
        {
            Student stu1 = new Student() { ID = 1, PenColor = ConsoleColor.Red };
            Student stu2 = new Student() { ID = 2, PenColor = ConsoleColor.Yellow };
            Student stu3 = new Student() { ID = 3, PenColor = ConsoleColor.Gray };

            Action act1 = new Action(stu1.DoHomeWork);
            Action act2 = new Action(stu2.DoHomeWork);
            Action act3 = new Action(stu3.DoHomeWork);

            act1.BeginInvoke(null, null);
            act2.BeginInvoke(null, null);
            act3.BeginInvoke(null, null);

            for(int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("This is main thread {0}", i);
                Thread.Sleep(1000);
            }
            Console.ReadLine();
        }
    }
    class Student
    {
        public int ID{ get; set; }
        public ConsoleColor PenColor { get; set; }
        public void DoHomeWork()
        {
            for(int i=0;i < 5 ; i++){
                Console.ForegroundColor = this.PenColor;
                Console.WriteLine("Student{0} doning homework {1} hours",this.ID,i);
                Thread.Sleep(1000); 
            }
        }

    }  
}
