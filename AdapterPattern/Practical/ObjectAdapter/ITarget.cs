using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Practical.ObjectAdapter
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
    public class Adapter : ITarget
    {
        public Power _power;
        public Adapter(Power power)
        {
            this._power = power;
        }

        /// <summary>
        /// 得到想要的电压
        /// </summary>
        public void GetPower()
        {
            _power.GetPower220V();
            Console.WriteLine("得到手机的充电电压！");
        }
    }
    public class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("手机：");
            ITarget t = new Adapter(new Power());
            t.GetPower();
        }
    }
}
