using System;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

//依赖注入
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var sc = new ServiceCollection();
            sc.AddScoped(typeof(ITank),typeof(HeavyTank));
            sc.AddScoped(typeof(IVechicle), typeof(Car));
            sc.AddScoped<Driver>();
            var sp = sc.BuildServiceProvider();
            //=======分割线=============
            var tank = sp.GetService<ITank>();
            tank.Run();
            tank.Fire();

            var driver = sp.GetService<Driver>();
            driver.Drive();
            Console.ReadLine();
        }
    }
    public interface IVechicle
    {
        void Run();
    }
    class Driver
    {
        private IVechicle _vechile;
        public Driver(IVechicle vechicle)
        {
            _vechile = vechicle;
        }
        public void Drive()
        {
            _vechile.Run();
        }
    }
    class Car : IVechicle
    {
        public void Run()
        {
            Console.WriteLine("bababababab");
        }
    }
    interface IWeapon
    {
        void Fire();
    }
    interface ITank : IWeapon, IVechicle
    {
    }
    class LightTank : ITank
    {
        public void Run()
        {
            Console.WriteLine("ka ka ka ka");
        }
        public void Fire()
        {
            Console.WriteLine("boo boo boo");
        }
    }
    class HeavyTank : ITank
    {
        public void Run()
        {
            Console.WriteLine("kaaa kaaaa kaaaa kaaaa");
        }
        public void Fire()
        {
            Console.WriteLine("boo!!! boo!!! boo!!!");
        }
    }

}
    