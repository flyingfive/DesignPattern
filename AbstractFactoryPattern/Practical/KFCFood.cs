using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Practical
{
    /// <summary>
    /// Product族1，KFC食品
    /// </summary>
    public abstract class KFCFood
    {
        public abstract void Display();
    }

    public class Chicken : KFCFood
    {
        public override void Display()
        {
            Console.WriteLine("鸡腿 + 1");
        }
    }

    public class Wings : KFCFood
    {
        public override void Display()
        {
            Console.WriteLine("鸡翅 + 1");
        }
    }
}
