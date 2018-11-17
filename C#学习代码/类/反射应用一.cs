using System;
using System.Collections;
using System.Reflection;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Driver driver = new Driver(new LightTank());
            //driver.Drive();
            ITank tank = new HeavyTank();
            //----------反射-----------------
            //GetType得到的是动态类型描述，动态类型就是程序运行时在内存中与之关联的动态描述信息
            var t = tank.GetType();
            //当有动态类型时（t），就可以用其去创建object对象
            object o = Activator.CreateInstance(t);
            MethodInfo runMi = t.GetMethod("run");
            MethodInfo fireMi = t.GetMethod("Fire");
            runMi.Invoke(o, null);
            fireMi.Invoke(o, null);
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
