using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var fan = new DeskFan(new PowerSupply());
            Console.WriteLine(fan.Work());
            Console.ReadLine();
        }
    }
    //紧耦合 -> 逐渐解耦
    //电扇工作实例，电扇依赖于电源，所以会紧耦合
    class PowerSupply
    {
        public int GetPower()
        {
            return 100;
        }
    }
    class DeskFan
    {
        //紧耦合
        private PowerSupply _powerSupply;
        public DeskFan(PowerSupply powerSupply)
        {
            _powerSupply = powerSupply;
        }
        public string Work()
        {
            int power = _powerSupply.GetPower();
            if(power <= 0)
            {
                return "wont work!";
            }else if(power < 100)
            {
                return "slow";
            }else if(power < 200)
            {
                return "work fine";
            }
            else
            {
                return "warnning!";
            }
        }
    }   

}

