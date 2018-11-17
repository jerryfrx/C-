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

    //利用接口进行解耦
    public interface IPowerSupply
    {
        int GetPower();
    }

   
    public class PowerSupply : IPowerSupply
    {
        public int GetPower()
        {
            return 100;
        }
    }
    public class DeskFan
    {       
        private IPowerSupply _powerSupply;

        public DeskFan(IPowerSupply powerSupply)
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

