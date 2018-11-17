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
        //显式异步调用
        
        static void Main(string[] args)
        {
            Student stu1 = new Student() { ID = 1, PenColor = ConsoleColor.Red };
            Student stu2 = new Student() { ID = 2, PenColor = ConsoleColor.Yellow };
            Student stu3 = new Student() { ID = 3, PenColor = ConsoleColor.Gray };

            //方法一：
            //Thread thread1 = new Thread(new ThreadStart(stu1.DoHomeWork));
            //Thread thread2 = new Thread(new ThreadStart(stu2.DoHomeWork));
            //Thread thread3 = new Thread(new ThreadStart(stu3.DoHomeWork));

            //thread1.Start();
            //thread2.Start();
            //thread3.Start();

            //方法二
            Task task1 = new Task(new Action(stu1.DoHomeWork));
            Task task2 = new Task(new Action(stu2.DoHomeWork));
            Task task3 = new Task(new Action(stu3.DoHomeWork));

            task1.Start();
            task2.Start();
            task3.Start();

            for (int i = 0; i < 10; i++)
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
