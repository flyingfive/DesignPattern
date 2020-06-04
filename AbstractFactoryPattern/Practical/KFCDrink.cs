using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Practical
{
    /// <summary>
    /// Product族2，KFC饮料
    /// </summary>
    public abstract class KFCDrink
    {
        public abstract void Display();
    }
    public class Coke : KFCDrink
    {
        public override void Display()
        {
            Console.WriteLine("可乐 + 1");
        }
    }
    public class Coffee : KFCDrink
    {
        public override void Display()
        {
            Console.WriteLine("咖啡 + 1");
        }
    }
}
