using System;
//通过传进来的参数修改其所引用的对象的值的情况叫做方法的副作用side-effect ,实际中应尽量避免
//方法的主要作用还是返回值

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Student oldstu = new Student() { Name="jerry"};
            SomeMethod(oldstu);
            Console.WriteLine("Hashcode={0},name={1}", oldstu.GetHashCode(), oldstu.Name);
            
            Console.ReadLine();
        }
        static void SomeMethod(Student stu)
        {
            stu.Name = "lyn";
            Console.WriteLine("Hashcode={0},name={1}",stu.GetHashCode(),stu.Name);
        }
        class Student
        {
            public string Name { get; set; }
        }
    }
}
