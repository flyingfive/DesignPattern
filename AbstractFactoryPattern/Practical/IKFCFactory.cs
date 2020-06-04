using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Practical
{
    /// <summary>
    /// 抽象工厂，生产套餐
    /// </summary>
    public interface IKFCFactory
    {
        KFCFood CreateFood();
        KFCDrink CreateDrink();
    }

    /// <summary>
    /// 经济型套餐，包括鸡翅和可乐
    /// </summary>
    public class CheapPackageFactory : IKFCFactory
    {
        public KFCFood CreateFood()
        {
            return new Wings();
        }
        public KFCDrink CreateDrink()
        {
            return new Coke();
        }
    }

    /// <summary>
    /// 豪华型套餐，包括鸡腿和咖啡
    /// </summary>
    public class LuxuryPackageFactory : IKFCFactory
    {
        public KFCFood CreateFood()
        {
            return new Chicken();
        }

        public KFCDrink CreateDrink()
        {
            return new Coffee();
        }
    }
}
