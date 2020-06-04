using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Practical.ClassAdapter
{
    public interface ITarget
    {
        void GetPower();
    }
    public class Power
    {
        public void GetPower220V()
        {
            Console.WriteLine("从电源中得到220V的电压");
        }
    }
    public class Adapter : Power, ITarget
    {
        public void GetPower()
        {
            this.GetPower220V();
            Console.WriteLine("得到手机的充电电压！");
        }
    }
    public class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("手机：");
            ITarget t = new Adapter();
            t.GetPower();
        }
    }
}
