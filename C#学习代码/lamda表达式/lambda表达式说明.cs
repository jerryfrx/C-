using System;

namespace ConsoleApp13{
    class Program{
        static void Main(string[] args){
            //lambda
            //1.匿名方法
            //2.Inline方法,在调用的时候才声明的方法使Inline方法
            //系统提供的两种委托Action Func
            //如何把一个Lambda表达式赋值给委托类型变量
            //如何把一个Lambda表达式传给一个委托型参数
            Func<int, int, int> func = new Func<int, int, int>((int a,int b) => { return a + b; });
            Func<int, int, int> func1 = (a, b) => a + b;            
            Console.WriteLine( func1(1, 2));
            DoSomeCal<int>((int a,int b)=> { return a + b; },10,20);
            DoSomeCal<int>((a,b) => a * b, 10, 20);

            //LINQ：.Net language Integrated Query

        }
        //把一个Lambda表达式传给一个委托型参数
        static void DoSomeCal<T>(Func<T,T,T>func,T a,T b) {
            T res = func.Invoke(a, b);
            Console.WriteLine(res);
        }
    }
}
