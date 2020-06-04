using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Practical
{
    public interface IKFCFactory
    {
        KFCFood CreateFood();
    }
    public class ChickenFactory : IKFCFactory
    {
        public KFCFood CreateFood()
        {
            return new Chicken();
        }
    }
    public class WingsFactory : IKFCFactory
    {
        public KFCFood CreateFood()
        {
            return new Wings();
        }
    }
}
