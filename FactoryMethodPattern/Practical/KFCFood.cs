using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Practical
{
    /// <summary>
    /// 抽象的KFC食品，Product角色
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
