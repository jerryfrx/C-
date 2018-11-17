using System;
using System.Collections;


//接口的显示实现
namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var wk = new WarmKiller();
            //只有当IKill对象来引用WarmKiller的实例时，才能调用Kill方法
            IKill ki = wk;
            ki.Kill();
        }
    }
    interface IGentleman
    {
        void Love();
    }
    interface IKill
    {
        void Kill();
    }
    class WarmKiller : IGentleman, IKill
    {
        public void Love()
        {
            Console.WriteLine("love .......");
        }
        void IKill.Kill()
        {
            Console.WriteLine("kill .......");
        }
    }
}
