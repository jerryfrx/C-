using System;
using System.Collections;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;


//依赖注入示例
//依赖注入需要使用nuget导入依赖注入框架Microsoft.Extensions.DependencyInjection
//并且要using Microsoft.Extensions.DependencyInjection
//依赖注入的关键是依托于一个容器
//把各种各样的类型以及对应的接口都放到容器里面，容器也叫ServiceProvider
namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            //ITank是静态类型，typeof后才能拿到动态的类型描述
            //AddScoped方法有多种重载，这里调用的是第一个参数为一个类型，第二个参数为谁实现了这个类型
            serviceCollection.AddScoped(typeof(ITank),typeof(HeavyTank));
            serviceCollection.AddScoped(typeof(IVehicle), typeof(Car));
            serviceCollection.AddScoped<Driver>();
            var serviceProvider = serviceCollection.BuildServiceProvider();
            //-------------------以上为注册-------------------------------
            ITank tank = serviceProvider.GetService<ITank>();
            tank.Fire();
            tank.run();
            //--------------------------------------------------------------
            Driver driver = serviceProvider.GetService<Driver>();
            driver.Drive();
        }
    }
    class Driver
    {
        private IVehicle _vehicle;
        public Driver(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }
        public void Drive()
        {
            _vehicle.run();
        }
    }
    interface IVehicle
    {
        void run();
    }
    class Car : IVehicle
    {
        public void run()
        {
            Console.WriteLine("car is running");
        }
    }
    class Truck : IVehicle
    {
        public void run()
        {
            Console.WriteLine("Truck is running");
        }
    }
    interface IWeapon
    {
        void Fire();
    }
    interface ITank : IVehicle, IWeapon
    {

    }
    class LightTank : ITank
    {
        public void Fire()
        {
           Console.WriteLine("boo boo boo");
        }

        public void run()
        {
            Console.WriteLine("ka ka ka");
        }
    }
    class HeavyTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("boooo booooo booooo");
        }

        public void run()
        {
            Console.WriteLine("kaaa kaaa kaaa");
        }
    }
}
