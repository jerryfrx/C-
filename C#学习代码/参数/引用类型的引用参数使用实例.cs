using System;

//引用类型的引用参数使用实例
namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Student oldstu = new Student() { Name="jerry"};
            Console.WriteLine("Hashcode={0},name={1}", oldstu.GetHashCode(), oldstu.Name);
            Console.WriteLine("=========================================");
            SomeMethod(ref oldstu);
            Console.WriteLine("Hashcode={0},name={1}", oldstu.GetHashCode(), oldstu.Name);
            
            Console.ReadLine();
        }
        static void SomeMethod(ref Student stu)
        {
            stu = new Student() { Name="lyn"};
            Console.WriteLine("Hashcode={0},name={1}",stu.GetHashCode(),stu.Name);
        }
        class Student
        {
            public string Name { get; set; }
        }
    }
}
