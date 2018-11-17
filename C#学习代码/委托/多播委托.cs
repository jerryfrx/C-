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
        //多播委托
        
        static void Main(string[] args)
        {
            Student stu1 = new Student() { ID = 1, PenColor = ConsoleColor.Red };
            Student stu2 = new Student() { ID = 2, PenColor = ConsoleColor.Yellow };
            Student stu3 = new Student() { ID = 3, PenColor = ConsoleColor.Cyan };

            Action act1 = new Action(stu1.DoHomeWork);
            Action act2 = new Action(stu2.DoHomeWork);
            Action act3 = new Action(stu3.DoHomeWork);

            //act1.Invoke();
            //act2.Invoke();
            //act3.Invoke();

            //多播委托
            act1 += act2;
            act1 += act3;
            act1.Invoke();
            //Console.ReadLine();
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
