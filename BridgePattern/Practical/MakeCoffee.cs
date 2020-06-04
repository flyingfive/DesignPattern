using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Practical
{
    public abstract class MakeCoffee
    {
        public abstract void Making();
    }

    /// <summary>
    /// 单件模式类用来加载当前MakeCoffee
    /// </summary>
    public sealed class MakeCoffeeSingleton
    {
        private static MakeCoffee _instance;

        public MakeCoffeeSingleton(MakeCoffee instance)
        {
            _instance = instance;
        }

        public static MakeCoffee Instance()
        {
            return _instance;
        }
    }

    public abstract class Coffee
    {
        private MakeCoffee _makeCoffee;

        public Coffee()
        {
            _makeCoffee = MakeCoffeeSingleton.Instance();
        }

        public MakeCoffee MakeCoffee()
        {
            return this._makeCoffee;
        }

        public abstract void Make();
    }
    /// <summary>
    /// 原味咖啡
    /// </summary>
    public class BlackCoffee : MakeCoffee
    {
        public override void Making()
        {
            Console.WriteLine("原味咖啡");
        }
    }
    /// <summary>
    /// 牛奶咖啡
    /// </summary>
    public class WhiteCoffee : MakeCoffee
    {
        public override void Making()
        {
            Console.WriteLine("牛奶咖啡");
        }
    }
    /// <summary>
    /// 中杯
    /// </summary>
    public class MediumCupCoffee : Coffee
    {
        public override void Make()
        {
            MakeCoffee makeCoffee = this.MakeCoffee();
            Console.Write("中杯");
            makeCoffee.Making();
        }
    }
    /// <summary>
    /// 大杯
    /// </summary>
    public class LargeCupCoffee : Coffee
    {
        public override void Make()
        {
            MakeCoffee makeCoffee = this.MakeCoffee();
            Console.Write("大杯");
            makeCoffee.Making();
        }
    }
    class Client
    {
        static void Main(string[] args)
        {
            MakeCoffeeSingleton whiteCoffeeSingleton = new MakeCoffeeSingleton(new WhiteCoffee());

            // 中杯牛奶咖啡
            MediumCupCoffee mediumWhiteCoffee = new MediumCupCoffee();
            mediumWhiteCoffee.Make();

            // 大杯牛奶咖啡
            LargeCupCoffee largeCupWhiteCoffee = new LargeCupCoffee();
            largeCupWhiteCoffee.Make();

            MakeCoffeeSingleton blackCoffeeSingleton = new MakeCoffeeSingleton(new BlackCoffee());
            // 中杯原味咖啡
            MediumCupCoffee mediumBlackCoffee = new MediumCupCoffee();
            mediumBlackCoffee.Make();

            // 大杯牛奶咖啡
            LargeCupCoffee largeCupBlackCoffee = new LargeCupCoffee();
            largeCupBlackCoffee.Make();
        }
    }
}
